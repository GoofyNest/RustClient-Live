internal struct DeleteSnapshotCallbackInfoInternal : ICallbackInfoInternal, IGettable<DeleteSnapshotCallbackInfo>, ISettable<DeleteSnapshotCallbackInfo>, IDisposable // TypeDefIndex: 8805
{
	private Result m_ResultCode;
	private IntPtr m_LocalUserId;
	private IntPtr m_ClientData;

	public Result ResultCode { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public void Set(ref DeleteSnapshotCallbackInfo other) { }

	public void Set(ref Nullable<DeleteSnapshotCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out DeleteSnapshotCallbackInfo output) { }

}

