internal struct OnAchievementsUnlockedCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnAchievementsUnlockedCallbackInfo>, ISettable<OnAchievementsUnlockedCallbackInfo>, IDisposable // TypeDefIndex: 9926
{
	private IntPtr m_ClientData;
	private IntPtr m_UserId;
	private uint m_AchievementsCount;
	private IntPtr m_AchievementIds;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }
	public Utf8String[] AchievementIds { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_UserId() { }

	public void set_UserId(ProductUserId value) { }

	public Utf8String[] get_AchievementIds() { }

	public void set_AchievementIds(Utf8String[] value) { }

	public void Set(ref OnAchievementsUnlockedCallbackInfo other) { }

	public void Set(ref Nullable<OnAchievementsUnlockedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnAchievementsUnlockedCallbackInfo output) { }

}

