public sealed class SessionsInterface : Handle // TypeDefIndex: 8595
{
	public const int AddnotifyjoinsessionacceptedApiLatest = 1;
	public const int AddnotifysessioninviteacceptedApiLatest = 1;
	public const int AddnotifysessioninvitereceivedApiLatest = 1;
	public const int AttributedataApiLatest = 1;
	public const int CopyactivesessionhandleApiLatest = 1;
	public const int CopysessionhandlebyinviteidApiLatest = 1;
	public const int CopysessionhandlebyuieventidApiLatest = 1;
	public const int CopysessionhandleforpresenceApiLatest = 1;
	public const int CreatesessionmodificationApiLatest = 4;
	public const int CreatesessionsearchApiLatest = 1;
	public const int DestroysessionApiLatest = 1;
	public const int DumpsessionstateApiLatest = 1;
	public const int EndsessionApiLatest = 1;
	public const int GetinvitecountApiLatest = 1;
	public const int GetinviteidbyindexApiLatest = 1;
	public const int InviteidMaxLength = 64;
	public const int IsuserinsessionApiLatest = 1;
	public const int JoinsessionApiLatest = 2;
	public const int MaxSearchResults = 200;
	public const int Maxregisteredplayers = 1000;
	public const int QueryinvitesApiLatest = 1;
	public const int RegisterplayersApiLatest = 2;
	public const int RejectinviteApiLatest = 1;
	public static readonly Utf8String SearchBucketId; 
	public static readonly Utf8String SearchEmptyServersOnly; 
	public static readonly Utf8String SearchMinslotsavailable; 
	public static readonly Utf8String SearchNonemptyServersOnly; 
	public const int SendinviteApiLatest = 1;
	public const int SessionattributeApiLatest = 1;
	public const int SessionattributedataApiLatest = 1;
	public const int StartsessionApiLatest = 1;
	public const int UnregisterplayersApiLatest = 2;
	public const int UpdatesessionApiLatest = 1;
	public const int UpdatesessionmodificationApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyJoinSessionAccepted(ref AddNotifyJoinSessionAcceptedOptions options, object clientData, OnJoinSessionAcceptedCallback notificationFn) { }

	public ulong AddNotifySessionInviteAccepted(ref AddNotifySessionInviteAcceptedOptions options, object clientData, OnSessionInviteAcceptedCallback notificationFn) { }

	public ulong AddNotifySessionInviteReceived(ref AddNotifySessionInviteReceivedOptions options, object clientData, OnSessionInviteReceivedCallback notificationFn) { }

	public Result CopyActiveSessionHandle(ref CopyActiveSessionHandleOptions options, out ActiveSession outSessionHandle) { }

	public Result CopySessionHandleByInviteId(ref CopySessionHandleByInviteIdOptions options, out SessionDetails outSessionHandle) { }

	public Result CopySessionHandleByUiEventId(ref CopySessionHandleByUiEventIdOptions options, out SessionDetails outSessionHandle) { }

	public Result CopySessionHandleForPresence(ref CopySessionHandleForPresenceOptions options, out SessionDetails outSessionHandle) { }

	public Result CreateSessionModification(ref CreateSessionModificationOptions options, out SessionModification outSessionModificationHandle) { }

	public Result CreateSessionSearch(ref CreateSessionSearchOptions options, out SessionSearch outSessionSearchHandle) { }

	public void DestroySession(ref DestroySessionOptions options, object clientData, OnDestroySessionCallback completionDelegate) { }

	public Result DumpSessionState(ref DumpSessionStateOptions options) { }

	public void EndSession(ref EndSessionOptions options, object clientData, OnEndSessionCallback completionDelegate) { }

	public uint GetInviteCount(ref GetInviteCountOptions options) { }

	public Result GetInviteIdByIndex(ref GetInviteIdByIndexOptions options, out Utf8String outBuffer) { }

	public Result IsUserInSession(ref IsUserInSessionOptions options) { }

	public void JoinSession(ref JoinSessionOptions options, object clientData, OnJoinSessionCallback completionDelegate) { }

	public void QueryInvites(ref QueryInvitesOptions options, object clientData, OnQueryInvitesCallback completionDelegate) { }

	public void RegisterPlayers(ref RegisterPlayersOptions options, object clientData, OnRegisterPlayersCallback completionDelegate) { }

	public void RejectInvite(ref RejectInviteOptions options, object clientData, OnRejectInviteCallback completionDelegate) { }

	public void RemoveNotifyJoinSessionAccepted(ulong inId) { }

	public void RemoveNotifySessionInviteAccepted(ulong inId) { }

	public void RemoveNotifySessionInviteReceived(ulong inId) { }

	public void SendInvite(ref SendInviteOptions options, object clientData, OnSendInviteCallback completionDelegate) { }

	public void StartSession(ref StartSessionOptions options, object clientData, OnStartSessionCallback completionDelegate) { }

	public void UnregisterPlayers(ref UnregisterPlayersOptions options, object clientData, OnUnregisterPlayersCallback completionDelegate) { }

	public void UpdateSession(ref UpdateSessionOptions options, object clientData, OnUpdateSessionCallback completionDelegate) { }

	public Result UpdateSessionModification(ref UpdateSessionModificationOptions options, out SessionModification outSessionModificationHandle) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDestroySessionCallbackInternalImplementation(ref DestroySessionCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnEndSessionCallbackInternalImplementation(ref EndSessionCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnJoinSessionAcceptedCallbackInternalImplementation(ref JoinSessionAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnJoinSessionCallbackInternalImplementation(ref JoinSessionCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnQueryInvitesCallbackInternalImplementation(ref QueryInvitesCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnRegisterPlayersCallbackInternalImplementation(ref RegisterPlayersCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnRejectInviteCallbackInternalImplementation(ref RejectInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnSendInviteCallbackInternalImplementation(ref SendInviteCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnSessionInviteAcceptedCallbackInternalImplementation(ref SessionInviteAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnSessionInviteReceivedCallbackInternalImplementation(ref SessionInviteReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnStartSessionCallbackInternalImplementation(ref StartSessionCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUnregisterPlayersCallbackInternalImplementation(ref UnregisterPlayersCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateSessionCallbackInternalImplementation(ref UpdateSessionCallbackInfoInternal data) { }

	private static void .cctor() { }

}

