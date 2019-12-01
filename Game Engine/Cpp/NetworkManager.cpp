#include "NetworkManager.h"
NetworkManager::NetworkManager()
{

}

void NetworkManager::ConnectHost()
{

}

void NetworkManager::Update(ObjectPool* OP, EventQueue* EQ)
{
	for (int i = 0; i < EQ->Queue.size(); ++i)
	{
		event EV = EQ->CheckQueueReturnEvent(SubSystem_Network);
		if (EV.Empty == false)
		{
			Reactions A = EventReactions[(int)EV.NetworkEventType];
			(this->*A)(EV.ND);
			EQ->RemoveFromQueue(SubSystem_Network);
		}
		else
		{
			break;
		}

	}


	//While enet has events
	while (enet_host_service(client, &enetEvent, 0) > 0)
	{
		//For each event
		switch (enetEvent.type) 
		{
		//when a recieve event
		case ENET_EVENT_TYPE_RECEIVE:
			memcpy(packetType, enetEvent.packet->data, sizeof(int));
			if (*packetType == 0)
			{
				std::cout << "Packet Received!\n";
				memcpy(clientData, enetEvent.packet->data, sizeof(ClientData));
				//get client information for sending to server
				clientIndex = clientData->clientIndex;

			}
			else if (*packetType == 1)
			{
				memcpy(serverData, enetEvent.packet->data, sizeof(EntityData)); 

				//check object pool for gameobject by name
				GameObject* GO = OP->IfObjectExists(serverData->Name);
				std::vector<std::string>::iterator it;
				it = std::find(ConnectedObjectTempStore.begin(), ConnectedObjectTempStore.end(), serverData->Name);
				//If entity already exists
				if (GO->IsEmpty() == true && it == ConnectedObjectTempStore.end())
				{
					//Create an entity event
					ConnectedObjectTempStore.push_back(serverData->Name);
					event E;
					E.SubSystemList.push_back(SubSystem_ObjectPool);
					E.ObjectPoolEventEnum = ObjectPool_CREATEENTITY;

					E.OD.MeshName = serverData->MeshName;
					E.OD.Name = serverData->Name;
					E.OD.Material = serverData->Material;

					E.OD.e_type = "entity";

					E.OD.positions.x = serverData->Positions.x;
					E.OD.positions.y = serverData->Positions.y;
					E.OD.positions.z = serverData->Positions.z;

					E.OD.Colliders.x = serverData->Colliders.x;
					E.OD.Colliders.y = serverData->Colliders.y;
					E.OD.Colliders.z = serverData->Colliders.z;
					EQ->AddEvent(E);
					std::cout << "Created Event Named:"<<serverData->Name << std::endl;
				}
				else if(GO->IsEmpty() == false)
				{
					//Setvelocity Event
					event E;
					E.SubSystemList.push_back(SubSystem_Physics);
					E.PhysicsEventType = Physics_SETVELOCITY;
					E.PD.Name = serverData->Name;
					E.PD.GenericVector.x = serverData->Velocity.x;
					E.PD.GenericVector.y = serverData->Velocity.y;
					E.PD.GenericVector.z = serverData->Velocity.z;
					EQ->AddEvent(E);

					event E2;
					E2.SubSystemList.push_back(SubSystem_Physics);
					E2.PhysicsEventType = Physics_TELEPORT;
					E2.PD.Name = serverData->Name;
					E2.PD.positions.x = serverData->Positions.x;
					E2.PD.positions.y = serverData->Positions.y;
					E2.PD.positions.z = serverData->Positions.z;
					EQ->AddEvent(E2);
				}
			}
			break;
		}
	}
}

void NetworkManager::SendPacket(NetworkData ND)
{
	EntityData* ED = new EntityData();
	strcpy(ED->Name, ND.Name.c_str());
	strcpy(ED->MeshName, ND.MeshName.c_str());
	strcpy(ED->Material, ND.Material.c_str());
	ED->clientIndex = clientIndex;
	ED->Positions.x = ND.position.x;
	ED->Positions.y = ND.position.y;
	ED->Positions.z = ND.position.z;

	ED->Colliders.x = ND.collider.x;
	ED->Colliders.y = ND.collider.y;
	ED->Colliders.z = ND.collider.z;

	ED->Velocity.x = ND.Velocity.x;
	ED->Velocity.y = ND.Velocity.y;
	ED->Velocity.z = ND.Velocity.z;
	//send packet
	dataPacket = enet_packet_create(ED,sizeof(EntityData), ENET_PACKET_FLAG_RELIABLE);
	//send to server
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
	//remove all etities for new level
	ConnectedObjectTempStore.clear();
}

void NetworkManager::Dealloc()
{
	delete client;
	delete peer;
	delete serverData;
	delete clientData;
	delete dataPacket;
	delete packetType;
}


NetworkManager::~NetworkManager()
{
}
