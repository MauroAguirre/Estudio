/*
               File: Carne_BC
        Description: Carne
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/22/2019 19:0:59.57
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class carne_bc : GXHttpHandler, IGxSilentTrn
   {
      public carne_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public carne_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public void GetInsDefault( )
      {
         ReadRow035( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey035( ) ;
         standaloneModal( ) ;
         AddRow035( ) ;
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
               Z4CarneId = A4CarneId;
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
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls035( ) ;
            }
            else
            {
               CheckExtendedTable035( ) ;
               if ( AnyError == 0 )
               {
                  ZM035( 4) ;
               }
               CloseExtendedTableCursors035( ) ;
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

      protected void ZM035( short GX_JID )
      {
         if ( ( GX_JID == 2 ) || ( GX_JID == 0 ) )
         {
            Z22CarneFechaIngreso = A22CarneFechaIngreso;
            Z5SocioId = A5SocioId;
         }
         if ( ( GX_JID == 4 ) || ( GX_JID == 0 ) )
         {
         }
         if ( GX_JID == -2 )
         {
            Z4CarneId = A4CarneId;
            Z22CarneFechaIngreso = A22CarneFechaIngreso;
            Z5SocioId = A5SocioId;
         }
      }

      protected void standaloneNotModal( )
      {
      }

      protected void standaloneModal( )
      {
      }

      protected void Load035( )
      {
         /* Using cursor BC00035 */
         pr_default.execute(3, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound5 = 1;
            A22CarneFechaIngreso = BC00035_A22CarneFechaIngreso[0];
            A5SocioId = BC00035_A5SocioId[0];
            ZM035( -2) ;
         }
         pr_default.close(3);
         OnLoadActions035( ) ;
      }

      protected void OnLoadActions035( )
      {
      }

      protected void CheckExtendedTable035( )
      {
         standaloneModal( ) ;
         /* Using cursor BC00036 */
         pr_default.execute(4, new Object[] {A5SocioId, A4CarneId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_1004", new   object[]  {"Socio Id"}), 1, "");
            AnyError = 1;
         }
         pr_default.close(4);
         if ( ! ( (DateTime.MinValue==A22CarneFechaIngreso) || ( A22CarneFechaIngreso >= context.localUtil.YMDToD( 1753, 1, 1) ) ) )
         {
            GX_msglist.addItem("Field Carne Fecha Ingreso is out of range", "OutOfRange", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC00034 */
         pr_default.execute(2, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Socio'.", "ForeignKeyNotFound", 1, "SOCIOID");
            AnyError = 1;
         }
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors035( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey035( )
      {
         /* Using cursor BC00037 */
         pr_default.execute(5, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound5 = 1;
         }
         else
         {
            RcdFound5 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00033 */
         pr_default.execute(1, new Object[] {A4CarneId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM035( 2) ;
            RcdFound5 = 1;
            A4CarneId = BC00033_A4CarneId[0];
            A22CarneFechaIngreso = BC00033_A22CarneFechaIngreso[0];
            A5SocioId = BC00033_A5SocioId[0];
            Z4CarneId = A4CarneId;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load035( ) ;
            if ( AnyError == 1 )
            {
               RcdFound5 = 0;
               InitializeNonKey035( ) ;
            }
            Gx_mode = sMode5;
         }
         else
         {
            RcdFound5 = 0;
            InitializeNonKey035( ) ;
            sMode5 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode5;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey035( ) ;
         if ( RcdFound5 == 0 )
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

      protected void CheckOptimisticConcurrency035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00032 */
            pr_default.execute(0, new Object[] {A4CarneId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carne"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            if ( (pr_default.getStatus(0) == 101) || ( Z22CarneFechaIngreso != BC00032_A22CarneFechaIngreso[0] ) || ( Z5SocioId != BC00032_A5SocioId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Carne"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM035( 0) ;
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00038 */
                     pr_default.execute(6, new Object[] {A22CarneFechaIngreso, A5SocioId});
                     A4CarneId = BC00038_A4CarneId[0];
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Carne") ;
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
               Load035( ) ;
            }
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void Update035( )
      {
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable035( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm035( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate035( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00039 */
                     pr_default.execute(7, new Object[] {A22CarneFechaIngreso, A5SocioId, A4CarneId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Carne") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Carne"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate035( ) ;
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
            EndLevel035( ) ;
         }
         CloseExtendedTableCursors035( ) ;
      }

      protected void DeferredUpdate035( )
      {
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate035( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency035( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls035( ) ;
            AfterConfirm035( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete035( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000310 */
                  pr_default.execute(8, new Object[] {A4CarneId});
                  pr_default.close(8);
                  dsDefault.SmartCacheProvider.SetUpdated("Carne") ;
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
         sMode5 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel035( ) ;
         Gx_mode = sMode5;
      }

      protected void OnDeleteControls035( )
      {
         standaloneModal( ) ;
         /* No delete mode formulas found. */
      }

      protected void EndLevel035( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete035( ) ;
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

      public void ScanKeyStart035( )
      {
         /* Scan By routine */
         /* Using cursor BC000311 */
         pr_default.execute(9, new Object[] {A4CarneId});
         RcdFound5 = 0;
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound5 = 1;
            A4CarneId = BC000311_A4CarneId[0];
            A22CarneFechaIngreso = BC000311_A22CarneFechaIngreso[0];
            A5SocioId = BC000311_A5SocioId[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext035( )
      {
         /* Scan next routine */
         pr_default.readNext(9);
         RcdFound5 = 0;
         ScanKeyLoad035( ) ;
      }

      protected void ScanKeyLoad035( )
      {
         sMode5 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(9) != 101) )
         {
            RcdFound5 = 1;
            A4CarneId = BC000311_A4CarneId[0];
            A22CarneFechaIngreso = BC000311_A22CarneFechaIngreso[0];
            A5SocioId = BC000311_A5SocioId[0];
         }
         Gx_mode = sMode5;
      }

      protected void ScanKeyEnd035( )
      {
         pr_default.close(9);
      }

      protected void AfterConfirm035( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert035( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate035( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete035( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete035( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate035( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes035( )
      {
      }

      protected void send_integrity_lvl_hashes035( )
      {
      }

      protected void AddRow035( )
      {
         VarsToRow5( bcCarne) ;
      }

      protected void ReadRow035( )
      {
         RowToVars5( bcCarne, 1) ;
      }

      protected void InitializeNonKey035( )
      {
         A22CarneFechaIngreso = DateTime.MinValue;
         A5SocioId = 0;
         Z22CarneFechaIngreso = DateTime.MinValue;
         Z5SocioId = 0;
      }

      protected void InitAll035( )
      {
         A4CarneId = 0;
         InitializeNonKey035( ) ;
      }

      protected void StandaloneModalInsert( )
      {
      }

      public void VarsToRow5( SdtCarne obj5 )
      {
         obj5.gxTpr_Mode = Gx_mode;
         obj5.gxTpr_Carnefechaingreso = A22CarneFechaIngreso;
         obj5.gxTpr_Socioid = A5SocioId;
         obj5.gxTpr_Carneid = A4CarneId;
         obj5.gxTpr_Carneid_Z = Z4CarneId;
         obj5.gxTpr_Carnefechaingreso_Z = Z22CarneFechaIngreso;
         obj5.gxTpr_Socioid_Z = Z5SocioId;
         obj5.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow5( SdtCarne obj5 )
      {
         obj5.gxTpr_Carneid = A4CarneId;
         return  ;
      }

      public void RowToVars5( SdtCarne obj5 ,
                              int forceLoad )
      {
         Gx_mode = obj5.gxTpr_Mode;
         A22CarneFechaIngreso = obj5.gxTpr_Carnefechaingreso;
         A5SocioId = obj5.gxTpr_Socioid;
         A4CarneId = obj5.gxTpr_Carneid;
         Z4CarneId = obj5.gxTpr_Carneid_Z;
         Z22CarneFechaIngreso = obj5.gxTpr_Carnefechaingreso_Z;
         Z5SocioId = obj5.gxTpr_Socioid_Z;
         Gx_mode = obj5.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A4CarneId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey035( ) ;
         ScanKeyStart035( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z4CarneId = A4CarneId;
         }
         ZM035( -2) ;
         OnLoadActions035( ) ;
         AddRow035( ) ;
         ScanKeyEnd035( ) ;
         if ( RcdFound5 == 0 )
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
         RowToVars5( bcCarne, 0) ;
         ScanKeyStart035( ) ;
         if ( RcdFound5 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z4CarneId = A4CarneId;
         }
         ZM035( -2) ;
         OnLoadActions035( ) ;
         AddRow035( ) ;
         ScanKeyEnd035( ) ;
         if ( RcdFound5 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey035( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert035( ) ;
         }
         else
         {
            if ( RcdFound5 == 1 )
            {
               if ( A4CarneId != Z4CarneId )
               {
                  A4CarneId = Z4CarneId;
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
                  Update035( ) ;
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
                  if ( A4CarneId != Z4CarneId )
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
                        Insert035( ) ;
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
                        Insert035( ) ;
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
         RowToVars5( bcCarne, 0) ;
         SaveImpl( ) ;
         VarsToRow5( bcCarne) ;
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
         RowToVars5( bcCarne, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert035( ) ;
         AfterTrn( ) ;
         VarsToRow5( bcCarne) ;
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
            SdtCarne auxBC = new SdtCarne(context) ;
            auxBC.Load(A4CarneId);
            auxBC.UpdateDirties(bcCarne);
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
         RowToVars5( bcCarne, 0) ;
         UpdateImpl( ) ;
         VarsToRow5( bcCarne) ;
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
         RowToVars5( bcCarne, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert035( ) ;
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
         VarsToRow5( bcCarne) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars5( bcCarne, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey035( ) ;
         if ( RcdFound5 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A4CarneId != Z4CarneId )
            {
               A4CarneId = Z4CarneId;
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
            if ( A4CarneId != Z4CarneId )
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
         context.RollbackDataStores("carne_bc",pr_default);
         VarsToRow5( bcCarne) ;
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
         Gx_mode = bcCarne.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcCarne.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcCarne )
         {
            bcCarne = (SdtCarne)(sdt);
            if ( StringUtil.StrCmp(bcCarne.gxTpr_Mode, "") == 0 )
            {
               bcCarne.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow5( bcCarne) ;
            }
            else
            {
               RowToVars5( bcCarne, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcCarne.gxTpr_Mode, "") == 0 )
            {
               bcCarne.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars5( bcCarne, 1) ;
         return  ;
      }

      public SdtCarne Carne_BC
      {
         get {
            return bcCarne ;
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
         Gx_mode = "";
         Z22CarneFechaIngreso = DateTime.MinValue;
         A22CarneFechaIngreso = DateTime.MinValue;
         BC00035_A4CarneId = new short[1] ;
         BC00035_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00035_A5SocioId = new short[1] ;
         BC00036_A5SocioId = new short[1] ;
         BC00034_A5SocioId = new short[1] ;
         BC00037_A4CarneId = new short[1] ;
         BC00033_A4CarneId = new short[1] ;
         BC00033_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00033_A5SocioId = new short[1] ;
         sMode5 = "";
         BC00032_A4CarneId = new short[1] ;
         BC00032_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00032_A5SocioId = new short[1] ;
         BC00038_A4CarneId = new short[1] ;
         BC000311_A4CarneId = new short[1] ;
         BC000311_A22CarneFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC000311_A5SocioId = new short[1] ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.carne_bc__default(),
            new Object[][] {
                new Object[] {
               BC00032_A4CarneId, BC00032_A22CarneFechaIngreso, BC00032_A5SocioId
               }
               , new Object[] {
               BC00033_A4CarneId, BC00033_A22CarneFechaIngreso, BC00033_A5SocioId
               }
               , new Object[] {
               BC00034_A5SocioId
               }
               , new Object[] {
               BC00035_A4CarneId, BC00035_A22CarneFechaIngreso, BC00035_A5SocioId
               }
               , new Object[] {
               BC00036_A5SocioId
               }
               , new Object[] {
               BC00037_A4CarneId
               }
               , new Object[] {
               BC00038_A4CarneId
               }
               , new Object[] {
               }
               , new Object[] {
               }
               , new Object[] {
               BC000311_A4CarneId, BC000311_A22CarneFechaIngreso, BC000311_A5SocioId
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
      private short Z4CarneId ;
      private short A4CarneId ;
      private short GX_JID ;
      private short Z5SocioId ;
      private short A5SocioId ;
      private short RcdFound5 ;
      private int trnEnded ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String Gx_mode ;
      private String sMode5 ;
      private DateTime Z22CarneFechaIngreso ;
      private DateTime A22CarneFechaIngreso ;
      private SdtCarne bcCarne ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00035_A4CarneId ;
      private DateTime[] BC00035_A22CarneFechaIngreso ;
      private short[] BC00035_A5SocioId ;
      private short[] BC00036_A5SocioId ;
      private short[] BC00034_A5SocioId ;
      private short[] BC00037_A4CarneId ;
      private short[] BC00033_A4CarneId ;
      private DateTime[] BC00033_A22CarneFechaIngreso ;
      private short[] BC00033_A5SocioId ;
      private short[] BC00032_A4CarneId ;
      private DateTime[] BC00032_A22CarneFechaIngreso ;
      private short[] BC00032_A5SocioId ;
      private short[] BC00038_A4CarneId ;
      private short[] BC000311_A4CarneId ;
      private DateTime[] BC000311_A22CarneFechaIngreso ;
      private short[] BC000311_A5SocioId ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class carne_bc__default : DataStoreHelperBase, IDataStoreHelper
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
         ,new UpdateCursor(def[7])
         ,new UpdateCursor(def[8])
         ,new ForEachCursor(def[9])
       };
    }

    private static CursorDef[] def;
    private void cursorDefinitions( )
    {
       if ( def == null )
       {
          Object[] prmBC00035 ;
          prmBC00035 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00036 ;
          prmBC00036 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00034 ;
          prmBC00034 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00037 ;
          prmBC00037 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00033 ;
          prmBC00033 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00032 ;
          prmBC00032 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00038 ;
          prmBC00038 = new Object[] {
          new Object[] {"@CarneFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00039 ;
          prmBC00039 = new Object[] {
          new Object[] {"@CarneFechaIngreso",SqlDbType.DateTime,8,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000310 ;
          prmBC000310 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000311 ;
          prmBC000311 = new Object[] {
          new Object[] {"@CarneId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00032", "SELECT [CarneId], [CarneFechaIngreso], [SocioId] FROM [Carne] WITH (UPDLOCK) WHERE [CarneId] = @CarneId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00032,1,0,true,false )
             ,new CursorDef("BC00033", "SELECT [CarneId], [CarneFechaIngreso], [SocioId] FROM [Carne] WITH (NOLOCK) WHERE [CarneId] = @CarneId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00033,1,0,true,false )
             ,new CursorDef("BC00034", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00034,1,0,true,false )
             ,new CursorDef("BC00035", "SELECT TM1.[CarneId], TM1.[CarneFechaIngreso], TM1.[SocioId] FROM [Carne] TM1 WITH (NOLOCK) WHERE TM1.[CarneId] = @CarneId ORDER BY TM1.[CarneId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00035,100,0,true,false )
             ,new CursorDef("BC00036", "SELECT [SocioId] FROM [Carne] WITH (NOLOCK) WHERE ([SocioId] = @SocioId) AND (Not ( [CarneId] = @CarneId)) ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00036,1,0,true,false )
             ,new CursorDef("BC00037", "SELECT [CarneId] FROM [Carne] WITH (NOLOCK) WHERE [CarneId] = @CarneId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00037,1,0,true,false )
             ,new CursorDef("BC00038", "INSERT INTO [Carne]([CarneFechaIngreso], [SocioId]) VALUES(@CarneFechaIngreso, @SocioId); SELECT SCOPE_IDENTITY()", GxErrorMask.GX_NOMASK,prmBC00038)
             ,new CursorDef("BC00039", "UPDATE [Carne] SET [CarneFechaIngreso]=@CarneFechaIngreso, [SocioId]=@SocioId  WHERE [CarneId] = @CarneId", GxErrorMask.GX_NOMASK,prmBC00039)
             ,new CursorDef("BC000310", "DELETE FROM [Carne]  WHERE [CarneId] = @CarneId", GxErrorMask.GX_NOMASK,prmBC000310)
             ,new CursorDef("BC000311", "SELECT TM1.[CarneId], TM1.[CarneFechaIngreso], TM1.[SocioId] FROM [Carne] TM1 WITH (NOLOCK) WHERE TM1.[CarneId] = @CarneId ORDER BY TM1.[CarneId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000311,100,0,true,false )
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
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 2 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 6 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 9 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((DateTime[]) buf[1])[0] = rslt.getGXDate(2) ;
                ((short[]) buf[2])[0] = rslt.getShort(3) ;
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
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 4 :
                stmt.SetParameter(1, (short)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 5 :
                stmt.SetParameter(1, (short)parms[0]);
                return;
             case 6 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                return;
             case 7 :
                stmt.SetParameter(1, (DateTime)parms[0]);
                stmt.SetParameter(2, (short)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
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

}
