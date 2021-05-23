using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using CRUD_OPRATION.Models;

namespace CRUD_OPRATION.DataBase
{
    public class DataBaseContext :DbContext
    {
        public DataBaseContext() : base(nameOrConnectionString:"Myconnection")
        {

        }

        public virtual DbSet<Stud>studobj { get; set; }
    }
}