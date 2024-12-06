

let ownerId;
let eventStatus;
const meetId = window.location.href.split("/")[4];

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

    const id = data.id;

    const name = data.name;
    document.getElementsByTagName("title")[0].textContent = name;

    const place = data.location;
    const date = getDate(data.date);
    const timeStart = data.timeStart;
    const timeEnd = data.timeEnd;
    const description = data.description;
    const status = data.status;
    const maxGuests = data.maxGuest;
    const currGuests = data.currentGuestsCount;


    const user = data.userDTO;
    ownerId = user.id;
    const city = user.city;
    const userName = user.userName;
    const rating = user.rating;
    //const imageLink = user.imageLink;

    console.log(user);
    const tags = data.tagsDTO;
    let allTags = "";
    for (tag of tags) {
        allTags += tag.name + ", ";
    }


    if (status == 0) {
        eventStatus = "Запланировано";
    }
    if (status == 1) {
        eventStatus = "В процессе";
    }
    if (status == 2) {
        eventStatus = "Завершено";
    }
    if (status == 3) {
        eventStatus = "Отменено";
    }

    document.getElementById("username").textContent = userName;
    document.getElementById("username").style.textDecoration = "underline";


    document.getElementById("rating").textContent = " (" + rating + ")";
    document.getElementById("eventname").textContent = name;
    document.getElementById("status").textContent = eventStatus;
    document.getElementById("dateandtime").textContent = date + " " + timeStart + " - " + timeEnd;
    document.getElementById("city").textContent = city;
    document.getElementById("place").textContent = place;
    document.getElementById("guests").textContent = currGuests + "/" + maxGuests;
    document.getElementById("description").textContent = description;
    document.getElementById("tags").textContent = allTags.slice(0, -2);
    //document.getElementById("avatar").src = imageLink;



    fetch("/api/ref/userapi/check/" + meetId, {
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
            console.log("checked");

            if (data.isUserOwner) {    // создатель евента открывает страницу
                document.getElementById("joinButtons").remove();
                document.getElementById("LeaveButtons").remove();
                document.getElementById("markForm").remove();
                console.log("USER IS AUTHOR");

                if (eventStatus != "Запланировано") {
                    document.getElementById("manageButtons").remove();
                }

            }
            else {      // левый чел открывает страницу

                console.log("USER IS NOT AN OWNER");
                document.getElementById("manageButtons").remove();      // Убираем элементы управления евентом


                if (eventStatus == "Запланировано") {

                    if (data.isUserRegistrated) {           // Проверка, зареган ли чел на евент
                        console.log("Вы зарегистрированы");
                        document.getElementById("joinButtons").remove();
                    }
                    else {
                        console.log("Вы не зарегистрированы");
                        document.getElementById("LeaveButtons").remove();
                    }

                    document.getElementById("markForm").remove();   // Убираем возможность оценить автора, 
                                                                    //т.к.евент еще не завершился
                }
                else {      // event в процессе, отменен или завершен
                    document.getElementById("joinButtons").remove();    // Убираем возможность зарегаться
                    document.getElementById("LeaveButtons").remove();   // Убираем возможность ливнуть

                    if (!data.isMeetRated && eventStatus == "Завершено") { // если завершен
                        // даем гостю возможность оценить организатора
                        // вывод в label, что все завершено 
                    }
                    else {  // оценка уже выставлена
                        document.getElementById("markForm").remove();
                        // вывод в label, что все завершено 
                    }
                    
                }
            }
        });



    fetch("/api/ref/commentApi/meet/" + meetId, {
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })

        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            throw new Error('Network response was not ok');
        })

        .then(data => {
            AddCommentsToPage(data);
        });



    fetch("/api/ref/userApi/visits/" + meetId, { // посмотреть гостей
        method: "GET",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
    })

        .then(response => {
            if (response.status == 200) {
                return response.json();
            }
            throw new Error('Network response was not ok');
        })

        .then(data => {

            console.log(data);

            let pGuests = document.getElementById("guestsnames");
            for (var i = 0; i < data.length; i++) {

                pGuests.textContent += data[i].userName + ", "
            }
            pGuests.textContent = pGuests.textContent.slice(0, -2);
        });


})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});



document.getElementById("join").addEventListener("click", () => {


    let url = "/api/ref/meetingapi/Join/" + meetId;
    console.log(url);

    fetch(url, {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
    })
    .then(response => {
        if (response.status == 200) {
            location.reload();
        }
        
        throw new Error('Network response was not ok');
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });

});



document.getElementById("leave").addEventListener("click", () => {


    let url = "../api/ref/meetingApi/Leave/" + meetId;
    console.log(url);

    fetch(url, {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json"},
    })

        .then(response => {
            if (response.status == 200) {
                location.reload();
            }
            
            throw new Error('Network response was not ok');
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });

});




