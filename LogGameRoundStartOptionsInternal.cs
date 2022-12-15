internal struct LogGameRoundStartOptionsInternal : ISettable<LogGameRoundStartOptions>, IDisposable // TypeDefIndex: 9776
{
	private int m_ApiVersion;
	private IntPtr m_SessionIdentifier;
	private IntPtr m_LevelName;
	private IntPtr m_ModeName;
	private uint m_RoundTimeSeconds;

	public Utf8String SessionIdentifier { set; }
	public Utf8String LevelName { set; }
	public Utf8String ModeName { set; }
	public uint RoundTimeSeconds { set; }


	public void set_SessionIdentifier(Utf8String value) { }

	public void set_LevelName(Utf8String value) { }

	public void set_ModeName(Utf8String value) { }

	public void set_RoundTimeSeconds(uint value) { }

	public void Set(ref LogGameRoundStartOptions other) { }

	public void Set(ref Nullable<LogGameRoundStartOptions> other) { }

	public void Dispose() { }

}

