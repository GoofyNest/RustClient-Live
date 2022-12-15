internal struct KickCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<KickCompleteCallbackInfo>, ISettable<KickCompleteCallbackInfo>, IDisposable // TypeDefIndex: 8743
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

	public void Set(ref KickCompleteCallbackInfo other) { }

	public void Set(ref Nullable<KickCompleteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out KickCompleteCallbackInfo output) { }

}

