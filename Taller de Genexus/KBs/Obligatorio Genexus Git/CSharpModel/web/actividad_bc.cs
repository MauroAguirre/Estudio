/*
               File: Actividad_BC
        Description: Actividad
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:34.26
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
   public class actividad_bc : GXHttpHandler, IGxSilentTrn
   {
      public actividad_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public actividad_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtActividad> GetAll( int Start ,
                                                  int Count )
      {
         GXPagingFrom1 = Start;
         GXPagingTo1 = Count;
         /* Using cursor BC00014 */
         pr_default.execute(2, new Object[] {GXPagingFrom1, GXPagingTo1});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound1 = 1;
            A1ActividadId = BC00014_A1ActividadId[0];
            A13ActividadDescripcion = BC00014_A13ActividadDescripcion[0];
         }
         bcActividad = new SdtActividad(context);
         gx_restcollection.Clear();
         while ( RcdFound1 != 0 )
         {
            OnLoadActions011( ) ;
            AddRow011( ) ;
            gx_sdt_item = (SdtActividad)(bcActividad.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(2);
            RcdFound1 = 0;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(2) != 101) )
            {
               RcdFound1 = 1;
               A1ActividadId = BC00014_A1ActividadId[0];
               A13ActividadDescripcion = BC00014_A13ActividadDescripcion[0];
            }
            Gx_mode = sMode1;
         }
         pr_default.close(2);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM011( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow011( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey011( ) ;
         standaloneModal( ) ;
         AddRow011( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11012 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z1ActividadId = A1ActividadId;
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

      protected void CONFIRM_010( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls011( ) ;
            }
            else
            {
               CheckExtendedTable011( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors011( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12012( )
      {
         /* Start Routine */
      }

      protected void E11012( )
      {
         /* After Trn Routine */
      }

      protected void ZM011( short GX_JID )
      {
         if ( ( GX_JID == 3 ) || ( GX_JID == 0 ) )
         {
            Z13ActividadDescripcion = A13ActividadDescripcion;
            Z35ActividadCantidadProfesores = A35ActividadCantidadProfesores;
         }
         if ( GX_JID == -3 )
         {
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
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A1ActividadId) && ( Gx_BScreen == 0 ) )
         {
            GXt_int1 = A1ActividadId;
            new ultimoidactividad(context ).execute( out  GXt_int1) ;
            A1ActividadId = GXt_int1;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 ) && ( Gx_BScreen == 0 ) )
         {
            GXt_int1 = A35ActividadCantidadProfesores;
            new cantidaddeprofesenactividad(context ).execute(  A1ActividadId, out  GXt_int1) ;
            A35ActividadCantidadProfesores = GXt_int1;
         }
      }

      protected void Load011( )
      {
         /* Using cursor BC00015 */
         pr_default.execute(3, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound1 = 1;
            A13ActividadDescripcion = BC00015_A13ActividadDescripcion[0];
            ZM011( -3) ;
         }
         pr_default.close(3);
         OnLoadActions011( ) ;
      }

      protected void OnLoadActions011( )
      {
         GXt_int1 = A35ActividadCantidadProfesores;
         new cantidaddeprofesenactividad(context ).execute(  A1ActividadId, out  GXt_int1) ;
         A35ActividadCantidadProfesores = GXt_int1;
      }

      protected void CheckExtendedTable011( )
      {
         standaloneModal( ) ;
         GXt_int1 = A35ActividadCantidadProfesores;
         new cantidaddeprofesenactividad(context ).execute(  A1ActividadId, out  GXt_int1) ;
         A35ActividadCantidadProfesores = GXt_int1;
      }

      protected void CloseExtendedTableCursors011( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey011( )
      {
         /* Using cursor BC00016 */
         pr_default.execute(4, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound1 = 1;
         }
         else
         {
            RcdFound1 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00013 */
         pr_default.execute(1, new Object[] {A1ActividadId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM011( 3) ;
            RcdFound1 = 1;
            A1ActividadId = BC00013_A1ActividadId[0];
            A13ActividadDescripcion = BC00013_A13ActividadDescripcion[0];
            Z1ActividadId = A1ActividadId;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load011( ) ;
            if ( AnyError == 1 )
            {
               RcdFound1 = 0;
               InitializeNonKey011( ) ;
            }
            Gx_mode = sMode1;
         }
         else
         {
            RcdFound1 = 0;
            InitializeNonKey011( ) ;
            sMode1 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode1;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey011( ) ;
         if ( RcdFound1 == 0 )
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
         CONFIRM_010( ) ;
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

      protected void CheckOptimisticConcurrency011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00012 */
            pr_default.execute(0, new Object[] {A1ActividadId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Actividad1"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z13ActividadDescripcion, BC00012_A13ActividadDescripcion[0]) != 0 ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Actividad1"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM011( 0) ;
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00017 */
                     pr_default.execute(5, new Object[] {A1ActividadId, A13ActividadDescripcion});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("Actividad1") ;
                     if ( (pr_default.getStatus(5) == 1) )
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
               Load011( ) ;
            }
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void Update011( )
      {
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable011( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm011( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate011( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00018 */
                     pr_default.execute(6, new Object[] {A13ActividadDescripcion, A1ActividadId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Actividad1") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Actividad1"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate011( ) ;
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
            EndLevel011( ) ;
         }
         CloseExtendedTableCursors011( ) ;
      }

      protected void DeferredUpdate011( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate011( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency011( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls011( ) ;
            AfterConfirm011( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete011( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00019 */
                  pr_default.execute(7, new Object[] {A1ActividadId});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("Actividad1") ;
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
         sMode1 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel011( ) ;
         Gx_mode = sMode1;
      }

      protected void OnDeleteControls011( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            GXt_int1 = A35ActividadCantidadProfesores;
            new cantidaddeprofesenactividad(context ).execute(  A1ActividadId, out  GXt_int1) ;
            A35ActividadCantidadProfesores = GXt_int1;
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000110 */
            pr_default.execute(8, new Object[] {A1ActividadId});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Profesor"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel011( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete011( ) ;
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

      public void ScanKeyStart011( )
      {
         /* Scan By routine */
         /* Using cursor BC000111 */
         pr_default.execute(9, new Object[] {A1ActividadId});
         RcdFound1 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound1 = 1;
            A1ActividadId = BC000111_A1ActividadId[0];
            A13ActividadDescripcion = BC000111_A13ActividadDescripcion[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext011( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound1 = 0;
         ScanKeyLoad011( ) ;
      }

      protected void ScanKeyLoad011( )
      {
         sMode1 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound1 = 1;
            A1ActividadId = BC000111_A1ActividadId[0];
            A13ActividadDescripcion = BC000111_A13ActividadDescripcion[0];
         }
         Gx_mode = sMode1;
      }

      protected void ScanKeyEnd011( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm011( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert011( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate011( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete011( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete011( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate011( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes011( )
      {
      }

      protected void send_integrity_lvl_hashes011( )
      {
      }

      protected void AddRow011( )
      {
         VarsToRow1( bcActividad) ;
      }

      protected void ReadRow011( )
      {
         RowToVars1( bcActividad, 1) ;
      }

      protected void InitializeNonKey011( )
      {
         A35ActividadCantidadProfesores = 0;
         A13ActividadDescripcion = "";
         Z13ActividadDescripcion = "";
      }

      protected void InitAll011( )
      {
         A1ActividadId = new ultimoidactividad(context).executeUdp( );
         InitializeNonKey011( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow1( SdtActividad obj1 )
      {
         obj1.gxTpr_Mode = Gx_mode;
         obj1.gxTpr_Actividadcantidadprofesores = A35ActividadCantidadProfesores;
         obj1.gxTpr_Actividaddescripcion = A13ActividadDescripcion;
         obj1.gxTpr_Actividadid = A1ActividadId;
         obj1.gxTpr_Actividadid_Z = Z1ActividadId;
         obj1.gxTpr_Actividaddescripcion_Z = Z13ActividadDescripcion;
         obj1.gxTpr_Actividadcantidadprofesores_Z = Z35ActividadCantidadProfesores;
         obj1.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow1( SdtActividad obj1 )
      {
         obj1.gxTpr_Actividadid = A1ActividadId;
         return  ;
      }

      public void RowToVars1( SdtActividad obj1 ,
                              int forceLoad )
      {
         Gx_mode = obj1.gxTpr_Mode;
         A35ActividadCantidadProfesores = obj1.gxTpr_Actividadcantidadprofesores;
         A13ActividadDescripcion = obj1.gxTpr_Actividaddescripcion;
         A1ActividadId = obj1.gxTpr_Actividadid;
         Z1ActividadId = obj1.gxTpr_Actividadid_Z;
         Z13ActividadDescripcion = obj1.gxTpr_Actividaddescripcion_Z;
         Z35ActividadCantidadProfesores = obj1.gxTpr_Actividadcantidadprofesores_Z;
         Gx_mode = obj1.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A1ActividadId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey011( ) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1ActividadId = A1ActividadId;
         }
         ZM011( -3) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
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
         RowToVars1( bcActividad, 0) ;
         ScanKeyStart011( ) ;
         if ( RcdFound1 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z1ActividadId = A1ActividadId;
         }
         ZM011( -3) ;
         OnLoadActions011( ) ;
         AddRow011( ) ;
         ScanKeyEnd011( ) ;
         if ( RcdFound1 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey011( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert011( ) ;
         }
         else
         {
            if ( RcdFound1 == 1 )
            {
               if ( A1ActividadId != Z1ActividadId )
               {
                  A1ActividadId = Z1ActividadId;
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
                  Update011( ) ;
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
                  if ( A1ActividadId != Z1ActividadId )
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
                        Insert011( ) ;
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
                        Insert011( ) ;
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
         RowToVars1( bcActividad, 0) ;
         SaveImpl( ) ;
         VarsToRow1( bcActividad) ;
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
         RowToVars1( bcActividad, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
         AfterTrn( ) ;
         VarsToRow1( bcActividad) ;
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
            SdtActividad auxBC = new SdtActividad(context) ;
            auxBC.Load(A1ActividadId);
            auxBC.UpdateDirties(bcActividad);
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
         RowToVars1( bcActividad, 0) ;
         UpdateImpl( ) ;
         VarsToRow1( bcActividad) ;
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
         RowToVars1( bcActividad, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert011( ) ;
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
         VarsToRow1( bcActividad) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars1( bcActividad, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey011( ) ;
         if ( RcdFound1 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A1ActividadId != Z1ActividadId )
            {
               A1ActividadId = Z1ActividadId;
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
            if ( A1ActividadId != Z1ActividadId )
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
         context.RollbackDataStores("actividad_bc",pr_default);
         VarsToRow1( bcActividad) ;
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
         Gx_mode = bcActividad.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcActividad.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcActividad )
         {
            bcActividad = (SdtActividad)(sdt);
            if ( StringUtil.StrCmp(bcActividad.gxTpr_Mode, "") == 0 )
            {
               bcActividad.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow1( bcActividad) ;
            }
            else
            {
               RowToVars1( bcActividad, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcActividad.gxTpr_Mode, "") == 0 )
            {
               bcActividad.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars1( bcActividad, 1) ;
         return  ;
      }

      public SdtActividad Actividad_BC
      {
         get {
            return bcActividad ;
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
      }

      public override void initialize( )
      {
         scmdbuf = "";
         PreviousTooltip = "";
         PreviousCaption = "";
         BC00014_A1ActividadId = new short[1] ;
         BC00014_A13ActividadDescripcion = new String[] {""} ;
         A13ActividadDescripcion = "";
         gx_restcollection = new GXBCCollection<SdtActividad>( context, "Actividad", "ObligatorioGenexusGit");
         sMode1 = "";
         Gx_mode = "";
         Z13ActividadDescripcion = "";
         BC00015_A1ActividadId = new short[1] ;
         BC00015_A13ActividadDescripcion = new String[] {""} ;
         BC00016_A1ActividadId = new short[1] ;
         BC00013_A1ActividadId = new short[1] ;
         BC00013_A13ActividadDescripcion = new String[] {""} ;
         BC00012_A1ActividadId = new short[1] ;
         BC00012_A13ActividadDescripcion = new String[] {""} ;
         BC000110_A2ProfesorId = new short[1] ;
         BC000111_A1ActividadId = new short[1] ;
         BC000111_A13ActividadDescripcion = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.actividad_bc__default(),
            new Object[][] {
                new Object[] {
               BC00012_A1ActividadId, BC00012_A13ActividadDescripcion
               }
               , new Object[] {
               BC00013_A1ActividadId, BC00013_A13ActividadDescripcion
               }
               , new Object[] {
               BC00014_A1ActividadId, BC00014_A13ActividadDescripcion
               }
               , new Object[] {
               BC00015_A1ActividadId, BC00015_A13ActividadDescripcion
               }
               , new Object[] {
               BC00016_A1ActividadId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000110_A2ProfesorId
               }
               , new Object[] {
               BC000111_A1ActividadId, BC000111_A13ActividadDescripcion
               }
            }
         );
         A1ActividadId = new ultimoidactividad(context).executeUdp( );
         Z1ActividadId = new ultimoidactividad(context).executeUdp( );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12012 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound1 ;
      private short A1ActividadId ;
      private short Z1ActividadId ;
      private short GX_JID ;
      private short Z35ActividadCantidadProfesores ;
      private short A35ActividadCantidadProfesores ;
      private short Gx_BScreen ;
      private short GXt_int1 ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom1 ;
      private int GXPagingTo1 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String A13ActividadDescripcion ;
      private String sMode1 ;
      private String Gx_mode ;
      private String Z13ActividadDescripcion ;
      private GXBCCollection<SdtActividad> gx_restcollection ;
      private SdtActividad bcActividad ;
      private SdtActividad gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00014_A1ActividadId ;
      private String[] BC00014_A13ActividadDescripcion ;
      private short[] BC00015_A1ActividadId ;
      private String[] BC00015_A13ActividadDescripcion ;
      private short[] BC00016_A1ActividadId ;
      private short[] BC00013_A1ActividadId ;
      private String[] BC00013_A13ActividadDescripcion ;
      private short[] BC00012_A1ActividadId ;
      private String[] BC00012_A13ActividadDescripcion ;
      private short[] BC000110_A2ProfesorId ;
      private short[] BC000111_A1ActividadId ;
      private String[] BC000111_A13ActividadDescripcion ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class actividad_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[5])
         ,new UpdateCursor(def[6])
         ,new UpdateCursor(def[7])
         ,new ForEachCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00014 ;
          prmBC00014 = new Object[] {
          new Object[] {"@GXPagingFrom1",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo1",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00015 ;
          prmBC00015 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00016 ;
          prmBC00016 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00013 ;
          prmBC00013 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00012 ;
          prmBC00012 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00017 ;
          prmBC00017 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@ActividadDescripcion",SqlDbType.Char,20,0}
          } ;
          Object[] prmBC00018 ;
          prmBC00018 = new Object[] {
          new Object[] {"@ActividadDescripcion",SqlDbType.Char,20,0} ,
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00019 ;
          prmBC00019 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000110 ;
          prmBC000110 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000111 ;
          prmBC000111 = new Object[] {
          new Object[] {"@ActividadId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00012", "SELECT [ActividadId], [ActividadDescripcion] FROM [Actividad1] WITH (UPDLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00012,1,0,true,false )
             ,new CursorDef("BC00013", "SELECT [ActividadId], [ActividadDescripcion] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00013,1,0,true,false )
             ,new CursorDef("BC00014", "SELECT TM1.[ActividadId], TM1.[ActividadDescripcion] FROM [Actividad1] TM1 WITH (NOLOCK) ORDER BY TM1.[ActividadId]  OFFSET @GXPagingFrom1 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo1 > 0 THEN @GXPagingTo1 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00014,100,0,true,false )
             ,new CursorDef("BC00015", "SELECT TM1.[ActividadId], TM1.[ActividadDescripcion] FROM [Actividad1] TM1 WITH (NOLOCK) WHERE TM1.[ActividadId] = @ActividadId ORDER BY TM1.[ActividadId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00015,100,0,true,false )
             ,new CursorDef("BC00016", "SELECT [ActividadId] FROM [Actividad1] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00016,1,0,true,false )
             ,new CursorDef("BC00017", "INSERT INTO [Actividad1]([ActividadId], [ActividadDescripcion]) VALUES(@ActividadId, @ActividadDescripcion)", GxErrorMask.GX_NOMASK,prmBC00017)
             ,new CursorDef("BC00018", "UPDATE [Actividad1] SET [ActividadDescripcion]=@ActividadDescripcion  WHERE [ActividadId] = @ActividadId", GxErrorMask.GX_NOMASK,prmBC00018)
             ,new CursorDef("BC00019", "DELETE FROM [Actividad1]  WHERE [ActividadId] = @ActividadId", GxErrorMask.GX_NOMASK,prmBC00019)
             ,new CursorDef("BC000110", "SELECT TOP 1 [ProfesorId] FROM [Profesor] WITH (NOLOCK) WHERE [ActividadId] = @ActividadId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000110,1,0,true,true )
             ,new CursorDef("BC000111", "SELECT TM1.[ActividadId], TM1.[ActividadDescripcion] FROM [Actividad1] TM1 WITH (NOLOCK) WHERE TM1.[ActividadId] = @ActividadId ORDER BY TM1.[ActividadId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000111,100,0,true,false )
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
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getString(2, 20) ;
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
                stmt.SetParameter(1, (int)parms[0]);
                stmt.SetParameter(2, (int)parms[1]);
                return;
             case 3 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 8 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 9 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
       }
    }

 }

 [ServiceContract(Namespace = "GeneXus.Programs.actividad_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class actividad_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA1ActividadId}")]
    public SdtActividad_RESTInterface Load( string sA1ActividadId )
    {
       try
       {
          short A1ActividadId ;
          A1ActividadId = (short)(NumberUtil.Val( (String)(sA1ActividadId), "."));
          SdtActividad worker = new SdtActividad(context) ;
          SdtActividad_RESTInterface worker_interface = new SdtActividad_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA1ActividadId, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction() ;
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A1ActividadId);
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
    	UriTemplate = "/{sA1ActividadId}")]
    public SdtActividad_RESTInterface Delete( string sA1ActividadId )
    {
       try
       {
          short A1ActividadId ;
          A1ActividadId = (short)(NumberUtil.Val( (String)(sA1ActividadId), "."));
          SdtActividad worker = new SdtActividad(context) ;
          SdtActividad_RESTInterface worker_interface = new SdtActividad_RESTInterface (worker);
          worker.Load(A1ActividadId);
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
    	UriTemplate = "/{sA1ActividadId}")]
    public SdtActividad_RESTInterface Insert( string sA1ActividadId ,
                                              SdtActividad_RESTInterface entity )
    {
       try
       {
          short A1ActividadId ;
          A1ActividadId = (short)(NumberUtil.Val( (String)(sA1ActividadId), "."));
          SdtActividad worker = new SdtActividad(context) ;
          bool gxcheck = RestParameter("check", "true") ;
          bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
          SdtActividad_RESTInterface worker_interface = new SdtActividad_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Actividadid = A1ActividadId;
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
    	UriTemplate = "/{sA1ActividadId}")]
    public SdtActividad_RESTInterface Update( string sA1ActividadId ,
                                              SdtActividad_RESTInterface entity )
    {
       try
       {
          short A1ActividadId ;
          A1ActividadId = (short)(NumberUtil.Val( (String)(sA1ActividadId), "."));
          SdtActividad worker = new SdtActividad(context) ;
          SdtActividad_RESTInterface worker_interface = new SdtActividad_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true") ;
          worker.Load(A1ActividadId);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Actividadid = A1ActividadId;
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
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Actividad"}) );
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
