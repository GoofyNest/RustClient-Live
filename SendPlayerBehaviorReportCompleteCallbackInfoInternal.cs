internal struct SendPlayerBehaviorReportCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<SendPlayerBehaviorReportCompleteCallbackInfo>, ISettable<SendPlayerBehaviorReportCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8627
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

	public void Set(ref SendPlayerBehaviorReportCompleteCallbackInfo other) { }

	public void Set(ref Nullable<SendPlayerBehaviorReportCompleteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out SendPlayerBehaviorReportCompleteCallbackInfo output) { }

}

