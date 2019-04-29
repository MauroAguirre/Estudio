using System;
using GeneXus.Builder;
using System.IO;
public class bldDevelopermenu : GxBaseBuilder
{
   string cs_path = "." ;
   public bldDevelopermenu( ) : base()
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
      if ( ! File.Exists(@"bin\client.exe.config") || checkTime(@"bin\client.exe.config",cs_path + @"\client.exe.config") )
      {
         File.Copy( cs_path + @"\client.exe.config", @"bin\client.exe.config", true);
      }
      return ErrCode ;
   }

   static public int Main( string[] args )
   {
      bldDevelopermenu x = new bldDevelopermenu() ;
      x.SetMainSourceFile( "bldDevelopermenu.cs");
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
      sc.Add( @"listadosociomonto", "dll");
      sc.Add( @"listadoprofesoractividad", "dll");
      sc.Add( @"listadoclasesocioysexo", "dll");
      sc.Add( @"listadoclasessegunactividad", "dll");
      sc.Add( @"listadosociodeclase", "dll");
      sc.Add( @"listadosociospremiados", "dll");
      sc.Add( @"listadossocioparapremiar", "dll");
      sc.Add( @"anotificationsregistrationhandler", "dll");
      sc.Add( @"anotificationsregistrationhandler", "dll");
      sc.Add( @"gxaftereventreplicator", "dll");
      sc.Add( @"gxaftereventreplicator", "dll");
      sc.Add( @"gxonpendingeventfailed", "dll");
      sc.Add( @"gxonpendingeventfailed", "dll");
      sc.Add( @"appmasterpage", "dll");
      sc.Add( @"recentlinks", "dll");
      sc.Add( @"promptmasterpage", "dll");
      sc.Add( @"rwdmasterpage", "dll");
      sc.Add( @"rwdrecentlinks", "dll");
      sc.Add( @"rwdpromptmasterpage", "dll");
      sc.Add( @"notauthorized", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"home", "dll");
      sc.Add( @"tabbedview", "dll");
      sc.Add( @"wwactividad", "dll");
      sc.Add( @"actividadgeneral", "dll");
      sc.Add( @"actividadprofesorwc", "dll");
      sc.Add( @"viewactividad", "dll");
      sc.Add( @"wwcarnet", "dll");
      sc.Add( @"carnetgeneral", "dll");
      sc.Add( @"viewcarnet", "dll");
      sc.Add( @"wwclase", "dll");
      sc.Add( @"clasegeneral", "dll");
      sc.Add( @"viewclase", "dll");
      sc.Add( @"wwprofesor", "dll");
      sc.Add( @"profesorgeneral", "dll");
      sc.Add( @"profesorclasewc", "dll");
      sc.Add( @"viewprofesor", "dll");
      sc.Add( @"wwsocio", "dll");
      sc.Add( @"sociogeneral", "dll");
      sc.Add( @"viewsocio", "dll");
      sc.Add( @"inicio", "dll");
      sc.Add( @"inicio", "dll");
      sc.Add( @"gx0010", "dll");
      sc.Add( @"gx0040", "dll");
      sc.Add( @"gx00b0", "dll");
      sc.Add( @"debugmenu", "dll");
      sc.Add( @"clasesocioswc", "dll");
      sc.Add( @"sociosocioswc", "dll");
      sc.Add( @"gx00d1", "dll");
      sc.Add( @"sociocarnetwc", "dll");
      sc.Add( @"gx00e0", "dll");
      sc.Add( @"carnetsociowc", "dll");
      sc.Add( @"actividadesclasessocios", "dll");
      sc.Add( @"gridactividadprofesor", "dll");
      sc.Add( @"graficaactividadprofesor", "dll");
      sc.Add( @"actividad", "dll");
      sc.Add( @"actividad_bc", "dll");
      sc.Add( @"profesor", "dll");
      sc.Add( @"profesor_bc", "dll");
      sc.Add( @"carnet", "dll");
      sc.Add( @"carnet_bc", "dll");
      sc.Add( @"clase", "dll");
      sc.Add( @"clase_bc", "dll");
      sc.Add( @"socio", "dll");
      sc.Add( @"socio_bc", "dll");
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

