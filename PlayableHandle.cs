public struct PlayableHandle : IEquatable<PlayableHandle> // TypeDefIndex: 3874
{
	internal IntPtr m_Handle; 
	internal uint m_Version; 
	private static readonly PlayableHandle m_Null; 

	public static PlayableHandle Null { get; }


	internal T GetObject<T>() { }
	/* GenericInstMethod :
	|
	|-PlayableHandle.GetObject<object>
	*/

	[VisibleToOtherModulesAttribute] 
	internal bool IsPlayableOfType<T>() { }
	/* GenericInstMethod :
	|
	|-PlayableHandle.IsPlayableOfType<object>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationLayerMixerPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationMixerPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationMotionXToDeltaPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationOffsetPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationPosePlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationRemoveScalePlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimationScriptPlayable>
	|
	|-PlayableHandle.IsPlayableOfType<AnimatorControllerPlayable>
	*/

	public static PlayableHandle get_Null() { }

	public static bool op_Equality(PlayableHandle x, PlayableHandle y) { }

	public override bool Equals(object p) { }

	public bool Equals(PlayableHandle other) { }

	public override int GetHashCode() { }

	internal static bool CompareVersion(PlayableHandle lhs, PlayableHandle rhs) { }

	[VisibleToOtherModulesAttribute] 
	internal bool IsValid() { }

	[VisibleToOtherModulesAttribute] 
	[FreeFunctionAttribute] 
	internal Type GetPlayableType() { }

	[FreeFunctionAttribute] 
	[VisibleToOtherModulesAttribute] 
	internal void SetScriptInstance(object scriptInstance) { }

	[FreeFunctionAttribute] 
	[VisibleToOtherModulesAttribute] 
	internal void SetInputCount(int value) { }

	[FreeFunctionAttribute] 
	private object GetScriptInstance() { }

	private static void .cctor() { }

	private static bool IsValid_Injected(ref PlayableHandle _unity_self) { }

	private static Type GetPlayableType_Injected(ref PlayableHandle _unity_self) { }

	private static void SetScriptInstance_Injected(ref PlayableHandle _unity_self, object scriptInstance) { }

	private static void SetInputCount_Injected(ref PlayableHandle _unity_self, int value) { }

	private static object GetScriptInstance_Injected(ref PlayableHandle _unity_self) { }

}

