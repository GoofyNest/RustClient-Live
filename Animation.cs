public class AnimationCurve : IEquatable<AnimationCurve> // TypeDefIndex: 3353
{	// Fields
	internal IntPtr m_Ptr; // 0x10

	// Properties
	public Keyframe[] keys { get; set; }
	public Keyframe Item { get; }
	public int length { get; }
	public WrapMode preWrapMode { set; }
	public WrapMode postWrapMode { set; }

	// Methods

	[FreeFunctionAttribute] // RVA: 0xF00F0 Offset: 0xEF4F0 VA: 0x1800F00F0
	// RVA: 0x1817470 Offset: 0x1816870 VA: 0x181817470
	private static void Internal_Destroy(IntPtr ptr) { }

	[FreeFunctionAttribute] // RVA: 0xF01D0 Offset: 0xEF5D0 VA: 0x1800F01D0
	// RVA: 0x1817430 Offset: 0x1816830 VA: 0x181817430
	private static IntPtr Internal_Create(Keyframe[] keys) { }

	[FreeFunctionAttribute] // RVA: 0xF0330 Offset: 0xEF730 VA: 0x1800F0330
	// RVA: 0x18174B0 Offset: 0x18168B0 VA: 0x1818174B0
	private bool Internal_Equals(IntPtr other) { }

	// RVA: 0x1817270 Offset: 0x1816670 VA: 0x181817270 Slot: 1
	protected override void Finalize() { }

	[ThreadSafeAttribute] // RVA: 0x93AB0 Offset: 0x92EB0 VA: 0x180093AB0
	// RVA: 0x1817220 Offset: 0x1816620 VA: 0x181817220
	public float Evaluate(float time) { }

	// RVA: 0x18173F0 Offset: 0x18167F0 VA: 0x1818173F0
	public Keyframe[] get_keys() { }

	// RVA: 0x18177A0 Offset: 0x1816BA0 VA: 0x1818177A0
	public void set_keys(Keyframe[] value) { }

	// RVA: 0x1816D00 Offset: 0x1816100 VA: 0x181816D00
	public int AddKey(Keyframe key) { }

	[NativeMethodAttribute] // RVA: 0xF0510 Offset: 0xEF910 VA: 0x1800F0510
	// RVA: 0x1816CB0 Offset: 0x18160B0 VA: 0x181816CB0
	private int AddKey_Internal(Keyframe key) { }

	// RVA: 0x1817880 Offset: 0x1816C80 VA: 0x181817880
	public Keyframe get_Item(int index) { }

	[NativeMethodAttribute] // RVA: 0xF06A0 Offset: 0xEFAA0 VA: 0x1800F06A0
	// RVA: 0x1817910 Offset: 0x1816D10 VA: 0x181817910
	public int get_length() { }

	[FreeFunctionAttribute] // RVA: 0xF07E0 Offset: 0xEFBE0 VA: 0x1800F07E0
	// RVA: 0x18177A0 Offset: 0x1816BA0 VA: 0x1818177A0
	private void SetKeys(Keyframe[] keys) { }

	[NativeThrowsAttribute] // RVA: 0xF0920 Offset: 0xEFD20 VA: 0x1800F0920
	[FreeFunctionAttribute] // RVA: 0xF0920 Offset: 0xEFD20 VA: 0x1800F0920
	// RVA: 0x1817380 Offset: 0x1816780 VA: 0x181817380
	private Keyframe GetKey(int index) { }

	[FreeFunctionAttribute] // RVA: 0xF0BE0 Offset: 0xEFFE0 VA: 0x1800F0BE0
	// RVA: 0x18173F0 Offset: 0x18167F0 VA: 0x1818173F0
	private Keyframe[] GetKeys() { }

	// RVA: 0x1816D60 Offset: 0x1816160 VA: 0x181816D60
	public static AnimationCurve Constant(float timeStart, float timeEnd, float value) { }

	// RVA: 0x1817500 Offset: 0x1816900 VA: 0x181817500
	public static AnimationCurve Linear(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	// RVA: 0x1816D90 Offset: 0x1816190 VA: 0x181816D90
	public static AnimationCurve EaseInOut(float timeStart, float valueStart, float timeEnd, float valueEnd) { }

	[NativeMethodAttribute] // RVA: 0xF0D10 Offset: 0xF0110 VA: 0x1800F0D10
	// RVA: 0x1817990 Offset: 0x1816D90 VA: 0x181817990
	public void set_preWrapMode(WrapMode value) { }

	[NativeMethodAttribute] // RVA: 0xF0E20 Offset: 0xF0220 VA: 0x1800F0E20
	// RVA: 0x1817950 Offset: 0x1816D50 VA: 0x181817950
	public void set_postWrapMode(WrapMode value) { }

	// RVA: 0x1817830 Offset: 0x1816C30 VA: 0x181817830
	public void .ctor(Keyframe[] keys) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x18177F0 Offset: 0x1816BF0 VA: 0x1818177F0
	public void .ctor() { }

	// RVA: 0x1817000 Offset: 0x1816400 VA: 0x181817000 Slot: 0
	public override bool Equals(object o) { }

	// RVA: 0x1817160 Offset: 0x1816560 VA: 0x181817160 Slot: 4
	public bool Equals(AnimationCurve other) { }

	// RVA: 0x1817320 Offset: 0x1816720 VA: 0x181817320 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1816C60 Offset: 0x1816060 VA: 0x181816C60
	private int AddKey_Internal_Injected(ref Keyframe key) { }

	// RVA: 0x1817330 Offset: 0x1816730 VA: 0x181817330
	private void GetKey_Injected(int index, out Keyframe ret) { }

}

public sealed class AnimationClip : Motion // TypeDefIndex: 4479
{	// Properties
	[NativePropertyAttribute] // RVA: 0xC9070 Offset: 0xC8470 VA: 0x1800C9070
	public float length { get; }

	// Methods

	// RVA: 0x22D55E0 Offset: 0x22D49E0 VA: 0x1822D55E0
	public void .ctor() { }

	[FreeFunctionAttribute] // RVA: 0xC8E00 Offset: 0xC8200 VA: 0x1800C8E00
	// RVA: 0x22D55A0 Offset: 0x22D49A0 VA: 0x1822D55A0
	private static void Internal_CreateAnimationClip(AnimationClip self) { }

	// RVA: 0x22D5660 Offset: 0x22D4A60 VA: 0x1822D5660
	public float get_length() { }

}

internal enum AnimationEventSource // TypeDefIndex: 4496
{	// Fields
	public int value__; // 0x0
	public const AnimationEventSource NoSource = 0;
	public const AnimationEventSource Legacy = 1;
	public const AnimationEventSource Animator = 2;

}

public sealed class AnimationEvent // TypeDefIndex: 4497
{	// Fields
	internal float m_Time; // 0x10
	internal string m_FunctionName; // 0x18
	internal string m_StringParameter; // 0x20
	internal Object m_ObjectReferenceParameter; // 0x28
	internal float m_FloatParameter; // 0x30
	internal int m_IntParameter; // 0x34
	internal int m_MessageOptions; // 0x38
	internal AnimationEventSource m_Source; // 0x3C
	internal AnimationState m_StateSender; // 0x40
	internal AnimatorStateInfo m_AnimatorStateInfo; // 0x48
	internal AnimatorClipInfo m_AnimatorClipInfo; // 0x6C

	// Properties
	public string stringParameter { get; set; }
	public int intParameter { get; }
	public bool isFiredByAnimator { get; }
	public AnimatorClipInfo animatorClipInfo { get; }

	// Methods

	// RVA: 0x22D56A0 Offset: 0x22D4AA0 VA: 0x1822D56A0
	public void .ctor() { }

	// RVA: 0x1A5DBD0 Offset: 0x1A5CFD0 VA: 0x181A5DBD0
	public string get_stringParameter() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_stringParameter(string value) { }

	// RVA: 0x22D5790 Offset: 0x22D4B90 VA: 0x1822D5790
	public int get_intParameter() { }

	// RVA: 0x22D57A0 Offset: 0x22D4BA0 VA: 0x1822D57A0
	public bool get_isFiredByAnimator() { }

	// RVA: 0x22D5730 Offset: 0x22D4B30 VA: 0x1822D5730
	public AnimatorClipInfo get_animatorClipInfo() { }

}

public sealed class Animation : Behaviour, IEnumerable // TypeDefIndex: 4499
{	// Properties
	public bool isPlaying { get; }
	public AnimationState Item { get; }

	// Methods

	// RVA: 0x22D60A0 Offset: 0x22D54A0 VA: 0x1822D60A0
	public void Stop() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D60A0 Offset: 0x22D54A0 VA: 0x1822D60A0
	private static void INTERNAL_CALL_Stop(Animation self) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D6210 Offset: 0x22D5610 VA: 0x1822D6210
	public bool get_isPlaying() { }

	// RVA: 0x22D6050 Offset: 0x22D5450 VA: 0x1822D6050
	public AnimationState get_Item(string name) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D61D0 Offset: 0x22D55D0 VA: 0x1822D61D0
	public bool Play() { }

	// RVA: 0x22D60E0 Offset: 0x22D54E0 VA: 0x1822D60E0
	public bool Play(PlayMode mode) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D6170 Offset: 0x22D5570 VA: 0x1822D6170
	public bool Play(string animation, PlayMode mode) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D6120 Offset: 0x22D5520 VA: 0x1822D6120
	public bool Play(string animation) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D60E0 Offset: 0x22D54E0 VA: 0x1822D60E0
	private bool PlayDefaultAnimation(PlayMode mode) { }

	// RVA: 0x22D5F60 Offset: 0x22D5360 VA: 0x1822D5F60 Slot: 4
	public IEnumerator GetEnumerator() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D6050 Offset: 0x22D5450 VA: 0x1822D6050
	internal AnimationState GetState(string name) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D5FD0 Offset: 0x22D53D0 VA: 0x1822D5FD0
	internal AnimationState GetStateAtIndex(int index) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D6010 Offset: 0x22D5410 VA: 0x1822D6010
	internal int GetStateCount() { }

}

private sealed class Animation.Enumerator : IEnumerator // TypeDefIndex: 4500
{	// Fields
	private Animation m_Outer; // 0x10
	private int m_CurrentIndex; // 0x18

	// Properties
	public object Current { get; }

	// Methods

	// RVA: 0x11B44A0 Offset: 0x11B38A0 VA: 0x1811B44A0
	internal void .ctor(Animation outer) { }

	// RVA: 0x22D7F50 Offset: 0x22D7350 VA: 0x1822D7F50 Slot: 5
	public object get_Current() { }

	// RVA: 0x22D7EF0 Offset: 0x22D72F0 VA: 0x1822D7EF0 Slot: 4
	public bool MoveNext() { }

	// RVA: 0x1176E50 Offset: 0x1176250 VA: 0x181176E50 Slot: 6
	public void Reset() { }

}

public sealed class AnimationState : TrackedReference // TypeDefIndex: 4501
{	// Properties
	public float time { set; }
	public float speed { get; set; }
	public float length { get; }

	// Methods

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D5F10 Offset: 0x22D5310 VA: 0x1822D5F10
	public void set_time(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D5E80 Offset: 0x22D5280 VA: 0x1822D5E80
	public float get_speed() { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D5EC0 Offset: 0x22D52C0 VA: 0x1822D5EC0
	public void set_speed(float value) { }

	[GeneratedByOldBindingsGeneratorAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22D5E40 Offset: 0x22D5240 VA: 0x1822D5E40
	public float get_length() { }

	// RVA: 0x7992B0 Offset: 0x7986B0 VA: 0x1807992B0
	public void .ctor() { }

}

public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
{
// Namespace: UnityEngine.Animations
[NativeHeaderAttribute] // RVA: 0xD0750 Offset: 0xCFB50 VA: 0x1800D0750
[RequiredByNativeCodeAttribute] // RVA: 0xD0750 Offset: 0xCFB50 VA: 0x1800D0750
[StaticAccessorAttribute] // RVA: 0xD0750 Offset: 0xCFB50 VA: 0x1800D0750
[NativeHeaderAttribute] // RVA: 0xD0750 Offset: 0xCFB50 VA: 0x1800D0750
public struct AnimationClipPlayable : IEquatable<AnimationClipPlayable> // TypeDefIndex: 4503
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C560 Offset: 0x23B960 VA: 0x18023C560 Slot: 4
	public bool Equals(AnimationClipPlayable other) { }

}

public struct AnimationHumanStream // TypeDefIndex: 4504
{	// Fields
	private IntPtr stream; // 0x0

}

public struct AnimationLayerMixerPlayable : IEquatable<AnimationLayerMixerPlayable> // TypeDefIndex: 4505
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationLayerMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C6A0 Offset: 0x23BAA0 VA: 0x18023C6A0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C610 Offset: 0x23BA10 VA: 0x18023C610 Slot: 4
	public bool Equals(AnimationLayerMixerPlayable other) { }

	// RVA: 0x22D57B0 Offset: 0x22D4BB0 VA: 0x1822D57B0
	private static void .cctor() { }

}

public struct AnimationMixerPlayable : IEquatable<AnimationMixerPlayable> // TypeDefIndex: 4506
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMixerPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C7D0 Offset: 0x23BBD0 VA: 0x18023C7D0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C740 Offset: 0x23BB40 VA: 0x18023C740 Slot: 4
	public bool Equals(AnimationMixerPlayable other) { }

	// RVA: 0x22D58A0 Offset: 0x22D4CA0 VA: 0x1822D58A0
	private static void .cctor() { }

}

internal struct AnimationMotionXToDeltaPlayable : IEquatable<AnimationMotionXToDeltaPlayable> // TypeDefIndex: 4507
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationMotionXToDeltaPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23C900 Offset: 0x23BD00 VA: 0x18023C900
	private void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C870 Offset: 0x23BC70 VA: 0x18023C870 Slot: 4
	public bool Equals(AnimationMotionXToDeltaPlayable other) { }

	// RVA: 0x22D5990 Offset: 0x22D4D90 VA: 0x1822D5990
	private static void .cctor() { }

}

internal struct AnimationOffsetPlayable : IEquatable<AnimationOffsetPlayable> // TypeDefIndex: 4508
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationOffsetPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CA50 Offset: 0x23BE50 VA: 0x18023CA50
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23C9A0 Offset: 0x23BDA0 VA: 0x18023C9A0 Slot: 4
	public bool Equals(AnimationOffsetPlayable other) { }

	// RVA: 0x22D5A80 Offset: 0x22D4E80 VA: 0x1822D5A80
	private static void .cctor() { }

}

