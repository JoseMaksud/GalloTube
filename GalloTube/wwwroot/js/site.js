// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function showLoading() {
    const loader = document.querySelector('.loader');
    if (loader != null) {
        loader.classList.remove('d-none');
    }
};

function hideLoading() {
    const loader = document.querySelector('.loader');
    if (loader != null) {
        loader.classList.add('d-none');
    }
};

$(document).ready(function () {
    hideLoading();
});

document.addEventListener('DOMContentLoaded', function() {
    var form = document.querySelector('form');
    console.log(form);
    if (form != undefined){ 
        form.addEventListener('submit', function() {
            if ($(form).valid() === true) 
                showLoading();
        })
    }
});