/*
               File: NotificationsRegistrationHandler
        Description: Notifications Registration Handler
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:6:42.84
       Program type: Main program
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
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   public class anotificationsregistrationhandler : GXProcedure
   {
      public anotificationsregistrationhandler( )
      {
         context = new GxContext(  );
         DataStoreUtil.LoadDataStores( context);
         IsMain = true;
         context.SetDefaultTheme("Carmine");
      }

      public anotificationsregistrationhandler( IGxContext context )
      {
         this.context = context;
         IsMain = false;
      }

      public void release( )
      {
      }

      public void execute( short aP0_DeviceType ,
                           String aP1_DeviceId ,
                           String aP2_DeviceToken ,
                           String aP3_DeviceName )
      {
         this.AV11DeviceType = aP0_DeviceType;
         this.AV8DeviceId = aP1_DeviceId;
         this.AV10DeviceToken = aP2_DeviceToken;
         this.AV9DeviceName = aP3_DeviceName;
         initialize();
         executePrivate();
      }

      public void executeSubmit( short aP0_DeviceType ,
                                 String aP1_DeviceId ,
                                 String aP2_DeviceToken ,
                                 String aP3_DeviceName )
      {
         anotificationsregistrationhandler objanotificationsregistrationhandler;
         objanotificationsregistrationhandler = new anotificationsregistrationhandler();
         objanotificationsregistrationhandler.AV11DeviceType = aP0_DeviceType;
         objanotificationsregistrationhandler.AV8DeviceId = aP1_DeviceId;
         objanotificationsregistrationhandler.AV10DeviceToken = aP2_DeviceToken;
         objanotificationsregistrationhandler.AV9DeviceName = aP3_DeviceName;
         objanotificationsregistrationhandler.context.SetSubmitInitialConfig(context);
         objanotificationsregistrationhandler.initialize();
         ThreadPool.QueueUserWorkItem( PropagateCulture(new WaitCallback( executePrivateCatch )),objanotificationsregistrationhandler);
      }

      void executePrivateCatch( object stateInfo )
      {
         try
         {
            ((anotificationsregistrationhandler)stateInfo).executePrivate();
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
         context.StatusMessage( StringUtil.Trim( AV10DeviceToken) );
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

      private short AV11DeviceType ;
      private String AV8DeviceId ;
      private String AV10DeviceToken ;
      private String AV9DeviceName ;
   }

   [ServiceContract(Namespace = "GeneXus.Programs.notificationsregistrationhandler_services")]
   [ServiceBehavior(ConcurrencyMode = ConcurrencyMode.Multiple)]
   [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
   public class notificationsregistrationhandler_services : GxRestService
   {
      [OperationContract]
      [WebInvoke(Method =  "POST" ,
      	BodyStyle =  WebMessageBodyStyle.Wrapped  ,
      	ResponseFormat = WebMessageFormat.Json,
      	UriTemplate = "/")]
      public void execute( short DeviceType ,
                           String DeviceId ,
                           String DeviceToken ,
                           String DeviceName )
      {
         try
         {
            if ( ! ProcessHeaders("notificationsregistrationhandler") )
            {
               return  ;
            }
            anotificationsregistrationhandler worker = new anotificationsregistrationhandler(context) ;
            worker.IsMain = RunAsMain ;
            worker.execute(DeviceType,DeviceId,DeviceToken,DeviceName );
            worker.cleanup( );
         }
         catch ( Exception e )
         {
            WebException(e);
         }
         finally
         {
            Cleanup();
         }
      }

   }

}
