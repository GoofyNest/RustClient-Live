internal struct PollStatusOptionsInternal : ISettable<PollStatusOptions>, IDisposable // TypeDefIndex: 9847
{
	private int m_ApiVersion;
	private uint m_OutMessageLength;

	public uint OutMessageLength { set; }


	public void set_OutMessageLength(uint value) { }

	public void Set(ref PollStatusOptions other) { }

	public void Set(ref Nullable<PollStatusOptions> other) { }

	public void Dispose() { }

}

