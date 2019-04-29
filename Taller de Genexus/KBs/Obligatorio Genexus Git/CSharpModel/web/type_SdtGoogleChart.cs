/*
				   File: type_SdtGoogleChart
			Description: GoogleChart
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 12/04/2019 19:47:31
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
using GeneXus.Http.Server;
using System.Reflection;
using System.Xml.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Runtime.Serialization;

namespace GeneXus.Programs{
	[XmlSerializerFormat]
	[XmlRoot(ElementName="GoogleChart")]
	[XmlType(TypeName="GoogleChart" , Namespace="ObligatorioGenexusGit" )]
	[Serializable]
	public class SdtGoogleChart : GxUserType
	{
		public SdtGoogleChart( )
		{
			/* Constructor for serialization */
		}

		public SdtGoogleChart(IGxContext context)
		{
			this.context = context;
			initialize();
		}

		#region Json
		private static Hashtable mapper;
		public override String JsonMap(String value)
		{
			if (mapper == null)
			{
				mapper = new Hashtable();
			}
			return (String)mapper[value]; ;
		}

		public override void ToJSON()
		{
			ToJSON(true) ;
			return;
		}

		public override void ToJSON(bool includeState)
		{
			AddObjectProperty("Categories", gxTv_SdtGoogleChart_Categories, false);  
			AddObjectProperty("Series", gxTv_SdtGoogleChart_Series, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Categories" )]
		[XmlArray(ElementName="Categories"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<String> gxTpr_Categories_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtGoogleChart_Categories == null )
				{
					gxTv_SdtGoogleChart_Categories = new GxSimpleCollection<String>( );
				}
				return gxTv_SdtGoogleChart_Categories;
			}
			set {
				if ( gxTv_SdtGoogleChart_Categories == null )
				{
					gxTv_SdtGoogleChart_Categories = new GxSimpleCollection<String>( );
				}
				gxTv_SdtGoogleChart_Categories = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<String> gxTpr_Categories
		{
			get {
				if ( gxTv_SdtGoogleChart_Categories == null )
				{
					gxTv_SdtGoogleChart_Categories = new GxSimpleCollection<String>();
				}
				return gxTv_SdtGoogleChart_Categories ;
			}
			set {
				gxTv_SdtGoogleChart_Categories = value;
				SetDirty("Categories");
			}
		}

		public void gxTv_SdtGoogleChart_Categories_SetNull()
		{
			gxTv_SdtGoogleChart_Categories = null;
			return  ;
		}

		public bool gxTv_SdtGoogleChart_Categories_IsNull()
		{
			if (gxTv_SdtGoogleChart_Categories == null)
			{
				return true ;
			}
			return false ;
		}



		[SoapElement(ElementName="Series" )]
		[XmlArray(ElementName="Series"  )]
		[XmlArrayItemAttribute(ElementName="Series" , IsNullable=false )]
		public GXBaseCollection<SdtGoogleChart_Series> gxTpr_Series
		{
			get {
				if ( gxTv_SdtGoogleChart_Series == null )
				{
					gxTv_SdtGoogleChart_Series = new GXBaseCollection<SdtGoogleChart_Series>( context, "GoogleChart.Series", "");
				}
				return gxTv_SdtGoogleChart_Series;
			}
			set {
				if ( gxTv_SdtGoogleChart_Series == null )
				{
					gxTv_SdtGoogleChart_Series = new GXBaseCollection<SdtGoogleChart_Series>( context, "GoogleChart.Series", "");
				}
				gxTv_SdtGoogleChart_Series = value;
				SetDirty("Series");
			}
		}

		public void gxTv_SdtGoogleChart_Series_SetNull()
		{
			gxTv_SdtGoogleChart_Series = null;
			return  ;
		}

		public bool gxTv_SdtGoogleChart_Series_IsNull()
		{
			if (gxTv_SdtGoogleChart_Series == null)
			{
				return true ;
			}
			return false ;
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			return  ;
		}



		#endregion

		#region Declaration

		protected GxSimpleCollection<String> gxTv_SdtGoogleChart_Categories = null; protected GXBaseCollection<SdtGoogleChart_Series> gxTv_SdtGoogleChart_Series = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"GoogleChart", Namespace="ObligatorioGenexusGit")]
	public class SdtGoogleChart_RESTInterface : GxGenericCollectionItem<SdtGoogleChart>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGoogleChart_RESTInterface( ) : base()
		{
		}

		public SdtGoogleChart_RESTInterface( SdtGoogleChart psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Categories", Order=0)]
		public  GxSimpleCollection<String> gxTpr_Categories
		{
			get { 
				return sdt.gxTpr_Categories;
			}
			set { 
				sdt.gxTpr_Categories = value;
			}
		}

		[DataMember(Name="Series", Order=1)]
		public GxGenericCollection<SdtGoogleChart_Series_RESTInterface> gxTpr_Series
		{
			get {
				return new GxGenericCollection<SdtGoogleChart_Series_RESTInterface>(sdt.gxTpr_Series) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Series);
			}

		}


		#endregion

		public SdtGoogleChart sdt
		{
			get { 
				return (SdtGoogleChart)Sdt;
			}
			set { 
				Sdt = value;
			}
		}

		[OnDeserializing]
		void checkSdt( StreamingContext ctx )
		{
			if ( sdt == null )
			{
				sdt = new SdtGoogleChart() ;
			}
		}
	}
	#endregion
}