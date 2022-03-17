

document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('addBtn').addEventListener('click', addNumbers)
});

document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('subtractBtn').addEventListener('click', subtractNumbers)
});

document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('multiplyBtn').addEventListener('click', multiplyNumbers)
});

document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('divideBtn').addEventListener('click', divideNumbers)
});

document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('newHobbyBtn').addEventListener('click', addHobbies)
});

document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('stringAddBtn').addEventListener('click', stringAdd)
});
document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('stringDeleteBtn').addEventListener('click', stringDelete)
});
document.addEventListener('DOMContentLoaded', function (event) {
    document.getElementById('clearArray').addEventListener('click', arrayClear)
});

function addNumbers() {
    const n1 = document.querySelector(".in1");
    const n2 = document.querySelector(".in2");
    const result = parseInt(n1.value) + parseInt(n2.value);
    document.getElementById("result").innerHTML = result;
}

function subtractNumbers() {
    const n1 = document.querySelector(".in1");
    const n2 = document.querySelector(".in2");
    const result = parseInt(n1.value) - parseInt(n2.value);
    document.getElementById("result").innerHTML = result;
}

function multiplyNumbers() {
    const n1 = document.querySelector(".in1");
    const n2 = document.querySelector(".in2");
    const result = parseInt(n1.value) * parseInt(n2.value);
    document.getElementById("result").innerHTML = result;
}

function divideNumbers() {
    const n1 = document.querySelector(".in1");
    const n2 = document.querySelector(".in2");
    if (parseFloat(n2.value) != 0) {
        const result = parseFloat(n1.value) / parseFloat(n2.value);
        document.getElementById("result").innerHTML = result;
    }
    else {
        document.getElementById("result").innerHTML = "undefined";
        alert("Cannot divide by 0");
    }
}

function addHobbies() {
    const inputList = document.querySelectorAll('.hobbiesInput');
    if (inputList.length < 5) {
        const hobbiesList = document.getElementById('hobbiesList');
        const newlineelement = CreateNode('br'),
            inputElement = CreateNode('input');
        inputElement.setAttribute("class", "hobbiesInput");
        append(hobbiesList, newlineelement);
        append(hobbiesList, inputElement);
    }
    else {
        document.getElementById('newHobbyBtn').removeEventListener('click', addHobbies);
    }
}

function CreateNode(element) {
    return document.createElement(element);
}

function append(parent, el) {
    return parent.appendChild(el);
}

let strings = [];

function stringAdd() {
    console.log(strings);

    if (strings.length < 5) {
        const newEl = document.getElementById('input3').value;
        strings.push(newEl);
    }
    else {
        alert("The array is full");
        document.getElementById('stringAddBtn').disabled = true;
    }
    displayArray();
}

function displayArray() {
    document.getElementById('arrayOutput').innerHTML = '';
    for (var i = 0; i < strings.length; i++) {
        document.getElementById('arrayOutput').innerHTML += `<li>${strings[i]}</li>`;
    }
}

function stringDelete() {
    const stringToDel = document.getElementById('input3').value;
    strings.splice(stringToDel - 1, 1);
    displayArray();
    document.getElementById('stringAddBtn').disabled = false;
}

function arrayClear() {
    strings = [];
    displayArray();
}