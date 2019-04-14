using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace Model
{
    public class LoginViewModel
    {
        public string UserName { get; set; } = "";

        [DataType(DataType.Password)]
        public string Password { get; set; } = "";
    }
}
