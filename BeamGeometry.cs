public class BeamGeometry : MonoBehaviour // TypeDefIndex: 11533
{	// Fields
	private VolumetricLightBeam m_Master; // 0x18
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

	// Properties
	public MeshRenderer meshRenderer { get; set; }
	public MeshFilter meshFilter { get; set; }
	public Material material { get; set; }
	public Mesh coneMesh { get; set; }
	public bool visible { get; set; }
	public int sortingLayerID { get; set; }
	public int sortingOrder { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public MeshRenderer get_meshRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	private void set_meshRenderer(MeshRenderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public MeshFilter get_meshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	private void set_meshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public Material get_material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	private void set_material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public Mesh get_coneMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	private void set_coneMesh(Mesh value) { }

	// RVA: 0x1117AC0 Offset: 0x1116EC0 VA: 0x181117AC0
	public bool get_visible() { }

	// RVA: 0x1117B20 Offset: 0x1116F20 VA: 0x181117B20
	public void set_visible(bool value) { }

	// RVA: 0x1117A80 Offset: 0x1116E80 VA: 0x181117A80
	public int get_sortingLayerID() { }

	// RVA: 0x1117AE0 Offset: 0x1116EE0 VA: 0x181117AE0
	public void set_sortingLayerID(int value) { }

	// RVA: 0x1117AA0 Offset: 0x1116EA0 VA: 0x181117AA0
	public int get_sortingOrder() { }

	// RVA: 0x1117B00 Offset: 0x1116F00 VA: 0x181117B00
	public void set_sortingOrder(int value) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Start() { }

	// RVA: 0x1116550 Offset: 0x1115950 VA: 0x181116550
	private void OnDestroy() { }

	// RVA: 0x1116450 Offset: 0x1115850 VA: 0x181116450
	private static bool IsUsingCustomRenderPipeline() { }

	// RVA: 0x1116690 Offset: 0x1115A90 VA: 0x181116690
	private void OnEnable() { }

	// RVA: 0x1116600 Offset: 0x1115A00 VA: 0x181116600
	private void OnDisable() { }

	// RVA: 0x1116090 Offset: 0x1115490 VA: 0x181116090
	public void Initialize(VolumetricLightBeam master, Shader shader) { }

	// RVA: 0x11167B0 Offset: 0x1115BB0 VA: 0x1811167B0
	public void RegenerateMesh() { }

	// RVA: 0x1115F80 Offset: 0x1115380 VA: 0x181115F80
	private void ComputeLocalMatrix() { }

	// RVA: 0x1116F50 Offset: 0x1116350 VA: 0x181116F50
	public void UpdateMaterialAndBounds() { }

	// RVA: 0x1116AA0 Offset: 0x1115EA0 VA: 0x181116AA0
	public void SetClippingPlane(Plane planeWS) { }

	// RVA: 0x1116A50 Offset: 0x1115E50 VA: 0x181116A50
	public void SetClippingPlaneOff() { }

	// RVA: 0x1116540 Offset: 0x1115940 VA: 0x181116540
	private void OnBeginCameraRendering(ScriptableRenderContext context, Camera cam) { }

	// RVA: 0x1116720 Offset: 0x1115B20 VA: 0x181116720
	private void OnWillRenderObject() { }

	// RVA: 0x1116B90 Offset: 0x1115F90 VA: 0x181116B90
	private void UpdateCameraRelatedProperties(Camera cam) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

