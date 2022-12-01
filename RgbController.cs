public class RgbController : IDisposable // TypeDefIndex: 7703
{
	private readonly IReadOnlyList<IRgbService> _services;
	private readonly CancellationTokenSource _cts;
	private readonly ManualResetEventSlim _shutdown;
	[CompilerGeneratedAttribute]
	private readonly IRgbService <SteelSeries>k__BackingField;
	[CompilerGeneratedAttribute]
	private readonly IRgbService <Razer>k__BackingField;

	public IRgbService SteelSeries { get; }
	public IRgbService Razer { get; }


	[CompilerGeneratedAttribute]
	public IRgbService get_SteelSeries() { }

	[CompilerGeneratedAttribute]
	public IRgbService get_Razer() { }

	public void .ctor() { }

	public void Dispose() { }

	public void StaticColor(Color color) { }

	public void PulseColor(Color color, float duration = 1) { }

	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute]
	private void Worker() { }

	[AsyncStateMachineAttribute]
	private ValueTask StartServices() { }

	[AsyncStateMachineAttribute]
	private ValueTask StopServices() { }

	[AsyncStateMachineAttribute]
	private ValueTask UpdateServices() { }

	public static void LogError(string message) { }

	public static void LogError(Exception exception, string message) { }

}

private struct RgbController.<Worker>d__14 : IAsyncStateMachine // TypeDefIndex: 7704
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	public RgbController <>4__this;
	private CancellationToken <ct>5__2;
	private ValueTaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StartServices>d__15 : IAsyncStateMachine // TypeDefIndex: 7705
{
	public int <>1__state;
	public AsyncValueTaskMethodBuilder <>t__builder;
	public RgbController <>4__this;
	private IEnumerator<IRgbService> <>7__wrap1;
	private IRgbService <service>5__3;
	private ValueTaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<StopServices>d__16 : IAsyncStateMachine // TypeDefIndex: 7706
{
	public int <>1__state;
	public AsyncValueTaskMethodBuilder <>t__builder;
	public RgbController <>4__this;
	private IEnumerator<IRgbService> <>7__wrap1;
	private IRgbService <service>5__3;
	private ValueTaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RgbController.<UpdateServices>d__17 : IAsyncStateMachine // TypeDefIndex: 7707
{
	public int <>1__state;
	public AsyncValueTaskMethodBuilder <>t__builder;
	public RgbController <>4__this;
	private IEnumerator<IRgbService> <>7__wrap1;
	private IRgbService <service>5__3;
	private ValueTaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

