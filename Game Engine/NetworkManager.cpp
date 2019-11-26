#include "NetworkManager.h"
NetworkManager::NetworkManager()
{
	*packetType = -1;
	if (enet_initialize() != 0)
	{
		std::cout << "Enet failed to initialise!" << "\n\n";
	}
	client = enet_host_create(NULL, 1, 2, 0, 0);

	if (client == NULL)
	{
		std::cout << "Client failed to initialise!" << "\n\n";
	}
	enet_address_set_host(&address, "localhost");
	address.port = 1234;
	Host();
}

void NetworkManager::Host()
{
	peer = enet_host_connect(client, &address, 2, 0);

	if (peer == NULL) {
		std::cout << "No available peers for initializing an ENet connection.\n";
	}
}

void NetworkManager::Update(ObjectPool*OP,Physics*PM,LuaHelper*LH,Renderer*R)
{
	while (enet_host_service(client, &enetEvent, 0) > 0)
	{
		switch (enetEvent.type) {

			/* Again, we're reacting based on the detected event type. In this case, it's
			ENET_EVENT_TYPE_RECEIVE, which means our client has recieved a packet from a
			peer (in this case, the server). After quickly outputting some debug text to
			console to confirm packet receipt, what happens next is the key part.

			Our packet has some intrinsic variables - its data (what it's storing) and its
			dataLength (how much data it's storing). In this case, since we KNOW the packet
			is a Vector2, we can use the memcpy function fairly easily. This is a basic C++
			function which copies a given amount of data from one location to another. In
			this case, it copies TO newPosition FROM data, and it copies an amount dataLength.

			Given what we know about pointer arithmetic, it should be obvious to us that we
			can make these packets more sophisticated. We can make huge packets which hold
			many different kinds of data. We simply include an enumerator at the beginning of
			each data segment, saying what data type it is, and either copy that much data over
			into a variable of that type, or include as the next element of a packet the amount
			of data this variable type needs to copy. This is particularly useful when it comes
			to Part 2 of the coursework, where 'level data' is likely very different to the
			'physics data' you'll have been transmitting for Part 1. */

		case ENET_EVENT_TYPE_RECEIVE:

			memcpy(packetType, enetEvent.packet->data, sizeof(int));

			if (*packetType == 0)
			{
				std::cout << "Packet Received!\n";
				memcpy(clientData, enetEvent.packet->data, sizeof(ClientData));
				clientIndex = clientData->clientIndex;

			}
			else if (*packetType == 1)
			{
				memcpy(serverData, enetEvent.packet->data, sizeof(EntityData));
				GameObject* GO = OP->GetObjectFromPool(serverData->Name);
				if (GO == nullptr)
				{
					event EV;
					OP->CreateEntity(serverData->Name,serverData->MeshName,serverData->Material
									,serverData->positions->x, serverData->positions->y, serverData->positions->z
									,serverData->Colliders->x,serverData->Colliders->y,serverData->Colliders->z,PM,R,LH);
				}
				else
				{
					GO->SetTransform(serverData->positions->x,serverData->positions->y,serverData->positions->z);
				}
			}
			break;
		}
	}

}

NetworkManager::~NetworkManager()
{
}
