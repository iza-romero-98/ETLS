﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class GeneralesAdministrativos
    {
        public string GaAdminId { get; set; }
        public string GaDomicilio { get; set; }
        public string GaColonia { get; set; }
        public int GaMunicipio { get; set; }
        public int GaEstado { get; set; }
        public string GaTelefono { get; set; }
        public string GaCell { get; set; }
        public string GaCorreoAlterno { get; set; }
        public int? GaCp { get; set; }

        public virtual Administrativos GaAdmin { get; set; }
    }
}