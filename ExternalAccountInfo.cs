public struct ExternalAccountInfo // TypeDefIndex: 9570
{
	[CompilerGeneratedAttribute] 
	private ProductUserId <ProductUserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <DisplayName>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <AccountId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ExternalAccountType <AccountIdType>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <LastLoginTime>k__BackingField; 

	public ProductUserId ProductUserId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String AccountId { get; set; }
	public ExternalAccountType AccountIdType { get; set; }
	public Nullable<DateTimeOffset> LastLoginTime { get; set; }


	[CompilerGeneratedAttribute] 
	public ProductUserId get_ProductUserId() { }

	[CompilerGeneratedAttribute] 
	public void set_ProductUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_DisplayName() { }

	[CompilerGeneratedAttribute] 
	public void set_DisplayName(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_AccountId() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public ExternalAccountType get_AccountIdType() { }

	[CompilerGeneratedAttribute] 
	public void set_AccountIdType(ExternalAccountType value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_LastLoginTime() { }

	[CompilerGeneratedAttribute] 
	public void set_LastLoginTime(Nullable<DateTimeOffset> value) { }

	internal void Set(ref ExternalAccountInfoInternal other) { }

}

