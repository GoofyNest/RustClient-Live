public struct ContactFilter2D // TypeDefIndex: 4081
{
	[NativeNameAttribute] 
	public bool useTriggers; 
	[NativeNameAttribute] 
	public bool useLayerMask; 
	[NativeNameAttribute] 
	public bool useDepth; 
	[NativeNameAttribute] 
	public bool useOutsideDepth; 
	[NativeNameAttribute] 
	public bool useNormalAngle; 
	[NativeNameAttribute] 
	public bool useOutsideNormalAngle; 
	[NativeNameAttribute] 
	public LayerMask layerMask; 
	[NativeNameAttribute] 
	public float minDepth; 
	[NativeNameAttribute] 
	public float maxDepth; 
	[NativeNameAttribute] 
	public float minNormalAngle; 
	[NativeNameAttribute] 
	public float maxNormalAngle; 


	private void CheckConsistency() { }

	public void SetLayerMask(LayerMask layerMask) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

