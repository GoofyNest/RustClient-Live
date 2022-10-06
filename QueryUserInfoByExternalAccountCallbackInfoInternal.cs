internal struct QueryUserInfoByExternalAccountCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryUserInfoByExternalAccountCallbackInfo>, ISettable<QueryUserInfoByExternalAccountCallbackInfo>, IDisposable // TypeDefIndex: 8310
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ExternalAccountId; 
	private ExternalAccountType m_AccountType; 
	private IntPtr m_TargetUserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ExternalAccountId { get; set; }
	public ExternalAccountType AccountType { get; set; }
	public EpicAccountId TargetUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public Utf8String get_ExternalAccountId() { }

	public void set_ExternalAccountId(Utf8String value) { }

	public ExternalAccountType get_AccountType() { }

	public void set_AccountType(ExternalAccountType value) { }

	public EpicAccountId get_TargetUserId() { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref QueryUserInfoByExternalAccountCallbackInfo other) { }

	public void Set(ref Nullable<QueryUserInfoByExternalAccountCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryUserInfoByExternalAccountCallbackInfo output) { }

}

