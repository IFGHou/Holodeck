namespace DotNetInterceptTester.My_System.Net.Sockets.Socket
{
public class Listen_System_Net_Sockets_Socket_System_Int32
{
public static bool _Listen_System_Net_Sockets_Socket_System_Int32( )
{
   //Parameters
   System.Int32 backlog = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.Sockets.Socket.Listen(backlog);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.Sockets.Socket.Listen(backlog);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
