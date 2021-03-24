const customersListBox = document.getElementById('customers');
const productsListBox = document.getElementById('products');
const quantityInput = document.getElementById('quantity');

function calculate() {
    let quantity = parseFloat(quantityInput.value);
    let customerId = parseFloat(customersListBox.options[customersListBox.selectedIndex].value);
    let productId = parseFloat(productsListBox.options[productsListBox.selectedIndex].value);
    let data = { customerId: customerId, productId: productId, quantity: quantity };
    fetch("api/CalculatePrice", {
        method: 'POST',
        headers: {
            'Accept': 'application/json',
            'Content-Type': 'application/json'
        },
        body: JSON.stringify(data)
    })
        .then(response => response.json())
        .then(data => document.getElementById('result').innerText = data)
        .catch(error => console.error('Unable to get items.', error));
}


function getItems(url, dropdown) {
    fetch(url)
        .then(response => response.json())
        .then(function (data) {
            console.log(data);
            let option;
            for (let i = 0; i < data.length; i++) {
                option = document.createElement('option');
                option.text = data[i].name;
                option.value = data[i].id;
                dropdown.add(option);
            }
        })
        .catch(error => console.error('Unable to get items.', error));
}

getItems("api/GetProducts", productsListBox);
getItems("api/GetCustomers", customersListBox);
