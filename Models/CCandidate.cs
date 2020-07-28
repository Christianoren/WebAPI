using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class CCandidate
    {
        [Key]
        public int id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string fullName { get; set; }

        [Column(TypeName = "nvarchar(16)")]
        public string mobilenumber { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string email { get; set; }

        public Adresse Adresse { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string stilling { get; set; }
    }
}
