using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System.ComponentModel;

namespace MVCShop.Domain.Entities
{
    [MetadataType(typeof(UserMetadata))]
    public class User
    {
        public int Id { get; set; }
        public string Login { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        [Bind(Exclude="ID")]
        public class UserMetadata
        {
            [ScaffoldColumn(false)]
            public int Id { get; set; }

            [DisplayName("Login")]
            [Required(ErrorMessage="User Login is required")]
            [DisplayFormat(ConvertEmptyStringToNull=false)]
            [StringLength(255)]
            public string Login { get; set; }

            [DisplayName("Name")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(255)]
            public string Name { get; set; }

            [DisplayName("Password")]
            [StringLength(255)]
            [Required(ErrorMessage = "User Password is required")]
            public string Password { get; set; }

            [DisplayName("Email")]
            [StringLength(255)]
            [Required(ErrorMessage = "User Email is required")]
            public string Email { get; set; }

            [DisplayName("Phone")]
            [DisplayFormat(ConvertEmptyStringToNull = false)]
            [StringLength(13)]
            public string Phone { get; set; }
        }
    }
}