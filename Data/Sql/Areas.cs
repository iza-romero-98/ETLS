﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class Areas
    {
        public Areas()
        {
            Puestos = new HashSet<Puestos>();
        }

        public int AreaId { get; set; }
        public string AreaNombre { get; set; }
        public string AreaDescripcion { get; set; }

        public virtual ICollection<Puestos> Puestos { get; set; }
    }
}