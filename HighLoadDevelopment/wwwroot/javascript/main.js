const tokenKey = "NeToKeN";
const token = window.localStorage.getItem(tokenKey);

const meetUserName = "MeetUserName";
const userSessionName = window.localStorage.getItem(meetUserName);

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
            month = "мая";
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
            month = "not a month";
    }

    return dateS[2] + " " + month + " " + dateS[0];
}


const formSearch = document.getElementsByName("searchform")[0];
const inputSearch = document.getElementsByName("searchname")[0];



inputSearch.addEventListener("mouseenter", (e) => {
    console.log(e.target.placeholder = "Введите название евента");
});

inputSearch.addEventListener("mouseleave", (e) => {
    console.log(e.target.placeholder = "Поиск...");
});



formSearch.addEventListener("submit", (e) => {
    e.preventDefault();

    const name = inputSearch.value

    window.location.href = "";

});


document.getElementById("toSearch").addEventListener("click", () => {

    window.location.href = "";
});



document.getElementById("home").addEventListener("click", async () => {

    window.location.href = "/";

});


document.getElementById("myPage").addEventListener("click", async () => {

    window.location.href = "/user";

});


//document.getElementById("logOut").addEventListener("click", async () => {

//    window.location.href = "";

//});



