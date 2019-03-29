/*
				   File: type_SdtTransactionContext
			Description: TransactionContext
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 22/03/2019 19:01:42
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
	[XmlRoot(ElementName="TransactionContext")]
	[XmlType(TypeName="TransactionContext" , Namespace="ObligatorioGenexusGit" )]
	[Serializable]
	public class SdtTransactionContext : GxUserType
	{
		public SdtTransactionContext( )
		{
			/* Constructor for serialization */
			gxTv_SdtTransactionContext_Callerobject = "";

			gxTv_SdtTransactionContext_Callerurl = "";

			gxTv_SdtTransactionContext_Transactionname = "";

		}

		public SdtTransactionContext(IGxContext context)
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
			AddObjectProperty("CallerObject", gxTpr_Callerobject, false);
			AddObjectProperty("CallerOnDelete", gxTpr_Callerondelete, false);
			AddObjectProperty("CallerURL", gxTpr_Callerurl, false);
			AddObjectProperty("TransactionName", gxTpr_Transactionname, false);
			AddObjectProperty("Attributes", gxTv_SdtTransactionContext_Attributes, false);  
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="CallerObject")]
		[XmlElement(ElementName="CallerObject")]
		public String gxTpr_Callerobject
		{
			get { 
				return gxTv_SdtTransactionContext_Callerobject; 
			}
			set { 
				gxTv_SdtTransactionContext_Callerobject = value;
				SetDirty("Callerobject");
			}
		}


		[SoapElement(ElementName="CallerOnDelete")]
		[XmlElement(ElementName="CallerOnDelete")]
		public bool gxTpr_Callerondelete
		{
			get { 
				return gxTv_SdtTransactionContext_Callerondelete; 
			}
			set { 
				gxTv_SdtTransactionContext_Callerondelete = value;
				SetDirty("Callerondelete");
			}
		}


		[SoapElement(ElementName="CallerURL")]
		[XmlElement(ElementName="CallerURL")]
		public String gxTpr_Callerurl
		{
			get { 
				return gxTv_SdtTransactionContext_Callerurl; 
			}
			set { 
				gxTv_SdtTransactionContext_Callerurl = value;
				SetDirty("Callerurl");
			}
		}


		[SoapElement(ElementName="TransactionName")]
		[XmlElement(ElementName="TransactionName")]
		public String gxTpr_Transactionname
		{
			get { 
				return gxTv_SdtTransactionContext_Transactionname; 
			}
			set { 
				gxTv_SdtTransactionContext_Transactionname = value;
				SetDirty("Transactionname");
			}
		}


		[SoapElement(ElementName="Attributes" )]
		[XmlArray(ElementName="Attributes"  )]
		[XmlArrayItemAttribute(ElementName="Attribute" , IsNullable=false )]
		public GXBaseCollection<SdtTransactionContext_Attribute> gxTpr_Attributes
		{
			get {
				if ( gxTv_SdtTransactionContext_Attributes == null )
				{
					gxTv_SdtTransactionContext_Attributes = new GXBaseCollection<SdtTransactionContext_Attribute>( context, "TransactionContext.Attribute", "");
				}
				return gxTv_SdtTransactionContext_Attributes;
			}
			set {
				if ( gxTv_SdtTransactionContext_Attributes == null )
				{
					gxTv_SdtTransactionContext_Attributes = new GXBaseCollection<SdtTransactionContext_Attribute>( context, "TransactionContext.Attribute", "");
				}
				gxTv_SdtTransactionContext_Attributes = value;
				SetDirty("Attributes");
			}
		}

		public void gxTv_SdtTransactionContext_Attributes_SetNull()
		{
			gxTv_SdtTransactionContext_Attributes = null;
			return  ;
		}

		public bool gxTv_SdtTransactionContext_Attributes_IsNull()
		{
			if (gxTv_SdtTransactionContext_Attributes == null)
			{
				return true ;
			}
			return false ;
		}




		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtTransactionContext_Callerobject = "";

			gxTv_SdtTransactionContext_Callerurl = "";
			gxTv_SdtTransactionContext_Transactionname = "";

			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtTransactionContext_Callerobject;
		protected bool gxTv_SdtTransactionContext_Callerondelete;
		protected String gxTv_SdtTransactionContext_Callerurl;
		protected String gxTv_SdtTransactionContext_Transactionname;
		protected GXBaseCollection<SdtTransactionContext_Attribute> gxTv_SdtTransactionContext_Attributes = null; 


		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"TransactionContext", Namespace="ObligatorioGenexusGit")]
	public class SdtTransactionContext_RESTInterface : GxGenericCollectionItem<SdtTransactionContext>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtTransactionContext_RESTInterface( ) : base()
		{
		}

		public SdtTransactionContext_RESTInterface( SdtTransactionContext psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="CallerObject", Order=0)]
		public String gxTpr_Callerobject
		{
			get { 
				return sdt.gxTpr_Callerobject;
			}
			set { 
				sdt.gxTpr_Callerobject = value;
			}
		}

		[DataMember(Name="CallerOnDelete", Order=1)]
		public bool gxTpr_Callerondelete
		{
			get { 
				return sdt.gxTpr_Callerondelete;
			}
			set { 
				sdt.gxTpr_Callerondelete = value;
			}
		}

		[DataMember(Name="CallerURL", Order=2)]
		public String gxTpr_Callerurl
		{
			get { 
				return sdt.gxTpr_Callerurl;
			}
			set { 
				sdt.gxTpr_Callerurl = value;
			}
		}

		[DataMember(Name="TransactionName", Order=3)]
		public String gxTpr_Transactionname
		{
			get { 
				return sdt.gxTpr_Transactionname;
			}
			set { 
				sdt.gxTpr_Transactionname = value;
			}
		}

		[DataMember(Name="Attributes", Order=4)]
		public GxGenericCollection<SdtTransactionContext_Attribute_RESTInterface> gxTpr_Attributes
		{
			get {
				return new GxGenericCollection<SdtTransactionContext_Attribute_RESTInterface>(sdt.gxTpr_Attributes) ;
			}

			set {
				value.LoadCollection(sdt.gxTpr_Attributes);
			}

		}


		#endregion

		public SdtTransactionContext sdt
		{
			get { 
				return (SdtTransactionContext)Sdt;
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
				sdt = new SdtTransactionContext() ;
			}
		}
	}
	#endregion
}