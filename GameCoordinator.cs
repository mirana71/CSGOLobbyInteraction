using SteamKit2;
using System;
using SteamKit2.GC;
using SteamKit2.GC.CSGO.Internal;

namespace GameCoordinator

        void OnGCMessage(SteamGameCoordinator.MessageCallback callback)
        {
            if (callback == null)
                return;

            Console.WriteLine("OnGCMessage code : {0}", callback.EMsg));

            var messageMap = new Dictionary<uint, Action<IPacketGCMsg>>
            {
                { ( uint )EGCBaseClientMsg.k_EMsgGCClientWelcome, OnClientWelcome },
                { ( uint )ECsgoGCMsg.k_EMsgGCCStrike15_v2_MatchmakingGC2ClientHello, OnMatchmakingClientHello },
                { (uint)EMsg.ClientMMSJoinLobbyResponse, OnJoinLobbyResponse },
                { (uint)EMsg.ClientMMSCreateLobbyResponse, OnCreateLobbyResponse }
        	};
          
   async void OnClientWelcome(IPacketGCMsg packetMsg)
        {
            var msg = new ClientGCMsgProtobuf<CMsgClientWelcome>(packetMsg);

            Console.WriteLine($"MM welcomes us. Your current location: {0}", msg.Body.location.country));

            var getUser = new ClientGCMsgProtobuf<CMsgStoreGetUserData>((uint)EGCItemMsg.k_EMsgGCStoreGetUserData);
            getUser.Body.currency = 2;
            GameCoordinator.Send(storeGetUser, 730);

            var requestCoPlays = new ClientGCMsgProtobuf<CMsgGCCStrike15_v2_Account_RequestCoPlays>((uint)ECsgoGCMsg.k_EMsgGCCStrike15_v2_Account_RequestCoPlays);
            GameCoordinator.Send(requestCoPlays, 730);

            GameCoordinator.Send(getUser, 730);

            form.ToggleConnected(true);
            await Task.Delay(TimeSpan.FromSeconds(2)).ConfigureAwait(false);
        }
