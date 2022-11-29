internal struct PromoteMemberCallbackInfoInternal : ICallbackInfoInternal, IGettable<PromoteMemberCallbackInfo>, ISettable<PromoteMemberCallbackInfo>, IDisposable // TypeDefIndex: 9251
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_LobbyId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Utf8String LobbyId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Utf8String get_LobbyId() { }

	public void set_LobbyId(Utf8String value) { }

	public void Set(ref PromoteMemberCallbackInfo other) { }

	public void Set(ref Nullable<PromoteMemberCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out PromoteMemberCallbackInfo output) { }

}

