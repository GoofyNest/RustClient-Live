public struct Friend // TypeDefIndex: 5237
{
	public SteamId Id; 

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

	[AsyncStateMachineAttribute] 
	public Task RequestInfoAsync() { }

	public Relationship get_Relationship() { }

	public FriendState get_State() { }

	public string get_Name() { }

	public Nullable<Friend.FriendGameInfo> get_GameInfo() { }

}

public struct Friend.FriendGameInfo // TypeDefIndex: 5238
{
	internal ulong GameID; 
	internal uint GameIP; 
	internal ulong SteamIDLobby; 
	public int ConnectionPort; 
	public int QueryPort; 

	public IPAddress IpAddress { get; }


	public IPAddress get_IpAddress() { }

	internal static Friend.FriendGameInfo From(FriendGameInfo_t i) { }

}

private struct Friend.<RequestInfoAsync>d__13 : IAsyncStateMachine // TypeDefIndex: 5239
{
	public int <>1__state; 
	public AsyncTaskMethodBuilder <>t__builder; 
	public Friend <>4__this; 
	private TaskAwaiter <>u__1; 


	private void MoveNext() { }

	[DebuggerHiddenAttribute] 
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