public struct AnimationPlayableOutput // TypeDefIndex: 4509
{	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

}

internal struct AnimationPosePlayable : IEquatable<AnimationPosePlayable> // TypeDefIndex: 4510
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationPosePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CBA0 Offset: 0x23BFA0 VA: 0x18023CBA0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CAF0 Offset: 0x23BEF0 VA: 0x18023CAF0 Slot: 4
	public bool Equals(AnimationPosePlayable other) { }

	// RVA: 0x22D5B70 Offset: 0x22D4F70 VA: 0x1822D5B70
	private static void .cctor() { }

}

internal struct AnimationRemoveScalePlayable : IEquatable<AnimationRemoveScalePlayable> // TypeDefIndex: 4511
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationRemoveScalePlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CCF0 Offset: 0x23C0F0 VA: 0x18023CCF0
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CC40 Offset: 0x23C040 VA: 0x18023CC40 Slot: 4
	public bool Equals(AnimationRemoveScalePlayable other) { }

	// RVA: 0x22D5C60 Offset: 0x22D5060 VA: 0x1822D5C60
	private static void .cctor() { }

}

public struct AnimationScriptPlayable : IEquatable<AnimationScriptPlayable> // TypeDefIndex: 4512
{	// Fields
	private PlayableHandle m_Handle; // 0x0
	private static readonly AnimationScriptPlayable m_NullPlayable; // 0x0

