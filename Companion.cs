public class CompanionSetupScreen : SingletonComponent<CompanionSetupScreen> // TypeDefIndex: 12875
{
	public const string PairedKey = "companionPaired";
	public GameObject instructionsBody;
	public GameObject detailsPanel;
	public GameObject loadingMessage;
	public GameObject errorMessage;
	public GameObject notSupportedMessage;
	public GameObject disabledMessage;
	public GameObject enabledMessage;
	public GameObject refreshButton;
	public GameObject enableButton;
	public GameObject disableButton;
	public GameObject pairButton;
	public RustText serverName;
	public RustButton helpButton;
	[CompilerGeneratedAttribute]
	private CompanionSetupScreen.ScreenState <State>k__BackingField;
	private bool _isLoading;
	private Nullable<bool> _enabled;
	private bool _hidePair;

	public CompanionSetupScreen.ScreenState State { get; set; }


	[CompilerGeneratedAttribute]
	public CompanionSetupScreen.ScreenState get_State() { }

	[CompilerGeneratedAttribute]
	private void set_State(CompanionSetupScreen.ScreenState value) { }

	public void OnEnable() { }

	public void Refresh() { }

	[AsyncStateMachineAttribute]
	public void RefreshImpl() { }

	[AsyncStateMachineAttribute]
	public void Enable() { }

	[AsyncStateMachineAttribute]
	public void Disable() { }

	public void Pair() { }

	private void ResetPair() { }

	public void OpenVideo() { }

	public void HelpPressed() { }

	public void HelpReleased() { }

	private void UpdateUI() { }

	public void ChangeState(CompanionSetupScreen.ScreenState state) { }

	public void .ctor() { }

}

public enum CompanionSetupScreen.ScreenState // TypeDefIndex: 12876
{
	public int value__;
	public const CompanionSetupScreen.ScreenState Loading = 0;
	public const CompanionSetupScreen.ScreenState Error = 1;
	public const CompanionSetupScreen.ScreenState NoServer = 2;
	public const CompanionSetupScreen.ScreenState NotSupported = 3;
	public const CompanionSetupScreen.ScreenState NotInstalled = 4;
	public const CompanionSetupScreen.ScreenState Disabled = 5;
	public const CompanionSetupScreen.ScreenState Enabled = 6;
	public const CompanionSetupScreen.ScreenState ShowHelp = 7;

}

private struct CompanionSetupScreen.<RefreshImpl>d__24 : IAsyncStateMachine // TypeDefIndex: 12877
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	public CompanionSetupScreen <>4__this;
	private TaskAwaiter<CompanionSubscription.Status> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Enable>d__25 : IAsyncStateMachine // TypeDefIndex: 12878
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	public CompanionSetupScreen <>4__this;
	private TaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSetupScreen.<Disable>d__26 : IAsyncStateMachine // TypeDefIndex: 12879
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	public CompanionSetupScreen <>4__this;
	private TaskAwaiter <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public static class CompanionSubscription // TypeDefIndex: 12880
{
	private const string ApiEndpoint = "https:
	private const string CheckApi = "https:
	private const string AddApi = "https:
	private const string RemoveApi = "https:
	private static readonly HttpClient Http;


	[AsyncStateMachineAttribute]
	public static Task<CompanionSubscription.Status> CheckStatus() { }

	[AsyncStateMachineAttribute]
	public static Task Add() { }

	[AsyncStateMachineAttribute]
	public static Task Remove() { }

	private static StringContent GenerateRequest(IAuthTicket authTicket) { }

	private static void .cctor() { }

}

private class CompanionSubscription.Request // TypeDefIndex: 12881
{
	public string SteamTicket;
	public string ServerId;


	public void .ctor() { }

}

public class CompanionSubscription.Status // TypeDefIndex: 12882
{
	public bool IsInstalled;
	public bool IsSubscribed;


	public void .ctor() { }

}

private struct CompanionSubscription.<CheckStatus>d__5 : IAsyncStateMachine // TypeDefIndex: 12883
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<CompanionSubscription.Status> <>t__builder;
	private IAuthTicket <ticket>5__2;
	private TaskAwaiter<IAuthTicket> <>u__1;
	private TaskAwaiter<HttpResponseMessage> <>u__2;
	private TaskAwaiter<string> <>u__3;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Add>d__6 : IAsyncStateMachine // TypeDefIndex: 12884
{
	public int <>1__state;
	public AsyncTaskMethodBuilder <>t__builder;
	private IAuthTicket <ticket>5__2;
	private TaskAwaiter<IAuthTicket> <>u__1;
	private TaskAwaiter<HttpResponseMessage> <>u__2;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct CompanionSubscription.<Remove>d__7 : IAsyncStateMachine // TypeDefIndex: 12885
{
	public int <>1__state;
	public AsyncTaskMethodBuilder <>t__builder;
	private IAuthTicket <ticket>5__2;
	private TaskAwaiter<IAuthTicket> <>u__1;
	private TaskAwaiter<HttpResponseMessage> <>u__2;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

