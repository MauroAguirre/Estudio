/*
               File: type_SdtSocio
        Description: Socio
             Author: GeneXus C# Generator version 15_0_12-126726
       Generated on: 4/12/2019 21:1:45.96
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
   [XmlRoot(ElementName = "Socio" )]
   [XmlType(TypeName =  "Socio" , Namespace = "ObligatorioGenexusGit" )]
   [Serializable]
   public class SdtSocio : GxSilentTrnSdt, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSocio( )
      {
      }

      public SdtSocio( IGxContext context )
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

      public void Load( short AV5SocioId )
      {
         IGxSilentTrn obj ;
         obj = getTransaction();
         obj.LoadKey(new Object[] {(short)AV5SocioId});
         return  ;
      }

      public override Object[][] GetBCKey( )
      {
         return (Object[][])(new Object[][]{new Object[]{"SocioId", typeof(short)}}) ;
      }

      public override GXProperties GetMetadata( )
      {
         GXProperties metadata = new GXProperties() ;
         metadata.Set("Name", "Socio");
         metadata.Set("BT", "Socio");
         metadata.Set("PK", "[ \"SocioId\" ]");
         metadata.Set("PKAssigned", "[ \"SocioId\" ]");
         metadata.Set("FKList", "[ { \"FK\":[ \"CarnetId\" ],\"FKMap\":[  ] } ]");
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
         state.Add("gxTpr_Initialized");
         state.Add("gxTpr_Socioid_Z");
         state.Add("gxTpr_Sociodireccion_Z");
         state.Add("gxTpr_Sociosexo_Z");
         state.Add("gxTpr_Socioedad_Z");
         state.Add("gxTpr_Sociotipocuota_Z");
         state.Add("gxTpr_Socioreconocido_Z");
         state.Add("gxTpr_Sociomonto_Z");
         state.Add("gxTpr_Carnetid_Z");
         state.Add("gxTpr_Carnetfechaingreso_Z_Nullable");
         state.Add("gxTpr_Sociofoto_gxi_Z");
         return state ;
      }

      public override void Copy( GxUserType source )
      {
         SdtSocio sdt ;
         sdt = (SdtSocio)(source);
         gxTv_SdtSocio_Socioid = sdt.gxTv_SdtSocio_Socioid ;
         gxTv_SdtSocio_Sociodireccion = sdt.gxTv_SdtSocio_Sociodireccion ;
         gxTv_SdtSocio_Sociosexo = sdt.gxTv_SdtSocio_Sociosexo ;
         gxTv_SdtSocio_Socioedad = sdt.gxTv_SdtSocio_Socioedad ;
         gxTv_SdtSocio_Sociotipocuota = sdt.gxTv_SdtSocio_Sociotipocuota ;
         gxTv_SdtSocio_Socioreconocido = sdt.gxTv_SdtSocio_Socioreconocido ;
         gxTv_SdtSocio_Sociofoto = sdt.gxTv_SdtSocio_Sociofoto ;
         gxTv_SdtSocio_Sociofoto_gxi = sdt.gxTv_SdtSocio_Sociofoto_gxi ;
         gxTv_SdtSocio_Sociomonto = sdt.gxTv_SdtSocio_Sociomonto ;
         gxTv_SdtSocio_Carnetid = sdt.gxTv_SdtSocio_Carnetid ;
         gxTv_SdtSocio_Carnetfechaingreso = sdt.gxTv_SdtSocio_Carnetfechaingreso ;
         gxTv_SdtSocio_Mode = sdt.gxTv_SdtSocio_Mode ;
         gxTv_SdtSocio_Initialized = sdt.gxTv_SdtSocio_Initialized ;
         gxTv_SdtSocio_Socioid_Z = sdt.gxTv_SdtSocio_Socioid_Z ;
         gxTv_SdtSocio_Sociodireccion_Z = sdt.gxTv_SdtSocio_Sociodireccion_Z ;
         gxTv_SdtSocio_Sociosexo_Z = sdt.gxTv_SdtSocio_Sociosexo_Z ;
         gxTv_SdtSocio_Socioedad_Z = sdt.gxTv_SdtSocio_Socioedad_Z ;
         gxTv_SdtSocio_Sociotipocuota_Z = sdt.gxTv_SdtSocio_Sociotipocuota_Z ;
         gxTv_SdtSocio_Socioreconocido_Z = sdt.gxTv_SdtSocio_Socioreconocido_Z ;
         gxTv_SdtSocio_Sociomonto_Z = sdt.gxTv_SdtSocio_Sociomonto_Z ;
         gxTv_SdtSocio_Carnetid_Z = sdt.gxTv_SdtSocio_Carnetid_Z ;
         gxTv_SdtSocio_Carnetfechaingreso_Z = sdt.gxTv_SdtSocio_Carnetfechaingreso_Z ;
         gxTv_SdtSocio_Sociofoto_gxi_Z = sdt.gxTv_SdtSocio_Sociofoto_gxi_Z ;
         return  ;
      }

      public override void ToJSON( )
      {
         ToJSON( true) ;
         return  ;
      }

      public override void ToJSON( bool includeState )
      {
         AddObjectProperty("SocioId", gxTv_SdtSocio_Socioid, false);
         AddObjectProperty("SocioDireccion", gxTv_SdtSocio_Sociodireccion, false);
         AddObjectProperty("SocioSexo", gxTv_SdtSocio_Sociosexo, false);
         AddObjectProperty("SocioEdad", gxTv_SdtSocio_Socioedad, false);
         AddObjectProperty("SocioTipoCuota", gxTv_SdtSocio_Sociotipocuota, false);
         AddObjectProperty("SocioReconocido", gxTv_SdtSocio_Socioreconocido, false);
         AddObjectProperty("SocioFoto", gxTv_SdtSocio_Sociofoto, false);
         AddObjectProperty("SocioMonto", gxTv_SdtSocio_Sociomonto, false);
         AddObjectProperty("CarnetId", gxTv_SdtSocio_Carnetid, false);
         sDateCnv = "";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSocio_Carnetfechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSocio_Carnetfechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         sDateCnv = sDateCnv + "-";
         sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSocio_Carnetfechaingreso)), 10, 0));
         sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
         AddObjectProperty("CarnetFechaIngreso", sDateCnv, false);
         if ( includeState )
         {
            AddObjectProperty("SocioFoto_GXI", gxTv_SdtSocio_Sociofoto_gxi, false);
            AddObjectProperty("Mode", gxTv_SdtSocio_Mode, false);
            AddObjectProperty("Initialized", gxTv_SdtSocio_Initialized, false);
            AddObjectProperty("SocioId_Z", gxTv_SdtSocio_Socioid_Z, false);
            AddObjectProperty("SocioDireccion_Z", gxTv_SdtSocio_Sociodireccion_Z, false);
            AddObjectProperty("SocioSexo_Z", gxTv_SdtSocio_Sociosexo_Z, false);
            AddObjectProperty("SocioEdad_Z", gxTv_SdtSocio_Socioedad_Z, false);
            AddObjectProperty("SocioTipoCuota_Z", gxTv_SdtSocio_Sociotipocuota_Z, false);
            AddObjectProperty("SocioReconocido_Z", gxTv_SdtSocio_Socioreconocido_Z, false);
            AddObjectProperty("SocioMonto_Z", gxTv_SdtSocio_Sociomonto_Z, false);
            AddObjectProperty("CarnetId_Z", gxTv_SdtSocio_Carnetid_Z, false);
            sDateCnv = "";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Year( gxTv_SdtSocio_Carnetfechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "0000", 1, 4-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Month( gxTv_SdtSocio_Carnetfechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            sDateCnv = sDateCnv + "-";
            sNumToPad = StringUtil.Trim( StringUtil.Str( (decimal)(DateTimeUtil.Day( gxTv_SdtSocio_Carnetfechaingreso_Z)), 10, 0));
            sDateCnv = sDateCnv + StringUtil.Substring( "00", 1, 2-StringUtil.Len( sNumToPad)) + sNumToPad;
            AddObjectProperty("CarnetFechaIngreso_Z", sDateCnv, false);
            AddObjectProperty("SocioFoto_GXI_Z", gxTv_SdtSocio_Sociofoto_gxi_Z, false);
         }
         return  ;
      }

      public void UpdateDirties( SdtSocio sdt )
      {
         if ( sdt.IsDirty("SocioId") )
         {
            gxTv_SdtSocio_Socioid = sdt.gxTv_SdtSocio_Socioid ;
         }
         if ( sdt.IsDirty("SocioDireccion") )
         {
            gxTv_SdtSocio_Sociodireccion = sdt.gxTv_SdtSocio_Sociodireccion ;
         }
         if ( sdt.IsDirty("SocioSexo") )
         {
            gxTv_SdtSocio_Sociosexo = sdt.gxTv_SdtSocio_Sociosexo ;
         }
         if ( sdt.IsDirty("SocioEdad") )
         {
            gxTv_SdtSocio_Socioedad = sdt.gxTv_SdtSocio_Socioedad ;
         }
         if ( sdt.IsDirty("SocioTipoCuota") )
         {
            gxTv_SdtSocio_Sociotipocuota = sdt.gxTv_SdtSocio_Sociotipocuota ;
         }
         if ( sdt.IsDirty("SocioReconocido") )
         {
            gxTv_SdtSocio_Socioreconocido = sdt.gxTv_SdtSocio_Socioreconocido ;
         }
         if ( sdt.IsDirty("SocioFoto") )
         {
            gxTv_SdtSocio_Sociofoto = sdt.gxTv_SdtSocio_Sociofoto ;
         }
         if ( sdt.IsDirty("SocioFoto") )
         {
            gxTv_SdtSocio_Sociofoto_gxi = sdt.gxTv_SdtSocio_Sociofoto_gxi ;
         }
         if ( sdt.IsDirty("SocioMonto") )
         {
            gxTv_SdtSocio_Sociomonto = sdt.gxTv_SdtSocio_Sociomonto ;
         }
         if ( sdt.IsDirty("CarnetId") )
         {
            gxTv_SdtSocio_Carnetid = sdt.gxTv_SdtSocio_Carnetid ;
         }
         if ( sdt.IsDirty("CarnetFechaIngreso") )
         {
            gxTv_SdtSocio_Carnetfechaingreso = sdt.gxTv_SdtSocio_Carnetfechaingreso ;
         }
         return  ;
      }

      [  SoapElement( ElementName = "SocioId" )]
      [  XmlElement( ElementName = "SocioId"   )]
      public short gxTpr_Socioid
      {
         get {
            return gxTv_SdtSocio_Socioid ;
         }

         set {
            if ( gxTv_SdtSocio_Socioid != value )
            {
               gxTv_SdtSocio_Mode = "INS";
               this.gxTv_SdtSocio_Socioid_Z_SetNull( );
               this.gxTv_SdtSocio_Sociodireccion_Z_SetNull( );
               this.gxTv_SdtSocio_Sociosexo_Z_SetNull( );
               this.gxTv_SdtSocio_Socioedad_Z_SetNull( );
               this.gxTv_SdtSocio_Sociotipocuota_Z_SetNull( );
               this.gxTv_SdtSocio_Socioreconocido_Z_SetNull( );
               this.gxTv_SdtSocio_Sociomonto_Z_SetNull( );
               this.gxTv_SdtSocio_Carnetid_Z_SetNull( );
               this.gxTv_SdtSocio_Carnetfechaingreso_Z_SetNull( );
               this.gxTv_SdtSocio_Sociofoto_gxi_Z_SetNull( );
            }
            gxTv_SdtSocio_Socioid = value;
            SetDirty("Socioid");
         }

      }

      [  SoapElement( ElementName = "SocioDireccion" )]
      [  XmlElement( ElementName = "SocioDireccion"   )]
      public String gxTpr_Sociodireccion
      {
         get {
            return gxTv_SdtSocio_Sociodireccion ;
         }

         set {
            gxTv_SdtSocio_Sociodireccion = value;
            SetDirty("Sociodireccion");
         }

      }

      [  SoapElement( ElementName = "SocioSexo" )]
      [  XmlElement( ElementName = "SocioSexo"   )]
      public String gxTpr_Sociosexo
      {
         get {
            return gxTv_SdtSocio_Sociosexo ;
         }

         set {
            gxTv_SdtSocio_Sociosexo = value;
            SetDirty("Sociosexo");
         }

      }

      [  SoapElement( ElementName = "SocioEdad" )]
      [  XmlElement( ElementName = "SocioEdad"   )]
      public short gxTpr_Socioedad
      {
         get {
            return gxTv_SdtSocio_Socioedad ;
         }

         set {
            gxTv_SdtSocio_Socioedad = value;
            SetDirty("Socioedad");
         }

      }

      [  SoapElement( ElementName = "SocioTipoCuota" )]
      [  XmlElement( ElementName = "SocioTipoCuota"   )]
      public String gxTpr_Sociotipocuota
      {
         get {
            return gxTv_SdtSocio_Sociotipocuota ;
         }

         set {
            gxTv_SdtSocio_Sociotipocuota = value;
            SetDirty("Sociotipocuota");
         }

      }

      [  SoapElement( ElementName = "SocioReconocido" )]
      [  XmlElement( ElementName = "SocioReconocido"   )]
      public bool gxTpr_Socioreconocido
      {
         get {
            return gxTv_SdtSocio_Socioreconocido ;
         }

         set {
            gxTv_SdtSocio_Socioreconocido = value;
            SetDirty("Socioreconocido");
         }

      }

      [  SoapElement( ElementName = "SocioFoto" )]
      [  XmlElement( ElementName = "SocioFoto"   )]
      [GxUpload()]
      public String gxTpr_Sociofoto
      {
         get {
            return gxTv_SdtSocio_Sociofoto ;
         }

         set {
            gxTv_SdtSocio_Sociofoto = value;
            SetDirty("Sociofoto");
         }

      }

      [  SoapElement( ElementName = "SocioFoto_GXI" )]
      [  XmlElement( ElementName = "SocioFoto_GXI"   )]
      public String gxTpr_Sociofoto_gxi
      {
         get {
            return gxTv_SdtSocio_Sociofoto_gxi ;
         }

         set {
            gxTv_SdtSocio_Sociofoto_gxi = value;
            SetDirty("Sociofoto_gxi");
         }

      }

      [  SoapElement( ElementName = "SocioMonto" )]
      [  XmlElement( ElementName = "SocioMonto"   )]
      public short gxTpr_Sociomonto
      {
         get {
            return gxTv_SdtSocio_Sociomonto ;
         }

         set {
            gxTv_SdtSocio_Sociomonto = value;
            SetDirty("Sociomonto");
         }

      }

      public void gxTv_SdtSocio_Sociomonto_SetNull( )
      {
         gxTv_SdtSocio_Sociomonto = 0;
         return  ;
      }

      public bool gxTv_SdtSocio_Sociomonto_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarnetId" )]
      [  XmlElement( ElementName = "CarnetId"   )]
      public short gxTpr_Carnetid
      {
         get {
            return gxTv_SdtSocio_Carnetid ;
         }

         set {
            gxTv_SdtSocio_Carnetid = value;
            SetDirty("Carnetid");
         }

      }

      [  SoapElement( ElementName = "CarnetFechaIngreso" )]
      [  XmlElement( ElementName = "CarnetFechaIngreso"  , IsNullable=true )]
      public string gxTpr_Carnetfechaingreso_Nullable
      {
         get {
            if ( gxTv_SdtSocio_Carnetfechaingreso == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtSocio_Carnetfechaingreso).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtSocio_Carnetfechaingreso = DateTime.MinValue;
            else
               gxTv_SdtSocio_Carnetfechaingreso = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Carnetfechaingreso
      {
         get {
            return gxTv_SdtSocio_Carnetfechaingreso ;
         }

         set {
            gxTv_SdtSocio_Carnetfechaingreso = value;
            SetDirty("Carnetfechaingreso");
         }

      }

      [  SoapElement( ElementName = "Mode" )]
      [  XmlElement( ElementName = "Mode"   )]
      public String gxTpr_Mode
      {
         get {
            return gxTv_SdtSocio_Mode ;
         }

         set {
            gxTv_SdtSocio_Mode = value;
            SetDirty("Mode");
         }

      }

      public void gxTv_SdtSocio_Mode_SetNull( )
      {
         gxTv_SdtSocio_Mode = "";
         return  ;
      }

      public bool gxTv_SdtSocio_Mode_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "Initialized" )]
      [  XmlElement( ElementName = "Initialized"   )]
      public short gxTpr_Initialized
      {
         get {
            return gxTv_SdtSocio_Initialized ;
         }

         set {
            gxTv_SdtSocio_Initialized = value;
            SetDirty("Initialized");
         }

      }

      public void gxTv_SdtSocio_Initialized_SetNull( )
      {
         gxTv_SdtSocio_Initialized = 0;
         return  ;
      }

      public bool gxTv_SdtSocio_Initialized_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioId_Z" )]
      [  XmlElement( ElementName = "SocioId_Z"   )]
      public short gxTpr_Socioid_Z
      {
         get {
            return gxTv_SdtSocio_Socioid_Z ;
         }

         set {
            gxTv_SdtSocio_Socioid_Z = value;
            SetDirty("Socioid_Z");
         }

      }

      public void gxTv_SdtSocio_Socioid_Z_SetNull( )
      {
         gxTv_SdtSocio_Socioid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSocio_Socioid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioDireccion_Z" )]
      [  XmlElement( ElementName = "SocioDireccion_Z"   )]
      public String gxTpr_Sociodireccion_Z
      {
         get {
            return gxTv_SdtSocio_Sociodireccion_Z ;
         }

         set {
            gxTv_SdtSocio_Sociodireccion_Z = value;
            SetDirty("Sociodireccion_Z");
         }

      }

      public void gxTv_SdtSocio_Sociodireccion_Z_SetNull( )
      {
         gxTv_SdtSocio_Sociodireccion_Z = "";
         return  ;
      }

      public bool gxTv_SdtSocio_Sociodireccion_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioSexo_Z" )]
      [  XmlElement( ElementName = "SocioSexo_Z"   )]
      public String gxTpr_Sociosexo_Z
      {
         get {
            return gxTv_SdtSocio_Sociosexo_Z ;
         }

         set {
            gxTv_SdtSocio_Sociosexo_Z = value;
            SetDirty("Sociosexo_Z");
         }

      }

      public void gxTv_SdtSocio_Sociosexo_Z_SetNull( )
      {
         gxTv_SdtSocio_Sociosexo_Z = "";
         return  ;
      }

      public bool gxTv_SdtSocio_Sociosexo_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioEdad_Z" )]
      [  XmlElement( ElementName = "SocioEdad_Z"   )]
      public short gxTpr_Socioedad_Z
      {
         get {
            return gxTv_SdtSocio_Socioedad_Z ;
         }

         set {
            gxTv_SdtSocio_Socioedad_Z = value;
            SetDirty("Socioedad_Z");
         }

      }

      public void gxTv_SdtSocio_Socioedad_Z_SetNull( )
      {
         gxTv_SdtSocio_Socioedad_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSocio_Socioedad_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioTipoCuota_Z" )]
      [  XmlElement( ElementName = "SocioTipoCuota_Z"   )]
      public String gxTpr_Sociotipocuota_Z
      {
         get {
            return gxTv_SdtSocio_Sociotipocuota_Z ;
         }

         set {
            gxTv_SdtSocio_Sociotipocuota_Z = value;
            SetDirty("Sociotipocuota_Z");
         }

      }

      public void gxTv_SdtSocio_Sociotipocuota_Z_SetNull( )
      {
         gxTv_SdtSocio_Sociotipocuota_Z = "";
         return  ;
      }

      public bool gxTv_SdtSocio_Sociotipocuota_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioReconocido_Z" )]
      [  XmlElement( ElementName = "SocioReconocido_Z"   )]
      public bool gxTpr_Socioreconocido_Z
      {
         get {
            return gxTv_SdtSocio_Socioreconocido_Z ;
         }

         set {
            gxTv_SdtSocio_Socioreconocido_Z = value;
            SetDirty("Socioreconocido_Z");
         }

      }

      public void gxTv_SdtSocio_Socioreconocido_Z_SetNull( )
      {
         gxTv_SdtSocio_Socioreconocido_Z = false;
         return  ;
      }

      public bool gxTv_SdtSocio_Socioreconocido_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioMonto_Z" )]
      [  XmlElement( ElementName = "SocioMonto_Z"   )]
      public short gxTpr_Sociomonto_Z
      {
         get {
            return gxTv_SdtSocio_Sociomonto_Z ;
         }

         set {
            gxTv_SdtSocio_Sociomonto_Z = value;
            SetDirty("Sociomonto_Z");
         }

      }

      public void gxTv_SdtSocio_Sociomonto_Z_SetNull( )
      {
         gxTv_SdtSocio_Sociomonto_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSocio_Sociomonto_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarnetId_Z" )]
      [  XmlElement( ElementName = "CarnetId_Z"   )]
      public short gxTpr_Carnetid_Z
      {
         get {
            return gxTv_SdtSocio_Carnetid_Z ;
         }

         set {
            gxTv_SdtSocio_Carnetid_Z = value;
            SetDirty("Carnetid_Z");
         }

      }

      public void gxTv_SdtSocio_Carnetid_Z_SetNull( )
      {
         gxTv_SdtSocio_Carnetid_Z = 0;
         return  ;
      }

      public bool gxTv_SdtSocio_Carnetid_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "CarnetFechaIngreso_Z" )]
      [  XmlElement( ElementName = "CarnetFechaIngreso_Z"  , IsNullable=true )]
      public string gxTpr_Carnetfechaingreso_Z_Nullable
      {
         get {
            if ( gxTv_SdtSocio_Carnetfechaingreso_Z == DateTime.MinValue)
               return null;
            return new GxDateString(gxTv_SdtSocio_Carnetfechaingreso_Z).value ;
         }

         set {
            if (String.IsNullOrEmpty(value) || value == GxDateString.NullValue )
               gxTv_SdtSocio_Carnetfechaingreso_Z = DateTime.MinValue;
            else
               gxTv_SdtSocio_Carnetfechaingreso_Z = DateTime.Parse( value);
         }

      }

      [SoapIgnore]
      [XmlIgnore]
      public DateTime gxTpr_Carnetfechaingreso_Z
      {
         get {
            return gxTv_SdtSocio_Carnetfechaingreso_Z ;
         }

         set {
            gxTv_SdtSocio_Carnetfechaingreso_Z = value;
            SetDirty("Carnetfechaingreso_Z");
         }

      }

      public void gxTv_SdtSocio_Carnetfechaingreso_Z_SetNull( )
      {
         gxTv_SdtSocio_Carnetfechaingreso_Z = (DateTime)(DateTime.MinValue);
         return  ;
      }

      public bool gxTv_SdtSocio_Carnetfechaingreso_Z_IsNull( )
      {
         return false ;
      }

      [  SoapElement( ElementName = "SocioFoto_GXI_Z" )]
      [  XmlElement( ElementName = "SocioFoto_GXI_Z"   )]
      public String gxTpr_Sociofoto_gxi_Z
      {
         get {
            return gxTv_SdtSocio_Sociofoto_gxi_Z ;
         }

         set {
            gxTv_SdtSocio_Sociofoto_gxi_Z = value;
            SetDirty("Sociofoto_gxi_Z");
         }

      }

      public void gxTv_SdtSocio_Sociofoto_gxi_Z_SetNull( )
      {
         gxTv_SdtSocio_Sociofoto_gxi_Z = "";
         return  ;
      }

      public bool gxTv_SdtSocio_Sociofoto_gxi_Z_IsNull( )
      {
         return false ;
      }

      public void initialize( )
      {
         gxTv_SdtSocio_Sociodireccion = "";
         gxTv_SdtSocio_Sociosexo = "";
         gxTv_SdtSocio_Sociotipocuota = "";
         gxTv_SdtSocio_Sociofoto = "";
         gxTv_SdtSocio_Sociofoto_gxi = "";
         gxTv_SdtSocio_Carnetfechaingreso = DateTime.MinValue;
         gxTv_SdtSocio_Mode = "";
         gxTv_SdtSocio_Sociodireccion_Z = "";
         gxTv_SdtSocio_Sociosexo_Z = "";
         gxTv_SdtSocio_Sociotipocuota_Z = "";
         gxTv_SdtSocio_Carnetfechaingreso_Z = DateTime.MinValue;
         gxTv_SdtSocio_Sociofoto_gxi_Z = "";
         sDateCnv = "";
         sNumToPad = "";
         IGxSilentTrn obj ;
         obj = (IGxSilentTrn)ClassLoader.FindInstance( "socio", "GeneXus.Programs.socio_bc", new Object[] {context}, constructorCallingAssembly);;
         obj.initialize();
         obj.SetSDT(this, 1);
         setTransaction( obj) ;
         obj.SetMode("INS");
         return  ;
      }

      private short gxTv_SdtSocio_Socioid ;
      private short gxTv_SdtSocio_Socioedad ;
      private short gxTv_SdtSocio_Sociomonto ;
      private short gxTv_SdtSocio_Carnetid ;
      private short gxTv_SdtSocio_Initialized ;
      private short gxTv_SdtSocio_Socioid_Z ;
      private short gxTv_SdtSocio_Socioedad_Z ;
      private short gxTv_SdtSocio_Sociomonto_Z ;
      private short gxTv_SdtSocio_Carnetid_Z ;
      private String gxTv_SdtSocio_Sociosexo ;
      private String gxTv_SdtSocio_Sociotipocuota ;
      private String gxTv_SdtSocio_Mode ;
      private String gxTv_SdtSocio_Sociosexo_Z ;
      private String gxTv_SdtSocio_Sociotipocuota_Z ;
      private String sDateCnv ;
      private String sNumToPad ;
      private DateTime gxTv_SdtSocio_Carnetfechaingreso ;
      private DateTime gxTv_SdtSocio_Carnetfechaingreso_Z ;
      private bool gxTv_SdtSocio_Socioreconocido ;
      private bool gxTv_SdtSocio_Socioreconocido_Z ;
      private String gxTv_SdtSocio_Sociodireccion ;
      private String gxTv_SdtSocio_Sociofoto_gxi ;
      private String gxTv_SdtSocio_Sociodireccion_Z ;
      private String gxTv_SdtSocio_Sociofoto_gxi_Z ;
      private String gxTv_SdtSocio_Sociofoto ;
   }

   [DataContract(Name = @"Socio", Namespace = "ObligatorioGenexusGit")]
   public class SdtSocio_RESTInterface : GxGenericCollectionItem<SdtSocio>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSocio_RESTInterface( ) : base()
      {
      }

      public SdtSocio_RESTInterface( SdtSocio psdt ) : base(psdt)
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

      [DataMember( Name = "SocioSexo" , Order = 2 )]
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

      [DataMember( Name = "SocioTipoCuota" , Order = 4 )]
      [GxSeudo()]
      public String gxTpr_Sociotipocuota
      {
         get {
            return StringUtil.RTrim( sdt.gxTpr_Sociotipocuota) ;
         }

         set {
            sdt.gxTpr_Sociotipocuota = value;
         }

      }

      [DataMember( Name = "SocioReconocido" , Order = 5 )]
      [GxSeudo()]
      public bool gxTpr_Socioreconocido
      {
         get {
            return sdt.gxTpr_Socioreconocido ;
         }

         set {
            sdt.gxTpr_Socioreconocido = value;
         }

      }

      [DataMember( Name = "SocioFoto" , Order = 6 )]
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

      [DataMember( Name = "SocioMonto" , Order = 7 )]
      [GxSeudo()]
      public Nullable<short> gxTpr_Sociomonto
      {
         get {
            return sdt.gxTpr_Sociomonto ;
         }

         set {
            sdt.gxTpr_Sociomonto = (short)(value.HasValue ? value.Value : 0);
         }

      }

      [DataMember( Name = "CarnetId" , Order = 8 )]
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

      [DataMember( Name = "CarnetFechaIngreso" , Order = 9 )]
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

      public SdtSocio sdt
      {
         get {
            return (SdtSocio)Sdt ;
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
            sdt = new SdtSocio() ;
         }
      }

      [DataMember( Name = "gx_md5_hash", Order = 10 )]
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

   [DataContract(Name = @"Socio", Namespace = "ObligatorioGenexusGit")]
   public class SdtSocio_RESTLInterface : GxGenericCollectionItem<SdtSocio>, System.Web.SessionState.IRequiresSessionState
   {
      public SdtSocio_RESTLInterface( ) : base()
      {
      }

      public SdtSocio_RESTLInterface( SdtSocio psdt ) : base(psdt)
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

      [DataMember( Name = "uri", Order = 1 )]
      public string Uri
      {
         get {
            String gxuri = "/rest/Socio/{0}" ;
            gxuri = String.Format(gxuri,gxTpr_Socioid) ;
            return gxuri ;
         }

         set {
         }

      }

      public SdtSocio sdt
      {
         get {
            return (SdtSocio)Sdt ;
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
            sdt = new SdtSocio() ;
         }
      }

      private String gxuri ;
   }

}
