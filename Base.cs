public abstract class Base : IDisposable // TypeDefIndex: 5287
{
	[CompilerGeneratedAttribute] 
	private AppId <AppId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Action OnChanges; 
	[CompilerGeneratedAttribute] 
	private Action<ServerInfo> OnResponsiveServer; 
	public List<ServerInfo> Responsive; 
	public List<ServerInfo> Unresponsive; 
	internal HServerListRequest request; 
	internal List<MatchMakingKeyValuePair> filters; 
	internal List<int> watchList; 
	internal int LastCount; 

	internal static ISteamMatchmakingServers Internal { get; }
	public AppId AppId { get; set; }
	internal int Count { get; }
	internal bool IsRefreshing { get; }


	internal static ISteamMatchmakingServers get_Internal() { }

	[CompilerGeneratedAttribute] 
	public AppId get_AppId() { }

	[CompilerGeneratedAttribute] 
	public void set_AppId(AppId value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnChanges(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnChanges(Action value) { }

	public void .ctor() { }

	[AsyncStateMachineAttribute] 
	public virtual Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	public virtual void Cancel() { }

	internal abstract void LaunchQuery();

	internal virtual MatchMakingKeyValuePair[] GetFilters() { }

	public void AddFilter(string key, string value) { }

	internal int get_Count() { }

	internal bool get_IsRefreshing() { }

	private void Reset() { }

	private void ReleaseQuery() { }

	public void Dispose() { }

	internal void InvokeChanges() { }

	private void UpdatePending() { }

	public void UpdateResponsive() { }

	private void MovePendingToUnresponsive() { }

	private void OnServer(ServerInfo serverInfo, bool responded) { }

	[CompilerGeneratedAttribute] 
	private bool <UpdateResponsive>b__33_0(int x) { }

	[CompilerGeneratedAttribute] 
	private bool <MovePendingToUnresponsive>b__34_0(int x) { }

}

private struct Base.<RunQueryAsync>d__15 : IAsyncStateMachine // TypeDefIndex: 5288
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<bool> <>t__builder; 
	public Base <>4__this; 
	public float timeoutSeconds; 
	private Stopwatch <stopwatch>5__2; 
	private HServerListRequest <thisRequest>5__3; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public class Base // TypeDefIndex: 6259
{
	public string Parent; 
	public Auth Auth; 

	public int Version { get; }


	public int get_Version() { }

	public void .ctor() { }

}

