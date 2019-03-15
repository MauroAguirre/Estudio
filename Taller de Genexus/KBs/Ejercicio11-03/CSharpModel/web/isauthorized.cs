/*
               File: IsAuthorized
        Description: Is Authorized
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/14/2019 20:6:59.77
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
using com.genexus;
using GeneXus.Data.ADO;
using GeneXus.Data.NTier;
using GeneXus.Data.NTier.ADO;
using System.Runtime.Remoting;
using GeneXus.WebControls;
using GeneXus.Http;
using GeneXus.Procedure;
using GeneXus.XML;
using GeneXus.Search;
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Threading;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class isauthorized : GXProcedure
   {
      public isauthorized( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public isauthorized( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( String aP0_GxObject ,
                           out bool aP1_Authorized )
      {
         this.GxObject = aP0_GxObject;
         this.AV9Authorized = false ;
         initialize();
         executePrivate();
         aP1_Authorized=this.AV9Authorized;
      }

      public bool executeUdp( String aP0_GxObject )
      {
         this.GxObject = aP0_GxObject;
         this.AV9Authorized = false ;
         initialize();
         executePrivate();
         aP1_Authorized=this.AV9Authorized;
         return AV9Authorized ;
      }

      public void executeSubmit( String aP0_GxObject ,
                                 out bool aP1_Authorized )
      {
         isauthorized objisauthorized;
         objisauthorized = new isauthorized();
         objisauthorized.GxObject = aP0_GxObject;
         objisauthorized.AV9Authorized = false ;
         objisauthorized.context.SetSubmitInitialConfig(context);
         objisauthorized.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objisauthorized);
         aP1_Authorized=this.AV9Authorized;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((isauthorized)stateInfo).executePrivate();
         }
         catch ( Exception e )
         {
            GXUtil.SaveToEventLog( "Design", e);
            throw e ;
         }
      }

      void executePrivate( )
      {
         /* GeneXus formulas */
         /* Output device settings */
         AV9Authorized = true;
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
         exitApplication();
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private bool AV9Authorized ;
      private String GxObject ;
      private bool aP1_Authorized ;
   }

}
