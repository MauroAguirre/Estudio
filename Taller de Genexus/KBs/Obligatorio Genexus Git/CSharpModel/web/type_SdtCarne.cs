/*
               File: type_SdtCarne
        Description: Carne
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 5:22:32.78
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
using System.Runtime.Serialization;
namespace GeneXus.Programs {
   [XmlSerializerFormat]
   [XmlRoot(ElementName = "Carne" )]
   [XmlType(TypeName =  "Carne" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtCarne : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCarne( )
      {
      }

      public SdtCarne( IGxContext context )
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

      public void Load( short AV4CarneId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV4CarneId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"CarneId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Carne");
         metadata.Set("BT", "Carne");
         metadata.Set("PK", "[ \"CarneId\" ]");
         metadata.Set("PKAssigned", "[ \"CarneId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"SocioId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Carneid_Z");
         state.Add("gxTpr_Carnefechaingreso_Z_Nullable");
         state.Add("gxTpr_Socioid_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtCarne sdt ;
         sdt = (SdtCarne)(source);
         gxTv_SdtCarne_Carneid = sdt.gxTv_SdtCarne_Carneid ;
         gxTv_SdtCarne_Carnefechaingreso = sdt.gxTv_SdtCarne_Carnefechaingreso ;
         gxTv_SdtCarne_Socioid = sdt.gxTv_SdtCarne_Socioid ;
         gxTv_SdtCarne_Mode = sdt.gxTv_SdtCarne_Mode ;
         gxTv_SdtCarne_Initialized = sdt.gxTv_SdtCarne_Initialized ;
         gxTv_SdtCarne_Carneid_Z = sdt.gxTv_SdtCarne_Carneid_Z ;
         gxTv_SdtCarne_Carnefechaingreso_Z = sdt.gxTv_SdtCarne_Carnefechaingreso_Z ;
         gxTv_SdtCarne_Socioid_Z = sdt.gxTv_SdtCarne_Socioid_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("CarneId", gxTv_SdtCarne_Carneid, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCarne_Carnefechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCarne_Carnefechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCarne_Carnefechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("CarneFechaIngreso", sDateCnv, false);
         AddObjectProperty("SocioId", gxTv_SdtCarne_Socioid, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtCarne_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtCarne_Initialized, false);
            AddObjectProperty("CarneId_Z", gxTv_SdtCarne_Carneid_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtCarne_Carnefechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtCarne_Carnefechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtCarne_Carnefechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("CarneFechaIngreso_Z", sDateCnv, false);
            AddObjectProperty("SocioId_Z", gxTv_SdtCarne_Socioid_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtCarne sdt )
      {
         if ( sdt.IsDirty("CarneId") )
         {
            gxTv_SdtCarne_Carneid = sdt.gxTv_SdtCarne_Carneid ;
         }
         if ( sdt.IsDirty("CarneFechaIngreso") )
         {
            gxTv_SdtCarne_Carnefechaingreso = sdt.gxTv_SdtCarne_Carnefechaingreso ;
         }
         if ( sdt.IsDirty("SocioId") )
         {
            gxTv_SdtCarne_Socioid = sdt.gxTv_SdtCarne_Socioid ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "CarneId" )]
      [  XmlElement( ElementName = "CarneId"   )]
      public short gxTpr_Carneid
      {
         get {
            return gxTv_SdtCarne_Carneid ;
         }

         set {
            if ( gxTv_SdtCarne_Carneid != value )
            {
               gxTv_SdtCarne_Mode = "INS";
               this.gxTv_SdtCarne_Carneid_Z_SetNull( );
               this.gxTv_SdtCarne_Carnefechaingreso_Z_SetNull( );
               this.gxTv_SdtCarne_Socioid_Z_SetNull( );
            }
            gxTv_SdtCarne_Carneid = value;
            SetDirty("Carneid");
         }

      }

      [  SoapElement( ElementName = "CarneFechaIngreso" )]
      [  XmlElement( ElementName = "CarneFechaIngreso"  , IsNullable=true )]
      public string gxTpr_Carnefechaingreso_Nullable
      {
         get {
            if ( gxTv_SdtCarne_Carnefechaingreso == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtCarne_Carnefechaingreso).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtCarne_Carnefechaingreso = DateTime.MinValue;
            else
               gxTv_SdtCarne_Carnefechaingreso = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Carnefechaingreso
      {
         get {
            return gxTv_SdtCarne_Carnefechaingreso ;
         }

         set {
            gxTv_SdtCarne_Carnefechaingreso = value;
            SetDirty("Carnefechaingreso");
         }

      }

      [  SoapElement( ElementName = "SocioId" )]
      [  XmlElement( ElementName = "SocioId"   )]
      public short gxTpr_Socioid
      {
         get {
            return gxTv_SdtCarne_Socioid ;
         }

         set {
            gxTv_SdtCarne_Socioid = value;
            SetDirty("Socioid");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtCarne_Mode ;
         }

         set {
            gxTv_SdtCarne_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtCarne_Mode_SetNull( )
      {
         gxTv_SdtCarne_Mode = "";
         return  ;
      }

      public bool gxTv_SdtCarne_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtCarne_Initialized ;
         }

         set {
            gxTv_SdtCarne_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtCarne_Initialized_SetNull( )
      {
         gxTv_SdtCarne_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtCarne_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarneId_Z" )]
      [  XmlElement( ElementName = "CarneId_Z"   )]
      public short gxTpr_Carneid_Z
      {
         get {
            return gxTv_SdtCarne_Carneid_Z ;
         }

         set {
            gxTv_SdtCarne_Carneid_Z = value;
            SetDirty("Carneid_Z");
         }

      }

      public void gxTv_SdtCarne_Carneid_Z_SetNull( )
      {
         gxTv_SdtCarne_Carneid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtCarne_Carneid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarneFechaIngreso_Z" )]
      [  XmlElement( ElementName = "CarneFechaIngreso_Z"  , IsNullable=true )]
      public string gxTpr_Carnefechaingreso_Z_Nullable
      {
         get {
            if ( gxTv_SdtCarne_Carnefechaingreso_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtCarne_Carnefechaingreso_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtCarne_Carnefechaingreso_Z = DateTime.MinValue;
            else
               gxTv_SdtCarne_Carnefechaingreso_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Carnefechaingreso_Z
      {
         get {
            return gxTv_SdtCarne_Carnefechaingreso_Z ;
         }

         set {
            gxTv_SdtCarne_Carnefechaingreso_Z = value;
            SetDirty("Carnefechaingreso_Z");
         }

      }

      public void gxTv_SdtCarne_Carnefechaingreso_Z_SetNull( )
      {
         gxTv_SdtCarne_Carnefechaingreso_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtCarne_Carnefechaingreso_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioId_Z" )]
      [  XmlElement( ElementName = "SocioId_Z"   )]
      public short gxTpr_Socioid_Z
      {
         get {
            return gxTv_SdtCarne_Socioid_Z ;
         }

         set {
            gxTv_SdtCarne_Socioid_Z = value;
            SetDirty("Socioid_Z");
         }

      }

      public void gxTv_SdtCarne_Socioid_Z_SetNull( )
      {
         gxTv_SdtCarne_Socioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtCarne_Socioid_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtCarne_Carnefechaingreso = DateTime.MinValue;
         gxTv_SdtCarne_Mode = "";
         gxTv_SdtCarne_Carnefechaingreso_Z = DateTime.MinValue;
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "carne", "GeneXus.Programs.carne_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtCarne_Carneid ;
      private short gxTv_SdtCarne_Socioid ;
      private short gxTv_SdtCarne_Initialized ;
      private short gxTv_SdtCarne_Carneid_Z ;
      private short gxTv_SdtCarne_Socioid_Z ;
      private String gxTv_SdtCarne_Mode ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtCarne_Carnefechaingreso ;
      private DateTime gxTv_SdtCarne_Carnefechaingreso_Z ;
   }

   [DataContract(Name = @"Carne", Namespace = "ObligatorioGenexusGit")]
   public class SdtCarne_RESTInterface : GxGenericCollectionItem<SdtCarne>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtCarne_RESTInterface( ) : base()
      {
      }

      public SdtCarne_RESTInterface( SdtCarne psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "CarneId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Carneid
      {
         get {
            return sdt.gxTpr_Carneid ;
         }

         set {
            sdt.gxTpr_Carneid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "CarneFechaIngreso" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Carnefechaingreso
      {
         get {
            return DateTimeUtil.DToC2( sdt.gxTpr_Carnefechaingreso) ;
         }

         set {
            sdt.gxTpr_Carnefechaingreso = DateTimeUtil.CToD2( value);
         }

      }

      [DataMember( Name = "SocioId" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Socioid
      {
         get {
            return sdt.gxTpr_Socioid ;
         }

         set {
            sdt.gxTpr_Socioid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtCarne sdt
      {
         get {
            return (SdtCarne)Sdt ;
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
            sdt = new SdtCarne() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 3 )]
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

}
