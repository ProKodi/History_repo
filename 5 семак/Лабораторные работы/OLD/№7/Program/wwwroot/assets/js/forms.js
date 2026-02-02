



class InputForm{
    // Создаем оверлей 
    const overlay = $("<div id='modalOverlay'></div>").css({
        display: 'none',
        position: 'fixed',
        top: 0, left: 0,
        width: '100%', height: '100%',
        background: 'rgba(0, 0, 0, 0.8)',
        /* Центрируем картинку при открытии */
        justifyContent: 'center',
        alignItems: 'center',
        zIndex: 999
    });




}





// Создаем оверлей 
const overlay = $("<div id='modalOverlay'></div>").css({
    display: 'none',
    position: 'fixed',
    top: 0, left: 0,
    width: '100%', height: '100%',
    background: 'rgba(0, 0, 0, 0.8)',
    /* Центрируем картинку при открытии */
    justifyContent: 'center',
    alignItems: 'center',
    zIndex: 999
});

// форму один раз
const form = $('<div id="popupForm"></div>').css({
    background: "#262641",
    position: "fixed",
    top:"50%",
    left:"50%",
    transform: "translate(-50%, -50%)",

    padding: "5%",
    zindex: 9999,
});


function close_form(e){
    if (e.target === overlay[0] || e.target === closeBtn[0]) {
        overlay.css("display", "none");
        $("body").css("overflow", "");
    }
}

// Клик по фону закрывает оверлей
overlay.on("click", close_form);