	// Methods

	// RVA: 0x23CE20 Offset: 0x23C220 VA: 0x18023CE20
	internal void .ctor(PlayableHandle handle) { }

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23CD90 Offset: 0x23C190 VA: 0x18023CD90 Slot: 4
	public bool Equals(AnimationScriptPlayable other) { }

	// RVA: 0x22D5D50 Offset: 0x22D5150 VA: 0x1822D5D50
	private static void .cctor() { }

}

public struct AnimationStream // TypeDefIndex: 4513
{	// Fields
	private uint m_AnimatorBindingsVersion; // 0x0
	private IntPtr constant; // 0x8
	private IntPtr input; // 0x10
	private IntPtr output; // 0x18
	private IntPtr workspace; // 0x20
	private IntPtr inputStreamAccessor; // 0x28
	private IntPtr animationHandleBinder; // 0x30

}

public class AnimationTriggers // TypeDefIndex: 4904
{
// Namespace: 
private struct <PrivateImplementationDetails>.__StaticArrayInitTypeSize=104 // TypeDefIndex: 4901

// Namespace: 
internal class <Module> // TypeDefIndex: 4902

// Namespace: 
internal class <Module> // TypeDefIndex: 4903

// Namespace: UnityEngine.UI
[Serializable]
public class AnimationTriggers // TypeDefIndex: 4904
	// Fields
	private const string kDefaultNormalAnimName = "Normal";
	private const string kDefaultHighlightedAnimName = "Highlighted";
	private const string kDefaultPressedAnimName = "Pressed";
	private const string kDefaultSelectedAnimName = "Selected";
	private const string kDefaultDisabledAnimName = "Disabled";
	[FormerlySerializedAsAttribute] // RVA: 0xE1880 Offset: 0xE0C80 VA: 0x1800E1880
	[SerializeField] // RVA: 0xE1880 Offset: 0xE0C80 VA: 0x1800E1880
	private string m_NormalTrigger; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xE1910 Offset: 0xE0D10 VA: 0x1800E1910
	[SerializeField] // RVA: 0xE1910 Offset: 0xE0D10 VA: 0x1800E1910
	private string m_HighlightedTrigger; // 0x18
	[FormerlySerializedAsAttribute] // RVA: 0xE2D50 Offset: 0xE2150 VA: 0x1800E2D50
	[SerializeField] // RVA: 0xE2D50 Offset: 0xE2150 VA: 0x1800E2D50
	private string m_PressedTrigger; // 0x20
	[FormerlySerializedAsAttribute] // RVA: 0xE4210 Offset: 0xE3610 VA: 0x1800E4210
	[SerializeField] // RVA: 0xE4210 Offset: 0xE3610 VA: 0x1800E4210
	private string m_SelectedTrigger; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xE4640 Offset: 0xE3A40 VA: 0x1800E4640
	[SerializeField] // RVA: 0xE4640 Offset: 0xE3A40 VA: 0x1800E4640
	private string m_DisabledTrigger; // 0x30

