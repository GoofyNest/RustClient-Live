public struct BlockParticipantOptions // TypeDefIndex: 8765
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <RoomName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <ParticipantId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Blocked>k__BackingField; 

	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public ProductUserId ParticipantId { get; set; }
	public bool Blocked { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute] 
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_ParticipantId() { }

	[CompilerGeneratedAttribute] 
	public void set_ParticipantId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Blocked() { }

	[CompilerGeneratedAttribute] 
	public void set_Blocked(bool value) { }

}

