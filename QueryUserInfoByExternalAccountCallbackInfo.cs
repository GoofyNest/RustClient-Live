public struct QueryUserInfoByExternalAccountCallbackInfo : ICallbackInfo // TypeDefIndex: 8323
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private EpicAccountId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <ExternalAccountId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ExternalAccountType <AccountType>k__BackingField;
	[CompilerGeneratedAttribute]
	private EpicAccountId <TargetUserId>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String ExternalAccountId { get; set; }
	public ExternalAccountType AccountType { get; set; }
	public EpicAccountId TargetUserId { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

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

	[CompilerGeneratedAttribute]
	public EpicAccountId get_TargetUserId() { }

	[CompilerGeneratedAttribute]
	public void set_TargetUserId(EpicAccountId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryUserInfoByExternalAccountCallbackInfoInternal other) { }

}

