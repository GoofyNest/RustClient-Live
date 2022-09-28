internal struct CreateUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateUserCallbackInfo>, ISettable<CreateUserCallbackInfo>, IDisposable // TypeDefIndex: 9283
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_KWSUserId; 
	private int m_IsMinor; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public bool IsMinor { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_KWSUserId() { }

	public void set_KWSUserId(Utf8String value) { }

	public bool get_IsMinor() { }

	public void set_IsMinor(bool value) { }

	public void Set(ref CreateUserCallbackInfo other) { }

	public void Set(ref Nullable<CreateUserCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out CreateUserCallbackInfo output) { }

}

internal struct CreateUserCallbackInfoInternal : ICallbackInfoInternal, IGettable<CreateUserCallbackInfo>, ISettable<CreateUserCallbackInfo>, IDisposable // TypeDefIndex: 9526
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref CreateUserCallbackInfo other) { }

	public void Set(ref Nullable<CreateUserCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out CreateUserCallbackInfo output) { }

}

