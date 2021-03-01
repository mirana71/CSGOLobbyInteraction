using SteamKit2;
using System;
using SteamKit2.GC;
using SteamKit2.GC.CSGO.Internal;


        public void InviteToLobby(ulong _steamId, ulong lobbyId);
        {
            if (inLobby()) // you must be in lobby to do that
            {
                var inviteRequest = new ClientMsgProtobuf<CMsgClientMMSInviteToLobby>(EMsg.ClientMMSInviteToLobby);
                inviteRequest.ProtoHeader.routing_appid = 730;
                inviteRequest.Header.Proto.routing_appid = 730;
                inviteRequest.Body.app_id = 730;
                inviteRequest.Body.steam_id_lobby = lobbyId;
                inviteRequest.Body.steam_id_user_invited = _steamId;
                Client.Send(inviteRequest);

                Console.WriteLine("Invited user : {0} to the lobby : {1}", _steamId, lobbyId);

            }
        }
