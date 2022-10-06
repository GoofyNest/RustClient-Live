internal struct CopyUnlockedAchievementByIndexOptionsInternal : ISettable<CopyUnlockedAchievementByIndexOptions>, IDisposable // TypeDefIndex: 9898
{
	private int m_ApiVersion; 
	private IntPtr m_UserId; 
	private uint m_AchievementIndex; 

	public ProductUserId UserId { set; }
	public uint AchievementIndex { set; }


	public void set_UserId(ProductUserId value) { }

	public void set_AchievementIndex(uint value) { }

	public void Set(ref CopyUnlockedAchievementByIndexOptions other) { }

	public void Set(ref Nullable<CopyUnlockedAchievementByIndexOptions> other) { }

	public void Dispose() { }

}

