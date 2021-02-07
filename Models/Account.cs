using System;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace AccountManagementApp2.Models
{
    public class Account
    {
        [Key]
        public int Id { get; set; }
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string email { get; set; }
        public string gender { get; set; }
        public DateTime dateOfBirth { get; set; }
        public DateTime? createdDate { get; set; }
        public DateTime? lastUpdatedDate { get; set; }
        public DateTime? deletionDate { get; set; }
        public bool isComplete { get; set; }
        public Account()
        {
            isComplete = false;
        }
    }
}
