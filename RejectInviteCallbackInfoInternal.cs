internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable // TypeDefIndex: 8539
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public void Set(ref RejectInviteCallbackInfo other) { }

	public void Set(ref Nullable<RejectInviteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out RejectInviteCallbackInfo output) { }

}

internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable // TypeDefIndex: 9261
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_InviteId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String InviteId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_InviteId() { }

	public void set_InviteId(Utf8String value) { }

	public void Set(ref RejectInviteCallbackInfo other) { }

	public void Set(ref Nullable<RejectInviteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out RejectInviteCallbackInfo output) { }

}

internal struct RejectInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<RejectInviteCallbackInfo>, ISettable<RejectInviteCallbackInfo>, IDisposable // TypeDefIndex: 9410
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public EpicAccountId get_TargetUserId() { }

	public void set_TargetUserId(EpicAccountId value) { }

	public void Set(ref RejectInviteCallbackInfo other) { }

	public void Set(ref Nullable<RejectInviteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out RejectInviteCallbackInfo output) { }

}

