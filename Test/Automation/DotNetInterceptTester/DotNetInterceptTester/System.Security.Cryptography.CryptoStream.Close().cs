namespace DotNetInterceptTester.My_System.Security.Cryptography.CryptoStream
{
public class Close_System_Security_Cryptography_CryptoStream
{
public static bool _Close_System_Security_Cryptography_CryptoStream( )
{
   //Parameters


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Security.Cryptography.CryptoStream.Close();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Security.Cryptography.CryptoStream.Close();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
