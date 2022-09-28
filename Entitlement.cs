public struct Entitlement // TypeDefIndex: 9413
{
	[CompilerGeneratedAttribute] 
	private Utf8String <EntitlementName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <EntitlementId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <CatalogItemId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ServerIndex>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <Redeemed>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private long <EndTimestamp>k__BackingField; 

	public Utf8String EntitlementName { get; set; }
	public Utf8String EntitlementId { get; set; }
	public Utf8String CatalogItemId { get; set; }
	public int ServerIndex { get; set; }
	public bool Redeemed { get; set; }
	public long EndTimestamp { get; set; }


	[CompilerGeneratedAttribute] 
	public Utf8String get_EntitlementName() { }

	[CompilerGeneratedAttribute] 
	public void set_EntitlementName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_EntitlementId() { }

	[CompilerGeneratedAttribute] 
	public void set_EntitlementId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_CatalogItemId() { }

	[CompilerGeneratedAttribute] 
	public void set_CatalogItemId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public int get_ServerIndex() { }

	[CompilerGeneratedAttribute] 
	public void set_ServerIndex(int value) { }

	[CompilerGeneratedAttribute] 
	public bool get_Redeemed() { }

	[CompilerGeneratedAttribute] 
	public void set_Redeemed(bool value) { }

	[CompilerGeneratedAttribute] 
	public long get_EndTimestamp() { }

	[CompilerGeneratedAttribute] 
	public void set_EndTimestamp(long value) { }

	internal void Set(ref EntitlementInternal other) { }

}