	// Properties
	public string normalTrigger { get; set; }
	public string highlightedTrigger { get; set; }
	public string pressedTrigger { get; set; }
	public string selectedTrigger { get; set; }
	public string disabledTrigger { get; set; }

	// Methods

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_normalTrigger() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_normalTrigger(string value) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_highlightedTrigger() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_highlightedTrigger(string value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public string get_pressedTrigger() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	public void set_pressedTrigger(string value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public string get_selectedTrigger() { }

	// RVA: 0x7CE240 Offset: 0x7CD640 VA: 0x1807CE240
	public void set_selectedTrigger(string value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public string get_disabledTrigger() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	public void set_disabledTrigger(string value) { }

	// RVA: 0x10AFE80 Offset: 0x10AF280 VA: 0x1810AFE80
	public void .ctor() { }

}

public class AnimationFlagHandler : MonoBehaviour // TypeDefIndex: 8783
{	// Fields
	public Animator animator; // 0x18

	// Methods

	// RVA: 0x8287D0 Offset: 0x827BD0 VA: 0x1808287D0
	public void SetBoolTrue(string name) { }

	// RVA: 0x8287A0 Offset: 0x827BA0 VA: 0x1808287A0
	public void SetBoolFalse(string name) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AnimationEventForward : MonoBehaviour // TypeDefIndex: 9120
{	// Fields
	public GameObject targetObject; // 0x18

	// Methods

	// RVA: 0x8279B0 Offset: 0x826DB0 VA: 0x1808279B0
	public void Event(string type) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AnimationEvents : BaseMonoBehaviour // TypeDefIndex: 9325
{	// Fields
	public Transform rootObject; // 0x18
	public HeldEntity targetEntity; // 0x20
	[TooltipAttribute] // RVA: 0xE7610 Offset: 0xE6A10 VA: 0x1800E7610
	public string effectFolder; // 0x28
	public bool enforceClipWeights; // 0x30
	public string localFolder; // 0x38
	[TooltipAttribute] // RVA: 0xE7740 Offset: 0xE6B40 VA: 0x1800E7740
	public bool customLocalFolder; // 0x40
	public bool IsBusy; // 0x41
	private IAnimationEventReceiver cachedEventReceiver; // 0x48
	private bool hasCachedEventReceiver; // 0x50

	// Methods

	// RVA: 0x8281B0 Offset: 0x8275B0 VA: 0x1808281B0
	protected void OnEnable() { }

	// RVA: 0x828450 Offset: 0x827850 VA: 0x180828450
	public void SetBusy(int i) { }

	// RVA: 0x8280C0 Offset: 0x8274C0 VA: 0x1808280C0
	public void Hide(string childName) { }

	// RVA: 0x828510 Offset: 0x827910 VA: 0x180828510
	public void Show(string childName) { }

	// RVA: 0x828010 Offset: 0x827410 VA: 0x180828010
	public void HideGameObject(string childName) { }

	// RVA: 0x828460 Offset: 0x827860 VA: 0x180828460
	public void ShowGameObject(string childName) { }

	// RVA: 0x827A00 Offset: 0x826E00 VA: 0x180827A00
	public void DoEffect(AnimationEvent evt) { }

	// RVA: 0x8279D0 Offset: 0x826DD0 VA: 0x1808279D0
	public void Broadcast(string strEvent) { }

	// RVA: 0x828180 Offset: 0x827580 VA: 0x180828180
	public void Message(string strEvent) { }

	// RVA: 0x827C50 Offset: 0x827050 VA: 0x180827C50
	public void Event(string name) { }

	// RVA: 0x8286B0 Offset: 0x827AB0 VA: 0x1808286B0
	private void TryCacheEventReceiver() { }

	// RVA: 0x828330 Offset: 0x827730 VA: 0x180828330
	public void ReliableEvent(string name) { }

	// RVA: 0x8285D0 Offset: 0x8279D0 VA: 0x1808285D0
	public void Strike() { }

	// RVA: 0x827BD0 Offset: 0x826FD0 VA: 0x180827BD0
	public void Event_Strike() { }

	// RVA: 0x828640 Offset: 0x827A40 VA: 0x180828640
	public void Throw() { }

	// RVA: 0x827C10 Offset: 0x827010 VA: 0x180827C10
	public void Event_Throw() { }

	// RVA: 0x826660 Offset: 0x825A60 VA: 0x180826660
	public void PlaySound(SoundDefinition def) { }

	// RVA: 0x828240 Offset: 0x827640 VA: 0x180828240
	public void PlaySoundFirstPerson(SoundDefinition def) { }

	// RVA: 0x53B440 Offset: 0x53A840 VA: 0x18053B440
	public void .ctor() { }

}

