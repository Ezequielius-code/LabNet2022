var name;
var surname;
var email;
var age;
var gender;
var company;
var phone;

function DisplayResume()
{
    name = document.getElementById('name').value;
    surname = document.getElementById('surname').value;
    email = document.getElementById('mail').value;
    age = document.getElementById('age').value;
    gender = document.querySelector('input[name="gender"]:checked').value
    company = document.getElementById('company').value;
    phone = document.getElementById('phone').value;

    console.log(name);
    console.log(surname);
    console.log(email);
    console.log(age);
    console.log(gender);
    console.log(company);
    console.log(phone);

    if (ValidateText(name) && ValidateText(surname) && ValidateEmail(email) && ValidateCompany(company) && ValidatePhonenumber(phone))
    {
        alert("Your register has been completed successfully");
    }
    else if (ValidateText(name) && ValidateText(surname) && ValidateEmail(email) && (ValidateCompany(company) && phone == "" || company == "" && ValidatePhonenumber(phone)))
    {
        alert("Your register has been completed successfully");
    }
    else if(ValidateText(name) && ValidateText(surname) && ValidateEmail(email) && company == "" && phone == "")
    {
       alert("Your register has been completed successfully");
    }
    else
    {
        alert("Some inputs may be wrong. Please, check the input data.");
    }
}

function ValidateText(text)
{
    if (/^[a-zA-ZÀ-ÿ\s]{2,40}$/i.test(text))
    {
        return true;
    }
    else
    {
        return false;
    }
}

function ValidateEmail(email)
{
    if (/^(([^<>()[\]\.,;:\s@\"]+(\.[^<>()[\]\.,;:\s@\"]+)*)|(\".+\"))@(([^<>()[\]\.,;:\s@\"]+\.)+[^<>()[\]\.,;:\s@\"]{2,})$/i.test(email))
    {
        return true;
    } 
    else 
    {
        return false;
    }
}

function ValidateCompany(companyName)
{
    if (/^[a-zA-Z0-9\_\-]{4,16}$/i.test(email))
    {
        return true;
    } 
    else 
    {
        return false;
    }
}

function ValidatePhonenumber(phoneNumber)
{
    if (/^\d{7,14}$/i.test(email))
    {
        return true;
    } 
    else 
    {
        return false;
    }
}