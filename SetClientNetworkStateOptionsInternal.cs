internal struct SetClientNetworkStateOptionsInternal : ISettable<SetClientNetworkStateOptions>, IDisposable // TypeDefIndex: 9746
{
	private int m_ApiVersion;
	private IntPtr m_ClientHandle;
	private int m_IsNetworkActive;

	public IntPtr ClientHandle { set; }
	public bool IsNetworkActive { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void set_IsNetworkActive(bool value) { }

	public void Set(ref SetClientNetworkStateOptions other) { }

	public void Set(ref Nullable<SetClientNetworkStateOptions> other) { }

	public void Dispose() { }

}

