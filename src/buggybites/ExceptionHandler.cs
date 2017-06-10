using System;
using System.IO;
using System.Text;

/// <summary>
/// Summary description for ExceptionHandler
/// </summary>
public class ExceptionHandler
{
	public ExceptionHandler()
	{
	}
    public static void LogException(Exception ex)
    {
        Stream s = GenerateStreamFromString("c:\\log.txt");


        Utility.WriteToLog(ex.Message, s);
    }


    public static Stream GenerateStreamFromString(String p)
    {
        return new MemoryStream(Encoding.UTF8.GetBytes(p));

    }
}
