internal struct SubmitSnapshotCallbackInfoInternal : ICallbackInfoInternal, IGettable<SubmitSnapshotCallbackInfo>, ISettable<SubmitSnapshotCallbackInfo>, IDisposable // TypeDefIndex: 8818
{
	private Result m_ResultCode;
	private uint m_SnapshotId;
	private IntPtr m_ClientData;

	public Result ResultCode { get; set; }
	public uint SnapshotId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public uint get_SnapshotId() { }

	public void set_SnapshotId(uint value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public void Set(ref SubmitSnapshotCallbackInfo other) { }

	public void Set(ref Nullable<SubmitSnapshotCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out SubmitSnapshotCallbackInfo output) { }

}

