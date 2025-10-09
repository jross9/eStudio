namespace eLib
{
	public enum PinType { UNDEF, INPUT, OUTPUT, INOUT, AIN, AOUT, GROUND, POWER }

	public static class G
	{
		public static void LogCount(string prjID, string prjLogCode = "C#", int iDate = 10825)
		{
			StreamWriter sw = new StreamWriter(@"..\..\..\..\..\_countRun.txt", true);
			sw.WriteLine(iDate + "\t" + prjID + "\t" + DateTime.Now + "\t" + prjLogCode);
			sw.Close();
		}
	}
}
