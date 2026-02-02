



import $ from "jquery";


/// Класс реализующий функционал оверлея
export class OverLay{
    // Создаем оверлей 
    public readonly overlay = $("<div id='overlay'></div>").css({
        "display": "none",
        "position": "fixed",
        "top": "0", 
        "left": "0",
        "width": "100%",
        "height": "100%",
        "background": "rgba(0, 0, 0, 0.8)",
        "justify-content": "center",
        "align-items": "center",
        "z-index": 999,
    });

    public constructor(readonly parent: JQuery<HTMLElement>){
        // Удяляем старый оверлей (если он есть)
        $("#overlay").remove();


        // Клик по фону закрывает оверлей
        this.overlay.on("click", 
            function(e: any): void{
                if(e.target == $("#overlay")[0]){ OverLay.close(); }
            }
        );
        parent.append(this.overlay);
    }

    /// Закрытие оверлея
    public static close(): void{ $("#overlay").css("display", "none"); }

    /// Добавление поля на оверлей
    public append(child: JQuery<HTMLElement>): void{ this.overlay.append(child); }

    /// Показ оверлея
    public show(): Promise<void>{
        return new Promise((_) => { this.overlay.css("display", "flex"); });
    }
}


(window as any).OverLay = OverLay;