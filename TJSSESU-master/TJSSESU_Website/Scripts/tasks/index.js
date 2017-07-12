/**
 * Created by hongh on 2017/7/10.
 */
$(document).ready(function(){
    $("#submitBt").click(function(){
        $.ajax({
            type: "POST",
            url:"submit",
            data:$('#submitBt').value,
            error: function(request) {
                alert("Connection error");
            },
            success: function(data) {
                $("#submitBt").attr('disabled',true);
                $("#submitBt").html("Submitted");
                $("#submitBt").removeClass("uk-button-primary");
            }
        })
    })

    $("#checkBt").click(function(){
        $.ajax({
            type: "POST",
            url:"check",
            data:$('#checkBt').value,
            error: function(request) {
                alert("Connection error");
            },
            success: function(data) {
                $("#submitBt").attr('disabled',true);
                $("#submitBt").html("Done");
                $("#submitBt").removeClass("uk-button-primary");
            }
        })
    })
})
