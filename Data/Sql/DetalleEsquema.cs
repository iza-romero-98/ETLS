﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class DetalleEsquema
    {
        public int DetalleEsquemaId { get; set; }
        public int LpId { get; set; }
        public bool? DeMensualidad { get; set; }
        public bool? DeInscripcion { get; set; }

        public virtual ListaPrecios Lp { get; set; }
    }
}