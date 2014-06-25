/// <reference path="jquery.unobtrusive-ajax.min.js" />
(function ($) {
    $(document).ready(function () {
        $('textarea.elastic').elastic();

        $('#btnTranslate').click(function (e) {
            e.preventDefault();
            $.ajax({
                method: 'POST',
                url: '/translate',
                data: {
                    text: $('#txtTranslateText').val()
                },
                success: function (result) {
                    $("#translate-result .contents").replaceWith($(result));
                }
            });
        });

    });
})(jQuery)