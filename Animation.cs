public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 3353
{
	internal IntPtr m_Ptr; 

	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { set; }
	public WrapMode postWrapMode { set; }


	[FreeFunctionAttribute] 
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] 
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] 
	private bool Internal_Equals(IntPtr other) { }

	protected override void Finalize() { }

	[ThreadSafeAttribute] 
	public float Evaluate(float time) { }

	public Keyframe[] get_keys() { }

	public void set_keys(Keyframe[] value) { }

	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] 
	private int AddKey_Internal(Keyframe key) { }

	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] 
	public int get_length() { }

	[FreeFunctionAttribute] 
	private void SetKeys(Keyframe[] keys) { }

	[NativeThrowsAttribute] 
	[FreeFunctionAttribute] 
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] 
	private Keyframe[] GetKeys() { }

	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] 
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] 
	public void set_postWrapMode(WrapMode value) { }

	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] 
	public void .ctor() { }

	public override bool Equals(object o) { }

	public bool Equals(AnimationCurve other) { }

	public override int GetHashCode() { }

	private int AddKey_Internal_Injected(ref Keyframe key) { }

	private void GetKey_Injected(int index, out Keyframe ret) { }

}

public sealed class AnimationClip : Motion // TypeDefIndex: 4479
{
	[NativePropertyAttribute] 
	public float length { get; }


	public void .ctor() { }

	[FreeFunctionAttribute] 
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	public float get_length() { }

}

internal enum AnimationEventSource // TypeDefIndex: 4496
{
	public int value__; 
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;

}

public sealed class AnimationEvent // TypeDefIndex: 4497
{
	internal float m_Time; 
	internal string m_FunctionName; 
	internal string m_StringParameter; 
	internal Object m_ObjectReferenceParameter; 
	internal float m_FloatParameter; 
	internal int m_IntParameter; 
	internal int m_MessageOptions; 
	internal AnimationEventSource m_Source; 
	internal AnimationState m_StateSender; 
	internal AnimatorStateInfo m_AnimatorStateInfo; 
	internal AnimatorClipInfo m_AnimatorClipInfo; 

	public string stringParameter { get; set; }
	public int intParameter { get; }
	public bool isFiredByAnimator { get; }
	public AnimatorClipInfo animatorClipInfo { get; }


	public void .ctor() { }

	public string get_stringParameter() { }

	public void set_stringParameter(string value) { }

	public int get_intParameter() { }

	public bool get_isFiredByAnimator() { }

	public AnimatorClipInfo get_animatorClipInfo() { }

}

public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4499
{
	public bool isPlaying { get; }
	public AnimationState Item { get; }


	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	public bool get_isPlaying() { }

	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] 
	public bool Play() { }

	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] 
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	private bool PlayDefaultAnimation(PlayMode mode) { }

	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	internal int GetStateCount() { }

}

private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 4500
{
	private Animation m_Outer; 
	private int m_CurrentIndex; 

	public object Current { get; }


	internal void .ctor(Animation outer) { }

	public object get_Current() { }

	public bool MoveNext() { }

	public void Reset() { }

}

public sealed class AnimationState : TrackedReference // TypeDefIndex: 4501
{
	public float time { set; }
	public float speed { get; set; }
	public float length { get; }


	[GeneratedByOldBindingsGeneratorAttribute] 
	public void set_time(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	public float get_speed() { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	public void set_speed(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] 
	public float get_length() { }

	public void .ctor() { }

}

public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
{

[NativeHeaderAttribute] 
[RequiredByNativeCodeAttribute] 
[StaticAccessorAttribute] 
[NativeHeaderAttribute] 
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable>
	private PlayableHandle m_Handle; 


	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationClipPlayable other) { }

}

public struct AnimationHumanStream // TypeDefIndex: 4504
{
	private IntPtr stream; 

}

public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 4505
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; 


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationLayerMixerPlayable other) { }

	private static void .cctor() { }

}

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4506
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationMixerPlayable m_NullPlayable; 


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationMixerPlayable other) { }

	private static void .cctor() { }

}

internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4507
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; 


	private void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	private static void .cctor() { }

}

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4508
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationOffsetPlayable m_NullPlayable; 


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationOffsetPlayable other) { }

	private static void .cctor() { }

}

public struct AnimationPlayableOutput // TypeDefIndex: 4509
{
	private PlayableOutputHandle m_Handle; 

}

internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 4510
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationPosePlayable m_NullPlayable; 


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationPosePlayable other) { }

	private static void .cctor() { }

}

internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4511
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; 


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationRemoveScalePlayable other) { }

	private static void .cctor() { }

}

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 4512
{
	private PlayableHandle m_Handle; 
	private static readonly AnimationScriptPlayable m_NullPlayable; 


	internal void .ctor(PlayableHandle handle) { }

	public PlayableHandle GetHandle() { }

	public bool Equals(AnimationScriptPlayable other) { }

	private static void .cctor() { }

}

public struct AnimationStream // TypeDefIndex: 4513
{
	private uint m_AnimatorBindingsVersion; 
	private IntPtr constant; 
	private IntPtr input; 
	private IntPtr output; 
	private IntPtr workspace; 
	private IntPtr inputStreamAccessor; 
	private IntPtr animationHandleBinder; 

}

public class AnimationTriggers // TypeDefIndex: 4905
{

private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104

internal class <Module>

internal class <Module>

[Serializable]
public class AnimationTriggers
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private string m_NormalTrigger; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private string m_HighlightedTrigger; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private string m_PressedTrigger; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private string m_SelectedTrigger; 
	[FormerlySerializedAsAttribute] 
	[SerializeField] 
	private string m_DisabledTrigger; 

	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }


	public string get_normalTrigger() { }

	public void set_normalTrigger(string value) { }

	public string get_highlightedTrigger() { }

	public void set_highlightedTrigger(string value) { }

	public string get_pressedTrigger() { }

	public void set_pressedTrigger(string value) { }

	public string get_selectedTrigger() { }

	public void set_selectedTrigger(string value) { }

	public string get_disabledTrigger() { }

	public void set_disabledTrigger(string value) { }

	public void .ctor() { }

}

public class AnimationFlagHandler : MonoBehaviour // TypeDefIndex: 8786
{
	public Animator animator; 


	public void SetBoolTrue(string name) { }

	public void SetBoolFalse(string name) { }

	public void .ctor() { }

}

public class AnimationEventForward : MonoBehaviour // TypeDefIndex: 9124
{
	public GameObject targetObject; 


	public void Event(string type) { }

	public void .ctor() { }

}

public class AnimationEvents : BaseMonoBehaviour // TypeDefIndex: 9329
{
	public Transform rootObject; 
	public HeldEntity targetEntity; 
	[TooltipAttribute] 
	public string effectFolder; 
	public bool enforceClipWeights; 
	public string localFolder; 
	[TooltipAttribute] 
	public bool customLocalFolder; 
	public bool IsBusy; 
	private IAnimationEventReceiver cachedEventReceiver; 
	private bool hasCachedEventReceiver; 


	protected void OnEnable() { }

	public void SetBusy(int i) { }

	public void Hide(string childName) { }

	public void Show(string childName) { }

	public void HideGameObject(string childName) { }

	public void ShowGameObject(string childName) { }

	public void DoEffect(AnimationEvent evt) { }

	public void Broadcast(string strEvent) { }

	public void Message(string strEvent) { }

	public void Event(string name) { }

	private void TryCacheEventReceiver() { }

	public void ReliableEvent(string name) { }

	public void Strike() { }

	public void Event_Strike() { }

	public void Throw() { }

	public void Event_Throw() { }

	public void PlaySound(SoundDefinition def) { }

	public void PlaySoundFirstPerson(SoundDefinition def) { }

	public void .ctor() { }

}

