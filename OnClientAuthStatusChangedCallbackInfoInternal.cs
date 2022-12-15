internal struct OnClientAuthStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientAuthStatusChangedCallbackInfo>, ISettable<OnClientAuthStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 9796
{
	private IntPtr m_ClientData;
	private IntPtr m_ClientHandle;
	private AntiCheatCommonClientAuthStatus m_ClientAuthStatus;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAuthStatus ClientAuthStatus { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public IntPtr get_ClientHandle() { }

	public void set_ClientHandle(IntPtr value) { }

	public AntiCheatCommonClientAuthStatus get_ClientAuthStatus() { }

	public void set_ClientAuthStatus(AntiCheatCommonClientAuthStatus value) { }

	public void Set(ref OnClientAuthStatusChangedCallbackInfo other) { }

	public void Set(ref Nullable<OnClientAuthStatusChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnClientAuthStatusChangedCallbackInfo output) { }

}

