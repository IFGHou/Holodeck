namespace DotNetInterceptTester.My_System.Xml.XmlElement
{
public class SetAttributeNode_System_Xml_XmlElement_System_Xml_XmlAttribute
{
public static bool _SetAttributeNode_System_Xml_XmlElement_System_Xml_XmlAttribute( )
{
   //Parameters
   System.Xml.XmlAttribute newAttr = null;

   //ReturnType/Value
   System.Xml.XmlAttribute returnVal_Real = null;
   System.Xml.XmlAttribute returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlElement.SetAttributeNode(newAttr);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlElement.SetAttributeNode(newAttr);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
