using SteamKit2;
using System;
using SteamKit2.GC;
using SteamKit2.GC.CSGO.Internal;

        public void CreateLobby(string _username)
        {
            var createRequest = new ClientMsgProtobuf<CMsgClientMMSCreateLobby>(EMsg.ClientMMSCreateLobby);
            createRequest.Header.Proto.routing_appid = 730; // CS:GO APPID
            createRequest.ProtoHeader.routing_appid = 730;
            createRequest.Body.app_id = 730;
            createRequest.Body.max_members = 10;
            createRequest.Body.lobby_type = 1;
            createRequest.Body.lobby_flags = 1;
            createRequest.Body.cell_id = cellId;
            createRequest.Body.persona_name_owner = Friends.GetPersonaName();
            steamClient.Send(createRequest);

            Console.WriteLine("Created a lobby with 10 slots!");
        }
