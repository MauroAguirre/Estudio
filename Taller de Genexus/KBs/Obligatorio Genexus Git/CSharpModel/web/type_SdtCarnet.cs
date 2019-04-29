/*
               File: type_SdtCarnet
        Description: Carnet
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:33.8
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
using GeneXus.Encryption;
using GeneXus.Http.Client;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "Carnet" )]
   [XmlType(TypeName =  "Carnet" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtCarnet : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCarnet( )
      {
      }

      public SdtCarnet( IGxContext context )
      {
         this.context = context;
         constructorCallingAssembly = Assembly.GetCallingAssembly();
         initialize();
      }

      private static Hashtable mapper;
      public override String JsonMap( String value )
      {
         if ( mapper == null )
         {
            mapper = new Hashtable();
         }
         return (String)mapper[value]; ;
      }

      public void Load( short AV36CarnetId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV36CarnetId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"CarnetId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Carnet");
         metadata.Set("BT", "Carnet");
         metadata.Set("PK", "[ \"CarnetId\" ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Carnetid_Z");
         state.Add("gxTpr_Carnetfechaingreso_Z_Nullable");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtCarnet sdt ;
         sdt = (SdtCarnet)(source);
         gxTv_SdtCarnet_Carnetid = sdt.gxTv_SdtCarnet_Carnetid ;
         gxTv_SdtCarnet_Carnetfechaingreso = sdt.gxTv_SdtCarnet_Carnetfechaingreso ;
         gxTv_SdtCarnet_Mode = sdt.gxTv_SdtCarnet_Mode ;
         gxTv_SdtCarnet_Initialized = sdt.gxTv_SdtCarnet_Initialized ;
         gxTv_SdtCarnet_Carnetid_Z = sdt.gxTv_SdtCarnet_Carnetid_Z ;
         gxTv_SdtCarnet_Carnetfechaingreso_Z = sdt.gxTv_SdtCarnet_Carnetfechaingreso_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("CarnetId", gxTv_SdtCarnet_Carnetid, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCarnet_Carnetfechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCarnet_Carnetfechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCarnet_Carnetfechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("CarnetFechaIngreso", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtCarnet_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtCarnet_Initialized, false);
            AddObjectProperty("CarnetId_Z", gxTv_SdtCarnet_Carnetid_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCarnet_Carnetfechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCarnet_Carnetfechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCarnet_Carnetfechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("CarnetFechaIngreso_Z", sDateCnv, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtCarnet sdt )
      {
         if ( sdt.IsDirty("CarnetId") )
         {
            gxTv_SdtCarnet_Carnetid = sdt.gxTv_SdtCarnet_Carnetid ;
         }
         if ( sdt.IsDirty("CarnetFechaIngreso") )
         {
            gxTv_SdtCarnet_Carnetfechaingreso = sdt.gxTv_SdtCarnet_Carnetfechaingreso ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "CarnetId" )]
      [  XmlElement( ElementName = "CarnetId"   )]
      public short gxTpr_Carnetid
      {
         get {
            return gxTv_SdtCarnet_Carnetid ;
         }

         set {
            if ( gxTv_SdtCarnet_Carnetid != value )
            {
               gxTv_SdtCarnet_Mode = "INS";
               this.gxTv_SdtCarnet_Carnetid_Z_SetNull( );
               this.gxTv_SdtCarnet_Carnetfechaingreso_Z_SetNull( );
            }
            gxTv_SdtCarnet_Carnetid = value;
            SetDirty("Carnetid");
         }

      }

      [  SoapElement( ElementName = "CarnetFechaIngreso" )]
      [  XmlElement( ElementName = "CarnetFechaIngreso"  , IsNullable=true )]
      public string gxTpr_Carnetfechaingreso_Nullable
      {
         get {
            if ( gxTv_SdtCarnet_Carnetfechaingreso == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtCarnet_Carnetfechaingreso).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtCarnet_Carnetfechaingreso = DateTime.MinValue;
            else
               gxTv_SdtCarnet_Carnetfechaingreso = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Carnetfechaingreso
      {
         get {
            return gxTv_SdtCarnet_Carnetfechaingreso ;
         }

         set {
            gxTv_SdtCarnet_Carnetfechaingreso = value;
            SetDirty("Carnetfechaingreso");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtCarnet_Mode ;
         }

         set {
            gxTv_SdtCarnet_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtCarnet_Mode_SetNull( )
      {
         gxTv_SdtCarnet_Mode = "";
         return  ;
      }

      public bool gxTv_SdtCarnet_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtCarnet_Initialized ;
         }

         set {
            gxTv_SdtCarnet_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtCarnet_Initialized_SetNull( )
      {
         gxTv_SdtCarnet_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtCarnet_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarnetId_Z" )]
      [  XmlElement( ElementName = "CarnetId_Z"   )]
      public short gxTpr_Carnetid_Z
      {
         get {
            return gxTv_SdtCarnet_Carnetid_Z ;
         }

         set {
            gxTv_SdtCarnet_Carnetid_Z = value;
            SetDirty("Carnetid_Z");
         }

      }

      public void gxTv_SdtCarnet_Carnetid_Z_SetNull( )
      {
         gxTv_SdtCarnet_Carnetid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtCarnet_Carnetid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarnetFechaIngreso_Z" )]
      [  XmlElement( ElementName = "CarnetFechaIngreso_Z"  , IsNullable=true )]
      public string gxTpr_Carnetfechaingreso_Z_Nullable
      {
         get {
            if ( gxTv_SdtCarnet_Carnetfechaingreso_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtCarnet_Carnetfechaingreso_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtCarnet_Carnetfechaingreso_Z = DateTime.MinValue;
            else
               gxTv_SdtCarnet_Carnetfechaingreso_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Carnetfechaingreso_Z
      {
         get {
            return gxTv_SdtCarnet_Carnetfechaingreso_Z ;
         }

         set {
            gxTv_SdtCarnet_Carnetfechaingreso_Z = value;
            SetDirty("Carnetfechaingreso_Z");
         }

      }

      public void gxTv_SdtCarnet_Carnetfechaingreso_Z_SetNull( )
      {
         gxTv_SdtCarnet_Carnetfechaingreso_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtCarnet_Carnetfechaingreso_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtCarnet_Carnetfechaingreso = DateTime.MinValue;
         gxTv_SdtCarnet_Mode = "";
         gxTv_SdtCarnet_Carnetfechaingreso_Z = DateTime.MinValue;
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "carnet", "GeneXus.Programs.carnet_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtCarnet_Carnetid ;
      private short gxTv_SdtCarnet_Initialized ;
      private short gxTv_SdtCarnet_Carnetid_Z ;
      private String gxTv_SdtCarnet_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtCarnet_Carnetfechaingreso ;
      private DateTime gxTv_SdtCarnet_Carnetfechaingreso_Z ;
   }

   [DataContract(Name = @"Carnet", Namespace = "ObligatorioGenexusGit")]
   public class SdtCarnet_RESTInterface : GxGenericCollectionItem<SdtCarnet>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCarnet_RESTInterface( ) : base()
      {
      }

      public SdtCarnet_RESTInterface( SdtCarnet psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CarnetId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Carnetid
      {
         get {
            return sdt.gxTpr_Carnetid ;
         }

         set {
            sdt.gxTpr_Carnetid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "CarnetFechaIngreso" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Carnetfechaingreso
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Carnetfechaingreso) ;
         }

         set {
            sdt.gxTpr_Carnetfechaingreso = DateTimeUtil.CToD2( value);
         }

      }

      public SdtCarnet sdt
      {
         get {
            return (SdtCarnet)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtCarnet() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 2 )]
      public string Hash
      {
         get {
            if ( StringUtil.StrCmp(md5Hash, null) == 0 )
            {
               md5Hash = (String)(getHash());
            }
            return md5Hash ;
         }

         set {
            md5Hash = value ;
         }

      }

      private String md5Hash ;
   }

   [DataContract(Name = @"Carnet", Namespace = "ObligatorioGenexusGit")]
   public class SdtCarnet_RESTLInterface : GxGenericCollectionItem<SdtCarnet>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCarnet_RESTLInterface( ) : base()
      {
      }

      public SdtCarnet_RESTLInterface( SdtCarnet psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CarnetId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Carnetid
      {
         get {
            return sdt.gxTpr_Carnetid ;
         }

         set {
            sdt.gxTpr_Carnetid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            String gxuri = "/rest/Carnet/{0}" ;
            gxuri = String.Format(gxuri,gxTpr_Carnetid) ;
            return gxuri ;
         }

         set {
         }

      }

      public SdtCarnet sdt
      {
         get {
            return (SdtCarnet)Sdt ;
         }

         set {
            Sdt = value ;
         }

      }

      [OnDeserializing]
      void checkSdt( StreamingContext ctx )
      {
         if ( sdt == null )
         {
            sdt = new SdtCarnet() ;
         }
      }

      private String gxuri ;
   }

}
