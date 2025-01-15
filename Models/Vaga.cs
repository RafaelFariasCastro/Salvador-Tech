using System;
using Microsoft.EntityFrameworkCore;

namespace PeojetoEstagio.Models
{
    public class Vaga
    {
        public int Id { get; set; }
        public string Name { get; set; } = " ";

        public string Brand { get; set; } = " ";
        public string Category { get; set; } = " ";
        
        [Precision(16,2 )]
        public string Price { get; set; }

        public string Description { get; set; } = " ";

        public string ImageFileName { get; set; } = " ";

        public DateTime CreatedAt { get; set; }
    }
}
