﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;

namespace ETL.Data.Sql
{
    public partial class DocumentosGenerales
    {
        public DocumentosGenerales()
        {
            Convenios = new HashSet<Convenios>();
        }

        public long DgPersonaId { get; set; }
        public int DgTipoDoc { get; set; }
        public int DgEstatus { get; set; }
        public DateTime DgFecReg { get; set; }
        public long DgAtendio { get; set; }
        public string DgNombre { get; set; }
        public byte[] DgDocumento { get; set; }
        public int? DgTipoPers { get; set; }
        public long Dgid { get; set; }
        public string DgComentario { get; set; }
        public string DgDocRoute { get; set; }

        public virtual ICollection<Convenios> Convenios { get; set; }
    }
}