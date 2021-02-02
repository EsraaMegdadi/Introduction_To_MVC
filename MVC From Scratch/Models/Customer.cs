using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVC_From_Scratch.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="please enter your Name")]
        [EmailAddress]
        public string Name  { get; set; }

        [Required(ErrorMessage ="please , enter your  address ")]
        public string  Address { get; set; }

        [Required(ErrorMessage ="please  enter your age")]
        public int Age  { get; set; }



        //default  constructor
        public Customer()
        {
        }

        public Customer(int id, string name, string address, int age)
        {
            Id = id;
            Name = name;
            Address = address;
            Age = age;
        }
    } 
}