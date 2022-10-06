internal struct LogPlayerUseAbilityOptionsInternal : ISettable<LogPlayerUseAbilityOptions>, IDisposable // TypeDefIndex: 9774
{
	private int m_ApiVersion; 
	private IntPtr m_PlayerHandle; 
	private uint m_AbilityId; 
	private uint m_AbilityDurationMs; 
	private uint m_AbilityCooldownMs; 

	public IntPtr PlayerHandle { set; }
	public uint AbilityId { set; }
	public uint AbilityDurationMs { set; }
	public uint AbilityCooldownMs { set; }


	public void set_PlayerHandle(IntPtr value) { }

	public void set_AbilityId(uint value) { }

	public void set_AbilityDurationMs(uint value) { }

	public void set_AbilityCooldownMs(uint value) { }

	public void Set(ref LogPlayerUseAbilityOptions other) { }

	public void Set(ref Nullable<LogPlayerUseAbilityOptions> other) { }

	public void Dispose() { }

}

