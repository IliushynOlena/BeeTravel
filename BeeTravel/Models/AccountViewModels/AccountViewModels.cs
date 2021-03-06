﻿using Microsoft.AspNetCore.Authentication;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BeeTravel.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Display(Name = "Електронна адреса")]
        [Required(ErrorMessage = "Вкажіть пошту")]
        public string Email { get; set; }

        [Display(Name = "Пароль")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Вкажіть пароль")]
        public string Password { get; set; }
        public string ReturnUrl { get; set; }

        // AuthenticationScheme is in Microsoft.AspNetCore.Authentication namespace
        public IList<AuthenticationScheme> ExternalLogins { get; set; }
    }
    public class RegistrationViewModel
    {
        [Display(Name = "Email")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        [EmailAddress(ErrorMessage = "Не корекна пошта")]
        public string Email { get; set; }

        [Display(Name = "Firstname")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Firstname { get; set; }

        [Display(Name = "Lastname")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        public string Lastname { get; set; }
        //
        [Display(Name = "Phone number")]
        [Required(ErrorMessage = "Обов'язкове поле")]
        [RegularExpression(@"^[+]380\d{9}$", ErrorMessage="Некоректний номер телефону")]
        public string PhoneNumber { get; set; }

        //[Display(Name = "Оберіть фото")]
        //[Required(ErrorMessage = "Оберіть фото профілю")]
        //[Microsoft.AspNetCore.Mvc.HiddenInput]
        //public string PhotoBase64 { get; set; }
        //
        [Display(Name = "Password")]
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Invalid password")]
        public string Password { get; set; }
    }
}
