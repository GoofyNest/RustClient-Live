public class Process : Component // TypeDefIndex: 2648
{
	private bool haveProcessId;
	private int processId;
	private bool haveProcessHandle;
	private SafeProcessHandle m_processHandle;
	private bool isRemoteMachine;
	private string machineName;
	private int m_processAccess;
	private ProcessThreadCollection threads;
	private ProcessModuleCollection modules;
	private bool haveWorkingSetLimits;
	private bool havePriorityClass;
	private bool watchForExit;
	private bool watchingForExit;
	private EventHandler onExited;
	private bool exited;
	private int exitCode;
	private bool signaled;
	private bool haveExitTime;
	private bool raisedOnExited;
	private RegisteredWaitHandle registeredWaitHandle;
	private WaitHandle waitHandle;
	private ISynchronizeInvoke synchronizingObject;
	private StreamReader standardOutput;
	private StreamWriter standardInput;
	private StreamReader standardError;
	private bool disposed;
	private Process.StreamReadMode outputStreamReadMode;
	private Process.StreamReadMode errorStreamReadMode;
	private Process.StreamReadMode inputStreamReadMode;
	internal AsyncStreamReader output;
	internal AsyncStreamReader error;
	private string process_name;

	[BrowsableAttribute]
	[MonitoringDescriptionAttribute]
	[DesignerSerializationVisibilityAttribute]
	private bool Associated { get; }
	[MonitoringDescriptionAttribute]
	[DesignerSerializationVisibilityAttribute]
	[BrowsableAttribute]
	public bool HasExited { get; }
	[DesignerSerializationVisibilityAttribute]
	[MonitoringDescriptionAttribute]
	public int Id { get; }
	[BrowsableAttribute]
	[DefaultValueAttribute]
	[MonitoringDescriptionAttribute]
	public ISynchronizeInvoke SynchronizingObject { get; }
	[MonitoringDescriptionAttribute]
	[DesignerSerializationVisibilityAttribute]
	public string ProcessName { get; }


	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	private bool get_Associated() { }

	public bool get_HasExited() { }

	public int get_Id() { }

	public ISynchronizeInvoke get_SynchronizingObject() { }

	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	protected override void Dispose(bool disposing) { }

	public void Close() { }

	private void EnsureState(Process.State state) { }

	public static Process GetCurrentProcess() { }

	protected void OnExited() { }

	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	private SafeProcessHandle GetProcessHandle(int access) { }

	public void Refresh() { }

	private void StopWatchingForExit() { }

	public override string ToString() { }

	private static string ProcessName_internal(IntPtr handle) { }

	private static string ProcessName_internal(SafeProcessHandle handle) { }

	public string get_ProcessName() { }

	private void RaiseOnExited() { }

}

private enum Process.StreamReadMode // TypeDefIndex: 2649
{
	public int value__;
	public const Process.StreamReadMode undefined = 0;
	public const Process.StreamReadMode syncMode = 1;
	public const Process.StreamReadMode asyncMode = 2;

}

private enum Process.State // TypeDefIndex: 2650
{
	public int value__;
	public const Process.State HaveId = 1;
	public const Process.State IsLocal = 2;
	public const Process.State IsNt = 4;
	public const Process.State HaveProcessInfo = 8;
	public const Process.State Exited = 16;
	public const Process.State Associated = 32;
	public const Process.State IsWin2k = 64;
	public const Process.State HaveNtProcessInfo = 12;

}

