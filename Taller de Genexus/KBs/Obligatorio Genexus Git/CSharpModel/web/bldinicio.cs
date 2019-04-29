using System;
using GeneXus.Builder;
using System.IO;
public class bldinicio : GxBaseBuilder
{
   string cs_path = "." ;
   public bldinicio( ) : base()
   {
   }

   public override int BeforeCompile( )
   {
      return 0 ;
   }

   public override int AfterCompile( )
   {
      int ErrCode ;
      ErrCode = 0;
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldinicio x = new bldinicio() ;
      x.SetMainSourceFile( "inicio.cs");
      x.LoadVariables( args);
      return x.CompileAll( );
   }

   public override ItemCollection GetSortedBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\GeneXus.Programs.Common.dll", cs_path + @"\genexus.programs.common.rsp");
      return sc ;
   }

   public override TargetCollection GetRuntimeBuildList( )
   {
      TargetCollection sc = new TargetCollection() ;
      sc.Add( @"inicio", "dll");
      return sc ;
   }

   public override ItemCollection GetResBuildList( )
   {
      ItemCollection sc = new ItemCollection() ;
      sc.Add( @"bin\messages.eng.dll", cs_path + @"\messages.eng.txt");
      return sc ;
   }

   public override bool ToBuild( String obj )
   {
      if (checkTime(obj, cs_path + @"\bin\GxClasses.dll" ))
         return true;
      if ( obj == @"bin\GeneXus.Programs.Common.dll" )
      {
         if (checkTime(obj, cs_path + @"\GxObjectCollection.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\SoapParm.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxWebStd.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxFullTextSearchReindexer.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GxModelInfoProvider.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\genexus.programs.sdt.rsp" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtCarne.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtCarnet.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtActividad.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtActividad_SocioEnActividad.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtClase.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtClase_Socios.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtProfesor.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\type_SdtSocio.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINPage.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINTipoCuota.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINSexo.cs" ))
            return true;
         if (checkTime(obj, cs_path + @"\GXDOMAINGoogleChartType.cs" ))
            return true;
      }
      if ( obj == @"bin\messages.eng.dll" )
      {
         if (checkTime(obj, cs_path + @"\messages.eng.txt" ))
            return true;
      }
      return false ;
   }

}

