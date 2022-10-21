internal struct SendCustomInviteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendCustomInviteCallbackInfo>, ISettable<SendCustomInviteCallbackInfo>, IDisposable // TypeDefIndex: 9534
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserIds; 
	private uint m_TargetUserIdsCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId[] TargetUserIds { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public ProductUserId[] get_TargetUserIds() { }

	public void set_TargetUserIds(ProductUserId[] value) { }

	public void Set(ref SendCustomInviteCallbackInfo other) { }

	public void Set(ref Nullable<SendCustomInviteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out SendCustomInviteCallbackInfo output) { }

}

