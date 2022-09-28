internal struct QueryActivePlayerSanctionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryActivePlayerSanctionsCallbackInfo>, ISettable<QueryActivePlayerSanctionsCallbackInfo>, IDisposable // TypeDefIndex: 8584
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_LocalUserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryActivePlayerSanctionsCallbackInfo other) { }

	public void Set(ref Nullable<QueryActivePlayerSanctionsCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryActivePlayerSanctionsCallbackInfo output) { }

}

