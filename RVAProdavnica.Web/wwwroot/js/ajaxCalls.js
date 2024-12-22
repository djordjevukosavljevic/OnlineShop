function TableSearch(dataObject, url, data) {
    $.ajax({
        method: "GET",
        url: url,
        data: data,
        success: function (response) {
            console.log("(|)");
            var len = $(response).find('.counter-rows').length;
            if (len != null && len > 0) {
                dataObject.append(response);
                $(".row-helper").fadeIn();
            }
            if (pageNumber > 1) {
                $("#load-older").html("Load older...");
                $("#load-older").prop('disabled', false);
            } else {
                $("#load-older").html("No older data...");
                $("#load-older").prop('disabled', true);
            }
            if (len < 5) {
                $("#load-more").html("No more data...");
                $("#load-more").prop('disabled', true);
            } else {
                $("#load-more").html("Load more...");
                $("#load-more").prop('disabled', false);
            }
        },
        error: function () {
            alert("Product loading error!");
        }
    });
}
