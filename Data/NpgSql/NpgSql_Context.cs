﻿// <auto-generated> This file has been auto generated by EF Core Power Tools. </auto-generated>
#nullable disable
using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ETL.Data.NpgSql
{
    public partial class NpgSql_Context : DbContext
    {
        public NpgSql_Context()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql(@"Server = interpue.com.mx; Port = 5435; Database = InterERP; User Id = pruebas; Password = Root.inter19!; Trust Server Certificate=true; Include Error Detail = true;");
        }

        public NpgSql_Context(DbContextOptions<NpgSql_Context> options)
            : base(options)
        {
        }

        public virtual DbSet<Cclistapreciosconcepto> Cclistapreciosconcepto { get; set; }
        public virtual DbSet<Etlalumno> Etlalumno { get; set; }
        public virtual DbSet<Etlcatalogoconcepto> Etlcatalogoconcepto { get; set; }
        public virtual DbSet<Etlcuentasdetalle> Etlcuentasdetalle { get; set; }
        public virtual DbSet<Etlreferencia> Etlreferencia { get; set; }
        public virtual DbSet<Etlreferenciasconceptos> Etlreferenciasconceptos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasPostgresExtension("dblink");

            modelBuilder.Entity<Cclistapreciosconcepto>(entity =>
            {
                entity.HasKey(e => new { e.Lpdivisionid, e.Lpconceptocon })
                    .HasName("cclistapreciosconcepto_pkey");

                entity.ToTable("cclistapreciosconcepto");

                entity.HasIndex(e => e.Companiaid, "cclistapreciosconcepto_companiaid_idx");

                entity.HasIndex(e => e.Fecvenid, "cclistapreciosconcepto_fecvenid_idx");

                entity.Property(e => e.Lpdivisionid)
                    .HasMaxLength(5)
                    .HasColumnName("lpdivisionid")
                    .IsFixedLength();

                entity.Property(e => e.Lpconceptocon).HasColumnName("lpconceptocon");

                entity.Property(e => e.Companiaid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("companiaid")
                    .IsFixedLength();

                entity.Property(e => e.Fecvenid)
                    .HasMaxLength(10)
                    .HasColumnName("fecvenid")
                    .HasDefaultValueSql("NULL::bpchar")
                    .IsFixedLength();

                entity.Property(e => e.Lpconceptodes)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("lpconceptodes")
                    .IsFixedLength();

                entity.Property(e => e.Lpconceptofecfin).HasColumnName("lpconceptofecfin");

                entity.Property(e => e.Lpconceptofecini).HasColumnName("lpconceptofecini");

                entity.Property(e => e.Lpconceptogeneracion)
                    .HasMaxLength(4)
                    .HasColumnName("lpconceptogeneracion")
                    .HasDefaultValueSql("NULL::bpchar")
                    .IsFixedLength();

                entity.Property(e => e.Lpconceptogrupo)
                    .HasMaxLength(1)
                    .HasColumnName("lpconceptogrupo")
                    .HasDefaultValueSql("NULL::bpchar");

                entity.Property(e => e.Lpconceptoid)
                    .IsRequired()
                    .HasMaxLength(5)
                    .HasColumnName("lpconceptoid")
                    .IsFixedLength();

                entity.Property(e => e.Lpconceptoprecio)
                    .HasPrecision(9, 2)
                    .HasColumnName("lpconceptoprecio");

                entity.Property(e => e.Varianteid)
                    .HasMaxLength(10)
                    .HasColumnName("varianteid")
                    .HasDefaultValueSql("NULL::bpchar")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Etlalumno>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("etlalumno");

                entity.Property(e => e.Aacfapellidom)
                    .HasMaxLength(50)
                    .HasColumnName("aacfapellidom")
                    .IsFixedLength();

                entity.Property(e => e.Aacfapellidop)
                    .HasMaxLength(50)
                    .HasColumnName("aacfapellidop")
                    .IsFixedLength();

                entity.Property(e => e.Aacfmail)
                    .HasMaxLength(150)
                    .HasColumnName("aacfmail")
                    .IsFixedLength();

                entity.Property(e => e.Aacfnomtutor)
                    .HasMaxLength(50)
                    .HasColumnName("aacfnomtutor")
                    .IsFixedLength();

                entity.Property(e => e.Aacftelefono)
                    .HasMaxLength(150)
                    .HasColumnName("aacftelefono")
                    .IsFixedLength();

                entity.Property(e => e.Aacftelefonot)
                    .HasMaxLength(25)
                    .HasColumnName("aacftelefonot")
                    .IsFixedLength();

                entity.Property(e => e.Aacsemestreactual).HasColumnName("aacsemestreactual");

                entity.Property(e => e.Acarid)
                    .HasMaxLength(20)
                    .HasColumnName("acarid")
                    .IsFixedLength();

                entity.Property(e => e.Aluestado)
                    .HasMaxLength(2)
                    .HasColumnName("aluestado")
                    .IsFixedLength();

                entity.Property(e => e.Alumodalidad)
                    .HasMaxLength(10)
                    .HasColumnName("alumodalidad")
                    .IsFixedLength();

                entity.Property(e => e.Alunocontrol)
                    .HasMaxLength(20)
                    .HasColumnName("alunocontrol")
                    .IsFixedLength();

                entity.Property(e => e.Alureganio).HasColumnName("alureganio");

                entity.Property(e => e.Aluregperiodo).HasColumnName("aluregperiodo");

                entity.Property(e => e.Bcid)
                    .HasMaxLength(20)
                    .HasColumnName("bcid")
                    .IsFixedLength();

                entity.Property(e => e.Beid).HasColumnName("beid");

                entity.Property(e => e.Beparcialidades)
                    .HasPrecision(7, 3)
                    .HasColumnName("beparcialidades");

                entity.Property(e => e.Cicloatual).HasColumnName("cicloatual");

                entity.Property(e => e.Coddescripcion)
                    .HasMaxLength(250)
                    .HasColumnName("coddescripcion")
                    .IsFixedLength();

                entity.Property(e => e.Crmamaterno)
                    .HasMaxLength(50)
                    .HasColumnName("crmamaterno")
                    .IsFixedLength();

                entity.Property(e => e.Crmapaterno)
                    .HasMaxLength(50)
                    .HasColumnName("crmapaterno")
                    .IsFixedLength();

                entity.Property(e => e.Crmclave)
                    .HasMaxLength(20)
                    .HasColumnName("crmclave")
                    .IsFixedLength();

                entity.Property(e => e.Crmfenac)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("crmfenac");

                entity.Property(e => e.Crmid).HasColumnName("crmid");

                entity.Property(e => e.Crmmodfecha)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("crmmodfecha");

                entity.Property(e => e.Crmmunicipio).HasColumnName("crmmunicipio");

                entity.Property(e => e.Crmnombre)
                    .HasMaxLength(50)
                    .HasColumnName("crmnombre")
                    .IsFixedLength();

                entity.Property(e => e.Crmregfecha)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("crmregfecha");

                entity.Property(e => e.Crmsexo)
                    .HasMaxLength(1)
                    .HasColumnName("crmsexo");
            });

            modelBuilder.Entity<Etlcatalogoconcepto>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("etlcatalogoconcepto");

                entity.Property(e => e.Cpconcepto)
                    .HasMaxLength(100)
                    .HasColumnName("cpconcepto")
                    .IsFixedLength();

                entity.Property(e => e.Cptipodoc)
                    .HasMaxLength(20)
                    .HasColumnName("cptipodoc")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Etlcuentasdetalle>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("etlcuentasdetalle");

                entity.Property(e => e.Aluid).HasColumnName("aluid");

                entity.Property(e => e.Cpconcepto)
                    .HasMaxLength(100)
                    .HasColumnName("cpconcepto")
                    .IsFixedLength();

                entity.Property(e => e.Cpdoclinea)
                    .HasMaxLength(3)
                    .HasColumnName("cpdoclinea")
                    .IsFixedLength();

                entity.Property(e => e.Cpestatus).HasColumnName("cpestatus");

                entity.Property(e => e.Cpfechaven).HasColumnName("cpfechaven");

                entity.Property(e => e.Cpfecreg).HasColumnName("cpfecreg");

                entity.Property(e => e.Cpid).HasColumnName("cpid");

                entity.Property(e => e.Cpidref).HasColumnName("cpidref");

                entity.Property(e => e.Cpimportepend)
                    .HasPrecision(9, 2)
                    .HasColumnName("cpimportepend");

                entity.Property(e => e.Cpimportetotal)
                    .HasPrecision(9, 2)
                    .HasColumnName("cpimportetotal");

                entity.Property(e => e.Cpnodoc).HasColumnName("cpnodoc");
            });

            modelBuilder.Entity<Etlreferencia>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("etlreferencia");

                entity.Property(e => e.Aluid)
                    .HasPrecision(18)
                    .HasColumnName("aluid");

                entity.Property(e => e.Referenciaestatus)
                    .HasMaxLength(60)
                    .HasColumnName("referenciaestatus")
                    .IsFixedLength();

                entity.Property(e => e.Referenciafechaini).HasColumnName("referenciafechaini");

                entity.Property(e => e.Referenciafechavig).HasColumnName("referenciafechavig");

                entity.Property(e => e.Referenciaid)
                    .HasMaxLength(20)
                    .HasColumnName("referenciaid")
                    .IsFixedLength();

                entity.Property(e => e.Referenciatotal)
                    .HasPrecision(9, 2)
                    .HasColumnName("referenciatotal");

                entity.Property(e => e.Reffecreg)
                    .HasColumnType("timestamp without time zone")
                    .HasColumnName("reffecreg");
            });

            modelBuilder.Entity<Etlreferenciasconceptos>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("etlreferenciasconceptos");

                entity.Property(e => e.Cpid).HasColumnName("cpid");

                entity.Property(e => e.Referenciaid)
                    .HasMaxLength(20)
                    .HasColumnName("referenciaid")
                    .IsFixedLength();

                entity.Property(e => e.Refmonto)
                    .HasPrecision(15, 2)
                    .HasColumnName("refmonto");
            });

            modelBuilder.HasSequence("apuestos_apid_seq").StartsAt(18);

            modelBuilder.HasSequence("ccbeca_beid_seq").StartsAt(423);

            modelBuilder.HasSequence("cceventos_eventoid_seq").StartsAt(2);

            modelBuilder.HasSequence("cereporteid");

            modelBuilder.HasSequence("encargados_rpid_seq").StartsAt(6);

            modelBuilder.HasSequence("id_usr_acc");

            modelBuilder.HasSequence("id_usr_mod");

            modelBuilder.HasSequence("idbregistro");

            modelBuilder.HasSequence("idrecl");

            modelBuilder.HasSequence("otid").StartsAt(2);

            modelBuilder.HasSequence("prsid").StartsAt(12);

            modelBuilder.HasSequence("rPayuRegistro_rPayuRegistroid_seq").StartsAt(21);

            modelBuilder.HasSequence("taaplicaciones_apliid_seq").StartsAt(2);

            modelBuilder.HasSequence("tabitacoracorreos_biid_seq").StartsAt(176);

            modelBuilder.HasSequence("tacomentario_comentarioid_seq").StartsAt(36);

            modelBuilder.HasSequence("taconfiguracion_aconid_seq").StartsAt(2);

            modelBuilder.HasSequence("tagenda_ageid_seq");

            modelBuilder.HasSequence("tagrupo_agruid_seq").StartsAt(1308);

            modelBuilder.HasSequence("talumnocarrera_alcid_seq").StartsAt(450);

            modelBuilder.HasSequence("tamateriaimpartir_amaiid_seq").StartsAt(68);

            modelBuilder.HasSequence("tanoticias_noticiaid_seq").StartsAt(8);

            modelBuilder.HasSequence("tarea_areid_seq").StartsAt(4);

            modelBuilder.HasSequence("tareglamento_reglamentoid_seq").StartsAt(35);

            modelBuilder.HasSequence("tbeneficio_benid_seq");

            modelBuilder.HasSequence("tcarrera_carid_seq").StartsAt(7);

            modelBuilder.HasSequence("tcita_citid_seq");

            modelBuilder.HasSequence("tcobranza_cbrid_seq");

            modelBuilder.HasSequence("tcobranzacuenta_ctaid_seq");

            modelBuilder.HasSequence("tcod_tcoid_seq");

            modelBuilder.HasSequence("tcodigo_codid_seq").StartsAt(3327);

            modelBuilder.HasSequence("tcompany_comid_seq");

            modelBuilder.HasSequence("tconfiguracion_cfgid_seq");

            modelBuilder.HasSequence("tcontacto_conid_seq");

            modelBuilder.HasSequence("tcrm_crmid_seq").StartsAt(954);

            modelBuilder.HasSequence("tctabanco_ctbid_seq");

            modelBuilder.HasSequence("tcuestionario_cueid_seq");

            modelBuilder.HasSequence("tescala_idescala_seq").StartsAt(2);

            modelBuilder.HasSequence("texpediente_expid_seq");

            modelBuilder.HasSequence("tfolio_folid_seq");

            modelBuilder.HasSequence("totro_otrid_seq");

            modelBuilder.HasSequence("tpago_pgoid_seq");

            modelBuilder.HasSequence("tpagocuenta_ptaid_seq");

            modelBuilder.HasSequence("tpagos_pagid_seq");

            modelBuilder.HasSequence("tpatron_ptrid_seq");

            modelBuilder.HasSequence("tplanasignado1_pasid_seq");

            modelBuilder.HasSequence("tplancues_pcuid_seq");

            modelBuilder.HasSequence("tprospecto_prsid_seq");

            modelBuilder.HasSequence("tprospectohistorial_prhid_seq");

            modelBuilder.HasSequence("tprueba_idprueba_seq").StartsAt(3);

            modelBuilder.HasSequence("tpruebaaplicacion_idtpa_seq").StartsAt(4);

            modelBuilder.HasSequence("tpruebaprefiles_idperfil_seq").StartsAt(6);

            modelBuilder.HasSequence("trecibo_rboid_seq");

            modelBuilder.HasSequence("tregdel_delid_seq");

            modelBuilder.HasSequence("tseguimiento_segid_seq");

            modelBuilder.HasSequence("ttmprbo_tboid_seq");

            modelBuilder.HasSequence("tusuario_id_seq");

            modelBuilder.HasSequence("tusuario_usuid_seq").StartsAt(1092);

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}