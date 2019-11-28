#include <iostream>
#include <vector>
#include "NetworkingStructs.h"
#include <enet/enet.h>

#define PeerCount 10

using namespace std;

void main()
{

	int clientCount = 1;

	if (enet_initialize() != 0)
	{
		cout << "Enet failed to initialise!" << "\n\n";
	}

	ENetAddress address;
	ENetHost* server;
	ENetEvent enetEvent;
	ENetPacket* dataPacket;
	std::vector<ENetPeer*> PeerArray;


	address.host = ENET_HOST_ANY;
	address.port = 1234;

	server = enet_host_create(&address, 32, 2, 0, 0);
	

	if (server == NULL)
	{
		cout << "Server failed to initialise!" << "\n\n";
	}

	EntityData* physicsData = new EntityData;
	ClientData* clientData = new ClientData;

	while (1)
	{

		while (enet_host_service(server, &enetEvent, 0) > 0)
		{
			ENetPeer* TempPeer;
			switch (enetEvent.type)
			{
			case ENET_EVENT_TYPE_CONNECT:
				
				cout << "A client connected from address " << enetEvent.peer->address.host << ":" << enetEvent.peer->address.port << ".\n";

				clientData->clientIndex = clientCount;

				PeerArray.push_back(enetEvent.peer);
				dataPacket = enet_packet_create(clientData, sizeof(ClientData), ENET_PACKET_FLAG_RELIABLE);
				enet_peer_send(enetEvent.peer, 0, dataPacket);

				enetEvent.peer->data = "This is a client";
				clientCount++;

				break;
			case ENET_EVENT_TYPE_DISCONNECT:
				cout << "The client from address " << enetEvent.peer->address.host << ":" << enetEvent.peer->address.port << " disconnected \n";
				clientCount--;
				enetEvent.peer->data = NULL;
				for (int i = 0; i < PeerArray.size(); ++i)
				{
					if (PeerArray[i] == enetEvent.peer)
					{
						PeerArray.erase(PeerArray.begin()+i);
						break;
					}
				}
				
				break;

			case ENET_EVENT_TYPE_RECEIVE:
				memcpy(physicsData, enetEvent.packet->data, enetEvent.packet->dataLength);
				for (int i = 0 ; i<PeerArray.size() ; ++i)
				{
					if (enetEvent.peer != PeerArray[i])
					{
						char IntergerString[32];
						int integer = physicsData->clientIndex;
						sprintf_s(IntergerString, "%d", integer);

						char PostFix[100] = "(Online)";
						strcat_s(PostFix, IntergerString);
						strcat_s(physicsData->Name, PostFix);
						dataPacket = enet_packet_create(physicsData, sizeof(EntityData), ENET_PACKET_FLAG_RELIABLE);
						enet_peer_send(PeerArray[i], 0, dataPacket);
					}
				}
			}
		}
	}

	delete physicsData;
	delete clientData;

	enet_host_destroy(server);
	atexit(enet_deinitialize);

}