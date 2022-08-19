public static class Benchmarking // TypeDefIndex: 8261
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private static bool <IsBenchmarking>k__BackingField; // 0x0
	public static string[] BenchmarkScenes; // 0x8

	// Properties
	public static bool IsBenchmarking { get; set; }
	public static bool IsAutoBenchmark { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5296A0 Offset: 0x528AA0 VA: 0x1805296A0
	public static bool get_IsBenchmarking() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x529700 Offset: 0x528B00 VA: 0x180529700
	public static void set_IsBenchmarking(bool value) { }

	// RVA: 0x5295D0 Offset: 0x5289D0 VA: 0x1805295D0
	public static bool get_IsAutoBenchmark() { }

	[AsyncStateMachineAttribute] // RVA: 0xA2DB0 Offset: 0xA21B0 VA: 0x1800A2DB0
	// RVA: 0x528F40 Offset: 0x528340 VA: 0x180528F40
	public static Task RunAsync(string demoName, bool runBenchmarkScenes = True) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2E70 Offset: 0xA2270 VA: 0x1800A2E70
	// RVA: 0x529330 Offset: 0x528730 VA: 0x180529330
	public static Task RunSingleSceneAsync(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA2FF0 Offset: 0xA23F0 VA: 0x1800A2FF0
	// RVA: 0x529050 Offset: 0x528450 VA: 0x180529050
	private static Task RunBenchmarkScene(string scene) { }

	[AsyncStateMachineAttribute] // RVA: 0xA3190 Offset: 0xA2590 VA: 0x1800A3190
	// RVA: 0x529140 Offset: 0x528540 VA: 0x180529140
	public static Task RunBenchmarksInScene() { }

	[AsyncStateMachineAttribute] // RVA: 0xA3210 Offset: 0xA2610 VA: 0x1800A3210
	// RVA: 0x528E80 Offset: 0x528280 VA: 0x180528E80
	private static Task Report() { }

	[AsyncStateMachineAttribute] // RVA: 0xA32D0 Offset: 0xA26D0 VA: 0x1800A32D0
	// RVA: 0x529220 Offset: 0x528620 VA: 0x180529220
	private static Task RunDemoBasedBenchmark(string demoName, string benchmarkLabel = "") { }

	// RVA: 0x528CC0 Offset: 0x5280C0 VA: 0x180528CC0
	private static void RecordBundleSizes() { }

	// RVA: 0x529430 Offset: 0x528830 VA: 0x180529430
	private static void .cctor() { }

}

private struct Benchmarking.<RunAsync>d__7 : IAsyncStateMachine // TypeDefIndex: 8262
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string demoName; // 0x20
	public bool runBenchmarkScenes; // 0x28
	private object <>7__wrap1; // 0x30
	private int <>7__wrap2; // 0x38
	private TaskAwaiter <>u__1; // 0x40
	private string[] <>7__wrap3; // 0x48
	private int <>7__wrap4; // 0x50

	// Methods

	// RVA: 0xF2A20 Offset: 0xF1E20 VA: 0x1800F2A20 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunSingleSceneAsync>d__8 : IAsyncStateMachine // TypeDefIndex: 8263
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private object <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private TaskAwaiter <>u__1; // 0x38

	// Methods

	// RVA: 0xF2A60 Offset: 0xF1E60 VA: 0x1800F2A60 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarkScene>d__9 : IAsyncStateMachine // TypeDefIndex: 8264
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string scene; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0xF2A30 Offset: 0xF1E30 VA: 0x1800F2A30 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunBenchmarksInScene>d__10 : IAsyncStateMachine // TypeDefIndex: 8265
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter <>u__1; // 0x20
	private BenchmarkScene[] <>7__wrap1; // 0x28
	private int <>7__wrap2; // 0x30
	private IEnumerator <coroutine>5__4; // 0x38

	// Methods

	// RVA: 0xF2A40 Offset: 0xF1E40 VA: 0x1800F2A40 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<Report>d__11 : IAsyncStateMachine // TypeDefIndex: 8266
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private TaskAwaiter<string> <>u__1; // 0x20

	// Methods

	// RVA: 0xF2A10 Offset: 0xF1E10 VA: 0x1800F2A10 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Benchmarking.<RunDemoBasedBenchmark>d__12 : IAsyncStateMachine // TypeDefIndex: 8267
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public string demoName; // 0x20
	public string benchmarkLabel; // 0x28
	private TaskAwaiter <>u__1; // 0x30

	// Methods

	// RVA: 0xF2A50 Offset: 0xF1E50 VA: 0x1800F2A50 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

