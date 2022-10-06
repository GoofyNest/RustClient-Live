public class BenchmarkData // TypeDefIndex: 6182
{
	public static BenchmarkData Current; 
	public Dictionary<string, float> Results; 
	public string ComputerName; 
	public string BuildDate; 
	public string BranchName; 
	public string Changeset; 
	public string BuildId; 
	public bool Auto; 
	public int Version; 
	public AppInfo AppInfo; 
	public SystemInformation SystemInfo; 
	private int frames; 
	private int hitches; 
	private int freezes; 
	private float lastTime; 
	private double frameTimes; 

	private float AvgMilliseconds { get; }
	private float avgFrameRate { get; }


	public static BenchmarkData New() { }

	public void WriteTimersToResults() { }

	[AsyncStateMachineAttribute] 
	public Task<string> Upload() { }

	public string WriteJSON() { }

	private float get_AvgMilliseconds() { }

	private float get_avgFrameRate() { }

	public void ResetCounters() { }

	public void Frame() { }

	public void CompleteDemoBenchmark(string benchmarkLabel = "") { }

	public void .ctor() { }

}

private struct BenchmarkData.<Upload>d__13 : IAsyncStateMachine // TypeDefIndex: 6183
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<string> <>t__builder; 
	public BenchmarkData <>4__this; 
	private TaskAwaiter<string> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

