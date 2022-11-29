public struct OnClientIntegrityViolatedCallbackInfo : ICallbackInfo // TypeDefIndex: 9830
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatClientViolationType <ViolationType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ViolationMessage>k__BackingField; 

	public object ClientData { get; set; }
	public AntiCheatClientViolationType ViolationType { get; set; }
	public Utf8String ViolationMessage { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatClientViolationType get_ViolationType() { }

	[CompilerGeneratedAttribute] 
	public void set_ViolationType(AntiCheatClientViolationType value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ViolationMessage() { }

	[CompilerGeneratedAttribute] 
	public void set_ViolationMessage(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnClientIntegrityViolatedCallbackInfoInternal other) { }

}

