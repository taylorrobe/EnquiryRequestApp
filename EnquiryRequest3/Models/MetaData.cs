﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EnquiryRequest3.Models
{
    public class AddressMetaData
    {
        // Allow up to 40 uppercase and lowercase 
        // characters. Use standard error.
        [Required]
        [StringLength(100, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [Display(Name = "Address line 1")]
        [RegularExpression(@"[0-9a-zA-Z''-'-\s,]{1,40}$",
         ErrorMessage = "Some Special Characters are not allowed.")]
        public object Address1;

        // Allow up to 40 uppercase and lowercase 
        // characters. Use standard error.
        [StringLength(100, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [Display(Name = "Address line 2")]
        [RegularExpression(@"[0-9a-zA-Z''-'-\s,]{1,40}$",
         ErrorMessage = "Some Special Characters are not allowed.")]
        public object Address2;

        // Allow up to 40 uppercase and lowercase 
        // characters. Use standard error.
        [StringLength(100, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [Display(Name = "Address line 3")]
        [RegularExpression(@"[0-9a-zA-Z''-'-\s,]{1,40}$",
         ErrorMessage = "Some Special Characters are not allowed.")]
        public object Address3;

        // Allow up to 40 uppercase and lowercase 
        // characters. Use standard error.
        [Required]
        [StringLength(10, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [Display(Name = "Post code")]
        [RegularExpression(@"([Gg][Ii][Rr] 0[Aa]{2})|((([A-Za-z][0-9]{1,2})|(([A-Za-z][A-Ha-hJ-Yj-y][0-9]{1,2})|(([A-Za-z][0-9][A-Za-z])|([A-Za-z][A-Ha-hJ-Yj-y][0-9]?[A-Za-z]))))\s?[0-9][A-Za-z]{2})",
         ErrorMessage = "Invalid postcode.")]
        public object PostCode;
    }

    public class ContactMetaData:AddressMetaData
    {
        // Allow up to 40 uppercase and lowercase 
        // characters. Use custom error.
        [Required]
        [StringLength(100, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Special Characters are not allowed.")]
        public object Forename;

        // Allow up to 40 uppercase and lowercase 
        // characters. Use standard error.
        [Required]
        [StringLength(100, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [RegularExpression(@"^[a-zA-Z''-'\s]{1,40}$",
         ErrorMessage = "Special Characters are not allowed.")]
        public object Surname;

        [Display(Name = "Organisation")]
        public Organisation Organisation;

        [EmailAddress]
        [StringLength(100, ErrorMessage = "The {0} cannot be more than {1} characters long.")]
        [Display(Name = "Default Invoicing Email Address")]
        public string DefaultInvoicingEmail;
    }


}