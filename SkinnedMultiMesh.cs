public class SkinnedMultiMesh : MonoBehaviour, IPrefabPreProcess // TypeDefIndex: 10980
{
	public bool shadowOnly;
	internal bool IsVisible;
	public bool eyesView;
	public Skeleton skeleton;
	public SkeletonSkinLod skeletonSkinLod;
	public List<SkinnedMultiMesh.Part> parts;
	public List<SkinnedMultiMesh.Part> createdParts;
	public long lastBuildHash;
	public MaterialPropertyBlock sharedPropertyBlock;
	public MaterialPropertyBlock hairPropertyBlock;
	public float skinNumber;
	public float meshNumber;
	public float hairNumber;
	public int skinType;
	public SkinSetCollection SkinCollection;
	[CompilerGeneratedAttribute]
	private readonly List<Renderer> <Renderers>k__BackingField;

	public List<Renderer> Renderers { get; }


	[CompilerGeneratedAttribute]
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

public struct SkinnedMultiMesh.Part // TypeDefIndex: 10981
{
	public Wearable wearable;
	public GameObject gameObject;
	public string name;
	public Item item;

}

private sealed class SkinnedMultiMesh.<>c // TypeDefIndex: 10982
{
	public static readonly SkinnedMultiMesh.<>c <>9;
	public static Func<SkinnedMultiMesh.Part, long> <>9__21_0;
	public static Func<Renderer, bool> <>9__39_0;


	private static void .cctor() { }

	public void .ctor() { }

	internal long <WorkoutPartsHash>

	internal bool <IsCurrentlyVisible>

}

private sealed class SkinnedMultiMesh.<>c__DisplayClass35_0 // TypeDefIndex: 10983
{
	public string name;


	public void .ctor() { }

	internal bool <FindParts>

}

