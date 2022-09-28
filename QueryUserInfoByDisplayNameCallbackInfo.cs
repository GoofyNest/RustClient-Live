public struct QueryUserInfoByDisplayNameCallbackInfo : ICallbackInfo // TypeDefIndex: 8271
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <DisplayName>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public Utf8String DisplayName { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_DisplayName() { }

	[CompilerGeneratedAttribute] 
	public void set_DisplayName(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryUserInfoByDisplayNameCallbackInfoInternal other) { }

}

