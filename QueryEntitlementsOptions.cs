public struct QueryEntitlementsOptions // TypeDefIndex: 9496
{
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String[] <EntitlementNames>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IncludeRedeemed>k__BackingField; 

	public EpicAccountId LocalUserId { get; set; }
	public Utf8String[] EntitlementNames { get; set; }
	public bool IncludeRedeemed { get; set; }


	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String[] get_EntitlementNames() { }

	[CompilerGeneratedAttribute] 
	public void set_EntitlementNames(Utf8String[] value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IncludeRedeemed() { }

	[CompilerGeneratedAttribute] 
	public void set_IncludeRedeemed(bool value) { }

}

