



import $ from "jquery";

import * as BaseEnum from "../../BaseEnum.ts";


/// Класс реализующий хеадер формы
export class HeaderForm{
    /// Хеадер формы
    public readonly data_form_header = $(`<header id = "data_form_header"></header>`);

    public constructor(readonly parent: JQuery<HTMLElement>){
        parent.append(this.data_form_header);
    }

    /// Добавление элемента на форму
    public append(child: JQuery<HTMLElement>, anc: BaseEnum.Anchor = BaseEnum.Anchor.Left): void{ 
        let css_style: any = { display: "flex", "justify-self": "flex-start", };

        switch(anc){
            case(BaseEnum.Anchor.Left): {
                css_style["justify-self"] = "flex-start";
                break;
            }
            case(BaseEnum.Anchor.Center): {
                css_style["justify-self"] = "center";
                break;
            }
            case(BaseEnum.Anchor.Right): {
                css_style["justify-self"] = "flex-end";
                break;
            }
        }
        this.data_form_header.append(child.css(css_style));
    }
}

(window as any).HeaderForm = HeaderForm;