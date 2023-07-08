const colourArray = ['red', 'yellow', 'blue', 'green'];
let intervalId;


function clickButton(buttonid, color) {
    const button = document.getElementById(buttonid);
    button.addEventListener('click', function () {
        button.style.backgroundColor = "white";
        button.style.width = "320px";
        button.style.height = "320px"

        setTimeout(function () {
            button.style.backgroundColor = color;
            button.style.width = "300px";
            button.style.height = "300px"
        }, 100);

    });
}

function clickStartButton() {
    const startButton = document.getElementById("start-btn");

    startButton.addEventListener('click', function () {
        startButton.style.backgroundColor = "white";
        startButton.style.width = "220px";
        startButton.style.height = "55px"

        setTimeout(function () {
            startButton.style.backgroundColor = "chartreuse";
            startButton.style.width = "200px";
            startButton.style.height = "50px"
        }, 100)

        const buttons = document.getElementsByClassName('btn');
        Array.from(buttons).forEach(function (button) {
            button.disabled = false;
        });

        let array = colourSequence();
        let colour = array[0];

        console.log(colour);

        highlightButton(colour);
    });
}

function highlightButton(buttonColour) {
    let highlightedBtn = document.getElementById(buttonColour + "-btn");
    setInterval(function () {
        highlightedBtn.classList.add("highlight");
    }, 1000)
}

let scoreCounter = function () {

}

function colourSequence() {
    const gameArray = [];
    console.log(colourArray);
    const randomColour = colourArray[Math.floor(Math.random() * colourArray.length)];
    gameArray.push(randomColour);
    console.log(gameArray);
    return gameArray;
}



//iterate through colour array 
//select a colour
//add that colour to new array

clickStartButton();
clickButton("red-btn", "Red");
clickButton("yellow-btn", "Yellow");
clickButton("blue-btn", "Blue");
clickButton("green-btn", "Green");

