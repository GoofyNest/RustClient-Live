internal struct OnClientIntegrityViolatedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnClientIntegrityViolatedCallbackInfo>, ISettable<OnClientIntegrityViolatedCallbackInfo>, IDisposable // TypeDefIndex: 9787
{
	private IntPtr m_ClientData; 
	private AntiCheatClientViolationType m_ViolationType; 
	private IntPtr m_ViolationMessage; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public AntiCheatClientViolationType ViolationType { get; set; }
	public Utf8String ViolationMessage { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public AntiCheatClientViolationType get_ViolationType() { }

	public void set_ViolationType(AntiCheatClientViolationType value) { }

	public Utf8String get_ViolationMessage() { }

	public void set_ViolationMessage(Utf8String value) { }

	public void Set(ref OnClientIntegrityViolatedCallbackInfo other) { }

	public void Set(ref Nullable<OnClientIntegrityViolatedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnClientIntegrityViolatedCallbackInfo output) { }

}

