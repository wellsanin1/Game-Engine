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
	void SendPacket(std::string Name, std::string MeshName, std::string Material, Vector3 positions, Vector3 Colliders);
	void Initiate();
private:
	ENetAddress address;
	ENetHost* client;
	ENetPeer* peer;
	ENetEvent enetEvent;

	EntityData* serverData = new EntityData;
	ClientData* clientData = new ClientData;
	ClientPacket* clientPacket = new ClientPacket;
	ENetPacket* dataPacket;
	int* packetType = new int;
	int clientIndex = -1;

	void ConnectHost();

};
