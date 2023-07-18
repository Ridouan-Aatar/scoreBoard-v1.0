var _fittyElements = null;

function initOverlayManager() {
    _fittyElements = fittyElements;
    populateOverlay();
    initWebSocket();
    
}

function populateOverlay() {
    try {
        if (contentUpdateMode === null || isNaN(contentUpdateMode) || contentUpdateMode != 4 ) {
            contentUpdateMode = 4;
        }
        if (contentUpdateMode == 4 ) {
            updateContentInStyleTagFromAJAX(0);
            return;
        }
    } catch (ex) {
        console.log(ex);
    }
}

function updateContentInStyleTagFromAJAX(timeout) {
    setTimeout(function () {
        $.ajax({
            url: `${ serverBaseUrl }/getContentCss/index.php`,
            type: "GET",
            data: null,
            dataType: "text",
            async: false,
            success: function (data) {
                console.log(data);
                $("style#contentCSS").text(data);
                resizeFittyElements();
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR);
                console.log(textStatus);
                console.log(errorThrown);
            }
        });
    }, timeout);
}
function updateTimer(timeout) {
    setTimeout(function () {
        $.ajax({
            url: `${ serverBaseUrl }/getContentCss/contentJson.php`,
            type: "GET",
            data: null,
            dataType: "json",
            async: false,
            success: function (data) {
                console.log(data);
                var dataJson = JSON.parse(data)
                console.log(dataJson.TimerState);
                if(dataJson.OverlayVisible == "True")
                    showOverlay();
                if(dataJson.OverlayVisible == "False")
                    hideOverlay();
                if(timerState!=dataJson.TimerState){
                timerState = dataJson.TimerState;

                periodTime = dataJson.PeriodTime;

                periodState = dataJson.PeriodState;
                if(!isMainTimerStarted||dataJson.TimerChanged=="True"){
                    totalSeconds =dataJson.TimerTotalSeconds;
                    isMainTimerStarted=true;
                }
                    if(timerState==1){
                        Timer();
                        if(isMainTimerEnded)
                            ExtraTimer();
                    }
                    if(timerState==-1){
                        stopTimer();
                        stopExtraTimer();
                    }
                    
                    

                }


                extraTime = dataJson.ExtraTime;

                extraTimeVisible = dataJson.ExtraTimeVisible;
                  if(/*isMainTimerEnded&&*/extraTimeVisible=="True"){
                        showExtraTime();
                    }
                    if(/*isMainTimerEnded&&*/extraTimeVisible=="False"){
                        hideExtraTime();
                    }


                //$("style#contentCSS").text(data);
                resizeFittyElements();
            },
            error: function (jqXHR, textStatus, errorThrown) {
                console.log(jqXHR);
                console.log(textStatus);
                console.log(errorThrown);
            }
        });
    }, timeout);
}

function updateContentInStyleTag(css, timeout) {
    setTimeout(function () {
        $("style#contentCSS").text(css);
        resizeFittyElements();
    }, timeout);
}

function resizeFittyElements() {
    for (var i = 0; i < _fittyElements.length; i++) {
        fitty(_fittyElements[i].selector, { minSize: _fittyElements[i].minSize, maxSize: _fittyElements[i].maxSize, multiLine: _fittyElements[i].multiLine });
    }
}


function updateOverlay(data) {
    if (data.messageType === "UpdateOverlay") {
        switch (contentUpdateMode) {
        case 4:
            // No fade out | Update Content CSS through CSS WebSocket | No fade in
            //updateContentInStyleTag(data.css, 0);
            updateContentInStyleTagFromAJAX(fadeOutTime);
            updateTimer(fadeOutTime);
            
            break;
        default:
            console.log(`Unknown contentUpdateMode: ${ contentUpdateMode }`);
            break;
        }
    }
}