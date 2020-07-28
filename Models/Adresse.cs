using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class Adresse
    {
        [Key]
        public int AdresseId { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string gateadresse { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string husnummer { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string postnummer { get; set; }

        [Column(TypeName = "nvarchar(100)")]
        public string sted { get; set; }
    }
}
