
let url = "/api/ref/userApi/";

//var cks = document.cookie.split("; ");
//console.log(cks);



const userId = window.location.href.split("/")[4];

if (userId != undefined) {
    url += userId;
}


fetch(url, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
})
.then(response => {
    if (response.status == 200) {
        return response.json();
    }
    throw new Error('Network response was not ok');
})

    .then(data => {
        console.log(data);
        putUserDataOnPage(data);
        putOwnEventsOnPage(data.meetingsDTO);

        const userUrl = "/api/ref/userApi/verify/" + userId;
        console.log(userUrl);

        console.log(data.userName);
        console.log(userSessionName);
        if (data.userName != userSessionName) {
            console.log("not own");
        }
        else {
            console.log("my page");
        }
        //fetch(userUrl, {
        //    method: "GET",
        //    headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
        //})

        //    .then(response => {
        //        if (response.status == 200) {

        //            return response.json();
        //        }
        //        throw new Error('Network response was not ok');
        //    })

        //    .then(data => {

        //        console.log(data);
        //        if (data) {
        //            getGuestsEvents();
        //        }
        //    })
    })
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});
   

//function getGuestsEvents() {
//    const guestsEvents = "/api/ref/meetingApi/ByUserId";
//    fetch(guestsEvents, {
//        method: "GET",
//        headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
//    })
//        .then(response => {
//            if (response.status == 200) {
//                return response.json();
//            }
//            throw new Error('Network response was not ok');
//        })

//        .then(data => {
//            console.log(    data);
//            putGuestsEventsOnPage(data);
//        });
//}


function putUserDataOnPage(user){

    const username = user.userName;

    document.getElementsByTagName("title")[0].textContent = username;

    const firstname = user.firstName;
    const lastname = user.lastName;
    const secondname = user.secondName;
    const information = user.information;
    const phone = user.phoneNumber;
    const email = user.email;


    const city = user.city;
    const rating = user.rating;
    const imageLink = user.imageLink;


    const tags = user.tagsDTO;
    let allTags = "";
    for (tag of tags) {
        allTags += tag.name + ", ";
    }

    document.getElementById("fullname").textContent = lastname + " " + firstname + " " + secondname;
    document.getElementById("picture").src = imageLink;
    document.getElementById("nickandrating").textContent = username + " (" + rating + ")";
    const phoneData = document.getElementById("phone");
    phoneData.textContent = phone;
    phoneData.style.margin = 0;

    const emailData = document.getElementById("email")
    emailData.textContent = email;
    emailData.style.margin = 0;

    const locationData = document.getElementById("location")
    locationData.textContent = city;
    locationData.style.margin = 0;

    const informationData = document.getElementById("information")
    informationData.textContent = information;
    informationData.style.margin = 0;

    const tagsData = document.getElementById("tags")
    tagsData.textContent = allTags.slice(0, -2);
    tagsData.style.margin = 0;
}


function putOwnEventsOnPage(events) {

    const myevtable = document.getElementById("myeventstable");


    for (let i = 0; i < events.length; i++) {

        const tr = document.createElement("tr");
        myevtable.appendChild(tr);


        const td1 = document.createElement("td");
        td1.textContent = getStatus(events[i].status);
        tr.append(td1);


        const td2 = document.createElement("td");
        td2.textContent = events[i].name;
        tr.append(td2);


        const date = getDate(events[i].date);
        const td3 = document.createElement("td");
        td3.textContent = date + "\n" + events[i].timeStart.slice(0, -3) + " - " + events[i].timeEnd.slice(0, -3);
        tr.append(td3);


        const td4 = document.createElement("td");
        td4.textContent = events[i].currentGuestsCount + "/" + events[i].maxGuest;
        tr.append(td4);



        var anc = document.createElement("a");
        anc.href = "/meets/" + events[i].id;            //"../../api/EventsApi/Event/" + events[i].id;
        anc.textContent = "Подробнее ";
        

        const td5 = document.createElement("td");
        td5.appendChild(anc);
        tr.append(td5);        
    }
}



function putGuestsEventsOnPage(events) {

    const myevtable = document.getElementById("guestsevents");


    for (let i = 0; i < events  .length; i++) {
        const tr = document.createElement("tr");
        myevtable.appendChild(tr);


        const td1 = document.createElement("td");
        td1.textContent = getStatus(events[i].status);
        tr.append(td1);


        const td2 = document.createElement("td");
        td2.textContent = events[i].user.userName;
        tr.append(td2);


        const td3 = document.createElement("td");
        td3.textContent = events[i].name;
        tr.append(td3);


        const date = getDate(events[i].date);
        const td4 = document.createElement("td");
        td4.textContent = date + "\n" + events[i].timeStart.slice(0, -3) + " - " + events[i].timeEnd.slice(0, -3);
        tr.append(td4);


        var anc = document.createElement("a");
        anc.href = "/meets/" + events[i].id;   // "../api/EventsApi/Event/" + events[i].id;
        anc.textContent = "Подробнее ";

        const td5 = document.createElement("td");
        td5.appendChild(anc);
        tr.append(td5);      
    }
}



function getStatus(num) {
    if (num == 0) {
        return "Запланировано";
    }
    if (num == 1) {
        return "В процессе";
    }
    if (num == 2) {
        return "Завершено";
    }
    if (num == 3) {
        return "Отменено";
    }
}



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
        case 12:
            month = "дек";
            break;
        default:
            month = "декдекдекдек";
    }

    return dateS[2] + " " + month + " " + dateS[0];
}



document.getElementById("toAccountUpdate").addEventListener("click", () => {

    window.location.href = "/User/edit";

});



document.getElementById("ShowGuestsEvents").addEventListener("click", (button) => {

    const table = document.getElementById("guestsevents");

    if (table.hidden) {
        table.hidden = false;
        button.target.textContent = "Скрыть список встреч";
    }
    else {
        table.hidden = true;
        button.target.textContent = "Показать список встреч";
    }
});



document.getElementById("showMyEvents").addEventListener("click", (button) => {

    const table = document.getElementById("myeventstable");

    if (table.hidden) {
        table.hidden = false;
        button.target.textContent = "Скрыть список моих встреч";
    }
    else {
        table.hidden = true;
        button.target.textContent = "Показать список моих встреч";
    }
});



document.getElementById("createNewEvent").addEventListener("click", () => {

    window.location.href = "/meets/create";
});