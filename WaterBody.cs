public class WaterBody : MonoBehaviour // TypeDefIndex: 10596
{	// Fields
	public WaterBodyType Type; // 0x18
	public Renderer Renderer; // 0x20
	public Collider[] Triggers; // 0x28
	public bool IsOcean; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <Transform>k__BackingField; // 0x38
	public WaterBody.FishingTag FishingType; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <MeshFilter>k__BackingField; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Mesh <SharedMesh>k__BackingField; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <Material>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <DepthPass>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <DepthDisplacementPass>k__BackingField; // 0x64
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <OcclusionPass>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <CausticsPass>k__BackingField; // 0x6C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <OcclusionCausticsPass>k__BackingField; // 0x70

	// Properties
	public Transform Transform { get; set; }
	public MeshFilter MeshFilter { get; set; }
	public Mesh SharedMesh { get; set; }
	public Material Material { get; set; }
	public int DepthPass { get; set; }
	public int DepthDisplacementPass { get; set; }
	public int OcclusionPass { get; set; }
	public int CausticsPass { get; set; }
	public int OcclusionCausticsPass { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0
	private void set_Transform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00
	public Transform get_Transform() { }

	// RVA: 0x7E34F0 Offset: 0x7E28F0 VA: 0x1807E34F0
	private void Awake() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	private void set_MeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCCA0 Offset: 0x5DC0A0 VA: 0x1805DCCA0
	public MeshFilter get_MeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	private void set_SharedMesh(Mesh value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC350 Offset: 0x4CB750 VA: 0x1804CC350
	public Mesh get_SharedMesh() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC360 Offset: 0x4CB760 VA: 0x1804CC360
	private void set_Material(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4CC340 Offset: 0x4CB740 VA: 0x1804CC340
	public Material get_Material() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCA0 Offset: 0x58D0A0 VA: 0x18058DCA0
	private void set_DepthPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC10 Offset: 0x58D010 VA: 0x18058DC10
	public int get_DepthPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC80 Offset: 0x58D080 VA: 0x18058DC80
	private void set_DepthDisplacementPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBF0 Offset: 0x58CFF0 VA: 0x18058DBF0
	public int get_DepthDisplacementPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E39B0 Offset: 0x7E2DB0 VA: 0x1807E39B0
	private void set_OcclusionPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E3980 Offset: 0x7E2D80 VA: 0x1807E3980
	public int get_OcclusionPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E3990 Offset: 0x7E2D90 VA: 0x1807E3990
	private void set_CausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E3960 Offset: 0x7E2D60 VA: 0x1807E3960
	public int get_CausticsPass() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E39A0 Offset: 0x7E2DA0 VA: 0x1807E39A0
	private void set_OcclusionCausticsPass(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E3970 Offset: 0x7E2D70 VA: 0x1807E3970
	public int get_OcclusionCausticsPass() { }

	// RVA: 0x7E3580 Offset: 0x7E2980 VA: 0x1807E3580
	private void OnEnable() { }

	// RVA: 0x7E3520 Offset: 0x7E2920 VA: 0x1807E3520
	private void OnDisable() { }

	// RVA: 0x7E3840 Offset: 0x7E2C40 VA: 0x1807E3840
	public void OnOceanLevelChanged(float newLevel) { }

	// RVA: 0x7E3950 Offset: 0x7E2D50 VA: 0x1807E3950
	public void .ctor() { }

}

public enum WaterBody.FishingTag // TypeDefIndex: 10597
{	// Fields
	public int value__; // 0x0
	public const WaterBody.FishingTag MoonPool = 1;
	public const WaterBody.FishingTag River = 2;
	public const WaterBody.FishingTag Ocean = 4;
	public const WaterBody.FishingTag Swamp = 8;

}

