public struct QueryActivePlayerSanctionsCallbackInfo : ICallbackInfo // TypeDefIndex: 8618
{
	[CompilerGeneratedAttribute] 
	private Result <ResultCode>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute] 
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryActivePlayerSanctionsCallbackInfoInternal other) { }

}

