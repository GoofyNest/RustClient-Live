public sealed class RTCAudioInterface : Handle // TypeDefIndex: 8701
{
	public const int AddnotifyaudiobeforerenderApiLatest = 1;
	public const int AddnotifyaudiobeforesendApiLatest = 1;
	public const int AddnotifyaudiodeviceschangedApiLatest = 1;
	public const int AddnotifyaudioinputstateApiLatest = 1;
	public const int AddnotifyaudiooutputstateApiLatest = 1;
	public const int AddnotifyparticipantupdatedApiLatest = 1;
	public const int AudiobufferApiLatest = 1;
	public const int AudioinputdeviceinfoApiLatest = 1;
	public const int AudiooutputdeviceinfoApiLatest = 1;
	public const int GetaudioinputdevicebyindexApiLatest = 1;
	public const int GetaudioinputdevicescountApiLatest = 1;
	public const int GetaudiooutputdevicebyindexApiLatest = 1;
	public const int GetaudiooutputdevicescountApiLatest = 1;
	public const int RegisterplatformaudiouserApiLatest = 1;
	public const int SendaudioApiLatest = 1;
	public const int SetaudioinputsettingsApiLatest = 1;
	public const int SetaudiooutputsettingsApiLatest = 1;
	public const int UnregisterplatformaudiouserApiLatest = 1;
	public const int UpdateparticipantvolumeApiLatest = 1;
	public const int UpdatereceivingApiLatest = 1;
	public const int UpdatereceivingvolumeApiLatest = 1;
	public const int UpdatesendingApiLatest = 1;
	public const int UpdatesendingvolumeApiLatest = 1;


	public void .ctor() { }

	public void .ctor(IntPtr innerHandle) { }

	public ulong AddNotifyAudioBeforeRender(ref AddNotifyAudioBeforeRenderOptions options, object clientData, OnAudioBeforeRenderCallback completionDelegate) { }

	public ulong AddNotifyAudioBeforeSend(ref AddNotifyAudioBeforeSendOptions options, object clientData, OnAudioBeforeSendCallback completionDelegate) { }

	public ulong AddNotifyAudioDevicesChanged(ref AddNotifyAudioDevicesChangedOptions options, object clientData, OnAudioDevicesChangedCallback completionDelegate) { }

	public ulong AddNotifyAudioInputState(ref AddNotifyAudioInputStateOptions options, object clientData, OnAudioInputStateCallback completionDelegate) { }

	public ulong AddNotifyAudioOutputState(ref AddNotifyAudioOutputStateOptions options, object clientData, OnAudioOutputStateCallback completionDelegate) { }

	public ulong AddNotifyParticipantUpdated(ref AddNotifyParticipantUpdatedOptions options, object clientData, OnParticipantUpdatedCallback completionDelegate) { }

	public Nullable<AudioInputDeviceInfo> GetAudioInputDeviceByIndex(ref GetAudioInputDeviceByIndexOptions options) { }

	public uint GetAudioInputDevicesCount(ref GetAudioInputDevicesCountOptions options) { }

	public Nullable<AudioOutputDeviceInfo> GetAudioOutputDeviceByIndex(ref GetAudioOutputDeviceByIndexOptions options) { }

	public uint GetAudioOutputDevicesCount(ref GetAudioOutputDevicesCountOptions options) { }

	public Result RegisterPlatformAudioUser(ref RegisterPlatformAudioUserOptions options) { }

	public void RemoveNotifyAudioBeforeRender(ulong notificationId) { }

	public void RemoveNotifyAudioBeforeSend(ulong notificationId) { }

	public void RemoveNotifyAudioDevicesChanged(ulong notificationId) { }

	public void RemoveNotifyAudioInputState(ulong notificationId) { }

	public void RemoveNotifyAudioOutputState(ulong notificationId) { }

	public void RemoveNotifyParticipantUpdated(ulong notificationId) { }

	public Result SendAudio(ref SendAudioOptions options) { }

	public Result SetAudioInputSettings(ref SetAudioInputSettingsOptions options) { }

	public Result SetAudioOutputSettings(ref SetAudioOutputSettingsOptions options) { }

	public Result UnregisterPlatformAudioUser(ref UnregisterPlatformAudioUserOptions options) { }

	public void UpdateParticipantVolume(ref UpdateParticipantVolumeOptions options, object clientData, OnUpdateParticipantVolumeCallback completionDelegate) { }

	public void UpdateReceiving(ref UpdateReceivingOptions options, object clientData, OnUpdateReceivingCallback completionDelegate) { }

	public void UpdateReceivingVolume(ref UpdateReceivingVolumeOptions options, object clientData, OnUpdateReceivingVolumeCallback completionDelegate) { }

	public void UpdateSending(ref UpdateSendingOptions options, object clientData, OnUpdateSendingCallback completionDelegate) { }

	public void UpdateSendingVolume(ref UpdateSendingVolumeOptions options, object clientData, OnUpdateSendingVolumeCallback completionDelegate) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAudioBeforeRenderCallbackInternalImplementation(ref AudioBeforeRenderCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAudioBeforeSendCallbackInternalImplementation(ref AudioBeforeSendCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAudioDevicesChangedCallbackInternalImplementation(ref AudioDevicesChangedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAudioInputStateCallbackInternalImplementation(ref AudioInputStateCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnAudioOutputStateCallbackInternalImplementation(ref AudioOutputStateCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnParticipantUpdatedCallbackInternalImplementation(ref ParticipantUpdatedCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateParticipantVolumeCallbackInternalImplementation(ref UpdateParticipantVolumeCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateReceivingCallbackInternalImplementation(ref UpdateReceivingCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateReceivingVolumeCallbackInternalImplementation(ref UpdateReceivingVolumeCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateSendingCallbackInternalImplementation(ref UpdateSendingCallbackInfoInternal data) { }

	[MonoPInvokeCallbackAttribute] 
	internal static void OnUpdateSendingVolumeCallbackInternalImplementation(ref UpdateSendingVolumeCallbackInfoInternal data) { }

}

