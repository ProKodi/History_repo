



import $ from "jquery";

export class BodyTableInput{
    // Тело таблицы
    public readonly table_body = $(`<tbody id="table-body"></tbody>`);

    public constructor(readonly parent: JQuery<HTMLElement>){
        parent.append(this.table_body);
    }

    public append_row(label: string, id: string, type: string = "text"): void{
        let row_container = $("<tr></tr>");
        row_container.append($(`<td class="first_col"><p>${label}</p></td>`));
        row_container.append($(`<td class="second_col"><input type = ${type} id = ${id}></td>`));
        
        this.table_body.append(row_container);
    }
}
(window as any).BodyTableInput = BodyTableInput;