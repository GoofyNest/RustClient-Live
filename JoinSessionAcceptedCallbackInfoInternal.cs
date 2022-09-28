internal struct JoinSessionAcceptedCallbackInfoInternal : ICallbackInfoInternal, IGettable<JoinSessionAcceptedCallbackInfo>, ISettable<JoinSessionAcceptedCallbackInfo>, IDisposable // TypeDefIndex: 8453
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

	public void Set(ref JoinSessionAcceptedCallbackInfo other) { }

	public void Set(ref Nullable<JoinSessionAcceptedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out JoinSessionAcceptedCallbackInfo output) { }

}

