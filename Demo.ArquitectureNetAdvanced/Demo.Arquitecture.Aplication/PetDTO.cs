using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Arquitecture.Aplication.DTO
{
    public class PetDTO
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Raice { get; set; }
        public string Legs { get; set; }
        public DateTime Birth { get; set; }
    }
}
