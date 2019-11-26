#pragma once
struct Vector3 
{
	float x;
	float y;
	float z;
};

struct EntityData 
{
	std::string Name;
	std::string MeshName;
	std::string Material;
	int packetType = 1;
	int clients;
	Vector3 positions[3];
	Vector3 Colliders[3];
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