const sayHelloUrl = "http://localhost:5209/api/hello";
const addTwoUrl = "http://localhost:5209/api/addtwo";
const greaterThanUrl = "http://localhost:5209/api/greaterthan";
const madLibsUrl = "http://localhost:5209/api/madlibs";
const magicUrl = "http://localhost:5209/api/magic";
const restaurantUrl = "http://localhost:5209/api/restaurant";

const addTwoForm = document.getElementById("add-two-form");
const greaterThanForm = document.getElementById("greater-than-form");
const madForm = document.getElementById("mad-form");
const num1Input = document.getElementById("num1-input");
const num2Input = document.getElementById("num2-input");
const adjectiveInput = document.getElementById("adjective");
const nounInput = document.getElementById("noun");
const pluralNounInput = document.getElementById("plural-noun");
const verbInput = document.getElementById("verb");
const colorInput = document.getElementById("color");
const secondAdjectiveInput = document.getElementById("adjective-two");
const madLibsNumberInput = document.getElementById("number");
const exclamationInput = document.getElementById("exclamation");
const secondNounInput = document.getElementById("noun-two");
const sillyWordsInput = document.getElementById("silly-words");
const madText = document.getElementById("mad-text");
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
const magicButton = document.getElementById("magic");
const madLibsButton = document.getElementById("madLibs");
const restaurantButton = document.getElementById("restaurant")
const magicForm = document.getElementById("magic-form");
const magicInput = document.getElementById("magic-input");
const magicText = document.getElementById("magic-text");
const mexicanButton = document.getElementById("mexican");
const italianButton = document.getElementById("italian");
const americanButton = document.getElementById("american");
const restaurantText = document.getElementById("restaurant-text");




const helloFetch = async (name) => {
    const response = await fetch(`${sayHelloUrl}/username?username=${name}`);
    const data = await response.json();
    console.log(data);
    return data;
} 


const additionFetch = async (numberOne, numberTwo) => {
    const response = await fetch(`${addTwoUrl}/addition/${numberOne}/${numberTwo}`);

    return await response.json();
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

        const numberOne = Number(num1Input.value);
        const numberTwo = Number(num2Input.value);

        const output = await additionFetch(numberOne, numberTwo);
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

if (madForm) {
    madForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const words = [
            adjectiveInput.value.trim(),
            nounInput.value.trim(),
            pluralNounInput.value.trim(),
            verbInput.value.trim(),
            colorInput.value.trim(),
            secondAdjectiveInput.value.trim(),
            madLibsNumberInput.value.trim(),
            exclamationInput.value.trim(),
            secondNounInput.value.trim(),
            sillyWordsInput.value.trim()
        ];

        const response = await fetch(`${madLibsUrl}/game/${words.join("/")}`);
        const data = await response.json();

        madText.textContent = data.message;
    });
}

if (magicForm) {
    magicForm.addEventListener("submit", async (event) => {
        event.preventDefault();

        const input = magicInput.value.trim();
        const response = await fetch(`${magicUrl}/answer?input=${input}`);
        const data = await response.json();

        magicText.textContent = data.message;
    });
}

const chooseRestaurant = async (cuisine) => {
    const response = await fetch(`${restaurantUrl}/${cuisine}`);
    const data = await response.json();
    restaurantText.textContent = data.message;
};

if (mexicanButton) {
    mexicanButton.addEventListener("click", () => chooseRestaurant("mexican"));
}

if (italianButton) {
    italianButton.addEventListener("click", () => chooseRestaurant("italian"));
}

if (americanButton) {
    americanButton.addEventListener("click", () => chooseRestaurant("american"));
}

if (sayHelloButton) {
    sayHelloButton.addEventListener("click", () => {
        window.location.href = "hello.html";
    });
}

if (twoNumbersButton) {
    twoNumbersButton.addEventListener("click", () => {
        window.location.href = "addtwo.html";
    });
}

if (greaterLessButton) {
    greaterLessButton.addEventListener("click", () => {
        window.location.href = "greaterthan.html";
    });
}

if (magicButton){
    magicButton.addEventListener("click", () => {
        window.location.href = "magic.html";
    });
}

if (madLibsButton){
    madLibsButton.addEventListener("click", () => {
        window.location.href = "madlibs.html";
    });
}

if (restaurantButton){
    restaurantButton.addEventListener("click", () => {
        window.location.href = "restaurant.html";
    });
}