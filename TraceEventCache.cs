public class TraceEventCache // TypeDefIndex: 2638
{
	private static int processId;
	private static string processName;
	private long timeStamp;
	private DateTime dateTime;
	private string stackTrace;

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

