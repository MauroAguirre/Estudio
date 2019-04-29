/*
               File: Carnet_BC
        Description: Carnet
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:30.77
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
   public class carnet_bc : GXHttpHandler, IGxSilentTrn
   {
      public carnet_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public carnet_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtCarnet> GetAll( int Start ,
                                               int Count )
      {
         GXPagingFrom14 = Start;
         GXPagingTo14 = Count;
         /* Using cursor BC00034 */
         pr_default.execute(2, new Object[] {GXPagingFrom14, GXPagingTo14});
         RcdFound14 = 0;
         if ( (pr_default.getStatus(2) != 101) )
         {
            RcdFound14 = 1;
            A36CarnetId = BC00034_A36CarnetId[0];
            A37CarnetFechaIngreso = BC00034_A37CarnetFechaIngreso[0];
         }
         bcCarnet = new SdtCarnet(context);
         gx_restcollection.Clear();
         while ( RcdFound14 != 0 )
         {
            OnLoadActions0314( ) ;
            AddRow0314( ) ;
            gx_sdt_item = (SdtCarnet)(bcCarnet.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(2);
            RcdFound14 = 0;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(2) != 101) )
            {
               RcdFound14 = 1;
               A36CarnetId = BC00034_A36CarnetId[0];
               A37CarnetFechaIngreso = BC00034_A37CarnetFechaIngreso[0];
            }
            Gx_mode = sMode14;
         }
         pr_default.close(2);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM0314( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow0314( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey0314( ) ;
         standaloneModal( ) ;
         AddRow0314( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11032 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z36CarnetId = A36CarnetId;
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

      protected void CONFIRM_030( )
      {
         BeforeValidate0314( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls0314( ) ;
            }
            else
            {
               CheckExtendedTable0314( ) ;
               if ( AnyError == 0 )
               {
               }
               CloseExtendedTableCursors0314( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12032( )
      {
         /* Start Routine */
      }

      protected void E11032( )
      {
         /* After Trn Routine */
      }

      protected void ZM0314( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z37CarnetFechaIngreso = A37CarnetFechaIngreso;
         }
         if ( GX_JID == -2 )
         {
            Z36CarnetId = A36CarnetId;
            Z37CarnetFechaIngreso = A37CarnetFechaIngreso;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load0314( )
      {
         /* Using cursor BC00035 */
         pr_default.execute(3, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound14 = 1;
            A37CarnetFechaIngreso = BC00035_A37CarnetFechaIngreso[0];
            ZM0314( -2) ;
         }
         pr_default.close(3);
         OnLoadActions0314( ) ;
      }

      protected void OnLoadActions0314( )
      {
      }

      protected void CheckExtendedTable0314( )
      {
         standaloneModal( ) ;
         if ( ! ( (DateTime.MinValue==A37CarnetFechaIngreso) || ( A37CarnetFechaIngreso >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Carnet Fecha Ingreso is out of range", "OutOfRange", 1, "");
            AnyError = 1;
         }
      }

      protected void CloseExtendedTableCursors0314( )
      {
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey0314( )
      {
         /* Using cursor BC00036 */
         pr_default.execute(4, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound14 = 1;
         }
         else
         {
            RcdFound14 = 0;
         }
         pr_default.close(4);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00033 */
         pr_default.execute(1, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM0314( 2) ;
            RcdFound14 = 1;
            A36CarnetId = BC00033_A36CarnetId[0];
            A37CarnetFechaIngreso = BC00033_A37CarnetFechaIngreso[0];
            Z36CarnetId = A36CarnetId;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load0314( ) ;
            if ( AnyError == 1 )
            {
               RcdFound14 = 0;
               InitializeNonKey0314( ) ;
            }
            Gx_mode = sMode14;
         }
         else
         {
            RcdFound14 = 0;
            InitializeNonKey0314( ) ;
            sMode14 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode14;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey0314( ) ;
         if ( RcdFound14 == 0 )
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
         CONFIRM_030( ) ;
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

      protected void CheckOptimisticConcurrency0314( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00032 */
            pr_default.execute(0, new Object[] {A36CarnetId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carnet"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z37CarnetFechaIngreso != BC00032_A37CarnetFechaIngreso[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Carnet"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert0314( )
      {
         BeforeValidate0314( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0314( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM0314( 0) ;
            CheckOptimisticConcurrency0314( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0314( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert0314( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00037 */
                     pr_default.execute(5, new Object[] {A36CarnetId, A37CarnetFechaIngreso});
                     pr_default.close(5);
                     dsDefault.SmartCacheProvider.SetUpdated("Carnet") ;
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
               Load0314( ) ;
            }
            EndLevel0314( ) ;
         }
         CloseExtendedTableCursors0314( ) ;
      }

      protected void Update0314( )
      {
         BeforeValidate0314( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable0314( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0314( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm0314( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate0314( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00038 */
                     pr_default.execute(6, new Object[] {A37CarnetFechaIngreso, A36CarnetId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Carnet") ;
                     if ( (pr_default.getStatus(6) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carnet"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate0314( ) ;
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
            EndLevel0314( ) ;
         }
         CloseExtendedTableCursors0314( ) ;
      }

      protected void DeferredUpdate0314( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate0314( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency0314( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls0314( ) ;
            AfterConfirm0314( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete0314( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC00039 */
                  pr_default.execute(7, new Object[] {A36CarnetId});
                  pr_default.close(7);
                  dsDefault.SmartCacheProvider.SetUpdated("Carnet") ;
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
         sMode14 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel0314( ) ;
         Gx_mode = sMode14;
      }

      protected void OnDeleteControls0314( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
         if ( AnyError == 0 )
         {
            /* Using cursor BC000310 */
            pr_default.execute(8, new Object[] {A36CarnetId});
            if ( (pr_default.getStatus(8) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Socio"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(8);
         }
      }

      protected void EndLevel0314( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete0314( ) ;
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

      public void ScanKeyStart0314( )
      {
         /* Scan By routine */
         /* Using cursor BC000311 */
         pr_default.execute(9, new Object[] {A36CarnetId});
         RcdFound14 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound14 = 1;
            A36CarnetId = BC000311_A36CarnetId[0];
            A37CarnetFechaIngreso = BC000311_A37CarnetFechaIngreso[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext0314( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound14 = 0;
         ScanKeyLoad0314( ) ;
      }

      protected void ScanKeyLoad0314( )
      {
         sMode14 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound14 = 1;
            A36CarnetId = BC000311_A36CarnetId[0];
            A37CarnetFechaIngreso = BC000311_A37CarnetFechaIngreso[0];
         }
         Gx_mode = sMode14;
      }

      protected void ScanKeyEnd0314( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm0314( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert0314( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate0314( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete0314( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete0314( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate0314( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes0314( )
      {
      }

      protected void send_integrity_lvl_hashes0314( )
      {
      }

      protected void AddRow0314( )
      {
         VarsToRow14( bcCarnet) ;
      }

      protected void ReadRow0314( )
      {
         RowToVars14( bcCarnet, 1) ;
      }

      protected void InitializeNonKey0314( )
      {
         A37CarnetFechaIngreso = DateTime.MinValue;
         Z37CarnetFechaIngreso = DateTime.MinValue;
      }

      protected void InitAll0314( )
      {
         A36CarnetId = 0;
         InitializeNonKey0314( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow14( SdtCarnet obj14 )
      {
         obj14.gxTpr_Mode = Gx_mode;
         obj14.gxTpr_Carnetfechaingreso = A37CarnetFechaIngreso;
         obj14.gxTpr_Carnetid = A36CarnetId;
         obj14.gxTpr_Carnetid_Z = Z36CarnetId;
         obj14.gxTpr_Carnetfechaingreso_Z = Z37CarnetFechaIngreso;
         obj14.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow14( SdtCarnet obj14 )
      {
         obj14.gxTpr_Carnetid = A36CarnetId;
         return  ;
      }

      public void RowToVars14( SdtCarnet obj14 ,
                               int forceLoad )
      {
         Gx_mode = obj14.gxTpr_Mode;
         A37CarnetFechaIngreso = obj14.gxTpr_Carnetfechaingreso;
         A36CarnetId = obj14.gxTpr_Carnetid;
         Z36CarnetId = obj14.gxTpr_Carnetid_Z;
         Z37CarnetFechaIngreso = obj14.gxTpr_Carnetfechaingreso_Z;
         Gx_mode = obj14.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A36CarnetId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey0314( ) ;
         ScanKeyStart0314( ) ;
         if ( RcdFound14 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z36CarnetId = A36CarnetId;
         }
         ZM0314( -2) ;
         OnLoadActions0314( ) ;
         AddRow0314( ) ;
         ScanKeyEnd0314( ) ;
         if ( RcdFound14 == 0 )
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
         RowToVars14( bcCarnet, 0) ;
         ScanKeyStart0314( ) ;
         if ( RcdFound14 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z36CarnetId = A36CarnetId;
         }
         ZM0314( -2) ;
         OnLoadActions0314( ) ;
         AddRow0314( ) ;
         ScanKeyEnd0314( ) ;
         if ( RcdFound14 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey0314( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert0314( ) ;
         }
         else
         {
            if ( RcdFound14 == 1 )
            {
               if ( A36CarnetId != Z36CarnetId )
               {
                  A36CarnetId = Z36CarnetId;
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
                  Update0314( ) ;
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
                  if ( A36CarnetId != Z36CarnetId )
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
                        Insert0314( ) ;
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
                        Insert0314( ) ;
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
         RowToVars14( bcCarnet, 0) ;
         SaveImpl( ) ;
         VarsToRow14( bcCarnet) ;
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
         RowToVars14( bcCarnet, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0314( ) ;
         AfterTrn( ) ;
         VarsToRow14( bcCarnet) ;
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
            SdtCarnet auxBC = new SdtCarnet(context) ;
            auxBC.Load(A36CarnetId);
            auxBC.UpdateDirties(bcCarnet);
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
         RowToVars14( bcCarnet, 0) ;
         UpdateImpl( ) ;
         VarsToRow14( bcCarnet) ;
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
         RowToVars14( bcCarnet, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert0314( ) ;
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
         VarsToRow14( bcCarnet) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars14( bcCarnet, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey0314( ) ;
         if ( RcdFound14 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A36CarnetId != Z36CarnetId )
            {
               A36CarnetId = Z36CarnetId;
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
            if ( A36CarnetId != Z36CarnetId )
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
         context.RollbackDataStores("carnet_bc",pr_default);
         VarsToRow14( bcCarnet) ;
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
         Gx_mode = bcCarnet.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcCarnet.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcCarnet )
         {
            bcCarnet = (SdtCarnet)(sdt);
            if ( StringUtil.StrCmp(bcCarnet.gxTpr_Mode, "") == 0 )
            {
               bcCarnet.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow14( bcCarnet) ;
            }
            else
            {
               RowToVars14( bcCarnet, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcCarnet.gxTpr_Mode, "") == 0 )
            {
               bcCarnet.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars14( bcCarnet, 1) ;
         return  ;
      }

      public SdtCarnet Carnet_BC
      {
         get {
            return bcCarnet ;
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
         BC00034_A36CarnetId = new short[1] ;
         BC00034_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         A37CarnetFechaIngreso = DateTime.MinValue;
         gx_restcollection = new GXBCCollection<SdtCarnet>( context, "Carnet", "ObligatorioGenexusGit");
         sMode14 = "";
         Gx_mode = "";
         Z37CarnetFechaIngreso = DateTime.MinValue;
         BC00035_A36CarnetId = new short[1] ;
         BC00035_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00036_A36CarnetId = new short[1] ;
         BC00033_A36CarnetId = new short[1] ;
         BC00033_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00032_A36CarnetId = new short[1] ;
         BC00032_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC000310_A5SocioId = new short[1] ;
         BC000311_A36CarnetId = new short[1] ;
         BC000311_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.carnet_bc__default(),
            new Object[][] {
                new Object[] {
               BC00032_A36CarnetId, BC00032_A37CarnetFechaIngreso
               }
               , new Object[] {
               BC00033_A36CarnetId, BC00033_A37CarnetFechaIngreso
               }
               , new Object[] {
               BC00034_A36CarnetId, BC00034_A37CarnetFechaIngreso
               }
               , new Object[] {
               BC00035_A36CarnetId, BC00035_A37CarnetFechaIngreso
               }
               , new Object[] {
               BC00036_A36CarnetId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000310_A5SocioId
               }
               , new Object[] {
               BC000311_A36CarnetId, BC000311_A37CarnetFechaIngreso
               }
            }
         );
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12032 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound14 ;
      private short A36CarnetId ;
      private short Z36CarnetId ;
      private short GX_JID ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom14 ;
      private int GXPagingTo14 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String sMode14 ;
      private String Gx_mode ;
      private DateTime A37CarnetFechaIngreso ;
      private DateTime Z37CarnetFechaIngreso ;
      private GXBCCollection<SdtCarnet> gx_restcollection ;
      private SdtCarnet bcCarnet ;
      private SdtCarnet gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00034_A36CarnetId ;
      private DateTime[] BC00034_A37CarnetFechaIngreso ;
      private short[] BC00035_A36CarnetId ;
      private DateTime[] BC00035_A37CarnetFechaIngreso ;
      private short[] BC00036_A36CarnetId ;
      private short[] BC00033_A36CarnetId ;
      private DateTime[] BC00033_A37CarnetFechaIngreso ;
      private short[] BC00032_A36CarnetId ;
      private DateTime[] BC00032_A37CarnetFechaIngreso ;
      private short[] BC000310_A5SocioId ;
      private short[] BC000311_A36CarnetId ;
      private DateTime[] BC000311_A37CarnetFechaIngreso ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class carnet_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00034 ;
          prmBC00034 = new Object[] {
          new Object[] {"@GXPagingFrom14",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo14",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00035 ;
          prmBC00035 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00036 ;
          prmBC00036 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00033 ;
          prmBC00033 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00032 ;
          prmBC00032 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00037 ;
          prmBC00037 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CarnetFechaIngreso",SqlDbType.DateTime,8,0}
          } ;
          Object[] prmBC00038 ;
          prmBC00038 = new Object[] {
          new Object[] {"@CarnetFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00039 ;
          prmBC00039 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000310 ;
          prmBC000310 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000311 ;
          prmBC000311 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00032", "SELECT [CarnetId], [CarnetFechaIngreso] FROM [Carnet] WITH (UPDLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00032,1,0,true,false )
             ,new CursorDef("BC00033", "SELECT [CarnetId], [CarnetFechaIngreso] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00033,1,0,true,false )
             ,new CursorDef("BC00034", "SELECT TM1.[CarnetId], TM1.[CarnetFechaIngreso] FROM [Carnet] TM1 WITH (NOLOCK) ORDER BY TM1.[CarnetId]  OFFSET @GXPagingFrom14 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo14 > 0 THEN @GXPagingTo14 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00034,100,0,true,false )
             ,new CursorDef("BC00035", "SELECT TM1.[CarnetId], TM1.[CarnetFechaIngreso] FROM [Carnet] TM1 WITH (NOLOCK) WHERE TM1.[CarnetId] = @CarnetId ORDER BY TM1.[CarnetId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00035,100,0,true,false )
             ,new CursorDef("BC00036", "SELECT [CarnetId] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00036,1,0,true,false )
             ,new CursorDef("BC00037", "INSERT INTO [Carnet]([CarnetId], [CarnetFechaIngreso]) VALUES(@CarnetId, @CarnetFechaIngreso)", GxErrorMask.GX_NOMASK,prmBC00037)
             ,new CursorDef("BC00038", "UPDATE [Carnet] SET [CarnetFechaIngreso]=@CarnetFechaIngreso  WHERE [CarnetId] = @CarnetId", GxErrorMask.GX_NOMASK,prmBC00038)
             ,new CursorDef("BC00039", "DELETE FROM [Carnet]  WHERE [CarnetId] = @CarnetId", GxErrorMask.GX_NOMASK,prmBC00039)
             ,new CursorDef("BC000310", "SELECT TOP 1 [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000310,1,0,true,true )
             ,new CursorDef("BC000311", "SELECT TM1.[CarnetId], TM1.[CarnetFechaIngreso] FROM [Carnet] TM1 WITH (NOLOCK) WHERE TM1.[CarnetId] = @CarnetId ORDER BY TM1.[CarnetId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000311,100,0,true,false )
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
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 8 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
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
                stmt.SetParameter(2, (DateTime)parms[1]);
                return;
             case 6 :
                stmt.SetParameter(1, (DateTime)parms[0]);
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

 [ServiceContract(Namespace = "GeneXus.Programs.carnet_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class carnet_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA36CarnetId}")]
    public SdtCarnet_RESTInterface Load( string sA36CarnetId )
    {
       try
       {
          short A36CarnetId ;
          A36CarnetId = (short)(NumberUtil.Val( (String)(sA36CarnetId), "."));
          SdtCarnet worker = new SdtCarnet(context) ;
          SdtCarnet_RESTInterface worker_interface = new SdtCarnet_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA36CarnetId, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction() ;
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A36CarnetId);
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
    	UriTemplate = "/{sA36CarnetId}")]
    public SdtCarnet_RESTInterface Delete( string sA36CarnetId )
    {
       try
       {
          short A36CarnetId ;
          A36CarnetId = (short)(NumberUtil.Val( (String)(sA36CarnetId), "."));
          SdtCarnet worker = new SdtCarnet(context) ;
          SdtCarnet_RESTInterface worker_interface = new SdtCarnet_RESTInterface (worker);
          worker.Load(A36CarnetId);
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
    	UriTemplate = "/{sA36CarnetId}")]
    public SdtCarnet_RESTInterface Insert( string sA36CarnetId ,
                                           SdtCarnet_RESTInterface entity )
    {
       try
       {
          short A36CarnetId ;
          A36CarnetId = (short)(NumberUtil.Val( (String)(sA36CarnetId), "."));
          SdtCarnet worker = new SdtCarnet(context) ;
          bool gxcheck = RestParameter("check", "true") ;
          bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
          SdtCarnet_RESTInterface worker_interface = new SdtCarnet_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Carnetid = A36CarnetId;
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
    	UriTemplate = "/{sA36CarnetId}")]
    public SdtCarnet_RESTInterface Update( string sA36CarnetId ,
                                           SdtCarnet_RESTInterface entity )
    {
       try
       {
          short A36CarnetId ;
          A36CarnetId = (short)(NumberUtil.Val( (String)(sA36CarnetId), "."));
          SdtCarnet worker = new SdtCarnet(context) ;
          SdtCarnet_RESTInterface worker_interface = new SdtCarnet_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true") ;
          worker.Load(A36CarnetId);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Carnetid = A36CarnetId;
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
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Carnet"}) );
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
