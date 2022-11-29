internal struct DefinitionInternal : IGettable<Definition>, ISettable<Definition>, IDisposable // TypeDefIndex: 9289
{
	private int m_ApiVersion; 
	private IntPtr m_LeaderboardId; 
	private IntPtr m_StatName; 
	private LeaderboardAggregation m_Aggregation; 
	private long m_StartTime; 
	private long m_EndTime; 

	public Utf8String LeaderboardId { get; set; }
	public Utf8String StatName { get; set; }
	public LeaderboardAggregation Aggregation { get; set; }
	public Nullable<DateTimeOffset> StartTime { get; set; }
	public Nullable<DateTimeOffset> EndTime { get; set; }


	public Utf8String get_LeaderboardId() { }

	public void set_LeaderboardId(Utf8String value) { }

	public Utf8String get_StatName() { }

	public void set_StatName(Utf8String value) { }

	public LeaderboardAggregation get_Aggregation() { }

	public void set_Aggregation(LeaderboardAggregation value) { }

	public Nullable<DateTimeOffset> get_StartTime() { }

	public void set_StartTime(Nullable<DateTimeOffset> value) { }

	public Nullable<DateTimeOffset> get_EndTime() { }

	public void set_EndTime(Nullable<DateTimeOffset> value) { }

	public void Set(ref Definition other) { }

	public void Set(ref Nullable<Definition> other) { }

	public void Dispose() { }

	public void Get(out Definition output) { }

}

internal struct DefinitionInternal : IGettable<Definition>, ISettable<Definition>, IDisposable // TypeDefIndex: 9910
{
	private int m_ApiVersion; 
	private IntPtr m_AchievementId; 
	private IntPtr m_DisplayName; 
	private IntPtr m_Description; 
	private IntPtr m_LockedDisplayName; 
	private IntPtr m_LockedDescription; 
	private IntPtr m_HiddenDescription; 
	private IntPtr m_CompletionDescription; 
	private IntPtr m_UnlockedIconId; 
	private IntPtr m_LockedIconId; 
	private int m_IsHidden; 
	private int m_StatThresholdsCount; 
	private IntPtr m_StatThresholds; 

	public Utf8String AchievementId { get; set; }
	public Utf8String DisplayName { get; set; }
	public Utf8String Description { get; set; }
	public Utf8String LockedDisplayName { get; set; }
	public Utf8String LockedDescription { get; set; }
	public Utf8String HiddenDescription { get; set; }
	public Utf8String CompletionDescription { get; set; }
	public Utf8String UnlockedIconId { get; set; }
	public Utf8String LockedIconId { get; set; }
	public bool IsHidden { get; set; }
	public StatThresholds[] StatThresholds { get; set; }


	public Utf8String get_AchievementId() { }

	public void set_AchievementId(Utf8String value) { }

	public Utf8String get_DisplayName() { }

	public void set_DisplayName(Utf8String value) { }

	public Utf8String get_Description() { }

	public void set_Description(Utf8String value) { }

	public Utf8String get_LockedDisplayName() { }

	public void set_LockedDisplayName(Utf8String value) { }

	public Utf8String get_LockedDescription() { }

	public void set_LockedDescription(Utf8String value) { }

	public Utf8String get_HiddenDescription() { }

	public void set_HiddenDescription(Utf8String value) { }

	public Utf8String get_CompletionDescription() { }

	public void set_CompletionDescription(Utf8String value) { }

	public Utf8String get_UnlockedIconId() { }

	public void set_UnlockedIconId(Utf8String value) { }

	public Utf8String get_LockedIconId() { }

	public void set_LockedIconId(Utf8String value) { }

	public bool get_IsHidden() { }

	public void set_IsHidden(bool value) { }

	public StatThresholds[] get_StatThresholds() { }

	public void set_StatThresholds(StatThresholds[] value) { }

	public void Set(ref Definition other) { }

	public void Set(ref Nullable<Definition> other) { }

	public void Dispose() { }

	public void Get(out Definition output) { }

}

