namespace DotNetInterceptTester.My_System.Net.IPAddress
{
public class HostToNetworkOrder_System_Int16
{
public static bool _HostToNetworkOrder_System_Int16( )
{
   //Parameters
   System.Int16 host = null;

   //ReturnType/Value
   System.Int16 returnVal_Real = null;
   System.Int16 returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.IPAddress.HostToNetworkOrder(host);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.IPAddress.HostToNetworkOrder(host);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
