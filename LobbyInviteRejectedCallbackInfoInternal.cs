internal struct LobbyInviteRejectedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteRejectedCallbackInfo>, ISettable<LobbyInviteRejectedCallbackInfo>, IDisposable // TypeDefIndex: 9150
{
	private IntPtr m_ClientData; 
	private IntPtr m_InviteId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_LobbyId; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public Utf8String LobbyId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_InviteId() { }

	public void set_InviteId(Utf8String value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref LobbyInviteRejectedCallbackInfo other) { }

	public void Set(ref Nullable<LobbyInviteRejectedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbyInviteRejectedCallbackInfo output) { }

}

