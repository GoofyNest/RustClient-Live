internal struct QueryDefinitionsOptionsInternal : ISettable<QueryDefinitionsOptions>, IDisposable // TypeDefIndex: 9948
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_EpicUserId_DEPRECATED;
	private IntPtr m_HiddenAchievementIds_DEPRECATED;
	private uint m_HiddenAchievementsCount_DEPRECATED;

	public ProductUserId LocalUserId { set; }
	public EpicAccountId EpicUserId_DEPRECATED { set; }
	public Utf8String[] HiddenAchievementIds_DEPRECATED { set; }


	public void set_LocalUserId(ProductUserId value) { }

	public void set_EpicUserId_DEPRECATED(EpicAccountId value) { }

	public void set_HiddenAchievementIds_DEPRECATED(Utf8String[] value) { }

	public void Set(ref QueryDefinitionsOptions other) { }

	public void Set(ref Nullable<QueryDefinitionsOptions> other) { }

	public void Dispose() { }

}

