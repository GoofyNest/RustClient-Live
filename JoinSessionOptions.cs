public struct JoinSessionOptions // TypeDefIndex: 8456
{
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private SessionDetails <SessionHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <PresenceEnabled>k__BackingField; 

	public Utf8String SessionName { get; set; }
	public SessionDetails SessionHandle { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool PresenceEnabled { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionName() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public SessionDetails get_SessionHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionHandle(SessionDetails value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public bool get_PresenceEnabled() { }

	[CompilerGeneratedAttribute] 
	public void set_PresenceEnabled(bool value) { }

}

