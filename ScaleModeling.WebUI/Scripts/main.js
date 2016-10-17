// Clickable content handler
$(document).ready(function ($) {
    $(".clickable-content").click(function () {
        window.location = $(this).data("href");
    });
});