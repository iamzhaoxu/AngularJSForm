using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AngularJSForm.Models
{
    public class UserModel
    {
        [Key]
        public Guid UserID
        {
            get;
            set;
        }

        [Required]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        public string Type { get; set; }
    }
}