internal struct CopyPlayerAchievementByAchievementIdOptionsInternal : ISettable<CopyPlayerAchievementByAchievementIdOptions>, IDisposable // TypeDefIndex: 9906
{
	private int m_ApiVersion;
	private IntPtr m_TargetUserId;
	private IntPtr m_AchievementId;
	private IntPtr m_LocalUserId;

	public ProductUserId TargetUserId { set; }
	public Utf8String AchievementId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_AchievementId(Utf8String value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref CopyPlayerAchievementByAchievementIdOptions other) { }

	public void Set(ref Nullable<CopyPlayerAchievementByAchievementIdOptions> other) { }

	public void Dispose() { }

}

