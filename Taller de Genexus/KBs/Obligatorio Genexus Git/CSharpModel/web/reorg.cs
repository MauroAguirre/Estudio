/*
               File: reorg
        Description: Table Manager
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 20:37:52.56
       Program type: Callable routine
          Main DBMS: SQL Server
*/
using System;
using System.Collections;
using GeneXus.Utils;
using GeneXus.Resources;
using GeneXus.Application;
using GeneXus.Metadata;
using GeneXus.Cryptography;
using GeneXus.Reorg;
using System.Threading;
using GeneXus.Programs;
using System.Web.Services;
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
namespace GeneXus.Programs {
   public class reorg : GXReorganization
   {
      public reorg( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public reorg( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( )
      {
         initialize();
         executePrivate();
      }

      void executePrivate( )
      {
         SetCreateDataBase( ) ;
         CreateDataBase( ) ;
         if ( PreviousCheck() )
         {
            ExecuteReorganization( ) ;
         }
      }

      private void CreateDataBase( )
      {
         DS = (GxDataStore)(context.GetDataStore( "Default"));
         ErrCode = DS.Connection.FullConnect();
         DataBaseName = DS.Connection.Database;
         if ( ErrCode != 0 )
         {
            DS.Connection.Database = "";
            ErrCode = DS.Connection.FullConnect();
            if ( ErrCode == 0 )
            {
               try
               {
                  GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("GXM_dbcrea")+ " " +DataBaseName , null);
                  cmdBuffer = "CREATE DATABASE " + "[" + DataBaseName + "]";
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
                  Count = 1;
               }
               catch ( Exception ex )
               {
                  ErrCode = 1;
                  GeneXus.Reorg.GXReorganization.AddMsg( ex.Message , null);
                  throw ex ;
               }
               ErrCode = DS.Connection.Disconnect();
               DS.Connection.Database = DataBaseName;
               ErrCode = DS.Connection.FullConnect();
               while ( ( ErrCode != 0 ) && ( Count > 0 ) && ( Count < 30 ) )
               {
                  Res = GXUtil.Sleep( 1);
                  ErrCode = DS.Connection.FullConnect();
                  Count = (short)(Count+1);
               }
               setupDB = 0;
               if ( ( setupDB == 1 ) || GeneXus.Configuration.Preferences.MustSetupDB( ) )
               {
                  defaultUsers = GXUtil.DefaultWebUser( context);
                  short gxidx ;
                  gxidx = 1;
                  while ( gxidx <= defaultUsers.Count )
                  {
                     defaultUser = ((String)defaultUsers.Item(gxidx));
                     try
                     {
                        GeneXus.Reorg.GXReorganization.AddMsg( GXResourceManager.GetMessage("GXM_dbadduser", new   object[]  {defaultUser, DataBaseName}) , null);
                        cmdBuffer = "CREATE LOGIN " + "[" + defaultUser + "]" + " FROM WINDOWS";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "CREATE USER " + "[" + defaultUser + "]" + " FOR LOGIN " + "[" + defaultUser + "]";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "EXEC sp_addrolemember N'db_datareader', N'" + defaultUser + "'";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     try
                     {
                        cmdBuffer = "EXEC sp_addrolemember N'db_datawriter', N'" + defaultUser + "'";
                        RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                        RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                        RGZ.ExecuteStmt() ;
                        RGZ.Drop();
                     }
                     catch ( Exception ex )
                     {
                     }
                     gxidx = (short)(gxidx+1);
                  }
               }
            }
            if ( ErrCode != 0 )
            {
               ErrMsg = DS.ErrDescription;
               GeneXus.Reorg.GXReorganization.AddMsg( ErrMsg , null);
               ErrCode = 1;
               throw new Exception( ErrMsg) ;
            }
         }
      }

      private void FirstActions( )
      {
         /* Load data into tables. */
      }

      public void CreateCarnet( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Carnet */
         try
         {
            cmdBuffer=" CREATE TABLE [Carnet] ([CarnetId]  smallint NOT NULL , [CarnetFechaIngreso]  datetime NOT NULL , PRIMARY KEY([CarnetId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Carnet]") ;
               cmdBuffer=" DROP TABLE [Carnet] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Carnet]") ;
                  cmdBuffer=" DROP VIEW [Carnet] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Carnet]") ;
                     cmdBuffer=" DROP FUNCTION [Carnet] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Carnet] ([CarnetId]  smallint NOT NULL , [CarnetFechaIngreso]  datetime NOT NULL , PRIMARY KEY([CarnetId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateClaseSocios( )
      {
         String cmdBuffer = "" ;
         /* Indices for table ClaseSocios */
         try
         {
            cmdBuffer=" CREATE TABLE [ClaseSocios] ([ClaseId]  smallint NOT NULL , [SocioId]  smallint NOT NULL , PRIMARY KEY([ClaseId], [SocioId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[ClaseSocios]") ;
               cmdBuffer=" DROP TABLE [ClaseSocios] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[ClaseSocios]") ;
                  cmdBuffer=" DROP VIEW [ClaseSocios] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[ClaseSocios]") ;
                     cmdBuffer=" DROP FUNCTION [ClaseSocios] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [ClaseSocios] ([ClaseId]  smallint NOT NULL , [SocioId]  smallint NOT NULL , PRIMARY KEY([ClaseId], [SocioId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ICLASESOCIOS1] ON [ClaseSocios] ([SocioId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [ICLASESOCIOS1] ON [ClaseSocios] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ICLASESOCIOS1] ON [ClaseSocios] ([SocioId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateClase( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Clase */
         try
         {
            cmdBuffer=" CREATE TABLE [Clase] ([ClaseId]  smallint NOT NULL , [ProfesorId]  smallint NOT NULL , PRIMARY KEY([ClaseId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Clase]") ;
               cmdBuffer=" DROP TABLE [Clase] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Clase]") ;
                  cmdBuffer=" DROP VIEW [Clase] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Clase]") ;
                     cmdBuffer=" DROP FUNCTION [Clase] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Clase] ([ClaseId]  smallint NOT NULL , [ProfesorId]  smallint NOT NULL , PRIMARY KEY([ClaseId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ICLASE1] ON [Clase] ([ProfesorId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [ICLASE1] ON [Clase] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ICLASE1] ON [Clase] ([ProfesorId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateProfesor( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Profesor */
         try
         {
            cmdBuffer=" CREATE TABLE [Profesor] ([ProfesorId]  smallint NOT NULL , [ProfesorNombre]  char(20) NOT NULL , [ProfesorDireccion]  varchar(1024) NOT NULL , [ProfesorFoto]  VARBINARY(MAX) NOT NULL , [ProfesorFoto_GXI]  varchar(2048) NULL , [ActividadId]  smallint NOT NULL , PRIMARY KEY([ProfesorId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Profesor]") ;
               cmdBuffer=" DROP TABLE [Profesor] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Profesor]") ;
                  cmdBuffer=" DROP VIEW [Profesor] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Profesor]") ;
                     cmdBuffer=" DROP FUNCTION [Profesor] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Profesor] ([ProfesorId]  smallint NOT NULL , [ProfesorNombre]  char(20) NOT NULL , [ProfesorDireccion]  varchar(1024) NOT NULL , [ProfesorFoto]  VARBINARY(MAX) NOT NULL , [ProfesorFoto_GXI]  varchar(2048) NULL , [ActividadId]  smallint NOT NULL , PRIMARY KEY([ProfesorId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IPROFESOR1] ON [Profesor] ([ActividadId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [IPROFESOR1] ON [Profesor] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [IPROFESOR1] ON [Profesor] ([ActividadId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateSocio( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Socio */
         try
         {
            cmdBuffer=" CREATE TABLE [Socio] ([SocioId]  smallint NOT NULL , [SocioDireccion]  varchar(1024) NOT NULL , [SocioSexo]  char(20) NOT NULL , [SocioEdad]  smallint NOT NULL , [SocioReconocido]  BIT NOT NULL , [SocioFoto]  VARBINARY(MAX) NOT NULL , [SocioFoto_GXI]  varchar(2048) NULL , [SocioTipoCuota]  char(20) NOT NULL , [CarnetId]  smallint NOT NULL , PRIMARY KEY([SocioId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Socio]") ;
               cmdBuffer=" DROP TABLE [Socio] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Socio]") ;
                  cmdBuffer=" DROP VIEW [Socio] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Socio]") ;
                     cmdBuffer=" DROP FUNCTION [Socio] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Socio] ([SocioId]  smallint NOT NULL , [SocioDireccion]  varchar(1024) NOT NULL , [SocioSexo]  char(20) NOT NULL , [SocioEdad]  smallint NOT NULL , [SocioReconocido]  BIT NOT NULL , [SocioFoto]  VARBINARY(MAX) NOT NULL , [SocioFoto_GXI]  varchar(2048) NULL , [SocioTipoCuota]  char(20) NOT NULL , [CarnetId]  smallint NOT NULL , PRIMARY KEY([SocioId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         try
         {
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ISOCIO1] ON [Socio] ([CarnetId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            cmdBuffer=" DROP INDEX [ISOCIO1] ON [Socio] "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            cmdBuffer=" CREATE NONCLUSTERED INDEX [ISOCIO1] ON [Socio] ([CarnetId] ) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void CreateActividad1( )
      {
         String cmdBuffer = "" ;
         /* Indices for table Actividad1 */
         try
         {
            cmdBuffer=" CREATE TABLE [Actividad1] ([ActividadId]  smallint NOT NULL , [ActividadDescripcion]  char(20) NOT NULL , PRIMARY KEY([ActividadId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               DropTableConstraints( "[Actividad1]") ;
               cmdBuffer=" DROP TABLE [Actividad1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
               try
               {
                  DropTableConstraints( "[Actividad1]") ;
                  cmdBuffer=" DROP VIEW [Actividad1] "
                  ;
                  RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                  RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
                  RGZ.ExecuteStmt() ;
                  RGZ.Drop();
               }
               catch ( Exception sqlex2 )
               {
                  try
                  {
                     DropTableConstraints( "[Actividad1]") ;
                     cmdBuffer=" DROP FUNCTION [Actividad1] "
                     ;
                     RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
                     RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
                     RGZ.ExecuteStmt() ;
                     RGZ.Drop();
                  }
                  catch ( Exception sqlex3 )
                  {
                  }
               }
            }
            cmdBuffer=" CREATE TABLE [Actividad1] ([ActividadId]  smallint NOT NULL , [ActividadDescripcion]  char(20) NOT NULL , PRIMARY KEY([ActividadId]))  "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RISocioCarnet( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Socio] ADD CONSTRAINT [ISOCIO1] FOREIGN KEY ([CarnetId]) REFERENCES [Carnet] ([CarnetId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Socio] DROP CONSTRAINT [ISOCIO1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Socio] ADD CONSTRAINT [ISOCIO1] FOREIGN KEY ([CarnetId]) REFERENCES [Carnet] ([CarnetId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIProfesorActividad1( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Profesor] ADD CONSTRAINT [IPROFESOR1] FOREIGN KEY ([ActividadId]) REFERENCES [Actividad1] ([ActividadId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Profesor] DROP CONSTRAINT [IPROFESOR1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Profesor] ADD CONSTRAINT [IPROFESOR1] FOREIGN KEY ([ActividadId]) REFERENCES [Actividad1] ([ActividadId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIClaseProfesor( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [Clase] ADD CONSTRAINT [ICLASE1] FOREIGN KEY ([ProfesorId]) REFERENCES [Profesor] ([ProfesorId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [Clase] DROP CONSTRAINT [ICLASE1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [Clase] ADD CONSTRAINT [ICLASE1] FOREIGN KEY ([ProfesorId]) REFERENCES [Profesor] ([ProfesorId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIClaseSociosClase( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [ClaseSocios] ADD CONSTRAINT [ICLASESOCIOS2] FOREIGN KEY ([ClaseId]) REFERENCES [Clase] ([ClaseId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [ClaseSocios] DROP CONSTRAINT [ICLASESOCIOS2] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [ClaseSocios] ADD CONSTRAINT [ICLASESOCIOS2] FOREIGN KEY ([ClaseId]) REFERENCES [Clase] ([ClaseId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      public void RIClaseSociosSocio( )
      {
         String cmdBuffer ;
         try
         {
            cmdBuffer=" ALTER TABLE [ClaseSocios] ADD CONSTRAINT [ICLASESOCIOS1] FOREIGN KEY ([SocioId]) REFERENCES [Socio] ([SocioId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
         catch ( Exception ex )
         {
            try
            {
               cmdBuffer=" ALTER TABLE [ClaseSocios] DROP CONSTRAINT [ICLASESOCIOS1] "
               ;
               RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
               RGZ.ErrorMask = GxErrorMask.GX_MASKNOTFOUND | GxErrorMask.GX_MASKLOOPLOCK;
               RGZ.ExecuteStmt() ;
               RGZ.Drop();
            }
            catch ( Exception sqlex1 )
            {
            }
            cmdBuffer=" ALTER TABLE [ClaseSocios] ADD CONSTRAINT [ICLASESOCIOS1] FOREIGN KEY ([SocioId]) REFERENCES [Socio] ([SocioId]) "
            ;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
         }
      }

      private void TablesCount( )
      {
      }

      private bool PreviousCheck( )
      {
         if ( ! IsResumeMode( ) )
         {
            if ( GXUtil.DbmsVersion( context, "DEFAULT") < 10 )
            {
               SetCheckError ( GXResourceManager.GetMessage("GXM_bad_DBMS_version", new   object[]  {"2012"}) ) ;
               return false ;
            }
         }
         if ( ! MustRunCheck( ) )
         {
            return true ;
         }
         if ( GXUtil.IsSQLSERVER2005( context, "DEFAULT") )
         {
            /* Using cursor P00012 */
            pr_default.execute(0);
            while ( (pr_default.getStatus(0) != 101) )
            {
               sSchemaVar = P00012_AsSchemaVar[0];
               nsSchemaVar = P00012_nsSchemaVar[0];
               pr_default.readNext(0);
            }
            pr_default.close(0);
         }
         else
         {
            /* Using cursor P00023 */
            pr_default.execute(1);
            while ( (pr_default.getStatus(1) != 101) )
            {
               sSchemaVar = P00023_AsSchemaVar[0];
               nsSchemaVar = P00023_nsSchemaVar[0];
               pr_default.readNext(1);
            }
            pr_default.close(1);
         }
         return true ;
      }

      private void ExecuteOnlyTablesReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 1 ,  "CreateCarnet" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 2 ,  "CreateClaseSocios" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 3 ,  "CreateClase" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 4 ,  "CreateProfesor" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 5 ,  "CreateSocio" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 6 ,  "CreateActividad1" , new Object[]{ });
      }

      private void ExecuteOnlyRisReorganization( )
      {
         ReorgExecute.RegisterBlockForSubmit( 7 ,  "RISocioCarnet" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 8 ,  "RIProfesorActividad1" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 9 ,  "RIClaseProfesor" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 10 ,  "RIClaseSociosClase" , new Object[]{ });
         ReorgExecute.RegisterBlockForSubmit( 11 ,  "RIClaseSociosSocio" , new Object[]{ });
      }

      private void ExecuteTablesReorganization( )
      {
         ExecuteOnlyTablesReorganization( ) ;
         ExecuteOnlyRisReorganization( ) ;
         ReorgExecute.SubmitAll() ;
      }

      private void SetPrecedence( )
      {
         SetPrecedencetables( ) ;
         SetPrecedenceris( ) ;
      }

      private void SetPrecedencetables( )
      {
         GXReorganization.SetMsg( 1 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Carnet", ""}) );
         GXReorganization.SetMsg( 2 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"ClaseSocios", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateClaseSocios" ,  "CreateClase" );
         ReorgExecute.RegisterPrecedence( "CreateClaseSocios" ,  "CreateSocio" );
         GXReorganization.SetMsg( 3 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Clase", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateClase" ,  "CreateProfesor" );
         GXReorganization.SetMsg( 4 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Profesor", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateProfesor" ,  "CreateActividad1" );
         GXReorganization.SetMsg( 5 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Socio", ""}) );
         ReorgExecute.RegisterPrecedence( "CreateSocio" ,  "CreateCarnet" );
         GXReorganization.SetMsg( 6 ,  GXResourceManager.GetMessage("GXM_filecrea", new   object[]  {"Actividad1", ""}) );
      }

      private void SetPrecedenceris( )
      {
         GXReorganization.SetMsg( 7 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[ISOCIO1]"}) );
         ReorgExecute.RegisterPrecedence( "RISocioCarnet" ,  "CreateSocio" );
         ReorgExecute.RegisterPrecedence( "RISocioCarnet" ,  "CreateCarnet" );
         GXReorganization.SetMsg( 8 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[IPROFESOR1]"}) );
         ReorgExecute.RegisterPrecedence( "RIProfesorActividad1" ,  "CreateProfesor" );
         ReorgExecute.RegisterPrecedence( "RIProfesorActividad1" ,  "CreateActividad1" );
         GXReorganization.SetMsg( 9 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[ICLASE1]"}) );
         ReorgExecute.RegisterPrecedence( "RIClaseProfesor" ,  "CreateClase" );
         ReorgExecute.RegisterPrecedence( "RIClaseProfesor" ,  "CreateProfesor" );
         GXReorganization.SetMsg( 10 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[ICLASESOCIOS2]"}) );
         ReorgExecute.RegisterPrecedence( "RIClaseSociosClase" ,  "CreateClaseSocios" );
         ReorgExecute.RegisterPrecedence( "RIClaseSociosClase" ,  "CreateClase" );
         GXReorganization.SetMsg( 11 ,  GXResourceManager.GetMessage("GXM_refintcrea", new   object[]  {"[ICLASESOCIOS1]"}) );
         ReorgExecute.RegisterPrecedence( "RIClaseSociosSocio" ,  "CreateClaseSocios" );
         ReorgExecute.RegisterPrecedence( "RIClaseSociosSocio" ,  "CreateSocio" );
      }

      private void ExecuteReorganization( )
      {
         if ( ErrCode == 0 )
         {
            TablesCount( ) ;
            if ( ! PrintOnlyRecordCount( ) )
            {
               FirstActions( ) ;
               SetPrecedence( ) ;
               ExecuteTablesReorganization( ) ;
            }
         }
      }

      [System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.Synchronized)]
      public void DropTableConstraints( String sTableName )
      {
         String cmdBuffer ;
         /* Using cursor P00034 */
         pr_default.execute(2, new Object[] {sTableName});
         while ( (pr_default.getStatus(2) != 101) )
         {
            constid = P00034_Aconstid[0];
            nconstid = P00034_nconstid[0];
            fkeyid = P00034_Afkeyid[0];
            nfkeyid = P00034_nfkeyid[0];
            rkeyid = P00034_Arkeyid[0];
            nrkeyid = P00034_nrkeyid[0];
            cmdBuffer = "ALTER TABLE " + "[" + fkeyid + "] DROP CONSTRAINT " + constid;
            RGZ = new GxCommand(dsDefault.Db, cmdBuffer, dsDefault,0,true,false,null);
            RGZ.ErrorMask = GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK;
            RGZ.ExecuteStmt() ;
            RGZ.Drop();
            pr_default.readNext(2);
         }
         pr_default.close(2);
      }

      public void UtilsCleanup( )
      {
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         DS = new GxDataStore();
         ErrMsg = "";
         DataBaseName = "";
         defaultUsers = new GeneXus.Utils.GxStringCollection();
         defaultUser = "";
         sSchemaVar = "";
         nsSchemaVar = false;
         scmdbuf = "";
         P00012_AsSchemaVar = new String[] {""} ;
         P00012_nsSchemaVar = new bool[] {false} ;
         P00023_AsSchemaVar = new String[] {""} ;
         P00023_nsSchemaVar = new bool[] {false} ;
         sTableName = "";
         constid = "";
         nconstid = false;
         fkeyid = "";
         nfkeyid = false;
         P00034_Aconstid = new String[] {""} ;
         P00034_nconstid = new bool[] {false} ;
         P00034_Afkeyid = new String[] {""} ;
         P00034_nfkeyid = new bool[] {false} ;
         P00034_Arkeyid = new int[1] ;
         P00034_nrkeyid = new bool[] {false} ;
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.reorg__default(),
            new Object[][] {
                new Object[] {
               P00012_AsSchemaVar
               }
               , new Object[] {
               P00023_AsSchemaVar
               }
               , new Object[] {
               P00034_Aconstid, P00034_Afkeyid, P00034_Arkeyid
               }
            }
         );
         /* GeneXus formulas. */
      }

      protected short ErrCode ;
      protected short Count ;
      protected short Res ;
      protected short setupDB ;
      protected int rkeyid ;
      protected String ErrMsg ;
      protected String DataBaseName ;
      protected String cmdBuffer ;
      protected String defaultUser ;
      protected String sSchemaVar ;
      protected String scmdbuf ;
      protected String sTableName ;
      protected bool nsSchemaVar ;
      protected bool nconstid ;
      protected bool nfkeyid ;
      protected bool nrkeyid ;
      protected String constid ;
      protected String fkeyid ;
      protected GeneXus.Utils.GxStringCollection defaultUsers ;
      protected GxDataStore DS ;
      protected IGxDataStore dsDefault ;
      protected GxCommand RGZ ;
      protected IDataStoreProvider pr_default ;
      protected String[] P00012_AsSchemaVar ;
      protected bool[] P00012_nsSchemaVar ;
      protected String[] P00023_AsSchemaVar ;
      protected bool[] P00023_nsSchemaVar ;
      protected String[] P00034_Aconstid ;
      protected bool[] P00034_nconstid ;
      protected String[] P00034_Afkeyid ;
      protected bool[] P00034_nfkeyid ;
      protected int[] P00034_Arkeyid ;
      protected bool[] P00034_nrkeyid ;
   }

   public class reorg__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmP00012 ;
          prmP00012 = new Object[] {
          } ;
          Object[] prmP00023 ;
          prmP00023 = new Object[] {
          } ;
          Object[] prmP00034 ;
          prmP00034 = new Object[] {
          new Object[] {"@sTableName",SqlDbType.Char,255,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("P00012", "SELECT SCHEMA_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00012,100,0,true,false )
             ,new CursorDef("P00023", "SELECT USER_NAME() ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00023,100,0,true,false )
             ,new CursorDef("P00034", "SELECT OBJECT_NAME(object_id), OBJECT_NAME(parent_object_id), referenced_object_id FROM sys.foreign_keys WHERE referenced_object_id = OBJECT_ID(RTRIM(LTRIM(@sTableName))) ",false, GxErrorMask.GX_NOMASK | GxErrorMask.GX_MASKLOOPLOCK, false, this,prmP00034,100,0,true,false )
          };
       }
    }

    public void getResults( int cursor ,
                            IFieldGetter rslt ,
                            Object[] buf )
    {
       switch ( cursor )
       {
             case 0 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 1 :
                ((String[]) buf[0])[0] = rslt.getString(1, 255) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getVarchar(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((int[]) buf[2])[0] = rslt.getInt(3) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 2 :
                stmt.SetParameter(1, (String)parms[0]);
                return;
       }
    }

 }

}
