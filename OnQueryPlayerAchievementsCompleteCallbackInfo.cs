public struct OnQueryPlayerAchievementsCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9937
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <UserId>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }


	[CompilerGeneratedAttribute]
	public Result get_ResultCode() { }

	[CompilerGeneratedAttribute]
	public void set_ResultCode(Result value) { }

	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_UserId() { }

	[CompilerGeneratedAttribute]
	public void set_UserId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfoInternal other) { }

}

