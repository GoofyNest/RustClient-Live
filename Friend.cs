public struct Friend // TypeDefIndex: 5236
{	public SteamId Id; // 0x0

	public bool IsMe { get; }
	public bool IsFriend { get; }
	public bool IsPlayingThisGame { get; }
	public bool IsOnline { get; }
	public Relationship Relationship { get; }
	public FriendState State { get; }
	public string Name { get; }
	public Nullable<Friend.FriendGameInfo> GameInfo { get; }


	public void .ctor(SteamId steamid) { }

	public override string ToString() { }

	public bool get_IsMe() { }

	public bool get_IsFriend() { }

	public bool get_IsPlayingThisGame() { }

	public bool get_IsOnline() { }

	[AsyncStateMachineAttribute] // RVA: 0x97520 Offset: 0x96920 VA: 0x180097520
	public Task RequestInfoAsync() { }

	public Relationship get_Relationship() { }

	public FriendState get_State() { }

	public string get_Name() { }

	public Nullable<Friend.FriendGameInfo> get_GameInfo() { }

}

public struct Friend.FriendGameInfo // TypeDefIndex: 5237
{	internal ulong GameID; // 0x0
	internal uint GameIP; // 0x8
	internal ulong SteamIDLobby; // 0x10
	public int ConnectionPort; // 0x18
	public int QueryPort; // 0x1C

	public IPAddress IpAddress { get; }


	public IPAddress get_IpAddress() { }

	internal static Friend.FriendGameInfo From(FriendGameInfo_t i) { }

}

private struct Friend.<RequestInfoAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 5238
{	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Friend <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28


	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

