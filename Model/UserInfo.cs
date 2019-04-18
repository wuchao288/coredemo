using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class LoginViewModel
    {
        [Required]
        [Range(3,5)]
        public string UserName { get; set; } = "";

        [DataType(DataType.Password)]
        [Display(Name ="密码",Prompt = "密码")]
        [Required]
        public string Password { get; set; } = "";

        [MaxLength(10)]
        public int Password9 { get; set; } = 10;

        public string PUIuu { get; set; }
    }
}
