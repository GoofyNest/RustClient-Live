internal struct UninstallModCallbackInfoInternal : ICallbackInfoInternal, IGettable<UninstallModCallbackInfo>, ISettable<UninstallModCallbackInfo>, IDisposable // TypeDefIndex: 9025
{
	private Result m_ResultCode; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_ClientData; 
	private IntPtr m_Mod; 

	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public Nullable<ModIdentifier> Mod { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public Nullable<ModIdentifier> get_Mod() { }

	public void set_Mod(Nullable<ModIdentifier> value) { }

	public void Set(ref UninstallModCallbackInfo other) { }

	public void Set(ref Nullable<UninstallModCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out UninstallModCallbackInfo output) { }

}

