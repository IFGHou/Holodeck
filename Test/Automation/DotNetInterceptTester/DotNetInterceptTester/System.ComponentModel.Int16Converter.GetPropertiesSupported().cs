using System;

namespace DotNetInterceptTester.My_System.ComponentModel.Int16Converter
{
public class GetPropertiesSupported_System_ComponentModel_Int16Converter
{
public static bool _GetPropertiesSupported_System_ComponentModel_Int16Converter( )
{

   //class object
    System.ComponentModel.Int16Converter _System_ComponentModel_Int16Converter = new System.ComponentModel.Int16Converter();

   //Parameters

   //ReturnType/Value
   System.Boolean returnVal_Real = false;
   System.Boolean returnVal_Intercepted = false;

   //Exception
   System.Exception exception_Real = null;
   System.Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnVal_Real = _System_ComponentModel_Int16Converter.GetPropertiesSupported();
   }

   catch( System.Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnVal_Intercepted = _System_ComponentModel_Int16Converter.GetPropertiesSupported();
   }

   catch( System.Exception e )
   {
      exception_Intercepted = e;
   }


   return( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
