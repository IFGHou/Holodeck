namespace DotNetInterceptTester.My_System.ServiceProcess.ServiceProcessInstaller
{
public class CopyFromComponent_System_ServiceProcess_ServiceProcessInstaller_System_ComponentModel_IComponent
{
public static bool _CopyFromComponent_System_ServiceProcess_ServiceProcessInstaller_System_ComponentModel_IComponent( )
{
   //Parameters
   System.ComponentModel.IComponent comp = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.ServiceProcess.ServiceProcessInstaller.CopyFromComponent(comp);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.ServiceProcess.ServiceProcessInstaller.CopyFromComponent(comp);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
