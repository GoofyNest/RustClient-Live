internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 9598
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private LoginStatus m_PreviousStatus; 
	private LoginStatus m_CurrentStatus; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public LoginStatus PreviousStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public LoginStatus get_PreviousStatus() { }

	public void set_PreviousStatus(LoginStatus value) { }

	public LoginStatus get_CurrentStatus() { }

	public void set_CurrentStatus(LoginStatus value) { }

	public void Set(ref LoginStatusChangedCallbackInfo other) { }

	public void Set(ref Nullable<LoginStatusChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LoginStatusChangedCallbackInfo output) { }

}

internal struct LoginStatusChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<LoginStatusChangedCallbackInfo>, ISettable<LoginStatusChangedCallbackInfo>, IDisposable // TypeDefIndex: 9675
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private LoginStatus m_PrevStatus; 
	private LoginStatus m_CurrentStatus; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public LoginStatus PrevStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public LoginStatus get_PrevStatus() { }

	public void set_PrevStatus(LoginStatus value) { }

	public LoginStatus get_CurrentStatus() { }

	public void set_CurrentStatus(LoginStatus value) { }

	public void Set(ref LoginStatusChangedCallbackInfo other) { }

	public void Set(ref Nullable<LoginStatusChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out LoginStatusChangedCallbackInfo output) { }

}

