namespace DotNetInterceptTester.My_System.Configuration.ConfigXmlDocument
{
public class CloneNode_System_Configuration_ConfigXmlDocument_System_Boolean
{
public static bool _CloneNode_System_Configuration_ConfigXmlDocument_System_Boolean( )
{
   //Parameters
   System.Boolean deep = null;

   //ReturnType/Value
   System.Xml.XmlNode returnVal_Real = null;
   System.Xml.XmlNode returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Configuration.ConfigXmlDocument.CloneNode(deep);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Configuration.ConfigXmlDocument.CloneNode(deep);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
