using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class BaseCategory
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public virtual List<HousingType> HousingTypes { get; set; }

    }
}
