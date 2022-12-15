public sealed class CustomInvitesInterface : Handle // TypeDefIndex: 9531
{
	public const int AddnotifycustominviteacceptedApiLatest = 1;
	public const int AddnotifycustominvitereceivedApiLatest = 1;
	public const int AddnotifycustominviterejectedApiLatest = 1;
	public const int FinalizeinviteApiLatest = 1;
	public const int MaxPayloadLength = 500;
	public const int SendcustominviteApiLatest = 1;
	public const int SetcustominviteApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyCustomInviteAccepted(ref AddNotifyCustomInviteAcceptedOptions options, object clientData, OnCustomInviteAcceptedCallback notificationFn) { }

	public ulong AddNotifyCustomInviteReceived(ref AddNotifyCustomInviteReceivedOptions options, object clientData, OnCustomInviteReceivedCallback notificationFn) { }

	public ulong AddNotifyCustomInviteRejected(ref AddNotifyCustomInviteRejectedOptions options, object clientData, OnCustomInviteRejectedCallback notificationFn) { }

	public Result FinalizeInvite(ref FinalizeInviteOptions options) { }

	public void RemoveNotifyCustomInviteAccepted(ulong inId) { }

	public void RemoveNotifyCustomInviteReceived(ulong inId) { }

	public void RemoveNotifyCustomInviteRejected(ulong inId) { }

	public void SendCustomInvite(ref SendCustomInviteOptions options, object clientData, OnSendCustomInviteCallback completionDelegate) { }

	public Result SetCustomInvite(ref SetCustomInviteOptions options) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnCustomInviteAcceptedCallbackInternalImplementation(ref OnCustomInviteAcceptedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnCustomInviteReceivedCallbackInternalImplementation(ref OnCustomInviteReceivedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnCustomInviteRejectedCallbackInternalImplementation(ref CustomInviteRejectedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute]
	internal static void OnSendCustomInviteCallbackInternalImplementation(ref SendCustomInviteCallbackInfoInternal data) { }

}

