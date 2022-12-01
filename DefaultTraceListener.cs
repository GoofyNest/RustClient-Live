public class DefaultTraceListener : TraceListener // TypeDefIndex: 2655
{
	private static readonly bool OnWin32;
	private static readonly string MonoTracePrefix;
	private static readonly string MonoTraceFile;
	private string logFileName;

	[MonoTODOAttribute]
	public string LogFileName { get; }


	private static void .cctor() { }

	private static string GetPrefix(string var, string target) { }

	public void .ctor() { }

	public string get_LogFileName() { }

	private static void WriteWindowsDebugString(string message) { }

	private void WriteDebugString(string message) { }

	private void WriteMonoTrace(string message) { }

	private void WritePrefix() { }

	private void WriteImpl(string message) { }

	private void WriteLogFile(string message, string logFile) { }

	public override void Write(string message) { }

	public override void WriteLine(string message) { }

}

