internal struct CopyUnlockedAchievementByAchievementIdOptionsInternal : ISettable<CopyUnlockedAchievementByAchievementIdOptions>, IDisposable // TypeDefIndex: 9908
{
	private int m_ApiVersion;
	private IntPtr m_UserId;
	private IntPtr m_AchievementId;

	public ProductUserId UserId { set; }
	public Utf8String AchievementId { set; }


	public void set_UserId(ProductUserId value) { }

	public void set_AchievementId(Utf8String value) { }

	public void Set(ref CopyUnlockedAchievementByAchievementIdOptions other) { }

	public void Set(ref Nullable<CopyUnlockedAchievementByAchievementIdOptions> other) { }

	public void Dispose() { }

}

