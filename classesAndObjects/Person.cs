using System;

public class Person
    {
    public string name;
    public string surName;
    public int age;
    public int id;
    public string phoneNumber;
    public string email;
    public Person( string name, string surName, int age, int id, string phoneNumber, string email )
        {
        this.name = name;
        this.surName = surName;
        this.age = age;
        this.id = id;
        this.phoneNumber = phoneNumber;
        this.email = email;
        }
    public void DisplayPersonInfo()
        {
        Console.WriteLine($"Name: {name}, Surname: {surName}, Age: {age}, ID number: {id}, PhoneNumber: {phoneNumber}, Email: {email} ");
        }

    }
