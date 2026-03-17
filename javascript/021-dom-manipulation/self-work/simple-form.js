function btnclick() {
    const tb = document.getElementById("textBox");
    tb.value = `Hello! ${tb.value}`;
}

const btn = document.getElementById("buttonclick");

btn.addEventListener("click", btnclick);


