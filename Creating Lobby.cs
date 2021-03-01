using SteamKit2;
using System;
using SteamKit2.GC;
using SteamKit2.GC.CSGO.Internal;

        public void CreateLobby()
        {
            var createlobbyRequest = new ClientMsgProtobuf<CMsgClientMMSCreateLobby>(EMsg.ClientMMSCreateLobby);
            createlobbyRequest.Header.Proto.routing_appid = 730; // CS:GO APPID
            createlobbyRequest.ProtoHeader.routing_appid = 730;
            createlobbyRequest.Body.app_id = 730;
            createlobbyRequest.Body.max_members = 10;
            createlobbyRequest.Body.lobby_type = 1;
            createlobbyRequest.Body.lobby_flags = 1;
            createlobbyRequest.Body.cell_id = cellId;
            createlobbyRequest.Body.persona_name_owner = Friends.GetPersonaName();
            Client.Send(createRequest);

            Console.WriteLine("Created a lobby with 10 slots!");
        }
