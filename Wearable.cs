public class Wearable : MonoBehaviour, IItemSetup, IPrefabPreProcess // TypeDefIndex: 11802
{
	[InspectorFlagsAttribute] 
	public Wearable.RemoveSkin removeSkin; 
	[InspectorFlagsAttribute] 
	public Wearable.RemoveSkin removeSkinFirstPerson; 
	[InspectorFlagsAttribute] 
	public Wearable.RemoveHair removeHair; 
	[InspectorFlagsAttribute] 
	public Wearable.DeformHair deformHair; 
	[InspectorFlagsAttribute] 
	public Wearable.OccupationSlots occupationUnder; 
	[InspectorFlagsAttribute] 
	public Wearable.OccupationSlots occupationOver; 
	public bool showCensorshipCube; 
	public bool showCensorshipCubeBreasts; 
	public bool forceHideCensorshipBreasts; 
	public string followBone; 
	public bool disableRigStripping; 
	public bool overrideDownLimit; 
	public float downLimit; 
	[HideInInspector] 
	public PlayerModelHair playerModelHair; 
	[HideInInspector] 
	public PlayerModelHairCap playerModelHairCap; 
	[HideInInspector] 
	public WearableReplacementByRace wearableReplacementByRace; 
	[HideInInspector] 
	public WearableShadowLod wearableShadowLod; 
	[HideInInspector] 
	public List<Renderer> renderers; 
	[HideInInspector] 
	public List<PlayerModelSkin> playerModelSkins; 
	[HideInInspector] 
	public List<BoneRetarget> boneRetargets; 
	[HideInInspector] 
	public List<SkinnedMeshRenderer> skinnedRenderers; 
	[HideInInspector] 
	public List<SkeletonSkin> skeletonSkins; 
	[HideInInspector] 
	public List<ComponentInfo> componentInfos; 
	public bool HideInEyesView; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public bool HideInFirstPerson; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float ExtraLeanBack; 
	[TooltipAttribute] 
	public bool PreserveBones; 
	public Renderer[] RenderersLod0; 
	public Renderer[] RenderersLod1; 
	public Renderer[] RenderersLod2; 
	public Renderer[] RenderersLod3; 
	public Renderer[] SkipInFirstPersonLegs; 
	private static LOD[] emptyLOD; 


	public void OnItemSetup(Item item) { }

	public virtual void PreProcess(IPrefabProcessor preProcess, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void CacheComponents() { }

	public void StripRig(IPrefabProcessor preProcess, SkinnedMeshRenderer skinnedMeshRenderer) { }

	public void SetupRendererCache(IPrefabProcessor preProcess) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Wearable.RemoveSkin // TypeDefIndex: 11803
{
	public int value__; 
	public const Wearable.RemoveSkin Torso = 1;
	public const Wearable.RemoveSkin Feet = 2;
	public const Wearable.RemoveSkin Hands = 4;
	public const Wearable.RemoveSkin Legs = 8;
	public const Wearable.RemoveSkin Head = 16;

}

public enum Wearable.RemoveHair // TypeDefIndex: 11804
{
	public int value__; 
	public const Wearable.RemoveHair Head = 1;
	public const Wearable.RemoveHair Eyebrow = 2;
	public const Wearable.RemoveHair Facial = 4;
	public const Wearable.RemoveHair Armpit = 8;
	public const Wearable.RemoveHair Pubic = 16;

}

public enum Wearable.DeformHair // TypeDefIndex: 11805
{
	public int value__; 
	public const Wearable.DeformHair None = 0;
	public const Wearable.DeformHair BaseballCap = 1;
	public const Wearable.DeformHair BoonieHat = 2;
	public const Wearable.DeformHair CandleHat = 3;
	public const Wearable.DeformHair MinersHat = 4;
	public const Wearable.DeformHair WoodHelmet = 5;

}

public enum Wearable.OccupationSlots // TypeDefIndex: 11806
{
	public int value__; 
	public const Wearable.OccupationSlots HeadTop = 1;
	public const Wearable.OccupationSlots Face = 2;
	public const Wearable.OccupationSlots HeadBack = 4;
	public const Wearable.OccupationSlots TorsoFront = 8;
	public const Wearable.OccupationSlots TorsoBack = 16;
	public const Wearable.OccupationSlots LeftShoulder = 32;
	public const Wearable.OccupationSlots RightShoulder = 64;
	public const Wearable.OccupationSlots LeftArm = 128;
	public const Wearable.OccupationSlots RightArm = 256;
	public const Wearable.OccupationSlots LeftHand = 512;
	public const Wearable.OccupationSlots RightHand = 1024;
	public const Wearable.OccupationSlots Groin = 2048;
	public const Wearable.OccupationSlots Bum = 4096;
	public const Wearable.OccupationSlots LeftKnee = 8192;
	public const Wearable.OccupationSlots RightKnee = 16384;
	public const Wearable.OccupationSlots LeftLeg = 32768;
	public const Wearable.OccupationSlots RightLeg = 65536;
	public const Wearable.OccupationSlots LeftFoot = 131072;
	public const Wearable.OccupationSlots RightFoot = 262144;
	public const Wearable.OccupationSlots Mouth = 524288;
	public const Wearable.OccupationSlots Eyes = 1048576;

}

private sealed class Wearable.<>c // TypeDefIndex: 11807
{
	public static readonly Wearable.<>c <>9; 
	public static Func<Renderer, bool> <>9__39_0; 
	public static Func<Renderer, bool> <>9__39_1; 
	public static Func<Renderer, bool> <>9__39_2; 
	public static Func<Renderer, bool> <>9__39_3; 


	private static void .cctor() { }

	public void .ctor() { }

	internal bool <CacheComponents>

	internal bool <CacheComponents>

	internal bool <CacheComponents>

	internal bool <CacheComponents>

}

