﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IssueManagementSystem.DomainModel.Auth
{
    /// <summary>
    /// ユーザー
    /// </summary>
    public class User
    {
        /// <summary>
        /// ユーザーID
        /// </summary>
        public string UserId { get; set; }

        /// <summary>
        /// パスワード
        /// </summary>
        [Required]
        public string HashPassword { get; set; }

        /// <summary>
        /// 名字
        /// </summary>
        [Required]
        public string LastName { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        [Required]
        public string FirstName { get; set; }
    }
}
