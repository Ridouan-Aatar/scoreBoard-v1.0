var connection = null;

function initWebSocket() {
    connection = new WebSocket(`${ webSocketProtocol }://${ webSocketIp }:${ webSocketPort }`);

    connection.onopen = function () {
        console.log("Connected to the WebSocket");
        tempToken = generateTempToken();
        var connectionMessage = { "identification": null, "type": "GameOverlay", "name": overlayName, "path": "", "message": "", "messageType": "RequestIdentification", "tempToken": tempToken };
        connection.send(JSON.stringify(connectionMessage));
    };

    connection.onmessage = function (message) {
        console.log(`Received message: ${ message.data }`);
        var data = JSON.parse(message.data);
        console.log(JSON.stringify(data)); // <--------------------
        
        if (data.messageType === "IdentificationAnswer" && data.name === overlayName) {
            if (id !== null) {
                console.log("IdentificationAnswer received, but Overlay already has an Id.");
                return;
            }
    
            if (tempToken !== data.tempToken) {
                console.log("IdentificationAnswer received, but the temporary token did not match.");
                return;
            }
    
            console.log(`IdentificationAnswer received ${ data.identity }`);
            id = data.identity;
            return;
        }
    
        updateOverlay(data);
        updateCardOverlay(data);
    };
    
    connection.onerror = function (error) {
        snackbar("Something went wrong with the WebSocket connection.");
        console.log(error);
    };
    
    connection.onclose = function (event) {
        console.log("WebSocket connection closed");
        snackbar("WebSocket connection closed");
    };
}

function sendDisconnectingMessage() {
    var disconnectMessage = { "messageType": "OverlayDisconnecting", "identity": id, "type": "GameOverlay", "name": overlayName }; 
	connection.send(JSON.stringify(disconnectMessage));
}