namespace DotNetInterceptTester.My_System.Diagnostics.EventLog
{
public class WriteEntry_System_String_System_String
{
public static bool _WriteEntry_System_String_System_String( )
{
   //Parameters
   System.String source = null;
   System.String message = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Diagnostics.EventLog.WriteEntry(source,message);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Diagnostics.EventLog.WriteEntry(source,message);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
