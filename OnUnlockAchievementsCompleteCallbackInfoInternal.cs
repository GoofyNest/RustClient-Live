internal struct OnUnlockAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnUnlockAchievementsCompleteCallbackInfo>, ISettable<OnUnlockAchievementsCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9938
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_UserId; 
	private uint m_AchievementsCount; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }
	public uint AchievementsCount { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_UserId() { }

	public void set_UserId(ProductUserId value) { }

	public uint get_AchievementsCount() { }

	public void set_AchievementsCount(uint value) { }

	public void Set(ref OnUnlockAchievementsCompleteCallbackInfo other) { }

	public void Set(ref Nullable<OnUnlockAchievementsCompleteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnUnlockAchievementsCompleteCallbackInfo output) { }

}

