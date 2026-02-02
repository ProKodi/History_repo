







// Создаем оверлей и форму один раз
const overlay = $("<div id='modalOverlay'></div>").css({
    display: 'none',
    position: 'fixed',
    top: 0, left: 0,
    width: '100%', height: '100%',
    background: 'rgba(0, 0, 0, 0.8)',
    /* Центрируем картинку при открытии */
    justifyContent: 'cente
    r',
    alignItems: 'center',
    zIndex: 999
});

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


form.append($('<label>ФИО:  <input id = "input_name" type = "text"> </label>'));
form.append($('<label>Пол:  <input id = "sex" type = "text"> </label>'));
form.append($('<label>Родители: <input id = "perents" type = "text"> </label>'));
form.append($('<label>Адрес: <input id = "adress" type = "text"> </label>'));
form.append($('<label>Телефон: <input id = "number_phone" type = "text"> </label>'));
form.append($('<label>Паспортные данные: <input id = "pasport_data" type = "text"> </label>'));
form.append($('<label>Группа: <input id = "group" type = "text"> </label>'));
form.append($('<label>Дата рождения: <input id = "birthday" type = "text"> </label>'));
form.append($('<label>Дата поступления: <input id = "date_receipt" type = "text"> </label>'));
form.append($('<label>Очная форма обучения: <input id = "is_full_time" type = "text"> </label>'));
form.append($('<label>Номер зачетки: <input id = "number_record_book" type = "text"> </label>'));
form.append($('<label>Курс: <input id = "nuber_course" type = "text"> </label>'));




// Вставляем форму в оверлей
overlay.append(form);
// Добавляем оверлей в body
$("body").append(overlay);



const submitBtn = $('<button>Ввести</button>');
const closeBtn = $('<button>Закрыть</button>');
// Закрытие формы
closeBtn.on("click", close_form);

form.append(submitBtn, closeBtn);




$(document).ready(function() {
    document.querySelectorAll("#editableTable td").forEach(td => {
        td.addEventListener("dblclick", () => {
            td.contentEditable = true;     // включаем редактирование
            td.focus();                    // ставим курсор внутрь
        });
    
        td.addEventListener("blur", () => {
            td.contentEditable = false;    // выключаем редактирование при потере фокуса
        });
    
        td.addEventListener("keydown", (e) => {
            if (e.key === "Enter") {       // по Enter завершаем редактирование
                e.preventDefault();
                td.blur();
            }
        });
    });




    $('#append_row').click(function() {


        // Можно очищать поля перед открытием
        //fields.forEach(f => $('#' + f.id).val(''));

        form.attr("src", $(this).attr("src"));
        overlay.css("display", "flex");



        /*overlay.fadeIn();
        form.fadeIn();*/
    // overlay.css("display", "flex");


        // Запрашиваем у пользователя данные (пользователь сам вводит данные) (вернет строку)

        
        // Можно очищать поля перед открытием
        // fields.forEach(f => $('#' + f.id).val(''));

 
        // form.fadeIn();


        /*let name = prompt("введите фио студента:");

        console.log(name)

        if(name == null || name.trim() == ""){
            alert("Вы не ввели информацию");
            return;
        }



        let table = $("#editableTable");

        // Создаем новую строку
        let new_row = $("<tr></tr>");


        new_row.append("<td>0</td>");
        new_row.append("<td></td>");
        new_row.append("<td></td>");
        new_row.append("<td></td>");
        new_row.append("<td></td>");

        new_row.append("<td></td>");
        new_row.append("<td></td>");
        new_row.append("<td></td>");
        new_row.append("<td></td>");
        new_row.append("<td></td>");

        new_row.append("<td></td>");
        new_row.append("<td></td>");



        // Добавляем строку
        table.append(new_row);

        // Прокрутка до последней строки
        table.find("tr:last")[0].scrollIntoView({ behavior: "smooth" });*/


    /*
    const table = document.getElementById("myTable");

    // Добавляем новую строку в конец таблицы
    const newRow = table.insertRow(); // можно передать индекс: table.insertRow(1)

    // Добавляем ячейки
    const cell1 = newRow.insertCell(0);
    const cell2 = newRow.insertCell(1);

    // Заполняем ячейки
    cell1.textContent = "Иван";
    cell2.textContent = "25";

    */

    });







});


