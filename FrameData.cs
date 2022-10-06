public struct FrameData // TypeDefIndex: 3861
{
	internal ulong m_FrameID; 
	internal double m_DeltaTime; 
	internal float m_Weight; 
	internal float m_EffectiveWeight; 
	internal double m_EffectiveParentDelay; 
	internal float m_EffectiveParentSpeed; 
	internal float m_EffectiveSpeed; 
	internal FrameData.Flags m_Flags; 
	internal PlayableOutput m_Output; 

}

internal enum FrameData.Flags // TypeDefIndex: 3862
{
	public int value__; 
	public const FrameData.Flags Evaluate = 1;
	public const FrameData.Flags SeekOccured = 2;
	public const FrameData.Flags Loop = 4;
	public const FrameData.Flags Hold = 8;
	public const FrameData.Flags EffectivePlayStateDelayed = 16;
	public const FrameData.Flags EffectivePlayStatePlaying = 32;

}

