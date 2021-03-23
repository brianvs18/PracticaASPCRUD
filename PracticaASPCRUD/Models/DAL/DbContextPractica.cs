using Microsoft.EntityFrameworkCore;
using PracticaASPCRUD.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaASPCRUD.Models.DAL
{
    //Esta clase interactua con el modelo o acceder al modelo
    //Conexion con la BD
    public class DbContextPractica: DbContext
    {
        public DbContextPractica(DbContextOptions<DbContextPractica> options): base(options)
        {
        }
        public DbSet<Empleado> Empleados { get; set; }
        public DbSet<Cargo> Cargos { get; set; }
    }
}
