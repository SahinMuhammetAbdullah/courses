// clock.js

// Get current time and format
function getTime() {
    let date = new Date(),
        min = date.getMinutes(),
        sec = date.getSeconds(),
        hour = date.getHours();
    return "" + (hour < 10 ? ("0" + hour) : hour) + ":" + (min < 10 ? ("0" + min) : min) + ":" + (sec < 10 ? ("0" + sec) : sec);
}

// Set up the clock
function updateClock() {
    document.getElementById("clock").innerHTML = getTime();
}

// Set clock interval to tick clock
window.onload = () => {
    updateClock(); // sayfa yüklendiğinde bir kere çalıştır
    setInterval(updateClock, 1000); // her saniyede bir güncelle
};
