internal struct HardMuteMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<HardMuteMemberCallbackInfo>, ISettable<HardMuteMemberCallbackInfo>, IDisposable // TypeDefIndex: 9110
{
	private Result m_ResultCode;
	private IntPtr m_ClientData;
	private IntPtr m_LobbyId;
	private IntPtr m_TargetUserId;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public ProductUserId get_TargetUserId() { }

	public void set_TargetUserId(ProductUserId value) { }

	public void Set(ref HardMuteMemberCallbackInfo other) { }

	public void Set(ref Nullable<HardMuteMemberCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out HardMuteMemberCallbackInfo output) { }

}

