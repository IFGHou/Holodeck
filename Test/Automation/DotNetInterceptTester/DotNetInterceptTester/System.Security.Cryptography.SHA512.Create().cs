namespace DotNetInterceptTester.My_System.Security.Cryptography.SHA512
{
public class Create
{
public static bool _Create( )
{
   //Parameters

   //ReturnType/Value
   System.Security.Cryptography.SHA512 returnVal_Real = null;
   System.Security.Cryptography.SHA512 returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Security.Cryptography.SHA512.Create(;
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Security.Cryptography.SHA512.Create(;
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
