using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace SkillsetManager.Models
{
    public class FormModel
    {
        [Required(ErrorMessage = "Please enter the user's first name.")]
        public String Name { get; set; }

        [Required]
        public String Birthdate { get; set; }
    }
}