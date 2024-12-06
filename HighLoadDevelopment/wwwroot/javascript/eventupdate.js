
const meetId = window.location.href.split("/")[5];
let tagsUrl = "/api/ref/tagsApi";
let userId;

fetch(tagsUrl, {
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
    const spisok2 = document.getElementById("tags");
    spisok2.style.width = "50%";
    spisok2.style.height = "20.3vh";
    spisok2.style.borderRadius = "15px";
    for (let i of data) {
        var opt = document.createElement('option');
        opt.style.fontSize = "1.4vw";
        opt.style.paddingLeft = "2%";
        opt.value = i.id;
        opt.innerHTML = i.name;
        spisok2.appendChild(opt);
    }
})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});

   

let urlToMeet = "/api/ref/meetingapi/" + meetId;

fetch(urlToMeet, {
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
    const meet = data;// await response.json();

    const name = meet.name;
    const place = meet.location;
    const date = meet.date;
    const timeStart = meet.timeStart;
    const timeEnd = meet.timeEnd;
    const description = meet.description;
    const maxGuest = meet.maxGuest;


    const user = meet.user;
    //userId = user.id;

    const tags = meet.tagsDTO;
    let allTags = "";
    for (tag of tags) {
        allTags += tag.name + ", ";
    }


    document.getElementById("title").textContent = `Редактирование встречи "${name}"`;
    document.getElementsByName("name")[0].value = name;
    document.getElementsByName("place")[0].value = place;
    document.getElementsByName("date")[0].value = date;
    document.getElementsByName("timeStart")[0].value = timeStart;
    document.getElementsByName("timeEnd")[0].value = timeEnd;
    document.getElementsByName("maxGuests")[0].value = maxGuest;
    document.getElementById("description").textContent = description;
    document.getElementById("thistags").textContent = allTags.slice(0, -2);
})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});




const myform = document.forms[1];

myform.addEventListener('submit', async (e) => {

    e.preventDefault();


    let url = "/api/ref/meetingApi/update/" + meetId;


    const tags = document.getElementById("tags");
    let tagsarray = [];
    for (let t of tags.selectedOptions) {
        console.log(t.value);
        tagsarray.push(+t.value);
    }


    const meetUpdate = {
        id: meetId,
        Name: myform.name.value,
        Place: myform.place.value,
        Date: myform.date.value,
        TimeStart: myform.timeStart.value,
        TimeEnd: myform.timeEnd.value,
        MaxGuests: myform.maxGuests.value,
        Description: myform.description.value,
        TagIds: tagsarray
    }
    console.log(meetUpdate);
    console.log(url);
    fetch(url, {
        method: "PUT",
        headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
        body: JSON.stringify(meetUpdate)
    })

    .then(response => {
        if (response.status == 200) {
            return response;
        }
       
        throw new Error('Network response was not ok');
    })

    .then(data => {
        toastr["success"]("Встреча успешно отредактирована", "Успешно")

        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-top-full-width",
            "preventDuplicates": false,
            "onclick": null,
            "showDuration": "300",
            "hideDuration": "1000",
            "timeOut": "5000",
            "extendedTimeOut": "1000",
            "showEasing": "swing",
            "hideEasing": "linear",
            "showMethod": "fadeIn",
            "hideMethod": "fadeOut"
        }

        setTimeout(function () {
            window.location.href = "/meets/" + meetId;
        }, 3000);

    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });
   
});


async function getDate(date) {

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


async function goback() {
    console.log("trying to navigate back...");
    };

