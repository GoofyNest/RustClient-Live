public sealed class FriendsInterface : Handle // TypeDefIndex: 9341
{
	public const int AcceptinviteApiLatest = 1;
	public const int AddnotifyfriendsupdateApiLatest = 1;
	public const int GetfriendatindexApiLatest = 1;
	public const int GetfriendscountApiLatest = 1;
	public const int GetstatusApiLatest = 1;
	public const int QueryfriendsApiLatest = 1;
	public const int RejectinviteApiLatest = 1;
	public const int SendinviteApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public void AcceptInvite(ref AcceptInviteOptions options, object clientData, OnAcceptInviteCallback completionDelegate) { }

	public ulong AddNotifyFriendsUpdate(ref AddNotifyFriendsUpdateOptions options, object clientData, OnFriendsUpdateCallback friendsUpdateHandler) { }

	public EpicAccountId GetFriendAtIndex(ref GetFriendAtIndexOptions options) { }

	public int GetFriendsCount(ref GetFriendsCountOptions options) { }

	public FriendsStatus GetStatus(ref GetStatusOptions options) { }

	public void QueryFriends(ref QueryFriendsOptions options, object clientData, OnQueryFriendsCallback completionDelegate) { }

	public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate) { }

	public void RemoveNotifyFriendsUpdate(ulong notificationId) { }

	public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAcceptInviteCallbackInternalImplementation(ref AcceptInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnFriendsUpdateCallbackInternalImplementation(ref OnFriendsUpdateInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryFriendsCallbackInternalImplementation(ref QueryFriendsCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data) { }

}

