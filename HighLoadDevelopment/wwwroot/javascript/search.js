
let tagsUrl = "/api/ref/tagsApi";


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




const myform = document.forms[1];

myform.addEventListener('submit', async (e) => {

    e.preventDefault();

    const tags = document.getElementById("tags");
    let tagsarray = [];
    for (let t of tags.selectedOptions) {
        tagsarray.push(+t.value);
    }


    let meetToSearch = {
        Name: myform.name.value,
        Place: myform.place.value,
        Date: myform.date.value,
        TimeStart: myform.timeStart.value,
        TimeEnd: myform.timeEnd.value,
        Description: myform.description.value,
        TagIds: tagsarray
    }


    let sp = new URLSearchParams(meetToSearch);

    const req = sp.toString();
});



document.getElementById("goback").addEventListener("click", () => {

    window.history.go(-1);

});