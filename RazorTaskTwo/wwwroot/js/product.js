function SearchData() {
    var searchEle = document.getElementById("search").value;
    var searchData = document.getElementById("searchBar").value.toLowerCase();
    var table = document.getElementById("tblData");

    var rows = table.getElementsByTagName("tbody")[0].getElementsByTagName("tr");
    for (var i = 0; i < rows.length; i++)
    {
        var fieldCheck = rows[i].getElementsByTagName("td")[searchEle == "Name" ? 0 : (searchEle == "Category" ? 1 : 3)].textContent.toLowerCase();
        if (fieldCheck.indexOf(searchData)) {
            rows[i].style.display = "none";
        } else {
            rows[i].style.display = "";
        }
    }
}