const colourArray = ['Red', 'Yellow', 'Blue', 'Green'];
let userArray = [];
let gameArray = [];


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

        increaseUserArray(color);
        scoreCounter();
        colourSequence();

        console.log("userarray", userArray);

        Array.from(gameArray).forEach(function (colour) {
                highlightButton(colour);
        });



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

        startButton.disabled = true;

        let array = colourSequence();
        let colour = array[0];
        highlightButton(colour);
    });
}

function highlightButton(buttonColour) {
    let btnColour = String(buttonColour).toLowerCase();
    const highlightedBtn = document.getElementById(btnColour + "-btn");

    setTimeout(function () {
        highlightedBtn.style.backgroundColor = "white";
    }, 1000)

    setTimeout(function () {
        highlightedBtn.style.backgroundColor = buttonColour;
    }, 1500)
}

let scoreCounter = function () {
    if (JSON.stringify(userArray) === JSON.stringify(gameArray)) {
        console.log("win");
        userArray = [];
        }
    else {
        console.log("lose");
    }
}

function increaseUserArray(colour) {
    userArray.push(colour);
}

function colourSequence() {
    const randomColour = colourArray[Math.floor(Math.random() * colourArray.length)];
    gameArray.push(randomColour);
    console.log("gamearray", gameArray);
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

