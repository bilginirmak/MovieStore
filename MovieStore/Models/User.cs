﻿using System.ComponentModel.DataAnnotations;

namespace MovieStore.Models
{
    public class User
    {
        public string Id { get; set; }
        [Required(ErrorMessage = "Please enter Username")]
        public string Username { get; set; }
        [EmailAddress(ErrorMessage = "Please enter valid email address")]
        [Required(ErrorMessage = "Please enter Email")]
        public string Email { get; set; }
        public string Contact { get; set; }
    }
}
