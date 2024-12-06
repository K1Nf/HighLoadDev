const myform = document.forms["auth"];
var tokenKey = "NeToKeN";

myform.addEventListener('submit', async function (event) {

	// Отменяем стандартное поведение формы
	event.preventDefault();

	let user = {
		login: myform.login.value,
		password: myform.password.value
	};

	// Отправляем данные на сервер
fetch('../api/ref/auth/logIn', {
	method: 'POST',
	headers: {
		'Content-Type': 'application/json'
	},
	body: JSON.stringify(user),
})

.then(response => {
    if (response.status == 200) {
        return response.text();
    }
    throw new Error('Network response was not ok');
})

	.then(token => {

		//window.localStorage.setItem(tokenKey, token);
		
		const meetUserName = "MeetUserName";
		var cks = document.cookie.split("; ");
		for (var i = 0; i < cks.length; i++) {

			console.log(cks[i]);
			if (cks[i].startsWith(meetUserName)) {
				console.log(cks[i].split("=")[1]);
				window.localStorage.setItem(meetUserName, cks[i].split("=")[1]);
			}

			if (cks[i].startsWith(tokenKey)) {
				console.log(cks[i].split("=")[1]);
				window.localStorage.setItem(tokenKey, cks[i].split("=")[1]);
			}
		}

		window.location.href = "../User";

})
.catch(error => {
    console.error('There was a problem with the fetch operation:', error);
});

});

document.getElementById("register").addEventListener('click', async function (e) {
	e.preventDefault();

	window.location.href = "/Authorize/Register";
});

//document.getElementById("registerPOST").addEventListener('submit', async function (e) {
//	e.preventDefault();

//	let urlRegister = "/authorize/RegisterPOST";


//	//fetch
//});
