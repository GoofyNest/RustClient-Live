internal struct LogPlayerTickOptionsInternal : ISettable<LogPlayerTickOptions>, IDisposable // TypeDefIndex: 9738
{
	private int m_ApiVersion; 
	private IntPtr m_PlayerHandle; 
	private IntPtr m_PlayerPosition; 
	private IntPtr m_PlayerViewRotation; 
	private int m_IsPlayerViewZoomed; 
	private float m_PlayerHealth; 
	private AntiCheatCommonPlayerMovementState m_PlayerMovementState; 

	public IntPtr PlayerHandle { set; }
	public Nullable<Vec3f> PlayerPosition { set; }
	public Nullable<Quat> PlayerViewRotation { set; }
	public bool IsPlayerViewZoomed { set; }
	public float PlayerHealth { set; }
	public AntiCheatCommonPlayerMovementState PlayerMovementState { set; }


	public void set_PlayerHandle(IntPtr value) { }

	public void set_PlayerPosition(Nullable<Vec3f> value) { }

	public void set_PlayerViewRotation(Nullable<Quat> value) { }

	public void set_IsPlayerViewZoomed(bool value) { }

	public void set_PlayerHealth(float value) { }

	public void set_PlayerMovementState(AntiCheatCommonPlayerMovementState value) { }

	public void Set(ref LogPlayerTickOptions other) { }

	public void Set(ref Nullable<LogPlayerTickOptions> other) { }

	public void Dispose() { }

}

