internal struct CopyPlayerAchievementByIndexOptionsInternal : ISettable<CopyPlayerAchievementByIndexOptions>, IDisposable // TypeDefIndex: 9894
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private uint m_AchievementIndex; 
	private IntPtr m_LocalUserId; 

	public ProductUserId TargetUserId { set; }
	public uint AchievementIndex { set; }
	public ProductUserId LocalUserId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_AchievementIndex(uint value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref CopyPlayerAchievementByIndexOptions other) { }

	public void Set(ref Nullable<CopyPlayerAchievementByIndexOptions> other) { }

	public void Dispose() { }

}

