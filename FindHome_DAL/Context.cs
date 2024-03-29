﻿using FindHome_Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindHome_DAL
{
    public class Context:DbContext
    {
        public DbSet<Housing> Housings { get; set; }
        public DbSet<HousingType> HousingTypes { get; set; }
        public DbSet<BaseCategory> BaseCategories { get; set; }
        public DbSet<Owner> Owners { get; set; }
    }
}
