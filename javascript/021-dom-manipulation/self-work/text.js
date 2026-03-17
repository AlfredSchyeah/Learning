function btnClick() {
    textContainer.innerHTML = "New text";
}

const changeText = document.getElementById("changeText");
const textContainer = document.getElementById("text");

changeText.addEventListener("click", btnClick);