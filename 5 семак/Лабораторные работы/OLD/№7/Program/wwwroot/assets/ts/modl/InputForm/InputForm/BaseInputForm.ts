



import $ from "jquery";

import {OverLay} from "../../OverLay.ts";
import {ButtonState} from "../../BaseEnum.ts";


import {HeaderForm} from ".";
import {TableInput} from "../TableInput";
import {ButtonClose, ButtonClear, ButtonSave} from "../ButtonRow/index.ts"


export abstract class BaseInputForm{
    /// Оверлей
    public readonly overlay: OverLay;

    /// Окно для формы
    public readonly window_form = $(`<div id = "window_form"></div>`);

    /// Форма окна
    public readonly data_form = $(`<form id = "data_form"></form>`); 

    /// Хеадер формы
    public readonly data_form_header: HeaderForm;

    /// Добавляем таблицу на форму
    public readonly table_form: TableInput; 

    /// Строка кнопок
    public readonly row_bt = $(`<div id = "row_bt"></div>`);
    // Кнопка очистки
    public readonly bt_clear: ButtonClear;
    // Кнопка закрытия
    public readonly bt_close: ButtonClose;
    
    // Кнопка сохранения
    public readonly bt_save: ButtonSave;

    /// Флаг кнопок
    public state_button: ButtonState = ButtonState.Close;


    public SaveForm(){
        console.log(12345);
        this.state_button = ButtonState.Save;
        OverLay.close();
    }

    public CloseForm(){
        console.log(12345);
        this.state_button = ButtonState.Close;
        OverLay.close();
    }



    public constructor(){
        /// Работа с Хеадером формы
        this.data_form_header = new HeaderForm(this.data_form);


        /// Работа с таблицей формы
        this.table_form = new TableInput(this.data_form);


        /// Работа с строкой кнопок
        this.bt_save = new ButtonSave(this.row_bt);
        this.bt_save.on("click", this.SaveForm);

        this.bt_close = new ButtonClose(this.row_bt);
        this.bt_close.on("click", this.CloseForm);

        this.bt_clear = new ButtonClear(this.row_bt);

        this.data_form.append(this.row_bt)

        this.window_form.append(this.data_form);

        this.overlay = new OverLay($("body")); 
        this.overlay.append(this.window_form);
    }


    /// Показ формы
    public async show(): Promise<void>{ return this.overlay.show() }
}

(window as any).BaseInputForm = BaseInputForm;