public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3870
{	// Fields
	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	// Properties
	public static PlayableHandle Null { get; }

	// Methods

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xFE3F0 Offset: 0xFD7F0 VA: 0x1800FE3F0
	|-PlayableHandle.IsPlayableOfType<object>
	|
	|-RVA: 0xFDFF0 Offset: 0xFD3F0 VA: 0x1800FDFF0
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-RVA: 0xFE070 Offset: 0xFD470 VA: 0x1800FE070
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-RVA: 0xFE0F0 Offset: 0xFD4F0 VA: 0x1800FE0F0
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-RVA: 0xFE170 Offset: 0xFD570 VA: 0x1800FE170
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-RVA: 0xFE1F0 Offset: 0xFD5F0 VA: 0x1800FE1F0
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-RVA: 0xFE270 Offset: 0xFD670 VA: 0x1800FE270
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-RVA: 0xFE2F0 Offset: 0xFD6F0 VA: 0x1800FE2F0
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-RVA: 0xFE370 Offset: 0xFD770 VA: 0x1800FE370
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	*/

	// RVA: 0x18F5550 Offset: 0x18F4950 VA: 0x1818F5550
	public static PlayableHandle get_Null() { }

	// RVA: 0x18F55C0 Offset: 0x18F49C0 VA: 0x1818F55C0
	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	// RVA: 0x216F60 Offset: 0x216360 VA: 0x180216F60 Slot: 0
	public override bool Equals(object p) { }

	// RVA: 0x217050 Offset: 0x216450 VA: 0x180217050 Slot: 4
	public bool Equals(PlayableHandle other) { }

	// RVA: 0x2170F0 Offset: 0x2164F0 VA: 0x1802170F0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x18F5350 Offset: 0x18F4750 VA: 0x1818F5350
	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2171A0 Offset: 0x2165A0 VA: 0x1802171A0
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	[FreeFunctionAttribute] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	// RVA: 0x217130 Offset: 0x216530 VA: 0x180217130
	internal Type GetPlayableType() { }

	// RVA: 0x18F5510 Offset: 0x18F4910 VA: 0x1818F5510
	private static void .cctor() { }

	// RVA: 0x18F5460 Offset: 0x18F4860 VA: 0x1818F5460
	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	// RVA: 0x18F53B0 Offset: 0x18F47B0 VA: 0x1818F53B0
	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

