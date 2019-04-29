/*
				   File: type_SdtGoogleChart_Series
			Description: Series
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
	[XmlRoot(ElementName="GoogleChart.Series")]
	[XmlType(TypeName="GoogleChart.Series" , Namespace="ObligatorioGenexusGit" )]
	[Serializable]
	public class SdtGoogleChart_Series : GxUserType
	{
		public SdtGoogleChart_Series( )
		{
			/* Constructor for serialization */
			gxTv_SdtGoogleChart_Series_Name = "";

		}

		public SdtGoogleChart_Series(IGxContext context)
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
			AddObjectProperty("Name", gxTpr_Name, false);
			AddObjectProperty("Values", gxTv_SdtGoogleChart_Series_Values, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtGoogleChart_Series_Name; 
			}
			set { 
				gxTv_SdtGoogleChart_Series_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Values" )]
		[XmlArray(ElementName="Values"  )]
		[XmlArrayItemAttribute(ElementName="Item" , IsNullable=false )]
		public GxSimpleCollection<decimal> gxTpr_Values_GxSimpleCollection
		{
			get {
				if ( gxTv_SdtGoogleChart_Series_Values == null )
				{
					gxTv_SdtGoogleChart_Series_Values = new GxSimpleCollection<decimal>( );
				}
				return gxTv_SdtGoogleChart_Series_Values;
			}
			set {
				if ( gxTv_SdtGoogleChart_Series_Values == null )
				{
					gxTv_SdtGoogleChart_Series_Values = new GxSimpleCollection<decimal>( );
				}
				gxTv_SdtGoogleChart_Series_Values = value;
			}
		}

		[SoapIgnore]
		[XmlIgnore]
		public GxSimpleCollection<decimal> gxTpr_Values
		{
			get {
				if ( gxTv_SdtGoogleChart_Series_Values == null )
				{
					gxTv_SdtGoogleChart_Series_Values = new GxSimpleCollection<decimal>();
				}
				return gxTv_SdtGoogleChart_Series_Values ;
			}
			set {
				gxTv_SdtGoogleChart_Series_Values = value;
				SetDirty("Values");
			}
		}

		public void gxTv_SdtGoogleChart_Series_Values_SetNull()
		{
			gxTv_SdtGoogleChart_Series_Values = null;
			return  ;
		}

		public bool gxTv_SdtGoogleChart_Series_Values_IsNull()
		{
			if (gxTv_SdtGoogleChart_Series_Values == null)
			{
				return true ;
			}
			return false ;
		}



		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtGoogleChart_Series_Name = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtGoogleChart_Series_Name;
		protected GxSimpleCollection<decimal> gxTv_SdtGoogleChart_Series_Values = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"GoogleChart.Series", Namespace="ObligatorioGenexusGit")]
	public class SdtGoogleChart_Series_RESTInterface : GxGenericCollectionItem<SdtGoogleChart_Series>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGoogleChart_Series_RESTInterface( ) : base()
		{
		}

		public SdtGoogleChart_Series_RESTInterface( SdtGoogleChart_Series psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Name", Order=0)]
		public String gxTpr_Name
		{
			get { 
				return StringUtil.RTrim( sdt.gxTpr_Name);
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Values", Order=1)]
		public  GxSimpleCollection<String> gxTpr_Values
		{
			get { 
				return sdt.gxTpr_Values.ToStringCollection(10, 0);
			}
			set { 
				sdt.gxTpr_Values.FromStringCollection(value);
			}
		}


		#endregion

		public SdtGoogleChart_Series sdt
		{
			get { 
				return (SdtGoogleChart_Series)Sdt;
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
				sdt = new SdtGoogleChart_Series() ;
			}
		}
	}
	#endregion
}