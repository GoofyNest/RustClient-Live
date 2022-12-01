internal struct QueryPermissionsCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryPermissionsCallbackInfo>, ISettable<QueryPermissionsCallbackInfo>, IDisposable // TypeDefIndex: 9359
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_KWSUserId;
	private IntPtr m_DateOfBirth;
	private int m_IsMinor;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String KWSUserId { get; set; }
	public Utf8String DateOfBirth { get; set; }
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

	public Utf8String get_DateOfBirth() { }

	public void set_DateOfBirth(Utf8String value) { }

	public bool get_IsMinor() { }

	public void set_IsMinor(bool value) { }

	public void Set(ref QueryPermissionsCallbackInfo other) { }

	public void Set(ref Nullable<QueryPermissionsCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryPermissionsCallbackInfo output) { }

}

