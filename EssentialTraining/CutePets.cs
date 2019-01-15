using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EssentialTraining
{
    public class CutePets
    {
        public List<string> Pets { get; set; }

        public CutePets()
        {
            Pets = new List<string>();
        }

        public bool IsCute(string pet)
        {
            return Pets.Contains(pet);
        }
    }
  
}
