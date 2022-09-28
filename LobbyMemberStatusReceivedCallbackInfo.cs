public struct LobbyMemberStatusReceivedCallbackInfo : ICallbackInfo // TypeDefIndex: 9117
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <LobbyId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private LobbyMemberStatus <CurrentStatus>k__BackingField; 

	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }
	public LobbyMemberStatus CurrentStatus { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute] 
	public void set_LobbyId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public LobbyMemberStatus get_CurrentStatus() { }

	[CompilerGeneratedAttribute] 
	public void set_CurrentStatus(LobbyMemberStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref LobbyMemberStatusReceivedCallbackInfoInternal other) { }

}

