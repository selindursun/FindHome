using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_Entity
{
    public class HousingType
    {
        public int Id { get; set; }
        public string TypeName { get; set; }
        public int BaseCategoryId { get; set; }
        [ForeignKey("TypeId")]
        public virtual BaseCategory BaseCategory { get; set; }

        public virtual List<HousingType> HousingTypes { get; set; } // bir type da birden çok ev olabilir.




    }
}
