public struct OnAchievementsUnlockedCallbackV2Info : ICallbackInfo // TypeDefIndex: 9925
{
	[CompilerGeneratedAttribute] 
	private object <ClientData>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private ProductUserId <UserId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Utf8String <AchievementId>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Nullable<DateTimeOffset> <UnlockTime>k__BackingField; 

	public object ClientData { get; set; }
	public ProductUserId UserId { get; set; }
	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }


	[CompilerGeneratedAttribute] 
	public object get_ClientData() { }

	[CompilerGeneratedAttribute] 
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute] 
	public ProductUserId get_UserId() { }

	[CompilerGeneratedAttribute] 
	public void set_UserId(ProductUserId value) { }

	[CompilerGeneratedAttribute] 
	public Utf8String get_AchievementId() { }

	[CompilerGeneratedAttribute] 
	public void set_AchievementId(Utf8String value) { }

	[CompilerGeneratedAttribute] 
	public Nullable<DateTimeOffset> get_UnlockTime() { }

	[CompilerGeneratedAttribute] 
	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref OnAchievementsUnlockedCallbackV2InfoInternal other) { }

}

