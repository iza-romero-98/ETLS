﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class Empresas
    {
        public Empresas()
        {
            ActivoPara = new HashSet<ActivoPara>();
            CuentaBancaria = new HashSet<CuentaBancaria>();
        }

        public int EmpId { get; set; }
        public long? Usuid { get; set; }
        public string EmpDir { get; set; }
        public string EmpRfc { get; set; }
        public string EmpNombre { get; set; }

        public virtual Usuario Usu { get; set; }
        public virtual ICollection<ActivoPara> ActivoPara { get; set; }
        public virtual ICollection<CuentaBancaria> CuentaBancaria { get; set; }
    }
}