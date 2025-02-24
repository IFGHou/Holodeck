namespace DotNetInterceptTester.My_System.Diagnostics.Trace
{
public class Assert_System_Boolean
{
public static bool _Assert_System_Boolean( )
{
   //Parameters
   System.Boolean condition = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Diagnostics.Trace.Assert(condition);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Diagnostics.Trace.Assert(condition);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
