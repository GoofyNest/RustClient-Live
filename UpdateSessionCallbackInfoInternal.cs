internal struct UpdateSessionCallbackInfoInternal : ICallbackInfoInternal, IGettable<UpdateSessionCallbackInfo>, ISettable<UpdateSessionCallbackInfo>, IDisposable // TypeDefIndex: 8605
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_SessionName; 
	private IntPtr m_SessionId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String SessionName { get; set; }
	public Utf8String SessionId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_SessionName() { }

	public void set_SessionName(Utf8String value) { }

	public Utf8String get_SessionId() { }

	public void set_SessionId(Utf8String value) { }

	public void Set(ref UpdateSessionCallbackInfo other) { }

	public void Set(ref Nullable<UpdateSessionCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out UpdateSessionCallbackInfo output) { }

}

