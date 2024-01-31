// Please see documentation at https://learn.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.


let lastKnownScrollPosition = 0;
let ticking = false;
const productContainer = document.getElementById("productContainer");
const card = document.getElementById("card");

function doSomething(scrollPos) {
    if (scrollPos > 50 || scrollPos > 50) {
        console.log("> 50")
    } else {
        console.log("youssf")

    }
}

productContainer.addEventListener("scroll", (event) => {
    //console.log(event)

    lastKnownScrollPosition = productContainer.scrollTop;
    //lastKnownScrollPosition = productContainer.scrollY;
    console.log(lastKnownScrollPosition)

    if (!ticking) {
        window.requestAnimationFrame(() => {
            doSomething(lastKnownScrollPosition);
            ticking = false;
        });

        ticking = true;
    }
});


