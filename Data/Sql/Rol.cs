﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class Rol
    {
        public Rol()
        {
            Tpermisos = new HashSet<Tpermisos>();
        }

        public int Rolid { get; set; }
        public string Rolnombre { get; set; }
        public DateTime? Rolfecha { get; set; }
        public string Roldescripcion { get; set; }
        public decimal Rolactivo { get; set; }

        public virtual ICollection<Tpermisos> Tpermisos { get; set; }
    }
}