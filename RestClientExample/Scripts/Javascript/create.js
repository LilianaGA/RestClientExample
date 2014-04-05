

$("#create").click(function () {
    
    var name = $('#name').val();
    var url = $('#url').val();
    var action = $('#action').val();

    /*console.log(name);
    console.log(url);
    console.log(action);*/


    $.ajax({
        url: 'Create',
        type: 'POST',
        data: {
            name: name,
            url: url,
            action :action
        }
    }).done(function (data) {
        alert('Insertado');
    }).fail(function (data, jqxhr) {
        console.log(data);
        console.log(jqxhr);
    });


});



