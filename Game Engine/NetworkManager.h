#pragma once
#include "NetworkingStructs.h"
#include "ObjectPool.h"
#include "PhysicsManager.h"
#include "LUAHelper.h"
#include "Renderer.h"
#include <enet\enet.h>
#include <iostream>
class NetworkManager
{
public:
	NetworkManager();
	~NetworkManager();
	void Update(ObjectPool* OP, Physics* PM, LuaHelper* LH, Renderer* R);
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

	void Host();

};
