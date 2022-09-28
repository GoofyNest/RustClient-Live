public struct LobbyInviteReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9112
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <InviteId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <TargetUserId>k__BackingField; 

	public object ClientData { get; set; }
	public Utf8String InviteId { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public ProductUserId TargetUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_InviteId() { }

	[CompilerGeneratedAttribute] 
	public void set_InviteId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LobbyInviteReceivedCallbackInfoInternal other) { }

}

