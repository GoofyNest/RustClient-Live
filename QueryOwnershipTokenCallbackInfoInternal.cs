internal struct QueryOwnershipTokenCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryOwnershipTokenCallbackInfo>, ISettable<QueryOwnershipTokenCallbackInfo>, IDisposable // TypeDefIndex: 9507
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_OwnershipToken; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OwnershipToken { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public Utf8String get_OwnershipToken() { }

	public void set_OwnershipToken(Utf8String value) { }

	public void Set(ref QueryOwnershipTokenCallbackInfo other) { }

	public void Set(ref Nullable<QueryOwnershipTokenCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryOwnershipTokenCallbackInfo output) { }

}

