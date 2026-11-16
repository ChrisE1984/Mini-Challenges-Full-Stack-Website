const sayHelloUrl = "http://localhost:5209/api/hello";
const addTwoUrl = "http://localhost:5209/api/addtwo";
const greaterThanUrl = "http://localhost:5209/api/greaterthan";

const addTwoForm = document.getElementById("add-two-form");
const greaterThanForm = document.getElementById("greater-than-form");
const num1Input = document.getElementById("num1-input");
const num2Input = document.getElementById("num2-input");
const addTwoButton = document.getElementById("addTwoNumbers");
const greaterThanButton = document.getElementById("greaterThan");
const twoNumbersButton = document.getElementById("twoNumbers");
const greaterLessButton = document.getElementById("greaterLess");
const numOneInput = document.getElementById("numOne-input");
const numTwoInput = document.getElementById("numTwo-input");
const greaterThanResult = document.getElementById("greater-than-result");
const sayHelloForm=document.getElementById("say-hello-form");
const nameInput= document.getElementById("name-input")
const sayHelloButton1=document.getElementById("sayHello1");
const sayHelloButton=document.getElementById("sayHello");
const addOutput=document.getElementById("add-output");
const sayHelloOutput=document.getElementById("hello-result");
const homeButton= document.getElementById("home")



const helloFetch = async (name) => {
    const response = await fetch(`${sayHelloUrl}/username?username=${name}`);
    const data = await response.json();
    console.log(data);
    return data;
} 


const additionFetch = async (numberOne, numberTwo) => {
    const response = await fetch(`${addTwoUrl}/addition/${numberOne}/${numberTwo}`);
    const data = await response.json();
    console.log(data);
    return data;
}           

const APIFetch = async (url) => {
    //we need to await our fetch here and store it in a variable
    const res = await fetch(url);
    const data = await res.json();
    return data.message;// returns json object with message property we set in the controller
}

if (sayHelloForm) {
    sayHelloForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const output = await helloFetch(nameInput.value.trim());
        sayHelloOutput.textContent = output.message;
    });
}

if (addTwoForm) {
    addTwoForm.addEventListener("submit", async (event)=>{
        event.preventDefault();

        const output = await additionFetch(num1Input.value, num2Input.value);
        addOutput.textContent = output.message;
    });
}

if (greaterThanForm) {
    greaterThanForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const numOne = numOneInput.value;
        const numTwo = numTwoInput.value;

        const response = await fetch(`${greaterThanUrl}/compare/${numOne}/${numTwo}`);
        const data = await response.json();
        greaterThanResult.textContent = data.result;
    });
}

sayHelloButton.addEventListener("click", () => {
    window.location.href = "hello.html";
});

twoNumbersButton.addEventListener("click", () => {
    window.location.href = "addtwo.html";
});

greaterLessButton.addEventListener("click", () =>{
    window.location.href = "greaterthan.html";
})

homeButton.addEventListener("click", () =>{
    window.location.href = "index.html";
})