public struct FrameData // TypeDefIndex: 3859
{	// Fields
	internal ulong m_FrameID; // 0x0
	internal double m_DeltaTime; // 0x8
	internal float m_Weight; // 0x10
	internal float m_EffectiveWeight; // 0x14
	internal double m_EffectiveParentDelay; // 0x18
	internal float m_EffectiveParentSpeed; // 0x20
	internal float m_EffectiveSpeed; // 0x24
	internal FrameData.Flags m_Flags; // 0x28
	internal PlayableOutput m_Output; // 0x30

}

internal enum FrameData.Flags // TypeDefIndex: 3860
{	// Fields
	public int value__; // 0x0
	public const FrameData.Flags Evaluate = 1;
	public const FrameData.Flags SeekOccured = 2;
	public const FrameData.Flags Loop = 4;
	public const FrameData.Flags Hold = 8;
	public const FrameData.Flags EffectivePlayStateDelayed = 16;
	public const FrameData.Flags EffectivePlayStatePlaying = 32;

}

