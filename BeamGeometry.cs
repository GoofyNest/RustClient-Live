public class BeamGeometry : MonoBehaviour // TypeDefIndex: 13325
{
	private VolumetricLightBeam m_Master; 
	private Matrix4x4 m_ColorGradientMatrix; 
	private MeshType m_CurrentMeshType; 
	[CompilerGeneratedAttribute] 
	private MeshRenderer <meshRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <meshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <material>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Mesh <coneMesh>k__BackingField; 

	public MeshRenderer meshRenderer { get; set; }
	public MeshFilter meshFilter { get; set; }
	public Material material { get; set; }
	public Mesh coneMesh { get; set; }
	public bool visible { get; set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }


	[CompilerGeneratedAttribute] 
	public MeshRenderer get_meshRenderer() { }

	[CompilerGeneratedAttribute] 
	private void set_meshRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_meshFilter() { }

	[CompilerGeneratedAttribute] 
	private void set_meshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public Material get_material() { }

	[CompilerGeneratedAttribute] 
	private void set_material(Material value) { }

	[CompilerGeneratedAttribute] 
	public Mesh get_coneMesh() { }

	[CompilerGeneratedAttribute] 
	private void set_coneMesh(Mesh value) { }

	public bool get_visible() { }

	public void set_visible(bool value) { }

	public int get_sortingLayerID() { }

	public void set_sortingLayerID(int value) { }

	public int get_sortingOrder() { }

	public void set_sortingOrder(int value) { }

	private void Start() { }

	private void OnDestroy() { }

	private static bool IsUsingCustomRenderPipeline() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public void Initialize(VolumetricLightBeam master, Shader shader) { }

	public void RegenerateMesh() { }

	private void ComputeLocalMatrix() { }

	public void UpdateMaterialAndBounds() { }

	public void SetClippingPlane(Plane planeWS) { }

	public void SetClippingPlaneOff() { }

	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam) { }

	private void OnWillRenderObject() { }

	private void UpdateCameraRelatedProperties(Camera cam) { }

	public void .ctor() { }

}

