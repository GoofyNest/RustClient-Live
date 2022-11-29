public struct OnClientActionRequiredCallbackInfo : ICallbackInfo // TypeDefIndex: 9789
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IntPtr <ClientHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonClientAction <ClientAction>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonClientActionReason <ActionReasonCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ActionReasonDetailsString>k__BackingField; 

	public object ClientData { get; set; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAction ClientAction { get; set; }
	public AntiCheatCommonClientActionReason ActionReasonCode { get; set; }
	public Utf8String ActionReasonDetailsString { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public IntPtr get_ClientHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonClientAction get_ClientAction() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientAction(AntiCheatCommonClientAction value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonClientActionReason get_ActionReasonCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ActionReasonCode(AntiCheatCommonClientActionReason value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ActionReasonDetailsString() { }

	[CompilerGeneratedAttribute] 
	public void set_ActionReasonDetailsString(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnClientActionRequiredCallbackInfoInternal other) { }

}

