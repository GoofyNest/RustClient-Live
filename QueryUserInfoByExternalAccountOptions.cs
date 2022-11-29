public struct QueryUserInfoByExternalAccountOptions // TypeDefIndex: 8321
{
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <ExternalAccountId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ExternalAccountType <AccountType>k__BackingField; 

	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ExternalAccountId { get; set; }
	public ExternalAccountType AccountType { get; set; }


	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_ExternalAccountId() { }

	[CompilerGeneratedAttribute] 
	public void set_ExternalAccountId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ExternalAccountType get_AccountType() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountType(ExternalAccountType value) { }

}

