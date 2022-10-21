internal struct OnFriendsUpdateInfoInternal : ICallbackInfoInternal, IGettable<OnFriendsUpdateInfo>, ISettable<OnFriendsUpdateInfo>, IDisposable // TypeDefIndex: 9389
{
	private IntPtr m_ClientData; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_TargetUserId; 
	private FriendsStatus m_PreviousStatus; 
	private FriendsStatus m_CurrentStatus; 

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId TargetUserId { get; set; }
	public FriendsStatus PreviousStatus { get; set; }
	public FriendsStatus CurrentStatus { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public EpicAccountId get_TargetUserId() { }

	public void set_TargetUserId(EpicAccountId value) { }

	public FriendsStatus get_PreviousStatus() { }

	public void set_PreviousStatus(FriendsStatus value) { }

	public FriendsStatus get_CurrentStatus() { }

	public void set_CurrentStatus(FriendsStatus value) { }

	public void Set(ref OnFriendsUpdateInfo other) { }

	public void Set(ref Nullable<OnFriendsUpdateInfo> other) { }

	public void Dispose() { }

	public void Get(out OnFriendsUpdateInfo output) { }

}

