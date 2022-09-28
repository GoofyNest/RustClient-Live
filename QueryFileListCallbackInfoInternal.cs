internal struct QueryFileListCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileListCallbackInfo>, ISettable<QueryFileListCallbackInfo>, IDisposable // TypeDefIndex: 8368
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private uint m_FileCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public uint FileCount { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public uint get_FileCount() { }

	public void set_FileCount(uint value) { }

	public void Set(ref QueryFileListCallbackInfo other) { }

	public void Set(ref Nullable<QueryFileListCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryFileListCallbackInfo output) { }

}

internal struct QueryFileListCallbackInfoInternal : ICallbackInfoInternal, IGettable<QueryFileListCallbackInfo>, ISettable<QueryFileListCallbackInfo>, IDisposable // TypeDefIndex: 8871
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private uint m_FileCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public uint FileCount { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public uint get_FileCount() { }

	public void set_FileCount(uint value) { }

	public void Set(ref QueryFileListCallbackInfo other) { }

	public void Set(ref Nullable<QueryFileListCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out QueryFileListCallbackInfo output) { }

}

