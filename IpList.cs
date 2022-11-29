public class IpList : Internet // TypeDefIndex: 5295
{
	public List<string> Ips; 
	private bool wantsCancel; 


	public void .ctor(IEnumerable<string> list) { }

	[AsyncStateMachineAttribute] 
	public override Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	public override void Cancel() { }

}

private struct IpList.<RunQueryAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 5296
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder<bool> <>t__builder; 
	public IpList <>4__this; 
	public float timeoutSeconds; 
	private int <blockSize>5__2; 
	private int <pointer>5__3; 
	private string[] <ips>5__4; 
	private IEnumerable<string> <sublist>5__5; 
	private Internet <list>5__6; 
	private TaskAwaiter<bool> <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

