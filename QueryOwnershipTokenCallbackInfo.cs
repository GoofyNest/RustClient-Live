public struct QueryOwnershipTokenCallbackInfo : ICallbackInfo // TypeDefIndex: 9510
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private EpicAccountId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <OwnershipToken>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public Utf8String OwnershipToken { get; set; }


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
	public Utf8String get_OwnershipToken() { }

	[CompilerGeneratedAttribute]
	public void set_OwnershipToken(Utf8String value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref QueryOwnershipTokenCallbackInfoInternal other) { }

}

