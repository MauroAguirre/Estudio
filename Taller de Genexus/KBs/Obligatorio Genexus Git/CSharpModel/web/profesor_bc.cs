/*
               File: Profesor_BC
        Description: Profesor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:43.33
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
   public class profesor_bc : GXHttpHandler, IGxSilentTrn
   {
      public profesor_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public profesor_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtProfesor> GetAll( int Start ,
                                                 int Count )
      {
         GXPagingFrom11 = Start;
         GXPagingTo11 = Count;
         /* Using cursor BC00025 */
         pr_default.execute(3, new Object[] {GXPagingFrom11, GXPagingTo11});
         RcdFound11 = 0;
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound11 = 1;
            A2ProfesorId = BC00025_A2ProfesorId[0];
            A15ProfesorNombre = BC00025_A15ProfesorNombre[0];
            A16ProfesorDireccion = BC00025_A16ProfesorDireccion[0];
            A40000ProfesorFoto_GXI = BC00025_A40000ProfesorFoto_GXI[0];
            A13ActividadDescripcion = BC00025_A13ActividadDescripcion[0];
            A1ActividadId = BC00025_A1ActividadId[0];
            A17ProfesorFoto = BC00025_A17ProfesorFoto[0];
         }
         bcProfesor = new SdtProfesor(context);
         gx_restcollection.Clear();
         while ( RcdFound11 != 0 )
         {
            OnLoadActions0211( ) ;
            AddRow0211( ) ;
            gx_sdt_item = (SdtProfesor)(bcProfesor.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(3);
            RcdFound11 = 0;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(3) != 101) )
            {
               RcdFound11 = 1;
               A2ProfesorId = BC00025_A2ProfesorId[0];
               A15ProfesorNombre = BC00025_A15ProfesorNombre[0];
               A16ProfesorDireccion = BC00025_A16ProfesorDireccion[0];
               A40000ProfesorFoto_GXI = BC00025_A40000ProfesorFoto_GXI[0];
               A13ActividadDescripcion = BC00025_A13ActividadDescripcion[0];
               A1ActividadId = BC00025_A1ActividadId[0];
               A17ProfesorFoto = BC00025_A17ProfesorFoto[0];
            }
            Gx_mode = sMode11;
         }
         pr_default.close(3);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM0211( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow0211( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0211( ) ;
         standaloneModal( ) ;
         AddRow0211( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11022 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z2ProfesorId = A2ProfesorId;
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

      protected void CONFIRM_020( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0211( ) ;
            }
            else
            {
               CheckExtendedTable0211( ) ;
               if ( AnyError == 0 )
               {
                  ZM0211( 3) ;
               }
               CloseExtendedTableCursors0211( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12022( )
      {
         /* Start Routine */
      }

      protected void E11022( )
      {
         /* After Trn Routine */
      }

      protected void ZM0211( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z15ProfesorNombre = A15ProfesorNombre;
            Z16ProfesorDireccion = A16ProfesorDireccion;
            Z1ActividadId = A1ActividadId;
         }
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z13ActividadDescripcion = A13ActividadDescripcion;
         }
         if ( GX_JID == -2 )
         {
            Z2ProfesorId = A2ProfesorId;
            Z15ProfesorNombre = A15ProfesorNombre;
            Z16ProfesorDireccion = A16ProfesorDireccion;
            Z17ProfesorFoto = A17ProfesorFoto;
            Z40000ProfesorFoto_GXI = A40000ProfesorFoto_GXI;
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A2ProfesorId) && ( Gx_BScreen == 0 ) )
         {
            GXt_int1 = A2ProfesorId;
            new ultimoidprofesor(context ).execute( out  GXt_int1) ;
            A2ProfesorId = GXt_int1;
         }
      }

      protected void Load0211( )
      {
         /* Using cursor BC00026 */
         pr_default.execute(4, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound11 = 1;
            A15ProfesorNombre = BC00026_A15ProfesorNombre[0];
            A16ProfesorDireccion = BC00026_A16ProfesorDireccion[0];
            A40000ProfesorFoto_GXI = BC00026_A40000ProfesorFoto_GXI[0];
            A13ActividadDescripcion = BC00026_A13ActividadDescripcion[0];
            A1ActividadId = BC00026_A1ActividadId[0];
            A17ProfesorFoto = BC00026_A17ProfesorFoto[0];
            ZM0211( -2) ;
         }
         pr_default.close(4);
         OnLoadActions0211( ) ;
      }

      protected void OnLoadActions0211( )
      {
      }

      protected void CheckExtendedTable0211( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00024 */
         pr_default.execute(2, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Actividad'.", "ForeignKeyNotFound", 1, "ACTIVIDADID");
            AnyError = 1;
         }
         A13ActividadDescripcion = BC00024_A13ActividadDescripcion[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors0211( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0211( )
      {
         /* Using cursor BC00027 */
         pr_default.execute(5, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound11 = 1;
         }
         else
         {
            RcdFound11 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00023 */
         pr_default.execute(1, new Object[] {A2ProfesorId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0211( 2) ;
            RcdFound11 = 1;
            A2ProfesorId = BC00023_A2ProfesorId[0];
            A15ProfesorNombre = BC00023_A15ProfesorNombre[0];
            A16ProfesorDireccion = BC00023_A16ProfesorDireccion[0];
            A40000ProfesorFoto_GXI = BC00023_A40000ProfesorFoto_GXI[0];
            A1ActividadId = BC00023_A1ActividadId[0];
            A17ProfesorFoto = BC00023_A17ProfesorFoto[0];
            Z2ProfesorId = A2ProfesorId;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0211( ) ;
            if ( AnyError == 1 )
            {
               RcdFound11 = 0;
               InitializeNonKey0211( ) ;
            }
            Gx_mode = sMode11;
         }
         else
         {
            RcdFound11 = 0;
            InitializeNonKey0211( ) ;
            sMode11 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode11;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0211( ) ;
         if ( RcdFound11 == 0 )
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
         CONFIRM_020( ) ;
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

      protected void CheckOptimisticConcurrency0211( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00022 */
            pr_default.execute(0, new Object[] {A2ProfesorId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Profesor"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z15ProfesorNombre, BC00022_A15ProfesorNombre[0]) != 0 ) || ( StringUtil.StrCmp(Z16ProfesorDireccion, BC00022_A16ProfesorDireccion[0]) != 0 ) || ( Z1ActividadId != BC00022_A1ActividadId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Profesor"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0211( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0211( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0211( 0) ;
            CheckOptimisticConcurrency0211( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0211( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0211( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00028 */
                     pr_default.execute(6, new Object[] {A2ProfesorId, A15ProfesorNombre, A16ProfesorDireccion, A17ProfesorFoto, A40000ProfesorFoto_GXI, A1ActividadId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
                     if ( (pr_default.getStatus(6) == 1) )
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
                           GX_msglist.addItem(context.GetMessage( "GXM_sucadded", ""), "SuccessfullyAdded", 0, "", true);
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
               Load0211( ) ;
            }
            EndLevel0211( ) ;
         }
         CloseExtendedTableCursors0211( ) ;
      }

      protected void Update0211( )
      {
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0211( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0211( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0211( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0211( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00029 */
                     pr_default.execute(7, new Object[] {A15ProfesorNombre, A16ProfesorDireccion, A1ActividadId, A2ProfesorId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Profesor"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0211( ) ;
                     if ( AnyError == 0 )
                     {
                        /* Start of After( update) rules */
                        /* End of After( update) rules */
                        if ( AnyError == 0 )
                        {
                           getByPrimaryKey( ) ;
                           GX_msglist.addItem(context.GetMessage( "GXM_sucupdated", ""), "SuccessfullyUpdated", 0, "", true);
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
            EndLevel0211( ) ;
         }
         CloseExtendedTableCursors0211( ) ;
      }

      protected void DeferredUpdate0211( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC000210 */
            pr_default.execute(8, new Object[] {A17ProfesorFoto, A40000ProfesorFoto_GXI, A2ProfesorId});
            pr_default.close(8);
            dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0211( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0211( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0211( ) ;
            AfterConfirm0211( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0211( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000211 */
                  pr_default.execute(9, new Object[] {A2ProfesorId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("Profesor") ;
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
         sMode11 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0211( ) ;
         Gx_mode = sMode11;
      }

      protected void OnDeleteControls0211( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            /* Using cursor BC000212 */
            pr_default.execute(10, new Object[] {A1ActividadId});
            A13ActividadDescripcion = BC000212_A13ActividadDescripcion[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000213 */
            pr_default.execute(11, new Object[] {A2ProfesorId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Clase"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel0211( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0211( ) ;
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

      public void ScanKeyStart0211( )
      {
         /* Scan By routine */
         /* Using cursor BC000214 */
         pr_default.execute(12, new Object[] {A2ProfesorId});
         RcdFound11 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound11 = 1;
            A2ProfesorId = BC000214_A2ProfesorId[0];
            A15ProfesorNombre = BC000214_A15ProfesorNombre[0];
            A16ProfesorDireccion = BC000214_A16ProfesorDireccion[0];
            A40000ProfesorFoto_GXI = BC000214_A40000ProfesorFoto_GXI[0];
            A13ActividadDescripcion = BC000214_A13ActividadDescripcion[0];
            A1ActividadId = BC000214_A1ActividadId[0];
            A17ProfesorFoto = BC000214_A17ProfesorFoto[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0211( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound11 = 0;
         ScanKeyLoad0211( ) ;
      }

      protected void ScanKeyLoad0211( )
      {
         sMode11 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound11 = 1;
            A2ProfesorId = BC000214_A2ProfesorId[0];
            A15ProfesorNombre = BC000214_A15ProfesorNombre[0];
            A16ProfesorDireccion = BC000214_A16ProfesorDireccion[0];
            A40000ProfesorFoto_GXI = BC000214_A40000ProfesorFoto_GXI[0];
            A13ActividadDescripcion = BC000214_A13ActividadDescripcion[0];
            A1ActividadId = BC000214_A1ActividadId[0];
            A17ProfesorFoto = BC000214_A17ProfesorFoto[0];
         }
         Gx_mode = sMode11;
      }

      protected void ScanKeyEnd0211( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm0211( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0211( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0211( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0211( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0211( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0211( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0211( )
      {
      }

      protected void send_integrity_lvl_hashes0211( )
      {
      }

      protected void AddRow0211( )
      {
         VarsToRow11( bcProfesor) ;
      }

      protected void ReadRow0211( )
      {
         RowToVars11( bcProfesor, 1) ;
      }

      protected void InitializeNonKey0211( )
      {
         A15ProfesorNombre = "";
         A16ProfesorDireccion = "";
         A17ProfesorFoto = "";
         A40000ProfesorFoto_GXI = "";
         A1ActividadId = 0;
         A13ActividadDescripcion = "";
         Z15ProfesorNombre = "";
         Z16ProfesorDireccion = "";
         Z1ActividadId = 0;
      }

      protected void InitAll0211( )
      {
         A2ProfesorId = new ultimoidprofesor(context).executeUdp( );
         InitializeNonKey0211( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow11( SdtProfesor obj11 )
      {
         obj11.gxTpr_Mode = Gx_mode;
         obj11.gxTpr_Profesornombre = A15ProfesorNombre;
         obj11.gxTpr_Profesordireccion = A16ProfesorDireccion;
         obj11.gxTpr_Profesorfoto = A17ProfesorFoto;
         obj11.gxTpr_Profesorfoto_gxi = A40000ProfesorFoto_GXI;
         obj11.gxTpr_Actividadid = A1ActividadId;
         obj11.gxTpr_Actividaddescripcion = A13ActividadDescripcion;
         obj11.gxTpr_Profesorid = A2ProfesorId;
         obj11.gxTpr_Profesorid_Z = Z2ProfesorId;
         obj11.gxTpr_Profesornombre_Z = Z15ProfesorNombre;
         obj11.gxTpr_Profesordireccion_Z = Z16ProfesorDireccion;
         obj11.gxTpr_Actividadid_Z = Z1ActividadId;
         obj11.gxTpr_Actividaddescripcion_Z = Z13ActividadDescripcion;
         obj11.gxTpr_Profesorfoto_gxi_Z = Z40000ProfesorFoto_GXI;
         obj11.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow11( SdtProfesor obj11 )
      {
         obj11.gxTpr_Profesorid = A2ProfesorId;
         return  ;
      }

      public void RowToVars11( SdtProfesor obj11 ,
                               int forceLoad )
      {
         Gx_mode = obj11.gxTpr_Mode;
         A15ProfesorNombre = obj11.gxTpr_Profesornombre;
         A16ProfesorDireccion = obj11.gxTpr_Profesordireccion;
         A17ProfesorFoto = obj11.gxTpr_Profesorfoto;
         A40000ProfesorFoto_GXI = obj11.gxTpr_Profesorfoto_gxi;
         A1ActividadId = obj11.gxTpr_Actividadid;
         A13ActividadDescripcion = obj11.gxTpr_Actividaddescripcion;
         A2ProfesorId = obj11.gxTpr_Profesorid;
         Z2ProfesorId = obj11.gxTpr_Profesorid_Z;
         Z15ProfesorNombre = obj11.gxTpr_Profesornombre_Z;
         Z16ProfesorDireccion = obj11.gxTpr_Profesordireccion_Z;
         Z1ActividadId = obj11.gxTpr_Actividadid_Z;
         Z13ActividadDescripcion = obj11.gxTpr_Actividaddescripcion_Z;
         Z40000ProfesorFoto_GXI = obj11.gxTpr_Profesorfoto_gxi_Z;
         Gx_mode = obj11.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A2ProfesorId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0211( ) ;
         ScanKeyStart0211( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z2ProfesorId = A2ProfesorId;
         }
         ZM0211( -2) ;
         OnLoadActions0211( ) ;
         AddRow0211( ) ;
         ScanKeyEnd0211( ) ;
         if ( RcdFound11 == 0 )
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
         RowToVars11( bcProfesor, 0) ;
         ScanKeyStart0211( ) ;
         if ( RcdFound11 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z2ProfesorId = A2ProfesorId;
         }
         ZM0211( -2) ;
         OnLoadActions0211( ) ;
         AddRow0211( ) ;
         ScanKeyEnd0211( ) ;
         if ( RcdFound11 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0211( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0211( ) ;
         }
         else
         {
            if ( RcdFound11 == 1 )
            {
               if ( A2ProfesorId != Z2ProfesorId )
               {
                  A2ProfesorId = Z2ProfesorId;
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
                  Update0211( ) ;
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
                  if ( A2ProfesorId != Z2ProfesorId )
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
                        Insert0211( ) ;
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
                        Insert0211( ) ;
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
         RowToVars11( bcProfesor, 0) ;
         SaveImpl( ) ;
         VarsToRow11( bcProfesor) ;
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
         RowToVars11( bcProfesor, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0211( ) ;
         AfterTrn( ) ;
         VarsToRow11( bcProfesor) ;
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
            SdtProfesor auxBC = new SdtProfesor(context) ;
            auxBC.Load(A2ProfesorId);
            auxBC.UpdateDirties(bcProfesor);
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
         RowToVars11( bcProfesor, 0) ;
         UpdateImpl( ) ;
         VarsToRow11( bcProfesor) ;
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
         RowToVars11( bcProfesor, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0211( ) ;
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
         VarsToRow11( bcProfesor) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars11( bcProfesor, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0211( ) ;
         if ( RcdFound11 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A2ProfesorId != Z2ProfesorId )
            {
               A2ProfesorId = Z2ProfesorId;
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
            if ( A2ProfesorId != Z2ProfesorId )
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
         pr_default.close(1);
         pr_default.close(10);
         context.RollbackDataStores("profesor_bc",pr_default);
         VarsToRow11( bcProfesor) ;
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
         Gx_mode = bcProfesor.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcProfesor.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcProfesor )
         {
            bcProfesor = (SdtProfesor)(sdt);
            if ( StringUtil.StrCmp(bcProfesor.gxTpr_Mode, "") == 0 )
            {
               bcProfesor.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow11( bcProfesor) ;
            }
            else
            {
               RowToVars11( bcProfesor, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcProfesor.gxTpr_Mode, "") == 0 )
            {
               bcProfesor.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars11( bcProfesor, 1) ;
         return  ;
      }

      public SdtProfesor Profesor_BC
      {
         get {
            return bcProfesor ;
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
         pr_default.close(10);
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00025_A2ProfesorId = new short[1] ;
         BC00025_A15ProfesorNombre = new String[] {""} ;
         BC00025_A16ProfesorDireccion = new String[] {""} ;
         BC00025_A40000ProfesorFoto_GXI = new String[] {""} ;
         BC00025_A13ActividadDescripcion = new String[] {""} ;
         BC00025_A1ActividadId = new short[1] ;
         BC00025_A17ProfesorFoto = new String[] {""} ;
         A15ProfesorNombre = "";
         A16ProfesorDireccion = "";
         A40000ProfesorFoto_GXI = "";
         A13ActividadDescripcion = "";
         A17ProfesorFoto = "";
         gx_restcollection = new GXBCCollection<SdtProfesor>( context, "Profesor", "ObligatorioGenexusGit");
         sMode11 = "";
         Gx_mode = "";
         Z15ProfesorNombre = "";
         Z16ProfesorDireccion = "";
         Z13ActividadDescripcion = "";
         Z17ProfesorFoto = "";
         Z40000ProfesorFoto_GXI = "";
         BC00026_A2ProfesorId = new short[1] ;
         BC00026_A15ProfesorNombre = new String[] {""} ;
         BC00026_A16ProfesorDireccion = new String[] {""} ;
         BC00026_A40000ProfesorFoto_GXI = new String[] {""} ;
         BC00026_A13ActividadDescripcion = new String[] {""} ;
         BC00026_A1ActividadId = new short[1] ;
         BC00026_A17ProfesorFoto = new String[] {""} ;
         BC00024_A13ActividadDescripcion = new String[] {""} ;
         BC00027_A2ProfesorId = new short[1] ;
         BC00023_A2ProfesorId = new short[1] ;
         BC00023_A15ProfesorNombre = new String[] {""} ;
         BC00023_A16ProfesorDireccion = new String[] {""} ;
         BC00023_A40000ProfesorFoto_GXI = new String[] {""} ;
         BC00023_A1ActividadId = new short[1] ;
         BC00023_A17ProfesorFoto = new String[] {""} ;
         BC00022_A2ProfesorId = new short[1] ;
         BC00022_A15ProfesorNombre = new String[] {""} ;
         BC00022_A16ProfesorDireccion = new String[] {""} ;
         BC00022_A40000ProfesorFoto_GXI = new String[] {""} ;
         BC00022_A1ActividadId = new short[1] ;
         BC00022_A17ProfesorFoto = new String[] {""} ;
         BC000212_A13ActividadDescripcion = new String[] {""} ;
         BC000213_A3ClaseId = new short[1] ;
         BC000214_A2ProfesorId = new short[1] ;
         BC000214_A15ProfesorNombre = new String[] {""} ;
         BC000214_A16ProfesorDireccion = new String[] {""} ;
         BC000214_A40000ProfesorFoto_GXI = new String[] {""} ;
         BC000214_A13ActividadDescripcion = new String[] {""} ;
         BC000214_A1ActividadId = new short[1] ;
         BC000214_A17ProfesorFoto = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.profesor_bc__default(),
            new Object[][] {
                new Object[] {
               BC00022_A2ProfesorId, BC00022_A15ProfesorNombre, BC00022_A16ProfesorDireccion, BC00022_A40000ProfesorFoto_GXI, BC00022_A1ActividadId, BC00022_A17ProfesorFoto
               }
               , new Object[] {
               BC00023_A2ProfesorId, BC00023_A15ProfesorNombre, BC00023_A16ProfesorDireccion, BC00023_A40000ProfesorFoto_GXI, BC00023_A1ActividadId, BC00023_A17ProfesorFoto
               }
               , new Object[] {
               BC00024_A13ActividadDescripcion
               }
               , new Object[] {
               BC00025_A2ProfesorId, BC00025_A15ProfesorNombre, BC00025_A16ProfesorDireccion, BC00025_A40000ProfesorFoto_GXI, BC00025_A13ActividadDescripcion, BC00025_A1ActividadId, BC00025_A17ProfesorFoto
               }
               , new Object[] {
               BC00026_A2ProfesorId, BC00026_A15ProfesorNombre, BC00026_A16ProfesorDireccion, BC00026_A40000ProfesorFoto_GXI, BC00026_A13ActividadDescripcion, BC00026_A1ActividadId, BC00026_A17ProfesorFoto
               }
               , new Object[] {
               BC00027_A2ProfesorId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000212_A13ActividadDescripcion
               }
               , new Object[] {
               BC000213_A3ClaseId
               }
               , new Object[] {
               BC000214_A2ProfesorId, BC000214_A15ProfesorNombre, BC000214_A16ProfesorDireccion, BC000214_A40000ProfesorFoto_GXI, BC000214_A13ActividadDescripcion, BC000214_A1ActividadId, BC000214_A17ProfesorFoto
               }
            }
         );
         A2ProfesorId = new ultimoidprofesor(context).executeUdp( );
         Z2ProfesorId = new ultimoidprofesor(context).executeUdp( );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12022 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound11 ;
      private short A2ProfesorId ;
      private short A1ActividadId ;
      private short Z2ProfesorId ;
      private short GX_JID ;
      private short Z1ActividadId ;
      private short Gx_BScreen ;
      private short GXt_int1 ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom11 ;
      private int GXPagingTo11 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String A15ProfesorNombre ;
      private String A13ActividadDescripcion ;
      private String sMode11 ;
      private String Gx_mode ;
      private String Z15ProfesorNombre ;
      private String Z13ActividadDescripcion ;
      private String A16ProfesorDireccion ;
      private String A40000ProfesorFoto_GXI ;
      private String Z16ProfesorDireccion ;
      private String Z40000ProfesorFoto_GXI ;
      private String A17ProfesorFoto ;
      private String Z17ProfesorFoto ;
      private GXBCCollection<SdtProfesor> gx_restcollection ;
      private SdtProfesor bcProfesor ;
      private SdtProfesor gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00025_A2ProfesorId ;
      private String[] BC00025_A15ProfesorNombre ;
      private String[] BC00025_A16ProfesorDireccion ;
      private String[] BC00025_A40000ProfesorFoto_GXI ;
      private String[] BC00025_A13ActividadDescripcion ;
      private short[] BC00025_A1ActividadId ;
      private String[] BC00025_A17ProfesorFoto ;
      private short[] BC00026_A2ProfesorId ;
      private String[] BC00026_A15ProfesorNombre ;
      private String[] BC00026_A16ProfesorDireccion ;
      private String[] BC00026_A40000ProfesorFoto_GXI ;
      private String[] BC00026_A13ActividadDescripcion ;
      private short[] BC00026_A1ActividadId ;
      private String[] BC00026_A17ProfesorFoto ;
      private String[] BC00024_A13ActividadDescripcion ;
      private short[] BC00027_A2ProfesorId ;
      private short[] BC00023_A2ProfesorId ;
      private String[] BC00023_A15ProfesorNombre ;
      private String[] BC00023_A16ProfesorDireccion ;
      private String[] BC00023_A40000ProfesorFoto_GXI ;
      private short[] BC00023_A1ActividadId ;
      private String[] BC00023_A17ProfesorFoto ;
      private short[] BC00022_A2ProfesorId ;
      private String[] BC00022_A15ProfesorNombre ;
      private String[] BC00022_A16ProfesorDireccion ;
      private String[] BC00022_A40000ProfesorFoto_GXI ;
      private short[] BC00022_A1ActividadId ;
      private String[] BC00022_A17ProfesorFoto ;
      private String[] BC000212_A13ActividadDescripcion ;
      private short[] BC000213_A3ClaseId ;
      private short[] BC000214_A2ProfesorId ;
      private String[] BC000214_A15ProfesorNombre ;
      private String[] BC000214_A16ProfesorDireccion ;
      private String[] BC000214_A40000ProfesorFoto_GXI ;
      private String[] BC000214_A13ActividadDescripcion ;
      private short[] BC000214_A1ActividadId ;
      private String[] BC000214_A17ProfesorFoto ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class profesor_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new UpdateCursor(def[9])
         ,new ForEachCursor(def[10])
         ,new ForEachCursor(def[11])
         ,new ForEachCursor(def[12])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00025 ;
          prmBC00025 = new Object[] {
          new Object[] {"@GXPagingFrom11",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo11",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00026 ;
          prmBC00026 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00024 ;
          prmBC00024 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00027 ;
          prmBC00027 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00023 ;
          prmBC00023 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00022 ;
          prmBC00022 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00028 ;
          prmBC00028 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProfesorNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@ProfesorDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@ProfesorFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ProfesorFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00029 ;
          prmBC00029 = new Object[] {
          new Object[] {"@ProfesorNombre",SqlDbType.Char,20,0} ,
          new Object[] {"@ProfesorDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000210 ;
          prmBC000210 = new Object[] {
          new Object[] {"@ProfesorFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@ProfesorFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000211 ;
          prmBC000211 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000212 ;
          prmBC000212 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000213 ;
          prmBC000213 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000214 ;
          prmBC000214 = new Object[] {
          new Object[] {"@ProfesorId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00022", "SELECT [ProfesorId], [ProfesorNombre], [ProfesorDireccion], [ProfesorFoto_GXI], [ActividadId], [ProfesorFoto] FROM [Profesor] WITH (UPDLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00022,1,0,true,false )
             ,new CursorDef("BC00023", "SELECT [ProfesorId], [ProfesorNombre], [ProfesorDireccion], [ProfesorFoto_GXI], [ActividadId], [ProfesorFoto] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00023,1,0,true,false )
             ,new CursorDef("BC00024", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00024,1,0,true,false )
             ,new CursorDef("BC00025", "SELECT TM1.[ProfesorId], TM1.[ProfesorNombre], TM1.[ProfesorDireccion], TM1.[ProfesorFoto_GXI], T2.[ActividadDescripcion], TM1.[ActividadId], TM1.[ProfesorFoto] FROM ([Profesor] TM1 WITH (NOLOCK) INNER JOIN [Actividad1] T2 WITH (NOLOCK) ON T2.[ActividadId] = TM1.[ActividadId]) ORDER BY TM1.[ProfesorId]  OFFSET @GXPagingFrom11 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo11 > 0 THEN @GXPagingTo11 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00025,100,0,true,false )
             ,new CursorDef("BC00026", "SELECT TM1.[ProfesorId], TM1.[ProfesorNombre], TM1.[ProfesorDireccion], TM1.[ProfesorFoto_GXI], T2.[ActividadDescripcion], TM1.[ActividadId], TM1.[ProfesorFoto] FROM ([Profesor] TM1 WITH (NOLOCK) INNER JOIN [Actividad1] T2 WITH (NOLOCK) ON T2.[ActividadId] = TM1.[ActividadId]) WHERE TM1.[ProfesorId] = @ProfesorId ORDER BY TM1.[ProfesorId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00026,100,0,true,false )
             ,new CursorDef("BC00027", "SELECT [ProfesorId] FROM [Profesor] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00027,1,0,true,false )
             ,new CursorDef("BC00028", "INSERT INTO [Profesor]([ProfesorId], [ProfesorNombre], [ProfesorDireccion], [ProfesorFoto], [ProfesorFoto_GXI], [ActividadId]) VALUES(@ProfesorId, @ProfesorNombre, @ProfesorDireccion, @ProfesorFoto, @ProfesorFoto_GXI, @ActividadId)", GxErrorMask.GX_NOMASK,prmBC00028)
             ,new CursorDef("BC00029", "UPDATE [Profesor] SET [ProfesorNombre]=@ProfesorNombre, [ProfesorDireccion]=@ProfesorDireccion, [ActividadId]=@ActividadId  WHERE [ProfesorId] = @ProfesorId", GxErrorMask.GX_NOMASK,prmBC00029)
             ,new CursorDef("BC000210", "UPDATE [Profesor] SET [ProfesorFoto]=@ProfesorFoto, [ProfesorFoto_GXI]=@ProfesorFoto_GXI  WHERE [ProfesorId] = @ProfesorId", GxErrorMask.GX_NOMASK,prmBC000210)
             ,new CursorDef("BC000211", "DELETE FROM [Profesor]  WHERE [ProfesorId] = @ProfesorId", GxErrorMask.GX_NOMASK,prmBC000211)
             ,new CursorDef("BC000212", "SELECT [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000212,1,0,true,false )
             ,new CursorDef("BC000213", "SELECT TOP 1 [ClaseId] FROM [Clase] WITH (NOLOCK) WHERE [ProfesorId] = @ProfesorId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000213,1,0,true,true )
             ,new CursorDef("BC000214", "SELECT TM1.[ProfesorId], TM1.[ProfesorNombre], TM1.[ProfesorDireccion], TM1.[ProfesorFoto_GXI], T2.[ActividadDescripcion], TM1.[ActividadId], TM1.[ProfesorFoto] FROM ([Profesor] TM1 WITH (NOLOCK) INNER JOIN [Actividad1] T2 WITH (NOLOCK) ON T2.[ActividadId] = TM1.[ActividadId]) WHERE TM1.[ProfesorId] = @ProfesorId ORDER BY TM1.[ProfesorId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000214,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((short[]) buf[4])[0] = rslt.getShort(5) ;
                ((String[]) buf[5])[0] = rslt.getMultimediaFile(6, rslt.getVarchar(4)) ;
                return;
             case 2 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(4)) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(4)) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((String[]) buf[0])[0] = rslt.getString(1, 20) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                ((String[]) buf[2])[0] = rslt.getVarchar(3) ;
                ((String[]) buf[3])[0] = rslt.getMultimediaUri(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((short[]) buf[5])[0] = rslt.getShort(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaFile(7, rslt.getVarchar(4)) ;
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
                return;
             case 1 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 2 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 3 :
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (String)parms[2]);
                stmt.SetParameterBlob(4, (String)parms[3], false);
                stmt.SetParameterMultimedia(5, (String)parms[4], (String)parms[3], "Profesor", "ProfesorFoto");
                stmt.SetParameter(6, (short)parms[5]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (short)parms[3]);
                return;
             case 8 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Profesor", "ProfesorFoto");
                stmt.SetParameter(3, (short)parms[2]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 10 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 11 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 12 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.profesor_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class profesor_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA2ProfesorId}")]
    public SdtProfesor_RESTInterface Load( string sA2ProfesorId )
    {
       try
       {
          short A2ProfesorId ;
          A2ProfesorId = (short)(NumberUtil.Val( (String)(sA2ProfesorId), "."));
          SdtProfesor worker = new SdtProfesor(context) ;
          SdtProfesor_RESTInterface worker_interface = new SdtProfesor_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA2ProfesorId, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction() ;
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A2ProfesorId);
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
    	UriTemplate = "/{sA2ProfesorId}")]
    public SdtProfesor_RESTInterface Delete( string sA2ProfesorId )
    {
       try
       {
          short A2ProfesorId ;
          A2ProfesorId = (short)(NumberUtil.Val( (String)(sA2ProfesorId), "."));
          SdtProfesor worker = new SdtProfesor(context) ;
          SdtProfesor_RESTInterface worker_interface = new SdtProfesor_RESTInterface (worker);
          worker.Load(A2ProfesorId);
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
    	UriTemplate = "/{sA2ProfesorId}")]
    public SdtProfesor_RESTInterface Insert( string sA2ProfesorId ,
                                             SdtProfesor_RESTInterface entity )
    {
       try
       {
          short A2ProfesorId ;
          A2ProfesorId = (short)(NumberUtil.Val( (String)(sA2ProfesorId), "."));
          SdtProfesor worker = new SdtProfesor(context) ;
          bool gxcheck = RestParameter("check", "true") ;
          bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
          SdtProfesor_RESTInterface worker_interface = new SdtProfesor_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Profesorid = A2ProfesorId;
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
    	UriTemplate = "/{sA2ProfesorId}")]
    public SdtProfesor_RESTInterface Update( string sA2ProfesorId ,
                                             SdtProfesor_RESTInterface entity )
    {
       try
       {
          short A2ProfesorId ;
          A2ProfesorId = (short)(NumberUtil.Val( (String)(sA2ProfesorId), "."));
          SdtProfesor worker = new SdtProfesor(context) ;
          SdtProfesor_RESTInterface worker_interface = new SdtProfesor_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true") ;
          worker.Load(A2ProfesorId);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Profesorid = A2ProfesorId;
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
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Profesor"}) );
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
