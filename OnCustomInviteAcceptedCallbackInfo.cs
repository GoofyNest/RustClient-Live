public struct OnCustomInviteAcceptedCallbackInfo : ICallbackInfo // TypeDefIndex: 9523
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <CustomInviteId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <Payload>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String CustomInviteId { get; set; }
	public Utf8String Payload { get; set; }


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

	[CompilerGeneratedAttribute] 
	public Utf8String get_CustomInviteId() { }

	[CompilerGeneratedAttribute] 
	public void set_CustomInviteId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_Payload() { }

	[CompilerGeneratedAttribute] 
	public void set_Payload(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnCustomInviteAcceptedCallbackInfoInternal other) { }

}

