#include "NetworkManager.h"
NetworkManager::NetworkManager()
{

}

void NetworkManager::ConnectHost()
{
	peer = enet_host_connect(client, &address, 2, 0);

	if (peer == NULL) {
		std::cout << "No available peers for initializing an ENet connection.\n";
	}
}

void NetworkManager::Update(ObjectPool*OP,EventQueue* EQ)
{
	ConnectHost();
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
					event E;
					E.PD.Name = serverData->Name;
					E.PD.MeshName = serverData->MeshName;
					E.PD.Material = serverData->Material;

					E.PD.positions.x = serverData->positions.x;
					E.PD.positions.y = serverData->positions.y;
					E.PD.positions.z = serverData->positions.z;

					E.PD.Colliders.x = serverData->Colliders.x;
					E.PD.Colliders.y = serverData->Colliders.y;
					E.PD.Colliders.z = serverData->Colliders.z;

					EQ->AddEvent(E);
				}
				else
				{
					GO->SetTransform(serverData->positions.x,serverData->positions.y,serverData->positions.z);
				}
			}
			break;
		}
	}
}

void NetworkManager::SendPacket(std::string Name,std::string MeshName,std::string Material,Vector3 positions,Vector3 Colliders)
{
	EntityData* ED = new EntityData();
	ED->Name = Name;
	ED->MeshName = MeshName;
	ED->Material = Material;

	ED->positions.x = positions.x;
	ED->positions.y = positions.y;
	ED->positions.z = positions.z;

	ED->Colliders.x = Colliders.x;
	ED->Colliders.y = Colliders.y;
	ED->Colliders.z = Colliders.z;

	dataPacket = enet_packet_create(ED, sizeof(EntityData), ENET_PACKET_FLAG_RELIABLE);
	enet_peer_send(peer, 0, dataPacket);
}

void NetworkManager::Initiate()
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
	ConnectHost();
}

NetworkManager::~NetworkManager()
{
}
