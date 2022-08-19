public class DeferredMeshDecal : MonoBehaviour, IClientComponent // TypeDefIndex: 10665
{	// Fields
	private bool isVisible; // 0x18
	private Renderer renderer; // 0x20
	private List<DeferredMeshDecal.MaterialLink> materialLinks; // 0x28
	private List<DeferredMeshDecal.InstanceData> instanceData; // 0x30

	// Methods

	// RVA: 0x8F2360 Offset: 0x8F1760 VA: 0x1808F2360
	private void OnEnable() { }

	// RVA: 0x8F2260 Offset: 0x8F1660 VA: 0x1808F2260
	private void OnDisable() { }

	// RVA: 0x8F2180 Offset: 0x8F1580 VA: 0x1808F2180
	private void OnBecameVisible() { }

	// RVA: 0x8F20B0 Offset: 0x8F14B0 VA: 0x1808F20B0
	private void OnBecameInvisible() { }

	// RVA: 0x8F1DF0 Offset: 0x8F11F0 VA: 0x1808F1DF0
	private void CleanupLinks() { }

	// RVA: 0x8F2470 Offset: 0x8F1870 VA: 0x1808F2470
	private void PrepareLinks(Material[] mats) { }

	// RVA: 0x8F1FB0 Offset: 0x8F13B0 VA: 0x1808F1FB0
	public bool IsLinkedToMaterial(Material mat) { }

	// RVA: 0x8F1D10 Offset: 0x8F1110 VA: 0x1808F1D10
	public void AddToCommandBuffer(CommandBuffer cb) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public List<DeferredMeshDecal.InstanceData> GetInstanceData() { }

	// RVA: 0x8F2740 Offset: 0x8F1B40 VA: 0x1808F2740
	public void .ctor() { }

}

public class DeferredMeshDecal.MaterialReplacement // TypeDefIndex: 10666
{	// Fields
	public Material reference; // 0x10
	public Material material; // 0x18
	private int refCount; // 0x20
	private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool; // 0x0

	// Methods

	// RVA: 0x8FF4F0 Offset: 0x8FE8F0 VA: 0x1808FF4F0
	private void .ctor(Material reference) { }

	// RVA: 0x8FF150 Offset: 0x8FE550 VA: 0x1808FF150
	public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference) { }

	// RVA: 0x8FF3A0 Offset: 0x8FE7A0 VA: 0x1808FF3A0
	public void Release() { }

	// RVA: 0x8FF490 Offset: 0x8FE890 VA: 0x1808FF490
	private static void .cctor() { }

}

public struct DeferredMeshDecal.MaterialLink // TypeDefIndex: 10667
{	// Fields
	public DeferredMeshDecal.MaterialReplacement replacement; // 0x0
	public int submeshIndex; // 0x8

	// Methods

	// RVA: 0xF9CD0 Offset: 0xF90D0 VA: 0x1800F9CD0
	public void .ctor(DeferredMeshDecal.MaterialReplacement replacement, int submeshIndex) { }

}

public class DeferredMeshDecal.InstanceData // TypeDefIndex: 10668
{	// Fields
	private Transform transform; // 0x10
	private Material material; // 0x18
	private Mesh mesh; // 0x20
	private int submeshIndex; // 0x28
	private int hash; // 0x2C

	// Properties
	public Material Material { get; }
	public Mesh Mesh { get; }
	public int SubmeshIndex { get; }
	public Matrix4x4 LocalToWorld { get; }

	// Methods

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public Material get_Material() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	public Mesh get_Mesh() { }

	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public int get_SubmeshIndex() { }

	// RVA: 0x8FF100 Offset: 0x8FE500 VA: 0x1808FF100
	public Matrix4x4 get_LocalToWorld() { }

	// RVA: 0x8FEEB0 Offset: 0x8FE2B0 VA: 0x1808FEEB0
	public void .ctor(Renderer renderer, Material material, int submeshIndex) { }

	// RVA: 0x8FEE30 Offset: 0x8FE230 VA: 0x1808FEE30
	private int GenerateHashCode() { }

	// RVA: 0x8FED10 Offset: 0x8FE110 VA: 0x1808FED10 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x5F7BF0 Offset: 0x5F6FF0 VA: 0x1805F7BF0 Slot: 2
	public override int GetHashCode() { }

}

