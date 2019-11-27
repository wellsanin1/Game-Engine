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
	char Name[30];
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
};

struct ClientPacket
{
	int clientIndex;
	int direction;
};