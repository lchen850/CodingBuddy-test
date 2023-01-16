
    const toggleButton = document.getElementById("toggle-button");
    const mainNavList = document.getElementById("navbar-list");
    const loginList = document.getElementById("login-list");

    toggleButton.addEventListener("click", () => {
        mainNavList.classList.toggle("active");
        loginList.classList.toggle("active");
    })
