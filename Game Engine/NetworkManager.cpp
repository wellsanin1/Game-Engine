#include "NetworkManager.h"
NetworkManager::NetworkManager()
{

}

void NetworkManager::ConnectHost()
{

}

void NetworkManager::Update(ObjectPool*OP,EventQueue* EQ)
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
				std::vector<std::string>::iterator it;
				it = std::find(ConnectedObjectTempStore.begin(), ConnectedObjectTempStore.end(), serverData->Name);
				if (GO->IsEmpty() == true && it == ConnectedObjectTempStore.end())
				{
					ConnectedObjectTempStore.push_back(serverData->Name);
					event E;
					E.SubSystemList.push_back(SubSystem_ObjectPool);
					E.ObjectPoolEventEnum = ObjectPool_CREATEENTITY;
					E.OD.Name = serverData->Name;
					E.OD.e_type = "entity";
					E.OD.MeshName = serverData->MeshName;
					E.OD.Material = serverData->Material;

					E.OD.positions.x = serverData->Positions.x;
					E.OD.positions.y = serverData->Positions.y;
					E.OD.positions.z = serverData->Positions.z;

					E.OD.Colliders.x = serverData->Colliders.x;
					E.OD.Colliders.y = serverData->Colliders.y;
					E.OD.Colliders.z = serverData->Colliders.z;
					EQ->AddEvent(E);
				}
				else if(GO->IsEmpty() == false)
				{


					GO->SetVelocity(serverData->Velocity.x, serverData->Velocity.y, serverData->Velocity.z);
					GO->Teleport(serverData->Positions.x,serverData->Positions.y,serverData->Positions.z);
				}
			}
			break;
		}
	}
}

void NetworkManager::SendPacket(std::string Name,std::string MeshName,std::string Material,Vector3 positions,Vector3 Colliders, Vector3 Velocity)
{
	EntityData* ED = new EntityData();
	strcpy(ED->Name, Name.c_str());
	strcpy(ED->MeshName, MeshName.c_str());
	strcpy(ED->Material, Material.c_str());
	ED->clientIndex = clientIndex;
	ED->Positions.x = positions.x;
	ED->Positions.y = positions.y;
	ED->Positions.z = positions.z;

	ED->Colliders.x = Colliders.x;
	ED->Colliders.y = Colliders.y;
	ED->Colliders.z = Colliders.z;

	ED->Velocity.x = Velocity.x;
	ED->Velocity.y = Velocity.y;
	ED->Velocity.z = Velocity.z;

	dataPacket = enet_packet_create(ED,sizeof(EntityData), ENET_PACKET_FLAG_RELIABLE);
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
	peer = enet_host_connect(client, &address, 2, 0);

	if (peer == NULL) {
		std::cout << "No available peers for initializing an ENet connection.\n";
	}
}

void NetworkManager::Restart()
{
	ConnectedObjectTempStore.clear();
}


NetworkManager::~NetworkManager()
{
}
