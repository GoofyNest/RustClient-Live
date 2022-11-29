internal struct QueryIdTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryIdTokenCallbackInfo>, ISettable<QueryIdTokenCallbackInfo>, IDisposable // TypeDefIndex: 9699
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetAccountId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetAccountId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public EpicAccountId get_TargetAccountId() { }

	public void set_TargetAccountId(EpicAccountId value) { }

	public void Set(ref QueryIdTokenCallbackInfo other) { }

	public void Set(ref Nullable<QueryIdTokenCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryIdTokenCallbackInfo output) { }

}

