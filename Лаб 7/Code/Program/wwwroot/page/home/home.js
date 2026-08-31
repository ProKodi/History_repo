



const chat = document.getElementById("chat");
const input = document.getElementById("messageInput");


/**
 * Функция для отправки новых параметров на сервер
 * @param {*} data Новые параметры
 */
async function SetOptions(data){
    const response = await fetch("/answer", {
        method: "PATCH",
        headers: {
            "Content-Type": "application/json"
        },
        body: JSON.stringify(data)
    });

    if (!response.ok) {
        throw new Error(`HTTP error: ${response.status}`);
    }
    return await response.json()
}




function addMessage(text, type){
    const msg = document.createElement("div");
    msg.classList.add("message", type);
    msg.textContent = text;

    chat.appendChild(msg);
    chat.scrollTop = chat.scrollHeight;
}

async function sendMessage(){
    const text = input.value.trim();
    if(!text) return;
    input.value = "";

    addMessage(text,"user");
    data = {};
    data["text_message"] = text;
    data["is_user"] = true;


    let new_text = await SetOptions(data)
    addMessage(new_text["text_message"],"bot");
}

input.addEventListener("keypress", function(e){
    if(e.key === "Enter"){
        sendMessage();
    }
});