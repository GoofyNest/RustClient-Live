internal struct LobbyInviteReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyInviteReceivedCallbackInfo>, ISettable<LobbyInviteReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9148
{
	private IntPtr m_ClientData; 
	private IntPtr m_InviteId; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_InviteId() { }

	public void set_InviteId(Utf8String value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref LobbyInviteReceivedCallbackInfo other) { }

	public void Set(ref Nullable<LobbyInviteReceivedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbyInviteReceivedCallbackInfo output) { }

}

