using Prova_2_bimestre.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Prova_2_bimestre.Contexto
{
    public class Context : DbContext
    {
        public DbSet<secret> secrets { get; set; }
    }
}