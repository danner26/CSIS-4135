function toggleTheme() {
    var declaration = document.getElementsByTagName('html')[0];
    if (getComputedStyle(document.body).getPropertyValue('--body-color') == "white") {
        //Switch to purple major
        declaration.style.setProperty("--body-color", "rgb(144, 64, 219)");
        declaration.style.setProperty("--navbar-bg-color", "rgb(121, 47, 191)");
        declaration.style.setProperty("--background-color", "rgb(179, 122, 233)");
        declaration.style.setProperty("--section-text-color", "white");
    } else {
        //Switch to white major
        declaration.style.setProperty("--body-color", "white");
        declaration.style.setProperty("--navbar-bg-color", "rgb(179, 122, 233)");
        declaration.style.setProperty("--background-color", "rgb(144, 64, 219)");
        declaration.style.setProperty("--section-text-color", "black");
    }
}
