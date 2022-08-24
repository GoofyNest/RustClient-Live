public class DeferredMeshDecal : MonoBehaviour, IClientComponent // TypeDefIndex: 10665
{
	private bool isVisible; 
	private Renderer renderer; 
	private List<DeferredMeshDecal.MaterialLink> materialLinks; 
	private List<DeferredMeshDecal.InstanceData> instanceData; 


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
{
	public Material reference; 
	public Material material; 
	private int refCount; 
	private static Dictionary<Material, DeferredMeshDecal.MaterialReplacement> pool; 


private void .ctor(Material reference) { }

public static DeferredMeshDecal.MaterialReplacement Allocate(Material reference) { }

public void Release() { }

private static void .cctor() { }

}

public struct DeferredMeshDecal.MaterialLink // TypeDefIndex: 10667
{
	public DeferredMeshDecal.MaterialReplacement replacement; 
	public int submeshIndex; 


public void .ctor(DeferredMeshDecal.MaterialReplacement replacement, int submeshIndex) { }

}

public class DeferredMeshDecal.InstanceData // TypeDefIndex: 10668
{
	private Transform transform; 
	private Material material; 
	private Mesh mesh; 
	private int submeshIndex; 
	private int hash; 

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

