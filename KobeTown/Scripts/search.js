function searchProducts() {
    var keyword = document.getElementById('searchInput').value;
    var url = '/YourController/Search?keyword=' + encodeURIComponent(keyword);

    var xhr = new XMLHttpRequest();
    xhr.open('GET', url, true);

    xhr.onload = function () {
        if (xhr.status >= 200 && xhr.status < 300) {
            var products = JSON.parse(xhr.responseText);
            displaySearchResults(products);
        } else {
            console.error('Yêu cầu thất bại với mã trạng thái', xhr.status);
        }
    };

    xhr.onerror = function () {
        console.error('Yêu cầu thất bại');
    };

    xhr.send();
}

function displaySearchResults(products) {
    var resultsDiv = document.getElementById('searchResults');
    resultsDiv.innerHTML = '';

    products.forEach(function (product) {
        var productDiv = document.createElement('div');
        productDiv.textContent = product.Name;
        resultsDiv.appendChild(productDiv);
    });
}