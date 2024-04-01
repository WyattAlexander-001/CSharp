using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class User
    {
        private string firstName;
        private string lastName;
        private int age;
        private string email;
        private string password;
        private string address;
        private string city;
        private string state;
        private string zip;
        private string phoneNumber;
        private string creditCard;
        private string expirationDate;
        private string cvv;
        private string billingAddress;
        private string billingCity;
        private string billingState;
        private string billingZip;
        private string billingPhoneNumber;

        // Constructor
        public User(string firstName, string lastName, int age, string email, string password, string address, string city, string state, string zip, string phoneNumber, string creditCard, string expirationDate, string cvv, string billingAddress, string billingCity, string billingState, string billingZip, string billingPhoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.age = age;
            this.email = email;
            this.password = password;
            this.address = address;
            this.city = city;
            this.state = state;
            this.zip = zip;
            this.phoneNumber = phoneNumber;
            this.creditCard = creditCard;
            this.expirationDate = expirationDate;
            this.cvv = cvv;
            this.billingAddress = billingAddress;
            this.billingCity = billingCity;
            this.billingState = billingState;
            this.billingZip = billingZip;
            this.billingPhoneNumber = billingPhoneNumber;
        }

        // Getter and Setter for firstName
        public string GetFirstName() => firstName;
        public void SetFirstName(string value) => firstName = value;

        public string GetLastName() => lastName;
        public void SetLastName(string value) => lastName = value;

        public int GetAge() => age;
        public void SetAge(int value) => age = value;

        public string GetEmail() => email;
        public void SetEmail(string value) => email = value;

        public string GetPassword() => password;
        public void SetPassword(string value) => password = value;

        public string GetAddress() => address;
        public void SetAddress(string value) => address = value;

        public string GetCity() => city;
        public void SetCity(string value) => city = value;

        public string GetState() => state;
        public void SetState(string value) => state = value;

        public string GetZip() => zip;
        public void SetZip(string value) => zip = value;

        public string GetPhoneNumber() => phoneNumber;
        public void SetPhoneNumber(string value) => phoneNumber = value;

        public string GetCreditCard() => creditCard;
        public void SetCreditCard(string value) => creditCard = value;

        public string GetExpirationDate() => expirationDate;
        public void SetExpirationDate(string value) => expirationDate = value;

        public string GetCvv() => cvv;
        public void SetCvv(string value) => cvv = value;

        public string GetBillingAddress() => billingAddress;
        public void SetBillingAddress(string value) => billingAddress = value;

        public string GetBillingCity() => billingCity;
        public void SetBillingCity(string value) => billingCity = value;

        public string GetBillingState() => billingState;
        public void SetBillingState(string value) => billingState = value;

        public string GetBillingZip() => billingZip;
        public void SetBillingZip(string value) => billingZip = value;

        public string GetBillingPhoneNumber() => billingPhoneNumber;
        public void SetBillingPhoneNumber(string value) => billingPhoneNumber = value;

        public void PrintUser()
        {
            Console.WriteLine("First Name: " + firstName);
            Console.WriteLine("Last Name: " + lastName);
            Console.WriteLine("Age: " + age);
            Console.WriteLine("Email: " + email);
            Console.WriteLine("Password: " + password);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("City: " + city);
            Console.WriteLine("State: " + state);
            Console.WriteLine("Zip: " + zip);
            Console.WriteLine("Phone Number: " + phoneNumber);
            Console.WriteLine("Credit Card: " + creditCard);
            Console.WriteLine("Expiration Date: " + expirationDate);
            Console.WriteLine("CVV: " + cvv);
            Console.WriteLine("Billing Address: " + billingAddress);
            Console.WriteLine("Billing City: " + billingCity);
            Console.WriteLine("Billing State: " + billingState);
            Console.WriteLine("Billing Zip: " + billingZip);
            Console.WriteLine("Billing Phone Number: " + billingPhoneNumber);
        }
    }
}
