/*
               File: type_SdtProfesor
        Description: Profesor
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:43.80
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
   [XmlRoot(ElementName = "Profesor" )]
   [XmlType(TypeName =  "Profesor" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtProfesor : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProfesor( )
      {
      }

      public SdtProfesor( IGxContext context )
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

      public void Load( short AV2ProfesorId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV2ProfesorId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"ProfesorId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Profesor");
         metadata.Set("BT", "Profesor");
         metadata.Set("PK", "[ \"ProfesorId\" ]");
         metadata.Set("PKAssigned", "[ \"ProfesorId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"ActividadId\" ],\"FKMap\":[  ] } ]");
         metadata.Set("AllowInsert", "True");
         metadata.Set("AllowUpdate", "True");
         metadata.Set("AllowDelete", "True");
         return metadata ;
      }

      public override GeneXus.Utils.GxStringCollection StateAttributes( )
      {
         GeneXus.Utils.GxStringCollection state = new GeneXus.Utils.GxStringCollection() ;
         state.Add("gxTpr_Profesorfoto_gxi");
         state.Add("gxTpr_Mode");
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Profesorid_Z");
         state.Add("gxTpr_Profesornombre_Z");
         state.Add("gxTpr_Profesordireccion_Z");
         state.Add("gxTpr_Actividadid_Z");
         state.Add("gxTpr_Actividaddescripcion_Z");
         state.Add("gxTpr_Profesorfoto_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtProfesor sdt ;
         sdt = (SdtProfesor)(source);
         gxTv_SdtProfesor_Profesorid = sdt.gxTv_SdtProfesor_Profesorid ;
         gxTv_SdtProfesor_Profesornombre = sdt.gxTv_SdtProfesor_Profesornombre ;
         gxTv_SdtProfesor_Profesordireccion = sdt.gxTv_SdtProfesor_Profesordireccion ;
         gxTv_SdtProfesor_Profesorfoto = sdt.gxTv_SdtProfesor_Profesorfoto ;
         gxTv_SdtProfesor_Profesorfoto_gxi = sdt.gxTv_SdtProfesor_Profesorfoto_gxi ;
         gxTv_SdtProfesor_Actividadid = sdt.gxTv_SdtProfesor_Actividadid ;
         gxTv_SdtProfesor_Actividaddescripcion = sdt.gxTv_SdtProfesor_Actividaddescripcion ;
         gxTv_SdtProfesor_Mode = sdt.gxTv_SdtProfesor_Mode ;
         gxTv_SdtProfesor_Initialized = sdt.gxTv_SdtProfesor_Initialized ;
         gxTv_SdtProfesor_Profesorid_Z = sdt.gxTv_SdtProfesor_Profesorid_Z ;
         gxTv_SdtProfesor_Profesornombre_Z = sdt.gxTv_SdtProfesor_Profesornombre_Z ;
         gxTv_SdtProfesor_Profesordireccion_Z = sdt.gxTv_SdtProfesor_Profesordireccion_Z ;
         gxTv_SdtProfesor_Actividadid_Z = sdt.gxTv_SdtProfesor_Actividadid_Z ;
         gxTv_SdtProfesor_Actividaddescripcion_Z = sdt.gxTv_SdtProfesor_Actividaddescripcion_Z ;
         gxTv_SdtProfesor_Profesorfoto_gxi_Z = sdt.gxTv_SdtProfesor_Profesorfoto_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("ProfesorId", gxTv_SdtProfesor_Profesorid, false);
         AddObjectProperty("ProfesorNombre", gxTv_SdtProfesor_Profesornombre, false);
         AddObjectProperty("ProfesorDireccion", gxTv_SdtProfesor_Profesordireccion, false);
         AddObjectProperty("ProfesorFoto", gxTv_SdtProfesor_Profesorfoto, false);
         AddObjectProperty("ActividadId", gxTv_SdtProfesor_Actividadid, false);
         AddObjectProperty("ActividadDescripcion", gxTv_SdtProfesor_Actividaddescripcion, false);
         if ( includeState )
         {
            AddObjectProperty("ProfesorFoto_GXI", gxTv_SdtProfesor_Profesorfoto_gxi, false);
            AddObjectProperty("Mode", gxTv_SdtProfesor_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtProfesor_Initialized, false);
            AddObjectProperty("ProfesorId_Z", gxTv_SdtProfesor_Profesorid_Z, false);
            AddObjectProperty("ProfesorNombre_Z", gxTv_SdtProfesor_Profesornombre_Z, false);
            AddObjectProperty("ProfesorDireccion_Z", gxTv_SdtProfesor_Profesordireccion_Z, false);
            AddObjectProperty("ActividadId_Z", gxTv_SdtProfesor_Actividadid_Z, false);
            AddObjectProperty("ActividadDescripcion_Z", gxTv_SdtProfesor_Actividaddescripcion_Z, false);
            AddObjectProperty("ProfesorFoto_GXI_Z", gxTv_SdtProfesor_Profesorfoto_gxi_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtProfesor sdt )
      {
         if ( sdt.IsDirty("ProfesorId") )
         {
            gxTv_SdtProfesor_Profesorid = sdt.gxTv_SdtProfesor_Profesorid ;
         }
         if ( sdt.IsDirty("ProfesorNombre") )
         {
            gxTv_SdtProfesor_Profesornombre = sdt.gxTv_SdtProfesor_Profesornombre ;
         }
         if ( sdt.IsDirty("ProfesorDireccion") )
         {
            gxTv_SdtProfesor_Profesordireccion = sdt.gxTv_SdtProfesor_Profesordireccion ;
         }
         if ( sdt.IsDirty("ProfesorFoto") )
         {
            gxTv_SdtProfesor_Profesorfoto = sdt.gxTv_SdtProfesor_Profesorfoto ;
         }
         if ( sdt.IsDirty("ProfesorFoto") )
         {
            gxTv_SdtProfesor_Profesorfoto_gxi = sdt.gxTv_SdtProfesor_Profesorfoto_gxi ;
         }
         if ( sdt.IsDirty("ActividadId") )
         {
            gxTv_SdtProfesor_Actividadid = sdt.gxTv_SdtProfesor_Actividadid ;
         }
         if ( sdt.IsDirty("ActividadDescripcion") )
         {
            gxTv_SdtProfesor_Actividaddescripcion = sdt.gxTv_SdtProfesor_Actividaddescripcion ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "ProfesorId" )]
      [  XmlElement( ElementName = "ProfesorId"   )]
      public short gxTpr_Profesorid
      {
         get {
            return gxTv_SdtProfesor_Profesorid ;
         }

         set {
            if ( gxTv_SdtProfesor_Profesorid != value )
            {
               gxTv_SdtProfesor_Mode = "INS";
               this.gxTv_SdtProfesor_Profesorid_Z_SetNull( );
               this.gxTv_SdtProfesor_Profesornombre_Z_SetNull( );
               this.gxTv_SdtProfesor_Profesordireccion_Z_SetNull( );
               this.gxTv_SdtProfesor_Actividadid_Z_SetNull( );
               this.gxTv_SdtProfesor_Actividaddescripcion_Z_SetNull( );
               this.gxTv_SdtProfesor_Profesorfoto_gxi_Z_SetNull( );
            }
            gxTv_SdtProfesor_Profesorid = value;
            SetDirty("Profesorid");
         }

      }

      [  SoapElement( ElementName = "ProfesorNombre" )]
      [  XmlElement( ElementName = "ProfesorNombre"   )]
      public String gxTpr_Profesornombre
      {
         get {
            return gxTv_SdtProfesor_Profesornombre ;
         }

         set {
            gxTv_SdtProfesor_Profesornombre = value;
            SetDirty("Profesornombre");
         }

      }

      [  SoapElement( ElementName = "ProfesorDireccion" )]
      [  XmlElement( ElementName = "ProfesorDireccion"   )]
      public String gxTpr_Profesordireccion
      {
         get {
            return gxTv_SdtProfesor_Profesordireccion ;
         }

         set {
            gxTv_SdtProfesor_Profesordireccion = value;
            SetDirty("Profesordireccion");
         }

      }

      [  SoapElement( ElementName = "ProfesorFoto" )]
      [  XmlElement( ElementName = "ProfesorFoto"   )]
      [GxUpload()]
      public String gxTpr_Profesorfoto
      {
         get {
            return gxTv_SdtProfesor_Profesorfoto ;
         }

         set {
            gxTv_SdtProfesor_Profesorfoto = value;
            SetDirty("Profesorfoto");
         }

      }

      [  SoapElement( ElementName = "ProfesorFoto_GXI" )]
      [  XmlElement( ElementName = "ProfesorFoto_GXI"   )]
      public String gxTpr_Profesorfoto_gxi
      {
         get {
            return gxTv_SdtProfesor_Profesorfoto_gxi ;
         }

         set {
            gxTv_SdtProfesor_Profesorfoto_gxi = value;
            SetDirty("Profesorfoto_gxi");
         }

      }

      [  SoapElement( ElementName = "ActividadId" )]
      [  XmlElement( ElementName = "ActividadId"   )]
      public short gxTpr_Actividadid
      {
         get {
            return gxTv_SdtProfesor_Actividadid ;
         }

         set {
            gxTv_SdtProfesor_Actividadid = value;
            SetDirty("Actividadid");
         }

      }

      [  SoapElement( ElementName = "ActividadDescripcion" )]
      [  XmlElement( ElementName = "ActividadDescripcion"   )]
      public String gxTpr_Actividaddescripcion
      {
         get {
            return gxTv_SdtProfesor_Actividaddescripcion ;
         }

         set {
            gxTv_SdtProfesor_Actividaddescripcion = value;
            SetDirty("Actividaddescripcion");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtProfesor_Mode ;
         }

         set {
            gxTv_SdtProfesor_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtProfesor_Mode_SetNull( )
      {
         gxTv_SdtProfesor_Mode = "";
         return  ;
      }

      public bool gxTv_SdtProfesor_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtProfesor_Initialized ;
         }

         set {
            gxTv_SdtProfesor_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtProfesor_Initialized_SetNull( )
      {
         gxTv_SdtProfesor_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtProfesor_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProfesorId_Z" )]
      [  XmlElement( ElementName = "ProfesorId_Z"   )]
      public short gxTpr_Profesorid_Z
      {
         get {
            return gxTv_SdtProfesor_Profesorid_Z ;
         }

         set {
            gxTv_SdtProfesor_Profesorid_Z = value;
            SetDirty("Profesorid_Z");
         }

      }

      public void gxTv_SdtProfesor_Profesorid_Z_SetNull( )
      {
         gxTv_SdtProfesor_Profesorid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtProfesor_Profesorid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProfesorNombre_Z" )]
      [  XmlElement( ElementName = "ProfesorNombre_Z"   )]
      public String gxTpr_Profesornombre_Z
      {
         get {
            return gxTv_SdtProfesor_Profesornombre_Z ;
         }

         set {
            gxTv_SdtProfesor_Profesornombre_Z = value;
            SetDirty("Profesornombre_Z");
         }

      }

      public void gxTv_SdtProfesor_Profesornombre_Z_SetNull( )
      {
         gxTv_SdtProfesor_Profesornombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtProfesor_Profesornombre_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProfesorDireccion_Z" )]
      [  XmlElement( ElementName = "ProfesorDireccion_Z"   )]
      public String gxTpr_Profesordireccion_Z
      {
         get {
            return gxTv_SdtProfesor_Profesordireccion_Z ;
         }

         set {
            gxTv_SdtProfesor_Profesordireccion_Z = value;
            SetDirty("Profesordireccion_Z");
         }

      }

      public void gxTv_SdtProfesor_Profesordireccion_Z_SetNull( )
      {
         gxTv_SdtProfesor_Profesordireccion_Z = "";
         return  ;
      }

      public bool gxTv_SdtProfesor_Profesordireccion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadId_Z" )]
      [  XmlElement( ElementName = "ActividadId_Z"   )]
      public short gxTpr_Actividadid_Z
      {
         get {
            return gxTv_SdtProfesor_Actividadid_Z ;
         }

         set {
            gxTv_SdtProfesor_Actividadid_Z = value;
            SetDirty("Actividadid_Z");
         }

      }

      public void gxTv_SdtProfesor_Actividadid_Z_SetNull( )
      {
         gxTv_SdtProfesor_Actividadid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtProfesor_Actividadid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadDescripcion_Z" )]
      [  XmlElement( ElementName = "ActividadDescripcion_Z"   )]
      public String gxTpr_Actividaddescripcion_Z
      {
         get {
            return gxTv_SdtProfesor_Actividaddescripcion_Z ;
         }

         set {
            gxTv_SdtProfesor_Actividaddescripcion_Z = value;
            SetDirty("Actividaddescripcion_Z");
         }

      }

      public void gxTv_SdtProfesor_Actividaddescripcion_Z_SetNull( )
      {
         gxTv_SdtProfesor_Actividaddescripcion_Z = "";
         return  ;
      }

      public bool gxTv_SdtProfesor_Actividaddescripcion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProfesorFoto_GXI_Z" )]
      [  XmlElement( ElementName = "ProfesorFoto_GXI_Z"   )]
      public String gxTpr_Profesorfoto_gxi_Z
      {
         get {
            return gxTv_SdtProfesor_Profesorfoto_gxi_Z ;
         }

         set {
            gxTv_SdtProfesor_Profesorfoto_gxi_Z = value;
            SetDirty("Profesorfoto_gxi_Z");
         }

      }

      public void gxTv_SdtProfesor_Profesorfoto_gxi_Z_SetNull( )
      {
         gxTv_SdtProfesor_Profesorfoto_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtProfesor_Profesorfoto_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtProfesor_Profesornombre = "";
         gxTv_SdtProfesor_Profesordireccion = "";
         gxTv_SdtProfesor_Profesorfoto = "";
         gxTv_SdtProfesor_Profesorfoto_gxi = "";
         gxTv_SdtProfesor_Actividaddescripcion = "";
         gxTv_SdtProfesor_Mode = "";
         gxTv_SdtProfesor_Profesornombre_Z = "";
         gxTv_SdtProfesor_Profesordireccion_Z = "";
         gxTv_SdtProfesor_Actividaddescripcion_Z = "";
         gxTv_SdtProfesor_Profesorfoto_gxi_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "profesor", "GeneXus.Programs.profesor_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtProfesor_Profesorid ;
      private short gxTv_SdtProfesor_Actividadid ;
      private short gxTv_SdtProfesor_Initialized ;
      private short gxTv_SdtProfesor_Profesorid_Z ;
      private short gxTv_SdtProfesor_Actividadid_Z ;
      private String gxTv_SdtProfesor_Profesornombre ;
      private String gxTv_SdtProfesor_Actividaddescripcion ;
      private String gxTv_SdtProfesor_Mode ;
      private String gxTv_SdtProfesor_Profesornombre_Z ;
      private String gxTv_SdtProfesor_Actividaddescripcion_Z ;
      private String gxTv_SdtProfesor_Profesordireccion ;
      private String gxTv_SdtProfesor_Profesorfoto_gxi ;
      private String gxTv_SdtProfesor_Profesordireccion_Z ;
      private String gxTv_SdtProfesor_Profesorfoto_gxi_Z ;
      private String gxTv_SdtProfesor_Profesorfoto ;
   }

   [DataContract(Name = @"Profesor", Namespace = "ObligatorioGenexusGit")]
   public class SdtProfesor_RESTInterface : GxGenericCollectionItem<SdtProfesor>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProfesor_RESTInterface( ) : base()
      {
      }

      public SdtProfesor_RESTInterface( SdtProfesor psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ProfesorId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Profesorid
      {
         get {
            return sdt.gxTpr_Profesorid ;
         }

         set {
            sdt.gxTpr_Profesorid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ProfesorNombre" , Order = 1 )]
      [GxSeudo()]
      public String gxTpr_Profesornombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Profesornombre) ;
         }

         set {
            sdt.gxTpr_Profesornombre = value;
         }

      }

      [DataMember( Name = "ProfesorDireccion" , Order = 2 )]
      [GxSeudo()]
      public String gxTpr_Profesordireccion
      {
         get {
            return sdt.gxTpr_Profesordireccion ;
         }

         set {
            sdt.gxTpr_Profesordireccion = value;
         }

      }

      [DataMember( Name = "ProfesorFoto" , Order = 3 )]
      [GxUpload()]
      public String gxTpr_Profesorfoto
      {
         get {
            return (!String.IsNullOrEmpty(StringUtil.RTrim( sdt.gxTpr_Profesorfoto)) ? PathUtil.RelativeURL( sdt.gxTpr_Profesorfoto) : StringUtil.RTrim( sdt.gxTpr_Profesorfoto_gxi)) ;
         }

         set {
            sdt.gxTpr_Profesorfoto = value;
         }

      }

      [DataMember( Name = "ActividadId" , Order = 4 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Actividadid
      {
         get {
            return sdt.gxTpr_Actividadid ;
         }

         set {
            sdt.gxTpr_Actividadid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ActividadDescripcion" , Order = 5 )]
      [GxSeudo()]
      public String gxTpr_Actividaddescripcion
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Actividaddescripcion) ;
         }

         set {
            sdt.gxTpr_Actividaddescripcion = value;
         }

      }

      public SdtProfesor sdt
      {
         get {
            return (SdtProfesor)Sdt ;
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
            sdt = new SdtProfesor() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 6 )]
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

   [DataContract(Name = @"Profesor", Namespace = "ObligatorioGenexusGit")]
   public class SdtProfesor_RESTLInterface : GxGenericCollectionItem<SdtProfesor>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtProfesor_RESTLInterface( ) : base()
      {
      }

      public SdtProfesor_RESTLInterface( SdtProfesor psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ProfesorNombre" , Order = 0 )]
      [GxSeudo()]
      public String gxTpr_Profesornombre
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Profesornombre) ;
         }

         set {
            sdt.gxTpr_Profesornombre = value;
         }

      }

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            return "" ;
         }

         set {
         }

      }

      public SdtProfesor sdt
      {
         get {
            return (SdtProfesor)Sdt ;
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
            sdt = new SdtProfesor() ;
         }
      }

   }

}
