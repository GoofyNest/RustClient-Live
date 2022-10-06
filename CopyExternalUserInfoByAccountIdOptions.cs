public struct CopyExternalUserInfoByAccountIdOptions // TypeDefIndex: 8287
{
	[CompilerGeneratedAttribute] 
	private EpicAccountId <LocalUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private EpicAccountId <TargetUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <AccountId>k__BackingField; 

	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public Utf8String AccountId { get; set; }


	[CompilerGeneratedAttribute] 
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public EpicAccountId get_TargetUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_TargetUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_AccountId() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountId(Utf8String value) { }

}

