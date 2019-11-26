#include <iostream>
#include "NetworkingStructs.h"
#include <enet/enet.h>

/* Note that we are including both the 32-bit and 64-bit versions of SFML
(downloadable from their site) as ENet can be temperamental dependent upon OS.
The 64-bit version (with all library directories and libraries included for you)
seems to work on University computers. If it fails you may need to enable your
IDE to load symbols for DLLs (Tools -> Options -> Debugging -> Symbols, and check
the box 'Microsoft Symbol Servers' before cleaning and rebuilding the project).

REMEMBER: You don't have to use ENet for the coursework, of course, and this
example is purely illustrative. */

using namespace std;

/* We begin by creating a data structure - we're using a Vector2 in our example,
which holds two floats to represent a 2D position, but you should be able to see
how this can be replaced by any abstract data structure. It can even be replaced
with a generic bin, as was discussed in Lecture 2. */

void main()
{
	/* We begin with our SFML preamble - here, we're just setting up a simple
	background texture with instructions, and to help us be clear which window
	is the server and which is the client in our example. */

	int clientCount = 0;

	/* Now we're declaring our Vector2 - this vector will be controlling the
	position of an 'enemy' entity in the Client instance. */

	

	/* We initialise the ENet library, and double-check this has worked. We then
	declare a few library specific variables. An address (which represents the
	server address), a Host (which represents the server, i.e. this software
	instance), and an arbitrary Event. ENet is an event-driven library, and functions
	similarly to SFML in that regard. Just like we poll keyboard events from SFML's
	Event type, we can do the same for ENet's. */

	if (enet_initialize() != 0)
	{
		cout << "Enet failed to initialise!" << "\n\n";
	}

	ENetAddress address;
	ENetHost* server;
	ENetEvent enetEvent;

	ENetPacket* dataPacket;

	/* We set the address values to essentially be a local host */

	address.host = ENET_HOST_ANY;
	address.port = 1234;

	/* Now we create the server. We pass in the pointer to the address variable,
	the maximum number of clients we intend to support, the maximum number of
	channels to be used (in this case 2 channels, 0 and 1), and caps for
	upstream and downstream bandwidth (0 is uncapped). */

	server = enet_host_create(&address, 32, 2, 0, 0);
	
	/* Now we check server initialisation, before assigning some starting values
	to our position variable.*/

	if (server == NULL)
	{
		cout << "Server failed to initialise!" << "\n\n";
	}

	EntityData* physicsData = new EntityData;

	physicsData->positions.x = 600.0f;
	physicsData->positions.y = 300.0f;

	ClientData* clientData = new ClientData;

	while (1)
	{
		/* As we mentioned, ENet is event driven. This while loop checks to see if
		the server has any events to respond to. We can use the event type to
		determine how to respond to a given event. Note that there are multiple types
		of ENet event - in this example, our server is only reacting to a client
		connection being established (ENET_EVENT_TYPE_CONNECT) or a connection being
		dropped (ENET_EVENT_TYPE_DISCONNECT). Note that given our sample Client uses
		the enet_peer_disconnect_now function, there is no guarantee the server will
		detect a disconnect event - that is something you can consider improving in your
		own networking subsystem. */

		while (enet_host_service(server, &enetEvent, 0) > 0)
		{
			cout << "TEST" << endl;
			switch (enetEvent.type)
			{
			case ENET_EVENT_TYPE_CONNECT:
				
				cout << "A client connected from address " << enetEvent.peer->address.host << ":" << enetEvent.peer->address.port << ".\n";

				clientData->clientIndex = clientCount;

				dataPacket = enet_packet_create(clientData, sizeof(ClientData), ENET_PACKET_FLAG_RELIABLE);
				enet_peer_send(enetEvent.peer, 0, dataPacket);

				/* This event type has an associated peer: the client which has
				connected to the server. We can store some data about this peer
				for as long as it remains in scope using the "data" variable. */

				enetEvent.peer->data = "This is a client";
				clientCount++;

				break;
			case ENET_EVENT_TYPE_DISCONNECT:
				cout << "The client from address " << enetEvent.peer->address.host << ":" << enetEvent.peer->address.port << " disconnected \n";
				
				enetEvent.peer->data = NULL;
				
				break;

			case ENET_EVENT_TYPE_RECEIVE:
				memcpy(physicsData, enetEvent.packet->data, enetEvent.packet->dataLength);
				std::cout << "TEST";
				//physicsData->positions[clientPacket->clientIndex] = clientPacket->position;
			}
		}

		/* Basic draw functionality for SFML, making sure our texture appears. */
		dataPacket = enet_packet_create(physicsData, sizeof(EntityData), ENET_PACKET_FLAG_RELIABLE);
		enet_host_broadcast(server, 0, dataPacket);

	}

	/* We destroy the ENet Host instance, and deinitialize the library on shutdown. */

	delete physicsData;
	delete clientData;

	enet_host_destroy(server);
	atexit(enet_deinitialize);
}