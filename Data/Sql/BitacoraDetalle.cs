﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class BitacoraDetalle
    {
        public long Bgdid { get; set; }
        public long Bgid { get; set; }
        public long Bgdusuid { get; set; }
        public string Bgdpantalla { get; set; }
        public int Bgdrol { get; set; }
        public int Bgdcampanaid { get; set; }
        public string BgddireccionIp { get; set; }
        public string BgdestadoAnt { get; set; }
        public string BgdestadoAct { get; set; }
        public string BgdcomentarioM { get; set; }

        public virtual BitacoraGral Bg { get; set; }
    }
}