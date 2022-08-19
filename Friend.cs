public struct Friend // TypeDefIndex: 5236
{	// Fields
	public SteamId Id; // 0x0

	// Properties
	public bool IsMe { get; }
	public bool IsFriend { get; }
	public bool IsPlayingThisGame { get; }
	public bool IsOnline { get; }
	public Relationship Relationship { get; }
	public FriendState State { get; }
	public string Name { get; }
	public Nullable<Friend.FriendGameInfo> GameInfo { get; }

	// Methods

	// RVA: 0x1D2D40 Offset: 0x1D2140 VA: 0x1801D2D40
	public void .ctor(SteamId steamid) { }

	// RVA: 0x1D2CD0 Offset: 0x1D20D0 VA: 0x1801D2CD0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1D2D90 Offset: 0x1D2190 VA: 0x1801D2D90
	public bool get_IsMe() { }

	// RVA: 0x1D2D70 Offset: 0x1D2170 VA: 0x1801D2D70
	public bool get_IsFriend() { }

	// RVA: 0x1D2E10 Offset: 0x1D2210 VA: 0x1801D2E10
	public bool get_IsPlayingThisGame() { }

	// RVA: 0x1D2DF0 Offset: 0x1D21F0 VA: 0x1801D2DF0
	public bool get_IsOnline() { }

	[AsyncStateMachineAttribute] // RVA: 0x97520 Offset: 0x96920 VA: 0x180097520
	// RVA: 0x1D2C10 Offset: 0x1D2010 VA: 0x1801D2C10
	public Task RequestInfoAsync() { }

	// RVA: 0x1D2F30 Offset: 0x1D2330 VA: 0x1801D2F30
	public Relationship get_Relationship() { }

	// RVA: 0x1D2F40 Offset: 0x1D2340 VA: 0x1801D2F40
	public FriendState get_State() { }

	// RVA: 0x1D2F20 Offset: 0x1D2320 VA: 0x1801D2F20
	public string get_Name() { }

	// RVA: 0x1D2D50 Offset: 0x1D2150 VA: 0x1801D2D50
	public Nullable<Friend.FriendGameInfo> get_GameInfo() { }

}

public struct Friend.FriendGameInfo // TypeDefIndex: 5237
{	// Fields
	internal ulong GameID; // 0x0
	internal uint GameIP; // 0x8
	internal ulong SteamIDLobby; // 0x10
	public int ConnectionPort; // 0x18
	public int QueryPort; // 0x1C

	// Properties
	public IPAddress IpAddress { get; }

	// Methods

	// RVA: 0x1D2BB0 Offset: 0x1D1FB0 VA: 0x1801D2BB0
	public IPAddress get_IpAddress() { }

	// RVA: 0x127F510 Offset: 0x127E910 VA: 0x18127F510
	internal static Friend.FriendGameInfo From(FriendGameInfo_t i) { }

}

private struct Friend.<RequestInfoAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 5238
{	// Fields
	public int <>1__state; // 0x0
	public AsyncTaskMethodBuilder <>t__builder; // 0x8
	public Friend <>4__this; // 0x20
	private TaskAwaiter <>u__1; // 0x28

	// Methods

	// RVA: 0x1DB0A0 Offset: 0x1DA4A0 VA: 0x1801DB0A0 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF2060 Offset: 0xF1460 VA: 0x1800F2060 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

