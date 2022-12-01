public struct HardMuteMemberCallbackInfo : ICallbackInfo // TypeDefIndex: 9107
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <LobbyId>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <TargetUserId>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public Utf8String LobbyId { get; set; }
	public ProductUserId TargetUserId { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_LobbyId() { }

	[CompilerGeneratedAttribute]
	public void set_LobbyId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_TargetUserId() { }

	[CompilerGeneratedAttribute]
	public void set_TargetUserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref HardMuteMemberCallbackInfoInternal other) { }

}

