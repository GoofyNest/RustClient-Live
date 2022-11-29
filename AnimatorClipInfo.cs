public struct AnimatorClipInfo // TypeDefIndex: 4489
{
	private int m_ClipInstanceID; 
	private float m_Weight; 

	public AnimationClip clip { get; }
	public float weight { get; }


	public AnimationClip get_clip() { }

	public float get_weight() { }

	[FreeFunctionAttribute] 
	private static AnimationClip InstanceIDToAnimationClipPPtr(int instanceID) { }

}

