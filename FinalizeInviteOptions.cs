public struct FinalizeInviteOptions // TypeDefIndex: 9484
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <CustomInviteId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Result <ProcessingResult>k__BackingField; 

	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Result ProcessingResult { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_CustomInviteId() { }

	[CompilerGeneratedAttribute] 
	public void set_CustomInviteId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Result get_ProcessingResult() { }

	[CompilerGeneratedAttribute] 
	public void set_ProcessingResult(Result value) { }

}

