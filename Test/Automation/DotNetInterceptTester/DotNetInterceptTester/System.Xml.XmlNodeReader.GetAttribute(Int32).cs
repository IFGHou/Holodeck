namespace DotNetInterceptTester.My_System.Xml.XmlNodeReader
{
public class GetAttribute_System_Xml_XmlNodeReader_System_Int32
{
public static bool _GetAttribute_System_Xml_XmlNodeReader_System_Int32( )
{
   //Parameters
   System.Int32 attributeIndex = null;

   //ReturnType/Value
   System.String returnVal_Real = null;
   System.String returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Xml.XmlNodeReader.GetAttribute(attributeIndex);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Xml.XmlNodeReader.GetAttribute(attributeIndex);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
