



import $ from "jquery";


/// Класс реализующий функционал заголовка таблицы
export class HeaderTableInput{
    // Заголовок таблицы
    public readonly table_head = $(` <thead id="table-head"> </thead> `);

    // Строка заголовка таблицы
    public readonly row_header = $(`<tr></tr>`);

    // Название колонки с названиями полей
    public readonly first_field_header = $(`<th class="first_col">Название поля</th>`);
    // Название колонки с значениями полей
    public readonly second_field_header = $(`<th class="second_col">Данные для поля</th>`);


    public constructor(readonly parent: JQuery<HTMLElement>){
        this.row_header.append(this.first_field_header)
        this.row_header.append(this.second_field_header)

        this.table_head.append(this.row_header);

        parent.append(this.table_head);
    }

    /// Изменения виджета для первого заголовка
    public change_first_header(new_widget: JQuery<HTMLElement>){
        this.first_field_header.empty();
        this.first_field_header.append(new_widget);
    }

    /// Изменения виджета для второго заголовка
    public change_second_header(new_widget: JQuery<HTMLElement>){
        this.second_field_header.empty();
        this.second_field_header.append(new_widget);
    }
}
(window as any).HeaderTableInput = HeaderTableInput;