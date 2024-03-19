document.addEventListener('contextmenu', function(e) {
    e.preventDefault();
});
function handleKeyDown(event) {
    if (event.keyCode === 123 || (event.ctrlKey && event.shiftKey && event.keyCode === 73)) 
    {
        event.preventDefault();
    }
}
document.addEventListener("keydown", handleKeyDown);