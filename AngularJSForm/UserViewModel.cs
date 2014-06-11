using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using AngularJSForm.Models;

namespace AngularJSForm
{
    public class UserViewModel
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
        public UserType UserType
        {
            get;
            set;
        }

        public UserModel ToModle()
        {
            return new UserModel()
            {
                UserID = this.UserID,
                UserName = this.UserName,
                Password = this.Password,
                Type = this.UserType.Value
            };
        }
    }

    public class UserType
    {
        public int ID { get; set; }
        public string Value { get; set; }
    }
}