const listBtn = document.getElementById("buttonList");
const newList = document.getElementById("newList");

function creatnewlist() {
    const listItem = document.createElement("li");
    listItem.textContent = "Новый элемент";
    newList.appendChild(listItem);
}

listBtn.addEventListener("click", creatnewlist);