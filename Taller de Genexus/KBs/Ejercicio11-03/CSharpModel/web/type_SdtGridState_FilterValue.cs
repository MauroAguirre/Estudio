/*
				   File: type_SdtGridState_FilterValue
			Description: FilterValues
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 14/03/2019 20:07:10
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
	[XmlRoot(ElementName="GridState.FilterValue")]
	[XmlType(TypeName="GridState.FilterValue" , Namespace="Ejercicio1103" )]
	[Serializable]
	public class SdtGridState_FilterValue : GxUserType
	{
		public SdtGridState_FilterValue( )
		{
			/* Constructor for serialization */
			gxTv_SdtGridState_FilterValue_Value = "";

		}

		public SdtGridState_FilterValue(IGxContext context)
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
			AddObjectProperty("Value", gxTpr_Value, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Value")]
		[XmlElement(ElementName="Value")]
		public String gxTpr_Value
		{
			get { 
				return gxTv_SdtGridState_FilterValue_Value; 
			}
			set { 
				gxTv_SdtGridState_FilterValue_Value = value;
				SetDirty("Value");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtGridState_FilterValue_Value = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtGridState_FilterValue_Value;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"GridState.FilterValue", Namespace="Ejercicio1103")]
	public class SdtGridState_FilterValue_RESTInterface : GxGenericCollectionItem<SdtGridState_FilterValue>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtGridState_FilterValue_RESTInterface( ) : base()
		{
		}

		public SdtGridState_FilterValue_RESTInterface( SdtGridState_FilterValue psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Value", Order=0)]
		public String gxTpr_Value
		{
			get { 
				return sdt.gxTpr_Value;
			}
			set { 
				sdt.gxTpr_Value = value;
			}
		}


		#endregion

		public SdtGridState_FilterValue sdt
		{
			get { 
				return (SdtGridState_FilterValue)Sdt;
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
				sdt = new SdtGridState_FilterValue() ;
			}
		}
	}
	#endregion
}