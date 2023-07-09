const colourArray = ['Red', 'Yellow', 'Blue', 'Green'];
let userArray = [];
let gameArray = [];
const timer = ms => new Promise(res => setTimeout(res, ms))
let score = 0;
let highScore = 0;
const scoreCount = document.getElementById("score-counter");
const buttons = document.getElementsByClassName('btn');
const startButton = document.getElementById("start-btn");
const highScoreCounter = document.getElementById("high-score-counter");
const title = document.getElementById("title");
const bruh = new Audio('bruh.mp3');
const derp = new Audio('derp.mp3');
const meow = new Audio('meow.mp3');
const jojo = new Audio('jojo.mp3');

//Program
clickStartButton();
clickButton("red-btn", "Red");
clickButton("yellow-btn", "Yellow");
clickButton("blue-btn", "Blue");
clickButton("green-btn", "Green");


function clickStartButton() {
    startButton.addEventListener('click', function () {

        title.textContent = "Game Started";

        startButton.style.backgroundColor = "white";
        startButton.style.width = "220px";
        startButton.style.height = "55px"

        setTimeout(function () {
            startButton.style.backgroundColor = "chartreuse";
            startButton.style.width = "200px";
            startButton.style.height = "50px"
        }, 100)

        startButton.disabled = true;

        let array = colourSequence();
        let colour = array[0];
        highlightButton(colour);

        enableButtons();

    });
}

function clickButton(buttonid, color) {

    const button = document.getElementById(buttonid);

    button.addEventListener('click', function () {
        button.style.backgroundColor = "white";
        button.style.width = "320px";
        button.style.height = "320px"

        playSound(color);

        setTimeout(function () {
            button.style.backgroundColor = color;
            button.style.width = "300px";
            button.style.height = "300px"
        }, 100);

        increaseUserArray(color);
        scoreCounter();

        console.log("userarray", userArray);
    });
}

function playSound(color) {
    if (color === "Red") {
        bruh.play();
    }

    else if (color === "Yellow") {
        derp.play();
    }

    else if (color === "Blue") {
        meow.play();
    }

    else {
        playJojo();
    }
}

function playJojo() {
    jojo.currentTime = 0.3;
    jojo.play();

    setInterval(function () {
        if (jojo.currentTime > 1.5) {
            jojo.pause();
        }
    }, 1000);
}

async function memorySequence() {

    Array.from(buttons).forEach(function (button) {
        button.disabled = true;
    });

    for (let i = 0; i < gameArray.length; i++) {
        highlightButton(gameArray[i]);
        await timer(1000);
    }

    enableButtons();
}

async function enableButtons() {
    await timer(2000);

    Array.from(buttons).forEach(function (button) {
        button.disabled = false;
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
        score++
        console.log("win");
        userArray = [];

        memorySequence();

        colourSequence();

        scoreCount.textContent = "Score: " + score;
    }

    else {
        for (let i = 0; i < userArray.length; i++) {
            if (userArray[i] !== gameArray[i]) {
                if (score >= highScore) {
                    highScore = score;
                    highScoreCounter.textContent = "High Score: " + highScore;
                }

                score = 0;
                scoreCount.textContent = "Score: " + score;

                Array.from(buttons).forEach(function (button) {
                    button.disabled = true;
                });
                startButton.disabled = false;

                userArray = [];
                gameArray = [];

                title.textContent = "GAME OVER"
            }
        }
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

