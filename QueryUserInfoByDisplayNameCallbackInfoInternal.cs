internal struct QueryUserInfoByDisplayNameCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoByDisplayNameCallbackInfo>, ISettable<QueryUserInfoByDisplayNameCallbackInfo>, IDisposable // TypeDefIndex: 8306
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_DisplayName; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public Utf8String DisplayName { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public EpicAccountId get_TargetUserId() { }

	public void set_TargetUserId(EpicAccountId value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public void Set(ref QueryUserInfoByDisplayNameCallbackInfo other) { }

	public void Set(ref Nullable<QueryUserInfoByDisplayNameCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryUserInfoByDisplayNameCallbackInfo output) { }

}

