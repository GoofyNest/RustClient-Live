internal struct LobbySearchFindCallbackInfoInternal : ICallbackInfoInternal, IGettable<LobbySearchFindCallbackInfo>, ISettable<LobbySearchFindCallbackInfo>, IDisposable // TypeDefIndex: 9187
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public void Set(ref LobbySearchFindCallbackInfo other) { }

	public void Set(ref Nullable<LobbySearchFindCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LobbySearchFindCallbackInfo output) { }

}

