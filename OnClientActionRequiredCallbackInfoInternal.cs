internal struct OnClientActionRequiredCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientActionRequiredCallbackInfo>, ISettable<OnClientActionRequiredCallbackInfo>, IDisposable // TypeDefIndex: 9794
{
	private IntPtr m_ClientData;
	private IntPtr m_ClientHandle;
	private AntiCheatCommonClientAction m_ClientAction;
	private AntiCheatCommonClientActionReason m_ActionReasonCode;
	private IntPtr m_ActionReasonDetailsString;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAction ClientAction { get; set; }
	public AntiCheatCommonClientActionReason ActionReasonCode { get; set; }
	public Utf8String ActionReasonDetailsString { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public IntPtr get_ClientHandle() { }

	public void set_ClientHandle(IntPtr value) { }

	public AntiCheatCommonClientAction get_ClientAction() { }

	public void set_ClientAction(AntiCheatCommonClientAction value) { }

	public AntiCheatCommonClientActionReason get_ActionReasonCode() { }

	public void set_ActionReasonCode(AntiCheatCommonClientActionReason value) { }

	public Utf8String get_ActionReasonDetailsString() { }

	public void set_ActionReasonDetailsString(Utf8String value) { }

	public void Set(ref OnClientActionRequiredCallbackInfo other) { }

	public void Set(ref Nullable<OnClientActionRequiredCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnClientActionRequiredCallbackInfo output) { }

}

