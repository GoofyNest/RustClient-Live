public sealed class AntiCheatServerInterface : Handle // TypeDefIndex: 9728
{
	public const int AddnotifyclientactionrequiredApiLatest = 1;
	public const int AddnotifyclientauthstatuschangedApiLatest = 1;
	public const int AddnotifymessagetoclientApiLatest = 1;
	public const int BeginsessionApiLatest = 3;
	public const int BeginsessionMaxRegistertimeout = 120;
	public const int BeginsessionMinRegistertimeout = 10;
	public const int EndsessionApiLatest = 1;
	public const int GetprotectmessageoutputlengthApiLatest = 1;
	public const int ProtectmessageApiLatest = 1;
	public const int ReceivemessagefromclientApiLatest = 1;
	public const int RegisterclientApiLatest = 1;
	public const int SetclientnetworkstateApiLatest = 1;
	public const int UnprotectmessageApiLatest = 1;
	public const int UnregisterclientApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyClientActionRequired(ref AddNotifyClientActionRequiredOptions options, object clientData, OnClientActionRequiredCallback notificationFn) { }

	public ulong AddNotifyClientAuthStatusChanged(ref AddNotifyClientAuthStatusChangedOptions options, object clientData, OnClientAuthStatusChangedCallback notificationFn) { }

	public ulong AddNotifyMessageToClient(ref AddNotifyMessageToClientOptions options, object clientData, OnMessageToClientCallback notificationFn) { }

	public Result BeginSession(ref BeginSessionOptions options) { }

	public Result EndSession(ref EndSessionOptions options) { }

	public Result GetProtectMessageOutputLength(ref GetProtectMessageOutputLengthOptions options, out uint outBufferSizeBytes) { }

	public Result LogEvent(ref LogEventOptions options) { }

	public Result LogGameRoundEnd(ref LogGameRoundEndOptions options) { }

	public Result LogGameRoundStart(ref LogGameRoundStartOptions options) { }

	public Result LogPlayerDespawn(ref LogPlayerDespawnOptions options) { }

	public Result LogPlayerRevive(ref LogPlayerReviveOptions options) { }

	public Result LogPlayerSpawn(ref LogPlayerSpawnOptions options) { }

	public Result LogPlayerTakeDamage(ref LogPlayerTakeDamageOptions options) { }

	public Result LogPlayerTick(ref LogPlayerTickOptions options) { }

	public Result LogPlayerUseAbility(ref LogPlayerUseAbilityOptions options) { }

	public Result LogPlayerUseWeapon(ref LogPlayerUseWeaponOptions options) { }

	public Result ProtectMessage(ref ProtectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	public Result ReceiveMessageFromClient(ref ReceiveMessageFromClientOptions options) { }

	public Result RegisterClient(ref RegisterClientOptions options) { }

	public Result RegisterEvent(ref RegisterEventOptions options) { }

	public void RemoveNotifyClientActionRequired(ulong notificationId) { }

	public void RemoveNotifyClientAuthStatusChanged(ulong notificationId) { }

	public void RemoveNotifyMessageToClient(ulong notificationId) { }

	public Result SetClientDetails(ref SetClientDetailsOptions options) { }

	public Result SetClientNetworkState(ref SetClientNetworkStateOptions options) { }

	public Result SetGameSessionId(ref SetGameSessionIdOptions options) { }

	public Result UnprotectMessage(ref UnprotectMessageOptions options, ArraySegment<byte> outBuffer, out uint outBytesWritten) { }

	public Result UnregisterClient(ref UnregisterClientOptions options) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnClientActionRequiredCallbackInternalImplementation(ref OnClientActionRequiredCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnClientAuthStatusChangedCallbackInternalImplementation(ref OnClientAuthStatusChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnMessageToClientCallbackInternalImplementation(ref OnMessageToClientCallbackInfoInternal data) { }

}

