﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel
{
    public class LoginViewModel
    {
        [Required]
        
        public string UserName { get; set; }
        [DataType(DataType.Password)]
        [Required]
        public string Password { get; set; }
        [Display(Name ="Remember me")]
        public bool RemeberMe { get; set; }
    }
}
