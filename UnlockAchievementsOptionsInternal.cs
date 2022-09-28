internal struct UnlockAchievementsOptionsInternal : ISettable<UnlockAchievementsOptions>, IDisposable // TypeDefIndex: 9906
{
	private int m_ApiVersion; 
	private IntPtr m_UserId; 
	private IntPtr m_AchievementIds; 
	private uint m_AchievementsCount; 

	public ProductUserId UserId { set; }
	public Utf8String[] AchievementIds { set; }


	public void set_UserId(ProductUserId value) { }

	public void set_AchievementIds(Utf8String[] value) { }

	public void Set(ref UnlockAchievementsOptions other) { }

	public void Set(ref Nullable<UnlockAchievementsOptions> other) { }

	public void Dispose() { }

}

