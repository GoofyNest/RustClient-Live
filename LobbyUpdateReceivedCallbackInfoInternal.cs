internal struct LobbyUpdateReceivedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbyUpdateReceivedCallbackInfo>, ISettable<LobbyUpdateReceivedCallbackInfo>, IDisposable // TypeDefIndex: 9209
{
	private IntPtr m_ClientData;
	private IntPtr m_LobbyId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref LobbyUpdateReceivedCallbackInfo other) { }

	public void Set(ref Nullable<LobbyUpdateReceivedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbyUpdateReceivedCallbackInfo output) { }

}

