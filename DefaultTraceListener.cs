public class DefaultTraceListener : TraceListener // TypeDefIndex: 2655
{	// Fields
	private static readonly bool OnWin32; // 0x0
	private static readonly string MonoTracePrefix; // 0x8
	private static readonly string MonoTraceFile; // 0x10
	private string logFileName; // 0x38

	// Properties
	[MonoTODOAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string LogFileName { get; }

	// Methods

	// RVA: 0x1723EC0 Offset: 0x17232C0 VA: 0x181723EC0
	private static void .cctor() { }

	// RVA: 0x1723760 Offset: 0x1722B60 VA: 0x181723760
	private static string GetPrefix(string var, string target) { }

	// RVA: 0x1724040 Offset: 0x1723440 VA: 0x181724040
	public void .ctor() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public string get_LogFileName() { }

	// RVA: 0x1723EA0 Offset: 0x17232A0 VA: 0x181723EA0
	private static void WriteWindowsDebugString(string message) { }

	// RVA: 0x17237D0 Offset: 0x1722BD0 VA: 0x1817237D0
	private void WriteDebugString(string message) { }

	// RVA: 0x1723BF0 Offset: 0x1722FF0 VA: 0x181723BF0
	private void WriteMonoTrace(string message) { }

	// RVA: 0x1723E00 Offset: 0x1723200 VA: 0x181723E00
	private void WritePrefix() { }

	// RVA: 0x1723870 Offset: 0x1722C70 VA: 0x181723870
	private void WriteImpl(string message) { }

	// RVA: 0x1723A80 Offset: 0x1722E80 VA: 0x181723A80
	private void WriteLogFile(string message, string logFile) { }

	// RVA: 0x1723EB0 Offset: 0x17232B0 VA: 0x181723EB0 Slot: 10
	public override void Write(string message) { }

	// RVA: 0x1723A30 Offset: 0x1722E30 VA: 0x181723A30 Slot: 12
	public override void WriteLine(string message) { }

}

