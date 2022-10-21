internal struct OnShowBlockPlayerCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnShowBlockPlayerCallbackInfo>, ISettable<OnShowBlockPlayerCallbackInfo>, IDisposable // TypeDefIndex: 8348
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

	public void Set(ref OnShowBlockPlayerCallbackInfo other) { }

	public void Set(ref Nullable<OnShowBlockPlayerCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnShowBlockPlayerCallbackInfo output) { }

}

