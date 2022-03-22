using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class Owner
    {
        public int Id { get; set; }
        public string Name { get; set; } 
        public string Surname { get; set; }
        public String PhoneNumber { get; set; }       
        public virtual List<Housing> Housings { get; set; } //bire çok ilişkiden yaptım.her ev sahibinin birden çok evi olanilir.

    }
}
