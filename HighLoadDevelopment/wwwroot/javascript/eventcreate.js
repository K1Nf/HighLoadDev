const url = "/api/ref/tagsapi";

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

myform.addEventListener("submit", async (e) => {



    // Отменяем стандартное поведение формы
    e.preventDefault();

    //const url = "";
    const tags = document.getElementById("tags");
    let tagsarray = [];
    for (let t of tags.selectedOptions) {
        console.log(t.value);
        tagsarray.push(+t.value);
    }


    let meetRequest = {
        Name: myform.name.value,
        location: myform.place.value,
        Date: myform.date.value,
        TimeStart: myform.timeStart.value,
        TimeEnd: myform.timeEnd.value,
        MaxGuest: myform.guestscount.value,
        Description: myform.description.value,
        TagIds: tagsarray
    };

    const url2 = "../api/ref/meetingapi/create";
    console.log(meetRequest);
    //Отправляем данные на сервер
    fetch(url2, {
            method: 'POST',
            headers: { "Accept": "application/json", "Content-Type": "application/json"},
            body: JSON.stringify(meetRequest),
    })

    .then(response => {
        if (response.status == 200 || response.status == 201) {
            return "ok";
        }
        
        throw new Error('Network response was not ok');
    })

    .then(data => {
        console.log(data);
        toastr["success"]("Встреча успешно запланирована")

        toastr.options = {
            "closeButton": false,
            "debug": false,
            "newestOnTop": false,
            "progressBar": false,
            "positionClass": "toast-top-right",
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

        function openUserPage() {
            window.location.href = "../User/";
        }

        setTimeout(openUserPage, 3000);

    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });

});

