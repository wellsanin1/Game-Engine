#pragma once
#pragma comment(lib, "Ws2_32.lib")
#pragma comment(lib, "winmm.lib")

#include "NetworkingStructs.h"
#include "ObjectPool.h"
#include <enet\enet.h>
#include <iostream>
#include <string>

class NetworkManager
{
public:
	NetworkManager();
	~NetworkManager();
	void Update(ObjectPool* OP, EventQueue* EQ);
	void SendPacket(NetworkData ND);
	void Initiate();
	void Restart();
	void Dealloc();
	 std::vector<std::string>ConnectedObjectTempStore;
private:
	ENetAddress address;
	ENetHost* client;
	ENetPeer* peer;
	ENetEvent enetEvent;

	EntityData* serverData = new EntityData;
	ClientData* clientData = new ClientData;
	ENetPacket* dataPacket;
	int* packetType = new int;
	int clientIndex = -1;

	void ConnectHost();

	typedef void (NetworkManager::* Reactions)(NetworkData ND);
	Reactions EventReactions[1] =
	{
		&NetworkManager::SendPacket
	};
};
