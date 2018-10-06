$(document).ready(function () {
    var request = $.ajax({
        url: 'Home/TodoItemsPartial',
        type: 'get',

    });
    /*
    request.done(function (data) {
        console.info(data);
        data.forEach(function (item) {
            let element = '<div>' + item.Id + ' | ' + item.Description + '</div>';
            $('#items-container').append(element);
        });
    });
    request.fail(function (jqXHR, status) {
        console.log(status);
    });*/
    $("#btnProbando").click(function () {
        request.done(function(data) {
            console.info(data);
            $('#items-container').html(data);
            $("#loquito").html(Object.keyAt(data));
        });
    });
});