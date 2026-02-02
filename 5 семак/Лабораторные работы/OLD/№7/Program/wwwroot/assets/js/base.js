



/*
Данный модуль добавляет базовый функционал

*/



$(document).ready(function() {
    /// Реакция на нажатие на лого
    $("#logo").on("mousedown", function(e) {
        if((e.button === 0) && (window.location.pathname != "/")){ window.location.href = "/"; }
        else if(e.button === 1){ window.open("/", "_blank"); }
    })


    



})
