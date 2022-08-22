public struct ContactFilter2D // TypeDefIndex: 4081
{	[NativeNameAttribute] // RVA: 0x6FD60 Offset: 0x6F160 VA: 0x18006FD60
	public bool useTriggers; // 0x0
	[NativeNameAttribute] // RVA: 0x6FFF0 Offset: 0x6F3F0 VA: 0x18006FFF0
	public bool useLayerMask; // 0x1
	[NativeNameAttribute] // RVA: 0x700C0 Offset: 0x6F4C0 VA: 0x1800700C0
	public bool useDepth; // 0x2
	[NativeNameAttribute] // RVA: 0x70230 Offset: 0x6F630 VA: 0x180070230
	public bool useOutsideDepth; // 0x3
	[NativeNameAttribute] // RVA: 0x70390 Offset: 0x6F790 VA: 0x180070390
	public bool useNormalAngle; // 0x4
	[NativeNameAttribute] // RVA: 0x70480 Offset: 0x6F880 VA: 0x180070480
	public bool useOutsideNormalAngle; // 0x5
	[NativeNameAttribute] // RVA: 0x70590 Offset: 0x6F990 VA: 0x180070590
	public LayerMask layerMask; // 0x8
	[NativeNameAttribute] // RVA: 0x70620 Offset: 0x6FA20 VA: 0x180070620
	public float minDepth; // 0xC
	[NativeNameAttribute] // RVA: 0x707C0 Offset: 0x6FBC0 VA: 0x1800707C0
	public float maxDepth; // 0x10
	[NativeNameAttribute] // RVA: 0x70880 Offset: 0x6FC80 VA: 0x180070880
	public float minNormalAngle; // 0x14
	[NativeNameAttribute] // RVA: 0x709F0 Offset: 0x6FDF0 VA: 0x1800709F0
	public float maxNormalAngle; // 0x18


	private void CheckConsistency() { }

	public void SetLayerMask(LayerMask layerMask) { }

	public void SetDepth(float minDepth, float maxDepth) { }

	internal static ContactFilter2D CreateLegacyFilter(int layerMask, float minDepth, float maxDepth) { }

	private static void CheckConsistency_Injected(ref ContactFilter2D _unity_self) { }

}

