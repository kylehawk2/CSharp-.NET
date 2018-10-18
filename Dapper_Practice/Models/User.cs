using System;
using System.ComponentModel.DataAnnotations;

namespace Dapper_Practice.Models
{
    public class User
    {
        [Key]
        public int user_id {get;set;}
        [Required]
        [MinLength(2)]
        public string first_name {get;set;}
        [Required]
        [MinLength(2)]
        public string last_name {get;set;}
        [Required]
        [EmailAddress]
        public string email {get;set;}
        [Required]
        public string password {get;set;}
        public DateTime created_at {get;set;}
        public DateTime updated_at {get;set;}
    }
}