// Scrolls the window every time there is new text at the bottom
function ScrollWindow() {
    const textarea = document.getElementById('pcscreen');
    textarea.scrollTop = textarea.scrollHeight;
};

// Spawns random generated dollar bills

let id = 0;


function SpawnFallingImg() {
    // Makes a unique id every time for the dollars
    id++

    // Take a random img 
    const imgDollarArray = ["money1.png", "money2.png", "money3.png", "money4.png"]
    const randomindex = Math.floor(Math.random() * imgDollarArray.length)
    let randomDollarImg = imgDollarArray[randomindex]

    // Creates a dollar img with a random id and random picture
    const bg = document.querySelector('.background');
    const img = document.createElement("img");
    img.setAttribute("id", `dollar${id}`);
    img.classList.add('fallingimage');
    img.src = `./img/${randomDollarImg}`;
    bg.appendChild(img);

    // Removes the img again when their animation is ended
    RemoveFallingImg(id)
};

// Removes random generated dollar bills

function RemoveFallingImg(id) {
    const img = document.querySelector(`#dollar${id}`);
    img.addEventListener("animationend", function () {
        img.remove();
    })
};

// Decreases the powerbar

function TempHelperFunction(i) {
    const progressbar = document.getElementById('energybar');
    const progressLine = progressbar.querySelector('.progress');
   
    progressLine.style.width = i + '%';
    progressLine.textContent = i + '%';
}

function EnergyBar(i, progresslevel) {
    let progress = progresslevel;
    const progressbar = document.getElementById('energybar');
    const progressLine = progressbar.querySelector('.progress');
    if (progress > 0) {
        progress -= i;
        progressLine.style.width = progresslevel + '%';
        progressLine.textContent = progress + '%';
    }

};