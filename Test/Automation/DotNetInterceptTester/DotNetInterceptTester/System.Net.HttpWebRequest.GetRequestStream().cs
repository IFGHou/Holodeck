namespace DotNetInterceptTester.My_System.Net.HttpWebRequest
{
public class GetRequestStream_System_Net_HttpWebRequest
{
public static bool _GetRequestStream_System_Net_HttpWebRequest( )
{
   //Parameters

   //ReturnType/Value
   System.IO.Stream returnVal_Real = null;
   System.IO.Stream returnVal_Intercepted = null;

   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.Net.HttpWebRequest.GetRequestStream();
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.Net.HttpWebRequest.GetRequestStream();
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


   Return ( ( exception_Real.Messsage == exception_Intercepted.Message ) && ( returnValue_Real == returnValue_Intercepted ) );
}
}
}
