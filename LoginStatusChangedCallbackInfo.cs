public struct LoginStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9587
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LoginStatus <PreviousStatus>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LoginStatus <CurrentStatus>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public LoginStatus PreviousStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public LoginStatus get_PreviousStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_PreviousStatus(LoginStatus value) { }

	[CompilerGeneratedAttribute] 
	public LoginStatus get_CurrentStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_CurrentStatus(LoginStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LoginStatusChangedCallbackInfoInternal other) { }

}

public struct LoginStatusChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 9664
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LoginStatus <PrevStatus>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LoginStatus <CurrentStatus>k__BackingField; 

	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public LoginStatus PrevStatus { get; set; }
	public LoginStatus CurrentStatus { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public LoginStatus get_PrevStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_PrevStatus(LoginStatus value) { }

	[CompilerGeneratedAttribute] 
	public LoginStatus get_CurrentStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_CurrentStatus(LoginStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LoginStatusChangedCallbackInfoInternal other) { }

}

