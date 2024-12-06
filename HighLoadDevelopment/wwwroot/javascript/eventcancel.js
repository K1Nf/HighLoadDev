
const meetId = window.location.href.split("/")[5];

let urlToMeet = "/api/ref/meetingapi/" + meetId;
console.log(urlToMeet);
fetch(urlToMeet, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
})

.then(response => {
    if (response.status == 200) {
        return response.json();
    }

    throw new Error('Network response was not ok');
})

.then(data => {
    console.log(data);

    const name = data.name;
    const place = data.location;
    const date = getDate(data.date);
    const timeStart = data.timeStart;
    const timeEnd = data.timeEnd;
    const description = data.description;
    const maxGuests = data.maxGuest;
    const currGuests = data.currentGuestsCount;

    const tags = data.tagsDTO;
    let allTags = "";
    for (tag of tags) {
        allTags += tag.name + ", ";
    }

    document.getElementById("title").textContent = `Вы действительно хотите отменить встречу \n "${name}"?`;
    document.getElementById("title").style.fontSize = "1.8vw";
    document.getElementById("name1").textContent = name;
    document.getElementById("place").textContent = place;
    document.getElementById("dateandtime").textContent = date + " " + timeStart + " - " + timeEnd;
    document.getElementById("guests").textContent = currGuests + "/" + maxGuests;
    document.getElementById("description").textContent = description;
    document.getElementById("tags").textContent = allTags.slice(0, -2);

})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});



document.getElementById("cancelEvent").addEventListener("click", async () => {


    let urlToDeleteMeet = "/api/ref/meetingapi/delete/" + meetId;

    fetch(urlToDeleteMeet, {
        method: "DELETE",
        headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
    })
        .then(response => {
            if (response.status == 204)
                return response;
        })
        .then(data => {
            window.location.href = "/User";
        });


    if (response.ok === true) {
        const res = await response.text();
        console.log(res);
        
        //history goback(-2)???

    }
    else {
        console.log("VSE PLOHO");
    }
});


function getDate(date) {

    let dateS = date.split("-");
    let month = "";

    switch (+dateS[1]) {
        case 1:
            month = "янв";
            break;
        case 2:
            month = "фев";
            break;
        case 3:
            month = "мар";
            break;
        case 4:
            month = "апр";
            break;
        case 5:
            month = "май";
            break;
        case 6:
            month = "июн";
            break;
        case 7:
            month = "июл";
            break;
        case 8:
            month = "авг";
            break;
        case 9:
            month = "сен";
            break;
        case 10:
            month = "окт";
            break;
        case 11:
            month = "ноя";
            break;
        default:
            month = "дек";
    }

    return dateS[2] + " " + month + " " + dateS[0];
}
