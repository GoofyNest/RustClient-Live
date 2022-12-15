internal struct SessionInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<SessionInviteAcceptedCallbackInfo>, ISettable<SessionInviteAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 8567
{
	private IntPtr m_ClientData;
	private IntPtr m_SessionId;
	private IntPtr m_LocalUserId;
	private IntPtr m_TargetUserId;
	private IntPtr m_InviteId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String SessionId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String InviteId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_SessionId() { }

	public void set_SessionId(Utf8String value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public Utf8String get_InviteId() { }

	public void set_InviteId(Utf8String value) { }

	public void Set(ref SessionInviteAcceptedCallbackInfo other) { }

	public void Set(ref Nullable<SessionInviteAcceptedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out SessionInviteAcceptedCallbackInfo output) { }

}

