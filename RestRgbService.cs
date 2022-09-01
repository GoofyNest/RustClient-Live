public abstract class RestRgbService : IRgbService // TypeDefIndex: 7679
{
	private readonly SemaphoreSlim _sema; 
	private readonly Stopwatch _heartbeatTimer; 
	private readonly Stopwatch _timeSinceFailure; 
	private bool _failed; 
	[CompilerGeneratedAttribute] 
	private bool <IsConnected>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <ColorCorrection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private HttpClient <Client>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TimeSpan <HeartbeatInterval>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TimeSpan <ReinitializeDelay>k__BackingField; 

	public bool IsConnected { get; set; }
	public Vector3 ColorCorrection { get; set; }
	protected HttpClient Client { get; set; }
	protected TimeSpan HeartbeatInterval { get; set; }
	protected TimeSpan ReinitializeDelay { get; set; }


	[CompilerGeneratedAttribute] 
	public bool get_IsConnected() { }

	[CompilerGeneratedAttribute] 
	protected void set_IsConnected(bool value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_ColorCorrection() { }

	[CompilerGeneratedAttribute] 
	public void set_ColorCorrection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	protected HttpClient get_Client() { }

	[CompilerGeneratedAttribute] 
	protected void set_Client(HttpClient value) { }

	[CompilerGeneratedAttribute] 
	protected TimeSpan get_HeartbeatInterval() { }

	[CompilerGeneratedAttribute] 
	protected void set_HeartbeatInterval(TimeSpan value) { }

	[CompilerGeneratedAttribute] 
	protected TimeSpan get_ReinitializeDelay() { }

	[CompilerGeneratedAttribute] 
	protected void set_ReinitializeDelay(TimeSpan value) { }

	protected void .ctor() { }

	protected abstract ValueTask<bool> Initialize();

	protected abstract ValueTask Shutdown();

	protected abstract Task SendHeartbeat();

	protected abstract Task SendStaticColor(Color color);

	protected abstract Task SendPulseColor(Color color, float duration);

	protected abstract Task SendEvent(RgbEventType type);

	[AsyncStateMachineAttribute] 
	public ValueTask Start() { }

	[AsyncStateMachineAttribute] 
	public ValueTask Stop() { }

	[AsyncStateMachineAttribute] 
	public ValueTask Update() { }

	[AsyncStateMachineAttribute] 
	private void SendHeartbeatAndWait() { }

	public void StaticColor(Color color) { }

	[AsyncStateMachineAttribute] 
	private void StaticColorImpl(Color color) { }

	public void PulseColor(Color color, float duration) { }

	[AsyncStateMachineAttribute] 
	private void PulseColorImpl(Color color, float duration) { }

	public void Event(RgbEventType type) { }

	[AsyncStateMachineAttribute] 
	private void EventImpl(RgbEventType type) { }

	private void ShutdownFromFailure() { }

	[AsyncStateMachineAttribute] 
	protected Task<HttpResponseMessage> SendPost<T>(string endpoint, T payload) { }
	/* GenericInstMethod :
	|
	|-RestRgbService.SendPost<GameEvent<ColorEventData>>
	|
	|-RestRgbService.SendPost<GameEvent<EmptyEventData>>
	|
	|-RestRgbService.SendPost<GameMetadata>
	|
	|-RestRgbService.SendPost<LoadGoLispHandlers>
	|
	|-RestRgbService.SendPost<RegisterGameEvent>
	|
	|-RestRgbService.SendPost<RegisterTimelineEvents>
	|
	|-RestRgbService.SendPost<RemoveGame>
	*/

	protected static HttpContent BuildContent<T>(T parameters) { }
	/* GenericInstMethod :
	|
	|-RestRgbService.BuildContent<GameEvent<ColorEventData>>
	|
	|-RestRgbService.BuildContent<GameEvent<EmptyEventData>>
	|
	|-RestRgbService.BuildContent<GameMetadata>
	|
	|-RestRgbService.BuildContent<Heartbeat>
	|
	|-RestRgbService.BuildContent<LoadGoLispHandlers>
	|
	|-RestRgbService.BuildContent<RegisterGameEvent>
	|
	|-RestRgbService.BuildContent<RegisterTimelineEvents>
	|
	|-RestRgbService.BuildContent<RemoveGame>
	*/

}

private struct RestRgbService.<Start>d__31 : IAsyncStateMachine // TypeDefIndex: 7680
{
	public int <>1__state; 
	public AsyncValueTaskMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	private TaskAwaiter <>u__1; 
	private ValueTaskAwaiter<bool> <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Stop>d__32 : IAsyncStateMachine // TypeDefIndex: 7681
{
	public int <>1__state; 
	public AsyncValueTaskMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	private TaskAwaiter <>u__1; 
	private ValueTaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<Update>d__33 : IAsyncStateMachine // TypeDefIndex: 7682
{
	public int <>1__state; 
	public AsyncValueTaskMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	private ValueTaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendHeartbeatAndWait>d__34 : IAsyncStateMachine // TypeDefIndex: 7683
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	private TaskAwaiter<bool> <>u__1; 
	private TaskAwaiter <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<StaticColorImpl>d__36 : IAsyncStateMachine // TypeDefIndex: 7684
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	public Color color; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<PulseColorImpl>d__38 : IAsyncStateMachine // TypeDefIndex: 7685
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	public Color color; 
	public float duration; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<EventImpl>d__40 : IAsyncStateMachine // TypeDefIndex: 7686
{
	public int <>1__state; 
	public AsyncVoidMethodBuilder <>t__builder; 
	public RestRgbService <>4__this; 
	public RgbEventType type; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct RestRgbService.<SendPost>d__42<T> : IAsyncStateMachine // TypeDefIndex: 7687
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<HttpResponseMessage> <>t__builder; 
	public T payload; 
	public RestRgbService <>4__this; 
	public string endpoint; 
	private TaskAwaiter<HttpResponseMessage> <>u__1; 


	private void MoveNext() { }
	/* GenericInstMethod :
	|
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.MoveNext
	|
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.MoveNext
	|
	|-RestRgbService.<SendPost>d__42<GameMetadata>.MoveNext
	|
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.MoveNext
	|
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.MoveNext
	|
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.MoveNext
	|
	|-RestRgbService.<SendPost>d__42<RemoveGame>.MoveNext
	*/

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }
	/* GenericInstMethod :
	|
	|-RestRgbService.<SendPost>d__42<GameEvent<ColorEventData>>.SetStateMachine
	|
	|-RestRgbService.<SendPost>d__42<GameEvent<EmptyEventData>>.SetStateMachine
	|
	|-RestRgbService.<SendPost>d__42<GameMetadata>.SetStateMachine
	|
	|-RestRgbService.<SendPost>d__42<LoadGoLispHandlers>.SetStateMachine
	|
	|-RestRgbService.<SendPost>d__42<RegisterGameEvent>.SetStateMachine
	|
	|-RestRgbService.<SendPost>d__42<RegisterTimelineEvents>.SetStateMachine
	|
	|-RestRgbService.<SendPost>d__42<RemoveGame>.SetStateMachine
	*/

}

