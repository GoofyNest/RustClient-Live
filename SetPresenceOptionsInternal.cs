internal struct SetPresenceOptionsInternal : ISettable<SetPresenceOptions>, IDisposable // TypeDefIndex: 8870
{
	private int m_ApiVersion;
	private IntPtr m_LocalUserId;
	private IntPtr m_PresenceModificationHandle;

	public EpicAccountId LocalUserId { set; }
	public PresenceModification PresenceModificationHandle { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_PresenceModificationHandle(PresenceModification value) { }

	public void Set(ref SetPresenceOptions other) { }

	public void Set(ref Nullable<SetPresenceOptions> other) { }

	public void Dispose() { }

}

