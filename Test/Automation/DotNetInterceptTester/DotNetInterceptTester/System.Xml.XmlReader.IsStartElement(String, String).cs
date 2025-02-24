namespace DotNetInterceptTester.My_System.Xml.XmlReader
{
public class IsStartElement_System_Xml_XmlReader_System_String_System_String
{
public static bool _IsStartElement_System_Xml_XmlReader_System_String_System_String( )
{
   //Parameters
   System.String localname = null;
   System.String ns = null;

   //ReturnType/Value
   System.Boolean returnVal_Real = null;
   System.Boolean returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlReader.IsStartElement(localname,ns);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlReader.IsStartElement(localname,ns);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
