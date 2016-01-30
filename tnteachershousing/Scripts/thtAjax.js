
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

$('#pagedisplay').on ('click','#editproject',(function (e) {
    e.preventDefault();
    //alert($(this).attr('title'));
    var projectid = $(this).attr('title');
    $.ajax({
        url: '/Admin/EditProject/'+ projectid,
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
}));


$('#customerindex').click(function (e) {
    e.preventDefault();
    $.ajax({
        url: '/Admin/CustomerIndex',
        type: "GET",
        headers: { "x-access-token": secure.getToken(), "x-access-finger": finger.getFinger() },
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

