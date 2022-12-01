public struct UninstallModCallbackInfo : ICallbackInfo // TypeDefIndex: 9035
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private EpicAccountId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<ModIdentifier> <Mod>k__BackingField;

	public Result ResultCode { get; set; }
	public EpicAccountId LocalUserId { get; set; }
	public object ClientData { get; set; }
	public Nullable<ModIdentifier> Mod { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public EpicAccountId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(EpicAccountId value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public Nullable<ModIdentifier> get_Mod() { }

	[CompilerGeneratedAttribute]
	public void set_Mod(Nullable<ModIdentifier> value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref UninstallModCallbackInfoInternal other) { }

}

