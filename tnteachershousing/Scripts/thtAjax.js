
$('#createproject').click(function (e) {
    e.preventDefault();
    $.ajax({
        url: '/Admin/CreateProject',
        type: "GET",
        dataType: "html",
       cache: false,
        success: function (data) {
            //Fill div with results
            $("#pagedisplay").html(data);
        },
        error: function (xhr, status, error) {
            $("#pagedisplay").html("<p>Error occured during processing</p>");
        }
    });
});

$('#projectindex').click(function (e) {
    e.preventDefault();
    $.ajax({
        url: '/Admin/ProjectIndex',
        type: "GET",
        dataType: "html",
        cache: false,
        success: function (data) {
            //Fill div with results
            $("#pagedisplay").html(data);
        },
        error: function (xhr, status, error) {
            $("#pagedisplay").html("<p>Error occured in processing</p>")
        }
    });
});
