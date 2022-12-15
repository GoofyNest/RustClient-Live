public sealed class PresenceInterface : Handle // TypeDefIndex: 8847
{
	public const int AddnotifyjoingameacceptedApiLatest = 2;
	public const int AddnotifyonpresencechangedApiLatest = 1;
	public const int CopypresenceApiLatest = 3;
	public const int CreatepresencemodificationApiLatest = 1;
	public const int DataMaxKeyLength = 64;
	public const int DataMaxKeys = 32;
	public const int DataMaxValueLength = 255;
	public const int DatarecordApiLatest = 1;
	public const int DeletedataApiLatest = 1;
	public const int GetjoininfoApiLatest = 1;
	public const int HaspresenceApiLatest = 1;
	public const int InfoApiLatest = 3;
	public static readonly Utf8String KeyPlatformPresence;
	public const int QuerypresenceApiLatest = 1;
	public const int RichTextMaxValueLength = 255;
	public const int SetdataApiLatest = 1;
	public const int SetpresenceApiLatest = 1;
	public const int SetrawrichtextApiLatest = 1;
	public const int SetstatusApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyJoinGameAccepted(ref AddNotifyJoinGameAcceptedOptions options, object clientData, OnJoinGameAcceptedCallback notificationFn) { }

	public ulong AddNotifyOnPresenceChanged(ref AddNotifyOnPresenceChangedOptions options, object clientData, OnPresenceChangedCallback notificationHandler) { }

	public Result CopyPresence(ref CopyPresenceOptions options, out Nullable<Info> outPresence) { }

	public Result CreatePresenceModification(ref CreatePresenceModificationOptions options, out PresenceModification outPresenceModificationHandle) { }

	public Result GetJoinInfo(ref GetJoinInfoOptions options, out Utf8String outBuffer) { }

	public bool HasPresence(ref HasPresenceOptions options) { }

	public void QueryPresence(ref QueryPresenceOptions options, object clientData, OnQueryPresenceCompleteCallback completionDelegate) { }

	public void RemoveNotifyJoinGameAccepted(ulong inId) { }

	public void RemoveNotifyOnPresenceChanged(ulong notificationId) { }

	public void SetPresence(ref SetPresenceOptions options, object clientData, SetPresenceCompleteCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnJoinGameAcceptedCallbackInternalImplementation(ref JoinGameAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnPresenceChangedCallbackInternalImplementation(ref PresenceChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnQueryPresenceCompleteCallbackInternalImplementation(ref QueryPresenceCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void SetPresenceCompleteCallbackInternalImplementation(ref SetPresenceCallbackInfoInternal data) { }

	private static void .cctor() { }

}

