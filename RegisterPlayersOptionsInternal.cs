internal struct RegisterPlayersOptionsInternal : ISettable<RegisterPlayersOptions>, IDisposable // TypeDefIndex: 8539
{
	private int m_ApiVersion;
	private IntPtr m_SessionName;
	private IntPtr m_PlayersToRegister;
	private uint m_PlayersToRegisterCount;

	public Utf8String SessionName { set; }
	public ProductUserId[] PlayersToRegister { set; }


	public void set_SessionName(Utf8String value) { }

	public void set_PlayersToRegister(ProductUserId[] value) { }

	public void Set(ref RegisterPlayersOptions other) { }

	public void Set(ref Nullable<RegisterPlayersOptions> other) { }

	public void Dispose() { }

}

