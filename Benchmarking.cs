public static class Benchmarking // TypeDefIndex: 9931
{
	[CompilerGeneratedAttribute] 
	private static bool <IsBenchmarking>k__BackingField; 
	public static string[] BenchmarkScenes; 

	public static bool IsBenchmarking { get; set; }
	public static bool IsAutoBenchmark { get; }


	[CompilerGeneratedAttribute] 
	public static bool get_IsBenchmarking() { }

	[CompilerGeneratedAttribute] 
	public static void set_IsBenchmarking(bool value) { }

	public static bool get_IsAutoBenchmark() { }

	[AsyncStateMachineAttribute] 
	public static Task RunAsync(string demoName, bool runBenchmarkScenes = True) { }

	[AsyncStateMachineAttribute] 
	public static Task RunSingleSceneAsync(string scene) { }

	[AsyncStateMachineAttribute] 
	private static Task RunBenchmarkScene(string scene) { }

	[AsyncStateMachineAttribute] 
	public static Task RunBenchmarksInScene() { }

	[AsyncStateMachineAttribute] 
	private static Task Report() { }

	[AsyncStateMachineAttribute] 
	private static Task RunDemoBasedBenchmark(string demoName, string benchmarkLabel = "") { }

	private static void RecordBundleSizes() { }

	private static void .cctor() { }

}

private struct Benchmarking.<RunAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 9932
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public string demoName; 
	public bool runBenchmarkScenes; 
	private object <>7__wrap1; 
	private int <>7__wrap2; 
	private TaskAwaiter <>u__1; 
	private string[] <>7__wrap3; 
	private int <>7__wrap4; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunSingleSceneAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 9933
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public string scene; 
	private object <>7__wrap1; 
	private int <>7__wrap2; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarkScene>d__9 : IAsyncStateMachine // TypeDefIndex: 9934
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public string scene; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarksInScene>d__10 : IAsyncStateMachine // TypeDefIndex: 9935
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	private TaskAwaiter <>u__1; 
	private BenchmarkScene[] <>7__wrap1; 
	private int <>7__wrap2; 
	private IEnumerator <coroutine>5__4; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<Report>d__11 : IAsyncStateMachine // TypeDefIndex: 9936
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	private TaskAwaiter<string> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunDemoBasedBenchmark>d__12 : IAsyncStateMachine // TypeDefIndex: 9937
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public string demoName; 
	public string benchmarkLabel; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

