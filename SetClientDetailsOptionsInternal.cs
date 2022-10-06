internal struct SetClientDetailsOptionsInternal : ISettable<SetClientDetailsOptions>, IDisposable // TypeDefIndex: 9792
{
	private int m_ApiVersion; 
	private IntPtr m_ClientHandle; 
	private AntiCheatCommonClientFlags m_ClientFlags; 
	private AntiCheatCommonClientInput m_ClientInputMethod; 

	public IntPtr ClientHandle { set; }
	public AntiCheatCommonClientFlags ClientFlags { set; }
	public AntiCheatCommonClientInput ClientInputMethod { set; }


	public void set_ClientHandle(IntPtr value) { }

	public void set_ClientFlags(AntiCheatCommonClientFlags value) { }

	public void set_ClientInputMethod(AntiCheatCommonClientInput value) { }

	public void Set(ref SetClientDetailsOptions other) { }

	public void Set(ref Nullable<SetClientDetailsOptions> other) { }

	public void Dispose() { }

}

