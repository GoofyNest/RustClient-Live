internal struct UnlockedAchievementInternal : IGettable<UnlockedAchievement>, ISettable<UnlockedAchievement>, IDisposable // TypeDefIndex: 9942
{
	private int m_ApiVersion; 
	private IntPtr m_AchievementId; 
	private long m_UnlockTime; 

	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }


	public Utf8String get_AchievementId() { }

	public void set_AchievementId(Utf8String value) { }

	public Nullable<DateTimeOffset> get_UnlockTime() { }

	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	public void Set(ref UnlockedAchievement other) { }

	public void Set(ref Nullable<UnlockedAchievement> other) { }

	public void Dispose() { }

	public void Get(out UnlockedAchievement output) { }

}

