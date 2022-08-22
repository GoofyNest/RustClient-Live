public class SkinnedMultiMesh : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9235
{	public bool shadowOnly; // 0x18
	internal bool IsVisible; // 0x19
	public bool eyesView; // 0x1A
	public Skeleton skeleton; // 0x20
	public SkeletonSkinLod skeletonSkinLod; // 0x28
	public List<SkinnedMultiMesh.Part> parts; // 0x30
	public List<SkinnedMultiMesh.Part> createdParts; // 0x38
	public long lastBuildHash; // 0x40
	public MaterialPropertyBlock sharedPropertyBlock; // 0x48
	public MaterialPropertyBlock hairPropertyBlock; // 0x50
	public float skinNumber; // 0x58
	public float meshNumber; // 0x5C
	public float hairNumber; // 0x60
	public int skinType; // 0x64
	public SkinSetCollection SkinCollection; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private readonly List<Renderer> <Renderers>k__BackingField; // 0x70

	public List<Renderer> Renderers { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public List<Renderer> get_Renderers() { }

	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	public void Clear() { }

	public long WorkoutPartsHash() { }

	public void RebuildModel(PlayerModel model, bool reset) { }

	private void DoSkinSetup(PlayerModel model, Wearable wearable) { }

	private void DoHairCapSetup(Wearable wearable, List<KeyValuePair<HairCapMask, Renderer>> wearableHairCapSkins) { }

	private void DoHairSetup(Wearable wearable) { }

	private void DoWearableSetup(Wearable wearable, List<WearableHairCap> wearableHairCap) { }

	private void DoRetargeting(Wearable wearable) { }

	private void DoBoneRetargeting(Wearable wearable, Item item) { }

	private void UpdateRenderers(Wearable wearable) { }

	private void DoItemSetup(SkinnedMultiMesh.Part part, List<IItemSetup> itemSetups) { }

	public void DoLODSetup() { }

	public void DeformCreatedPart(int blendShapeIndex) { }

	public Transform FindBone(string strName) { }

	public Transform[] GetBones() { }

	public SkinnedMultiMesh.Part[] FindParts(string name) { }

	internal void DoShadowOverride(Renderer renderer, MaterialPropertyBlock block) { }

	private void SetupLightShadowBiasScale(Renderer renderer, MaterialPropertyBlock block, bool shadowOnly) { }

	public void SetVisible(bool bVisible) { }

	public bool IsCurrentlyVisible() { }

	public void .ctor() { }

}

public struct SkinnedMultiMesh.Part // TypeDefIndex: 9236
{	public Wearable wearable; // 0x0
	public GameObject gameObject; // 0x8
	public string name; // 0x10
	public Item item; // 0x18

}

private sealed class SkinnedMultiMesh.<>c // TypeDefIndex: 9237
{	public static readonly SkinnedMultiMesh.<>c <>9; // 0x0
	public static Func<SkinnedMultiMesh.Part, long> <>9__21_0; // 0x8
	public static Func<Renderer, bool> <>9__39_0; // 0x10


	private static void .cctor() { }

	public void .ctor() { }

	internal long <WorkoutPartsHash>b__21_0(SkinnedMultiMesh.Part x) { }

	internal bool <IsCurrentlyVisible>b__39_0(Renderer r) { }

}

private sealed class SkinnedMultiMesh.<>c__DisplayClass35_0 // TypeDefIndex: 9238
{	public string name; // 0x10


	public void .ctor() { }

	internal bool <FindParts>b__0(SkinnedMultiMesh.Part x) { }

}

