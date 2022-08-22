public class DeferredMeshDecal : MonoBehaviour, IClientComponent // TypeDefIndex: 10665
{	private bool isVisible; // 0x18
	private Renderer renderer; // 0x20
	private List<DeferredMeshDecal.MaterialLink> materialLinks; // 0x28
	private List<DeferredMeshDecal.InstanceData> instanceData; // 0x30


	private void OnEnable() { }

	private void OnDisable() { }

	private void OnBecameVisible() { }

	private void OnBecameInvisible() { }

	private void CleanupLinks() { }

	private void PrepareLinks(Material[] mats) { }

	public bool IsLinkedToMaterial(Material mat) { }

	public void AddToCommandBuffer(CommandBuffer cb) { }

	public List<DeferredMeshDecal.InstanceData> GetInstanceData() { }

	public void .ctor() { }

}

public class DeferredMeshDecal.MaterialReplacement // TypeDefIndex: 10666
{	public Material reference; // 0x10
	public Material material; // 0x18
	private int refCount; // 0x20
	private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool; // 0x0


	private void .ctor(Material reference) { }

	public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference) { }

	public void Release() { }

	private static void .cctor() { }

}

public struct DeferredMeshDecal.MaterialLink // TypeDefIndex: 10667
{	public DeferredMeshDecal.MaterialReplacement replacement; // 0x0
	public int submeshIndex; // 0x8


	public void .ctor(DeferredMeshDecal.MaterialReplacement replacement, int submeshIndex) { }

}

public class DeferredMeshDecal.InstanceData // TypeDefIndex: 10668
{	private Transform transform; // 0x10
	private Material material; // 0x18
	private Mesh mesh; // 0x20
	private int submeshIndex; // 0x28
	private int hash; // 0x2C

	public Material Material { get; }
	public Mesh Mesh { get; }
	public int SubmeshIndex { get; }
	public Matrix4x4 LocalToWorld { get; }


	public Material get_Material() { }

	public Mesh get_Mesh() { }

	public int get_SubmeshIndex() { }

	public Matrix4x4 get_LocalToWorld() { }

	public void .ctor(Renderer renderer, Material material, int submeshIndex) { }

	private int GenerateHashCode() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

}

