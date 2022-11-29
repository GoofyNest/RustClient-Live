internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<LinkAccountCallbackInfo>, ISettable<LinkAccountCallbackInfo>, IDisposable // TypeDefIndex: 9590
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref LinkAccountCallbackInfo other) { }

	public void Set(ref Nullable<LinkAccountCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LinkAccountCallbackInfo output) { }

}

internal struct LinkAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<LinkAccountCallbackInfo>, ISettable<LinkAccountCallbackInfo>, IDisposable // TypeDefIndex: 9665
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_PinGrantInfo; 
	private IntPtr m_SelectedAccountId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Nullable<PinGrantInfo> PinGrantInfo { get; set; }
	public EpicAccountId SelectedAccountId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public Nullable<PinGrantInfo> get_PinGrantInfo() { }

	public void set_PinGrantInfo(Nullable<PinGrantInfo> value) { }

	public EpicAccountId get_SelectedAccountId() { }

	public void set_SelectedAccountId(EpicAccountId value) { }

	public void Set(ref LinkAccountCallbackInfo other) { }

	public void Set(ref Nullable<LinkAccountCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LinkAccountCallbackInfo output) { }

}

