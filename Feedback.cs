public static class Feedback // TypeDefIndex: 6203
{

	[AsyncStateMachineAttribute]
	public static Task<string> Report(Feedback feedback) { }

}

private struct Feedback.<Report>d__0 : IAsyncStateMachine // TypeDefIndex: 6204
{
	public int <>1__state;
	public AsyncTaskMethodBuilder<string> <>t__builder;
	public Feedback feedback;
	private IAuthTicket <ticket>5__2;
	private TaskAwaiter<IAuthTicket> <>u__1;
	private TaskAwaiter<string> <>u__2;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

public struct Feedback // TypeDefIndex: 6251
{
	public string Subject;
	public string Message;
	public ReportType Type;
	public string TargetReportType;
	public string TargetId;
	public string TargetName;
	public string TargetEntity;
	public List<ulong> UsersInRange;
	public AppInfo AppInfo;

}

