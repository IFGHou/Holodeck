namespace DotNetInterceptTester.My_System.Xml.XmlSignificantWhitespace
{
public class DeleteData_System_Xml_XmlSignificantWhitespace_System_Int32_System_Int32
{
public static bool _DeleteData_System_Xml_XmlSignificantWhitespace_System_Int32_System_Int32( )
{
   //Parameters
   System.Int32 offset = null;
   System.Int32 count = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlSignificantWhitespace.DeleteData(offset,count);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlSignificantWhitespace.DeleteData(offset,count);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
