namespace DotNetInterceptTester.My_System.Security.Cryptography.SignatureDescription
{
public class ctor_System_Security_Cryptography_SignatureDescription_System_Security_SecurityElement
{
public static bool _ctor_System_Security_Cryptography_SignatureDescription_System_Security_SecurityElement( )
{
   //Parameters
   System.Security.SecurityElement el = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Security.Cryptography.SignatureDescription.ctor(el);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Security.Cryptography.SignatureDescription.ctor(el);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
