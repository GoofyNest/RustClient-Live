public sealed class AntiCheatClientInterface : Handle // TypeDefIndex: 9821
{
	private static byte[] PollStatusStaticBuffer;
	public const int AddexternalintegritycatalogApiLatest = 1;
	public const int AddnotifyclientintegrityviolatedApiLatest = 1;
	public const int AddnotifymessagetopeerApiLatest = 1;
	public const int AddnotifymessagetoserverApiLatest = 1;
	public const int AddnotifypeeractionrequiredApiLatest = 1;
	public const int AddnotifypeerauthstatuschangedApiLatest = 1;
	public const int BeginsessionApiLatest = 3;
	public const int EndsessionApiLatest = 1;
	public const int GetprotectmessageoutputlengthApiLatest = 1;
	public IntPtr PeerSelf;
	public const int PollstatusApiLatest = 1;
	public const int ProtectmessageApiLatest = 1;
	public const int ReceivemessagefrompeerApiLatest = 1;
	public const int ReceivemessagefromserverApiLatest = 1;
	public const int RegisterpeerApiLatest = 3;
	public const int RegisterpeerMaxAuthenticationtimeout = 120;
	public const int RegisterpeerMinAuthenticationtimeout = 40;
	public const int UnprotectmessageApiLatest = 1;
	public const int UnregisterpeerApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public Result AddExternalIntegrityCatalog(ref AddExternalIntegrityCatalogOptions options) { }

	public ulong AddNotifyClientIntegrityViolated(ref AddNotifyClientIntegrityViolatedOptions options, object clientData, OnClientIntegrityViolatedCallback notificationFn) { }

	public ulong AddNotifyMessageToPeer(ref AddNotifyMessageToPeerOptions options, object clientData, OnMessageToPeerCallback notificationFn) { }

	public ulong AddNotifyMessageToServer(ref AddNotifyMessageToServerOptions options, object clientData, OnMessageToServerCallback notificationFn) { }

	public ulong AddNotifyPeerActionRequired(ref AddNotifyPeerActionRequiredOptions options, object clientData, OnPeerActionRequiredCallback notificationFn) { }

	public ulong AddNotifyPeerAuthStatusChanged(ref AddNotifyPeerAuthStatusChangedOptions options, object clientData, OnPeerAuthStatusChangedCallback notificationFn) { }

	public Result BeginSession(ref BeginSessionOptions options) { }

	public Result EndSession(ref EndSessionOptions options) { }

	public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes) { }

	public Result PollStatus(ref PollStatusOptions options, out AntiCheatClientViolationType outViolationType, out Utf8String outMessage) { }

	public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	public Result ReceiveMessageFromPeer(ref ReceiveMessageFromPeerOptions options) { }

	public Result ReceiveMessageFromServer(ref ReceiveMessageFromServerOptions options) { }

	public Result RegisterPeer(ref RegisterPeerOptions options) { }

	public void RemoveNotifyClientIntegrityViolated(ulong notificationId) { }

	public void RemoveNotifyMessageToPeer(ulong notificationId) { }

	public void RemoveNotifyMessageToServer(ulong notificationId) { }

	public void RemoveNotifyPeerActionRequired(ulong notificationId) { }

	public void RemoveNotifyPeerAuthStatusChanged(ulong notificationId) { }

	public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	public Result UnregisterPeer(ref UnregisterPeerOptions options) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnClientIntegrityViolatedCallbackInternalImplementation(ref OnClientIntegrityViolatedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnMessageToPeerCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnMessageToServerCallbackInternalImplementation(ref OnMessageToServerCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnPeerActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnPeerAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }

	private static void .cctor() { }

}

