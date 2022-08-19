public class Process : Component // TypeDefIndex: 2648
{	// Fields
	private bool haveProcessId; // 0x28
	private int processId; // 0x2C
	private bool haveProcessHandle; // 0x30
	private SafeProcessHandle m_processHandle; // 0x38
	private bool isRemoteMachine; // 0x40
	private string machineName; // 0x48
	private int m_processAccess; // 0x50
	private ProcessThreadCollection threads; // 0x58
	private ProcessModuleCollection modules; // 0x60
	private bool haveWorkingSetLimits; // 0x68
	private bool havePriorityClass; // 0x69
	private bool watchForExit; // 0x6A
	private bool watchingForExit; // 0x6B
	private EventHandler onExited; // 0x70
	private bool exited; // 0x78
	private int exitCode; // 0x7C
	private bool signaled; // 0x80
	private bool haveExitTime; // 0x81
	private bool raisedOnExited; // 0x82
	private RegisteredWaitHandle registeredWaitHandle; // 0x88
	private WaitHandle waitHandle; // 0x90
	private ISynchronizeInvoke synchronizingObject; // 0x98
	private StreamReader standardOutput; // 0xA0
	private StreamWriter standardInput; // 0xA8
	private StreamReader standardError; // 0xB0
	private bool disposed; // 0xB8
	private Process.StreamReadMode outputStreamReadMode; // 0xBC
	private Process.StreamReadMode errorStreamReadMode; // 0xC0
	private Process.StreamReadMode inputStreamReadMode; // 0xC4
	internal AsyncStreamReader output; // 0xC8
	internal AsyncStreamReader error; // 0xD0
	private string process_name; // 0xD8

	// Properties
	[BrowsableAttribute] // RVA: 0xA7920 Offset: 0xA6D20 VA: 0x1800A7920
	[MonitoringDescriptionAttribute] // RVA: 0xA7920 Offset: 0xA6D20 VA: 0x1800A7920
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7920 Offset: 0xA6D20 VA: 0x1800A7920
	private bool Associated { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7A80 Offset: 0xA6E80 VA: 0x1800A7A80
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7A80 Offset: 0xA6E80 VA: 0x1800A7A80
	[BrowsableAttribute] // RVA: 0xA7A80 Offset: 0xA6E80 VA: 0x1800A7A80
	public bool HasExited { get; }
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7AE0 Offset: 0xA6EE0 VA: 0x1800A7AE0
	[MonitoringDescriptionAttribute] // RVA: 0xA7AE0 Offset: 0xA6EE0 VA: 0x1800A7AE0
	public int Id { get; }
	[BrowsableAttribute] // RVA: 0xA7C80 Offset: 0xA7080 VA: 0x1800A7C80
	[DefaultValueAttribute] // RVA: 0xA7C80 Offset: 0xA7080 VA: 0x1800A7C80
	[MonitoringDescriptionAttribute] // RVA: 0xA7C80 Offset: 0xA7080 VA: 0x1800A7C80
	public ISynchronizeInvoke SynchronizingObject { get; }
	[MonitoringDescriptionAttribute] // RVA: 0xA7D20 Offset: 0xA7120 VA: 0x1800A7D20
	[DesignerSerializationVisibilityAttribute] // RVA: 0xA7D20 Offset: 0xA7120 VA: 0x1800A7D20
	public string ProcessName { get; }

	// Methods

	// RVA: 0x17283D0 Offset: 0x17277D0 VA: 0x1817283D0
	private void .ctor(string machineName, bool isRemoteMachine, int processId, ProcessInfo processInfo) { }

	// RVA: 0x1728480 Offset: 0x1727880 VA: 0x181728480
	private bool get_Associated() { }

	// RVA: 0x1728490 Offset: 0x1727890 VA: 0x181728490
	public bool get_HasExited() { }

	// RVA: 0x1728770 Offset: 0x1727B70 VA: 0x181728770
	public int get_Id() { }

	// RVA: 0x1728970 Offset: 0x1727D70 VA: 0x181728970
	public ISynchronizeInvoke get_SynchronizingObject() { }

	// RVA: 0x1728180 Offset: 0x1727580 VA: 0x181728180
	private void ReleaseProcessHandle(SafeProcessHandle handle) { }

	// RVA: 0x1727550 Offset: 0x1726950 VA: 0x181727550 Slot: 10
	protected override void Dispose(bool disposing) { }

	// RVA: 0x1727360 Offset: 0x1726760 VA: 0x181727360
	public void Close() { }

	// RVA: 0x17275A0 Offset: 0x17269A0 VA: 0x1817275A0
	private void EnsureState(Process.State state) { }

	// RVA: 0x17277C0 Offset: 0x1726BC0 VA: 0x1817277C0
	public static Process GetCurrentProcess() { }

	// RVA: 0x1727D00 Offset: 0x1727100 VA: 0x181727D00
	protected void OnExited() { }

	// RVA: 0x17278A0 Offset: 0x1726CA0 VA: 0x1817278A0
	private SafeProcessHandle GetProcessHandle(int access, bool throwIfExited) { }

	// RVA: 0x1727890 Offset: 0x1726C90 VA: 0x181727890
	private SafeProcessHandle GetProcessHandle(int access) { }

	// RVA: 0x1728130 Offset: 0x1727530 VA: 0x181728130
	public void Refresh() { }

	// RVA: 0x17281A0 Offset: 0x17275A0 VA: 0x1817281A0
	private void StopWatchingForExit() { }

	// RVA: 0x17282D0 Offset: 0x17276D0 VA: 0x1817282D0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1728050 Offset: 0x1727450 VA: 0x181728050
	private static string ProcessName_internal(IntPtr handle) { }

	// RVA: 0x1727F70 Offset: 0x1727370 VA: 0x181727F70
	private static string ProcessName_internal(SafeProcessHandle handle) { }

	// RVA: 0x1728790 Offset: 0x1727B90 VA: 0x181728790
	public string get_ProcessName() { }

	// RVA: 0x1728060 Offset: 0x1727460 VA: 0x181728060
	private void RaiseOnExited() { }

}

private enum Process.StreamReadMode // TypeDefIndex: 2649
{	// Fields
	public int value__; // 0x0
	public const Process.StreamReadMode undefined = 0;
	public const Process.StreamReadMode syncMode = 1;
	public const Process.StreamReadMode asyncMode = 2;

}

private enum Process.State // TypeDefIndex: 2650
{	// Fields
	public int value__; // 0x0
	public const Process.State HaveId = 1;
	public const Process.State IsLocal = 2;
	public const Process.State IsNt = 4;
	public const Process.State HaveProcessInfo = 8;
	public const Process.State Exited = 16;
	public const Process.State Associated = 32;
	public const Process.State IsWin2k = 64;
	public const Process.State HaveNtProcessInfo = 12;

}

