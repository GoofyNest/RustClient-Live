public struct UnregisterPlayersOptions // TypeDefIndex: 8602
{
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId[] <PlayersToUnregister>k__BackingField; 

	public Utf8String SessionName { get; set; }
	public ProductUserId[] PlayersToUnregister { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionName() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId[] get_PlayersToUnregister() { }

	[CompilerGeneratedAttribute] 
	public void set_PlayersToUnregister(ProductUserId[] value) { }

}

