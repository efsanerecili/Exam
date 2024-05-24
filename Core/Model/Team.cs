using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Model
{
    public class Team
    {
        public int Id { get; set; }
       
        public string FullName { get; set; }
        [Required]
        [StringLength(50)]
        public string Position { get; set; }
        [Required]
        [StringLength(50)]
        public string? ImgUrl { get; set; }
        [NotMapped]
        public IFormFile? PhotoFile { get; set; }   
    }

}
