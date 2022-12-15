internal struct LobbyMemberUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyMemberUpdateReceivedCallbackInfo>, ISettable<LobbyMemberUpdateReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9168
{
	private IntPtr m_ClientData;
	private IntPtr m_LobbyId;
	private IntPtr m_TargetUserId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref LobbyMemberUpdateReceivedCallbackInfo other) { }

	public void Set(ref Nullable<LobbyMemberUpdateReceivedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbyMemberUpdateReceivedCallbackInfo output) { }

}

