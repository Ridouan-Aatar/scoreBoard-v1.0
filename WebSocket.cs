using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using WebSocketSharp;
using WebSocketSharp.Server;

namespace ScoreBoard
{
    public class Echo : WebSocketBehavior
    {

        //public const string[] messageType = "UpdateOverlay";
        public string answer = @"{'messageType':'IdentificationAnswer','identity':null,'type':'GameOverlay','name':'SmashUltimateSingles','tempToken':null}";
        


        protected override void OnMessage(MessageEventArgs e)
        {
            
            Console.WriteLine("Message Rcievied : \n" + e.Data);
            dynamic data = JObject.Parse(e.Data);
            if (data.messageType != "OverlayDisconnecting"&& data.tempToken!="null")
            {
                dynamic dataAnswer = JObject.Parse(answer);
                dataAnswer.identity = ++WebSocket._idCounter;
                dataAnswer.tempToken = data.tempToken;
                int id = dataAnswer.identity;

                Send(dataAnswer.ToString(Newtonsoft.Json.Formatting.None));
                WebSocket._OverlayAdd(id );
            }
            if (data.messageType == "OverlayDisconnecting" )
            {
                int id = data.identity;
                WebSocket._OverlayDelete(id);
            }


            //Program._idCounter++;

        }
    }
     public class WebSocket
    {
        private const string url = "ws://127.0.0.1:80";
        private WebSocketServer wsv;
        public string updateReq = @"{'messageType':'UpdateOverlay','name':'SmashUltimateSingles'}";
        public string updateReq2 = @"{'messageType':'UpdateCard','name':'SmashUltimateSingles'}";
        public bool isOpen = false;

        private static List<int> _Overlays = new List<int>();

        public static int _idCounter = 0;
        public void Start()
        {
            wsv = new WebSocketServer(url);

            wsv.Start();
            wsv.AllowForwardedRequest = true;
            wsv.AddWebSocketService<Echo>("/");
            isOpen = true;
        }
        public void Update(int mode = 0 )
        {

            dynamic dataReq = JObject.Parse( (mode == 0) ? updateReq : updateReq2);
            wsv.WebSocketServices.Broadcast(dataReq.ToString(Newtonsoft.Json.Formatting.None));
        }
        public void Stop()
        {
            if (wsv.IsListening)
            {
                wsv.Stop();
                isOpen = false;
            }
                
        }

        public static void _OverlayAdd(int overlayId)
        {
            _Overlays.Add(overlayId);
            foreach (var item in _Overlays)
            {
                Console.WriteLine(item);
            }
        }
        public static void _OverlayDelete(int overlayId)
        {
            _Overlays.Remove(overlayId);
        }
        public static int _OverlayCount()
        {
            return _Overlays.Count;
        }
    }
}
