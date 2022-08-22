public class IpList : Internet // TypeDefIndex: 5289
{	public List<string> Ips; // 0x58
	private bool wantsCancel; // 0x60


	public void .ctor(IEnumerable<string> list) { }

	[AsyncStateMachineAttribute] // RVA: 0xA25F0 Offset: 0xA19F0 VA: 0x1800A25F0
	public override Task<bool> RunQueryAsync(float timeoutSeconds = 10) { }

	public override void Cancel() { }

}

private struct IpList.<RunQueryAsync>d__4 : IAsyncStateMachine // TypeDefIndex: 5290
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder<bool> <>t__builder; // 0x8
	public IpList <>4__this; // 0x20
	public float timeoutSeconds; // 0x28
	private int <blockSize>5__2; // 0x2C
	private int <pointer>5__3; // 0x30
	private string[] <ips>5__4; // 0x38
	private IEnumerable<string> <sublist>5__5; // 0x40
	private Internet <list>5__6; // 0x48
	private TaskAwaiter<bool> <>u__1; // 0x50


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

