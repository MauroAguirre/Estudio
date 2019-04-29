/*
               File: type_SdtClase
        Description: Clase
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:39.84
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
   [XmlRoot(ElementName = "Clase" )]
   [XmlType(TypeName =  "Clase" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtClase : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtClase( )
      {
      }

      public SdtClase( IGxContext context )
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

      public void Load( short AV3ClaseId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV3ClaseId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"ClaseId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Clase");
         metadata.Set("BT", "Clase");
         metadata.Set("PK", "[ \"ClaseId\" ]");
         metadata.Set("PKAssigned", "[ \"ClaseId\" ]");
         metadata.Set("Levels", "[ \"Socios\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"ProfesorId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Claseid_Z");
         state.Add("gxTpr_Actividadid_Z");
         state.Add("gxTpr_Actividaddescripcion_Z");
         state.Add("gxTpr_Profesorid_Z");
         state.Add("gxTpr_Profesornombre_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtClase sdt ;
         sdt = (SdtClase)(source);
         gxTv_SdtClase_Claseid = sdt.gxTv_SdtClase_Claseid ;
         gxTv_SdtClase_Actividadid = sdt.gxTv_SdtClase_Actividadid ;
         gxTv_SdtClase_Actividaddescripcion = sdt.gxTv_SdtClase_Actividaddescripcion ;
         gxTv_SdtClase_Profesorid = sdt.gxTv_SdtClase_Profesorid ;
         gxTv_SdtClase_Profesornombre = sdt.gxTv_SdtClase_Profesornombre ;
         gxTv_SdtClase_Socios = sdt.gxTv_SdtClase_Socios ;
         gxTv_SdtClase_Mode = sdt.gxTv_SdtClase_Mode ;
         gxTv_SdtClase_Initialized = sdt.gxTv_SdtClase_Initialized ;
         gxTv_SdtClase_Claseid_Z = sdt.gxTv_SdtClase_Claseid_Z ;
         gxTv_SdtClase_Actividadid_Z = sdt.gxTv_SdtClase_Actividadid_Z ;
         gxTv_SdtClase_Actividaddescripcion_Z = sdt.gxTv_SdtClase_Actividaddescripcion_Z ;
         gxTv_SdtClase_Profesorid_Z = sdt.gxTv_SdtClase_Profesorid_Z ;
         gxTv_SdtClase_Profesornombre_Z = sdt.gxTv_SdtClase_Profesornombre_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("ClaseId", gxTv_SdtClase_Claseid, false);
         AddObjectProperty("ActividadId", gxTv_SdtClase_Actividadid, false);
         AddObjectProperty("ActividadDescripcion", gxTv_SdtClase_Actividaddescripcion, false);
         AddObjectProperty("ProfesorId", gxTv_SdtClase_Profesorid, false);
         AddObjectProperty("ProfesorNombre", gxTv_SdtClase_Profesornombre, false);
         if ( gxTv_SdtClase_Socios != null )
         {
            AddObjectProperty("Socios", gxTv_SdtClase_Socios, includeState);
         }
         if ( includeState )
         {
            AddObjectProperty("Mode", gxTv_SdtClase_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtClase_Initialized, false);
            AddObjectProperty("ClaseId_Z", gxTv_SdtClase_Claseid_Z, false);
            AddObjectProperty("ActividadId_Z", gxTv_SdtClase_Actividadid_Z, false);
            AddObjectProperty("ActividadDescripcion_Z", gxTv_SdtClase_Actividaddescripcion_Z, false);
            AddObjectProperty("ProfesorId_Z", gxTv_SdtClase_Profesorid_Z, false);
            AddObjectProperty("ProfesorNombre_Z", gxTv_SdtClase_Profesornombre_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtClase sdt )
      {
         if ( sdt.IsDirty("ClaseId") )
         {
            gxTv_SdtClase_Claseid = sdt.gxTv_SdtClase_Claseid ;
         }
         if ( sdt.IsDirty("ActividadId") )
         {
            gxTv_SdtClase_Actividadid = sdt.gxTv_SdtClase_Actividadid ;
         }
         if ( sdt.IsDirty("ActividadDescripcion") )
         {
            gxTv_SdtClase_Actividaddescripcion = sdt.gxTv_SdtClase_Actividaddescripcion ;
         }
         if ( sdt.IsDirty("ProfesorId") )
         {
            gxTv_SdtClase_Profesorid = sdt.gxTv_SdtClase_Profesorid ;
         }
         if ( sdt.IsDirty("ProfesorNombre") )
         {
            gxTv_SdtClase_Profesornombre = sdt.gxTv_SdtClase_Profesornombre ;
         }
         if ( gxTv_SdtClase_Socios != null )
         {
            GXBCLevelCollection<SdtClase_Socios> newCollectionSocios = sdt.gxTpr_Socios ;
            SdtClase_Socios currItemSocios ;
            SdtClase_Socios newItemSocios ;
            short idx = 1 ;
            while ( idx <= newCollectionSocios.Count )
            {
               newItemSocios = ((SdtClase_Socios)newCollectionSocios.Item(idx));
               currItemSocios = gxTv_SdtClase_Socios.GetByKey(newItemSocios.gxTpr_Socioid);
               if ( StringUtil.StrCmp(currItemSocios.gxTpr_Mode, "UPD") == 0 )
               {
                  currItemSocios.UpdateDirties(newItemSocios);
                  if ( StringUtil.StrCmp(newItemSocios.gxTpr_Mode, "DLT") == 0 )
                  {
                     currItemSocios.gxTpr_Mode = "DLT";
                  }
                  currItemSocios.gxTpr_Modified = 1;
               }
               else
               {
                  gxTv_SdtClase_Socios.Add(newItemSocios, 0);
               }
               idx = (short)(idx+1);
            }
         }
         return  ;
      }

      [  SoapElement( ElementName = "ClaseId" )]
      [  XmlElement( ElementName = "ClaseId"   )]
      public short gxTpr_Claseid
      {
         get {
            return gxTv_SdtClase_Claseid ;
         }

         set {
            if ( gxTv_SdtClase_Claseid != value )
            {
               gxTv_SdtClase_Mode = "INS";
               this.gxTv_SdtClase_Claseid_Z_SetNull( );
               this.gxTv_SdtClase_Actividadid_Z_SetNull( );
               this.gxTv_SdtClase_Actividaddescripcion_Z_SetNull( );
               this.gxTv_SdtClase_Profesorid_Z_SetNull( );
               this.gxTv_SdtClase_Profesornombre_Z_SetNull( );
               if ( gxTv_SdtClase_Socios != null )
               {
                  GXBCLevelCollection<SdtClase_Socios> collectionSocios = gxTv_SdtClase_Socios ;
                  SdtClase_Socios currItemSocios ;
                  short idx = 1 ;
                  while ( idx <= collectionSocios.Count )
                  {
                     currItemSocios = ((SdtClase_Socios)collectionSocios.Item(idx));
                     currItemSocios.gxTpr_Mode = "INS";
                     currItemSocios.gxTpr_Modified = 1;
                     idx = (short)(idx+1);
                  }
               }
            }
            gxTv_SdtClase_Claseid = value;
            SetDirty("Claseid");
         }

      }

      [  SoapElement( ElementName = "ActividadId" )]
      [  XmlElement( ElementName = "ActividadId"   )]
      public short gxTpr_Actividadid
      {
         get {
            return gxTv_SdtClase_Actividadid ;
         }

         set {
            gxTv_SdtClase_Actividadid = value;
            SetDirty("Actividadid");
         }

      }

      [  SoapElement( ElementName = "ActividadDescripcion" )]
      [  XmlElement( ElementName = "ActividadDescripcion"   )]
      public String gxTpr_Actividaddescripcion
      {
         get {
            return gxTv_SdtClase_Actividaddescripcion ;
         }

         set {
            gxTv_SdtClase_Actividaddescripcion = value;
            SetDirty("Actividaddescripcion");
         }

      }

      [  SoapElement( ElementName = "ProfesorId" )]
      [  XmlElement( ElementName = "ProfesorId"   )]
      public short gxTpr_Profesorid
      {
         get {
            return gxTv_SdtClase_Profesorid ;
         }

         set {
            gxTv_SdtClase_Profesorid = value;
            SetDirty("Profesorid");
         }

      }

      [  SoapElement( ElementName = "ProfesorNombre" )]
      [  XmlElement( ElementName = "ProfesorNombre"   )]
      public String gxTpr_Profesornombre
      {
         get {
            return gxTv_SdtClase_Profesornombre ;
         }

         set {
            gxTv_SdtClase_Profesornombre = value;
            SetDirty("Profesornombre");
         }

      }

      [  SoapElement( ElementName = "Socios" )]
      [  XmlArray( ElementName = "Socios"  )]
      [  XmlArrayItemAttribute( ElementName= "Clase.Socios"  , IsNullable=false)]
      public GXBCLevelCollection<SdtClase_Socios> gxTpr_Socios_GXBCLevelCollection
      {
         get {
            if ( gxTv_SdtClase_Socios == null )
            {
               gxTv_SdtClase_Socios = new GXBCLevelCollection<SdtClase_Socios>( context, "Clase.Socios", "ObligatorioGenexusGit");
            }
            return gxTv_SdtClase_Socios ;
         }

         set {
            if ( gxTv_SdtClase_Socios == null )
            {
               gxTv_SdtClase_Socios = new GXBCLevelCollection<SdtClase_Socios>( context, "Clase.Socios", "ObligatorioGenexusGit");
            }
            gxTv_SdtClase_Socios = value;
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public GXBCLevelCollection<SdtClase_Socios> gxTpr_Socios
      {
         get {
            if ( gxTv_SdtClase_Socios == null )
            {
               gxTv_SdtClase_Socios = new GXBCLevelCollection<SdtClase_Socios>( context, "Clase.Socios", "ObligatorioGenexusGit");
            }
            return gxTv_SdtClase_Socios ;
         }

         set {
            gxTv_SdtClase_Socios = value;
            SetDirty("Socios");
         }

      }

      public void gxTv_SdtClase_Socios_SetNull( )
      {
         gxTv_SdtClase_Socios = null;
         return  ;
      }

      public bool gxTv_SdtClase_Socios_IsNull( )
      {
         if ( gxTv_SdtClase_Socios == null )
         {
            return true ;
         }
         return false ;
      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtClase_Mode ;
         }

         set {
            gxTv_SdtClase_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtClase_Mode_SetNull( )
      {
         gxTv_SdtClase_Mode = "";
         return  ;
      }

      public bool gxTv_SdtClase_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtClase_Initialized ;
         }

         set {
            gxTv_SdtClase_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtClase_Initialized_SetNull( )
      {
         gxTv_SdtClase_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ClaseId_Z" )]
      [  XmlElement( ElementName = "ClaseId_Z"   )]
      public short gxTpr_Claseid_Z
      {
         get {
            return gxTv_SdtClase_Claseid_Z ;
         }

         set {
            gxTv_SdtClase_Claseid_Z = value;
            SetDirty("Claseid_Z");
         }

      }

      public void gxTv_SdtClase_Claseid_Z_SetNull( )
      {
         gxTv_SdtClase_Claseid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Claseid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadId_Z" )]
      [  XmlElement( ElementName = "ActividadId_Z"   )]
      public short gxTpr_Actividadid_Z
      {
         get {
            return gxTv_SdtClase_Actividadid_Z ;
         }

         set {
            gxTv_SdtClase_Actividadid_Z = value;
            SetDirty("Actividadid_Z");
         }

      }

      public void gxTv_SdtClase_Actividadid_Z_SetNull( )
      {
         gxTv_SdtClase_Actividadid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Actividadid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ActividadDescripcion_Z" )]
      [  XmlElement( ElementName = "ActividadDescripcion_Z"   )]
      public String gxTpr_Actividaddescripcion_Z
      {
         get {
            return gxTv_SdtClase_Actividaddescripcion_Z ;
         }

         set {
            gxTv_SdtClase_Actividaddescripcion_Z = value;
            SetDirty("Actividaddescripcion_Z");
         }

      }

      public void gxTv_SdtClase_Actividaddescripcion_Z_SetNull( )
      {
         gxTv_SdtClase_Actividaddescripcion_Z = "";
         return  ;
      }

      public bool gxTv_SdtClase_Actividaddescripcion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProfesorId_Z" )]
      [  XmlElement( ElementName = "ProfesorId_Z"   )]
      public short gxTpr_Profesorid_Z
      {
         get {
            return gxTv_SdtClase_Profesorid_Z ;
         }

         set {
            gxTv_SdtClase_Profesorid_Z = value;
            SetDirty("Profesorid_Z");
         }

      }

      public void gxTv_SdtClase_Profesorid_Z_SetNull( )
      {
         gxTv_SdtClase_Profesorid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtClase_Profesorid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "ProfesorNombre_Z" )]
      [  XmlElement( ElementName = "ProfesorNombre_Z"   )]
      public String gxTpr_Profesornombre_Z
      {
         get {
            return gxTv_SdtClase_Profesornombre_Z ;
         }

         set {
            gxTv_SdtClase_Profesornombre_Z = value;
            SetDirty("Profesornombre_Z");
         }

      }

      public void gxTv_SdtClase_Profesornombre_Z_SetNull( )
      {
         gxTv_SdtClase_Profesornombre_Z = "";
         return  ;
      }

      public bool gxTv_SdtClase_Profesornombre_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtClase_Actividaddescripcion = "";
         gxTv_SdtClase_Profesornombre = "";
         gxTv_SdtClase_Mode = "";
         gxTv_SdtClase_Actividaddescripcion_Z = "";
         gxTv_SdtClase_Profesornombre_Z = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "clase", "GeneXus.Programs.clase_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtClase_Claseid ;
      private short gxTv_SdtClase_Actividadid ;
      private short gxTv_SdtClase_Profesorid ;
      private short gxTv_SdtClase_Initialized ;
      private short gxTv_SdtClase_Claseid_Z ;
      private short gxTv_SdtClase_Actividadid_Z ;
      private short gxTv_SdtClase_Profesorid_Z ;
      private String gxTv_SdtClase_Actividaddescripcion ;
      private String gxTv_SdtClase_Profesornombre ;
      private String gxTv_SdtClase_Mode ;
      private String gxTv_SdtClase_Actividaddescripcion_Z ;
      private String gxTv_SdtClase_Profesornombre_Z ;
      private GXBCLevelCollection<SdtClase_Socios> gxTv_SdtClase_Socios=null ;
   }

   [DataContract(Name = @"Clase", Namespace = "ObligatorioGenexusGit")]
   public class SdtClase_RESTInterface : GxGenericCollectionItem<SdtClase>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtClase_RESTInterface( ) : base()
      {
      }

      public SdtClase_RESTInterface( SdtClase psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ClaseId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Claseid
      {
         get {
            return sdt.gxTpr_Claseid ;
         }

         set {
            sdt.gxTpr_Claseid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "ActividadId" , Order = 1 )]
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

      [DataMember( Name = "ActividadDescripcion" , Order = 2 )]
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

      [DataMember( Name = "ProfesorId" , Order = 3 )]
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

      [DataMember( Name = "ProfesorNombre" , Order = 4 )]
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

      [DataMember( Name = "Socios" , Order = 5 )]
      public GxGenericCollection<SdtClase_Socios_RESTInterface> gxTpr_Socios
      {
         get {
            return new GxGenericCollection<SdtClase_Socios_RESTInterface>(sdt.gxTpr_Socios) ;
         }

         set {
            value.LoadCollection(sdt.gxTpr_Socios);
         }

      }

      public SdtClase sdt
      {
         get {
            return (SdtClase)Sdt ;
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
            sdt = new SdtClase() ;
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

   [DataContract(Name = @"Clase", Namespace = "ObligatorioGenexusGit")]
   public class SdtClase_RESTLInterface : GxGenericCollectionItem<SdtClase>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtClase_RESTLInterface( ) : base()
      {
      }

      public SdtClase_RESTLInterface( SdtClase psdt ) : base(psdt)
      {
      }

      [DataMember( Name = "ClaseId" , Order = 0 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Claseid
      {
         get {
            return sdt.gxTpr_Claseid ;
         }

         set {
            sdt.gxTpr_Claseid = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            String gxuri = "/rest/Clase/{0}" ;
            gxuri = String.Format(gxuri,gxTpr_Claseid) ;
            return gxuri ;
         }

         set {
         }

      }

      public SdtClase sdt
      {
         get {
            return (SdtClase)Sdt ;
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
            sdt = new SdtClase() ;
         }
      }

      private String gxuri ;
   }

}
