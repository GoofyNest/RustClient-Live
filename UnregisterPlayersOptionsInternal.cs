internal struct UnregisterPlayersOptionsInternal : ISettable<UnregisterPlayersOptions>, IDisposable // TypeDefIndex: 8603
{
	private int m_ApiVersion; 
	private IntPtr m_SessionName; 
	private IntPtr m_PlayersToUnregister; 
	private uint m_PlayersToUnregisterCount; 

	public Utf8String SessionName { set; }
	public ProductUserId[] PlayersToUnregister { set; }


	public void set_SessionName(Utf8String value) { }

	public void set_PlayersToUnregister(ProductUserId[] value) { }

	public void Set(ref UnregisterPlayersOptions other) { }

	public void Set(ref Nullable<UnregisterPlayersOptions> other) { }

	public void Dispose() { }

}

