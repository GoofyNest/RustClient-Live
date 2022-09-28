public struct OnClientAuthStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9747
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private IntPtr <ClientHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonClientAuthStatus <ClientAuthStatus>k__BackingField; 

	public object ClientData { get; set; }
	public IntPtr ClientHandle { get; set; }
	public AntiCheatCommonClientAuthStatus ClientAuthStatus { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public IntPtr get_ClientHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonClientAuthStatus get_ClientAuthStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientAuthStatus(AntiCheatCommonClientAuthStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnClientAuthStatusChangedCallbackInfoInternal other) { }

}

