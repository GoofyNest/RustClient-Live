internal struct HideFriendsCallbackInfoInternal : ICallbackInfoInternal, IGettable<HideFriendsCallbackInfo>, ISettable<HideFriendsCallbackInfo>, IDisposable // TypeDefIndex: 8343
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public void Set(ref HideFriendsCallbackInfo other) { }

	public void Set(ref Nullable<HideFriendsCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out HideFriendsCallbackInfo output) { }

}

