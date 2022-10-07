using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// ********************************
using Microsoft.EntityFrameworkCore;
using SeguridadWeb.EntidadesDeNegocio;

namespace SeguridadWeb.AccesoADatos
{
    public class BDContexto : DbContext
    {
        public DbSet<Rol> Rol { get; set; }
        public DbSet<Usuario> Usuario { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"workstation id=PruebaPersonal.mssql.somee.com;packet size=4096;user id=BoniDev_SQLLogin_1;pwd=pfkfdconl7;data source=PruebaPersonal.mssql.somee.com;persist security info=False;initial catalog=PruebaPersonal");
        }
    }
}
