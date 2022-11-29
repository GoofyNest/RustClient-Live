internal struct LobbyMemberStatusReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyMemberStatusReceivedCallbackInfo>, ISettable<LobbyMemberStatusReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9162
{
	private IntPtr m_ClientData; 
	private IntPtr m_LobbyId; 
	private IntPtr m_TargetUserId; 
	private LobbyMemberStatus m_CurrentStatus; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public LobbyMemberStatus CurrentStatus { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public LobbyMemberStatus get_CurrentStatus() { }

	public void set_CurrentStatus(LobbyMemberStatus value) { }

	public void Set(ref LobbyMemberStatusReceivedCallbackInfo other) { }

	public void Set(ref Nullable<LobbyMemberStatusReceivedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbyMemberStatusReceivedCallbackInfo output) { }

}

