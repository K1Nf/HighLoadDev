let meetName;
let searchParams;
let url = "/api/ref/meetingapi";


//if (window.location.href.indexOf("Tag") != -1) {   // есть name
//    searchParams = window.location.href.split("?")[1];
//    url = url + "/SearchEvents?" + searchParams;
//    console.log("WITH PARAMS");
//    console.log(searchParams);
//    console.log(url);
//}
//else if(window.location.href.indexOf("?name=") != -1) {   // есть name
//    eventName = window.location.href.split("?")[1].split("=")[1];
//    url = url + "?name=" + eventName;
//    console.log(eventName);
//    console.log("NO PARAMS");
//    console.log(url);
//}

//myform = document.forms[0];
//console.log("RESULT URL: ");
//console.log(url);



fetch(url, {
    method: "GET",
    headers: {
        "Accept": "application/json", "Content-Type": "application/json"
    },
})
    .then(response => {
    if (response.status == 200) {
        return response.json();
    }
    else throw new Error('Network response was not ok');
})
.then(data => {
    console.log(data);

    let maindiv = document.getElementById('maindiv');

    for (let e of data) {
        const id = e.id;
        const name = e.name;
        const place = e.place;
        const date = getDate(e.date);
        const timeStart = e.timeStart;
        const timeEnd = e.timeEnd;
        const description = e.description;

        const userDTO = e.userDTO;
        const location = e.location;
        const userName = userDTO.userName;
        const rating = userDTO.rating;
        const city = userDTO.city;

        const imageLink = userDTO.imageLink;

        const tags = e.tagsDTO;


        // Создание блока с инфой об евенте
        let meetdiv = document.createElement('div');
        meetdiv.className = "event";
        maindiv.appendChild(meetdiv);



        // div с h1 с названием евента
        let headdiv = document.createElement('div');
        let headname = document.createElement('h1');
        headname.innerHTML = name;
        headname.style.textAlign = "center";
        headname.style.fontSize = "2.2vw";
        headname.style.marginBottom = "3%";
        headdiv.appendChild(headname);



        // div со всеми данными о евенте
        let contentdiv = document.createElement('div');
        meetdiv.appendChild(headdiv);
        meetdiv.appendChild(contentdiv);


        // div с классрм leftpart - аватар, ник+рейтинг, кнопка 'подробнее'
        let leftpartdiv = document.createElement('div');
        leftpartdiv.className = "leftpart";



        let img = document.createElement('img');
        //img.src = imageLink;
        img.className = "leftpartimg";

        let h2 = document.createElement('h2');
        h2.textContent = userName + " (" + rating + ")";

        let a = document.createElement('a');
        a.target = "_blank";
        a.className = "btn";

        a.textContent = "Подробнее ";
        a.href = "/meets/" + id;        ///?????????????
        //a.href = "../Pages/Event/EventPage.html" + "?id=" + id;        ///?????????????
        //a.onclick = openeventpage;



        // div с классрм rightpart - вся остальная инфа об евенте
        let rightpartdiv = document.createElement('div');
        rightpartdiv.className = "rightpart";



        // Создание div-ов
        let datediv = document.createElement('div');
        let timediv = document.createElement('div');
        let citydiv = document.createElement('div');
        let placediv = document.createElement('div');
        let descriptiondiv = document.createElement('div');
        let tagsdiv = document.createElement('div');



        // Создание заголовков
        let dateh2 = document.createElement('h2');
        dateh2.textContent = "Дата";

        let timeh2 = document.createElement('h2');
        timeh2.textContent = "Время";

        let cityh2 = document.createElement('h2');
        cityh2.textContent = "Город";

        let placeh2 = document.createElement('h2');
        placeh2.textContent = "Место";

        let descriptionh2 = document.createElement('h2');
        descriptionh2.textContent = "Описание";

        let tagsh2 = document.createElement('h2');
        tagsh2.textContent = "Тэги";



        // Создание параграфов
        let datep = document.createElement('p');
        datep.textContent = date;

        let timep = document.createElement('p');
        timep.textContent = timeStart + " - " + timeEnd;

        let cityp = document.createElement('p');
        cityp.textContent = city;

        let placep = document.createElement('p');
        placep.textContent = location;

        let descriptionp = document.createElement('p');
        descriptionp.textContent = description;

        let tagsp = document.createElement('p');
        for (tag of tags) {
            tagsp.textContent += tag.name + ", ";
        }
        tagsp.textContent = tagsp.textContent.slice(0, -2);


        contentdiv.appendChild(leftpartdiv);
        contentdiv.appendChild(rightpartdiv);


        // Заполнение левого дива аватаркой, ником и кнопкой 'подробнее'
        //leftpartdiv.appendChild(img);
        leftpartdiv.appendChild(h2);
        leftpartdiv.appendChild(a);


        // Заполнение правого дива всем контентом
        rightpartdiv.appendChild(datediv);
        rightpartdiv.appendChild(timediv);
        rightpartdiv.appendChild(citydiv);
        rightpartdiv.appendChild(placediv);
        rightpartdiv.appendChild(descriptiondiv);
        rightpartdiv.appendChild(tagsdiv);


        // Заполнение div-ов
        datediv.appendChild(dateh2);
        datediv.appendChild(datep);
        timediv.appendChild(timeh2);
        timediv.appendChild(timep);
        citydiv.appendChild(cityh2);
        citydiv.appendChild(cityp);
        placediv.appendChild(placeh2);
        placediv.appendChild(placep);
        descriptiondiv.appendChild(descriptionh2);
        descriptiondiv.appendChild(descriptionp);
        tagsdiv.appendChild(tagsh2);
        tagsdiv.appendChild(tagsp);
    }

    if (data.length == 0) {

        const headTitle = document.createElement("h1");
        headTitle.textContent = "По вашему запросу ничего не найдено";
        headTitle.style.fontSize = "2.2vw";

        maindiv.style.textAlign = "center";

        maindiv.append(headTitle);
    }

})
.catch(error => {
    console.error('There was a problem with the fetch operation: ', error);
});



function getDate(date) {

    let dateS = date.split("-");
    let month = "";

    switch (+dateS[1]) {
        case 1:
            month = "января";
            break;
        case 2:
            month = "февраля";
            break;
        case 3:
            month = "марта";
            break;
        case 4:
            month = "апреля";
            break;
        case 5:
            month = "мая";
            break;
        case 6:
            month = "июня";
            break;
        case 7:
            month = "июля";
            break;
        case 8:
            month = "августа";
            break;
        case 9:
            month = "сентября";
            break;
        case 10:
            month = "октября";
            break;
        case 11:
            month = "ноября";
            break;
        case 12:
            month = "декабря";
            break;
        default:
            month = "not a month";
    }

    return dateS[2] + " " + month + " " + dateS[0];
}


//myform.addEventListener("submit", async (e) => {

//    e.preventDefault();
//    const name = myform.name.value;
//    if (name == " ") {
//        window.location.href = "../../Events";
//    }
//    else {
//        window.location.href = "../../Events?name=" + name;
//    }
//});



//document.getElementById("myPage").addEventListener("click", () => {
//    window.location.href = "../../Users/";
//});

//document.getElementById("home").addEventListener("click", () => {
//    window.location.href = "../../Events";
//});