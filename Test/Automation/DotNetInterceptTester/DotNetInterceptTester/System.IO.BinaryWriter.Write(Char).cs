namespace DotNetInterceptTester.My_System.IO.BinaryWriter
{
public class Write_System_IO_BinaryWriter_System_Char
{
public static bool _Write_System_IO_BinaryWriter_System_Char( )
{
   //Parameters
   System.Char ch = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.IO.BinaryWriter.Write(ch);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.IO.BinaryWriter.Write(ch);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
