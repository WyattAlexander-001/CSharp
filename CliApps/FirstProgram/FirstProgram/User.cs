using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FirstProgram
{
    internal class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string PhoneNumber { get; set; }
        public string CreditCard { get; set; }
        public string ExpirationDate { get; set; }
        public string CVV { get; set; }
        public string BillingAddress { get; set; }
        public string BillingCity { get; set; }
        public string BillingState { get; set; }
        public string BillingZip { get; set; }
        public string BillingPhoneNumber { get; set; }  

        //Constructor
        public User(string firstName, string lastName, int age, string email, string password, string address, string city, string state, string zip, string phoneNumber, string creditCard, string expirationDate, string cvv, string billingAddress, string billingCity, string billingState, string billingZip, string billingPhoneNumber)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Email = email;
            Password = password;
            Address = address;
            City = city;
            State = state;
            Zip = zip;
            PhoneNumber = phoneNumber;
            CreditCard = creditCard;
            ExpirationDate = expirationDate;
            CVV = cvv;
            BillingAddress = billingAddress;
            BillingCity = billingCity;
            BillingState = billingState;
            BillingZip = billingZip;
            BillingPhoneNumber = billingPhoneNumber;
        }   
    }
}
