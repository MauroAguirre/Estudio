/*
               File: type_SdtClase_Socios
        Description: Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:40.13
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
   [XmlRoot(ElementName = "Clase.Socios" )]
   [XmlType(TypeName =  "Clase.Socios" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtClase_Socios : GxSilentTrnSdt, IGxSilentTrnGridItem
   {
      public SdtClase_Socios( )
      {
      }

      public SdtClase_Socios( IGxContext context )
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

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SocioId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Socios");
         metadata.Set("BT", "ClaseSocios");
         metadata.Set("PK", "[ \"SocioId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"ClaseId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"SocioId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Sociofoto_gxi");
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Modified");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Socioid_Z");
         state.Add("gxTpr_Socioedad_Z");
         state.Add("gxTpr_Sociodireccion_Z");
         state.Add("gxTpr_Sociofoto_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtClase_Socios sdt ;
         sdt = (SdtClase_Socios)(source);
         gxTv_SdtClase_Socios_Socioid = sdt.gxTv_SdtClase_Socios_Socioid ;
         gxTv_SdtClase_Socios_Socioedad = sdt.gxTv_SdtClase_Socios_Socioedad ;
         gxTv_SdtClase_Socios_Sociodireccion = sdt.gxTv_SdtClase_Socios_Sociodireccion ;
         gxTv_SdtClase_Socios_Sociofoto = sdt.gxTv_SdtClase_Socios_Sociofoto ;
         gxTv_SdtClase_Socios_Sociofoto_gxi = sdt.gxTv_SdtClase_Socios_Sociofoto_gxi ;
         gxTv_SdtClase_Socios_Mode = sdt.gxTv_SdtClase_Socios_Mode ;
         gxTv_SdtClase_Socios_Modified = sdt.gxTv_SdtClase_Socios_Modified ;
         gxTv_SdtClase_Socios_Initialized = sdt.gxTv_SdtClase_Socios_Initialized ;
         gxTv_SdtClase_Socios_Socioid_Z = sdt.gxTv_SdtClase_Socios_Socioid_Z ;
         gxTv_SdtClase_Socios_Socioedad_Z = sdt.gxTv_SdtClase_Socios_Socioedad_Z ;
         gxTv_SdtClase_Socios_Sociodireccion_Z = sdt.gxTv_SdtClase_Socios_Sociodireccion_Z ;
         gxTv_SdtClase_Socios_Sociofoto_gxi_Z = sdt.gxTv_SdtClase_Socios_Sociofoto_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SocioId", gxTv_SdtClase_Socios_Socioid, false);
         AddObjectProperty("SocioEdad", gxTv_SdtClase_Socios_Socioedad, false);
         AddObjectProperty("SocioDireccion", gxTv_SdtClase_Socios_Sociodireccion, false);
         AddObjectProperty("SocioFoto", gxTv_SdtClase_Socios_Sociofoto, false);
         if ( includeState )
         {
            AddObjectProperty("SocioFoto_GXI", gxTv_SdtClase_Socios_Sociofoto_gxi, false);
            AddObjectProperty("Mode", gxTv_SdtClase_Socios_Mode, false);
            AddObjectProperty("Modified", gxTv_SdtClase_Socios_Modified, false);
            AddObjectProperty("Initialized", gxTv_SdtClase_Socios_Initialized, false);
            AddObjectProperty("SocioId_Z", gxTv_SdtClase_Socios_Socioid_Z, false);
            AddObjectProperty("SocioEdad_Z", gxTv_SdtClase_Socios_Socioedad_Z, false);
            AddObjectProperty("SocioDireccion_Z", gxTv_SdtClase_Socios_Sociodireccion_Z, false);
            AddObjectProperty("SocioFoto_GXI_Z", gxTv_SdtClase_Socios_Sociofoto_gxi_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtClase_Socios sdt )
      {
         if ( sdt.IsDirty("SocioId") )
         {
            gxTv_SdtClase_Socios_Socioid = sdt.gxTv_SdtClase_Socios_Socioid ;
         }
         if ( sdt.IsDirty("SocioEdad") )
         {
            gxTv_SdtClase_Socios_Socioedad = sdt.gxTv_SdtClase_Socios_Socioedad ;
         }
         if ( sdt.IsDirty("SocioDireccion") )
         {
            gxTv_SdtClase_Socios_Sociodireccion = sdt.gxTv_SdtClase_Socios_Sociodireccion ;
         }
         if ( sdt.IsDirty("SocioFoto") )
         {
            gxTv_SdtClase_Socios_Sociofoto = sdt.gxTv_SdtClase_Socios_Sociofoto ;
         }
         if ( sdt.IsDirty("SocioFoto") )
         {
            gxTv_SdtClase_Socios_Sociofoto_gxi = sdt.gxTv_SdtClase_Socios_Sociofoto_gxi ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SocioId" )]
      [  XmlElement( ElementName = "SocioId"   )]
      public short gxTpr_Socioid
      {
         get {
            return gxTv_SdtClase_Socios_Socioid ;
         }

         set {
            gxTv_SdtClase_Socios_Socioid = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Socioid");
         }

      }

      [  SoapElement( ElementName = "SocioEdad" )]
      [  XmlElement( ElementName = "SocioEdad"   )]
      public short gxTpr_Socioedad
      {
         get {
            return gxTv_SdtClase_Socios_Socioedad ;
         }

         set {
            gxTv_SdtClase_Socios_Socioedad = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Socioedad");
         }

      }

      [  SoapElement( ElementName = "SocioDireccion" )]
      [  XmlElement( ElementName = "SocioDireccion"   )]
      public String gxTpr_Sociodireccion
      {
         get {
            return gxTv_SdtClase_Socios_Sociodireccion ;
         }

         set {
            gxTv_SdtClase_Socios_Sociodireccion = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Sociodireccion");
         }

      }

      [  SoapElement( ElementName = "SocioFoto" )]
      [  XmlElement( ElementName = "SocioFoto"   )]
      [GxUpload()]
      public String gxTpr_Sociofoto
      {
         get {
            return gxTv_SdtClase_Socios_Sociofoto ;
         }

         set {
            gxTv_SdtClase_Socios_Sociofoto = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Sociofoto");
         }

      }

      [  SoapElement( ElementName = "SocioFoto_GXI" )]
      [  XmlElement( ElementName = "SocioFoto_GXI"   )]
      public String gxTpr_Sociofoto_gxi
      {
         get {
            return gxTv_SdtClase_Socios_Sociofoto_gxi ;
         }

         set {
            gxTv_SdtClase_Socios_Sociofoto_gxi = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Sociofoto_gxi");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtClase_Socios_Mode ;
         }

         set {
            gxTv_SdtClase_Socios_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtClase_Socios_Mode_SetNull( )
      {
         gxTv_SdtClase_Socios_Mode = "";
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Modified" )]
      [  XmlElement( ElementName = "Modified"   )]
      public short gxTpr_Modified
      {
         get {
            return gxTv_SdtClase_Socios_Modified ;
         }

         set {
            gxTv_SdtClase_Socios_Modified = value;
            SetDirty("Modified");
         }

      }

      public void gxTv_SdtClase_Socios_Modified_SetNull( )
      {
         gxTv_SdtClase_Socios_Modified = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Modified_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtClase_Socios_Initialized ;
         }

         set {
            gxTv_SdtClase_Socios_Initialized = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtClase_Socios_Initialized_SetNull( )
      {
         gxTv_SdtClase_Socios_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioId_Z" )]
      [  XmlElement( ElementName = "SocioId_Z"   )]
      public short gxTpr_Socioid_Z
      {
         get {
            return gxTv_SdtClase_Socios_Socioid_Z ;
         }

         set {
            gxTv_SdtClase_Socios_Socioid_Z = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Socioid_Z");
         }

      }

      public void gxTv_SdtClase_Socios_Socioid_Z_SetNull( )
      {
         gxTv_SdtClase_Socios_Socioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Socioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioEdad_Z" )]
      [  XmlElement( ElementName = "SocioEdad_Z"   )]
      public short gxTpr_Socioedad_Z
      {
         get {
            return gxTv_SdtClase_Socios_Socioedad_Z ;
         }

         set {
            gxTv_SdtClase_Socios_Socioedad_Z = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Socioedad_Z");
         }

      }

      public void gxTv_SdtClase_Socios_Socioedad_Z_SetNull( )
      {
         gxTv_SdtClase_Socios_Socioedad_Z = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Socioedad_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioDireccion_Z" )]
      [  XmlElement( ElementName = "SocioDireccion_Z"   )]
      public String gxTpr_Sociodireccion_Z
      {
         get {
            return gxTv_SdtClase_Socios_Sociodireccion_Z ;
         }

         set {
            gxTv_SdtClase_Socios_Sociodireccion_Z = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Sociodireccion_Z");
         }

      }

      public void gxTv_SdtClase_Socios_Sociodireccion_Z_SetNull( )
      {
         gxTv_SdtClase_Socios_Sociodireccion_Z = "";
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Sociodireccion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioFoto_GXI_Z" )]
      [  XmlElement( ElementName = "SocioFoto_GXI_Z"   )]
      public String gxTpr_Sociofoto_gxi_Z
      {
         get {
            return gxTv_SdtClase_Socios_Sociofoto_gxi_Z ;
         }

         set {
            gxTv_SdtClase_Socios_Sociofoto_gxi_Z = value;
            gxTv_SdtClase_Socios_Modified = 1;
            SetDirty("Sociofoto_gxi_Z");
         }

      }

      public void gxTv_SdtClase_Socios_Sociofoto_gxi_Z_SetNull( )
      {
         gxTv_SdtClase_Socios_Sociofoto_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtClase_Socios_Sociofoto_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtClase_Socios_Sociodireccion = "";
         gxTv_SdtClase_Socios_Sociofoto = "";
         gxTv_SdtClase_Socios_Sociofoto_gxi = "";
         gxTv_SdtClase_Socios_Mode = "";
         gxTv_SdtClase_Socios_Sociodireccion_Z = "";
         gxTv_SdtClase_Socios_Sociofoto_gxi_Z = "";
         return  ;
      }

      private short gxTv_SdtClase_Socios_Socioid ;
      private short gxTv_SdtClase_Socios_Socioedad ;
      private short gxTv_SdtClase_Socios_Modified ;
      private short gxTv_SdtClase_Socios_Initialized ;
      private short gxTv_SdtClase_Socios_Socioid_Z ;
      private short gxTv_SdtClase_Socios_Socioedad_Z ;
      private String gxTv_SdtClase_Socios_Mode ;
      private String gxTv_SdtClase_Socios_Sociodireccion ;
      private String gxTv_SdtClase_Socios_Sociofoto_gxi ;
      private String gxTv_SdtClase_Socios_Sociodireccion_Z ;
      private String gxTv_SdtClase_Socios_Sociofoto_gxi_Z ;
      private String gxTv_SdtClase_Socios_Sociofoto ;
   }

   [DataContract(Name = @"Clase.Socios", Namespace = "ObligatorioGenexusGit")]
   public class SdtClase_Socios_RESTInterface : GxGenericCollectionItem<SdtClase_Socios>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtClase_Socios_RESTInterface( ) : base()
      {
      }

      public SdtClase_Socios_RESTInterface( SdtClase_Socios psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "SocioId" , Order = 0 )]
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

      [DataMember( Name = "SocioEdad" , Order = 1 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Socioedad
      {
         get {
            return sdt.gxTpr_Socioedad ;
         }

         set {
            sdt.gxTpr_Socioedad = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "SocioDireccion" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Sociodireccion
      {
         get {
            return sdt.gxTpr_Sociodireccion ;
         }

         set {
            sdt.gxTpr_Sociodireccion = value;
         }

      }

      [DataMember( Name = "SocioFoto" , Order = 3 )]
      [GxUpload()]
      public String gxTpr_Sociofoto
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Sociofoto)) ? PathUtil.RelativeURL( sdt.gxTpr_Sociofoto) : StringUtil.RTrim( sdt.gxTpr_Sociofoto_gxi)) ;
         }

         set {
            sdt.gxTpr_Sociofoto = value;
         }

      }

      public SdtClase_Socios sdt
      {
         get {
            return (SdtClase_Socios)Sdt ;
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
            sdt = new SdtClase_Socios() ;
         }
      }

   }

   [DataContract(Name = @"Clase.Socios", Namespace = "ObligatorioGenexusGit")]
   public class SdtClase_Socios_RESTLInterface : GxGenericCollectionItem<SdtClase_Socios>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtClase_Socios_RESTLInterface( ) : base()
      {
      }

      public SdtClase_Socios_RESTLInterface( SdtClase_Socios psdt ) : base(psdt)
      {
      }

      public SdtClase_Socios sdt
      {
         get {
            return (SdtClase_Socios)Sdt ;
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
            sdt = new SdtClase_Socios() ;
         }
      }

   }

}
