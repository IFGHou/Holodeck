namespace DotNetInterceptTester.My_System.ServiceProcess.ServiceProcessInstaller
{
public class Uninstall_System_ServiceProcess_ServiceProcessInstaller_System_Collections_IDictionary
{
public static bool _Uninstall_System_ServiceProcess_ServiceProcessInstaller_System_Collections_IDictionary( )
{
   //Parameters
   System.Collections.IDictionary savedState = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.ServiceProcess.ServiceProcessInstaller.Uninstall(savedState);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.ServiceProcess.ServiceProcessInstaller.Uninstall(savedState);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
