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
    for (let i of data) {
        var opt = document.createElement('option');
        opt.value = i.id;
        opt.innerHTML = i.name;
        spisok2.appendChild(opt);
    }
})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});



let userUrl = "/api/ref/userApi/";


fetch(userUrl, {
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
    tags = data.tagsDTO;

    let userTags = "";
    //for (const tag of tags) {
    //    userTags += tag.name + ", ";
    //}

    document.getElementById("firstname").value = data.firstName;
    document.getElementById("secondname").value = data.secondName;
    document.getElementById("lastname").value = data.lastName;
    document.getElementById("city").value = data.city;
    document.getElementById("information").value = data.information;
    document.getElementById("mytags").textContent = userTags.slice(0, -2);
})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});




myform = document.forms[1];

myform.addEventListener('submit', async (event) => {

    // Отменяем стандартное поведение формы
    event.preventDefault();


    const url = '/api/ref/userApi/update';

    const tags = document.getElementById("tags");
    let tagsarray = [];
    for (let t of tags.selectedOptions) {
        console.log(t.value);
        tagsarray.push(+t.value);
    }

    let userUpdate = {
        lastName: myform.lastname.value,
        firstName: myform.firstname.value,
        secondName: myform.secondname.value,
        city: myform.city.value,
        information: myform.information.value,
        tagIds: tagsarray
    };

    // Отправляем данные на сервер
    fetch(url, {
        method: 'PUT',
        headers: { "Accept": "application/json", "Content-Type": "application/json", "Authorization": "Bearer " + token },
        body: JSON.stringify(userUpdate),
    })
    .then(response => {
        if (response.status == 200) {
            return response;
        }
        throw new Error('Network response was not ok');
    })

    .then(data => {
        console.log(data);
        toastr["success"]("Профиль успешно отредактирован", "Успешно")

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


        console.log("vse horosho");
        setTimeout(function () {
            const button = document.getElementById("btnsbmt");
            button.disabled = true;
            window.location.href = ".../../";
        }, 3000);
    })
    .catch(error => {
        console.error('There was a problem with the fetch operation:', error);
    });
    
});



async function checkpass(e){

    const div1 = document.getElementById("div1");
    const div2 = document.getElementById("div2");

    if (div1.hidden) {
        div1.hidden = false;
        div2.hidden = false;
    }
    else {
        div1.hidden = true;
        div2.hidden = true;
    }
}
