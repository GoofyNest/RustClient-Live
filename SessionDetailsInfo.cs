public struct SessionDetailsInfo // TypeDefIndex: 8548
{
	[CompilerGeneratedAttribute] 
	private Utf8String <SessionId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <HostAddress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <NumOpenPublicConnections>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<SessionDetailsSettings> <Settings>k__BackingField; 

	public Utf8String SessionId { get; set; }
	public Utf8String HostAddress { get; set; }
	public uint NumOpenPublicConnections { get; set; }
	public Nullable<SessionDetailsSettings> Settings { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_SessionId() { }

	[CompilerGeneratedAttribute] 
	public void set_SessionId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_HostAddress() { }

	[CompilerGeneratedAttribute] 
	public void set_HostAddress(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public uint get_NumOpenPublicConnections() { }

	[CompilerGeneratedAttribute] 
	public void set_NumOpenPublicConnections(uint value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<SessionDetailsSettings> get_Settings() { }

	[CompilerGeneratedAttribute] 
	public void set_Settings(Nullable<SessionDetailsSettings> value) { }

	internal void Set(ref SessionDetailsInfoInternal other) { }

}

