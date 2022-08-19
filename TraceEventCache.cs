public class TraceEventCache // TypeDefIndex: 2638
{	// Fields
	private static int processId; // 0x0
	private static string processName; // 0x8
	private long timeStamp; // 0x10
	private DateTime dateTime; // 0x18
	private string stackTrace; // 0x20

	// Properties
	public string Callstack { get; }
	public Stack LogicalOperationStack { get; }
	public DateTime DateTime { get; }
	public int ProcessId { get; }
	public string ThreadId { get; }
	public long Timestamp { get; }

	// Methods

	// RVA: 0x1730FC0 Offset: 0x17303C0 VA: 0x181730FC0
	public string get_Callstack() { }

	// RVA: 0x17310B0 Offset: 0x17304B0 VA: 0x1817310B0
	public Stack get_LogicalOperationStack() { }

	// RVA: 0x1731000 Offset: 0x1730400 VA: 0x181731000
	public DateTime get_DateTime() { }

	// RVA: 0x1730D20 Offset: 0x1730120 VA: 0x181730D20
	public int get_ProcessId() { }

	// RVA: 0x17311F0 Offset: 0x17305F0 VA: 0x1817311F0
	public string get_ThreadId() { }

	// RVA: 0x1731270 Offset: 0x1730670 VA: 0x181731270
	public long get_Timestamp() { }

	// RVA: 0x1730D70 Offset: 0x1730170 VA: 0x181730D70
	private static void InitProcessInfo() { }

	// RVA: 0x1730D20 Offset: 0x1730120 VA: 0x181730D20
	internal static int GetProcessId() { }

	// RVA: 0x10D6480 Offset: 0x10D5880 VA: 0x1810D6480
	internal static int GetThreadId() { }

	// RVA: 0x1730F40 Offset: 0x1730340 VA: 0x181730F40
	public void .ctor() { }

}

