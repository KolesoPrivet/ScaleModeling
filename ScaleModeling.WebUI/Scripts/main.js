$(document).ready(function ($) {
    $(".clickable-content").click(function () {
        window.location = $(this).data("href");
    });
});