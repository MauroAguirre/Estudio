$(document).ready(() => {
    const request = $.ajax({
        url: 'Home/TodoItems',
        type: 'get'
    });

    request.done((data) => {
        console.info(data);
        data.forEach((item) => {
            let element = `<div>${item.Id} | ${item.Description}</div>`;
            $('#items-container').append(element);
        });
    });

    request.fail((jqXHR, status) => {
        console.log(status);
    });

    loadView("items-container-partial-view-1");
});

function dobleLlamada() {
    loadView("items-container-partial-view-1");
    // loadView("items-container-partial-view-2");
}

function loadView(destinationElement) {
    const request = $.ajax({
        url: 'Home/TodoItemsPartial',
        type: 'get'
    });


    request.done((data) => {
        $(`#${destinationElement}`).html(data);
    });
    return false;
};

function submitWithAJAX() {
    console.info("WWWWWWWWWWWWWIIIIIIIIIIIIIIIII!!!!!!!!!!!!!");
    // $('#todo-item-form').submit(function (event) {
    $('#todo-item-form').submit((event) => {
        let formData = {
            'description': $('input[name=description]').val()
        };

        $.ajax({
            type: 'POST',
            url: $('#todo-item-form').attr('action'),
            data: formData,
            //dataType: 'json',
            encode: true
        }).done((data) => {
            console.info("done", data);
        });
        event.preventDefault();
    });
    return false;
};

const showDataOnModal = () => {
    const options = { show: true };
    loadViewModal().then(() => {
        $('#exampleModal').modal(options);
    });
}

function loadViewModal() {
    let promise = new Promise((resolve, reject) => { // function(a,b)
        const request = $.ajax({
            url: 'Home/TodoItemsPartial',
            type: 'get'
        });
        request.done((data) => {
            $(`.modal-body`).html(data);
            resolve();
        });
    });
    return promise;
};