/*
               File: Clase_BC
        Description: Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:39.5
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
using System.Data;
using System.Data.SqlClient;
using GeneXus.Data;
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class clase_bc : GXHttpHandler, IGxSilentTrn
   {
      public clase_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public clase_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtClase> GetAll( int Start ,
                                              int Count )
      {
         GXPagingFrom12 = Start;
         GXPagingTo12 = Count;
         /* Using cursor BC00049 */
         pr_default.execute(7, new Object[] {GXPagingFrom12, GXPagingTo12});
         RcdFound12 = 0;
         if ( (pr_default.getStatus(7) != 101) )
         {
            RcdFound12 = 1;
            A3ClaseId = BC00049_A3ClaseId[0];
            A13ActividadDescripcion = BC00049_A13ActividadDescripcion[0];
            A15ProfesorNombre = BC00049_A15ProfesorNombre[0];
            A2ProfesorId = BC00049_A2ProfesorId[0];
            A1ActividadId = BC00049_A1ActividadId[0];
         }
         bcClase = new SdtClase(context);
         gx_restcollection.Clear();
         while ( RcdFound12 != 0 )
         {
            OnLoadActions0412( ) ;
            AddRow0412( ) ;
            gx_sdt_item = (SdtClase)(bcClase.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(7);
            RcdFound12 = 0;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(7) != 101) )
            {
               RcdFound12 = 1;
               A3ClaseId = BC00049_A3ClaseId[0];
               A13ActividadDescripcion = BC00049_A13ActividadDescripcion[0];
               A15ProfesorNombre = BC00049_A15ProfesorNombre[0];
               A2ProfesorId = BC00049_A2ProfesorId[0];
               A1ActividadId = BC00049_A1ActividadId[0];
            }
            Gx_mode = sMode12;
         }
         pr_default.close(7);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM0412( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow0412( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0412( ) ;
         standaloneModal( ) ;
         AddRow0412( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11042 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z3ClaseId = A3ClaseId;
               SetMode( "UPD") ;
            }
         }
      }

      public override String ToString( )
      {
         return "" ;
      }

      public GxContentInfo GetContentInfo( )
      {
         return (GxContentInfo)(null) ;
      }

      public bool Reindex( )
      {
         return true ;
      }

      protected void CONFIRM_040( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0412( ) ;
            }
            else
            {
               CheckExtendedTable0412( ) ;
               if ( AnyError == 0 )
               {
                  ZM0412( 3) ;
                  ZM0412( 4) ;
               }
               CloseExtendedTableCursors0412( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            /* Save parent mode. */
            sMode12 = Gx_mode;
            CONFIRM_0413( ) ;
            if ( AnyError == 0 )
            {
               /* Restore parent mode. */
               Gx_mode = sMode12;
               IsConfirmed = 1;
            }
            /* Restore parent mode. */
            Gx_mode = sMode12;
         }
      }

      protected void CONFIRM_0413( )
      {
         nGXsfl_13_idx = 0;
         while ( nGXsfl_13_idx < bcClase.gxTpr_Socios.Count )
         {
            ReadRow0413( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound13 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) || ( nIsMod_13 != 0 ) )
            {
               GetKey0413( ) ;
               if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 ) )
               {
                  if ( RcdFound13 == 0 )
                  {
                     Gx_mode = "INS";
                     BeforeValidate0413( ) ;
                     if ( AnyError == 0 )
                     {
                        CheckExtendedTable0413( ) ;
                        if ( AnyError == 0 )
                        {
                           ZM0413( 6) ;
                        }
                        CloseExtendedTableCursors0413( ) ;
                        if ( AnyError == 0 )
                        {
                           IsConfirmed = 1;
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                     AnyError = 1;
                  }
               }
               else
               {
                  if ( RcdFound13 != 0 )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                     {
                        Gx_mode = "DLT";
                        getByPrimaryKey0413( ) ;
                        Load0413( ) ;
                        BeforeValidate0413( ) ;
                        if ( AnyError == 0 )
                        {
                           OnDeleteControls0413( ) ;
                        }
                     }
                     else
                     {
                        if ( nIsMod_13 != 0 )
                        {
                           Gx_mode = "UPD";
                           BeforeValidate0413( ) ;
                           if ( AnyError == 0 )
                           {
                              CheckExtendedTable0413( ) ;
                              if ( AnyError == 0 )
                              {
                                 ZM0413( 6) ;
                              }
                              CloseExtendedTableCursors0413( ) ;
                              if ( AnyError == 0 )
                              {
                                 IsConfirmed = 1;
                              }
                           }
                        }
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "DLT") != 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
               VarsToRow13( ((SdtClase_Socios)bcClase.gxTpr_Socios.Item(nGXsfl_13_idx))) ;
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
      }

      protected void E12042( )
      {
         /* Start Routine */
      }

      protected void E11042( )
      {
         /* After Trn Routine */
      }

      protected void ZM0412( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z2ProfesorId = A2ProfesorId;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z15ProfesorNombre = A15ProfesorNombre;
            Z1ActividadId = A1ActividadId;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
            Z13ActividadDescripcion = A13ActividadDescripcion;
         }
         if ( GX_JID == -2 )
         {
            Z3ClaseId = A3ClaseId;
            Z2ProfesorId = A2ProfesorId;
            Z15ProfesorNombre = A15ProfesorNombre;
            Z1ActividadId = A1ActividadId;
            Z13ActividadDescripcion = A13ActividadDescripcion;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A3ClaseId) && ( Gx_BScreen == 0 ) )
         {
            GXt_int1 = A3ClaseId;
            new ultimoidclase(context ).execute( out  GXt_int1) ;
            A3ClaseId = GXt_int1;
         }
      }

      protected void Load0412( )
      {
         /* Using cursor BC000410 */
         pr_default.execute(8, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(8) != 101) )
         {
            RcdFound12 = 1;
            A13ActividadDescripcion = BC000410_A13ActividadDescripcion[0];
            A15ProfesorNombre = BC000410_A15ProfesorNombre[0];
            A2ProfesorId = BC000410_A2ProfesorId[0];
            A1ActividadId = BC000410_A1ActividadId[0];
            ZM0412( -2) ;
         }
         pr_default.close(8);
         OnLoadActions0412( ) ;
      }

      protected void OnLoadActions0412( )
      {
      }

      protected void CheckExtendedTable0412( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00047 */
         pr_default.execute(5, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(5) == 101) )
         {
            GX_msglist.addItem("No matching 'Profesor'.", "ForeignKeyNotFound", 1, "PROFESORID");
            AnyError = 1;
         }
         A15ProfesorNombre = BC00047_A15ProfesorNombre[0];
         A1ActividadId = BC00047_A1ActividadId[0];
         pr_default.close(5);
         /* Using cursor BC00048 */
         pr_default.execute(6, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(6) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "");
            AnyError = 1;
         }
         A13ActividadDescripcion = BC00048_A13ActividadDescripcion[0];
         pr_default.close(6);
      }

      protected void CloseExtendedTableCursors0412( )
      {
         pr_default.close(5);
         pr_default.close(6);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0412( )
      {
         /* Using cursor BC000411 */
         pr_default.execute(9, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound12 = 1;
         }
         else
         {
            RcdFound12 = 0;
         }
         pr_default.close(9);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00046 */
         pr_default.execute(4, new Object[] {A3ClaseId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            ZM0412( 2) ;
            RcdFound12 = 1;
            A3ClaseId = BC00046_A3ClaseId[0];
            A2ProfesorId = BC00046_A2ProfesorId[0];
            Z3ClaseId = A3ClaseId;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0412( ) ;
            if ( AnyError == 1 )
            {
               RcdFound12 = 0;
               InitializeNonKey0412( ) ;
            }
            Gx_mode = sMode12;
         }
         else
         {
            RcdFound12 = 0;
            InitializeNonKey0412( ) ;
            sMode12 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode12;
         }
         pr_default.close(4);
      }

      protected void getEqualNoModal( )
      {
         GetKey0412( ) ;
         if ( RcdFound12 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
         }
         getByPrimaryKey( ) ;
      }

      protected void insert_Check( )
      {
         CONFIRM_040( ) ;
         IsConfirmed = 0;
      }

      protected void update_Check( )
      {
         insert_Check( ) ;
      }

      protected void delete_Check( )
      {
         insert_Check( ) ;
      }

      protected void CheckOptimisticConcurrency0412( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00045 */
            pr_default.execute(3, new Object[] {A3ClaseId});
            if ( (pr_default.getStatus(3) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clase"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(3) == 101) || ( Z2ProfesorId != BC00045_A2ProfesorId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Clase"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0412( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0412( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0412( 0) ;
            CheckOptimisticConcurrency0412( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0412( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0412( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000412 */
                     pr_default.execute(10, new Object[] {A3ClaseId, A2ProfesorId});
                     pr_default.close(10);
                     dsDefault.SmartCacheProvider.SetUpdated("Clase") ;
                     if ( (pr_default.getStatus(10) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0412( ) ;
                           if ( AnyError == 0 )
                           {
                              /* Save values for previous() function. */
                              GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
                           }
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0412( ) ;
            }
            EndLevel0412( ) ;
         }
         CloseExtendedTableCursors0412( ) ;
      }

      protected void Update0412( )
      {
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0412( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0412( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0412( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0412( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000413 */
                     pr_default.execute(11, new Object[] {A2ProfesorId, A3ClaseId});
                     pr_default.close(11);
                     dsDefault.SmartCacheProvider.SetUpdated("Clase") ;
                     if ( (pr_default.getStatus(11) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Clase"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0412( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           ProcessLevel0412( ) ;
                           if ( AnyError == 0 )
                           {
                              getByPrimaryKey( ) ;
                              GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
                           }
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0412( ) ;
         }
         CloseExtendedTableCursors0412( ) ;
      }

      protected void DeferredUpdate0412( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0412( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0412( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0412( ) ;
            AfterConfirm0412( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0412( ) ;
               if ( AnyError == 0 )
               {
                  ScanKeyStart0413( ) ;
                  while ( RcdFound13 != 0 )
                  {
                     getByPrimaryKey0413( ) ;
                     Delete0413( ) ;
                     ScanKeyNext0413( ) ;
                  }
                  ScanKeyEnd0413( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000414 */
                     pr_default.execute(12, new Object[] {A3ClaseId});
                     pr_default.close(12);
                     dsDefault.SmartCacheProvider.SetUpdated("Clase") ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( delete) rules */
                        /* End of After( delete) rules */
                        if ( AnyError == 0 )
                        {
                           GX_msglist.addItem(context.GetMessage( "GXM_sucdeleted", ""), "SuccessfullyDeleted", 0, "", true);
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
         }
         sMode12 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0412( ) ;
         Gx_mode = sMode12;
      }

      protected void OnDeleteControls0412( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000415 */
            pr_default.execute(13, new Object[] {A2ProfesorId});
            A15ProfesorNombre = BC000415_A15ProfesorNombre[0];
            A1ActividadId = BC000415_A1ActividadId[0];
            pr_default.close(13);
            /* Using cursor BC000416 */
            pr_default.execute(14, new Object[] {A1ActividadId});
            A13ActividadDescripcion = BC000416_A13ActividadDescripcion[0];
            pr_default.close(14);
         }
      }

      protected void ProcessNestedLevel0413( )
      {
         nGXsfl_13_idx = 0;
         while ( nGXsfl_13_idx < bcClase.gxTpr_Socios.Count )
         {
            ReadRow0413( ) ;
            if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
            {
               if ( RcdFound13 == 0 )
               {
                  Gx_mode = "INS";
               }
               else
               {
                  Gx_mode = "UPD";
               }
            }
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") != 0 ) || ( nIsMod_13 != 0 ) )
            {
               standaloneNotModal0413( ) ;
               if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
               {
                  Gx_mode = "INS";
                  Insert0413( ) ;
               }
               else
               {
                  if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
                  {
                     Gx_mode = "DLT";
                     Delete0413( ) ;
                  }
                  else
                  {
                     Gx_mode = "UPD";
                     Update0413( ) ;
                  }
               }
            }
            KeyVarsToRow13( ((SdtClase_Socios)bcClase.gxTpr_Socios.Item(nGXsfl_13_idx))) ;
         }
         if ( AnyError == 0 )
         {
            /* Batch update SDT rows */
            nGXsfl_13_idx = 0;
            while ( nGXsfl_13_idx < bcClase.gxTpr_Socios.Count )
            {
               ReadRow0413( ) ;
               if ( String.IsNullOrEmpty(StringUtil.RTrim( Gx_mode)) )
               {
                  if ( RcdFound13 == 0 )
                  {
                     Gx_mode = "INS";
                  }
                  else
                  {
                     Gx_mode = "UPD";
                  }
               }
               /* Update SDT row */
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  bcClase.gxTpr_Socios.RemoveElement(nGXsfl_13_idx);
                  nGXsfl_13_idx = (short)(nGXsfl_13_idx-1);
               }
               else
               {
                  Gx_mode = "UPD";
                  getByPrimaryKey0413( ) ;
                  VarsToRow13( ((SdtClase_Socios)bcClase.gxTpr_Socios.Item(nGXsfl_13_idx))) ;
               }
            }
         }
         /* Start of After( level) rules */
         /* End of After( level) rules */
         InitAll0413( ) ;
         if ( AnyError != 0 )
         {
         }
         nRcdExists_13 = 0;
         nIsMod_13 = 0;
         Gxremove13 = 0;
      }

      protected void ProcessLevel0412( )
      {
         /* Save parent mode. */
         sMode12 = Gx_mode;
         ProcessNestedLevel0413( ) ;
         if ( AnyError != 0 )
         {
         }
         /* Restore parent mode. */
         Gx_mode = sMode12;
         /* ' Update level parameters */
      }

      protected void EndLevel0412( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(3);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0412( ) ;
         }
         if ( AnyError == 0 )
         {
            /* After transaction rules */
            /* Execute 'After Trn' event if defined. */
            trnEnded = 1;
         }
         else
         {
         }
         IsModified = 0;
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart0412( )
      {
         /* Scan By routine */
         /* Using cursor BC000417 */
         pr_default.execute(15, new Object[] {A3ClaseId});
         RcdFound12 = 0;
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A3ClaseId = BC000417_A3ClaseId[0];
            A13ActividadDescripcion = BC000417_A13ActividadDescripcion[0];
            A15ProfesorNombre = BC000417_A15ProfesorNombre[0];
            A2ProfesorId = BC000417_A2ProfesorId[0];
            A1ActividadId = BC000417_A1ActividadId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0412( )
      {
         /* Scan next routine */
         pr_default.readNext(15);
         RcdFound12 = 0;
         ScanKeyLoad0412( ) ;
      }

      protected void ScanKeyLoad0412( )
      {
         sMode12 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(15) != 101) )
         {
            RcdFound12 = 1;
            A3ClaseId = BC000417_A3ClaseId[0];
            A13ActividadDescripcion = BC000417_A13ActividadDescripcion[0];
            A15ProfesorNombre = BC000417_A15ProfesorNombre[0];
            A2ProfesorId = BC000417_A2ProfesorId[0];
            A1ActividadId = BC000417_A1ActividadId[0];
         }
         Gx_mode = sMode12;
      }

      protected void ScanKeyEnd0412( )
      {
         pr_default.close(15);
      }

      protected void AfterConfirm0412( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0412( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0412( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0412( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0412( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0412( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0412( )
      {
      }

      protected void ZM0413( short GX_JID )
      {
         if ( ( GX_JID == 5 ) || ( GX_JID == 0 ) )
         {
         }
         if ( ( GX_JID == 6 ) || ( GX_JID == 0 ) )
         {
            Z20SocioEdad = A20SocioEdad;
            Z18SocioDireccion = A18SocioDireccion;
         }
         if ( GX_JID == -5 )
         {
            Z3ClaseId = A3ClaseId;
            Z5SocioId = A5SocioId;
            Z20SocioEdad = A20SocioEdad;
            Z18SocioDireccion = A18SocioDireccion;
            Z21SocioFoto = A21SocioFoto;
            Z40000SocioFoto_GXI = A40000SocioFoto_GXI;
         }
      }

      protected void standaloneNotModal0413( )
      {
      }

      protected void standaloneModal0413( )
      {
      }

      protected void Load0413( )
      {
         /* Using cursor BC000418 */
         pr_default.execute(16, new Object[] {A3ClaseId, A5SocioId});
         if ( (pr_default.getStatus(16) != 101) )
         {
            RcdFound13 = 1;
            A20SocioEdad = BC000418_A20SocioEdad[0];
            A18SocioDireccion = BC000418_A18SocioDireccion[0];
            A40000SocioFoto_GXI = BC000418_A40000SocioFoto_GXI[0];
            A21SocioFoto = BC000418_A21SocioFoto[0];
            ZM0413( -5) ;
         }
         pr_default.close(16);
         OnLoadActions0413( ) ;
      }

      protected void OnLoadActions0413( )
      {
      }

      protected void CheckExtendedTable0413( )
      {
         Gx_BScreen = 1;
         standaloneModal0413( ) ;
         Gx_BScreen = 0;
         /* Using cursor BC00044 */
         pr_default.execute(2, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
         }
         A20SocioEdad = BC00044_A20SocioEdad[0];
         A18SocioDireccion = BC00044_A18SocioDireccion[0];
         A40000SocioFoto_GXI = BC00044_A40000SocioFoto_GXI[0];
         A21SocioFoto = BC00044_A21SocioFoto[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0413( )
      {
         pr_default.close(2);
      }

      protected void enableDisable0413( )
      {
      }

      protected void GetKey0413( )
      {
         /* Using cursor BC000419 */
         pr_default.execute(17, new Object[] {A3ClaseId, A5SocioId});
         if ( (pr_default.getStatus(17) != 101) )
         {
            RcdFound13 = 1;
         }
         else
         {
            RcdFound13 = 0;
         }
         pr_default.close(17);
      }

      protected void getByPrimaryKey0413( )
      {
         /* Using cursor BC00043 */
         pr_default.execute(1, new Object[] {A3ClaseId, A5SocioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0413( 5) ;
            RcdFound13 = 1;
            InitializeNonKey0413( ) ;
            A5SocioId = BC00043_A5SocioId[0];
            Z3ClaseId = A3ClaseId;
            Z5SocioId = A5SocioId;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal0413( ) ;
            Load0413( ) ;
            Gx_mode = sMode13;
         }
         else
         {
            RcdFound13 = 0;
            InitializeNonKey0413( ) ;
            sMode13 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal0413( ) ;
            Gx_mode = sMode13;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "DSP") == 0 ) || ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 ) )
         {
            DisableAttributes0413( ) ;
         }
         pr_default.close(1);
      }

      protected void CheckOptimisticConcurrency0413( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00042 */
            pr_default.execute(0, new Object[] {A3ClaseId, A5SocioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"ClaseSocios"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"ClaseSocios"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0413( )
      {
         BeforeValidate0413( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0413( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0413( 0) ;
            CheckOptimisticConcurrency0413( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0413( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0413( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC000420 */
                     pr_default.execute(18, new Object[] {A3ClaseId, A5SocioId});
                     pr_default.close(18);
                     dsDefault.SmartCacheProvider.SetUpdated("ClaseSocios") ;
                     if ( (pr_default.getStatus(18) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        /* End of After( Insert) rules */
                        if ( AnyError == 0 )
                        {
                           /* Save values for previous() function. */
                        }
                     }
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
            else
            {
               Load0413( ) ;
            }
            EndLevel0413( ) ;
         }
         CloseExtendedTableCursors0413( ) ;
      }

      protected void Update0413( )
      {
         BeforeValidate0413( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0413( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0413( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0413( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0413( ) ;
                  if ( AnyError == 0 )
                  {
                     /* No attributes to update on table [ClaseSocios] */
                     DeferredUpdate0413( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey0413( ) ;
                        }
                     }
                     else
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                        AnyError = 1;
                     }
                  }
               }
            }
            EndLevel0413( ) ;
         }
         CloseExtendedTableCursors0413( ) ;
      }

      protected void DeferredUpdate0413( )
      {
      }

      protected void Delete0413( )
      {
         Gx_mode = "DLT";
         BeforeValidate0413( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0413( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0413( ) ;
            AfterConfirm0413( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0413( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000421 */
                  pr_default.execute(19, new Object[] {A3ClaseId, A5SocioId});
                  pr_default.close(19);
                  dsDefault.SmartCacheProvider.SetUpdated("ClaseSocios") ;
                  if ( AnyError == 0 )
                  {
                     /* Start of After( delete) rules */
                     /* End of After( delete) rules */
                  }
                  else
                  {
                     GX_msglist.addItem(context.GetMessage( "GXM_unexp", ""), 1, "");
                     AnyError = 1;
                  }
               }
            }
         }
         sMode13 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0413( ) ;
         Gx_mode = sMode13;
      }

      protected void OnDeleteControls0413( )
      {
         standaloneModal0413( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000422 */
            pr_default.execute(20, new Object[] {A5SocioId});
            A20SocioEdad = BC000422_A20SocioEdad[0];
            A18SocioDireccion = BC000422_A18SocioDireccion[0];
            A40000SocioFoto_GXI = BC000422_A40000SocioFoto_GXI[0];
            A21SocioFoto = BC000422_A21SocioFoto[0];
            pr_default.close(20);
         }
      }

      protected void EndLevel0413( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError != 0 )
         {
            context.wjLoc = "";
            context.nUserReturn = 0;
         }
      }

      public void ScanKeyStart0413( )
      {
         /* Scan By routine */
         /* Using cursor BC000423 */
         pr_default.execute(21, new Object[] {A3ClaseId});
         RcdFound13 = 0;
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound13 = 1;
            A20SocioEdad = BC000423_A20SocioEdad[0];
            A18SocioDireccion = BC000423_A18SocioDireccion[0];
            A40000SocioFoto_GXI = BC000423_A40000SocioFoto_GXI[0];
            A5SocioId = BC000423_A5SocioId[0];
            A21SocioFoto = BC000423_A21SocioFoto[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0413( )
      {
         /* Scan next routine */
         pr_default.readNext(21);
         RcdFound13 = 0;
         ScanKeyLoad0413( ) ;
      }

      protected void ScanKeyLoad0413( )
      {
         sMode13 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(21) != 101) )
         {
            RcdFound13 = 1;
            A20SocioEdad = BC000423_A20SocioEdad[0];
            A18SocioDireccion = BC000423_A18SocioDireccion[0];
            A40000SocioFoto_GXI = BC000423_A40000SocioFoto_GXI[0];
            A5SocioId = BC000423_A5SocioId[0];
            A21SocioFoto = BC000423_A21SocioFoto[0];
         }
         Gx_mode = sMode13;
      }

      protected void ScanKeyEnd0413( )
      {
         pr_default.close(21);
      }

      protected void AfterConfirm0413( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0413( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0413( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0413( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0413( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0413( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0413( )
      {
      }

      protected void send_integrity_lvl_hashes0413( )
      {
      }

      protected void send_integrity_lvl_hashes0412( )
      {
      }

      protected void AddRow0412( )
      {
         VarsToRow12( bcClase) ;
      }

      protected void ReadRow0412( )
      {
         RowToVars12( bcClase, 1) ;
      }

      protected void AddRow0413( )
      {
         SdtClase_Socios obj13 ;
         obj13 = new SdtClase_Socios(context);
         VarsToRow13( obj13) ;
         bcClase.gxTpr_Socios.Add(obj13, 0);
         obj13.gxTpr_Mode = "UPD";
         obj13.gxTpr_Modified = 0;
      }

      protected void ReadRow0413( )
      {
         nGXsfl_13_idx = (short)(nGXsfl_13_idx+1);
         RowToVars13( ((SdtClase_Socios)bcClase.gxTpr_Socios.Item(nGXsfl_13_idx)), 1) ;
      }

      protected void InitializeNonKey0412( )
      {
         A1ActividadId = 0;
         A13ActividadDescripcion = "";
         A2ProfesorId = 0;
         A15ProfesorNombre = "";
         Z2ProfesorId = 0;
      }

      protected void InitAll0412( )
      {
         A3ClaseId = new ultimoidclase(context).executeUdp( );
         InitializeNonKey0412( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      protected void InitializeNonKey0413( )
      {
         A20SocioEdad = 0;
         A18SocioDireccion = "";
         A21SocioFoto = "";
         A40000SocioFoto_GXI = "";
      }

      protected void InitAll0413( )
      {
         A5SocioId = 0;
         InitializeNonKey0413( ) ;
      }

      protected void StandaloneModalInsert0413( )
      {
      }

      public void VarsToRow12( SdtClase obj12 )
      {
         obj12.gxTpr_Mode = Gx_mode;
         obj12.gxTpr_Actividadid = A1ActividadId;
         obj12.gxTpr_Actividaddescripcion = A13ActividadDescripcion;
         obj12.gxTpr_Profesorid = A2ProfesorId;
         obj12.gxTpr_Profesornombre = A15ProfesorNombre;
         obj12.gxTpr_Claseid = A3ClaseId;
         obj12.gxTpr_Claseid_Z = Z3ClaseId;
         obj12.gxTpr_Actividadid_Z = Z1ActividadId;
         obj12.gxTpr_Actividaddescripcion_Z = Z13ActividadDescripcion;
         obj12.gxTpr_Profesorid_Z = Z2ProfesorId;
         obj12.gxTpr_Profesornombre_Z = Z15ProfesorNombre;
         obj12.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow12( SdtClase obj12 )
      {
         obj12.gxTpr_Claseid = A3ClaseId;
         return  ;
      }

      public void RowToVars12( SdtClase obj12 ,
                               int forceLoad )
      {
         Gx_mode = obj12.gxTpr_Mode;
         A1ActividadId = obj12.gxTpr_Actividadid;
         A13ActividadDescripcion = obj12.gxTpr_Actividaddescripcion;
         A2ProfesorId = obj12.gxTpr_Profesorid;
         A15ProfesorNombre = obj12.gxTpr_Profesornombre;
         A3ClaseId = obj12.gxTpr_Claseid;
         Z3ClaseId = obj12.gxTpr_Claseid_Z;
         Z1ActividadId = obj12.gxTpr_Actividadid_Z;
         Z13ActividadDescripcion = obj12.gxTpr_Actividaddescripcion_Z;
         Z2ProfesorId = obj12.gxTpr_Profesorid_Z;
         Z15ProfesorNombre = obj12.gxTpr_Profesornombre_Z;
         Gx_mode = obj12.gxTpr_Mode;
         return  ;
      }

      public void VarsToRow13( SdtClase_Socios obj13 )
      {
         obj13.gxTpr_Mode = Gx_mode;
         obj13.gxTpr_Socioedad = A20SocioEdad;
         obj13.gxTpr_Sociodireccion = A18SocioDireccion;
         obj13.gxTpr_Sociofoto = A21SocioFoto;
         obj13.gxTpr_Sociofoto_gxi = A40000SocioFoto_GXI;
         obj13.gxTpr_Socioid = A5SocioId;
         obj13.gxTpr_Socioid_Z = Z5SocioId;
         obj13.gxTpr_Socioedad_Z = Z20SocioEdad;
         obj13.gxTpr_Sociodireccion_Z = Z18SocioDireccion;
         obj13.gxTpr_Sociofoto_gxi_Z = Z40000SocioFoto_GXI;
         obj13.gxTpr_Modified = nIsMod_13;
         return  ;
      }

      public void KeyVarsToRow13( SdtClase_Socios obj13 )
      {
         obj13.gxTpr_Socioid = A5SocioId;
         return  ;
      }

      public void RowToVars13( SdtClase_Socios obj13 ,
                               int forceLoad )
      {
         Gx_mode = obj13.gxTpr_Mode;
         A20SocioEdad = obj13.gxTpr_Socioedad;
         A18SocioDireccion = obj13.gxTpr_Sociodireccion;
         A21SocioFoto = obj13.gxTpr_Sociofoto;
         A40000SocioFoto_GXI = obj13.gxTpr_Sociofoto_gxi;
         A5SocioId = obj13.gxTpr_Socioid;
         Z5SocioId = obj13.gxTpr_Socioid_Z;
         Z20SocioEdad = obj13.gxTpr_Socioedad_Z;
         Z18SocioDireccion = obj13.gxTpr_Sociodireccion_Z;
         Z40000SocioFoto_GXI = obj13.gxTpr_Sociofoto_gxi_Z;
         nIsMod_13 = obj13.gxTpr_Modified;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A3ClaseId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0412( ) ;
         ScanKeyStart0412( ) ;
         if ( RcdFound12 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z3ClaseId = A3ClaseId;
         }
         ZM0412( -2) ;
         OnLoadActions0412( ) ;
         AddRow0412( ) ;
         bcClase.gxTpr_Socios.ClearCollection();
         if ( RcdFound12 == 1 )
         {
            ScanKeyStart0413( ) ;
            nGXsfl_13_idx = 1;
            while ( RcdFound13 != 0 )
            {
               Z3ClaseId = A3ClaseId;
               Z5SocioId = A5SocioId;
               ZM0413( -5) ;
               OnLoadActions0413( ) ;
               nRcdExists_13 = 1;
               nIsMod_13 = 0;
               AddRow0413( ) ;
               nGXsfl_13_idx = (short)(nGXsfl_13_idx+1);
               ScanKeyNext0413( ) ;
            }
            ScanKeyEnd0413( ) ;
         }
         ScanKeyEnd0412( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      public void Load( )
      {
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         RowToVars12( bcClase, 0) ;
         ScanKeyStart0412( ) ;
         if ( RcdFound12 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z3ClaseId = A3ClaseId;
         }
         ZM0412( -2) ;
         OnLoadActions0412( ) ;
         AddRow0412( ) ;
         bcClase.gxTpr_Socios.ClearCollection();
         if ( RcdFound12 == 1 )
         {
            ScanKeyStart0413( ) ;
            nGXsfl_13_idx = 1;
            while ( RcdFound13 != 0 )
            {
               Z3ClaseId = A3ClaseId;
               Z5SocioId = A5SocioId;
               ZM0413( -5) ;
               OnLoadActions0413( ) ;
               nRcdExists_13 = 1;
               nIsMod_13 = 0;
               AddRow0413( ) ;
               nGXsfl_13_idx = (short)(nGXsfl_13_idx+1);
               ScanKeyNext0413( ) ;
            }
            ScanKeyEnd0413( ) ;
         }
         ScanKeyEnd0412( ) ;
         if ( RcdFound12 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0412( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0412( ) ;
         }
         else
         {
            if ( RcdFound12 == 1 )
            {
               if ( A3ClaseId != Z3ClaseId )
               {
                  A3ClaseId = Z3ClaseId;
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  delete( ) ;
                  AfterTrn( ) ;
               }
               else
               {
                  Gx_mode = "UPD";
                  /* Update record */
                  Update0412( ) ;
               }
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "CandidateKeyNotFound", 1, "");
                  AnyError = 1;
               }
               else
               {
                  if ( A3ClaseId != Z3ClaseId )
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0412( ) ;
                     }
                  }
                  else
                  {
                     if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                        AnyError = 1;
                     }
                     else
                     {
                        Gx_mode = "INS";
                        /* Insert record */
                        Insert0412( ) ;
                     }
                  }
               }
            }
         }
         AfterTrn( ) ;
      }

      public void Save( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars12( bcClase, 0) ;
         SaveImpl( ) ;
         VarsToRow12( bcClase) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public bool Insert( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars12( bcClase, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0412( ) ;
         AfterTrn( ) ;
         VarsToRow12( bcClase) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      protected void UpdateImpl( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
         {
            SaveImpl( ) ;
         }
         else
         {
            SdtClase auxBC = new SdtClase(context) ;
            auxBC.Load(A3ClaseId);
            auxBC.UpdateDirties(bcClase);
            auxBC.Save();
            IGxSilentTrn auxTrn = auxBC.getTransaction() ;
            LclMsgLst = (msglist)(auxTrn.GetMessages());
            AnyError = (short)(auxTrn.Errors());
            Gx_mode = auxTrn.GetMode();
            context.GX_msglist = LclMsgLst;
            AfterTrn( ) ;
         }
      }

      public bool Update( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars12( bcClase, 0) ;
         UpdateImpl( ) ;
         VarsToRow12( bcClase) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public bool InsertOrUpdate( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         IsConfirmed = 1;
         RowToVars12( bcClase, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0412( ) ;
         if ( AnyError == 1 )
         {
            AnyError = 0;
            context.GX_msglist.removeAllItems();
            UpdateImpl( ) ;
         }
         else
         {
            AfterTrn( ) ;
         }
         VarsToRow12( bcClase) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars12( bcClase, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0412( ) ;
         if ( RcdFound12 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A3ClaseId != Z3ClaseId )
            {
               A3ClaseId = Z3ClaseId;
               GX_msglist.addItem(context.GetMessage( "GXM_getbeforeupd", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               delete_Check( ) ;
            }
            else
            {
               Gx_mode = "UPD";
               update_Check( ) ;
            }
         }
         else
         {
            if ( A3ClaseId != Z3ClaseId )
            {
               Gx_mode = "INS";
               insert_Check( ) ;
            }
            else
            {
               if ( StringUtil.StrCmp(Gx_mode, "UPD") == 0 )
               {
                  GX_msglist.addItem(context.GetMessage( "GXM_recdeleted", ""), 1, "");
                  AnyError = 1;
               }
               else
               {
                  Gx_mode = "INS";
                  insert_Check( ) ;
               }
            }
         }
         pr_default.close(4);
         pr_default.close(1);
         pr_default.close(13);
         pr_default.close(14);
         pr_default.close(20);
         context.RollbackDataStores("clase_bc",pr_default);
         VarsToRow12( bcClase) ;
         context.GX_msglist = BackMsgLst;
         return  ;
      }

      public int Errors( )
      {
         if ( AnyError == 0 )
         {
            return (int)(0) ;
         }
         return (int)(1) ;
      }

      public msglist GetMessages( )
      {
         return LclMsgLst ;
      }

      public String GetMode( )
      {
         Gx_mode = bcClase.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcClase.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcClase )
         {
            bcClase = (SdtClase)(sdt);
            if ( StringUtil.StrCmp(bcClase.gxTpr_Mode, "") == 0 )
            {
               bcClase.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow12( bcClase) ;
            }
            else
            {
               RowToVars12( bcClase, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcClase.gxTpr_Mode, "") == 0 )
            {
               bcClase.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars12( bcClase, 1) ;
         return  ;
      }

      public SdtClase Clase_BC
      {
         get {
            return bcClase ;
         }

      }

      public override void webExecute( )
      {
         createObjects();
         initialize();
      }

      protected override void createObjects( )
      {
      }

      protected void Process( )
      {
      }

      public override void cleanup( )
      {
         flushBuffer();
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
         pr_default.close(1);
         pr_default.close(20);
         pr_default.close(4);
         pr_default.close(13);
         pr_default.close(14);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00049_A3ClaseId = new short[1] ;
         BC00049_A13ActividadDescripcion = new String[] {""} ;
         BC00049_A15ProfesorNombre = new String[] {""} ;
         BC00049_A2ProfesorId = new short[1] ;
         BC00049_A1ActividadId = new short[1] ;
         A13ActividadDescripcion = "";
         A15ProfesorNombre = "";
         gx_restcollection = new GXBCCollection<SdtClase>( context, "Clase", "ObligatorioGenexusGit");
         sMode12 = "";
         Gx_mode = "";
         Z15ProfesorNombre = "";
         Z13ActividadDescripcion = "";
         BC000410_A3ClaseId = new short[1] ;
         BC000410_A13ActividadDescripcion = new String[] {""} ;
         BC000410_A15ProfesorNombre = new String[] {""} ;
         BC000410_A2ProfesorId = new short[1] ;
         BC000410_A1ActividadId = new short[1] ;
         BC00047_A15ProfesorNombre = new String[] {""} ;
         BC00047_A1ActividadId = new short[1] ;
         BC00048_A13ActividadDescripcion = new String[] {""} ;
         BC000411_A3ClaseId = new short[1] ;
         BC00046_A3ClaseId = new short[1] ;
         BC00046_A2ProfesorId = new short[1] ;
         BC00045_A3ClaseId = new short[1] ;
         BC00045_A2ProfesorId = new short[1] ;
         BC000415_A15ProfesorNombre = new String[] {""} ;
         BC000415_A1ActividadId = new short[1] ;
         BC000416_A13ActividadDescripcion = new String[] {""} ;
         BC000417_A3ClaseId = new short[1] ;
         BC000417_A13ActividadDescripcion = new String[] {""} ;
         BC000417_A15ProfesorNombre = new String[] {""} ;
         BC000417_A2ProfesorId = new short[1] ;
         BC000417_A1ActividadId = new short[1] ;
         Z18SocioDireccion = "";
         A18SocioDireccion = "";
         Z21SocioFoto = "";
         A21SocioFoto = "";
         Z40000SocioFoto_GXI = "";
         A40000SocioFoto_GXI = "";
         BC000418_A3ClaseId = new short[1] ;
         BC000418_A20SocioEdad = new short[1] ;
         BC000418_A18SocioDireccion = new String[] {""} ;
         BC000418_A40000SocioFoto_GXI = new String[] {""} ;
         BC000418_A5SocioId = new short[1] ;
         BC000418_A21SocioFoto = new String[] {""} ;
         BC00044_A20SocioEdad = new short[1] ;
         BC00044_A18SocioDireccion = new String[] {""} ;
         BC00044_A40000SocioFoto_GXI = new String[] {""} ;
         BC00044_A21SocioFoto = new String[] {""} ;
         BC000419_A3ClaseId = new short[1] ;
         BC000419_A5SocioId = new short[1] ;
         BC00043_A3ClaseId = new short[1] ;
         BC00043_A5SocioId = new short[1] ;
         sMode13 = "";
         BC00042_A3ClaseId = new short[1] ;
         BC00042_A5SocioId = new short[1] ;
         BC000422_A20SocioEdad = new short[1] ;
         BC000422_A18SocioDireccion = new String[] {""} ;
         BC000422_A40000SocioFoto_GXI = new String[] {""} ;
         BC000422_A21SocioFoto = new String[] {""} ;
         BC000423_A3ClaseId = new short[1] ;
         BC000423_A20SocioEdad = new short[1] ;
         BC000423_A18SocioDireccion = new String[] {""} ;
         BC000423_A40000SocioFoto_GXI = new String[] {""} ;
         BC000423_A5SocioId = new short[1] ;
         BC000423_A21SocioFoto = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.clase_bc__default(),
            new Object[][] {
                new Object[] {
               BC00042_A3ClaseId, BC00042_A5SocioId
               }
               , new Object[] {
               BC00043_A3ClaseId, BC00043_A5SocioId
               }
               , new Object[] {
               BC00044_A20SocioEdad, BC00044_A18SocioDireccion, BC00044_A40000SocioFoto_GXI, BC00044_A21SocioFoto
               }
               , new Object[] {
               BC00045_A3ClaseId, BC00045_A2ProfesorId
               }
               , new Object[] {
               BC00046_A3ClaseId, BC00046_A2ProfesorId
               }
               , new Object[] {
               BC00047_A15ProfesorNombre, BC00047_A1ActividadId
               }
               , new Object[] {
               BC00048_A13ActividadDescripcion
               }
               , new Object[] {
               BC00049_A3ClaseId, BC00049_A13ActividadDescripcion, BC00049_A15ProfesorNombre, BC00049_A2ProfesorId, BC00049_A1ActividadId
               }
               , new Object[] {
               BC000410_A3ClaseId, BC000410_A13ActividadDescripcion, BC000410_A15ProfesorNombre, BC000410_A2ProfesorId, BC000410_A1ActividadId
               }
               , new Object[] {
               BC000411_A3ClaseId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000415_A15ProfesorNombre, BC000415_A1ActividadId
               }
               , new Object[] {
               BC000416_A13ActividadDescripcion
               }
               , new Object[] {
               BC000417_A3ClaseId, BC000417_A13ActividadDescripcion, BC000417_A15ProfesorNombre, BC000417_A2ProfesorId, BC000417_A1ActividadId
               }
               , new Object[] {
               BC000418_A3ClaseId, BC000418_A20SocioEdad, BC000418_A18SocioDireccion, BC000418_A40000SocioFoto_GXI, BC000418_A5SocioId, BC000418_A21SocioFoto
               }
               , new Object[] {
               BC000419_A3ClaseId, BC000419_A5SocioId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000422_A20SocioEdad, BC000422_A18SocioDireccion, BC000422_A40000SocioFoto_GXI, BC000422_A21SocioFoto
               }
               , new Object[] {
               BC000423_A3ClaseId, BC000423_A20SocioEdad, BC000423_A18SocioDireccion, BC000423_A40000SocioFoto_GXI, BC000423_A5SocioId, BC000423_A21SocioFoto
               }
            }
         );
         A3ClaseId = new ultimoidclase(context).executeUdp( );
         Z3ClaseId = new ultimoidclase(context).executeUdp( );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12042 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound12 ;
      private short A3ClaseId ;
      private short A2ProfesorId ;
      private short A1ActividadId ;
      private short Z3ClaseId ;
      private short nGXsfl_13_idx=1 ;
      private short nIsMod_13 ;
      private short RcdFound13 ;
      private short GX_JID ;
      private short Z2ProfesorId ;
      private short Z1ActividadId ;
      private short Gx_BScreen ;
      private short GXt_int1 ;
      private short nRcdExists_13 ;
      private short Gxremove13 ;
      private short Z20SocioEdad ;
      private short A20SocioEdad ;
      private short Z5SocioId ;
      private short A5SocioId ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom12 ;
      private int GXPagingTo12 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String A13ActividadDescripcion ;
      private String A15ProfesorNombre ;
      private String sMode12 ;
      private String Gx_mode ;
      private String Z15ProfesorNombre ;
      private String Z13ActividadDescripcion ;
      private String sMode13 ;
      private String Z18SocioDireccion ;
      private String A18SocioDireccion ;
      private String Z40000SocioFoto_GXI ;
      private String A40000SocioFoto_GXI ;
      private String Z21SocioFoto ;
      private String A21SocioFoto ;
      private GXBCCollection<SdtClase> gx_restcollection ;
      private SdtClase bcClase ;
      private SdtClase gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00049_A3ClaseId ;
      private String[] BC00049_A13ActividadDescripcion ;
      private String[] BC00049_A15ProfesorNombre ;
      private short[] BC00049_A2ProfesorId ;
      private short[] BC00049_A1ActividadId ;
      private short[] BC000410_A3ClaseId ;
      private String[] BC000410_A13ActividadDescripcion ;
      private String[] BC000410_A15ProfesorNombre ;
      private short[] BC000410_A2ProfesorId ;
      private short[] BC000410_A1ActividadId ;
      private String[] BC00047_A15ProfesorNombre ;
      private short[] BC00047_A1ActividadId ;
      private String[] BC00048_A13ActividadDescripcion ;
      private short[] BC000411_A3ClaseId ;
      private short[] BC00046_A3ClaseId ;
      private short[] BC00046_A2ProfesorId ;
      private short[] BC00045_A3ClaseId ;
      private short[] BC00045_A2ProfesorId ;
      private String[] BC000415_A15ProfesorNombre ;
      private short[] BC000415_A1ActividadId ;
      private String[] BC000416_A13ActividadDescripcion ;
      private short[] BC000417_A3ClaseId ;
      private String[] BC000417_A13ActividadDescripcion ;
      private String[] BC000417_A15ProfesorNombre ;
      private short[] BC000417_A2ProfesorId ;
      private short[] BC000417_A1ActividadId ;
      private short[] BC000418_A3ClaseId ;
      private short[] BC000418_A20SocioEdad ;
      private String[] BC000418_A18SocioDireccion ;
      private String[] BC000418_A40000SocioFoto_GXI ;
      private short[] BC000418_A5SocioId ;
      private String[] BC000418_A21SocioFoto ;
      private short[] BC00044_A20SocioEdad ;
      private String[] BC00044_A18SocioDireccion ;
      private String[] BC00044_A40000SocioFoto_GXI ;
      private String[] BC00044_A21SocioFoto ;
      private short[] BC000419_A3ClaseId ;
      private short[] BC000419_A5SocioId ;
      private short[] BC00043_A3ClaseId ;
      private short[] BC00043_A5SocioId ;
      private short[] BC00042_A3ClaseId ;
      private short[] BC00042_A5SocioId ;
      private short[] BC000422_A20SocioEdad ;
      private String[] BC000422_A18SocioDireccion ;
      private String[] BC000422_A40000SocioFoto_GXI ;
      private String[] BC000422_A21SocioFoto ;
      private short[] BC000423_A3ClaseId ;
      private short[] BC000423_A20SocioEdad ;
      private String[] BC000423_A18SocioDireccion ;
      private String[] BC000423_A40000SocioFoto_GXI ;
      private short[] BC000423_A5SocioId ;
      private String[] BC000423_A21SocioFoto ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class clase_bc__default : DataStoreHelperBase, IDataStoreHelper
   {
      public ICursor[] getCursors( )
      {
         cursorDefinitions();
         return new Cursor[] {
          new ForEachCursor(def[0])
         ,new ForEachCursor(def[1])
         ,new ForEachCursor(def[2])
         ,new ForEachCursor(def[3])
         ,new ForEachCursor(def[4])
         ,new ForEachCursor(def[5])
         ,new ForEachCursor(def[6])
         ,new ForEachCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
         ,new UpdateCursor(def[10])
         ,new UpdateCursor(def[11])
         ,new UpdateCursor(def[12])
         ,new ForEachCursor(def[13])
         ,new ForEachCursor(def[14])
         ,new ForEachCursor(def[15])
         ,new ForEachCursor(def[16])
         ,new ForEachCursor(def[17])
         ,new UpdateCursor(def[18])
         ,new UpdateCursor(def[19])
         ,new ForEachCursor(def[20])
         ,new ForEachCursor(def[21])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00049 ;
          prmBC00049 = new Object[] {
          new Object[] {"@GXPagingFrom12",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo12",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC000410 ;
          prmBC000410 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00047 ;
          prmBC00047 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00048 ;
          prmBC00048 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000411 ;
          prmBC000411 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00046 ;
          prmBC00046 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00045 ;
          prmBC00045 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000412 ;
          prmBC000412 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000413 ;
          prmBC000413 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000414 ;
          prmBC000414 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000415 ;
          prmBC000415 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000416 ;
          prmBC000416 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000417 ;
          prmBC000417 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000418 ;
          prmBC000418 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00044 ;
          prmBC00044 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000419 ;
          prmBC000419 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00043 ;
          prmBC00043 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00042 ;
          prmBC00042 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000420 ;
          prmBC000420 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000421 ;
          prmBC000421 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000422 ;
          prmBC000422 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000423 ;
          prmBC000423 = new Object[] {
          new Object[] {"@ClaseId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00042", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (UPDLOCK) WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00042,1,0,true,false )
             ,new CursorDef("BC00043", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00043,1,0,true,false )
             ,new CursorDef("BC00044", "SELECT [SocioEdad], [SocioDireccion], [SocioFoto_GXI], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00044,1,0,true,false )
             ,new CursorDef("BC00045", "SELECT [ClaseId], [ProfesorId] FROM [Clase] WITH (UPDLOCK) WHERE [ClaseId] = @ClaseId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00045,1,0,true,false )
             ,new CursorDef("BC00046", "SELECT [ClaseId], [ProfesorId] FROM [Clase] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00046,1,0,true,false )
             ,new CursorDef("BC00047", "SELECT [ProfesorNombre], [ActividadId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00047,1,0,true,false )
             ,new CursorDef("BC00048", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00048,1,0,true,false )
             ,new CursorDef("BC00049", "SELECT TM1.[ClaseId], T3.[ActividadDescripcion], T2.[ProfesorNombre], TM1.[ProfesorId], T2.[ActividadId] FROM (([Clase] TM1 WITH (NOLOCK) INNER JOIN [Profesor] T2 WITH (NOLOCK) ON T2.[ProfesorId] = TM1.[ProfesorId]) INNER JOIN [Actividad1] T3 WITH (NOLOCK) ON T3.[ActividadId] = T2.[ActividadId]) ORDER BY TM1.[ClaseId]  OFFSET @GXPagingFrom12 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo12 > 0 THEN @GXPagingTo12 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00049,100,0,true,false )
             ,new CursorDef("BC000410", "SELECT TM1.[ClaseId], T3.[ActividadDescripcion], T2.[ProfesorNombre], TM1.[ProfesorId], T2.[ActividadId] FROM (([Clase] TM1 WITH (NOLOCK) INNER JOIN [Profesor] T2 WITH (NOLOCK) ON T2.[ProfesorId] = TM1.[ProfesorId]) INNER JOIN [Actividad1] T3 WITH (NOLOCK) ON T3.[ActividadId] = T2.[ActividadId]) WHERE TM1.[ClaseId] = @ClaseId ORDER BY TM1.[ClaseId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000410,100,0,true,false )
             ,new CursorDef("BC000411", "SELECT [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000411,1,0,true,false )
             ,new CursorDef("BC000412", "INSERT INTO [Clase]([ClaseId], [ProfesorId]) VALUES(@ClaseId, @ProfesorId)", GxErrorMask.GX_NOMASK,prmBC000412)
             ,new CursorDef("BC000413", "UPDATE [Clase] SET [ProfesorId]=@ProfesorId  WHERE [ClaseId] = @ClaseId", GxErrorMask.GX_NOMASK,prmBC000413)
             ,new CursorDef("BC000414", "DELETE FROM [Clase]  WHERE [ClaseId] = @ClaseId", GxErrorMask.GX_NOMASK,prmBC000414)
             ,new CursorDef("BC000415", "SELECT [ProfesorNombre], [ActividadId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000415,1,0,true,false )
             ,new CursorDef("BC000416", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000416,1,0,true,false )
             ,new CursorDef("BC000417", "SELECT TM1.[ClaseId], T3.[ActividadDescripcion], T2.[ProfesorNombre], TM1.[ProfesorId], T2.[ActividadId] FROM (([Clase] TM1 WITH (NOLOCK) INNER JOIN [Profesor] T2 WITH (NOLOCK) ON T2.[ProfesorId] = TM1.[ProfesorId]) INNER JOIN [Actividad1] T3 WITH (NOLOCK) ON T3.[ActividadId] = T2.[ActividadId]) WHERE TM1.[ClaseId] = @ClaseId ORDER BY TM1.[ClaseId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000417,100,0,true,false )
             ,new CursorDef("BC000418", "SELECT T1.[ClaseId], T2.[SocioEdad], T2.[SocioDireccion], T2.[SocioFoto_GXI], T1.[SocioId], T2.[SocioFoto] FROM ([ClaseSocios] T1 WITH (NOLOCK) INNER JOIN [Socio] T2 WITH (NOLOCK) ON T2.[SocioId] = T1.[SocioId]) WHERE T1.[ClaseId] = @ClaseId and T1.[SocioId] = @SocioId ORDER BY T1.[ClaseId], T1.[SocioId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000418,11,0,true,false )
             ,new CursorDef("BC000419", "SELECT [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000419,1,0,true,false )
             ,new CursorDef("BC000420", "INSERT INTO [ClaseSocios]([ClaseId], [SocioId]) VALUES(@ClaseId, @SocioId)", GxErrorMask.GX_NOMASK,prmBC000420)
             ,new CursorDef("BC000421", "DELETE FROM [ClaseSocios]  WHERE [ClaseId] = @ClaseId AND [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmBC000421)
             ,new CursorDef("BC000422", "SELECT [SocioEdad], [SocioDireccion], [SocioFoto_GXI], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000422,1,0,true,false )
             ,new CursorDef("BC000423", "SELECT T1.[ClaseId], T2.[SocioEdad], T2.[SocioDireccion], T2.[SocioFoto_GXI], T1.[SocioId], T2.[SocioFoto] FROM ([ClaseSocios] T1 WITH (NOLOCK) INNER JOIN [Socio] T2 WITH (NOLOCK) ON T2.[SocioId] = T1.[SocioId]) WHERE T1.[ClaseId] = @ClaseId ORDER BY T1.[ClaseId], T1.[SocioId]  OPTION (FAST 11)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000423,11,0,true,false )
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
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 5 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 6 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 7 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 13 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 14 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 15 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                return;
             case 16 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
             case 17 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 20 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getMultimediaUri(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaFile(4, rslt.getVarchar(3)) ;
                return;
             case 21 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
       }
    }

    public void setParameters( int cursor ,
                               IFieldSetter stmt ,
                               Object[] parms )
    {
       switch ( cursor )
       {
             case 0 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 7 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 13 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 14 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 15 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 16 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 17 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 18 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 19 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 20 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 21 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.clase_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class clase_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA3ClaseId}")]
    public SdtClase_RESTInterface Load( string sA3ClaseId )
    {
       try
       {
          short A3ClaseId ;
          A3ClaseId = (short)(NumberUtil.Val( (String)(sA3ClaseId), "."));
          SdtClase worker = new SdtClase(context) ;
          SdtClase_RESTInterface worker_interface = new SdtClase_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA3ClaseId, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction() ;
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A3ClaseId);
          }
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

    [OperationContract]
    [WebInvoke(Method =  "DELETE" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA3ClaseId}")]
    public SdtClase_RESTInterface Delete( string sA3ClaseId )
    {
       try
       {
          short A3ClaseId ;
          A3ClaseId = (short)(NumberUtil.Val( (String)(sA3ClaseId), "."));
          SdtClase worker = new SdtClase(context) ;
          SdtClase_RESTInterface worker_interface = new SdtClase_RESTInterface (worker);
          worker.Load(A3ClaseId);
          worker.Delete();
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             (( GXHttpHandler )worker.trn).context.CommitDataStores();
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

    [OperationContract]
    [WebInvoke(Method =  "POST" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA3ClaseId}")]
    public SdtClase_RESTInterface Insert( string sA3ClaseId ,
                                          SdtClase_RESTInterface entity )
    {
       try
       {
          short A3ClaseId ;
          A3ClaseId = (short)(NumberUtil.Val( (String)(sA3ClaseId), "."));
          SdtClase worker = new SdtClase(context) ;
          bool gxcheck = RestParameter("check", "true") ;
          bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
          SdtClase_RESTInterface worker_interface = new SdtClase_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Claseid = A3ClaseId;
          if ( gxcheck )
          {
             worker.Check();
          }
          else
          {
             if ( gxinsertorupdate )
             {
                worker.InsertOrUpdate();
             }
             else
             {
                worker.Save();
             }
          }
          ((GXHttpHandler)worker.trn).IsMain = true ;
          if ( worker.Success() )
          {
             if ( ! gxcheck )
             {
                (( GXHttpHandler )worker.trn).context.CommitDataStores();
                SetStatusCode(System.Net.HttpStatusCode.Created);
             }
             SetMessages(worker.trn.GetMessages());
             worker.trn.cleanup( );
             return worker_interface ;
          }
          else
          {
             worker.trn.cleanup( );
             ErrorCheck(worker.trn);
             return null ;
          }
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

    [OperationContract]
    [WebInvoke(Method =  "PUT" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA3ClaseId}")]
    public SdtClase_RESTInterface Update( string sA3ClaseId ,
                                          SdtClase_RESTInterface entity )
    {
       try
       {
          short A3ClaseId ;
          A3ClaseId = (short)(NumberUtil.Val( (String)(sA3ClaseId), "."));
          SdtClase worker = new SdtClase(context) ;
          SdtClase_RESTInterface worker_interface = new SdtClase_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true") ;
          worker.Load(A3ClaseId);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Claseid = A3ClaseId;
             if ( gxcheck )
             {
                worker.Check();
             }
             else
             {
                worker.Save();
             }
             ((GXHttpHandler)worker.trn).IsMain = true ;
             if ( worker.Success() )
             {
                if ( ! gxcheck )
                {
                   (( GXHttpHandler )worker.trn).context.CommitDataStores();
                }
                SetMessages(worker.trn.GetMessages());
                worker.trn.cleanup( );
                worker_interface.Hash = null;
                return worker_interface ;
             }
             else
             {
                worker.trn.cleanup( );
                ErrorCheck(worker.trn);
                return null ;
             }
          }
          else
          {
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Clase"}) );
          }
       }
       catch ( Exception e )
       {
          WebException(e);
       }
       finally
       {
          Cleanup();
       }
       return null ;
    }

 }

}
