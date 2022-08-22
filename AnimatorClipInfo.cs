public struct AnimatorClipInfo // TypeDefIndex: 4484
{	private int m_ClipInstanceID; // 0x0
	private float m_Weight; // 0x4

	public AnimationClip clip { get; }
	public float weight { get; }


	public AnimationClip get_clip() { }

	public float get_weight() { }

	[FreeFunctionAttribute] // RVA: 0xC95E0 Offset: 0xC89E0 VA: 0x1800C95E0
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

}

