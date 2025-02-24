namespace DotNetInterceptTester.My_System.IO.IsolatedStorage.IsolatedStorageFileStream
{
public class ctor_System_IO_IsolatedStorage_IsolatedStorageFileStream_System_String_System_IO_FileMode_System_IO_FileAccess_System_IO_FileShare
{
public static bool _ctor_System_IO_IsolatedStorage_IsolatedStorageFileStream_System_String_System_IO_FileMode_System_IO_FileAccess_System_IO_FileShare( )
{
   //Parameters
   System.String path = null;
   System.IO.FileMode mode = null;
   System.IO.FileAccess access = null;
   System.IO.FileShare share = null;


   //Exception
   Exception exception_Real = null;
   Exception exception_Intercepted = null;

   InterceptionMaintenance.disableInterception( );

   try
   {
      returnValue_Real = System.IO.IsolatedStorage.IsolatedStorageFileStream.ctor(path,mode,access,share);
   }

   catch( Exception e )
   {
      exception_Real = e;
   }


   InterceptionMaintenance.enableInterception( );

   try
   {
      returnValue_Intercepted = System.IO.IsolatedStorage.IsolatedStorageFileStream.ctor(path,mode,access,share);
   }

   catch( Exception e )
   {
      exception_Intercepted = e;
   }


}
}
}
