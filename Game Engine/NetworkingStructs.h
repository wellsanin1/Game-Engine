#pragma once
#include <string>

struct Vector3 
{
	float x;
	float y;
	float z;
};

struct EntityData 
{
	int packetType = 1;
	int clientIndex;
	char Name[100];
	char MeshName[30];
	char Material[30];
	int clients;
	Vector3 positions;
	Vector3 Colliders;
};

struct ClientData 
{
	int packetType = 0;
	int clientIndex;
	Vector3 position[3];
};

struct ClientPacket 
{
	int clientIndex;
	int direction;
};