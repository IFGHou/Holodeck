using System;
using System.IO;
using Microsoft.Win32;
using System.Xml;
using System.Xml.XPath;
using TestFramework.Run;
using TestFramework.Log;
using TestFramework.Exceptions;
using Holodeck;
using TestingFunctionXML;

namespace FunctionXMLTest
{
	/// <summary>
	/// Summary description for FunctionXMLTest8
	/// Make Functions.xml with missing one missing function
	/// </summary>
	public class FunctionXMLTest8:FunctionXMLTest
	{
		string FunctionsXMLFilePath;
		string FunctionsXMLBackupFilePath;
		FileInfo modifyThisFile;

		public FunctionXMLTest8()
		{
			
		}
		public override void executeTest( )
		{
			

			Console.WriteLine("Test Case:Make Functions.xml with missing one missing function");
			try
			{
				string holodeckPath;
				holodeckPath = (string) Registry.LocalMachine.OpenSubKey ("Software\\HolodeckEE", true).GetValue ("InstallPath");
				
				FunctionsXMLFilePath = string.Concat(holodeckPath,"\\function_db\\functions.xml");
				
				FunctionsXMLBackupFilePath = string.Concat(FunctionsXMLFilePath,".bak");

				modifyThisFile = new FileInfo(FunctionsXMLFilePath);
				modifyThisFile.Attributes = FileAttributes.Normal;
				modifyThisFile.CopyTo(FunctionsXMLBackupFilePath);
				
				//modify xml here
				FunctionsXMLFilePath = modifyThisFile.FullName;
				
				XmlDocument xmlDocument = new XmlDocument( );
				xmlDocument.Load(FunctionsXMLFilePath);

				XmlNode nodeFunction = xmlDocument.SelectSingleNode( "/Functions/Function [last()]" );
				
				nodeFunction.ParentNode.RemoveChild(nodeFunction);
				Console.WriteLine("Removing {0} function from the Functions.xml file", nodeFunction.SelectSingleNode("/FunctionName").InnerText);
				
							
				xmlDocument.Save(FunctionsXMLFilePath);
								  								
				//add code here which will launch Holodeck
				Holodeck.HolodeckProcess.Start();

			}
			catch(HolodeckExceptions.IncorrectRegistryException e)
			{
				Console.WriteLine(" Incorrect Registry Exception caught.... : " + e.Message);
				Console.WriteLine("Details: " + e.StackTrace);
			}
			catch(FileNotFoundException f)
			{
				Console.WriteLine(" File Not Found Exception caught.... : " + f.Message);
				Console.WriteLine("Details: " + f.StackTrace);
			}
			finally
			{
				if(Holodeck.HolodeckProcess.IsRunning ())
				{
					Holodeck.HolodeckProcess.Stop();
				}
				//reverting back to original
				modifyThisFile.Delete();

				FileInfo regainOriginal = new FileInfo(FunctionsXMLBackupFilePath);
				regainOriginal.MoveTo(FunctionsXMLFilePath);

			}
		}
	}
}
