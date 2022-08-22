public class TraceEventCache // TypeDefIndex: 2638
{	private static int processId; // 0x0
	private static string processName; // 0x8
	private long timeStamp; // 0x10
	private DateTime dateTime; // 0x18
	private string stackTrace; // 0x20

	public string Callstack { get; }
	public Stack LogicalOperationStack { get; }
	public DateTime DateTime { get; }
	public int ProcessId { get; }
	public string ThreadId { get; }
	public long Timestamp { get; }


	public string get_Callstack() { }

	public Stack get_LogicalOperationStack() { }

	public DateTime get_DateTime() { }

	public int get_ProcessId() { }

	public string get_ThreadId() { }

	public long get_Timestamp() { }

	private static void InitProcessInfo() { }

	internal static int GetProcessId() { }

	internal static int GetThreadId() { }

	public void .ctor() { }

}

