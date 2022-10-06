public struct RegisterPeerOptions // TypeDefIndex: 9840
{
	[CompilerGeneratedAttribute] 
	private IntPtr <PeerHandle>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonClientType <ClientType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private AntiCheatCommonClientPlatform <ClientPlatform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private uint <AuthenticationTimeout>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <AccountId_DEPRECATED>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <IpAddress>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <PeerProductUserId>k__BackingField; 

	public IntPtr PeerHandle { get; set; }
	public AntiCheatCommonClientType ClientType { get; set; }
	public AntiCheatCommonClientPlatform ClientPlatform { get; set; }
	public uint AuthenticationTimeout { get; set; }
	public Utf8String AccountId_DEPRECATED { get; set; }
	public Utf8String IpAddress { get; set; }
	public ProductUserId PeerProductUserId { get; set; }


	[CompilerGeneratedAttribute] 
	public IntPtr get_PeerHandle() { }

	[CompilerGeneratedAttribute] 
	public void set_PeerHandle(IntPtr value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonClientType get_ClientType() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientType(AntiCheatCommonClientType value) { }

	[CompilerGeneratedAttribute] 
	public AntiCheatCommonClientPlatform get_ClientPlatform() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientPlatform(AntiCheatCommonClientPlatform value) { }

	[CompilerGeneratedAttribute] 
	public uint get_AuthenticationTimeout() { }

	[CompilerGeneratedAttribute] 
	public void set_AuthenticationTimeout(uint value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_AccountId_DEPRECATED() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountId_DEPRECATED(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_IpAddress() { }

	[CompilerGeneratedAttribute] 
	public void set_IpAddress(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_PeerProductUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_PeerProductUserId(ProductUserId value) { }

}

