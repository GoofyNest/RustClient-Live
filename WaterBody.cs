public class WaterBody : MonoBehaviour // TypeDefIndex: 10596
{
	public WaterBodyType Type; 
	public Renderer Renderer; 
	public Collider[] Triggers; 
	public bool IsOcean; 
	[CompilerGeneratedAttribute] 
	private Transform <Transform>k__BackingField; 
	public WaterBody.FishingTag FishingType; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <MeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Mesh <SharedMesh>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <Material>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <DepthPass>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <DepthDisplacementPass>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <OcclusionPass>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <CausticsPass>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <OcclusionCausticsPass>k__BackingField; 

public Transform Transform { get; set; }
public MeshFilter MeshFilter { get; set; }
public Mesh SharedMesh { get; set; }
public Material Material { get; set; }
public int DepthPass { get; set; }
public int DepthDisplacementPass { get; set; }
public int OcclusionPass { get; set; }
public int CausticsPass { get; set; }
public int OcclusionCausticsPass { get; set; }


	[CompilerGeneratedAttribute] 
private void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] 
public Transform get_Transform() { }

private void Awake() { }

	[CompilerGeneratedAttribute] 
private void set_MeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
public MeshFilter get_MeshFilter() { }

	[CompilerGeneratedAttribute] 
private void set_SharedMesh(Mesh value) { }

	[CompilerGeneratedAttribute] 
public Mesh get_SharedMesh() { }

	[CompilerGeneratedAttribute] 
private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] 
public Material get_Material() { }

	[CompilerGeneratedAttribute] 
private void set_DepthPass(int value) { }

	[CompilerGeneratedAttribute] 
public int get_DepthPass() { }

	[CompilerGeneratedAttribute] 
private void set_DepthDisplacementPass(int value) { }

	[CompilerGeneratedAttribute] 
public int get_DepthDisplacementPass() { }

	[CompilerGeneratedAttribute] 
private void set_OcclusionPass(int value) { }

	[CompilerGeneratedAttribute] 
public int get_OcclusionPass() { }

	[CompilerGeneratedAttribute] 
private void set_CausticsPass(int value) { }

	[CompilerGeneratedAttribute] 
public int get_CausticsPass() { }

	[CompilerGeneratedAttribute] 
private void set_OcclusionCausticsPass(int value) { }

	[CompilerGeneratedAttribute] 
public int get_OcclusionCausticsPass() { }

private void OnEnable() { }

private void OnDisable() { }

public void OnOceanLevelChanged(float newLevel) { }

public void .ctor() { }

}

public enum WaterBody.FishingTag // TypeDefIndex: 10597
{
	public int value__; 
public const WaterBody.FishingTag MoonPool = 1;
public const WaterBody.FishingTag River = 2;
public const WaterBody.FishingTag Ocean = 4;
public const WaterBody.FishingTag Swamp = 8;

}

