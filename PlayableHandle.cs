public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3870
{	internal IntPtr m_Handle; // 0x0
	internal uint m_Version; // 0x8
	private static readonly PlayableHandle m_Null; // 0x0

	public static PlayableHandle Null { get; }


	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public static PlayableHandle get_Null() { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableHandle other) { }

	public override int GetHashCode() { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	[FreeFunctionAttribute] // RVA: 0x81250 Offset: 0x80650 VA: 0x180081250
	internal Type GetPlayableType() { }

	private static void .cctor() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

}

