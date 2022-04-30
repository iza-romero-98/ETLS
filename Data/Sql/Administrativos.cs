﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class Administrativos
    {
        public Administrativos()
        {
            StatusHistorial = new HashSet<StatusHistorial>();
        }

        public string AdminId { get; set; }
        public long AdminNumeroEmpleado { get; set; }
        public string AdminNombre { get; set; }
        public string AdminApp { get; set; }
        public string AdminApm { get; set; }
        public DateTime AdminFechaNacimiento { get; set; }
        public string AdminCurp { get; set; }
        public string AdminRfc { get; set; }
        public DateTime AdminFechaIngreso { get; set; }
        public bool AdminSexo { get; set; }
        public int AdminNacionalidad { get; set; }
        public string AdminCorreo { get; set; }
        public string AdminExtension { get; set; }
        public int AdminTipoPago { get; set; }
        public bool? AdminActivo { get; set; }

        public virtual DatosMedicos DatosMedicos { get; set; }
        public virtual GeneralesAdministrativos GeneralesAdministrativos { get; set; }
        public virtual ICollection<StatusHistorial> StatusHistorial { get; set; }
    }
}