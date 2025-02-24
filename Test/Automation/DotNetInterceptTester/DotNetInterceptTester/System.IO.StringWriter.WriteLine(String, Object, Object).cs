namespace DotNetInterceptTester.My_System.IO.StringWriter
{
public class WriteLine_System_IO_StringWriter_System_String_System_Object_System_Object
{
public static bool _WriteLine_System_IO_StringWriter_System_String_System_Object_System_Object( )
{
   //Parameters
   System.String format = null;
   System.Object arg0 = null;
   System.Object arg1 = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.IO.StringWriter.WriteLine(format,arg0,arg1);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.IO.StringWriter.WriteLine(format,arg0,arg1);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
