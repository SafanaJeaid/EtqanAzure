// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function changeactive(pname) {

    //console.log(pname);

    localStorage.setItem("activepage", pname);
}

$(function () {
    var pname = localStorage.getItem("activepage");

    if (pname == "Home" || pname == "" || pname == null) {
        $("ul.navbar-nav li.nav-item:nth-child(1) a").addClass("active-item");
        $("ul.navbar-nav li.nav-item:nth-child(2) a").addClass("normal-item");
    } else {
        $("ul.navbar-nav li.nav-item:nth-child(1) a").addClass("normal-item");
        $("ul.navbar-nav li.nav-item:nth-child(2) a").addClass("active-item");
    }
})