let guestButton = document.getElementById("showGuestList");

guestButton.addEventListener("click", () => {

    let guestsList = document.getElementById("guestsnames");

    if (guestsList.style.display == "none") {
        guestsList.style.display = "inline";
        guestButton.textContent = "Скрыть гостей";
    }
    else {
        guestsList.style.display = "none";
        guestButton.textContent = "Посмотреть гостей";
    }

});


document.getElementById("author").addEventListener("click", () => {

    window.location.href = "/user/" + ownerId;

});

document.getElementById("cancelEvent").addEventListener("click", () => {

    window.location.href = "/meets/cancel/" + meetId;

});

document.getElementById("changeEvent").addEventListener("click", () => {

    window.location.href = "/meets/Update/" + meetId;  

});



let addCommentSection = document.getElementById("addCommentSection"); 
let addCommentButton = document.getElementById("addComment"); 
let addCommH1 = document.getElementById("addCommH1"); 


addCommentButton.addEventListener("click", () => {

    if (addCommentSection.style.hidden) {
        addCommentSection.style.hidden = false;
        addCommentSection.style.display = "none";
        addCommH1.style.display = "none";
        addCommentButton.textContent = "Добавить комментарий";
    }
    else {
        addCommentSection.style.hidden = true;
        addCommentSection.style.display = "block";
        addCommH1.style.display = "block";
        addCommentButton.textContent = "Не добавлять комментарий";
    }

});


document.getElementById("addCommentPOST").addEventListener("click", () => {

    const url = "../api/ref/commentapi/create";

    let commentText = document.getElementById("commentText").value;

    let comment = {
        meetId: meetId,
        text: commentText
    }
    console.log(comment);
    // отправка коммента

    fetch(url, {
        method: "POST",
        headers: { "Accept": "application/json", "Content-Type": "application/json" },
        body: JSON.stringify(comment)
    })

        .then(response => {
            if (response.status == 201) {
                location.reload();
            }

            throw new Error('Network response was not ok');
        })
        .catch(error => {
            console.error('There was a problem with the fetch operation:', error);
        });

});

let form = document.forms[1];

form.addEventListener("submit", async (f) => {
    f.preventDefault();

    console.log("HELLO WORLD ITS FORM SUBMITTED");

    //const rating = form.rating.value;

    //const ratedUserId = ownerId;
    //const ratedmeetId = meetId;
    //const urlRate = "/api/Users/Rate";

    //const ratedBody = {
    //    mark: rating,
    //    meetId: ratedmeetId,
    //    userId: ratedUserId
    //}
    //console.log(ratedBody);
    //fetch(urlRate, {
    //    method: "POST",
    //    headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
    //    body: JSON.stringify(ratedBody)
    //})
    //    .then(response => {
    //        if (response.status == 200) {
    //            return response.json();
    //        }
            
    //        throw new Error('Network response was not ok');
    //    })

    //    .then(data => {
    //        console.log(data);
    //    })
    //.catch(error => {
    //    console.error('There was a problem with the fetch operation:', error);
    //});
})


function AddCommentsToPage(data) {

    let commentsSection = document.getElementById("commentsSection");

    for (let comment of data) {
        console.log(comment);
        let div1 = document.createElement("div");
        div1.style.marginBottom = "3%";
        // Создание блока с инфой об евенте
        commentsSection.appendChild(div1);



        // div с h1 с названием евента
        let div2 = document.createElement("div");
        let div3 = document.createElement("div");

        div3.style.border = "solid 1px black";
        div3.style.backgroundColor = "white";
        div3.style.padding = "2%";

        let p = document.createElement("p");

        p.style.width = "fit-conten";
        p.style.height = "fit-content";
        p.style.fontSize = "130%";

        p.textContent = comment.commentText;

        div3.appendChild(p);


        let img = document.createElement('img');
        let h2 = document.createElement('h2');
        let h5 = document.createElement('h5');

        img.src = "https://avatars.mds.yandex.net/get-entity_search/4759071/1011754557/S600xU_2x";

        img.style.width = "2.5vw";
        img.style.height = "2.5vw";
        img.style.borderRadius = "100%";
        img.style.border = "solid 1px black";

        h2.style.display = "inline";
        h5.style.display = "inline";
        h5.style.marginLeft = "1%";

        h2.textContent = comment.user.userName;


        let created_At = comment.created_At.slice(0, 19);

        h5.textContent = created_At;


        div2.appendChild(img);
        div2.appendChild(h2);
        div2.appendChild(h5);


        div1.appendChild(div2);
        div1.appendChild(div3);
       

    }
}