public struct OnAchievementsUnlockedCallbackInfo : ICallbackInfo // TypeDefIndex: 9911
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <UserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String[] <AchievementIds>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }
	public Utf8String[] AchievementIds { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_UserId() { }

	[CompilerGeneratedAttribute] 
	public void set_UserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String[] get_AchievementIds() { }

	[CompilerGeneratedAttribute] 
	public void set_AchievementIds(Utf8String[] value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnAchievementsUnlockedCallbackInfoInternal other) { }

}

