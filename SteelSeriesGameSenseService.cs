public class SteelSeriesGameSenseService : RestRgbService // TypeDefIndex: 7694
{
	private const string GameId = "RUST";
	private const string StaticColorEvent = "STATIC_COLOR";
	private const string PulseColorEvent = "PULSE_COLOR";
	private const string AllyDeathEvent = "ALLY_DIED";
	private const string EnemyDeathEvent = "ENEMY_DIED";
	private static readonly string PulseHandlerCode; 
	private string _address; 
	private string _heartbeatEndpoint; 
	private HttpContent _heartbeatContent; 
	private string _gameEventEndpoint; 


	[AsyncStateMachineAttribute] 
	protected override ValueTask<bool> Initialize() { }

	[AsyncStateMachineAttribute] 
	protected override ValueTask Shutdown() { }

	[AsyncStateMachineAttribute] 
	protected override Task SendHeartbeat() { }

	[AsyncStateMachineAttribute] 
	protected override Task SendStaticColor(Color color) { }

	[AsyncStateMachineAttribute] 
	protected override Task SendPulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] 
	protected override Task SendEvent(RgbEventType type) { }

	private static string TryGetMomentsEvent(RgbEventType type) { }

	private ColorData GetColorData(Color color) { }

	private string GetEndpoint(string path) { }

	private static string GetGameSenseAddress() { }

	private static string GetCorePropsPath() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct SteelSeriesGameSenseService.<Initialize>d__10 : IAsyncStateMachine // TypeDefIndex: 7695
{
	public int <>1__state; 
	public AsyncValueTaskMethodBuilder<bool> <>t__builder; 
	public SteelSeriesGameSenseService <>4__this; 
	private string <registerGameEventEndpoint>5__2; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<Shutdown>d__11 : IAsyncStateMachine // TypeDefIndex: 7696
{
	public int <>1__state; 
	public AsyncValueTaskMethodBuilder <>t__builder; 
	public SteelSeriesGameSenseService <>4__this; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendHeartbeat>d__12 : IAsyncStateMachine // TypeDefIndex: 7697
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public SteelSeriesGameSenseService <>4__this; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendStaticColor>d__13 : IAsyncStateMachine // TypeDefIndex: 7698
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public SteelSeriesGameSenseService <>4__this; 
	public Color color; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendPulseColor>d__14 : IAsyncStateMachine // TypeDefIndex: 7699
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public SteelSeriesGameSenseService <>4__this; 
	public float duration; 
	public Color color; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct SteelSeriesGameSenseService.<SendEvent>d__15 : IAsyncStateMachine // TypeDefIndex: 7700
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public RgbEventType type; 
	public SteelSeriesGameSenseService <>4__this; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

