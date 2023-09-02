var ping = new Audio("../sounds/paper-rip.ogg")
ping.load();

window.TESTPROPERTY = this;
console.log('test')
document.getElementById("calendar").addEventListener("mousedown", function () {ping.play()});