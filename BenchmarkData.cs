public class BenchmarkData // TypeDefIndex: 6178
{	// Fields
	public static BenchmarkData Current; // 0x0
	public Dictionary<string, float> Results; // 0x10
	public string ComputerName; // 0x18
	public string BuildDate; // 0x20
	public string BranchName; // 0x28
	public string Changeset; // 0x30
	public string BuildId; // 0x38
	public bool Auto; // 0x40
	public int Version; // 0x44
	public AppInfo AppInfo; // 0x48
	public SystemInformation SystemInfo; // 0x50
	private int frames; // 0x54
	private int hitches; // 0x58
	private int freezes; // 0x5C
	private float lastTime; // 0x60
	private double frameTimes; // 0x68

	// Properties
	private float AvgMilliseconds { get; }
	private float avgFrameRate { get; }

	// Methods

	// RVA: 0x14E12F0 Offset: 0x14E06F0 VA: 0x1814E12F0
	public static BenchmarkData New() { }

	// RVA: 0x14E17D0 Offset: 0x14E0BD0 VA: 0x1814E17D0
	public void WriteTimersToResults() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F760 Offset: 0x9EB60 VA: 0x18009F760
	// RVA: 0x14E14A0 Offset: 0x14E08A0 VA: 0x1814E14A0
	public Task<string> Upload() { }

	// RVA: 0x14E15A0 Offset: 0x14E09A0 VA: 0x1814E15A0
	public string WriteJSON() { }

	// RVA: 0x14E1A00 Offset: 0x14E0E00 VA: 0x1814E1A00
	private float get_AvgMilliseconds() { }

	// RVA: 0x14E1A20 Offset: 0x14E0E20 VA: 0x1814E1A20
	private float get_avgFrameRate() { }

	// RVA: 0x14E1490 Offset: 0x14E0890 VA: 0x1814E1490
	public void ResetCounters() { }

	// RVA: 0x14E1290 Offset: 0x14E0690 VA: 0x1814E1290
	public void Frame() { }

	// RVA: 0x14E1000 Offset: 0x14E0400 VA: 0x1814E1000
	public void CompleteDemoBenchmark(string benchmarkLabel = "") { }

	// RVA: 0x14E1990 Offset: 0x14E0D90 VA: 0x1814E1990
	public void .ctor() { }

}

private struct BenchmarkData.<Upload>d__13 : IAsyncStateMachine // TypeDefIndex: 6179
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public BenchmarkData <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28

	// Methods

	// RVA: 0x1F19C0 Offset: 0x1F0DC0 VA: 0x1801F19C0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1F19D0 Offset: 0x1F0DD0 VA: 0x1801F19D0 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

