namespace DotNetInterceptTester.My_System.Xml.XmlTextReader
{
public class ctor_System_Xml_XmlTextReader_System_IO_TextReader
{
public static bool _ctor_System_Xml_XmlTextReader_System_IO_TextReader( )
{
   //Parameters
   System.IO.TextReader input = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlTextReader.ctor(input);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlTextReader.ctor(input);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
