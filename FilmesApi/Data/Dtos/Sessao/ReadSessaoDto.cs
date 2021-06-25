using FilmesAPI.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FilmesAPI.Data.Dtos
{
    public class ReadSessaoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }
        public object Cinema { get; set; }
        public object Filme { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioEncerramento { get; set; }
    }
}
