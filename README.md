# scoreBoard-v1.0
This scoreboard is used as an Overlay for streaming live Soccer/FootBall Matches on OBS 

## Requirments:
    - XAMPP : Since i don't know how to implement a web server i am using this instead (the ports **must** be identical -80-).
    - .NET 4.7 or higher.
    - Chrome : since the overlay works there much better. 

## Contents
    This project have two parts :
        -Team Description : this contains a splitter splitted in two panels, each panel contains :
            -TextBoxes : for changing team's name.(after verifying it , it will be disabled until you unchecked the checkbox adjacent to it)
            -Two Buttons : one for incerementing and other for decrementing the score of the team.(after pressing any of them , they will be disabled until you unchecked the checkbox adjacent to them)
            -Colored Panel : after pressing it ,it will give u a color dialog where u choose the color.
        -Timer and Overlay Settings : this contains :
            -Three Labels : 
                -Main Timer.
                -Extra Timer.
                -Extra Time.
            - 3 Buttons adjacent to the Main Timer : for Playing,Pausing and Stopping Timers.
            - 2 Buttons adjacent to the Extra Timer : for Showing and Hiding the **Extra Time**.
            - 2 NumericUpDowns :  for setting period time (Minutes) and Extra Time.
            - Panel That contains 2 buttons for showing and hiding the Overlay.
            - Panel That contains 2 NumericUpDowns for setting the minute and the second , and a confirmation button for changing the main timer manually into the minute and the second that were chosen.

## How to use it :
    - Assuming you know how to build a c# project,the first you need is **copying** the **"getContentCss"** folder into the **htdocs** folder that locates in **xampp installation folder**.
    -Start the Apache Server with XAMPP.
    -Open the exceutable file of the project.
    -Open the html file **scoreboard** in **overlay** folder with **Chrome**.
    -if the html file shows the scoreboard perfectly with no errors that means everything works :) .
    -Assuming you know how to use **OBS** add a browser source with the html file.
    -Enjoy :).
### PS
    This is my first ever project that i ever upload in Github ,i hope u find some use of it,it may look like the project is messy from code or design standpoint since i'm intermediate and design isn't my strongest point lol , anyway enjoy live streaming soccer games with this dynamic overlay.
    I have a bigger project in my mind which is upgrading this and expanding of it and making all overlays that were used in big matches(like world cup), so **Stay Tuned**.
