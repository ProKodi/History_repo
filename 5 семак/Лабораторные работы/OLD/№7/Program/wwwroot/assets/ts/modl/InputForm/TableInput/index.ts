






export * from "./HeaderTableInput.ts"
export * from "./BodyTableInput.ts"


import {HeaderTableInput} from "./HeaderTableInput.ts";
import {BodyTableInput} from "./BodyTableInput.ts";





/// Класс реализующий функционал таблицы для ввода данных
export class TableInput{
    // Заголовок таблицы
    public readonly table_head: HeaderTableInput;

    // Тело таблицы
    public readonly table_body: BodyTableInput;

    /// Добавляем таблицу на форму
    public readonly table_form = $(`
        <table id = "table_form">
        </table>
    `);

    public constructor(readonly parent: JQuery<HTMLElement>){
        // Добавляем заголовок
        this.table_head = new HeaderTableInput(this.table_form)

        // Добавляем тело таблицы
        this.table_body = new BodyTableInput(this.table_form);

        parent.append(this.table_form);
    }

}

(window as any).TableInput = TableInput;