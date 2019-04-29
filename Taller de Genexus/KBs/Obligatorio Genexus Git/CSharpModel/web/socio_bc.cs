/*
               File: Socio_BC
        Description: Socio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:45.29
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
   public class socio_bc : GXHttpHandler, IGxSilentTrn
   {
      public socio_bc( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public socio_bc( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      protected void INITTRN( )
      {
      }

      public GXBCCollection<SdtSocio> GetAll( int Start ,
                                              int Count )
      {
         GXPagingFrom4 = Start;
         GXPagingTo4 = Count;
         /* Using cursor BC00055 */
         pr_default.execute(3, new Object[] {GXPagingFrom4, GXPagingTo4});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(3) != 101) )
         {
            RcdFound4 = 1;
            A5SocioId = BC00055_A5SocioId[0];
            A18SocioDireccion = BC00055_A18SocioDireccion[0];
            A19SocioSexo = BC00055_A19SocioSexo[0];
            A20SocioEdad = BC00055_A20SocioEdad[0];
            A33SocioTipoCuota = BC00055_A33SocioTipoCuota[0];
            A24SocioReconocido = BC00055_A24SocioReconocido[0];
            A40000SocioFoto_GXI = BC00055_A40000SocioFoto_GXI[0];
            A37CarnetFechaIngreso = BC00055_A37CarnetFechaIngreso[0];
            A36CarnetId = BC00055_A36CarnetId[0];
            A21SocioFoto = BC00055_A21SocioFoto[0];
         }
         bcSocio = new SdtSocio(context);
         gx_restcollection.Clear();
         while ( RcdFound4 != 0 )
         {
            OnLoadActions054( ) ;
            AddRow054( ) ;
            gx_sdt_item = (SdtSocio)(bcSocio.Clone());
            gx_restcollection.Add(gx_sdt_item, 0);
            pr_default.readNext(3);
            RcdFound4 = 0;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            if ( (pr_default.getStatus(3) != 101) )
            {
               RcdFound4 = 1;
               A5SocioId = BC00055_A5SocioId[0];
               A18SocioDireccion = BC00055_A18SocioDireccion[0];
               A19SocioSexo = BC00055_A19SocioSexo[0];
               A20SocioEdad = BC00055_A20SocioEdad[0];
               A33SocioTipoCuota = BC00055_A33SocioTipoCuota[0];
               A24SocioReconocido = BC00055_A24SocioReconocido[0];
               A40000SocioFoto_GXI = BC00055_A40000SocioFoto_GXI[0];
               A37CarnetFechaIngreso = BC00055_A37CarnetFechaIngreso[0];
               A36CarnetId = BC00055_A36CarnetId[0];
               A21SocioFoto = BC00055_A21SocioFoto[0];
            }
            Gx_mode = sMode4;
         }
         pr_default.close(3);
         /* Load Subordinate Levels */
         return gx_restcollection ;
      }

      protected void SETSEUDOVARS( )
      {
         ZM054( 0) ;
      }

      public void GetInsDefault( )
      {
         ReadRow054( ) ;
         standaloneNotModal( ) ;
         InitializeNonKey054( ) ;
         standaloneModal( ) ;
         AddRow054( ) ;
         Gx_mode = "INS";
         return  ;
      }

      protected void AfterTrn( )
      {
         if ( trnEnded == 1 )
         {
            /* Execute user event: After Trn */
            E11052 ();
            trnEnded = 0;
            standaloneNotModal( ) ;
            standaloneModal( ) ;
            if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  )
            {
               Z5SocioId = A5SocioId;
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

      protected void CONFIRM_050( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "DLT") == 0 )
            {
               OnDeleteControls054( ) ;
            }
            else
            {
               CheckExtendedTable054( ) ;
               if ( AnyError == 0 )
               {
                  ZM054( 8) ;
               }
               CloseExtendedTableCursors054( ) ;
            }
         }
         if ( AnyError == 0 )
         {
            IsConfirmed = 1;
         }
      }

      protected void E12052( )
      {
         /* Start Routine */
      }

      protected void E11052( )
      {
         /* After Trn Routine */
      }

      protected void E13052( )
      {
         /* Delete Routine */
         new borrarcarnets(context ).execute( ) ;
      }

      protected void ZM054( short GX_JID )
      {
         if ( ( GX_JID == 7 ) || ( GX_JID == 0 ) )
         {
            Z18SocioDireccion = A18SocioDireccion;
            Z19SocioSexo = A19SocioSexo;
            Z20SocioEdad = A20SocioEdad;
            Z33SocioTipoCuota = A33SocioTipoCuota;
            Z24SocioReconocido = A24SocioReconocido;
            Z36CarnetId = A36CarnetId;
            Z32SocioMonto = A32SocioMonto;
         }
         if ( ( GX_JID == 8 ) || ( GX_JID == 0 ) )
         {
            Z37CarnetFechaIngreso = A37CarnetFechaIngreso;
            Z32SocioMonto = A32SocioMonto;
         }
         if ( GX_JID == -7 )
         {
            Z5SocioId = A5SocioId;
            Z18SocioDireccion = A18SocioDireccion;
            Z19SocioSexo = A19SocioSexo;
            Z20SocioEdad = A20SocioEdad;
            Z33SocioTipoCuota = A33SocioTipoCuota;
            Z24SocioReconocido = A24SocioReconocido;
            Z21SocioFoto = A21SocioFoto;
            Z40000SocioFoto_GXI = A40000SocioFoto_GXI;
            Z36CarnetId = A36CarnetId;
            Z37CarnetFechaIngreso = A37CarnetFechaIngreso;
         }
      }

      protected void standaloneNotModal( )
      {
         Gx_BScreen = 0;
      }

      protected void standaloneModal( )
      {
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A32SocioMonto) && ( Gx_BScreen == 0 ) )
         {
            A32SocioMonto = 2500;
         }
         if ( ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )  && (0==A5SocioId) && ( Gx_BScreen == 0 ) )
         {
            GXt_int1 = A5SocioId;
            new ultimoidsocio(context ).execute( out  GXt_int1) ;
            A5SocioId = GXt_int1;
         }
      }

      protected void Load054( )
      {
         /* Using cursor BC00056 */
         pr_default.execute(4, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(4) != 101) )
         {
            RcdFound4 = 1;
            A18SocioDireccion = BC00056_A18SocioDireccion[0];
            A19SocioSexo = BC00056_A19SocioSexo[0];
            A20SocioEdad = BC00056_A20SocioEdad[0];
            A33SocioTipoCuota = BC00056_A33SocioTipoCuota[0];
            A24SocioReconocido = BC00056_A24SocioReconocido[0];
            A40000SocioFoto_GXI = BC00056_A40000SocioFoto_GXI[0];
            A37CarnetFechaIngreso = BC00056_A37CarnetFechaIngreso[0];
            A36CarnetId = BC00056_A36CarnetId[0];
            A21SocioFoto = BC00056_A21SocioFoto[0];
            ZM054( -7) ;
         }
         pr_default.close(4);
         OnLoadActions054( ) ;
      }

      protected void OnLoadActions054( )
      {
         if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
         {
            A32SocioMonto = (short)(1500-(1500*0.3m));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
            {
               A32SocioMonto = (short)(2500-(2500*0.3m));
            }
            else
            {
               if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
               {
                  A32SocioMonto = 1500;
               }
               else
               {
                  if ( true )
                  {
                     A32SocioMonto = 2500;
                  }
                  else
                  {
                     A32SocioMonto = 0;
                  }
               }
            }
         }
      }

      protected void CheckExtendedTable054( )
      {
         standaloneModal( ) ;
         if ( ! ( ( StringUtil.StrCmp(A19SocioSexo, "Hombre") == 0 ) || ( StringUtil.StrCmp(A19SocioSexo, "Mujer") == 0 ) || ( StringUtil.StrCmp(A19SocioSexo, "Otro") == 0 ) ) )
         {
            GX_msglist.addItem("Field Socio Sexo is out of range", "OutOfRange", 1, "");
            AnyError = 1;
         }
         if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
         {
            A32SocioMonto = (short)(1500-(1500*0.3m));
         }
         else
         {
            if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
            {
               A32SocioMonto = (short)(2500-(2500*0.3m));
            }
            else
            {
               if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
               {
                  A32SocioMonto = 1500;
               }
               else
               {
                  if ( true )
                  {
                     A32SocioMonto = 2500;
                  }
                  else
                  {
                     A32SocioMonto = 0;
                  }
               }
            }
         }
         if ( ! ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) || ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) ) )
         {
            GX_msglist.addItem("Field Socio Tipo Cuota is out of range", "OutOfRange", 1, "");
            AnyError = 1;
         }
         /* Using cursor BC00054 */
         pr_default.execute(2, new Object[] {A36CarnetId});
         if ( (pr_default.getStatus(2) == 101) )
         {
            GX_msglist.addItem("No matching 'Carnet'.", "ForeignKeyNotFound", 1, "CARNETID");
            AnyError = 1;
         }
         A37CarnetFechaIngreso = BC00054_A37CarnetFechaIngreso[0];
         pr_default.close(2);
      }

      protected void CloseExtendedTableCursors054( )
      {
         pr_default.close(2);
      }

      protected void enableDisable( )
      {
      }

      protected void GetKey054( )
      {
         /* Using cursor BC00057 */
         pr_default.execute(5, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(5) != 101) )
         {
            RcdFound4 = 1;
         }
         else
         {
            RcdFound4 = 0;
         }
         pr_default.close(5);
      }

      protected void getByPrimaryKey( )
      {
         /* Using cursor BC00053 */
         pr_default.execute(1, new Object[] {A5SocioId});
         if ( (pr_default.getStatus(1) != 101) )
         {
            ZM054( 7) ;
            RcdFound4 = 1;
            A5SocioId = BC00053_A5SocioId[0];
            A18SocioDireccion = BC00053_A18SocioDireccion[0];
            A19SocioSexo = BC00053_A19SocioSexo[0];
            A20SocioEdad = BC00053_A20SocioEdad[0];
            A33SocioTipoCuota = BC00053_A33SocioTipoCuota[0];
            A24SocioReconocido = BC00053_A24SocioReconocido[0];
            A40000SocioFoto_GXI = BC00053_A40000SocioFoto_GXI[0];
            A36CarnetId = BC00053_A36CarnetId[0];
            A21SocioFoto = BC00053_A21SocioFoto[0];
            Z5SocioId = A5SocioId;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Load054( ) ;
            if ( AnyError == 1 )
            {
               RcdFound4 = 0;
               InitializeNonKey054( ) ;
            }
            Gx_mode = sMode4;
         }
         else
         {
            RcdFound4 = 0;
            InitializeNonKey054( ) ;
            sMode4 = Gx_mode;
            Gx_mode = "DSP";
            standaloneModal( ) ;
            Gx_mode = sMode4;
         }
         pr_default.close(1);
      }

      protected void getEqualNoModal( )
      {
         GetKey054( ) ;
         if ( RcdFound4 == 0 )
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
         CONFIRM_050( ) ;
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

      protected void CheckOptimisticConcurrency054( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            /* Using cursor BC00052 */
            pr_default.execute(0, new Object[] {A5SocioId});
            if ( (pr_default.getStatus(0) == 103) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Socio"}), "RecordIsLocked", 1, "");
               AnyError = 1;
               return  ;
            }
            Gx_longc = false;
            if ( (pr_default.getStatus(0) == 101) || ( StringUtil.StrCmp(Z18SocioDireccion, BC00052_A18SocioDireccion[0]) != 0 ) || ( StringUtil.StrCmp(Z19SocioSexo, BC00052_A19SocioSexo[0]) != 0 ) || ( Z20SocioEdad != BC00052_A20SocioEdad[0] ) || ( StringUtil.StrCmp(Z33SocioTipoCuota, BC00052_A33SocioTipoCuota[0]) != 0 ) || ( Z24SocioReconocido != BC00052_A24SocioReconocido[0] ) )
            {
               Gx_longc = true;
            }
            if ( Gx_longc || ( Z36CarnetId != BC00052_A36CarnetId[0] ) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_waschg", new   object[]  {"Socio"}), "RecordWasChanged", 1, "");
               AnyError = 1;
               return  ;
            }
         }
      }

      protected void Insert054( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable054( ) ;
         }
         if ( AnyError == 0 )
         {
            ZM054( 0) ;
            CheckOptimisticConcurrency054( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm054( ) ;
               if ( AnyError == 0 )
               {
                  BeforeInsert054( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00058 */
                     pr_default.execute(6, new Object[] {A5SocioId, A18SocioDireccion, A19SocioSexo, A20SocioEdad, A33SocioTipoCuota, A24SocioReconocido, A21SocioFoto, A40000SocioFoto_GXI, A36CarnetId});
                     pr_default.close(6);
                     dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
                     if ( (pr_default.getStatus(6) == 1) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
                        AnyError = 1;
                     }
                     if ( AnyError == 0 )
                     {
                        /* Start of After( Insert) rules */
                        new ingresarcarneauto(context ).execute( ) ;
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
               Load054( ) ;
            }
            EndLevel054( ) ;
         }
         CloseExtendedTableCursors054( ) ;
      }

      protected void Update054( )
      {
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            CheckExtendedTable054( ) ;
         }
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency054( ) ;
            if ( AnyError == 0 )
            {
               AfterConfirm054( ) ;
               if ( AnyError == 0 )
               {
                  BeforeUpdate054( ) ;
                  if ( AnyError == 0 )
                  {
                     /* Using cursor BC00059 */
                     pr_default.execute(7, new Object[] {A18SocioDireccion, A19SocioSexo, A20SocioEdad, A33SocioTipoCuota, A24SocioReconocido, A36CarnetId, A5SocioId});
                     pr_default.close(7);
                     dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
                     if ( (pr_default.getStatus(7) == 103) )
                     {
                        GX_msglist.addItem(context.GetMessage( "GXM_lock", new   object[]  {"Socio"}), "RecordIsLocked", 1, "");
                        AnyError = 1;
                     }
                     DeferredUpdate054( ) ;
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
            EndLevel054( ) ;
         }
         CloseExtendedTableCursors054( ) ;
      }

      protected void DeferredUpdate054( )
      {
         if ( AnyError == 0 )
         {
            /* Using cursor BC000510 */
            pr_default.execute(8, new Object[] {A21SocioFoto, A40000SocioFoto_GXI, A5SocioId});
            pr_default.close(8);
            dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
         }
      }

      protected void delete( )
      {
         Gx_mode = "DLT";
         BeforeValidate054( ) ;
         if ( AnyError == 0 )
         {
            CheckOptimisticConcurrency054( ) ;
         }
         if ( AnyError == 0 )
         {
            OnDeleteControls054( ) ;
            AfterConfirm054( ) ;
            if ( AnyError == 0 )
            {
               BeforeDelete054( ) ;
               if ( AnyError == 0 )
               {
                  /* No cascading delete specified. */
                  /* Using cursor BC000511 */
                  pr_default.execute(9, new Object[] {A5SocioId});
                  pr_default.close(9);
                  dsDefault.SmartCacheProvider.SetUpdated("Socio") ;
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
         sMode4 = Gx_mode;
         Gx_mode = "DLT";
         EndLevel054( ) ;
         Gx_mode = sMode4;
      }

      protected void OnDeleteControls054( )
      {
         standaloneModal( ) ;
         if ( AnyError == 0 )
         {
            /* Delete mode formulas */
            if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 ) && ( A20SocioEdad > 65 ) )
            {
               A32SocioMonto = (short)(1500-(1500*0.3m));
            }
            else
            {
               if ( ( StringUtil.StrCmp(A33SocioTipoCuota, "V") == 0 ) && ( A20SocioEdad > 65 ) )
               {
                  A32SocioMonto = (short)(2500-(2500*0.3m));
               }
               else
               {
                  if ( StringUtil.StrCmp(A33SocioTipoCuota, "P") == 0 )
                  {
                     A32SocioMonto = 1500;
                  }
                  else
                  {
                     if ( true )
                     {
                        A32SocioMonto = 2500;
                     }
                     else
                     {
                        A32SocioMonto = 0;
                     }
                  }
               }
            }
            /* Using cursor BC000512 */
            pr_default.execute(10, new Object[] {A36CarnetId});
            A37CarnetFechaIngreso = BC000512_A37CarnetFechaIngreso[0];
            pr_default.close(10);
         }
         if ( AnyError == 0 )
         {
            /* Using cursor BC000513 */
            pr_default.execute(11, new Object[] {A5SocioId});
            if ( (pr_default.getStatus(11) != 101) )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_del", new   object[]  {"Socios"}), "CannotDeleteReferencedRecord", 1, "");
               AnyError = 1;
            }
            pr_default.close(11);
         }
      }

      protected void EndLevel054( )
      {
         if ( StringUtil.StrCmp(Gx_mode, "INS") != 0 )
         {
            pr_default.close(0);
         }
         if ( AnyError == 0 )
         {
            BeforeComplete054( ) ;
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

      public void ScanKeyStart054( )
      {
         /* Scan By routine */
         /* Using cursor BC000514 */
         pr_default.execute(12, new Object[] {A5SocioId});
         RcdFound4 = 0;
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A5SocioId = BC000514_A5SocioId[0];
            A18SocioDireccion = BC000514_A18SocioDireccion[0];
            A19SocioSexo = BC000514_A19SocioSexo[0];
            A20SocioEdad = BC000514_A20SocioEdad[0];
            A33SocioTipoCuota = BC000514_A33SocioTipoCuota[0];
            A24SocioReconocido = BC000514_A24SocioReconocido[0];
            A40000SocioFoto_GXI = BC000514_A40000SocioFoto_GXI[0];
            A37CarnetFechaIngreso = BC000514_A37CarnetFechaIngreso[0];
            A36CarnetId = BC000514_A36CarnetId[0];
            A21SocioFoto = BC000514_A21SocioFoto[0];
         }
         /* Load Subordinate Levels */
      }

      protected void ScanKeyNext054( )
      {
         /* Scan next routine */
         pr_default.readNext(12);
         RcdFound4 = 0;
         ScanKeyLoad054( ) ;
      }

      protected void ScanKeyLoad054( )
      {
         sMode4 = Gx_mode;
         Gx_mode = "DSP";
         if ( (pr_default.getStatus(12) != 101) )
         {
            RcdFound4 = 1;
            A5SocioId = BC000514_A5SocioId[0];
            A18SocioDireccion = BC000514_A18SocioDireccion[0];
            A19SocioSexo = BC000514_A19SocioSexo[0];
            A20SocioEdad = BC000514_A20SocioEdad[0];
            A33SocioTipoCuota = BC000514_A33SocioTipoCuota[0];
            A24SocioReconocido = BC000514_A24SocioReconocido[0];
            A40000SocioFoto_GXI = BC000514_A40000SocioFoto_GXI[0];
            A37CarnetFechaIngreso = BC000514_A37CarnetFechaIngreso[0];
            A36CarnetId = BC000514_A36CarnetId[0];
            A21SocioFoto = BC000514_A21SocioFoto[0];
         }
         Gx_mode = sMode4;
      }

      protected void ScanKeyEnd054( )
      {
         pr_default.close(12);
      }

      protected void AfterConfirm054( )
      {
         /* After Confirm Rules */
      }

      protected void BeforeInsert054( )
      {
         /* Before Insert Rules */
      }

      protected void BeforeUpdate054( )
      {
         /* Before Update Rules */
      }

      protected void BeforeDelete054( )
      {
         /* Before Delete Rules */
      }

      protected void BeforeComplete054( )
      {
         /* Before Complete Rules */
      }

      protected void BeforeValidate054( )
      {
         /* Before Validate Rules */
      }

      protected void DisableAttributes054( )
      {
      }

      protected void send_integrity_lvl_hashes054( )
      {
      }

      protected void AddRow054( )
      {
         VarsToRow4( bcSocio) ;
      }

      protected void ReadRow054( )
      {
         RowToVars4( bcSocio, 1) ;
      }

      protected void InitializeNonKey054( )
      {
         A18SocioDireccion = "";
         A19SocioSexo = "";
         A20SocioEdad = 0;
         A33SocioTipoCuota = "";
         A24SocioReconocido = false;
         A21SocioFoto = "";
         A40000SocioFoto_GXI = "";
         A36CarnetId = 0;
         A37CarnetFechaIngreso = DateTime.MinValue;
         A32SocioMonto = 2500;
         Z18SocioDireccion = "";
         Z19SocioSexo = "";
         Z20SocioEdad = 0;
         Z33SocioTipoCuota = "";
         Z24SocioReconocido = false;
         Z36CarnetId = 0;
      }

      protected void InitAll054( )
      {
         A5SocioId = new ultimoidsocio(context).executeUdp( );
         InitializeNonKey054( ) ;
      }

      protected void StandaloneModalInsert( )
      {
         A32SocioMonto = i32SocioMonto;
      }

      public void VarsToRow4( SdtSocio obj4 )
      {
         obj4.gxTpr_Mode = Gx_mode;
         obj4.gxTpr_Sociodireccion = A18SocioDireccion;
         obj4.gxTpr_Sociosexo = A19SocioSexo;
         obj4.gxTpr_Socioedad = A20SocioEdad;
         obj4.gxTpr_Sociotipocuota = A33SocioTipoCuota;
         obj4.gxTpr_Socioreconocido = A24SocioReconocido;
         obj4.gxTpr_Sociofoto = A21SocioFoto;
         obj4.gxTpr_Sociofoto_gxi = A40000SocioFoto_GXI;
         obj4.gxTpr_Carnetid = A36CarnetId;
         obj4.gxTpr_Carnetfechaingreso = A37CarnetFechaIngreso;
         obj4.gxTpr_Sociomonto = A32SocioMonto;
         obj4.gxTpr_Socioid = A5SocioId;
         obj4.gxTpr_Socioid_Z = Z5SocioId;
         obj4.gxTpr_Sociodireccion_Z = Z18SocioDireccion;
         obj4.gxTpr_Sociosexo_Z = Z19SocioSexo;
         obj4.gxTpr_Socioedad_Z = Z20SocioEdad;
         obj4.gxTpr_Sociotipocuota_Z = Z33SocioTipoCuota;
         obj4.gxTpr_Socioreconocido_Z = Z24SocioReconocido;
         obj4.gxTpr_Sociomonto_Z = Z32SocioMonto;
         obj4.gxTpr_Carnetid_Z = Z36CarnetId;
         obj4.gxTpr_Carnetfechaingreso_Z = Z37CarnetFechaIngreso;
         obj4.gxTpr_Sociofoto_gxi_Z = Z40000SocioFoto_GXI;
         obj4.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void KeyVarsToRow4( SdtSocio obj4 )
      {
         obj4.gxTpr_Socioid = A5SocioId;
         return  ;
      }

      public void RowToVars4( SdtSocio obj4 ,
                              int forceLoad )
      {
         Gx_mode = obj4.gxTpr_Mode;
         A18SocioDireccion = obj4.gxTpr_Sociodireccion;
         A19SocioSexo = obj4.gxTpr_Sociosexo;
         A20SocioEdad = obj4.gxTpr_Socioedad;
         A33SocioTipoCuota = obj4.gxTpr_Sociotipocuota;
         A24SocioReconocido = obj4.gxTpr_Socioreconocido;
         A21SocioFoto = obj4.gxTpr_Sociofoto;
         A40000SocioFoto_GXI = obj4.gxTpr_Sociofoto_gxi;
         A36CarnetId = obj4.gxTpr_Carnetid;
         A37CarnetFechaIngreso = obj4.gxTpr_Carnetfechaingreso;
         A32SocioMonto = obj4.gxTpr_Sociomonto;
         A5SocioId = obj4.gxTpr_Socioid;
         Z5SocioId = obj4.gxTpr_Socioid_Z;
         Z18SocioDireccion = obj4.gxTpr_Sociodireccion_Z;
         Z19SocioSexo = obj4.gxTpr_Sociosexo_Z;
         Z20SocioEdad = obj4.gxTpr_Socioedad_Z;
         Z33SocioTipoCuota = obj4.gxTpr_Sociotipocuota_Z;
         Z24SocioReconocido = obj4.gxTpr_Socioreconocido_Z;
         Z32SocioMonto = obj4.gxTpr_Sociomonto_Z;
         Z36CarnetId = obj4.gxTpr_Carnetid_Z;
         Z37CarnetFechaIngreso = obj4.gxTpr_Carnetfechaingreso_Z;
         Z40000SocioFoto_GXI = obj4.gxTpr_Sociofoto_gxi_Z;
         Gx_mode = obj4.gxTpr_Mode;
         return  ;
      }

      public void LoadKey( Object[] obj )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         A5SocioId = (short)getParm(obj,0);
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         InitializeNonKey054( ) ;
         ScanKeyStart054( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z5SocioId = A5SocioId;
         }
         ZM054( -7) ;
         OnLoadActions054( ) ;
         AddRow054( ) ;
         ScanKeyEnd054( ) ;
         if ( RcdFound4 == 0 )
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
         RowToVars4( bcSocio, 0) ;
         ScanKeyStart054( ) ;
         if ( RcdFound4 == 0 )
         {
            Gx_mode = "INS";
         }
         else
         {
            Gx_mode = "UPD";
            Z5SocioId = A5SocioId;
         }
         ZM054( -7) ;
         OnLoadActions054( ) ;
         AddRow054( ) ;
         ScanKeyEnd054( ) ;
         if ( RcdFound4 == 0 )
         {
            GX_msglist.addItem(context.GetMessage( "GXM_keynfound", ""), "PrimaryKeyNotFound", 1, "");
            AnyError = 1;
         }
         context.GX_msglist = BackMsgLst;
      }

      protected void SaveImpl( )
      {
         nKeyPressed = 1;
         GetKey054( ) ;
         if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
         {
            /* Insert record */
            Insert054( ) ;
         }
         else
         {
            if ( RcdFound4 == 1 )
            {
               if ( A5SocioId != Z5SocioId )
               {
                  A5SocioId = Z5SocioId;
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
                  Update054( ) ;
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
                  if ( A5SocioId != Z5SocioId )
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
                        Insert054( ) ;
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
                        Insert054( ) ;
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
         RowToVars4( bcSocio, 0) ;
         SaveImpl( ) ;
         VarsToRow4( bcSocio) ;
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
         RowToVars4( bcSocio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert054( ) ;
         AfterTrn( ) ;
         VarsToRow4( bcSocio) ;
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
            SdtSocio auxBC = new SdtSocio(context) ;
            auxBC.Load(A5SocioId);
            auxBC.UpdateDirties(bcSocio);
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
         RowToVars4( bcSocio, 0) ;
         UpdateImpl( ) ;
         VarsToRow4( bcSocio) ;
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
         RowToVars4( bcSocio, 0) ;
         Gx_mode = "INS";
         /* Insert record */
         Insert054( ) ;
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
         VarsToRow4( bcSocio) ;
         context.GX_msglist = BackMsgLst;
         return (AnyError==0) ;
      }

      public void Check( )
      {
         BackMsgLst = context.GX_msglist;
         context.GX_msglist = LclMsgLst;
         AnyError = 0;
         context.GX_msglist.removeAllItems();
         RowToVars4( bcSocio, 0) ;
         nKeyPressed = 3;
         IsConfirmed = 0;
         GetKey054( ) ;
         if ( RcdFound4 == 1 )
         {
            if ( StringUtil.StrCmp(Gx_mode, "INS") == 0 )
            {
               GX_msglist.addItem(context.GetMessage( "GXM_noupdate", ""), "DuplicatePrimaryKey", 1, "");
               AnyError = 1;
            }
            else if ( A5SocioId != Z5SocioId )
            {
               A5SocioId = Z5SocioId;
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
            if ( A5SocioId != Z5SocioId )
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
         context.RollbackDataStores("socio_bc",pr_default);
         VarsToRow4( bcSocio) ;
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
         Gx_mode = bcSocio.gxTpr_Mode;
         return Gx_mode ;
      }

      public void SetMode( String lMode )
      {
         Gx_mode = lMode;
         bcSocio.gxTpr_Mode = Gx_mode;
         return  ;
      }

      public void SetSDT( GxSilentTrnSdt sdt ,
                          short sdtToBc )
      {
         if ( sdt != bcSocio )
         {
            bcSocio = (SdtSocio)(sdt);
            if ( StringUtil.StrCmp(bcSocio.gxTpr_Mode, "") == 0 )
            {
               bcSocio.gxTpr_Mode = "INS";
            }
            if ( sdtToBc == 1 )
            {
               VarsToRow4( bcSocio) ;
            }
            else
            {
               RowToVars4( bcSocio, 1) ;
            }
         }
         else
         {
            if ( StringUtil.StrCmp(bcSocio.gxTpr_Mode, "") == 0 )
            {
               bcSocio.gxTpr_Mode = "INS";
            }
         }
         return  ;
      }

      public void ReloadFromSDT( )
      {
         RowToVars4( bcSocio, 1) ;
         return  ;
      }

      public SdtSocio Socio_BC
      {
         get {
            return bcSocio ;
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
         BC00055_A5SocioId = new short[1] ;
         BC00055_A18SocioDireccion = new String[] {""} ;
         BC00055_A19SocioSexo = new String[] {""} ;
         BC00055_A20SocioEdad = new short[1] ;
         BC00055_A33SocioTipoCuota = new String[] {""} ;
         BC00055_A24SocioReconocido = new bool[] {false} ;
         BC00055_A40000SocioFoto_GXI = new String[] {""} ;
         BC00055_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00055_A36CarnetId = new short[1] ;
         BC00055_A21SocioFoto = new String[] {""} ;
         A18SocioDireccion = "";
         A19SocioSexo = "";
         A33SocioTipoCuota = "";
         A40000SocioFoto_GXI = "";
         A37CarnetFechaIngreso = DateTime.MinValue;
         A21SocioFoto = "";
         gx_restcollection = new GXBCCollection<SdtSocio>( context, "Socio", "ObligatorioGenexusGit");
         sMode4 = "";
         Gx_mode = "";
         Z18SocioDireccion = "";
         Z19SocioSexo = "";
         Z33SocioTipoCuota = "";
         Z37CarnetFechaIngreso = DateTime.MinValue;
         Z21SocioFoto = "";
         Z40000SocioFoto_GXI = "";
         BC00056_A5SocioId = new short[1] ;
         BC00056_A18SocioDireccion = new String[] {""} ;
         BC00056_A19SocioSexo = new String[] {""} ;
         BC00056_A20SocioEdad = new short[1] ;
         BC00056_A33SocioTipoCuota = new String[] {""} ;
         BC00056_A24SocioReconocido = new bool[] {false} ;
         BC00056_A40000SocioFoto_GXI = new String[] {""} ;
         BC00056_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00056_A36CarnetId = new short[1] ;
         BC00056_A21SocioFoto = new String[] {""} ;
         BC00054_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC00057_A5SocioId = new short[1] ;
         BC00053_A5SocioId = new short[1] ;
         BC00053_A18SocioDireccion = new String[] {""} ;
         BC00053_A19SocioSexo = new String[] {""} ;
         BC00053_A20SocioEdad = new short[1] ;
         BC00053_A33SocioTipoCuota = new String[] {""} ;
         BC00053_A24SocioReconocido = new bool[] {false} ;
         BC00053_A40000SocioFoto_GXI = new String[] {""} ;
         BC00053_A36CarnetId = new short[1] ;
         BC00053_A21SocioFoto = new String[] {""} ;
         BC00052_A5SocioId = new short[1] ;
         BC00052_A18SocioDireccion = new String[] {""} ;
         BC00052_A19SocioSexo = new String[] {""} ;
         BC00052_A20SocioEdad = new short[1] ;
         BC00052_A33SocioTipoCuota = new String[] {""} ;
         BC00052_A24SocioReconocido = new bool[] {false} ;
         BC00052_A40000SocioFoto_GXI = new String[] {""} ;
         BC00052_A36CarnetId = new short[1] ;
         BC00052_A21SocioFoto = new String[] {""} ;
         BC000512_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC000513_A3ClaseId = new short[1] ;
         BC000513_A5SocioId = new short[1] ;
         BC000514_A5SocioId = new short[1] ;
         BC000514_A18SocioDireccion = new String[] {""} ;
         BC000514_A19SocioSexo = new String[] {""} ;
         BC000514_A20SocioEdad = new short[1] ;
         BC000514_A33SocioTipoCuota = new String[] {""} ;
         BC000514_A24SocioReconocido = new bool[] {false} ;
         BC000514_A40000SocioFoto_GXI = new String[] {""} ;
         BC000514_A37CarnetFechaIngreso = new DateTime[] {DateTime.MinValue} ;
         BC000514_A36CarnetId = new short[1] ;
         BC000514_A21SocioFoto = new String[] {""} ;
         BackMsgLst = new msglist();
         LclMsgLst = new msglist();
         pr_default = new DataStoreProvider(context, new GeneXus.Programs.socio_bc__default(),
            new Object[][] {
                new Object[] {
               BC00052_A5SocioId, BC00052_A18SocioDireccion, BC00052_A19SocioSexo, BC00052_A20SocioEdad, BC00052_A33SocioTipoCuota, BC00052_A24SocioReconocido, BC00052_A40000SocioFoto_GXI, BC00052_A36CarnetId, BC00052_A21SocioFoto
               }
               , new Object[] {
               BC00053_A5SocioId, BC00053_A18SocioDireccion, BC00053_A19SocioSexo, BC00053_A20SocioEdad, BC00053_A33SocioTipoCuota, BC00053_A24SocioReconocido, BC00053_A40000SocioFoto_GXI, BC00053_A36CarnetId, BC00053_A21SocioFoto
               }
               , new Object[] {
               BC00054_A37CarnetFechaIngreso
               }
               , new Object[] {
               BC00055_A5SocioId, BC00055_A18SocioDireccion, BC00055_A19SocioSexo, BC00055_A20SocioEdad, BC00055_A33SocioTipoCuota, BC00055_A24SocioReconocido, BC00055_A40000SocioFoto_GXI, BC00055_A37CarnetFechaIngreso, BC00055_A36CarnetId, BC00055_A21SocioFoto
               }
               , new Object[] {
               BC00056_A5SocioId, BC00056_A18SocioDireccion, BC00056_A19SocioSexo, BC00056_A20SocioEdad, BC00056_A33SocioTipoCuota, BC00056_A24SocioReconocido, BC00056_A40000SocioFoto_GXI, BC00056_A37CarnetFechaIngreso, BC00056_A36CarnetId, BC00056_A21SocioFoto
               }
               , new Object[] {
               BC00057_A5SocioId
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
               BC000512_A37CarnetFechaIngreso
               }
               , new Object[] {
               BC000513_A3ClaseId, BC000513_A5SocioId
               }
               , new Object[] {
               BC000514_A5SocioId, BC000514_A18SocioDireccion, BC000514_A19SocioSexo, BC000514_A20SocioEdad, BC000514_A33SocioTipoCuota, BC000514_A24SocioReconocido, BC000514_A40000SocioFoto_GXI, BC000514_A37CarnetFechaIngreso, BC000514_A36CarnetId, BC000514_A21SocioFoto
               }
            }
         );
         A5SocioId = new ultimoidsocio(context).executeUdp( );
         Z5SocioId = new ultimoidsocio(context).executeUdp( );
         Z32SocioMonto = 2500;
         A32SocioMonto = 2500;
         i32SocioMonto = 2500;
         INITTRN();
         /* Execute Start event if defined. */
         /* Execute user event: Start */
         E12052 ();
         standaloneNotModal( ) ;
      }

      private short IsConfirmed ;
      private short IsModified ;
      private short AnyError ;
      private short nKeyPressed ;
      private short RcdFound4 ;
      private short A5SocioId ;
      private short A20SocioEdad ;
      private short A36CarnetId ;
      private short Z5SocioId ;
      private short GX_JID ;
      private short Z20SocioEdad ;
      private short Z36CarnetId ;
      private short Z32SocioMonto ;
      private short A32SocioMonto ;
      private short Gx_BScreen ;
      private short GXt_int1 ;
      private short i32SocioMonto ;
      private int trnEnded ;
      private int Start ;
      private int Count ;
      private int GXPagingFrom4 ;
      private int GXPagingTo4 ;
      private String scmdbuf ;
      private String PreviousTooltip ;
      private String PreviousCaption ;
      private String A19SocioSexo ;
      private String A33SocioTipoCuota ;
      private String sMode4 ;
      private String Gx_mode ;
      private String Z19SocioSexo ;
      private String Z33SocioTipoCuota ;
      private DateTime A37CarnetFechaIngreso ;
      private DateTime Z37CarnetFechaIngreso ;
      private bool A24SocioReconocido ;
      private bool Z24SocioReconocido ;
      private bool Gx_longc ;
      private String A18SocioDireccion ;
      private String A40000SocioFoto_GXI ;
      private String Z18SocioDireccion ;
      private String Z40000SocioFoto_GXI ;
      private String A21SocioFoto ;
      private String Z21SocioFoto ;
      private GXBCCollection<SdtSocio> gx_restcollection ;
      private SdtSocio bcSocio ;
      private SdtSocio gx_sdt_item ;
      private IGxDataStore dsDefault ;
      private IDataStoreProvider pr_default ;
      private short[] BC00055_A5SocioId ;
      private String[] BC00055_A18SocioDireccion ;
      private String[] BC00055_A19SocioSexo ;
      private short[] BC00055_A20SocioEdad ;
      private String[] BC00055_A33SocioTipoCuota ;
      private bool[] BC00055_A24SocioReconocido ;
      private String[] BC00055_A40000SocioFoto_GXI ;
      private DateTime[] BC00055_A37CarnetFechaIngreso ;
      private short[] BC00055_A36CarnetId ;
      private String[] BC00055_A21SocioFoto ;
      private short[] BC00056_A5SocioId ;
      private String[] BC00056_A18SocioDireccion ;
      private String[] BC00056_A19SocioSexo ;
      private short[] BC00056_A20SocioEdad ;
      private String[] BC00056_A33SocioTipoCuota ;
      private bool[] BC00056_A24SocioReconocido ;
      private String[] BC00056_A40000SocioFoto_GXI ;
      private DateTime[] BC00056_A37CarnetFechaIngreso ;
      private short[] BC00056_A36CarnetId ;
      private String[] BC00056_A21SocioFoto ;
      private DateTime[] BC00054_A37CarnetFechaIngreso ;
      private short[] BC00057_A5SocioId ;
      private short[] BC00053_A5SocioId ;
      private String[] BC00053_A18SocioDireccion ;
      private String[] BC00053_A19SocioSexo ;
      private short[] BC00053_A20SocioEdad ;
      private String[] BC00053_A33SocioTipoCuota ;
      private bool[] BC00053_A24SocioReconocido ;
      private String[] BC00053_A40000SocioFoto_GXI ;
      private short[] BC00053_A36CarnetId ;
      private String[] BC00053_A21SocioFoto ;
      private short[] BC00052_A5SocioId ;
      private String[] BC00052_A18SocioDireccion ;
      private String[] BC00052_A19SocioSexo ;
      private short[] BC00052_A20SocioEdad ;
      private String[] BC00052_A33SocioTipoCuota ;
      private bool[] BC00052_A24SocioReconocido ;
      private String[] BC00052_A40000SocioFoto_GXI ;
      private short[] BC00052_A36CarnetId ;
      private String[] BC00052_A21SocioFoto ;
      private DateTime[] BC000512_A37CarnetFechaIngreso ;
      private short[] BC000513_A3ClaseId ;
      private short[] BC000513_A5SocioId ;
      private short[] BC000514_A5SocioId ;
      private String[] BC000514_A18SocioDireccion ;
      private String[] BC000514_A19SocioSexo ;
      private short[] BC000514_A20SocioEdad ;
      private String[] BC000514_A33SocioTipoCuota ;
      private bool[] BC000514_A24SocioReconocido ;
      private String[] BC000514_A40000SocioFoto_GXI ;
      private DateTime[] BC000514_A37CarnetFechaIngreso ;
      private short[] BC000514_A36CarnetId ;
      private String[] BC000514_A21SocioFoto ;
      private msglist BackMsgLst ;
      private msglist LclMsgLst ;
   }

   public class socio_bc__default : DataStoreHelperBase, IDataStoreHelper
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
          Object[] prmBC00055 ;
          prmBC00055 = new Object[] {
          new Object[] {"@GXPagingFrom4",SqlDbType.Int,9,0} ,
          new Object[] {"@GXPagingTo4",SqlDbType.Int,9,0}
          } ;
          Object[] prmBC00056 ;
          prmBC00056 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00054 ;
          prmBC00054 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00057 ;
          prmBC00057 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00053 ;
          prmBC00053 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00052 ;
          prmBC00052 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00058 ;
          prmBC00058 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@SocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@SocioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@SocioFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC00059 ;
          prmBC00059 = new Object[] {
          new Object[] {"@SocioDireccion",SqlDbType.VarChar,1024,0} ,
          new Object[] {"@SocioSexo",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioEdad",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioTipoCuota",SqlDbType.Char,20,0} ,
          new Object[] {"@SocioReconocido",SqlDbType.Bit,4,0} ,
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000510 ;
          prmBC000510 = new Object[] {
          new Object[] {"@SocioFoto",SqlDbType.VarBinary,1024,0} ,
          new Object[] {"@SocioFoto_GXI",SqlDbType.VarChar,2048,0} ,
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000511 ;
          prmBC000511 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000512 ;
          prmBC000512 = new Object[] {
          new Object[] {"@CarnetId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000513 ;
          prmBC000513 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          Object[] prmBC000514 ;
          prmBC000514 = new Object[] {
          new Object[] {"@SocioId",SqlDbType.SmallInt,4,0}
          } ;
          def= new CursorDef[] {
              new CursorDef("BC00052", "SELECT [SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioTipoCuota], [SocioReconocido], [SocioFoto_GXI], [CarnetId], [SocioFoto] FROM [Socio] WITH (UPDLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00052,1,0,true,false )
             ,new CursorDef("BC00053", "SELECT [SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioTipoCuota], [SocioReconocido], [SocioFoto_GXI], [CarnetId], [SocioFoto] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00053,1,0,true,false )
             ,new CursorDef("BC00054", "SELECT [CarnetFechaIngreso] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC00054,1,0,true,false )
             ,new CursorDef("BC00055", "SELECT TM1.[SocioId], TM1.[SocioDireccion], TM1.[SocioSexo], TM1.[SocioEdad], TM1.[SocioTipoCuota], TM1.[SocioReconocido], TM1.[SocioFoto_GXI], T2.[CarnetFechaIngreso], TM1.[CarnetId], TM1.[SocioFoto] FROM ([Socio] TM1 WITH (NOLOCK) INNER JOIN [Carnet] T2 WITH (NOLOCK) ON T2.[CarnetId] = TM1.[CarnetId]) ORDER BY TM1.[SocioId]  OFFSET @GXPagingFrom4 ROWS FETCH NEXT CAST((SELECT CASE WHEN @GXPagingTo4 > 0 THEN @GXPagingTo4 ELSE 1e9 END) AS INTEGER) ROWS ONLY",true, GxErrorMask.GX_NOMASK, false, this,prmBC00055,100,0,true,false )
             ,new CursorDef("BC00056", "SELECT TM1.[SocioId], TM1.[SocioDireccion], TM1.[SocioSexo], TM1.[SocioEdad], TM1.[SocioTipoCuota], TM1.[SocioReconocido], TM1.[SocioFoto_GXI], T2.[CarnetFechaIngreso], TM1.[CarnetId], TM1.[SocioFoto] FROM ([Socio] TM1 WITH (NOLOCK) INNER JOIN [Carnet] T2 WITH (NOLOCK) ON T2.[CarnetId] = TM1.[CarnetId]) WHERE TM1.[SocioId] = @SocioId ORDER BY TM1.[SocioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00056,100,0,true,false )
             ,new CursorDef("BC00057", "SELECT [SocioId] FROM [Socio] WITH (NOLOCK) WHERE [SocioId] = @SocioId  OPTION (FAST 1)",true, GxErrorMask.GX_NOMASK, false, this,prmBC00057,1,0,true,false )
             ,new CursorDef("BC00058", "INSERT INTO [Socio]([SocioId], [SocioDireccion], [SocioSexo], [SocioEdad], [SocioTipoCuota], [SocioReconocido], [SocioFoto], [SocioFoto_GXI], [CarnetId]) VALUES(@SocioId, @SocioDireccion, @SocioSexo, @SocioEdad, @SocioTipoCuota, @SocioReconocido, @SocioFoto, @SocioFoto_GXI, @CarnetId)", GxErrorMask.GX_NOMASK,prmBC00058)
             ,new CursorDef("BC00059", "UPDATE [Socio] SET [SocioDireccion]=@SocioDireccion, [SocioSexo]=@SocioSexo, [SocioEdad]=@SocioEdad, [SocioTipoCuota]=@SocioTipoCuota, [SocioReconocido]=@SocioReconocido, [CarnetId]=@CarnetId  WHERE [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmBC00059)
             ,new CursorDef("BC000510", "UPDATE [Socio] SET [SocioFoto]=@SocioFoto, [SocioFoto_GXI]=@SocioFoto_GXI  WHERE [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmBC000510)
             ,new CursorDef("BC000511", "DELETE FROM [Socio]  WHERE [SocioId] = @SocioId", GxErrorMask.GX_NOMASK,prmBC000511)
             ,new CursorDef("BC000512", "SELECT [CarnetFechaIngreso] FROM [Carnet] WITH (NOLOCK) WHERE [CarnetId] = @CarnetId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000512,1,0,true,false )
             ,new CursorDef("BC000513", "SELECT TOP 1 [ClaseId], [SocioId] FROM [ClaseSocios] WITH (NOLOCK) WHERE [SocioId] = @SocioId ",true, GxErrorMask.GX_NOMASK, false, this,prmBC000513,1,0,true,true )
             ,new CursorDef("BC000514", "SELECT TM1.[SocioId], TM1.[SocioDireccion], TM1.[SocioSexo], TM1.[SocioEdad], TM1.[SocioTipoCuota], TM1.[SocioReconocido], TM1.[SocioFoto_GXI], T2.[CarnetFechaIngreso], TM1.[CarnetId], TM1.[SocioFoto] FROM ([Socio] TM1 WITH (NOLOCK) INNER JOIN [Carnet] T2 WITH (NOLOCK) ON T2.[CarnetId] = TM1.[CarnetId]) WHERE TM1.[SocioId] = @SocioId ORDER BY TM1.[SocioId]  OPTION (FAST 100)",true, GxErrorMask.GX_NOMASK, false, this,prmBC000514,100,0,true,false )
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
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(7)) ;
                return;
             case 1 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((short[]) buf[7])[0] = rslt.getShort(8) ;
                ((String[]) buf[8])[0] = rslt.getMultimediaFile(9, rslt.getVarchar(7)) ;
                return;
             case 2 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 3 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
                return;
             case 4 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
                return;
             case 5 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                return;
             case 10 :
                ((DateTime[]) buf[0])[0] = rslt.getGXDate(1) ;
                return;
             case 11 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((short[]) buf[1])[0] = rslt.getShort(2) ;
                return;
             case 12 :
                ((short[]) buf[0])[0] = rslt.getShort(1) ;
                ((String[]) buf[1])[0] = rslt.getVarchar(2) ;
                ((String[]) buf[2])[0] = rslt.getString(3, 20) ;
                ((short[]) buf[3])[0] = rslt.getShort(4) ;
                ((String[]) buf[4])[0] = rslt.getString(5, 20) ;
                ((bool[]) buf[5])[0] = rslt.getBool(6) ;
                ((String[]) buf[6])[0] = rslt.getMultimediaUri(7) ;
                ((DateTime[]) buf[7])[0] = rslt.getGXDate(8) ;
                ((short[]) buf[8])[0] = rslt.getShort(9) ;
                ((String[]) buf[9])[0] = rslt.getMultimediaFile(10, rslt.getVarchar(7)) ;
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
                stmt.SetParameter(4, (short)parms[3]);
                stmt.SetParameter(5, (String)parms[4]);
                stmt.SetParameter(6, (bool)parms[5]);
                stmt.SetParameterBlob(7, (String)parms[6], false);
                stmt.SetParameterMultimedia(8, (String)parms[7], (String)parms[6], "Socio", "SocioFoto");
                stmt.SetParameter(9, (short)parms[8]);
                return;
             case 7 :
                stmt.SetParameter(1, (String)parms[0]);
                stmt.SetParameter(2, (String)parms[1]);
                stmt.SetParameter(3, (short)parms[2]);
                stmt.SetParameter(4, (String)parms[3]);
                stmt.SetParameter(5, (bool)parms[4]);
                stmt.SetParameter(6, (short)parms[5]);
                stmt.SetParameter(7, (short)parms[6]);
                return;
             case 8 :
                stmt.SetParameterBlob(1, (String)parms[0], false);
                stmt.SetParameterMultimedia(2, (String)parms[1], (String)parms[0], "Socio", "SocioFoto");
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

 [ServiceContract(Namespace = "GeneXus.Programs.socio_bc_services")]
 [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
 [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
 public class socio_bc_services : GxRestService
 {
    [OperationContract]
    [WebInvoke(Method =  "GET" ,
    	BodyStyle =  WebMessageBodyStyle.Bare  ,
    	ResponseFormat = WebMessageFormat.Json,
    	UriTemplate = "/{sA5SocioId}")]
    public SdtSocio_RESTInterface Load( string sA5SocioId )
    {
       try
       {
          short A5SocioId ;
          A5SocioId = (short)(NumberUtil.Val( (String)(sA5SocioId), "."));
          SdtSocio worker = new SdtSocio(context) ;
          SdtSocio_RESTInterface worker_interface = new SdtSocio_RESTInterface (worker);
          if ( StringUtil.StrCmp(sA5SocioId, "_default") == 0 )
          {
             IGxSilentTrn workertrn = worker.getTransaction() ;
             workertrn.GetInsDefault();
          }
          else
          {
             worker.Load(A5SocioId);
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
    	UriTemplate = "/{sA5SocioId}")]
    public SdtSocio_RESTInterface Delete( string sA5SocioId )
    {
       try
       {
          short A5SocioId ;
          A5SocioId = (short)(NumberUtil.Val( (String)(sA5SocioId), "."));
          SdtSocio worker = new SdtSocio(context) ;
          SdtSocio_RESTInterface worker_interface = new SdtSocio_RESTInterface (worker);
          worker.Load(A5SocioId);
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
    	UriTemplate = "/{sA5SocioId}")]
    public SdtSocio_RESTInterface Insert( string sA5SocioId ,
                                          SdtSocio_RESTInterface entity )
    {
       try
       {
          short A5SocioId ;
          A5SocioId = (short)(NumberUtil.Val( (String)(sA5SocioId), "."));
          SdtSocio worker = new SdtSocio(context) ;
          bool gxcheck = RestParameter("check", "true") ;
          bool gxinsertorupdate = RestParameter("insertorupdate", "true") ;
          SdtSocio_RESTInterface worker_interface = new SdtSocio_RESTInterface (worker);
          worker_interface.CopyFrom(entity);
          worker.gxTpr_Socioid = A5SocioId;
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
    	UriTemplate = "/{sA5SocioId}")]
    public SdtSocio_RESTInterface Update( string sA5SocioId ,
                                          SdtSocio_RESTInterface entity )
    {
       try
       {
          short A5SocioId ;
          A5SocioId = (short)(NumberUtil.Val( (String)(sA5SocioId), "."));
          SdtSocio worker = new SdtSocio(context) ;
          SdtSocio_RESTInterface worker_interface = new SdtSocio_RESTInterface (worker);
          bool gxcheck = RestParameter("check", "true") ;
          worker.Load(A5SocioId);
          if (entity.Hash == worker_interface.Hash) {
             worker_interface.CopyFrom(entity);
             worker.gxTpr_Socioid = A5SocioId;
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
             SetError( "409", (( GXHttpHandler )worker.trn). context.GetMessage( "GXM_waschg", new   object[]  {"Socio"}) );
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
