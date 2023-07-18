Experience in HTML and CSS is recommended if you want to make changes to the overlay

../importantFiles/overlay/css/styles.css
-- Generally defines the base overlay style
-- It is unlikely that this file needs to be edited
---- Below /* TEXT */ defines the font styling of the overlay, minus the font size
------ span most importantly sets the color and text-shadow
---- Below /* divs to contain the background images */ defines the elements to apply the background images to
------ .scoreboardPart most importantly sets the height and width of the elements
-------- should be the same size as the background images and the OBS canvas
------ #scoreboardLeft, #scoreboardMiddle, #scoreboardBottom, #scoreboardRight, #tournamentLogo are the individual background containers
-------- These should only define the background image and the animation name and duration
-------- Complex slide ("size" or "position") animations are unviable with the techniques used, it should be kept to fade ("opacity") animations
---- Below /* divs to contain text content */ defines the elements to insert the text into
------ .contentBox most importantly defines some default values and the animation name and duration
-------- Slightly more complex animations (like "position") are possible in with these elements if you try
---- Below /* ANIMATIONS */ defines the animations
------ Contains some fade in animations by default

../importantFiles/overlay/css/contentBoxes.css
-- Generally defines the width, height and positions of every element to insert the text into
---- Should all be used in combination with .contentBox
---- Score, Name and Info elements their "width", "height" and "line-height" are defined together because they should be the same size as their opposit player/team counterpart
---- Inidividual element positions ("top" and "left") are defined separate, as they should be in different positions from their opposit player/team counterpart

../importantFiles/overlay/css/queu.css
Queu
-- Generally defines the animations to apply when content is being updated
---- .changing is applied when content is being updated
------ "transition duration" should be equal in time to variables.js "fadeOutTime" variable (convert seconds to milliseconds when applying this)
---- .changed is applied when content has been updated
------ "transition-duration" should be equal in time to variables.js "fadeInTime" variable (convert seconds to milliseconds when applying this)

../importantFiles/overlay/css/snackbar.css
Snackbar
-- Generally defines the styling and animations of the snackbar
-- It is unlikely that this file needs to be edited