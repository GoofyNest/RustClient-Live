public sealed class RTCInterface : Handle // TypeDefIndex: 8783
{
	public const int AddnotifydisconnectedApiLatest = 1;
	public const int AddnotifyparticipantstatuschangedApiLatest = 1;
	public const int BlockparticipantApiLatest = 1;
	public const int JoinroomApiLatest = 1;
	public const int LeaveroomApiLatest = 1;
	public const int ParticipantmetadataApiLatest = 1;
	public const int ParticipantmetadataKeyMaxcharcount = 256;
	public const int ParticipantmetadataValueMaxcharcount = 256;
	public const int SetroomsettingApiLatest = 1;
	public const int SetsettingApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyDisconnected(ref AddNotifyDisconnectedOptions options, object clientData, OnDisconnectedCallback completionDelegate) { }

	public ulong AddNotifyParticipantStatusChanged(ref AddNotifyParticipantStatusChangedOptions options, object clientData, OnParticipantStatusChangedCallback completionDelegate) { }

	public void BlockParticipant(ref BlockParticipantOptions options, object clientData, OnBlockParticipantCallback completionDelegate) { }

	public RTCAudioInterface GetAudioInterface() { }

	public void JoinRoom(ref JoinRoomOptions options, object clientData, OnJoinRoomCallback completionDelegate) { }

	public void LeaveRoom(ref LeaveRoomOptions options, object clientData, OnLeaveRoomCallback completionDelegate) { }

	public void RemoveNotifyDisconnected(ulong notificationId) { }

	public void RemoveNotifyParticipantStatusChanged(ulong notificationId) { }

	public Result SetRoomSetting(ref SetRoomSettingOptions options) { }

	public Result SetSetting(ref SetSettingOptions options) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnBlockParticipantCallbackInternalImplementation(ref BlockParticipantCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnDisconnectedCallbackInternalImplementation(ref DisconnectedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnJoinRoomCallbackInternalImplementation(ref JoinRoomCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnLeaveRoomCallbackInternalImplementation(ref LeaveRoomCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnParticipantStatusChangedCallbackInternalImplementation(ref ParticipantStatusChangedCallbackInfoInternal data) { }

}

