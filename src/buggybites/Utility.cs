using System;
using System.IO;

/// <summary>
/// Summary description for Utility
/// </summary>
public class Utility
{
	public Utility()
	{
	}

    public static void WriteToLog(string message, Stream fileName)
    {
        try
        {
            
            using (StreamWriter sw = new StreamWriter(fileName))
            {
                //Log the event with date and time.
                sw.WriteLine("--------------------------");
                sw.WriteLine(DateTime.Now.ToString());
                sw.WriteLine("-------------------");
                sw.WriteLine(message);
            }
        }
        catch (Exception ex)
        {
            ExceptionHandler.LogException(ex);
        }
    }
}
