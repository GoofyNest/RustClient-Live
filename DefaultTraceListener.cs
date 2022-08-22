public class DefaultTraceListener : TraceListener // TypeDefIndex: 2655
{	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x38

	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

