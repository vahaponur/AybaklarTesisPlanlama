using ATP.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATP.Data
{
    public class FacilityValidator
    {
        List<string> messages = new List<string>();
        bool validated = false;
        public bool Validated { get { return validated; } }
        public List<string> Messages { get { return messages; } }
        public FacilityValidator( Facility facility) 
        { 
            if (facility != null)
            {
                if (string.IsNullOrEmpty(facility.Name)) { messages.Add( "İsim bos olamaz.");  return; }
                if (string.IsNullOrEmpty(facility.Adress.City)) { messages.Add("İl boş olamaz"); return; }
                validated = true;
            }
        }
    }
}
