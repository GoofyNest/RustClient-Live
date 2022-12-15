internal struct OnAchievementsUnlockedCallbackV2InfoInternal : ICallbackInfoInternal, IGettable<OnAchievementsUnlockedCallbackV2Info>, ISettable<OnAchievementsUnlockedCallbackV2Info>, IDisposable // TypeDefIndex: 9930
{
	private IntPtr m_ClientData;
	private IntPtr m_UserId;
	private IntPtr m_AchievementId;
	private long m_UnlockTime;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }
	public Utf8String AchievementId { get; set; }
	public Nullable<DateTimeOffset> UnlockTime { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_UserId() { }

	public void set_UserId(ProductUserId value) { }

	public Utf8String get_AchievementId() { }

	public void set_AchievementId(Utf8String value) { }

	public Nullable<DateTimeOffset> get_UnlockTime() { }

	public void set_UnlockTime(Nullable<DateTimeOffset> value) { }

	public void Set(ref OnAchievementsUnlockedCallbackV2Info other) { }

	public void Set(ref Nullable<OnAchievementsUnlockedCallbackV2Info> other) { }

	public void Dispose() { }

	public void Get(out OnAchievementsUnlockedCallbackV2Info output) { }

}

