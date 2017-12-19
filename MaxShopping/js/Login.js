function newPage(link) {
    var response = confirm("Are you a New User?");
    if (response === true) {
        
        window.location.href = link;
    }
    return response;
}

function CheckEmail(email) {
    var Email = email;
    Emailorg = $("#txtEmail").val();
    if (Email == "") {
        alert("Please enter a Mail Id");
        return false;
    }
    else if(email=="")
    {
        alert("Please enter a Mail Id in Retype Mailid");
        return false;
    }
    else if(Email != Emailorg)
    {
        alert("Entered Email Mismatch")
        return false;
    }
    else
    {
        return true;
    }
}

function CheckPassword(pass) {
    var pass = Password;
    if(pass=="")
    {
        alert("Please Retpye a Password");
        return false;
    }
    else if(Password=="")
    {
        alert("Please Enter a Password")
        return false;
    }
    else if (pass != password) {
        alert("Password Mismatch");
        return false;
    }
    else {
        return true;
    }
}
