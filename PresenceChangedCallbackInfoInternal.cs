internal struct PresenceChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<PresenceChangedCallbackInfo>, ISettable<PresenceChangedCallbackInfo>, IDisposable // TypeDefIndex: 8846
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_PresenceUserId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public EpicAccountId LocalUserId { get; set; }
	public EpicAccountId PresenceUserId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public EpicAccountId get_LocalUserId() { }

	public void set_LocalUserId(EpicAccountId value) { }

	public EpicAccountId get_PresenceUserId() { }

	public void set_PresenceUserId(EpicAccountId value) { }

	public void Set(ref PresenceChangedCallbackInfo other) { }

	public void Set(ref Nullable<PresenceChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out PresenceChangedCallbackInfo output) { }

}

