var timerState = -2;

var isMainTimerStarted = false;

var periodTime = 0;

var periodState = 1;

var extraTime = 0;

var extraTimeVisible = "False";
var extraTimerVisible = false;

var totalSeconds=0;
var totalExtraSeconds = 0;


var isMainTimerEnded = false;



function Timer() {
// Update the count down every 1 second

  var x = setInterval(function() {
    if(!isMainTimerEnded){
      console.log("Reading---"+"<<<<<<<<"+timerState);
    if(timerState == 0){
      clearInterval(x);
      
    }

    if(timerState == 1){
      totalSeconds++;
   var minutes = Math.floor(totalSeconds/60);
   var seconds = totalSeconds-(minutes*60);
  document.getElementById("timer").innerHTML = minutes.toLocaleString('en-US', {
    minimumIntegerDigits: 2,
    useGrouping: false
  }) + ":" + seconds.toLocaleString('en-US', {
    minimumIntegerDigits: 2,
    useGrouping: false
  });
    console.log("2--------Reading---------"+minutes+":"+seconds);

    if (minutes == (periodTime*periodState)) {
        totalSeconds=0;
    isMainTimerEnded = true;
    ExtraTimer();
    clearInterval(x);
  }
    }
    }
    
        if(timerState == -1){
        clearInterval(x);
 }

}, 1000);

}

function showOverlay(){

    document.getElementById('tournamentLogo').style.animation="opacityGradualFadeIn";
    document.getElementById('tournamentLogo').style.animationDuration="0.5s";
    document.getElementById('tournamentLogo').style.animationFillMode="forwards";

        document.getElementById('circle1').style.animation="opacityGradualFadeIn";
    document.getElementById('circle1').style.animationDuration="0.75s";
    //document.getElementById('circle1').style.animationFillMode="forwards";

        document.getElementById('circle2').style.animation="opacityGradualFadeIn";
    document.getElementById('circle2').style.animationDuration="1s";
    //document.getElementById('circle2').style.animationFillMode="forwards";

    document.getElementById('mainTimer').style.animation="opacityHalfFadeIn";
    document.getElementById('mainTimer').style.animationDuration="2s";
    document.getElementById('mainTimer').style.animationFillMode="forwards";

    document.getElementById('scoreboard').style.animation="opacityHalfFadeIn";
    document.getElementById('scoreboard').style.animationDuration="1s";
    document.getElementById('scoreboard').style.animationFillMode="forwards";

    showExtraTimer();


    document.getElementById('leftScoreBox').style.animation="opacityHalfFadeIn";
    document.getElementById('leftScoreBox').style.animationDuration="5s";
    document.getElementById('leftScoreBox').style.animationFillMode="forwards";


    document.getElementById('leftNameBox').style.animation="opacityHalfFadeIn";
    document.getElementById('leftNameBox').style.animationDuration="5s";
    document.getElementById('leftNameBox').style.animationFillMode="forwards";

    document.getElementById('timercss').style.animation="opacityHalfFadeIn";
    document.getElementById('timercss').style.animationDuration="5s";
    document.getElementById('timercss').style.animationFillMode="forwards";

    document.getElementById('player1ColorBox').style.animation="opacityHalfFadeIn";
    document.getElementById('player1ColorBox').style.animationDuration="5s";
    document.getElementById('player1ColorBox').style.animationFillMode="forwards";

    document.getElementById('player2ColorBox').style.animation="opacityHalfFadeIn";
    document.getElementById('player2ColorBox').style.animationDuration="5s";
    document.getElementById('player2ColorBox').style.animationFillMode="forwards";

    document.getElementById('rightNameBox').style.animation="opacityHalfFadeIn";
    document.getElementById('rightNameBox').style.animationDuration="5s";
    document.getElementById('rightNameBox').style.animationFillMode="forwards";

    document.getElementById('rightScoreBox').style.animation="opacityHalfFadeIn";
    document.getElementById('rightScoreBox').style.animationDuration="5s";
    document.getElementById('rightScoreBox').style.animationFillMode="forwards";



    showExtraTime()

    /*var x = document.getElementsByClassName('contentBox');
    for (let i = 0 ;i<x.length;i++) {
      x[i].style.animation="opacityHalfFadeIn";
      x[i].style.animationDuration="5s";
      x[i].style.animationFillMode="forwards";
    }*/
}

