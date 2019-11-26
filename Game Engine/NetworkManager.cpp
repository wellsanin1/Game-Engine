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
		switch (enetEvent.type) 
		{
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

void NetworkManager::SendPacket(std::string Name,std::string MeshName,std::string Material,Vector3 positions[3],Vector3 Colliders[3])
{
	EntityData* ED = new EntityData();
	ED->Name = Name;
	ED->MeshName = MeshName;
	ED->Material = Material;
	for (int i = 0;i<3;++i)
	{
		ED->positions[i] = positions[i];
		ED->Colliders[i] = Colliders[i];
	}
	dataPacket = enet_packet_create(ED, sizeof(EntityData), ENET_PACKET_FLAG_RELIABLE);
	enet_peer_send(peer, 0, dataPacket);
}

NetworkManager::~NetworkManager()
{
}
