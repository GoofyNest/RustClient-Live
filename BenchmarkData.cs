public class BenchmarkData // TypeDefIndex: 6178
{	public static BenchmarkData Current; // 0x0
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

	private float AvgMilliseconds { get; }
	private float avgFrameRate { get; }


	public static BenchmarkData New() { }

	public void WriteTimersToResults() { }

	[AsyncStateMachineAttribute] // RVA: 0x9F760 Offset: 0x9EB60 VA: 0x18009F760
	public Task<string> Upload() { }

	public string WriteJSON() { }

	private float get_AvgMilliseconds() { }

	private float get_avgFrameRate() { }

	public void ResetCounters() { }

	public void Frame() { }

	public void CompleteDemoBenchmark(string benchmarkLabel = "") { }

	public void .ctor() { }

}

private struct BenchmarkData.<Upload>d__13 : IAsyncStateMachine // TypeDefIndex: 6179
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<string> <>t__builder; // 0x8
	public BenchmarkData <>4__this; // 0x20
	private TaskAwaiter<string> <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

