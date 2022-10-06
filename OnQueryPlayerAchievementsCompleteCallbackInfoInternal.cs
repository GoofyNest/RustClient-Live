internal struct OnQueryPlayerAchievementsCompleteCallbackInfoInternal : ICallbackInfoInternal, IGettable<OnQueryPlayerAchievementsCompleteCallbackInfo>, ISettable<OnQueryPlayerAchievementsCompleteCallbackInfo>, IDisposable // TypeDefIndex: 9924
{
	private Result m_ResultCode; 
	private IntPtr m_ClientData; 
	private IntPtr m_UserId; 

	public Result ResultCode { get; set; }
	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId UserId { get; set; }


	public Result get_ResultCode() { }

	public void set_ResultCode(Result value) { }

	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_UserId() { }

	public void set_UserId(ProductUserId value) { }

	public void Set(ref OnQueryPlayerAchievementsCompleteCallbackInfo other) { }

	public void Set(ref Nullable<OnQueryPlayerAchievementsCompleteCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out OnQueryPlayerAchievementsCompleteCallbackInfo output) { }

}

