﻿using System.ComponentModel.DataAnnotations;

namespace TechXpress.Data.Entities
{
    public class ContactUs
    {
            [Key]
            public int Id { get; set; }

            [Required(ErrorMessage = "Name is required")]
            public string Name { get; set; }

            [Required(ErrorMessage = "Subject is required")]
            public string Subject { get; set; }

            [Required(ErrorMessage = "Email is required")]
            [EmailAddress(ErrorMessage = "Invalid email format")]
            public string Email { get; set; }

            [Required(ErrorMessage = "Phone is required")]
            [Phone(ErrorMessage = "Invalid phone number")]
            public string Phone { get; set; }

            [Required(ErrorMessage = "Message is required")]
            public string Message { get; set; }
    }

}
