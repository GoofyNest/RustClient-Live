public class SkinnedMultiMesh : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 9235
{	// Fields
	public bool shadowOnly; // 0x18
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

	// Properties
	public List<Renderer> Renderers { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public List<Renderer> get_Renderers() { }

	// RVA: 0x5B98C0 Offset: 0x5B8CC0 VA: 0x1805B98C0 Slot: 4
	public void PreProcess(IPrefabProcessor process, GameObject rootObj, string name, bool serverside, bool clientside, bool bundling) { }

	// RVA: 0x5B7F90 Offset: 0x5B7390 VA: 0x1805B7F90
	public void Clear() { }

	// RVA: 0x5BAEF0 Offset: 0x5BA2F0 VA: 0x1805BAEF0
	public long WorkoutPartsHash() { }

	// RVA: 0x5B9980 Offset: 0x5B8D80 VA: 0x1805B9980
	public void RebuildModel(PlayerModel model, bool reset) { }

	// RVA: 0x5B92D0 Offset: 0x5B86D0 VA: 0x1805B92D0
	private void DoSkinSetup(PlayerModel model, Wearable wearable) { }

	// RVA: 0x5B87F0 Offset: 0x5B7BF0 VA: 0x1805B87F0
	private void DoHairCapSetup(Wearable wearable, List<KeyValuePair<HairCapMask, Renderer>> wearableHairCapSkins) { }

	// RVA: 0x5B8A30 Offset: 0x5B7E30 VA: 0x1805B8A30
	private void DoHairSetup(Wearable wearable) { }

	// RVA: 0x5B9420 Offset: 0x5B8820 VA: 0x1805B9420
	private void DoWearableSetup(Wearable wearable, List<WearableHairCap> wearableHairCap) { }

	// RVA: 0x5B9100 Offset: 0x5B8500 VA: 0x1805B9100
	private void DoRetargeting(Wearable wearable) { }

	// RVA: 0x5B8460 Offset: 0x5B7860 VA: 0x1805B8460
	private void DoBoneRetargeting(Wearable wearable, Item item) { }

	// RVA: 0x5BAD20 Offset: 0x5BA120 VA: 0x1805BAD20
	private void UpdateRenderers(Wearable wearable) { }

	// RVA: 0x5B8B10 Offset: 0x5B7F10 VA: 0x1805B8B10
	private void DoItemSetup(SkinnedMultiMesh.Part part, List<IItemSetup> itemSetups) { }

	// RVA: 0x5B8CD0 Offset: 0x5B80D0 VA: 0x1805B8CD0
	public void DoLODSetup() { }

	// RVA: 0x5B8140 Offset: 0x5B7540 VA: 0x1805B8140
	public void DeformCreatedPart(int blendShapeIndex) { }

	// RVA: 0x5B9680 Offset: 0x5B8A80 VA: 0x1805B9680
	public Transform FindBone(string strName) { }

	// RVA: 0x5B9760 Offset: 0x5B8B60 VA: 0x1805B9760
	public Transform[] GetBones() { }

	// RVA: 0x5B96A0 Offset: 0x5B8AA0 VA: 0x1805B96A0
	public SkinnedMultiMesh.Part[] FindParts(string name) { }

	// RVA: 0x5B9220 Offset: 0x5B8620 VA: 0x1805B9220
	internal void DoShadowOverride(Renderer renderer, MaterialPropertyBlock block) { }

	// RVA: 0x5BAC90 Offset: 0x5BA090 VA: 0x1805BAC90
	private void SetupLightShadowBiasScale(Renderer renderer, MaterialPropertyBlock block, bool shadowOnly) { }

	// RVA: 0x5BAB50 Offset: 0x5B9F50 VA: 0x1805BAB50
	public void SetVisible(bool bVisible) { }

	// RVA: 0x5B97B0 Offset: 0x5B8BB0 VA: 0x1805B97B0
	public bool IsCurrentlyVisible() { }

	// RVA: 0x5BB060 Offset: 0x5BA460 VA: 0x1805BB060
	public void .ctor() { }

}

public struct SkinnedMultiMesh.Part // TypeDefIndex: 9236
{	// Fields
	public Wearable wearable; // 0x0
	public GameObject gameObject; // 0x8
	public string name; // 0x10
	public Item item; // 0x18

}

private sealed class SkinnedMultiMesh.<>c // TypeDefIndex: 9237
{	// Fields
	public static readonly SkinnedMultiMesh.<>c <>9; // 0x0
	public static Func<SkinnedMultiMesh.Part, long> <>9__21_0; // 0x8
	public static Func<Renderer, bool> <>9__39_0; // 0x10

	// Methods

	// RVA: 0x5DDFD0 Offset: 0x5DD3D0 VA: 0x1805DDFD0
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5DDE90 Offset: 0x5DD290 VA: 0x1805DDE90
	internal long <WorkoutPartsHash>b__21_0(SkinnedMultiMesh.Part x) { }

	// RVA: 0x5DDE70 Offset: 0x5DD270 VA: 0x1805DDE70
	internal bool <IsCurrentlyVisible>b__39_0(Renderer r) { }

}

private sealed class SkinnedMultiMesh.<>c__DisplayClass35_0 // TypeDefIndex: 9238
{	// Fields
	public string name; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x5DDF80 Offset: 0x5DD380 VA: 0x1805DDF80
	internal bool <FindParts>b__0(SkinnedMultiMesh.Part x) { }

}

