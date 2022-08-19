public static class Account // TypeDefIndex: 6172
{	// Fields
	public static RealTimeSince LastUpdated; // 0x0
	public static int UnreadNotices; // 0x4
	public static AccountNotice[] Notices; // 0x8

	// Properties
	public static bool IsReachable { get; }

	// Methods

	// RVA: 0x14E05D0 Offset: 0x14DF9D0 VA: 0x1814E05D0
	public static bool get_IsReachable() { }

	[AsyncStateMachineAttribute] // RVA: 0x9EE50 Offset: 0x9E250 VA: 0x18009EE50
	// RVA: 0x14E04B0 Offset: 0x14DF8B0 VA: 0x1814E04B0
	public static Task Refresh() { }

	[AsyncStateMachineAttribute] // RVA: 0x9EF00 Offset: 0x9E300 VA: 0x18009EF00
	// RVA: 0x14E03D0 Offset: 0x14DF7D0 VA: 0x1814E03D0
	public static Task ReadAllNotices() { }

	// RVA: 0x14E0580 Offset: 0x14DF980 VA: 0x1814E0580
	private static void .cctor() { }

}

public class Account.AccountJson // TypeDefIndex: 6173
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <SteamId>k__BackingField; // 0x10
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <UnreadNotices>k__BackingField; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AccountNotice[] <Notices>k__BackingField; // 0x20

	// Properties
	public string SteamId { get; set; }
	public int UnreadNotices { get; set; }
	public AccountNotice[] Notices { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_SteamId() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_SteamId(string value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_UnreadNotices() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8E20 Offset: 0x7E8220 VA: 0x1807E8E20
	public void set_UnreadNotices(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public AccountNotice[] get_Notices() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_Notices(AccountNotice[] value) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

private struct Account.<Refresh>d__6 : IAsyncStateMachine // TypeDefIndex: 6174
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<string> <>u__2; // 0x30

	// Methods

	// RVA: 0x1F1950 Offset: 0x1F0D50 VA: 0x1801F1950 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

private struct Account.<ReadAllNotices>d__7 : IAsyncStateMachine // TypeDefIndex: 6175
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	private IAuthTicket <ticket>5__2; // 0x20
	private TaskAwaiter<IAuthTicket> <>u__1; // 0x28
	private TaskAwaiter<string> <>u__2; // 0x30
	private TaskAwaiter <>u__3; // 0x38

	// Methods

	// RVA: 0x1F1940 Offset: 0x1F0D40 VA: 0x1801F1940 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

