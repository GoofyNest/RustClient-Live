public struct ExternalUserInfo // TypeDefIndex: 8309
{
	[CompilerGeneratedAttribute]
	private ExternalAccountType <AccountType>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <AccountId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <DisplayName>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <DisplayNameSanitized>k__BackingField;

	public ExternalAccountType AccountType { get; set; }
	public Utf8String AccountId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String DisplayNameSanitized { get; set; }


	[CompilerGeneratedAttribute]
	public ExternalAccountType get_AccountType() { }

	[CompilerGeneratedAttribute]
	public void set_AccountType(ExternalAccountType value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_AccountId() { }

	[CompilerGeneratedAttribute]
	public void set_AccountId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_DisplayName() { }

	[CompilerGeneratedAttribute]
	public void set_DisplayName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_DisplayNameSanitized() { }

	[CompilerGeneratedAttribute]
	public void set_DisplayNameSanitized(Utf8String value) { }

	internal void Set(ref ExternalUserInfoInternal other) { }

}

