internal struct OnCustomInviteAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnCustomInviteAcceptedCallbackInfo>, ISettable<OnCustomInviteAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 9524
{
	private IntPtr m_ClientData; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_CustomInviteId; 
	private IntPtr m_Payload; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_CustomInviteId() { }

	public void set_CustomInviteId(Utf8String value) { }

	public Utf8String get_Payload() { }

	public void set_Payload(Utf8String value) { }

	public void Set(ref OnCustomInviteAcceptedCallbackInfo other) { }

	public void Set(ref Nullable<OnCustomInviteAcceptedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnCustomInviteAcceptedCallbackInfo output) { }

}

