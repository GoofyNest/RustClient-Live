public struct ActiveSessionInfo // TypeDefIndex: 8412
{
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private OnlineSessionState <State>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<SessionDetailsInfo> <SessionDetails>k__BackingField; 

	public Utf8String SessionName { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public OnlineSessionState State { get; set; }
	public Nullable<SessionDetailsInfo> SessionDetails { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionName() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public OnlineSessionState get_State() { }

	[CompilerGeneratedAttribute] 
	public void set_State(OnlineSessionState value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<SessionDetailsInfo> get_SessionDetails() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionDetails(Nullable<SessionDetailsInfo> value) { }

	internal void Set(ref ActiveSessionInfoInternal other) { }

}

