﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class MoodleKey
    {
        public int IdMoodleKey { get; set; }
        public int NivelId { get; set; }
        public string MoodleName { get; set; }
        public string MoodleKey1 { get; set; }
        public DateTime MoodleFechaRegistro { get; set; }
        public long Usuid { get; set; }

        public virtual Niveles Nivel { get; set; }
        public virtual Usuario Usu { get; set; }
    }
}