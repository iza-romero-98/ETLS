﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class Municipios
    {
        public Municipios()
        {
            DatosFacturacion = new HashSet<DatosFacturacion>();
            GeneralesAlumno = new HashSet<GeneralesAlumno>();
        }

        public int MunicipiosId { get; set; }
        public string MunicipiosNombre { get; set; }
        public int MunicipioEstado { get; set; }

        public virtual ICollection<DatosFacturacion> DatosFacturacion { get; set; }
        public virtual ICollection<GeneralesAlumno> GeneralesAlumno { get; set; }
    }
}