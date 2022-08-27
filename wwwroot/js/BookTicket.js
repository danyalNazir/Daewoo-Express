var seatsDic = [];
counter = 0;
quantity = 0;
function seatClick(id) {
    var seatview = document.getElementById(id);
    var seatsField = document.getElementById("Seats");
    var quantityField = document.getElementById("Quantity");
    var amountField = document.getElementById("Amount");
    var fare = document.getElementById("Fare").value;

    var index;
    if (seatsDic.length < 5) {
        if (counter == 0) {
            if (seatsDic.length < 1) {
                console.log("1st");
                seatsDic.push({
                    seatNo: seatview.innerText,
                    value: seatview.innerText,
                });
                seatview.style.backgroundImage =
                    "url(https://www.daewoo.com.pk/Theme/Images/male_seat.png)";
                counter += 1;
                quantity += 1;
            } else if (seatsDic.length >= 1) {
                for (let seat in seatsDic) {
                    if (seatsDic[seat].value === seatview.innerText) {
                        index = seatsDic.findIndex((i) => i.value === seatview.innerText);
                        console.log("2nd");
                        seatsDic.splice(index, 1);
                        seatview.style.backgroundImage =
                            "url(https://www.daewoo.com.pk/Theme/Images/empty_seat.png)";
                        counter += 1;
                        quantity -= 1;
                    }
                }
            }
        } else if (counter >= 1) {
            for (let seat in seatsDic) {
                if (seatsDic[seat].value != seatview.innerText) {
                    console.log("3rd");
                    index = -1;
                } else if (seatsDic[seat].value === seatview.innerText) {
                    index = seatsDic.findIndex((i) => i.value === seatview.innerText);
                    console.log("4th");
                    break;
                }
            }
            if (index === -1) {
                seatsDic.push({
                    seatNo: seatview.innerText,
                    value: seatview.innerText,
                });
                seatview.style.backgroundImage =
                    "url(https://www.daewoo.com.pk/Theme/Images/male_seat.png)";
                counter += 1;
                quantity += 1;
            } else {
                seatsDic.splice(index, 1);
                seatview.style.backgroundImage =
                    "url(https://www.daewoo.com.pk/Theme/Images/empty_seat.png)";
                counter -= 1;
                quantity -= 1;
            }
        }
        var selectedSeats = "";
        for (let seat in seatsDic) {
            selectedSeats += `${seatsDic[seat].value},`;
        }
        seatsField.value = selectedSeats;
        quantityField.value = quantity;
        amountField.value = quantity * fare;
        console.log(selectedSeats.length);
    }
    else {
        alert("You can Book 5 seats at max!");
    }
}