public struct AnimatorStateInfo // TypeDefIndex: 4485
{	private int m_Name; // 0x0
	private int m_Path; // 0x4
	private int m_FullPath; // 0x8
	private float m_NormalizedTime; // 0xC
	private float m_Length; // 0x10
	private float m_Speed; // 0x14
	private float m_SpeedMultiplier; // 0x18
	private int m_Tag; // 0x1C
	private int m_Loop; // 0x20

	public int shortNameHash { get; }
	public float normalizedTime { get; }
	public float speed { get; }


	public int get_shortNameHash() { }

	public float get_normalizedTime() { }

	public float get_speed() { }

}

