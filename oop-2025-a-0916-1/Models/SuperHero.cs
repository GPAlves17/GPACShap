 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oop_2025_a_0916_1.Models
{
    public class SuperHero
    {
        public string Name { get; set; } = String.Empty;

        public string Alias { get; set; } = String.Empty;

        public override string ToString()
        {
            return $"{Name} is {Alias}";

        }
    }
}
