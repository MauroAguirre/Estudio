/*
               File: type_SdtActividad_SocioEnActividad
        Description: Actividad
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 8:31:57.25
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
   [XmlRoot(ElementName = "Actividad.SocioEnActividad" )]
   [XmlType(TypeName =  "Actividad.SocioEnActividad" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtActividad_SocioEnActividad : GxSilentTrnSdt, IGxSilentTrnGridItem
   {
      public SdtActividad_SocioEnActividad( )
      {
      }

      public SdtActividad_SocioEnActividad( IGxContext context )
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
         metadata.Set("Name", "SocioEnActividad");
         metadata.Set("BT", "ActividadSocioEnActividad");
         metadata.Set("PK", "[ \"SocioId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"ActividadId\" ],\"FKMap\":[  ] },{ \"FK\":[ \"SocioId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Sociodireccion_Z");
         state.Add("gxTpr_Socioedad_Z");
         state.Add("gxTpr_Socioreconocido_Z");
         state.Add("gxTpr_Sociosexo_Z");
         state.Add("gxTpr_Sociofoto_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtActividad_SocioEnActividad sdt ;
         sdt = (SdtActividad_SocioEnActividad)(source);
         gxTv_SdtActividad_SocioEnActividad_Socioid = sdt.gxTv_SdtActividad_SocioEnActividad_Socioid ;
         gxTv_SdtActividad_SocioEnActividad_Sociodireccion = sdt.gxTv_SdtActividad_SocioEnActividad_Sociodireccion ;
         gxTv_SdtActividad_SocioEnActividad_Sociofoto = sdt.gxTv_SdtActividad_SocioEnActividad_Sociofoto ;
         gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi = sdt.gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi ;
         gxTv_SdtActividad_SocioEnActividad_Socioedad = sdt.gxTv_SdtActividad_SocioEnActividad_Socioedad ;
         gxTv_SdtActividad_SocioEnActividad_Socioreconocido = sdt.gxTv_SdtActividad_SocioEnActividad_Socioreconocido ;
         gxTv_SdtActividad_SocioEnActividad_Sociosexo = sdt.gxTv_SdtActividad_SocioEnActividad_Sociosexo ;
         gxTv_SdtActividad_SocioEnActividad_Mode = sdt.gxTv_SdtActividad_SocioEnActividad_Mode ;
         gxTv_SdtActividad_SocioEnActividad_Modified = sdt.gxTv_SdtActividad_SocioEnActividad_Modified ;
         gxTv_SdtActividad_SocioEnActividad_Initialized = sdt.gxTv_SdtActividad_SocioEnActividad_Initialized ;
         gxTv_SdtActividad_SocioEnActividad_Socioid_Z = sdt.gxTv_SdtActividad_SocioEnActividad_Socioid_Z ;
         gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z = sdt.gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z ;
         gxTv_SdtActividad_SocioEnActividad_Socioedad_Z = sdt.gxTv_SdtActividad_SocioEnActividad_Socioedad_Z ;
         gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z = sdt.gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z ;
         gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z = sdt.gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z ;
         gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z = sdt.gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SocioId", gxTv_SdtActividad_SocioEnActividad_Socioid, false);
         AddObjectProperty("SocioDireccion", gxTv_SdtActividad_SocioEnActividad_Sociodireccion, false);
         AddObjectProperty("SocioFoto", gxTv_SdtActividad_SocioEnActividad_Sociofoto, false);
         AddObjectProperty("SocioEdad", gxTv_SdtActividad_SocioEnActividad_Socioedad, false);
         AddObjectProperty("SocioReconocido", gxTv_SdtActividad_SocioEnActividad_Socioreconocido, false);
         AddObjectProperty("SocioSexo", gxTv_SdtActividad_SocioEnActividad_Sociosexo, false);
         if ( includeState )
         {
            AddObjectProperty("SocioFoto_GXI", gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi, false);
            AddObjectProperty("Mode", gxTv_SdtActividad_SocioEnActividad_Mode, false);
            AddObjectProperty("Modified", gxTv_SdtActividad_SocioEnActividad_Modified, false);
            AddObjectProperty("Initialized", gxTv_SdtActividad_SocioEnActividad_Initialized, false);
            AddObjectProperty("SocioId_Z", gxTv_SdtActividad_SocioEnActividad_Socioid_Z, false);
            AddObjectProperty("SocioDireccion_Z", gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z, false);
            AddObjectProperty("SocioEdad_Z", gxTv_SdtActividad_SocioEnActividad_Socioedad_Z, false);
            AddObjectProperty("SocioReconocido_Z", gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z, false);
            AddObjectProperty("SocioSexo_Z", gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z, false);
            AddObjectProperty("SocioFoto_GXI_Z", gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtActividad_SocioEnActividad sdt )
      {
         if ( sdt.IsDirty("SocioId") )
         {
            gxTv_SdtActividad_SocioEnActividad_Socioid = sdt.gxTv_SdtActividad_SocioEnActividad_Socioid ;
         }
         if ( sdt.IsDirty("SocioDireccion") )
         {
            gxTv_SdtActividad_SocioEnActividad_Sociodireccion = sdt.gxTv_SdtActividad_SocioEnActividad_Sociodireccion ;
         }
         if ( sdt.IsDirty("SocioFoto") )
         {
            gxTv_SdtActividad_SocioEnActividad_Sociofoto = sdt.gxTv_SdtActividad_SocioEnActividad_Sociofoto ;
         }
         if ( sdt.IsDirty("SocioFoto") )
         {
            gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi = sdt.gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi ;
         }
         if ( sdt.IsDirty("SocioEdad") )
         {
            gxTv_SdtActividad_SocioEnActividad_Socioedad = sdt.gxTv_SdtActividad_SocioEnActividad_Socioedad ;
         }
         if ( sdt.IsDirty("SocioReconocido") )
         {
            gxTv_SdtActividad_SocioEnActividad_Socioreconocido = sdt.gxTv_SdtActividad_SocioEnActividad_Socioreconocido ;
         }
         if ( sdt.IsDirty("SocioSexo") )
         {
            gxTv_SdtActividad_SocioEnActividad_Sociosexo = sdt.gxTv_SdtActividad_SocioEnActividad_Sociosexo ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SocioId" )]
      [  XmlElement( ElementName = "SocioId"   )]
      public short gxTpr_Socioid
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Socioid ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Socioid = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Socioid");
         }

      }

      [  SoapElement( ElementName = "SocioDireccion" )]
      [  XmlElement( ElementName = "SocioDireccion"   )]
      public String gxTpr_Sociodireccion
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociodireccion ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociodireccion = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociodireccion");
         }

      }

      [  SoapElement( ElementName = "SocioFoto" )]
      [  XmlElement( ElementName = "SocioFoto"   )]
      [GxUpload()]
      public String gxTpr_Sociofoto
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociofoto ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociofoto = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociofoto");
         }

      }

      [  SoapElement( ElementName = "SocioFoto_GXI" )]
      [  XmlElement( ElementName = "SocioFoto_GXI"   )]
      public String gxTpr_Sociofoto_gxi
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociofoto_gxi");
         }

      }

      [  SoapElement( ElementName = "SocioEdad" )]
      [  XmlElement( ElementName = "SocioEdad"   )]
      public short gxTpr_Socioedad
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Socioedad ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Socioedad = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Socioedad");
         }

      }

      [  SoapElement( ElementName = "SocioReconocido" )]
      [  XmlElement( ElementName = "SocioReconocido"   )]
      public String gxTpr_Socioreconocido
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Socioreconocido ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Socioreconocido = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Socioreconocido");
         }

      }

      [  SoapElement( ElementName = "SocioSexo" )]
      [  XmlElement( ElementName = "SocioSexo"   )]
      public String gxTpr_Sociosexo
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociosexo ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociosexo = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociosexo");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Mode ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Mode_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Mode = "";
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Modified" )]
      [  XmlElement( ElementName = "Modified"   )]
      public short gxTpr_Modified
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Modified ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Modified = value;
            SetDirty("Modified");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Modified_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Modified = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Modified_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Initialized ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Initialized = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Initialized_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioId_Z" )]
      [  XmlElement( ElementName = "SocioId_Z"   )]
      public short gxTpr_Socioid_Z
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Socioid_Z ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Socioid_Z = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Socioid_Z");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Socioid_Z_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Socioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Socioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioDireccion_Z" )]
      [  XmlElement( ElementName = "SocioDireccion_Z"   )]
      public String gxTpr_Sociodireccion_Z
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociodireccion_Z");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z = "";
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioEdad_Z" )]
      [  XmlElement( ElementName = "SocioEdad_Z"   )]
      public short gxTpr_Socioedad_Z
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Socioedad_Z ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Socioedad_Z = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Socioedad_Z");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Socioedad_Z_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Socioedad_Z = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Socioedad_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioReconocido_Z" )]
      [  XmlElement( ElementName = "SocioReconocido_Z"   )]
      public String gxTpr_Socioreconocido_Z
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Socioreconocido_Z");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z = "";
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioSexo_Z" )]
      [  XmlElement( ElementName = "SocioSexo_Z"   )]
      public String gxTpr_Sociosexo_Z
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociosexo_Z");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z = "";
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioFoto_GXI_Z" )]
      [  XmlElement( ElementName = "SocioFoto_GXI_Z"   )]
      public String gxTpr_Sociofoto_gxi_Z
      {
         get {
            return gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z ;
         }

         set {
            gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z = value;
            gxTv_SdtActividad_SocioEnActividad_Modified = 1;
            SetDirty("Sociofoto_gxi_Z");
         }

      }

      public void gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z_SetNull( )
      {
         gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtActividad_SocioEnActividad_Sociodireccion = "";
         gxTv_SdtActividad_SocioEnActividad_Sociofoto = "";
         gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi = "";
         gxTv_SdtActividad_SocioEnActividad_Socioreconocido = "";
         gxTv_SdtActividad_SocioEnActividad_Sociosexo = "";
         gxTv_SdtActividad_SocioEnActividad_Mode = "";
         gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z = "";
         gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z = "";
         gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z = "";
         gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z = "";
         return  ;
      }

      private short gxTv_SdtActividad_SocioEnActividad_Socioid ;
      private short gxTv_SdtActividad_SocioEnActividad_Socioedad ;
      private short gxTv_SdtActividad_SocioEnActividad_Modified ;
      private short gxTv_SdtActividad_SocioEnActividad_Initialized ;
      private short gxTv_SdtActividad_SocioEnActividad_Socioid_Z ;
      private short gxTv_SdtActividad_SocioEnActividad_Socioedad_Z ;
      private String gxTv_SdtActividad_SocioEnActividad_Socioreconocido ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociosexo ;
      private String gxTv_SdtActividad_SocioEnActividad_Mode ;
      private String gxTv_SdtActividad_SocioEnActividad_Socioreconocido_Z ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociosexo_Z ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociodireccion ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociodireccion_Z ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociofoto_gxi_Z ;
      private String gxTv_SdtActividad_SocioEnActividad_Sociofoto ;
   }

   [DataContract(Name = @"Actividad.SocioEnActividad", Namespace = "ObligatorioGenexusGit")]
   public class SdtActividad_SocioEnActividad_RESTInterface : GxGenericCollectionItem<SdtActividad_SocioEnActividad>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtActividad_SocioEnActividad_RESTInterface( ) : base()
      {
      }

      public SdtActividad_SocioEnActividad_RESTInterface( SdtActividad_SocioEnActividad psdt ) : base(psdt)
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

      [DataMember( Name = "SocioDireccion" , Order = 1 )]
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

      [DataMember( Name = "SocioFoto" , Order = 2 )]
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

      [DataMember( Name = "SocioEdad" , Order = 3 )]
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

      [DataMember( Name = "SocioReconocido" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Socioreconocido
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Socioreconocido) ;
         }

         set {
            sdt.gxTpr_Socioreconocido = value;
         }

      }

      [DataMember( Name = "SocioSexo" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Sociosexo
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Sociosexo) ;
         }

         set {
            sdt.gxTpr_Sociosexo = value;
         }

      }

      public SdtActividad_SocioEnActividad sdt
      {
         get {
            return (SdtActividad_SocioEnActividad)Sdt ;
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
            sdt = new SdtActividad_SocioEnActividad() ;
         }
      }

   }

}
