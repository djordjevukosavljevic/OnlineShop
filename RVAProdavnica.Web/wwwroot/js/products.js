var pageNumber = 1;
var rowsPerPage = 10;
$(document).ready(function () {
    var url = "/Administration/Product/Rows";
    var dataObject = $("#product-panel");
    var search = $("#search").val();
    var data = { "pageNumber": pageNumber, "rowsPerPage": rowsPerPage, "search": search }
    TableSearch(dataObject, url, data);

    $("#load-more").click(function () {
        dataObject.empty();
        pageNumber++;
        search = $("#search").val();
        data = { "pageNumber": pageNumber, "rowsPerPage": rowsPerPage, "search": search }
        TableSearch(dataObject, url, data);
    });

    $("#load-older").click(function () {
        dataObject.empty();
        if (pageNumber <= 1) {
            pageNumber = 1;
        } else {
            pageNumber--;
        }
        search = $("#search").val();
        data = { "pageNumber": pageNumber, "rowsPerPage": rowsPerPage, "search": search }
        TableSearch(dataObject, url, data);
    });

    $("#search").keyup(function () {
        dataObject.empty();

        pageNumber = 1;
        search = $("#search").val();
        data = { "pageNumber": pageNumber, "rowsPerPage": rowsPerPage, "search": search };
        TableSearch(dataObject, url, data);

    });
});