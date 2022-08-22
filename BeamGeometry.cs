public class BeamGeometry : MonoBehaviour // TypeDefIndex: 11533
{	private VolumetricLightBeam m_Master; // 0x18
	private Matrix4x4 m_ColorGradientMatrix; // 0x20
	private MeshType m_CurrentMeshType; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshRenderer <meshRenderer>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <meshFilter>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <material>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <coneMesh>k__BackingField; // 0x80

	public MeshRenderer meshRenderer { get; set; }
	public MeshFilter meshFilter { get; set; }
	public Material material { get; set; }
	public Mesh coneMesh { get; set; }
	public bool visible { get; set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public MeshRenderer get_meshRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_meshRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public MeshFilter get_meshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_meshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Material get_material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Mesh get_coneMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

