public struct CheckoutOptions // TypeDefIndex: 9417
{
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <OverrideCatalogNamespace>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private CheckoutEntry[] <Entries>k__BackingField; 

	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OverrideCatalogNamespace { get; set; }
	public CheckoutEntry[] Entries { get; set; }


	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_OverrideCatalogNamespace() { }

	[CompilerGeneratedAttribute] 
	public void set_OverrideCatalogNamespace(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public CheckoutEntry[] get_Entries() { }

	[CompilerGeneratedAttribute] 
	public void set_Entries(CheckoutEntry[] value) { }

}

