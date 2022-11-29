public struct SendAudioOptions // TypeDefIndex: 8706
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <RoomName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<AudioBuffer> <Buffer>k__BackingField; 

	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute] 
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<AudioBuffer> get_Buffer() { }

	[CompilerGeneratedAttribute] 
	public void set_Buffer(Nullable<AudioBuffer> value) { }

}

