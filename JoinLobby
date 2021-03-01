using SteamKit2;
using System;
using SteamKit2.GC;
using SteamKit2.GC.CSGO.Internal;

        public void JoinLobby(ulong lobbyId)
        {
            var joinRequest = new ClientMsgProtobuf<CMsgClientMMSJoinLobby>(EMsg.ClientMMSJoinLobby);
            joinRequest.ProtoHeader.routing_appid = 730;
            joinRequest.Header.Proto.routing_appid = 730;
            joinRequest.Body.app_id = 730;
            joinRequest.Body.steam_id_lobby = lobbyId;
            joinRequest.Body.persona_name = Friends.GetPersonaName();
            Client.Send(joinRequest);

            Console.WriteLine("Joining lobby with the {lobbyId} ID!");
        }
