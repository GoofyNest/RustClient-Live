internal struct JoinLobbyAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinLobbyAcceptedCallbackInfo>, ISettable<JoinLobbyAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 9114
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private ulong m_UiEventId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ulong UiEventId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ulong get_UiEventId() { }

	public void set_UiEventId(ulong value) { }

	public void Set(ref JoinLobbyAcceptedCallbackInfo other) { }

	public void Set(ref Nullable<JoinLobbyAcceptedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out JoinLobbyAcceptedCallbackInfo output) { }

}

