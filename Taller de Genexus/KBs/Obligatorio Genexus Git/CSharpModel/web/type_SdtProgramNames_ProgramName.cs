/*
				   File: type_SdtProgramNames_ProgramName
			Description: ProgramNames
				 Author: Nemo for C# version 15.0.12.126726
		   Generated on: 29/03/2019 11:16:54
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
	[XmlRoot(ElementName="ProgramName")]
	[XmlType(TypeName="ProgramName" , Namespace="ObligatorioGenexusGit" )]
	[Serializable]
	public class SdtProgramNames_ProgramName : GxUserType
	{
		public SdtProgramNames_ProgramName( )
		{
			/* Constructor for serialization */
			gxTv_SdtProgramNames_ProgramName_Name = "";

			gxTv_SdtProgramNames_ProgramName_Description = "";

			gxTv_SdtProgramNames_ProgramName_Link = "";

		}

		public SdtProgramNames_ProgramName(IGxContext context)
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
			AddObjectProperty("Description", gxTpr_Description, false);
			AddObjectProperty("Link", gxTpr_Link, false);
			return;
		}
		#endregion

		#region Properties

		[SoapElement(ElementName="Name")]
		[XmlElement(ElementName="Name")]
		public String gxTpr_Name
		{
			get { 
				return gxTv_SdtProgramNames_ProgramName_Name; 
			}
			set { 
				gxTv_SdtProgramNames_ProgramName_Name = value;
				SetDirty("Name");
			}
		}


		[SoapElement(ElementName="Description")]
		[XmlElement(ElementName="Description")]
		public String gxTpr_Description
		{
			get { 
				return gxTv_SdtProgramNames_ProgramName_Description; 
			}
			set { 
				gxTv_SdtProgramNames_ProgramName_Description = value;
				SetDirty("Description");
			}
		}


		[SoapElement(ElementName="Link")]
		[XmlElement(ElementName="Link")]
		public String gxTpr_Link
		{
			get { 
				return gxTv_SdtProgramNames_ProgramName_Link; 
			}
			set { 
				gxTv_SdtProgramNames_ProgramName_Link = value;
				SetDirty("Link");
			}
		}


		#endregion

		#region Initialization

		public void initialize( )
		{
			gxTv_SdtProgramNames_ProgramName_Name = "";
			gxTv_SdtProgramNames_ProgramName_Description = "";
			gxTv_SdtProgramNames_ProgramName_Link = "";
			return  ;
		}



		#endregion

		#region Declaration

		protected String gxTv_SdtProgramNames_ProgramName_Name;
		protected String gxTv_SdtProgramNames_ProgramName_Description;
		protected String gxTv_SdtProgramNames_ProgramName_Link;



		#endregion
	}
	#region Rest interface
	[DataContract(Name=@"ProgramName", Namespace="ObligatorioGenexusGit")]
	public class SdtProgramNames_ProgramName_RESTInterface : GxGenericCollectionItem<SdtProgramNames_ProgramName>, System.Web.SessionState.IRequiresSessionState
	{
		public SdtProgramNames_ProgramName_RESTInterface( ) : base()
		{
		}

		public SdtProgramNames_ProgramName_RESTInterface( SdtProgramNames_ProgramName psdt ) : base(psdt)
		{
		}

		#region Rest Properties
		[DataMember(Name="Name", Order=0)]
		public String gxTpr_Name
		{
			get { 
				return sdt.gxTpr_Name;
			}
			set { 
				sdt.gxTpr_Name = value;
			}
		}

		[DataMember(Name="Description", Order=1)]
		public String gxTpr_Description
		{
			get { 
				return sdt.gxTpr_Description;
			}
			set { 
				sdt.gxTpr_Description = value;
			}
		}

		[DataMember(Name="Link", Order=2)]
		public String gxTpr_Link
		{
			get { 
				return sdt.gxTpr_Link;
			}
			set { 
				sdt.gxTpr_Link = value;
			}
		}


		#endregion

		public SdtProgramNames_ProgramName sdt
		{
			get { 
				return (SdtProgramNames_ProgramName)Sdt;
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
				sdt = new SdtProgramNames_ProgramName() ;
			}
		}
	}
	#endregion
}