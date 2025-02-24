namespace DotNetInterceptTester.My_System.Net.WebProxy
{
public class ctor_System_Net_WebProxy_System_String_System_Boolean
{
public static bool _ctor_System_Net_WebProxy_System_String_System_Boolean( )
{
   //Parameters
   System.String Address = null;
   System.Boolean BypassOnLocal = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.WebProxy.ctor(Address,BypassOnLocal);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.WebProxy.ctor(Address,BypassOnLocal);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
