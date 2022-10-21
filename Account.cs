public static class Account // TypeDefIndex: 6177
{
	public static RealTimeSince LastUpdated; 
	public static int UnreadNotices; 
	public static AccountNotice[] Notices; 

	public static bool IsReachable { get; }


	public static bool get_IsReachable() { }

	[AsyncStateMachineAttribute] 
	public static Task Refresh() { }

	[AsyncStateMachineAttribute] 
	public static Task ReadAllNotices() { }

	private static void .cctor() { }

}

public class Account.AccountJson // TypeDefIndex: 6178
{
	[CompilerGeneratedAttribute] 
	private string <SteamId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <UnreadNotices>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AccountNotice[] <Notices>k__BackingField; 

	public string SteamId { get; set; }
	public int UnreadNotices { get; set; }
	public AccountNotice[] Notices { get; set; }


	[CompilerGeneratedAttribute] 
	public string get_SteamId() { }

	[CompilerGeneratedAttribute] 
	public void set_SteamId(string value) { }

	[CompilerGeneratedAttribute] 
	public int get_UnreadNotices() { }

	[CompilerGeneratedAttribute] 
	public void set_UnreadNotices(int value) { }

	[CompilerGeneratedAttribute] 
	public AccountNotice[] get_Notices() { }

	[CompilerGeneratedAttribute] 
	public void set_Notices(AccountNotice[] value) { }

	public void .ctor() { }

}

private struct Account.<Refresh>d__6 : IAsyncStateMachine // TypeDefIndex: 6179
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	private IAuthTicket <ticket>5__2; 
	private TaskAwaiter<IAuthTicket> <>u__1; 
	private TaskAwaiter<string> <>u__2; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Account.<ReadAllNotices>d__7 : IAsyncStateMachine // TypeDefIndex: 6180
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	private IAuthTicket <ticket>5__2; 
	private TaskAwaiter<IAuthTicket> <>u__1; 
	private TaskAwaiter<string> <>u__2; 
	private TaskAwaiter <>u__3; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

