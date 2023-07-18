Setting the contentUpdateMode in variables.js will result in the scoreboard.html using a different method of updating content.

1: Fade out elements through JSON WebSocket | Update Content CSS through CSS WebSocket | Fade in elements through JSON WebSocket
2: Fade out elements through JSON WebSocket | Update Content CSS through CSS AJAX | Fade in elements through JSON WebSocket
3: Fade out elements through JSON AJAX | Update Content CSS through CSS AJAX | Fade in elements through JSON AJAX
4: No fade out | Update Content CSS through CSS WebSocket | No fade in
5: Fade out elements through JSON WebSocket | Update timestamp on content.css | Fade in elements through JSON WebSocket
6: Fade out elements through JSON AJAX | Update timestamp on content.css | Fade in elements through JSON AJAX

1 is the most optimal method. Higher numbers are less preferred methods.
4 is the fastest method.
5 or 6 is recommended if all other methods fail to work in OBS.

Setting it to anything besides 1 to 6 will revert it back to 1 programmatically.