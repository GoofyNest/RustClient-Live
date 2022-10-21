internal struct ReadFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileCallbackInfo>, ISettable<ReadFileCallbackInfo>, IDisposable // TypeDefIndex: 8409
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public void Set(ref ReadFileCallbackInfo other) { }

	public void Set(ref Nullable<ReadFileCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out ReadFileCallbackInfo output) { }

}

internal struct ReadFileCallbackInfoInternal : ICallbackInfoInternal, IGettable<ReadFileCallbackInfo>, ISettable<ReadFileCallbackInfo>, IDisposable // TypeDefIndex: 8912
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Filename; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String Filename { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_Filename() { }

	public void set_Filename(Utf8String value) { }

	public void Set(ref ReadFileCallbackInfo other) { }

	public void Set(ref Nullable<ReadFileCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out ReadFileCallbackInfo output) { }

}

