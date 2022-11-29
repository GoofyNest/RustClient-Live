internal struct InstallModOptionsInternal : ISettable<InstallModOptions>, IDisposable // TypeDefIndex: 9018
{
	private int m_ApiVersion; 
	private IntPtr m_LocalUserId; 
	private IntPtr m_Mod; 
	private int m_RemoveAfterExit; 

	public EpicAccountId LocalUserId { set; }
	public Nullable<ModIdentifier> Mod { set; }
	public bool RemoveAfterExit { set; }


	public void set_LocalUserId(EpicAccountId value) { }

	public void set_Mod(Nullable<ModIdentifier> value) { }

	public void set_RemoveAfterExit(bool value) { }

	public void Set(ref InstallModOptions other) { }

	public void Set(ref Nullable<InstallModOptions> other) { }

	public void Dispose() { }

}

