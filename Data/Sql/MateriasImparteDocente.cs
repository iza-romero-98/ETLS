﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class MateriasImparteDocente
    {
        public string MidDocenteId { get; set; }
        public int MidMateriaId { get; set; }

        public virtual Administrativos MidDocente { get; set; }
        public virtual Materias MidMateria { get; set; }
    }
}