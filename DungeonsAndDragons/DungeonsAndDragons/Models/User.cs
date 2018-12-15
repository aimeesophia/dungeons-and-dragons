﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Text;
using System.Security.Cryptography;
using Microsoft.EntityFrameworkCore;
using DungeonsAndDragons.Models;
using DungeonsAndDragons.Controllers;

namespace DungeonsAndDragons.Models
{
    public class User
    {
        public int id { get; set; }
        [Required]
        [Column(TypeName = "varchar(20)")]
        public string username { get; set; }
        [Required]
        [Column(TypeName = "varchar(200)")]
        public string password { get; set; }

        public static bool AuthenticateSignIn(string password, string enteredpassword)
        {

            return Encryption.EncryptPassword(enteredpassword) == password;
        }
    }

}
