public struct GetExternalAccountMappingsOptions // TypeDefIndex: 9585
{
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ExternalAccountType <AccountIdType>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <TargetExternalUserId>k__BackingField;

	public ProductUserId LocalUserId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Utf8String TargetExternalUserId { get; set; }


	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGeneratedAttribute]
	public void set_AccountIdType(ExternalAccountType value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_TargetExternalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_TargetExternalUserId(Utf8String value) { }

}

