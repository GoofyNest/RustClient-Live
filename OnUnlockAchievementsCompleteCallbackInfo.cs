public struct OnUnlockAchievementsCompleteCallbackInfo : ICallbackInfo // TypeDefIndex: 9941
{
	[CompilerGeneratedAttribute]
	private Result <ResultCode>k__BackingField;
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <UserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <AchievementsCount>k__BackingField;

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }
	public uint AchievementsCount { get; set; }


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

	[CompilerGeneratedAttribute]
	public uint get_AchievementsCount() { }

	[CompilerGeneratedAttribute]
	public void set_AchievementsCount(uint value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnUnlockAchievementsCompleteCallbackInfoInternal other) { }

}

