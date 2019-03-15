/*
               File: RPT_Personas
        Description: Stub for RPT_Personas
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 3/14/2019 21:6:14.68
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
using System.Web.Services.Protocols;
using System.Web.Services;
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
   public class rpt_personas : GXProcedure
   {
      public rpt_personas( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         dsDefault = context.GetDataStore("Default");
         IsMain = true;
      }

      public rpt_personas( IGxContext context )
      {
         this.context = context;
         IsMain = false;
         dsDefault = context.GetDataStore("Default");
      }

      public void release( )
      {
      }

      public void execute( ref String aP0_PersonaNombre )
      {
         this.AV2PersonaNombre = aP0_PersonaNombre;
         initialize();
         executePrivate();
         aP0_PersonaNombre=this.AV2PersonaNombre;
      }

      public String executeUdp( )
      {
         this.AV2PersonaNombre = aP0_PersonaNombre;
         initialize();
         executePrivate();
         aP0_PersonaNombre=this.AV2PersonaNombre;
         return AV2PersonaNombre ;
      }

      public void executeSubmit( ref String aP0_PersonaNombre )
      {
         rpt_personas objrpt_personas;
         objrpt_personas = new rpt_personas();
         objrpt_personas.AV2PersonaNombre = aP0_PersonaNombre;
         objrpt_personas.context.SetSubmitInitialConfig(context);
         objrpt_personas.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objrpt_personas);
         aP0_PersonaNombre=this.AV2PersonaNombre;
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((rpt_personas)stateInfo).executePrivate();
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
         args = new Object[] {(String)AV2PersonaNombre} ;
         ClassLoader.Execute("arpt_personas","GeneXus.Programs","arpt_personas", new Object[] {context }, "execute", args);
         if ( ( args != null ) && ( args.Length == 1 ) )
         {
            AV2PersonaNombre = (String)(args[0]) ;
         }
         this.cleanup();
      }

      public override void cleanup( )
      {
         CloseOpenCursors();
         if ( IsMain )
         {
            context.CloseConnections() ;
         }
      }

      protected void CloseOpenCursors( )
      {
      }

      public override void initialize( )
      {
         /* GeneXus formulas. */
         context.Gx_err = 0;
      }

      private String AV2PersonaNombre ;
      private IGxDataStore dsDefault ;
      private String aP0_PersonaNombre ;
      private Object[] args ;
   }

}
