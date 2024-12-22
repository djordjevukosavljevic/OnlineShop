$(document).ready(function() {
    $('#sendBtn').onclick(function(event) {
        event.preventDefault();

        // Dohvatanje vrednosti unutar polja
        var firstName = $('#firstName').val().trim();
        var lastName = $('#lastName').val().trim();
        var email = $('#email').val().trim();
        var message = $('#message').val().trim();

        // RegEx
        var nameRegex = /^[A-Za-z]{2,}$/; // Minimum dva karaktera
        var emailRegex = /^[^\s@]+@[^\s@]+\.[^\s@]+$/; // Email verifikacija

        // Validacija
        var valid = true;

        if (firstName === '') {
            alert('First name cannot be empty.');
            valid = false;
        } else if (!nameRegex.test(firstName)) {
            alert('Please enter a valid first name.');
            valid = false;
        }

        if (lastName === '') {
            alert('Last name cannot be empty.');
            valid = false;
        } else if (!nameRegex.test(lastName)) {
            alert('Please enter a valid last name.');
            valid = false;
        }

        if (email === '') {
            alert('Email cannot be empty.');
            valid = false;
        } else if (!emailRegex.test(email)) {
            alert('Please enter a valid email address.');
            valid = false;
        }

        if (message === '') {
            alert('Message cannot be empty.');
            valid = false;
        }

        if (valid) {
            alert('Form submitted successfully!');
            window.alert("Message sent successfuly!");
        }
    });
});
