using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCDemo.Models
{
    public class addModel
    {

        [Required(ErrorMessage = "Input one is required")]

        public int inputOne { get; set; }
        [Required(ErrorMessage = "Input two is required")]
        public int inputTwo { get; set; }
        public int? result { get; set; }
    }
}