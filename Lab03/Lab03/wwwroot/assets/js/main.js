let prices = [ ["Coffee", "$1.25", false], ["Tea", "$1.20", false], ["Beer", "$3.25", true], ["Wine", "$5.50", true] ];

function generateReceipt() {
    $("#age").attr('hidden', true);
    $("#rec").attr('hidden', true);

    let item = getItem(document.getElementById("beverage").value);
    let quantity = document.getElementById("quantity").value;

    document.getElementById("rec_customerName").innerHTML = document.getElementById("customerName").value;

    document.getElementById("rec_quantity").innerHTML = quantity + " ";
    document.getElementById("rec_beverage").innerHTML = document.getElementById("beverage").value;
    document.getElementById("rec_itemPrice").innerHTML = item[1];

    document.getElementById("rec_totalPrice").innerHTML = "$" + (parseFloat(item[1].substring(1)) * parseInt(quantity));
    $("#rec").removeAttr('hidden');

    checkLegality(item);
}

function getItem(item) {
    for (var i = 0; i < prices.length; i++) {
        if ( item === prices[i][0] ) {
            return prices[i];
        }
    }
    return -1;
}

function checkLegality(item) {
    if ( item[2] ) {
        let date = moment();
        let legalAge = date.subtract(21, "years");
        let customerBday = moment(document.getElementById("customerBirthdate").value, "YYYY-MM-DD");

        document.getElementById("beforeDate").innerHTML = legalAge.format("MM/DD/YYYY");
        document.getElementById("age_beverage").innerHTML = document.getElementById("beverage").value;

        if (customerBday <= legalAge) {
            document.getElementById("age").setAttribute("style", "background-color: green;");
        } else {
            document.getElementById("age").setAttribute("style", "background-color: red;");
        }
        $("#age").removeAttr('hidden');
    } else $("#age").attr('hidden', true);
}

function start() {
    $("#rec").attr('hidden', true);
    $("#age").attr('hidden', true);
}