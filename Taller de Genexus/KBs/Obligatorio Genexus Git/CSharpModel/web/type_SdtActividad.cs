/*
               File: type_SdtActividad
        Description: Actividad
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:34.60
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
   [XmlRoot(ElementName = "Actividad" )]
   [XmlType(TypeName =  "Actividad" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtActividad : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtActividad( )
      {
      }

      public SdtActividad( IGxContext context )
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

      public void Load( short AV1ActividadId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV1ActividadId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"ActividadId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Actividad");
         metadata.Set("BT", "Actividad1");
         metadata.Set("PK", "[ \"ActividadId\" ]");
         metadata.Set("PKAssigned", "[ \"ActividadId\" ]");
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
         state.Add("gxTpr_Actividadid_Z");
         state.Add("gxTpr_Actividaddescripcion_Z");
         state.Add("gxTpr_Actividadcantidadprofesores_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtActividad sdt ;
         sdt = (SdtActividad)(source);
         gxTv_SdtActividad_Actividadid = sdt.gxTv_SdtActividad_Actividadid ;
         gxTv_SdtActividad_Actividaddescripcion = sdt.gxTv_SdtActividad_Actividaddescripcion ;
         gxTv_SdtActividad_Actividadcantidadprofesores = sdt.gxTv_SdtActividad_Actividadcantidadprofesores ;
         gxTv_SdtActividad_Mode = sdt.gxTv_SdtActividad_Mode ;
         gxTv_SdtActividad_Initialized = sdt.gxTv_SdtActividad_Initialized ;
         gxTv_SdtActividad_Actividadid_Z = sdt.gxTv_SdtActividad_Actividadid_Z ;
         gxTv_SdtActividad_Actividaddescripcion_Z = sdt.gxTv_SdtActividad_Actividaddescripcion_Z ;
         gxTv_SdtActividad_Actividadcantidadprofesores_Z = sdt.gxTv_SdtActividad_Actividadcantidadprofesores_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("ActividadId", gxTv_SdtActividad_Actividadid, false);
         AddObjectProperty("ActividadDescripcion", gxTv_SdtActividad_Actividaddescripcion, false);
         AddObjectProperty("ActividadCantidadProfesores", gxTv_SdtActividad_Actividadcantidadprofesores, false);
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtActividad_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtActividad_Initialized, false);
            AddObjectProperty("ActividadId_Z", gxTv_SdtActividad_Actividadid_Z, false);
            AddObjectProperty("ActividadDescripcion_Z", gxTv_SdtActividad_Actividaddescripcion_Z, false);
            AddObjectProperty("ActividadCantidadProfesores_Z", gxTv_SdtActividad_Actividadcantidadprofesores_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtActividad sdt )
      {
         if ( sdt.IsDirty("ActividadId") )
         {
            gxTv_SdtActividad_Actividadid = sdt.gxTv_SdtActividad_Actividadid ;
         }
         if ( sdt.IsDirty("ActividadDescripcion") )
         {
            gxTv_SdtActividad_Actividaddescripcion = sdt.gxTv_SdtActividad_Actividaddescripcion ;
         }
         if ( sdt.IsDirty("ActividadCantidadProfesores") )
         {
            gxTv_SdtActividad_Actividadcantidadprofesores = sdt.gxTv_SdtActividad_Actividadcantidadprofesores ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "ActividadId" )]
      [  XmlElement( ElementName = "ActividadId"   )]
      public short gxTpr_Actividadid
      {
         get {
            return gxTv_SdtActividad_Actividadid ;
         }

         set {
            if ( gxTv_SdtActividad_Actividadid != value )
            {
               gxTv_SdtActividad_Mode = "INS";
               this.gxTv_SdtActividad_Actividadid_Z_SetNull( );
               this.gxTv_SdtActividad_Actividaddescripcion_Z_SetNull( );
               this.gxTv_SdtActividad_Actividadcantidadprofesores_Z_SetNull( );
            }
            gxTv_SdtActividad_Actividadid = value;
            SetDirty("Actividadid");
         }

      }

      [  SoapElement( ElementName = "ActividadDescripcion" )]
      [  XmlElement( ElementName = "ActividadDescripcion"   )]
      public String gxTpr_Actividaddescripcion
      {
         get {
            return gxTv_SdtActividad_Actividaddescripcion ;
         }

         set {
            gxTv_SdtActividad_Actividaddescripcion = value;
            SetDirty("Actividaddescripcion");
         }

      }

      [  SoapElement( ElementName = "ActividadCantidadProfesores" )]
      [  XmlElement( ElementName = "ActividadCantidadProfesores"   )]
      public short gxTpr_Actividadcantidadprofesores
      {
         get {
            return gxTv_SdtActividad_Actividadcantidadprofesores ;
         }

         set {
            gxTv_SdtActividad_Actividadcantidadprofesores = value;
            SetDirty("Actividadcantidadprofesores");
         }

      }

      public void gxTv_SdtActividad_Actividadcantidadprofesores_SetNull( )
      {
         gxTv_SdtActividad_Actividadcantidadprofesores = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_Actividadcantidadprofesores_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtActividad_Mode ;
         }

         set {
            gxTv_SdtActividad_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtActividad_Mode_SetNull( )
      {
         gxTv_SdtActividad_Mode = "";
         return  ;
      }

      public bool gxTv_SdtActividad_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtActividad_Initialized ;
         }

         set {
            gxTv_SdtActividad_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtActividad_Initialized_SetNull( )
      {
         gxTv_SdtActividad_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadId_Z" )]
      [  XmlElement( ElementName = "ActividadId_Z"   )]
      public short gxTpr_Actividadid_Z
      {
         get {
            return gxTv_SdtActividad_Actividadid_Z ;
         }

         set {
            gxTv_SdtActividad_Actividadid_Z = value;
            SetDirty("Actividadid_Z");
         }

      }

      public void gxTv_SdtActividad_Actividadid_Z_SetNull( )
      {
         gxTv_SdtActividad_Actividadid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_Actividadid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadDescripcion_Z" )]
      [  XmlElement( ElementName = "ActividadDescripcion_Z"   )]
      public String gxTpr_Actividaddescripcion_Z
      {
         get {
            return gxTv_SdtActividad_Actividaddescripcion_Z ;
         }

         set {
            gxTv_SdtActividad_Actividaddescripcion_Z = value;
            SetDirty("Actividaddescripcion_Z");
         }

      }

      public void gxTv_SdtActividad_Actividaddescripcion_Z_SetNull( )
      {
         gxTv_SdtActividad_Actividaddescripcion_Z = "";
         return  ;
      }

      public bool gxTv_SdtActividad_Actividaddescripcion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadCantidadProfesores_Z" )]
      [  XmlElement( ElementName = "ActividadCantidadProfesores_Z"   )]
      public short gxTpr_Actividadcantidadprofesores_Z
      {
         get {
            return gxTv_SdtActividad_Actividadcantidadprofesores_Z ;
         }

         set {
            gxTv_SdtActividad_Actividadcantidadprofesores_Z = value;
            SetDirty("Actividadcantidadprofesores_Z");
         }

      }

      public void gxTv_SdtActividad_Actividadcantidadprofesores_Z_SetNull( )
      {
         gxTv_SdtActividad_Actividadcantidadprofesores_Z = 0;
         return  ;
      }

      public bool gxTv_SdtActividad_Actividadcantidadprofesores_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtActividad_Actividaddescripcion = "";
         gxTv_SdtActividad_Mode = "";
         gxTv_SdtActividad_Actividaddescripcion_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "actividad", "GeneXus.Programs.actividad_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtActividad_Actividadid ;
      private short gxTv_SdtActividad_Actividadcantidadprofesores ;
      private short gxTv_SdtActividad_Initialized ;
      private short gxTv_SdtActividad_Actividadid_Z ;
      private short gxTv_SdtActividad_Actividadcantidadprofesores_Z ;
      private String gxTv_SdtActividad_Actividaddescripcion ;
      private String gxTv_SdtActividad_Mode ;
      private String gxTv_SdtActividad_Actividaddescripcion_Z ;
   }

   [DataContract(Name = @"Actividad", Namespace = "ObligatorioGenexusGit")]
   public class SdtActividad_RESTInterface : GxGenericCollectionItem<SdtActividad>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtActividad_RESTInterface( ) : base()
      {
      }

      public SdtActividad_RESTInterface( SdtActividad psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ActividadId" , Order = 0 )]
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

      [DataMember( Name = "ActividadDescripcion" , Order = 1 )]
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

      [DataMember( Name = "ActividadCantidadProfesores" , Order = 2 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Actividadcantidadprofesores
      {
         get {
            return sdt.gxTpr_Actividadcantidadprofesores ;
         }

         set {
            sdt.gxTpr_Actividadcantidadprofesores = (short)(value.HasValue ? value.Value : 0);
         }

      }

      public SdtActividad sdt
      {
         get {
            return (SdtActividad)Sdt ;
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
            sdt = new SdtActividad() ;
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

   [DataContract(Name = @"Actividad", Namespace = "ObligatorioGenexusGit")]
   public class SdtActividad_RESTLInterface : GxGenericCollectionItem<SdtActividad>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtActividad_RESTLInterface( ) : base()
      {
      }

      public SdtActividad_RESTLInterface( SdtActividad psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ActividadDescripcion" , Order = 0 )]
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

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            return "" ;
         }

         set {
         }

      }

      public SdtActividad sdt
      {
         get {
            return (SdtActividad)Sdt ;
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
            sdt = new SdtActividad() ;
         }
      }

   }

}