function hideOverlay(){

    document.getElementById('tournamentLogo').style.animation="opacityGradualFadeOut";
    document.getElementById('tournamentLogo').style.animationDuration="1s";
    document.getElementById('tournamentLogo').style.animationFillMode="forwards";

        document.getElementById('circle1').style.animation="opacityGradualFadeOut";
    document.getElementById('circle1').style.animationDuration="0.75s";
    document.getElementById('circle1').style.animationFillMode="forwards";

        document.getElementById('circle2').style.animation="opacityGradualFadeOut";
    document.getElementById('circle2').style.animationDuration="0.5s";
    document.getElementById('circle2').style.animationFillMode="forwards";

    document.getElementById('mainTimer').style.animation="opacityHalfFadeOut";
    document.getElementById('mainTimer').style.animationDuration="2s";
    document.getElementById('mainTimer').style.animationFillMode="forwards";

        document.getElementById('scoreboard').style.animation="opacityHalfFadeOut";
    document.getElementById('scoreboard').style.animationDuration="4s";
    document.getElementById('scoreboard').style.animationFillMode="forwards";


hideExtraTimer();


    document.getElementById('leftScoreBox').style.animation="opacityHalfFadeOut";
    document.getElementById('leftScoreBox').style.animationDuration="1s";
    document.getElementById('leftScoreBox').style.animationFillMode="forwards";


    document.getElementById('leftNameBox').style.animation="opacityHalfFadeOut";
    document.getElementById('leftNameBox').style.animationDuration="1s";
    document.getElementById('leftNameBox').style.animationFillMode="forwards";

    document.getElementById('timercss').style.animation="opacityHalfFadeOut";
    document.getElementById('timercss').style.animationDuration="1s";
    document.getElementById('timercss').style.animationFillMode="forwards";

    document.getElementById('player1ColorBox').style.animation="opacityHalfFadeOut";
    document.getElementById('player1ColorBox').style.animationDuration="1s";
    document.getElementById('player1ColorBox').style.animationFillMode="forwards";

    document.getElementById('player2ColorBox').style.animation="opacityHalfFadeOut";
    document.getElementById('player2ColorBox').style.animationDuration="1s";
    document.getElementById('player2ColorBox').style.animationFillMode="forwards";

    document.getElementById('rightNameBox').style.animation="opacityHalfFadeOut";
    document.getElementById('rightNameBox').style.animationDuration="1s";
    document.getElementById('rightNameBox').style.animationFillMode="forwards";

    document.getElementById('rightScoreBox').style.animation="opacityHalfFadeOut";
    document.getElementById('rightScoreBox').style.animationDuration="1s";
    document.getElementById('rightScoreBox').style.animationFillMode="forwards";



    hideExtraTime();
    /*var x = document.getElementsByClassName('contentBox');
    for (let i = 0 ;i<x.length;i++) {
      x[i].style.animation="opacityHalfFadeOut";
      x[i].style.animationDuration="1s";
      x[i].style.animationFillMode="forwards";
    }*/
}

function stopTimer(){
totalSeconds=0;
        isMainTimerEnded = false;
        document.getElementById("timer").innerHTML = "00:00";
            console.log("Stoping--------------------");
}
function stopExtraTimer(){
  extraTimerVisible = false;
        totalExtraSeconds= 0 ;
        document.getElementById("extraTimerText").innerHTML = "";
            console.log("Stoping--------------------");
          hideExtraTimer();
}
function ExtraTimer(){
// Update the count down every 1 second
extraTimerVisible = true;
showExtraTimer();
  var x = setInterval(function() {
    console.log("ReadingExtra---"+"<<<<<<<<"+timerState);
    if(timerState == 0){
      clearInterval(x);
      
    }

    if(timerState == 1){
      totalExtraSeconds++;
   var eMinutes = Math.floor(totalExtraSeconds/60);
   var eSeconds = totalExtraSeconds-(eMinutes*60);
  document.getElementById("extraTimerText").innerHTML ="+"+ eMinutes.toLocaleString('en-US', {
    minimumIntegerDigits: 2,
    useGrouping: false
  }) + ":" + eSeconds.toLocaleString('en-US', {
    minimumIntegerDigits: 2,
    useGrouping: false
  });
    console.log("2--------ReadingExtra---------"+eMinutes+":"+eSeconds);

    }
        if(timerState == -1){
        clearInterval(x);
 }

}, 1000);
}
function showExtraTimer(){
  if(extraTimerVisible){
        document.getElementById('extraTimer').style.animation="opacityHalfFadeIn";
    document.getElementById('extraTimer').style.animationDuration="3s";
    document.getElementById('extraTimer').style.animationFillMode="forwards";

        document.getElementById('extraTimerBox').style.animation="opacityHalfFadeIn";
    document.getElementById('extraTimerBox').style.animationDuration="5s";
    document.getElementById('extraTimerBox').style.animationFillMode="forwards";
  }

}
function hideExtraTimer(){
  if(extraTimerVisible){
              document.getElementById('extraTimer').style.animation="opacityHalfFadeOut";
    document.getElementById('extraTimer').style.animationDuration="3s";
    document.getElementById('extraTimer').style.animationFillMode="forwards";

        document.getElementById('extraTimerBox').style.animation="opacityHalfFadeOut";
    document.getElementById('extraTimerBox').style.animationDuration="1s";
    document.getElementById('extraTimerBox').style.animationFillMode="forwards";
  }

}
function showExtraTime(){
  if(/*isMainTimerEnded&&*/extraTimeVisible=="True"){
        document.getElementById('extraTimeBox').style.animation="opacityHalfFadeIn";
    document.getElementById('extraTimeBox').style.animationDuration="5s";
    document.getElementById('extraTimeBox').style.animationFillMode="forwards";
      document.getElementById("extraTimeText").innerHTML ="'"+ extraTime;
          document.getElementById('extraTime').style.animation="opacityHalfFadeIn";
    document.getElementById('extraTime').style.animationDuration="2s";
    document.getElementById('extraTime').style.animationFillMode="forwards";
  }
}
function hideExtraTime(){
  if(/*isMainTimerEnded&&*/extraTimeVisible=="False"){
      document.getElementById("extraTimeText").innerHTML ="";
      document.getElementById('extraTimeBox').style.animation="opacityHalfFadeOut";
    document.getElementById('extraTimeBox').style.animationDuration="1s";
    document.getElementById('extraTimeBox').style.animationFillMode="forwards";
        document.getElementById('extraTime').style.animation="opacityHalfFadeOut";
    document.getElementById('extraTime').style.animationDuration="2s";
    document.getElementById('extraTime').style.animationFillMode="forwards";
  }
}


