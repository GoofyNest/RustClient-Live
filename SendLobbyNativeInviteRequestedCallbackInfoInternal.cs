internal struct SendLobbyNativeInviteRequestedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendLobbyNativeInviteRequestedCallbackInfo>, ISettable<SendLobbyNativeInviteRequestedCallbackInfo>, IDisposable // TypeDefIndex: 9271
{
	private IntPtr m_ClientData;
	private ulong m_UiEventId;
	private IntPtr m_LocalUserId;
	private IntPtr m_TargetNativeAccountType;
	private IntPtr m_TargetUserNativeAccountId;
	private IntPtr m_LobbyId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ulong UiEventId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String TargetNativeAccountType { get; set; }
	public Utf8String TargetUserNativeAccountId { get; set; }
	public Utf8String LobbyId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ulong get_UiEventId() { }

	public void set_UiEventId(ulong value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_TargetNativeAccountType() { }

	public void set_TargetNativeAccountType(Utf8String value) { }

	public Utf8String get_TargetUserNativeAccountId() { }

	public void set_TargetUserNativeAccountId(Utf8String value) { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref SendLobbyNativeInviteRequestedCallbackInfo other) { }

	public void Set(ref Nullable<SendLobbyNativeInviteRequestedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out SendLobbyNativeInviteRequestedCallbackInfo output) { }

}

