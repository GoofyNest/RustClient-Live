public struct BeginSessionOptions // TypeDefIndex: 9725
{
	[CompilerGeneratedAttribute] 
	private uint <RegisterTimeoutSeconds>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ServerName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <EnableGameplayData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 

	public uint RegisterTimeoutSeconds { get; set; }
	public Utf8String ServerName { get; set; }
	public bool EnableGameplayData { get; set; }
	public ProductUserId LocalUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public uint get_RegisterTimeoutSeconds() { }

	[CompilerGeneratedAttribute] 
	public void set_RegisterTimeoutSeconds(uint value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ServerName() { }

	[CompilerGeneratedAttribute] 
	public void set_ServerName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public bool get_EnableGameplayData() { }

	[CompilerGeneratedAttribute] 
	public void set_EnableGameplayData(bool value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

}

public struct BeginSessionOptions // TypeDefIndex: 9822
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatClientMode <Mode>k__BackingField; 

	public ProductUserId LocalUserId { get; set; }
	public AntiCheatClientMode Mode { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatClientMode get_Mode() { }

	[CompilerGeneratedAttribute] 
	public void set_Mode(AntiCheatClientMode value) { }

}

