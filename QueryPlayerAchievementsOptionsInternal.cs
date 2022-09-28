internal struct QueryPlayerAchievementsOptionsInternal : ISettable<QueryPlayerAchievementsOptions>, IDisposable // TypeDefIndex: 9902
{
	private int m_ApiVersion; 
	private IntPtr m_TargetUserId; 
	private IntPtr m_LocalUserId; 

	public ProductUserId TargetUserId { set; }
	public ProductUserId LocalUserId { set; }


	public void set_TargetUserId(ProductUserId value) { }

	public void set_LocalUserId(ProductUserId value) { }

	public void Set(ref QueryPlayerAchievementsOptions other) { }

	public void Set(ref Nullable<QueryPlayerAchievementsOptions> other) { }

	public void Dispose() { }

}

