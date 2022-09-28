public struct CreateSessionModificationOptions // TypeDefIndex: 8432
{
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <BucketId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <MaxPlayers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <PresenceEnabled>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <SanctionsEnabled>k__BackingField; 

	public Utf8String SessionName { get; set; }
	public Utf8String BucketId { get; set; }
	public uint MaxPlayers { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public bool PresenceEnabled { get; set; }
	public Utf8String SessionId { get; set; }
	public bool SanctionsEnabled { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionName() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_BucketId() { }

	[CompilerGeneratedAttribute] 
	public void set_BucketId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_MaxPlayers() { }

	[CompilerGeneratedAttribute] 
	public void set_MaxPlayers(uint value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public bool get_PresenceEnabled() { }

	[CompilerGeneratedAttribute] 
	public void set_PresenceEnabled(bool value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionId() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public bool get_SanctionsEnabled() { }

	[CompilerGeneratedAttribute] 
	public void set_SanctionsEnabled(bool value) { }

}

