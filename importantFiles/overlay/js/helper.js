function snackbar(message) {
    try {
        $("#snackbar").text(message);

        var marginLeft = ($(window).width() - $("#snackbar").outerWidth()) / 2;
        $("#snackbar").css("left", marginLeft >= 0 ? marginLeft : 0);

        $("#snackbar").addClass("show");
        setTimeout(function () {
            $("#snackbar").removeClass("show");
        }, 3000);
    } catch (ex) {
        console.log(ex);
    }
}

function generateTempToken() {
    var result = "";
    var characters = 'ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789';
    var charactersLength = characters.length;
    for (var i = 0; i < 8; i++) {
        result += characters.charAt(Math.floor(Math.random() * charactersLength));
    }
    return result;
}