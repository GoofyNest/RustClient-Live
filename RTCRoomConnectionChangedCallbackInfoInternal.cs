internal struct RTCRoomConnectionChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<RTCRoomConnectionChangedCallbackInfo>, ISettable<RTCRoomConnectionChangedCallbackInfo>, IDisposable // TypeDefIndex: 9249
{
	private IntPtr m_ClientData; 
	private IntPtr m_LobbyId; 
	private IntPtr m_LocalUserId; 
	private int m_IsConnected; 
	private Result m_DisconnectReason; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool IsConnected { get; set; }
	public Result DisconnectReason { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public bool get_IsConnected() { }

	public void set_IsConnected(bool value) { }

	public Result get_DisconnectReason() { }

	public void set_DisconnectReason(Result value) { }

	public void Set(ref RTCRoomConnectionChangedCallbackInfo other) { }

	public void Set(ref Nullable<RTCRoomConnectionChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out RTCRoomConnectionChangedCallbackInfo output) { }

}

