



import {RowButton} from "."


export class Button{
    public readonly bt = $(` <button type="button"> </button> `);

    public text = $(`<p>Кнопка</p>`);

    public image: null | JQuery<HTMLElement> = null;


    public constructor(readonly parent: JQuery<HTMLElement> | RowButton){
        this.bt.append(this.text);
        if(parent instanceof  RowButton){ parent.row_bt.append(this.bt); }
        else{ parent.append(this.bt); }
        
        
    }

    public SetText(new_text: JQuery<HTMLElement>){
        this.text.remove();
        this.text = new_text;
        this.bt.append(this.text);
    }

    public SetImage(new_image: JQuery<HTMLElement>){
        if(this.image != null){ this.image.remove(); }
        this.image = new_image;

        this.bt.append(this.image);
    }

    public on(name_event: string, listener_event: any){
        this.bt.on(name_event, listener_event);
    }
}
(window as any).Button = Button;




/// Кнопка закрытия
export class ButtonClose extends Button{
    public constructor(readonly parent: JQuery<HTMLElement>){
        super(parent);
        this.SetImage($(`<img src="https://api.iconify.design/lucide:x.svg?color=%230F172A&amp;width=16&amp;height=16" >`));
        this.SetText($("<p>Закрыть</p>"));

        this.bt.attr("id", "bt_close"); 
    }
}
(window as any).ButtonClose = ButtonClose;




/// Кнопка очистки
export class ButtonClear extends Button{
    public constructor(readonly parent: JQuery<HTMLElement>){
        super(parent);
        this.SetImage($(`<img src="https://api.iconify.design/lucide:eraser.svg?color=%230F172A&amp;width=16&amp;height=16" alt="Clear icon" id="irhyi-2" class="icon-clear">`));
        this.SetText($("<p>Очистить</p>"));
        this.bt.attr("id", "bt_clear"); 
        this.bt.attr("type", "reset"); 
    }
}
(window as any).ButtonClear = ButtonClear;


/// Кнопка сохранения
export class ButtonSave extends Button{
    public constructor(readonly parent: JQuery<HTMLElement>){
        super(parent);
        this.SetImage($(`<img src="https://api.iconify.design/lucide:save.svg?color=%23FFFFFF&amp;width=16&amp;height=16" alt="Save icon" id="i3ixg-2">`));
        this.SetText($("<p>Сохранить</p>"));
        this.bt.attr("id", "bt_save"); 
        this.bt.attr("type", "submit"); 
    }
}
(window as any).ButtonSave = ButtonSave;

