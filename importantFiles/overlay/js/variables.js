// Format of the Overlay (LPM based future feature)
var overlayName = "SmashUltimateSingles";

// URL the server runs on, like "http://localhost:13370"
var serverBaseUrl = "http://localhost:80";

// WebSocket protocol. Should be "ws" or "wss" when using HTTPS.
var webSocketProtocol = "ws";

// WebSocket IP. Should be equal to the IP the NodeJS WebSocket Server runs on, like "127.0.0.1"
var webSocketIp = "127.0.0.1";

// WebSocket Port. Should be equal to the Port the NodeJS WebSocket Server runs on, like "13370".
var webSocketPort = "80";

// The method by which the overlay will update.
// ContentUpdateModes-ReadMe.txt for more information.
var contentUpdateMode = 4;

// The time the content takes to fade out. Should be equal to Queu.css .changing "transition-duration" property (convert seconds to milliseconds when applying this).
var fadeOutTime = 500;

// Time the content remains invisible before fading back in.
var invisibleTime = 1000;

// The time the content takes to fade back in. Should be equal to Queu.css .changed "transition-duration" property (convert seconds to milliseconds when applying this).
var fadeInTime = 500;