



export * from "./ButtonRow"
export * from "./InputForm"
export * from "./TableInput"

/// Грузим css для работы формы
import "../main_style.css"


import {BaseInputForm} from "./InputForm";



export class TableInputForm extends BaseInputForm{}



(window as any).TableInputForm = TableInputForm;