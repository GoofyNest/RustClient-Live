public class TOD_Animation : MonoBehaviour // TypeDefIndex: 8068
{	// Fields
	[TooltipAttribute] // RVA: 0xE6540 Offset: 0xE5940 VA: 0x1800E6540
	[TOD_MinAttribute] // RVA: 0xE6540 Offset: 0xE5940 VA: 0x1800E6540
	public float CameraMovement; // 0x18
	[TooltipAttribute] // RVA: 0xE67C0 Offset: 0xE5BC0 VA: 0x1800E67C0
	[TOD_RangeAttribute] // RVA: 0xE67C0 Offset: 0xE5BC0 VA: 0x1800E67C0
	public float WindDegrees; // 0x1C
	[TooltipAttribute] // RVA: 0xE68B0 Offset: 0xE5CB0 VA: 0x1800E68B0
	[TOD_MinAttribute] // RVA: 0xE68B0 Offset: 0xE5CB0 VA: 0x1800E68B0
	public float WindSpeed; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <CloudUV>k__BackingField; // 0x24
	private TOD_Sky sky; // 0x30

	// Properties
	public Vector3 CloudUV { get; set; }
	public Vector3 OffsetUV { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x106F490 Offset: 0x106E890 VA: 0x18106F490
	public Vector3 get_CloudUV() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x106F670 Offset: 0x106EA70 VA: 0x18106F670
	public void set_CloudUV(Vector3 value) { }

	// RVA: 0x106F4B0 Offset: 0x106E8B0 VA: 0x18106F4B0
	public Vector3 get_OffsetUV() { }

	// RVA: 0x106F1A0 Offset: 0x106E5A0 VA: 0x18106F1A0
	protected void Start() { }

	// RVA: 0x106F250 Offset: 0x106E650 VA: 0x18106F250
	public void Update() { }

	// RVA: 0x106F470 Offset: 0x106E870 VA: 0x18106F470
	public void .ctor() { }

}

public class TOD_MinAttribute : PropertyAttribute // TypeDefIndex: 8069
{	// Fields
	public float min; // 0x10

	// Methods

	// RVA: 0x5BE740 Offset: 0x5BDB40 VA: 0x1805BE740
	public void .ctor(float min) { }

}

public class TOD_MaxAttribute : PropertyAttribute // TypeDefIndex: 8070
{	// Fields
	public float max; // 0x10

	// Methods

	// RVA: 0x5BE740 Offset: 0x5BDB40 VA: 0x1805BE740
	public void .ctor(float max) { }

}

public class TOD_RangeAttribute : PropertyAttribute // TypeDefIndex: 8071
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x762B40 Offset: 0x761F40 VA: 0x180762B40
	public void .ctor(float min, float max) { }

}

public class TOD_Billboard : MonoBehaviour // TypeDefIndex: 8072
{	// Fields
	public float Altitude; // 0x18
	public float Azimuth; // 0x1C
	public float Distance; // 0x20
	public float Size; // 0x24

	// Methods

	// RVA: -1 Offset: -1
	private T GetComponentInParents<T>() { }
	/* GenericInstMethod :
	|
	|-RVA: 0xBDBAD0 Offset: 0xBDAED0 VA: 0x180BDBAD0
	|-TOD_Billboard.GetComponentInParents<object>
	*/

	// RVA: 0x692610 Offset: 0x691A10 VA: 0x180692610
	public void .ctor() { }

}

public class TOD_Camera : MonoBehaviour // TypeDefIndex: 8073
{	// Fields
	public TOD_Sky sky; // 0x18
	public bool DomePosToCamera; // 0x20
	public Vector3 DomePosOffset; // 0x24
	public bool DomeScaleToFarClip; // 0x30
	public float DomeScaleFactor; // 0x34
	private Camera cameraComponent; // 0x38
	private Transform cameraTransform; // 0x40

	// Properties
	public bool HDR { get; }
	public float NearClipPlane { get; }
	public float FarClipPlane { get; }
	public Color BackgroundColor { get; }

	// Methods

	// RVA: 0x10709F0 Offset: 0x106FDF0 VA: 0x1810709F0
	public bool get_HDR() { }

	// RVA: 0x1070A80 Offset: 0x106FE80 VA: 0x181070A80
	public float get_NearClipPlane() { }

	// RVA: 0x1070960 Offset: 0x106FD60 VA: 0x181070960
	public float get_FarClipPlane() { }

	// RVA: 0x10708B0 Offset: 0x106FCB0 VA: 0x1810708B0
	public Color get_BackgroundColor() { }

	// RVA: 0x1070570 Offset: 0x106F970 VA: 0x181070570
	protected void OnValidate() { }

	// RVA: 0x10701C0 Offset: 0x106F5C0 VA: 0x1810701C0
	protected void OnEnable() { }

	// RVA: 0x10705F0 Offset: 0x106F9F0 VA: 0x1810705F0
	protected void Update() { }

	// RVA: 0x1070290 Offset: 0x106F690 VA: 0x181070290
	protected void OnPreCull() { }

	// RVA: 0x1070040 Offset: 0x106F440 VA: 0x181070040
	private TOD_Sky FindSky(bool fallback = False) { }

	// RVA: 0x106FFA0 Offset: 0x106F3A0 VA: 0x18106FFA0
	public void DoDomeScaleToFarClip() { }

	// RVA: 0x106FE10 Offset: 0x106F210 VA: 0x18106FE10
	public void DoDomePosToCamera() { }

	// RVA: 0x1070830 Offset: 0x106FC30 VA: 0x181070830
	public void .ctor() { }

}

public class TOD_Components : MonoBehaviour // TypeDefIndex: 8074
{	// Fields
	public GameObject Space; // 0x18
	public GameObject Stars; // 0x20
	public GameObject Sun; // 0x28
	public GameObject Moon; // 0x30
	public GameObject Atmosphere; // 0x38
	public GameObject Clear; // 0x40
	public GameObject Clouds; // 0x48
	public GameObject Billboards; // 0x50
	public GameObject Light; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <DomeTransform>k__BackingField; // 0x60
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <SpaceTransform>k__BackingField; // 0x68
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <StarTransform>k__BackingField; // 0x70
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <SunTransform>k__BackingField; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <MoonTransform>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <AtmosphereTransform>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <ClearTransform>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <CloudTransform>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <BillboardTransform>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Transform <LightTransform>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <SpaceRenderer>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <StarRenderer>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <SunRenderer>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <MoonRenderer>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <AtmosphereRenderer>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <ClearRenderer>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer <CloudRenderer>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Renderer[] <BillboardRenderers>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <SpaceMeshFilter>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <StarMeshFilter>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <SunMeshFilter>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <MoonMeshFilter>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <AtmosphereMeshFilter>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <ClearMeshFilter>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter <CloudMeshFilter>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private MeshFilter[] <BillboardMeshFilters>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <SpaceMaterial>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <StarMaterial>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <SunMaterial>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <MoonMaterial>k__BackingField; // 0x148
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <AtmosphereMaterial>k__BackingField; // 0x150
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <ClearMaterial>k__BackingField; // 0x158
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material <CloudMaterial>k__BackingField; // 0x160
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Material[] <BillboardMaterials>k__BackingField; // 0x168
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Light <LightSource>k__BackingField; // 0x170
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Sky <Sky>k__BackingField; // 0x178
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Animation <Animation>k__BackingField; // 0x180
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Time <Time>k__BackingField; // 0x188
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Camera <Camera>k__BackingField; // 0x190
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Rays <Rays>k__BackingField; // 0x198
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Scattering <Scattering>k__BackingField; // 0x1A0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Shadows <Shadows>k__BackingField; // 0x1A8

	// Properties
	public Transform DomeTransform { get; set; }
	public Transform SpaceTransform { get; set; }
	public Transform StarTransform { get; set; }
	public Transform SunTransform { get; set; }
	public Transform MoonTransform { get; set; }
	public Transform AtmosphereTransform { get; set; }
	public Transform ClearTransform { get; set; }
	public Transform CloudTransform { get; set; }
	public Transform BillboardTransform { get; set; }
	public Transform LightTransform { get; set; }
	public Renderer SpaceRenderer { get; set; }
	public Renderer StarRenderer { get; set; }
	public Renderer SunRenderer { get; set; }
	public Renderer MoonRenderer { get; set; }
	public Renderer AtmosphereRenderer { get; set; }
	public Renderer ClearRenderer { get; set; }
	public Renderer CloudRenderer { get; set; }
	public Renderer[] BillboardRenderers { get; set; }
	public MeshFilter SpaceMeshFilter { get; set; }
	public MeshFilter StarMeshFilter { get; set; }
	public MeshFilter SunMeshFilter { get; set; }
	public MeshFilter MoonMeshFilter { get; set; }
	public MeshFilter AtmosphereMeshFilter { get; set; }
	public MeshFilter ClearMeshFilter { get; set; }
	public MeshFilter CloudMeshFilter { get; set; }
	public MeshFilter[] BillboardMeshFilters { get; set; }
	public Material SpaceMaterial { get; set; }
	public Material StarMaterial { get; set; }
	public Material SunMaterial { get; set; }
	public Material MoonMaterial { get; set; }
	public Material AtmosphereMaterial { get; set; }
	public Material ClearMaterial { get; set; }
	public Material CloudMaterial { get; set; }
	public Material[] BillboardMaterials { get; set; }
	public Light LightSource { get; set; }
	public TOD_Sky Sky { get; set; }
	public TOD_Animation Animation { get; set; }
	public TOD_Time Time { get; set; }
	public TOD_Camera Camera { get; set; }
	public TOD_Rays Rays { get; set; }
	public TOD_Scattering Scattering { get; set; }
	public TOD_Shadows Shadows { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public Transform get_DomeTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	public void set_DomeTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5334F0 Offset: 0x5328F0 VA: 0x1805334F0
	public Transform get_SpaceTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5336F0 Offset: 0x532AF0 VA: 0x1805336F0
	public void set_SpaceTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC30 Offset: 0x58D030 VA: 0x18058DC30
	public Transform get_StarTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCC0 Offset: 0x58D0C0 VA: 0x18058DCC0
	public void set_StarTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E4EC0 Offset: 0x4E42C0 VA: 0x1804E4EC0
	public Transform get_SunTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E51E0 Offset: 0x4E45E0 VA: 0x1804E51E0
	public void set_SunTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC40 Offset: 0x58D040 VA: 0x18058DC40
	public Transform get_MoonTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DCD0 Offset: 0x58D0D0 VA: 0x18058DCD0
	public void set_MoonTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public Transform get_AtmosphereTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC60 Offset: 0x58D060 VA: 0x18058DC60
	public void set_AtmosphereTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E09F0 Offset: 0x4DFDF0 VA: 0x1804E09F0
	public Transform get_ClearTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E0A00 Offset: 0x4DFE00 VA: 0x1804E0A00
	public void set_ClearTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBE0 Offset: 0x58CFE0 VA: 0x18058DBE0
	public Transform get_CloudTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC70 Offset: 0x58D070 VA: 0x18058DC70
	public void set_CloudTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DBC0 Offset: 0x58CFC0 VA: 0x18058DBC0
	public Transform get_BillboardTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x58DC50 Offset: 0x58D050 VA: 0x18058DC50
	public void set_BillboardTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public Transform get_LightTransform() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53340 Offset: 0xC52740 VA: 0x180C53340
	public void set_LightTransform(Transform value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public Renderer get_SpaceRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE00 Offset: 0xA2B200 VA: 0x180A2BE00
	public void set_SpaceRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7AACD0 Offset: 0x7AA0D0 VA: 0x1807AACD0
	public Renderer get_StarRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE10 Offset: 0xA2B210 VA: 0x180A2BE10
	public void set_StarRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104A060 Offset: 0x1049460 VA: 0x18104A060
	public Renderer get_SunRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEF5DD0 Offset: 0xEF51D0 VA: 0x180EF5DD0
	public void set_SunRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B0A0 Offset: 0xD9A4A0 VA: 0x180D9B0A0
	public Renderer get_MoonRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9B480 Offset: 0xD9A880 VA: 0x180D9B480
	public void set_MoonRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53130 Offset: 0xC52530 VA: 0x180C53130
	public Renderer get_AtmosphereRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53280 Offset: 0xC52680 VA: 0x180C53280
	public void set_AtmosphereRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD9A430 Offset: 0xD99830 VA: 0x180D9A430
	public Renderer get_ClearRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD300D0 Offset: 0xD2F4D0 VA: 0x180D300D0
	public void set_ClearRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD40 Offset: 0x4EB140 VA: 0x1804EBD40
	public Renderer get_CloudRenderer() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4EBD50 Offset: 0x4EB150 VA: 0x1804EBD50
	public void set_CloudRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E830 Offset: 0x94DC30 VA: 0x18094E830
	public Renderer[] get_BillboardRenderers() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E8B0 Offset: 0x94DCB0 VA: 0x18094E8B0
	public void set_BillboardRenderers(Renderer[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53210 Offset: 0xC52610 VA: 0x180C53210
	public MeshFilter get_SpaceMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10715B0 Offset: 0x10709B0 VA: 0x1810715B0
	public void set_SpaceMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB0A550 Offset: 0xB09950 VA: 0x180B0A550
	public MeshFilter get_StarMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10715D0 Offset: 0x10709D0 VA: 0x1810715D0
	public void set_StarMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09500 Offset: 0xA08900 VA: 0x180A09500
	public MeshFilter get_SunMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA09800 Offset: 0xA08C00 VA: 0x180A09800
	public void set_SunMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62850 Offset: 0xC61C50 VA: 0x180C62850
	public MeshFilter get_MoonMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071570 Offset: 0x1070970 VA: 0x181071570
	public void set_MoonMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E420 Offset: 0x94D820 VA: 0x18094E420
	public MeshFilter get_AtmosphereMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E870 Offset: 0x94DC70 VA: 0x18094E870
	public void set_AtmosphereMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE610C0 Offset: 0xE604C0 VA: 0x180E610C0
	public MeshFilter get_ClearMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xE60780 Offset: 0xE5FB80 VA: 0x180E60780
	public void set_ClearMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7F5E00 Offset: 0x7F5200 VA: 0x1807F5E00
	public MeshFilter get_CloudMeshFilter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53320 Offset: 0xC52720 VA: 0x180C53320
	public void set_CloudMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE070 Offset: 0x4BD470 VA: 0x1804BE070
	public MeshFilter[] get_BillboardMeshFilters() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BE140 Offset: 0x4BD540 VA: 0x1804BE140
	public void set_BillboardMeshFilters(MeshFilter[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71AF80 Offset: 0x71A380 VA: 0x18071AF80
	public Material get_SpaceMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x71B010 Offset: 0x71A410 VA: 0x18071B010
	public void set_SpaceMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xBC2A40 Offset: 0xBC1E40 VA: 0x180BC2A40
	public Material get_StarMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10715C0 Offset: 0x10709C0 VA: 0x1810715C0
	public void set_StarMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD5C900 Offset: 0xD5BD00 VA: 0x180D5C900
	public Material get_SunMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD5C910 Offset: 0xD5BD10 VA: 0x180D5C910
	public void set_SunMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10714D0 Offset: 0x10708D0 VA: 0x1810714D0
	public Material get_MoonMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071560 Offset: 0x1070960 VA: 0x181071560
	public void set_MoonMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10714C0 Offset: 0x10708C0 VA: 0x1810714C0
	public Material get_AtmosphereMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071510 Offset: 0x1070910 VA: 0x181071510
	public void set_AtmosphereMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62810 Offset: 0xC61C10 VA: 0x180C62810
	public Material get_ClearMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071530 Offset: 0x1070930 VA: 0x181071530
	public void set_ClearMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7FEF40 Offset: 0x7FE340 VA: 0x1807FEF40
	public Material get_CloudMaterial() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071540 Offset: 0x1070940 VA: 0x181071540
	public void set_CloudMaterial(Material value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA1B2D0 Offset: 0xA1A6D0 VA: 0x180A1B2D0
	public Material[] get_BillboardMaterials() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071520 Offset: 0x1070920 VA: 0x181071520
	public void set_BillboardMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8A99E0 Offset: 0x8A8DE0 VA: 0x1808A99E0
	public Light get_LightSource() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071550 Offset: 0x1070950 VA: 0x181071550
	public void set_LightSource(Light value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62840 Offset: 0xC61C40 VA: 0x180C62840
	public TOD_Sky get_Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD3E6F0 Offset: 0xD3DAF0 VA: 0x180D3E6F0
	public void set_Sky(TOD_Sky value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62820 Offset: 0xC61C20 VA: 0x180C62820
	public TOD_Animation get_Animation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071500 Offset: 0x1070900 VA: 0x181071500
	public void set_Animation(TOD_Animation value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB09E20 Offset: 0xB09220 VA: 0x180B09E20
	public TOD_Time get_Time() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10715E0 Offset: 0x10709E0 VA: 0x1810715E0
	public void set_Time(TOD_Time value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53220 Offset: 0xC52620 VA: 0x180C53220
	public TOD_Camera get_Camera() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53330 Offset: 0xC52730 VA: 0x180C53330
	public void set_Camera(TOD_Camera value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xAD42C0 Offset: 0xAD36C0 VA: 0x180AD42C0
	public TOD_Rays get_Rays() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071580 Offset: 0x1070980 VA: 0x181071580
	public void set_Rays(TOD_Rays value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10714E0 Offset: 0x10708E0 VA: 0x1810714E0
	public TOD_Scattering get_Scattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1071590 Offset: 0x1070990 VA: 0x181071590
	public void set_Scattering(TOD_Scattering value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10714F0 Offset: 0x10708F0 VA: 0x1810714F0
	public TOD_Shadows get_Shadows() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x10715A0 Offset: 0x10709A0 VA: 0x1810715A0
	public void set_Shadows(TOD_Shadows value) { }

	// RVA: 0x1070B60 Offset: 0x106FF60 VA: 0x181070B60
	public void Initialize() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public enum TOD_MoonPositionType // TypeDefIndex: 8075
{	// Fields
	public int value__; // 0x0
	public const TOD_MoonPositionType OppositeToSun = 0;
	public const TOD_MoonPositionType Realistic = 1;

}

public enum TOD_StarsPositionType // TypeDefIndex: 8076
{	// Fields
	public int value__; // 0x0
	public const TOD_StarsPositionType Static = 0;
	public const TOD_StarsPositionType Rotating = 1;

}

public enum TOD_FogType // TypeDefIndex: 8077
{	// Fields
	public int value__; // 0x0
	public const TOD_FogType None = 0;
	public const TOD_FogType Atmosphere = 1;
	public const TOD_FogType Directional = 2;
	public const TOD_FogType Gradient = 3;

}

public enum TOD_AmbientType // TypeDefIndex: 8078
{	// Fields
	public int value__; // 0x0
	public const TOD_AmbientType None = 0;
	public const TOD_AmbientType Color = 1;
	public const TOD_AmbientType Gradient = 2;
	public const TOD_AmbientType Spherical = 3;

}

public enum TOD_ReflectionType // TypeDefIndex: 8079
{	// Fields
	public int value__; // 0x0
	public const TOD_ReflectionType None = 0;
	public const TOD_ReflectionType Cubemap = 1;

}

public enum TOD_ColorSpaceType // TypeDefIndex: 8080
{	// Fields
	public int value__; // 0x0
	public const TOD_ColorSpaceType Auto = 0;
	public const TOD_ColorSpaceType Linear = 1;
	public const TOD_ColorSpaceType Gamma = 2;

}

public enum TOD_ColorRangeType // TypeDefIndex: 8081
{	// Fields
	public int value__; // 0x0
	public const TOD_ColorRangeType Auto = 0;
	public const TOD_ColorRangeType HDR = 1;
	public const TOD_ColorRangeType LDR = 2;

}

public enum TOD_ColorOutputType // TypeDefIndex: 8082
{	// Fields
	public int value__; // 0x0
	public const TOD_ColorOutputType Raw = 0;
	public const TOD_ColorOutputType Dithered = 1;

}

public enum TOD_CloudQualityType // TypeDefIndex: 8083
{	// Fields
	public int value__; // 0x0
	public const TOD_CloudQualityType Low = 0;
	public const TOD_CloudQualityType Medium = 1;
	public const TOD_CloudQualityType High = 2;

}

public enum TOD_MeshQualityType // TypeDefIndex: 8084
{	// Fields
	public int value__; // 0x0
	public const TOD_MeshQualityType Low = 0;
	public const TOD_MeshQualityType Medium = 1;
	public const TOD_MeshQualityType High = 2;

}

public enum TOD_StarQualityType // TypeDefIndex: 8085
{	// Fields
	public int value__; // 0x0
	public const TOD_StarQualityType Low = 0;
	public const TOD_StarQualityType Medium = 1;
	public const TOD_StarQualityType High = 2;

}

public enum TOD_SkyQualityType // TypeDefIndex: 8086
{	// Fields
	public int value__; // 0x0
	public const TOD_SkyQualityType PerVertex = 0;
	public const TOD_SkyQualityType PerPixel = 1;

}

public abstract class TOD_ImageEffect : MonoBehaviour // TypeDefIndex: 8087
{	// Fields
	public TOD_Sky sky; // 0x18
	protected Camera cam; // 0x20
	private bool supportsDepth; // 0x28
	private bool supportsHdr; // 0x29
	private static Vector3[] frustumCornersArray; // 0x0

	// Methods

	// RVA: 0x1071D20 Offset: 0x1071120 VA: 0x181071D20
	protected Material CreateMaterial(Shader shader) { }

	// RVA: 0x10720B0 Offset: 0x10714B0 VA: 0x1810720B0
	private TOD_Sky FindSky(bool fallback = False) { }

	// RVA: 0x10719A0 Offset: 0x1070DA0 VA: 0x1810719A0
	protected void Awake() { }

	// RVA: 0x1071AA0 Offset: 0x1070EA0 VA: 0x181071AA0
	protected bool CheckSupport(bool needDepth = False, bool needHdr = False) { }

	// RVA: 0x8C57F0 Offset: 0x8C4BF0 VA: 0x1808C57F0
	protected void DrawBorder(RenderTexture dest, Material material) { }

	// RVA: 0x1072230 Offset: 0x1071630 VA: 0x181072230
	protected Matrix4x4 FrustumCorners() { }

	// RVA: 0x10726E0 Offset: 0x1071AE0 VA: 0x1810726E0
	protected RenderTexture GetSkyMask(RenderTexture source, Material skyMaskMaterial, Material screenClearMaterial, TOD_ImageEffect.ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

	// RVA: 0x1072C90 Offset: 0x1072090 VA: 0x181072C90
	private static void .cctor() { }

}

public enum TOD_ImageEffect.ResolutionType // TypeDefIndex: 8088
{	// Fields
	public int value__; // 0x0
	public const TOD_ImageEffect.ResolutionType Low = 0;
	public const TOD_ImageEffect.ResolutionType Normal = 1;
	public const TOD_ImageEffect.ResolutionType High = 2;

}

public class TOD_Parameters // TypeDefIndex: 8089
{	// Fields
	public TOD_CycleParameters Cycle; // 0x10
	public TOD_WorldParameters World; // 0x18
	public TOD_AtmosphereParameters Atmosphere; // 0x20
	public TOD_DayParameters Day; // 0x28
	public TOD_NightParameters Night; // 0x30
	public TOD_SunParameters Sun; // 0x38
	public TOD_MoonParameters Moon; // 0x40
	public TOD_LightParameters Light; // 0x48
	public TOD_StarParameters Stars; // 0x50
	public TOD_CloudParameters Clouds; // 0x58
	public TOD_FogParameters Fog; // 0x60
	public TOD_AmbientParameters Ambient; // 0x68
	public TOD_ReflectionParameters Reflection; // 0x70

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x10736C0 Offset: 0x1072AC0 VA: 0x1810736C0
	public void .ctor(TOD_Sky sky) { }

	// RVA: 0x10735B0 Offset: 0x10729B0 VA: 0x1810735B0
	public void ToSky(TOD_Sky sky) { }

}

public class TOD_CycleParameters // TypeDefIndex: 8090
{	// Fields
	[TooltipAttribute] // RVA: 0xEFF20 Offset: 0xEF320 VA: 0x1800EFF20
	public float Hour; // 0x10
	[TooltipAttribute] // RVA: 0xEFF50 Offset: 0xEF350 VA: 0x1800EFF50
	public int Day; // 0x14
	[TooltipAttribute] // RVA: 0xF0020 Offset: 0xEF420 VA: 0x1800F0020
	public int Month; // 0x18
	[TooltipAttribute] // RVA: 0xF0170 Offset: 0xEF570 VA: 0x1800F0170
	[TOD_RangeAttribute] // RVA: 0xF0170 Offset: 0xEF570 VA: 0x1800F0170
	public int Year; // 0x1C

	// Properties
	public DateTime DateTime { get; set; }
	public long Ticks { get; set; }

	// Methods

	// RVA: 0x1071620 Offset: 0x1070A20 VA: 0x181071620
	public DateTime get_DateTime() { }

	// RVA: 0x1071790 Offset: 0x1070B90 VA: 0x181071790
	public void set_DateTime(DateTime value) { }

	// RVA: 0x10716D0 Offset: 0x1070AD0 VA: 0x1810716D0
	public long get_Ticks() { }

	// RVA: 0x1071870 Offset: 0x1070C70 VA: 0x181071870
	public void set_Ticks(long value) { }

	// RVA: 0x10715F0 Offset: 0x10709F0 VA: 0x1810715F0
	public void .ctor() { }

}

public class TOD_WorldParameters // TypeDefIndex: 8091
{	// Fields
	[TooltipAttribute] // RVA: 0xF0240 Offset: 0xEF640 VA: 0x1800F0240
	[RangeAttribute] // RVA: 0xF0240 Offset: 0xEF640 VA: 0x1800F0240
	public float Latitude; // 0x10
	[TooltipAttribute] // RVA: 0xF0430 Offset: 0xEF830 VA: 0x1800F0430
	[RangeAttribute] // RVA: 0xF0430 Offset: 0xEF830 VA: 0x1800F0430
	public float Longitude; // 0x14
	[TooltipAttribute] // RVA: 0xF05C0 Offset: 0xEF9C0 VA: 0x1800F05C0
	[RangeAttribute] // RVA: 0xF05C0 Offset: 0xEF9C0 VA: 0x1800F05C0
	public float UTC; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class TOD_AtmosphereParameters // TypeDefIndex: 8092
{	// Fields
	[TooltipAttribute] // RVA: 0xF0740 Offset: 0xEFB40 VA: 0x1800F0740
	[TOD_MinAttribute] // RVA: 0xF0740 Offset: 0xEFB40 VA: 0x1800F0740
	public float RayleighMultiplier; // 0x10
	[TooltipAttribute] // RVA: 0xF0970 Offset: 0xEFD70 VA: 0x1800F0970
	[TOD_MinAttribute] // RVA: 0xF0970 Offset: 0xEFD70 VA: 0x1800F0970
	public float MieMultiplier; // 0x14
	[TooltipAttribute] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	[TOD_MinAttribute] // RVA: 0xF0C20 Offset: 0xF0020 VA: 0x1800F0C20
	public float Brightness; // 0x18
	[TooltipAttribute] // RVA: 0xF0D80 Offset: 0xF0180 VA: 0x1800F0D80
	[TOD_MinAttribute] // RVA: 0xF0D80 Offset: 0xF0180 VA: 0x1800F0D80
	public float Contrast; // 0x1C
	[TooltipAttribute] // RVA: 0x6F470 Offset: 0x6E870 VA: 0x18006F470
	[TOD_RangeAttribute] // RVA: 0x6F470 Offset: 0x6E870 VA: 0x18006F470
	public float Directionality; // 0x20
	[TooltipAttribute] // RVA: 0x6F5F0 Offset: 0x6E9F0 VA: 0x18006F5F0
	[TOD_RangeAttribute] // RVA: 0x6F5F0 Offset: 0x6E9F0 VA: 0x18006F5F0
	public float Fogginess; // 0x24

	// Methods

	// RVA: 0x106F680 Offset: 0x106EA80 VA: 0x18106F680
	public void .ctor() { }

}

public class TOD_DayParameters // TypeDefIndex: 8093
{	// Fields
	[TooltipAttribute] // RVA: 0x6FC00 Offset: 0x6F000 VA: 0x18006FC00
	public Gradient SunColor; // 0x10
	[TooltipAttribute] // RVA: 0x6FD30 Offset: 0x6F130 VA: 0x18006FD30
	public Gradient LightColor; // 0x18
	[TooltipAttribute] // RVA: 0x6FE80 Offset: 0x6F280 VA: 0x18006FE80
	public Gradient RayColor; // 0x20
	[TooltipAttribute] // RVA: 0x70050 Offset: 0x6F450 VA: 0x180070050
	public Gradient SkyColor; // 0x28
	[TooltipAttribute] // RVA: 0x70120 Offset: 0x6F520 VA: 0x180070120
	public Gradient CloudColor; // 0x30
	[TooltipAttribute] // RVA: 0x70320 Offset: 0x6F720 VA: 0x180070320
	public Gradient FogColor; // 0x38
	[TooltipAttribute] // RVA: 0x703C0 Offset: 0x6F7C0 VA: 0x1800703C0
	public Gradient AmbientColor; // 0x40
	[TooltipAttribute] // RVA: 0x704B0 Offset: 0x6F8B0 VA: 0x1800704B0
	[TOD_MinAttribute] // RVA: 0x704B0 Offset: 0x6F8B0 VA: 0x1800704B0
	public float LightIntensity; // 0x48
	[TooltipAttribute] // RVA: 0x705C0 Offset: 0x6F9C0 VA: 0x1800705C0
	[RangeAttribute] // RVA: 0x705C0 Offset: 0x6F9C0 VA: 0x1800705C0
	public float ShadowStrength; // 0x4C
	[TooltipAttribute] // RVA: 0x70710 Offset: 0x6FB10 VA: 0x180070710
	[RangeAttribute] // RVA: 0x70710 Offset: 0x6FB10 VA: 0x180070710
	public float AmbientMultiplier; // 0x50
	[TooltipAttribute] // RVA: 0x708B0 Offset: 0x6FCB0 VA: 0x1800708B0
	[RangeAttribute] // RVA: 0x708B0 Offset: 0x6FCB0 VA: 0x1800708B0
	public float ReflectionMultiplier; // 0x54

	// Methods

	// RVA: 0x1071960 Offset: 0x1070D60 VA: 0x181071960
	public void .ctor() { }

}

public class TOD_NightParameters // TypeDefIndex: 8094
{	// Fields
	[TooltipAttribute] // RVA: 0x70A30 Offset: 0x6FE30 VA: 0x180070A30
	public Gradient MoonColor; // 0x10
	[TooltipAttribute] // RVA: 0x70B30 Offset: 0x6FF30 VA: 0x180070B30
	public Gradient LightColor; // 0x18
	[TooltipAttribute] // RVA: 0x70CA0 Offset: 0x700A0 VA: 0x180070CA0
	public Gradient RayColor; // 0x20
	[TooltipAttribute] // RVA: 0x70DD0 Offset: 0x701D0 VA: 0x180070DD0
	public Gradient SkyColor; // 0x28
	[TooltipAttribute] // RVA: 0x70F60 Offset: 0x70360 VA: 0x180070F60
	public Gradient CloudColor; // 0x30
	[TooltipAttribute] // RVA: 0x710B0 Offset: 0x704B0 VA: 0x1800710B0
	public Gradient FogColor; // 0x38
	[TooltipAttribute] // RVA: 0x71180 Offset: 0x70580 VA: 0x180071180
	public Gradient AmbientColor; // 0x40
	[TooltipAttribute] // RVA: 0x704B0 Offset: 0x6F8B0 VA: 0x1800704B0
	[TOD_MinAttribute] // RVA: 0x704B0 Offset: 0x6F8B0 VA: 0x1800704B0
	public float LightIntensity; // 0x48
	[TooltipAttribute] // RVA: 0x705C0 Offset: 0x6F9C0 VA: 0x1800705C0
	[RangeAttribute] // RVA: 0x705C0 Offset: 0x6F9C0 VA: 0x1800705C0
	public float ShadowStrength; // 0x4C
	[TooltipAttribute] // RVA: 0x70710 Offset: 0x6FB10 VA: 0x180070710
	[RangeAttribute] // RVA: 0x70710 Offset: 0x6FB10 VA: 0x180070710
	public float AmbientMultiplier; // 0x50
	[TooltipAttribute] // RVA: 0x708B0 Offset: 0x6FCB0 VA: 0x1800708B0
	[RangeAttribute] // RVA: 0x708B0 Offset: 0x6FCB0 VA: 0x1800708B0
	public float ReflectionMultiplier; // 0x54

	// Methods

	// RVA: 0x1073580 Offset: 0x1072980 VA: 0x181073580
	public void .ctor() { }

}

public class TOD_SunParameters // TypeDefIndex: 8095
{	// Fields
	[TooltipAttribute] // RVA: 0x71900 Offset: 0x70D00 VA: 0x180071900
	[TOD_MinAttribute] // RVA: 0x71900 Offset: 0x70D00 VA: 0x180071900
	public float MeshSize; // 0x10
	[TooltipAttribute] // RVA: 0x71A10 Offset: 0x70E10 VA: 0x180071A10
	[TOD_MinAttribute] // RVA: 0x71A10 Offset: 0x70E10 VA: 0x180071A10
	public float MeshBrightness; // 0x14
	[TooltipAttribute] // RVA: 0x71C40 Offset: 0x71040 VA: 0x180071C40
	[TOD_MinAttribute] // RVA: 0x71C40 Offset: 0x71040 VA: 0x180071C40
	public float MeshContrast; // 0x18

	// Methods

	// RVA: 0x12D57A0 Offset: 0x12D4BA0 VA: 0x1812D57A0
	public void .ctor() { }

}

public class TOD_MoonParameters // TypeDefIndex: 8096
{	// Fields
	[TooltipAttribute] // RVA: 0x71E10 Offset: 0x71210 VA: 0x180071E10
	[TOD_MinAttribute] // RVA: 0x71E10 Offset: 0x71210 VA: 0x180071E10
	public float MeshSize; // 0x10
	[TooltipAttribute] // RVA: 0x72070 Offset: 0x71470 VA: 0x180072070
	[TOD_MinAttribute] // RVA: 0x72070 Offset: 0x71470 VA: 0x180072070
	public float MeshBrightness; // 0x14
	[TooltipAttribute] // RVA: 0x72230 Offset: 0x71630 VA: 0x180072230
	[TOD_MinAttribute] // RVA: 0x72230 Offset: 0x71630 VA: 0x180072230
	public float MeshContrast; // 0x18
	[TooltipAttribute] // RVA: 0x724A0 Offset: 0x718A0 VA: 0x1800724A0
	[TOD_MinAttribute] // RVA: 0x724A0 Offset: 0x718A0 VA: 0x1800724A0
	public float HaloSize; // 0x1C
	[TooltipAttribute] // RVA: 0x73950 Offset: 0x72D50 VA: 0x180073950
	[TOD_MinAttribute] // RVA: 0x73950 Offset: 0x72D50 VA: 0x180073950
	public float HaloBrightness; // 0x20
	[TooltipAttribute] // RVA: 0x73AC0 Offset: 0x72EC0 VA: 0x180073AC0
	public TOD_MoonPositionType Position; // 0x24

	// Methods

	// RVA: 0x1073540 Offset: 0x1072940 VA: 0x181073540
	public void .ctor() { }

}

public class TOD_StarParameters // TypeDefIndex: 8097
{	// Fields
	[TooltipAttribute] // RVA: 0x73C90 Offset: 0x73090 VA: 0x180073C90
	[TOD_MinAttribute] // RVA: 0x73C90 Offset: 0x73090 VA: 0x180073C90
	public float Size; // 0x10
	[TooltipAttribute] // RVA: 0x73E20 Offset: 0x73220 VA: 0x180073E20
	[TOD_MinAttribute] // RVA: 0x73E20 Offset: 0x73220 VA: 0x180073E20
	public float Brightness; // 0x14
	[TooltipAttribute] // RVA: 0x75390 Offset: 0x74790 VA: 0x180075390
	public TOD_StarsPositionType Position; // 0x18

	// Methods

	// RVA: 0x12D5780 Offset: 0x12D4B80 VA: 0x1812D5780
	public void .ctor() { }

}

public class TOD_CloudParameters // TypeDefIndex: 8098
{	// Fields
	[TooltipAttribute] // RVA: 0x75490 Offset: 0x74890 VA: 0x180075490
	[TOD_MinAttribute] // RVA: 0x75490 Offset: 0x74890 VA: 0x180075490
	public float Size; // 0x10
	[TooltipAttribute] // RVA: 0x75630 Offset: 0x74A30 VA: 0x180075630
	[TOD_RangeAttribute] // RVA: 0x75630 Offset: 0x74A30 VA: 0x180075630
	public float Opacity; // 0x14
	[TooltipAttribute] // RVA: 0x757F0 Offset: 0x74BF0 VA: 0x1800757F0
	[TOD_RangeAttribute] // RVA: 0x757F0 Offset: 0x74BF0 VA: 0x1800757F0
	public float Coverage; // 0x18
	[TooltipAttribute] // RVA: 0x75960 Offset: 0x74D60 VA: 0x180075960
	[TOD_RangeAttribute] // RVA: 0x75960 Offset: 0x74D60 VA: 0x180075960
	public float Sharpness; // 0x1C
	[TooltipAttribute] // RVA: 0x75C50 Offset: 0x75050 VA: 0x180075C50
	[TOD_RangeAttribute] // RVA: 0x75C50 Offset: 0x75050 VA: 0x180075C50
	public float Coloring; // 0x20
	[TooltipAttribute] // RVA: 0x75E10 Offset: 0x75210 VA: 0x180075E10
	[TOD_RangeAttribute] // RVA: 0x75E10 Offset: 0x75210 VA: 0x180075E10
	public float Attenuation; // 0x24
	[TooltipAttribute] // RVA: 0x75F60 Offset: 0x75360 VA: 0x180075F60
	[TOD_RangeAttribute] // RVA: 0x75F60 Offset: 0x75360 VA: 0x180075F60
	public float Saturation; // 0x28
	[TooltipAttribute] // RVA: 0x76070 Offset: 0x75470 VA: 0x180076070
	[TOD_MinAttribute] // RVA: 0x76070 Offset: 0x75470 VA: 0x180076070
	public float Scattering; // 0x2C
	[TooltipAttribute] // RVA: 0x76150 Offset: 0x75550 VA: 0x180076150
	[TOD_MinAttribute] // RVA: 0x76150 Offset: 0x75550 VA: 0x180076150
	public float Brightness; // 0x30

	// Methods

	// RVA: 0x1070B10 Offset: 0x106FF10 VA: 0x181070B10
	public void .ctor() { }

}

public class TOD_LightParameters // TypeDefIndex: 8099
{	// Fields
	[TooltipAttribute] // RVA: 0x76310 Offset: 0x75710 VA: 0x180076310
	[TOD_MinAttribute] // RVA: 0x76310 Offset: 0x75710 VA: 0x180076310
	public float UpdateInterval; // 0x10
	[TooltipAttribute] // RVA: 0x76470 Offset: 0x75870 VA: 0x180076470
	[TOD_RangeAttribute] // RVA: 0x76470 Offset: 0x75870 VA: 0x180076470
	public float MinimumHeight; // 0x14

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

public class TOD_FogParameters // TypeDefIndex: 8100
{	// Fields
	[TooltipAttribute] // RVA: 0x76620 Offset: 0x75A20 VA: 0x180076620
	public TOD_FogType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76710 Offset: 0x75B10 VA: 0x180076710
	[TOD_RangeAttribute] // RVA: 0x76710 Offset: 0x75B10 VA: 0x180076710
	public float HeightBias; // 0x14

	// Methods

	// RVA: 0x1071990 Offset: 0x1070D90 VA: 0x181071990
	public void .ctor() { }

}

public class TOD_AmbientParameters // TypeDefIndex: 8101
{	// Fields
	[TooltipAttribute] // RVA: 0x76940 Offset: 0x75D40 VA: 0x180076940
	public TOD_AmbientType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76A60 Offset: 0x75E60 VA: 0x180076A60
	[TOD_MinAttribute] // RVA: 0x76A60 Offset: 0x75E60 VA: 0x180076A60
	public float Saturation; // 0x14
	[TooltipAttribute] // RVA: 0x76C90 Offset: 0x76090 VA: 0x180076C90
	[TOD_MinAttribute] // RVA: 0x76C90 Offset: 0x76090 VA: 0x180076C90
	public float UpdateInterval; // 0x18

	// Methods

	// RVA: 0x106F180 Offset: 0x106E580 VA: 0x18106F180
	public void .ctor() { }

}

public class TOD_ReflectionParameters // TypeDefIndex: 8102
{	// Fields
	[TooltipAttribute] // RVA: 0x76DC0 Offset: 0x761C0 VA: 0x180076DC0
	public TOD_ReflectionType Mode; // 0x10
	[TooltipAttribute] // RVA: 0x76FA0 Offset: 0x763A0 VA: 0x180076FA0
	public ReflectionProbeClearFlags ClearFlags; // 0x14
	[TooltipAttribute] // RVA: 0x77080 Offset: 0x76480 VA: 0x180077080
	public LayerMask CullingMask; // 0x18
	[TooltipAttribute] // RVA: 0x77210 Offset: 0x76610 VA: 0x180077210
	public GameObject ProbePrefab; // 0x20

	// Methods

	// RVA: 0x1074590 Offset: 0x1073990 VA: 0x181074590
	public void .ctor() { }

}

public class TOD_Rays : TOD_ImageEffect // TypeDefIndex: 8103
{	// Fields
	public Shader GodRayShader; // 0x30
	public Shader ScreenClearShader; // 0x38
	public Shader SkyMaskShader; // 0x40
	[TooltipAttribute] // RVA: 0x775C0 Offset: 0x769C0 VA: 0x1800775C0
	public bool UseDepthTexture; // 0x48
	[HeaderAttribute] // RVA: 0x77740 Offset: 0x76B40 VA: 0x180077740
	[TooltipAttribute] // RVA: 0x77740 Offset: 0x76B40 VA: 0x180077740
	public TOD_Rays.BlendModeType BlendMode; // 0x4C
	[TooltipAttribute] // RVA: 0x77850 Offset: 0x76C50 VA: 0x180077850
	[TOD_MinAttribute] // RVA: 0x77850 Offset: 0x76C50 VA: 0x180077850
	public float Intensity; // 0x50
	[HeaderAttribute] // RVA: 0x77980 Offset: 0x76D80 VA: 0x180077980
	[TooltipAttribute] // RVA: 0x77980 Offset: 0x76D80 VA: 0x180077980
	public TOD_ImageEffect.ResolutionType Resolution; // 0x54
	[TooltipAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	[TOD_RangeAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	public int BlurIterations; // 0x58
	[TooltipAttribute] // RVA: 0x77CC0 Offset: 0x770C0 VA: 0x180077CC0
	[TOD_MinAttribute] // RVA: 0x77CC0 Offset: 0x770C0 VA: 0x180077CC0
	public float BlurRadius; // 0x5C
	[TooltipAttribute] // RVA: 0x77F30 Offset: 0x77330 VA: 0x180077F30
	[TOD_MinAttribute] // RVA: 0x77F30 Offset: 0x77330 VA: 0x180077F30
	public float MaxRadius; // 0x60
	private Material godRayMaterial; // 0x68
	private Material screenClearMaterial; // 0x70
	private Material skyMaskMaterial; // 0x78
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;

	// Methods

	// RVA: 0x1074080 Offset: 0x1073480 VA: 0x181074080
	protected void OnEnable() { }

	// RVA: 0x1073F30 Offset: 0x1073330 VA: 0x181073F30
	protected void OnDisable() { }

	// RVA: 0x1074220 Offset: 0x1073620 VA: 0x181074220
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x1074510 Offset: 0x1073910 VA: 0x181074510
	public void .ctor() { }

}

public enum TOD_Rays.BlendModeType // TypeDefIndex: 8104
{	// Fields
	public int value__; // 0x0
	public const TOD_Rays.BlendModeType Screen = 0;
	public const TOD_Rays.BlendModeType Add = 1;

}

public class TOD_Resources : MonoBehaviour // TypeDefIndex: 8105
{	// Fields
	public Material Skybox; // 0x18
	public Mesh MoonLOD0; // 0x20
	public Mesh MoonLOD1; // 0x28
	public Mesh MoonLOD2; // 0x30
	public Mesh SkyLOD0; // 0x38
	public Mesh SkyLOD1; // 0x40
	public Mesh SkyLOD2; // 0x48
	public Mesh CloudsLOD0; // 0x50
	public Mesh CloudsLOD1; // 0x58
	public Mesh CloudsLOD2; // 0x60
	public Mesh StarsLOD0; // 0x68
	public Mesh StarsLOD1; // 0x70
	public Mesh StarsLOD2; // 0x78
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunLightColor>k__BackingField; // 0x80
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonLightColor>k__BackingField; // 0x84
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunSkyColor>k__BackingField; // 0x88
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonSkyColor>k__BackingField; // 0x8C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunMeshColor>k__BackingField; // 0x90
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonMeshColor>k__BackingField; // 0x94
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunCloudColor>k__BackingField; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonCloudColor>k__BackingField; // 0x9C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_FogColor>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_GroundColor>k__BackingField; // 0xA4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_AmbientColor>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunDirection>k__BackingField; // 0xAC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonDirection>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_LightDirection>k__BackingField; // 0xB4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_LocalSunDirection>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_LocalMoonDirection>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_LocalLightDirection>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_Contrast>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_Brightness>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_Fogginess>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_Directionality>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonHaloPower>k__BackingField; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonHaloColor>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudSize>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudOpacity>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudCoverage>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudSharpness>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudDensity>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudColoring>k__BackingField; // 0xF0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudAttenuation>k__BackingField; // 0xF4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudSaturation>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudScattering>k__BackingField; // 0xFC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudBrightness>k__BackingField; // 0x100
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudMultiplier>k__BackingField; // 0x104
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudOffset>k__BackingField; // 0x108
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_CloudWind>k__BackingField; // 0x10C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_StarSize>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_StarBrightness>k__BackingField; // 0x114
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_StarVisibility>k__BackingField; // 0x118
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunMeshContrast>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_SunMeshBrightness>k__BackingField; // 0x120
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonMeshContrast>k__BackingField; // 0x124
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_MoonMeshBrightness>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_kBetaMie>k__BackingField; // 0x12C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_kSun>k__BackingField; // 0x130
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_k4PI>k__BackingField; // 0x134
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_kRadius>k__BackingField; // 0x138
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_kScale>k__BackingField; // 0x13C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_World2Sky>k__BackingField; // 0x140
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <ID_Sky2World>k__BackingField; // 0x144

	// Properties
	public int ID_SunLightColor { get; set; }
	public int ID_MoonLightColor { get; set; }
	public int ID_SunSkyColor { get; set; }
	public int ID_MoonSkyColor { get; set; }
	public int ID_SunMeshColor { get; set; }
	public int ID_MoonMeshColor { get; set; }
	public int ID_SunCloudColor { get; set; }
	public int ID_MoonCloudColor { get; set; }
	public int ID_FogColor { get; set; }
	public int ID_GroundColor { get; set; }
	public int ID_AmbientColor { get; set; }
	public int ID_SunDirection { get; set; }
	public int ID_MoonDirection { get; set; }
	public int ID_LightDirection { get; set; }
	public int ID_LocalSunDirection { get; set; }
	public int ID_LocalMoonDirection { get; set; }
	public int ID_LocalLightDirection { get; set; }
	public int ID_Contrast { get; set; }
	public int ID_Brightness { get; set; }
	public int ID_Fogginess { get; set; }
	public int ID_Directionality { get; set; }
	public int ID_MoonHaloPower { get; set; }
	public int ID_MoonHaloColor { get; set; }
	public int ID_CloudSize { get; set; }
	public int ID_CloudOpacity { get; set; }
	public int ID_CloudCoverage { get; set; }
	public int ID_CloudSharpness { get; set; }
	public int ID_CloudDensity { get; set; }
	public int ID_CloudColoring { get; set; }
	public int ID_CloudAttenuation { get; set; }
	public int ID_CloudSaturation { get; set; }
	public int ID_CloudScattering { get; set; }
	public int ID_CloudBrightness { get; set; }
	public int ID_CloudMultiplier { get; set; }
	public int ID_CloudOffset { get; set; }
	public int ID_CloudWind { get; set; }
	public int ID_StarSize { get; set; }
	public int ID_StarBrightness { get; set; }
	public int ID_StarVisibility { get; set; }
	public int ID_SunMeshContrast { get; set; }
	public int ID_SunMeshBrightness { get; set; }
	public int ID_MoonMeshContrast { get; set; }
	public int ID_MoonMeshBrightness { get; set; }
	public int ID_kBetaMie { get; set; }
	public int ID_kSun { get; set; }
	public int ID_k4PI { get; set; }
	public int ID_kRadius { get; set; }
	public int ID_kScale { get; set; }
	public int ID_World2Sky { get; set; }
	public int ID_Sky2World { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x59C1A0 Offset: 0x59B5A0 VA: 0x18059C1A0
	public int get_ID_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x59C1B0 Offset: 0x59B5B0 VA: 0x18059C1B0
	private void set_ID_SunLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104B3C0 Offset: 0x104A7C0 VA: 0x18104B3C0
	public int get_ID_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104B460 Offset: 0x104A860 VA: 0x18104B460
	private void set_ID_MoonLightColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5A44D0 Offset: 0x5A38D0 VA: 0x1805A44D0
	public int get_ID_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86EB0 Offset: 0xF862B0 VA: 0x180F86EB0
	private void set_ID_SunSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D40 Offset: 0x1074140 VA: 0x181074D40
	public int get_ID_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF86EC0 Offset: 0xF862C0 VA: 0x180F86EC0
	private void set_ID_MoonSkyColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD22840 Offset: 0xD21C40 VA: 0x180D22840
	public int get_ID_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xD227B0 Offset: 0xD21BB0 VA: 0x180D227B0
	private void set_ID_SunMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xBABAD0 Offset: 0xBAAED0 VA: 0x180BABAD0
	public int get_ID_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074EA0 Offset: 0x10742A0 VA: 0x181074EA0
	private void set_ID_MoonMeshColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB96A00 Offset: 0xB95E00 VA: 0x180B96A00
	public int get_ID_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104A170 Offset: 0x1049570 VA: 0x18104A170
	private void set_ID_SunCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xB96A10 Offset: 0xB95E10 VA: 0x180B96A10
	public int get_ID_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DBE70 Offset: 0x5DB270 VA: 0x1805DBE70
	private void set_ID_MoonCloudColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104C610 Offset: 0x104BA10 VA: 0x18104C610
	public int get_ID_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E30 Offset: 0x1074230 VA: 0x181074E30
	private void set_ID_FogColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104C620 Offset: 0x104BA20 VA: 0x18104C620
	public int get_ID_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E40 Offset: 0x1074240 VA: 0x181074E40
	private void set_ID_GroundColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074C60 Offset: 0x1074060 VA: 0x181074C60
	public int get_ID_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DA0 Offset: 0x10741A0 VA: 0x181074DA0
	private void set_ID_AmbientColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BC00 Offset: 0xA2B000 VA: 0x180A2BC00
	public int get_ID_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074EF0 Offset: 0x10742F0 VA: 0x181074EF0
	private void set_ID_SunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95B0 Offset: 0x2F89B0 VA: 0x1802F95B0
	public int get_ID_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x2F95C0 Offset: 0x2F89C0 VA: 0x1802F95C0
	private void set_ID_MoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CE0 Offset: 0x10740E0 VA: 0x181074CE0
	public int get_ID_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E50 Offset: 0x1074250 VA: 0x181074E50
	private void set_ID_LightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D10 Offset: 0x1074110 VA: 0x181074D10
	public int get_ID_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E80 Offset: 0x1074280 VA: 0x181074E80
	private void set_ID_LocalSunDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D00 Offset: 0x1074100 VA: 0x181074D00
	public int get_ID_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E70 Offset: 0x1074270 VA: 0x181074E70
	private void set_ID_LocalMoonDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CF0 Offset: 0x10740F0 VA: 0x181074CF0
	public int get_ID_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E60 Offset: 0x1074260 VA: 0x181074E60
	private void set_ID_LocalLightDirection(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xADE1B0 Offset: 0xADD5B0 VA: 0x180ADE1B0
	public int get_ID_Contrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E20 Offset: 0x1074220 VA: 0x181074E20
	private void set_ID_Contrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xADE1D0 Offset: 0xADD5D0 VA: 0x180ADE1D0
	public int get_ID_Brightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1049B20 Offset: 0x1048F20 VA: 0x181049B20
	private void set_ID_Brightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BD70 Offset: 0xA2B170 VA: 0x180A2BD70
	public int get_ID_Fogginess() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE20 Offset: 0xA2B220 VA: 0x180A2BE20
	private void set_ID_Fogginess(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x84C150 Offset: 0x84B550 VA: 0x18084C150
	public int get_ID_Directionality() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x75BD40 Offset: 0x75B140 VA: 0x18075BD40
	private void set_ID_Directionality(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D20 Offset: 0x1074120 VA: 0x181074D20
	public int get_ID_MoonHaloPower() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E90 Offset: 0x1074290 VA: 0x181074E90
	private void set_ID_MoonHaloPower(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104B320 Offset: 0x104A720 VA: 0x18104B320
	public int get_ID_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104B1F0 Offset: 0x104A5F0 VA: 0x18104B1F0
	private void set_ID_MoonHaloColor(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104B3B0 Offset: 0x104A7B0 VA: 0x18104B3B0
	public int get_ID_CloudSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x104B200 Offset: 0x104A600 VA: 0x18104B200
	private void set_ID_CloudSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E820 Offset: 0x94DC20 VA: 0x18094E820
	public int get_ID_CloudOpacity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E8A0 Offset: 0x94DCA0 VA: 0x18094E8A0
	private void set_ID_CloudOpacity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074C90 Offset: 0x1074090 VA: 0x181074C90
	public int get_ID_CloudCoverage() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DD0 Offset: 0x10741D0 VA: 0x181074DD0
	private void set_ID_CloudCoverage(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CD0 Offset: 0x10740D0 VA: 0x181074CD0
	public int get_ID_CloudSharpness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E10 Offset: 0x1074210 VA: 0x181074E10
	private void set_ID_CloudSharpness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CA0 Offset: 0x10740A0 VA: 0x181074CA0
	public int get_ID_CloudDensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DE0 Offset: 0x10741E0 VA: 0x181074DE0
	private void set_ID_CloudDensity(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074C80 Offset: 0x1074080 VA: 0x181074C80
	public int get_ID_CloudColoring() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DC0 Offset: 0x10741C0 VA: 0x181074DC0
	private void set_ID_CloudColoring(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074C70 Offset: 0x1074070 VA: 0x181074C70
	public int get_ID_CloudAttenuation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DB0 Offset: 0x10741B0 VA: 0x181074DB0
	private void set_ID_CloudAttenuation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CB0 Offset: 0x10740B0 VA: 0x181074CB0
	public int get_ID_CloudSaturation() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074DF0 Offset: 0x10741F0 VA: 0x181074DF0
	private void set_ID_CloudSaturation(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074CC0 Offset: 0x10740C0 VA: 0x181074CC0
	public int get_ID_CloudScattering() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074E00 Offset: 0x1074200 VA: 0x181074E00
	private void set_ID_CloudScattering(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53140 Offset: 0xC52540 VA: 0x180C53140
	public int get_ID_CloudBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53290 Offset: 0xC52690 VA: 0x180C53290
	private void set_ID_CloudBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53050 Offset: 0xC52450 VA: 0x180C53050
	public int get_ID_CloudMultiplier() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53260 Offset: 0xC52660 VA: 0x180C53260
	private void set_ID_CloudMultiplier(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E6E0 Offset: 0x94DAE0 VA: 0x18094E6E0
	public int get_ID_CloudOffset() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E880 Offset: 0x94DC80 VA: 0x18094E880
	private void set_ID_CloudOffset(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53060 Offset: 0xC52460 VA: 0x180C53060
	public int get_ID_CloudWind() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53270 Offset: 0xC52670 VA: 0x180C53270
	private void set_ID_CloudWind(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xED4C60 Offset: 0xED4060 VA: 0x180ED4C60
	public int get_ID_StarSize() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074EE0 Offset: 0x10742E0 VA: 0x181074EE0
	private void set_ID_StarSize(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D50 Offset: 0x1074150 VA: 0x181074D50
	public int get_ID_StarBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074ED0 Offset: 0x10742D0 VA: 0x181074ED0
	private void set_ID_StarBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90CEB0 Offset: 0x90C2B0 VA: 0x18090CEB0
	public int get_ID_StarVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x90CEC0 Offset: 0x90C2C0 VA: 0x18090CEC0
	private void set_ID_StarVisibility(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D70 Offset: 0x1074170 VA: 0x181074D70
	public int get_ID_SunMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F10 Offset: 0x1074310 VA: 0x181074F10
	private void set_ID_SunMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D60 Offset: 0x1074160 VA: 0x181074D60
	public int get_ID_SunMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F00 Offset: 0x1074300 VA: 0x181074F00
	private void set_ID_SunMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D30 Offset: 0x1074130 VA: 0x181074D30
	public int get_ID_MoonMeshContrast() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074EB0 Offset: 0x10742B0 VA: 0x181074EB0
	private void set_ID_MoonMeshContrast(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81A940 Offset: 0x819D40 VA: 0x18081A940
	public int get_ID_MoonMeshBrightness() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x81AD00 Offset: 0x81A100 VA: 0x18081AD00
	private void set_ID_MoonMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62520 Offset: 0xC61920 VA: 0x180C62520
	public int get_ID_kBetaMie() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F40 Offset: 0x1074340 VA: 0x181074F40
	private void set_ID_kBetaMie(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC626F0 Offset: 0xC61AF0 VA: 0x180C626F0
	public int get_ID_kSun() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F60 Offset: 0x1074360 VA: 0x181074F60
	private void set_ID_kSun(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D90 Offset: 0x1074190 VA: 0x181074D90
	public int get_ID_k4PI() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F30 Offset: 0x1074330 VA: 0x181074F30
	private void set_ID_k4PI(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62730 Offset: 0xC61B30 VA: 0x180C62730
	public int get_ID_kRadius() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F50 Offset: 0x1074350 VA: 0x181074F50
	private void set_ID_kRadius(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E410 Offset: 0x94D810 VA: 0x18094E410
	public int get_ID_kScale() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x94E860 Offset: 0x94DC60 VA: 0x18094E860
	private void set_ID_kScale(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074D80 Offset: 0x1074180 VA: 0x181074D80
	public int get_ID_World2Sky() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074F20 Offset: 0x1074320 VA: 0x181074F20
	private void set_ID_World2Sky(int value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62450 Offset: 0xC61850 VA: 0x180C62450
	public int get_ID_Sky2World() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x1074EC0 Offset: 0x10742C0 VA: 0x181074EC0
	private void set_ID_Sky2World(int value) { }

	// RVA: 0x1074860 Offset: 0x1073C60 VA: 0x181074860
	public void Initialize() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class TOD_Scattering : TOD_ImageEffect // TypeDefIndex: 8106
{	// Fields
	public Shader ScatteringShader; // 0x30
	public Shader ScreenClearShader; // 0x38
	public Shader SkyMaskShader; // 0x40
	public Texture2D DitheringTexture; // 0x48
	[TooltipAttribute] // RVA: 0x85140 Offset: 0x84540 VA: 0x180085140
	public bool SinglePass; // 0x50
	[HeaderAttribute] // RVA: 0x85210 Offset: 0x84610 VA: 0x180085210
	[TooltipAttribute] // RVA: 0x85210 Offset: 0x84610 VA: 0x180085210
	[RangeAttribute] // RVA: 0x85210 Offset: 0x84610 VA: 0x180085210
	public float GlobalDensity; // 0x54
	[TooltipAttribute] // RVA: 0x854D0 Offset: 0x848D0 VA: 0x1800854D0
	[RangeAttribute] // RVA: 0x854D0 Offset: 0x848D0 VA: 0x1800854D0
	public float HeightFalloff; // 0x58
	[TooltipAttribute] // RVA: 0x85630 Offset: 0x84A30 VA: 0x180085630
	public float StartDistance; // 0x5C
	[TooltipAttribute] // RVA: 0x85730 Offset: 0x84B30 VA: 0x180085730
	public float ZeroLevel; // 0x60
	[HeaderAttribute] // RVA: 0x857F0 Offset: 0x84BF0 VA: 0x1800857F0
	[TooltipAttribute] // RVA: 0x857F0 Offset: 0x84BF0 VA: 0x1800857F0
	public TOD_ImageEffect.ResolutionType Resolution; // 0x64
	[TooltipAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	[TOD_RangeAttribute] // RVA: 0x77B20 Offset: 0x76F20 VA: 0x180077B20
	public int BlurIterations; // 0x68
	[TooltipAttribute] // RVA: 0x85A70 Offset: 0x84E70 VA: 0x180085A70
	[TOD_MinAttribute] // RVA: 0x85A70 Offset: 0x84E70 VA: 0x180085A70
	public float BlurRadius; // 0x6C
	[TooltipAttribute] // RVA: 0x85BA0 Offset: 0x84FA0 VA: 0x180085BA0
	[TOD_MinAttribute] // RVA: 0x85BA0 Offset: 0x84FA0 VA: 0x180085BA0
	public float MaxRadius; // 0x70
	private Material scatteringMaterial; // 0x78
	private Material screenClearMaterial; // 0x80
	private Material skyMaskMaterial; // 0x88

	// Methods

	// RVA: 0x12CBE10 Offset: 0x12CB210 VA: 0x1812CBE10
	protected void OnEnable() { }

	// RVA: 0x12CBCB0 Offset: 0x12CB0B0 VA: 0x1812CBCB0
	protected void OnDisable() { }

	// RVA: 0x12CC060 Offset: 0x12CB460 VA: 0x1812CC060
	protected void OnPreCull() { }

	// RVA: 0x12CBFB0 Offset: 0x12CB3B0 VA: 0x1812CBFB0
	protected void OnPostRender() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12CC110 Offset: 0x12CB510 VA: 0x1812CC110
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CC430 Offset: 0x12CB830 VA: 0x1812CC430
	public void .ctor() { }

}

public class TOD_Shadows : TOD_ImageEffect // TypeDefIndex: 8107
{	// Fields
	public Shader ShadowShader; // 0x30
	public Texture2D CloudTexture; // 0x38
	[HeaderAttribute] // RVA: 0x85FE0 Offset: 0x853E0 VA: 0x180085FE0
	[RangeAttribute] // RVA: 0x85FE0 Offset: 0x853E0 VA: 0x180085FE0
	public float Cutoff; // 0x40
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Fade; // 0x44
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Intensity; // 0x48
	private Material shadowMaterial; // 0x50

	// Methods

	// RVA: 0x12CC540 Offset: 0x12CB940 VA: 0x1812CC540
	protected void OnEnable() { }

	// RVA: 0x12CC4B0 Offset: 0x12CB8B0 VA: 0x1812CC4B0
	protected void OnDisable() { }

	[ImageEffectOpaque] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12CC5F0 Offset: 0x12CB9F0 VA: 0x1812CC5F0
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x12CC820 Offset: 0x12CBC20 VA: 0x1812CC820
	public void .ctor() { }

}

public class TOD_Sky : MonoBehaviour // TypeDefIndex: 8108
{	// Fields
	private static List<TOD_Sky> instances; // 0x0
	[TooltipAttribute] // RVA: 0x879D0 Offset: 0x86DD0 VA: 0x1800879D0
	public TOD_ColorSpaceType ColorSpace; // 0x18
	[TooltipAttribute] // RVA: 0x87B90 Offset: 0x86F90 VA: 0x180087B90
	public TOD_ColorRangeType ColorRange; // 0x1C
	[TooltipAttribute] // RVA: 0x87CE0 Offset: 0x870E0 VA: 0x180087CE0
	public TOD_ColorOutputType ColorOutput; // 0x20
	[TooltipAttribute] // RVA: 0x87F40 Offset: 0x87340 VA: 0x180087F40
	public TOD_SkyQualityType SkyQuality; // 0x24
	[TooltipAttribute] // RVA: 0x88090 Offset: 0x87490 VA: 0x180088090
	public TOD_CloudQualityType CloudQuality; // 0x28
	[TooltipAttribute] // RVA: 0x88140 Offset: 0x87540 VA: 0x180088140
	public TOD_MeshQualityType MeshQuality; // 0x2C
	[TooltipAttribute] // RVA: 0x88350 Offset: 0x87750 VA: 0x180088350
	public TOD_StarQualityType StarQuality; // 0x30
	public TOD_CycleParameters Cycle; // 0x38
	public TOD_WorldParameters World; // 0x40
	public TOD_AtmosphereParameters Atmosphere; // 0x48
	public TOD_DayParameters Day; // 0x50
	public TOD_NightParameters Night; // 0x58
	public TOD_SunParameters Sun; // 0x60
	public TOD_MoonParameters Moon; // 0x68
	public TOD_StarParameters Stars; // 0x70
	public TOD_CloudParameters Clouds; // 0x78
	public TOD_LightParameters Light; // 0x80
	public TOD_FogParameters Fog; // 0x88
	public TOD_AmbientParameters Ambient; // 0x90
	public TOD_ReflectionParameters Reflection; // 0x98
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <Initialized>k__BackingField; // 0xA0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Components <Components>k__BackingField; // 0xA8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TOD_Resources <Resources>k__BackingField; // 0xB0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsDay>k__BackingField; // 0xB8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <IsNight>k__BackingField; // 0xB9
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <LerpValue>k__BackingField; // 0xBC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <SunZenith>k__BackingField; // 0xC0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <SunAltitude>k__BackingField; // 0xC4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <SunAzimuth>k__BackingField; // 0xC8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <MoonZenith>k__BackingField; // 0xCC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <MoonAltitude>k__BackingField; // 0xD0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <MoonAzimuth>k__BackingField; // 0xD4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <SunsetTime>k__BackingField; // 0xD8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <SunriseTime>k__BackingField; // 0xDC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <LocalSiderealTime>k__BackingField; // 0xE0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <SunVisibility>k__BackingField; // 0xE4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private float <MoonVisibility>k__BackingField; // 0xE8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <SunDirection>k__BackingField; // 0xEC
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <MoonDirection>k__BackingField; // 0xF8
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <LightDirection>k__BackingField; // 0x104
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <LocalSunDirection>k__BackingField; // 0x110
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <LocalMoonDirection>k__BackingField; // 0x11C
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Vector3 <LocalLightDirection>k__BackingField; // 0x128
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <SunLightColor>k__BackingField; // 0x134
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <MoonLightColor>k__BackingField; // 0x144
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <SunRayColor>k__BackingField; // 0x154
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <MoonRayColor>k__BackingField; // 0x164
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <SunSkyColor>k__BackingField; // 0x174
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <MoonSkyColor>k__BackingField; // 0x184
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <SunMeshColor>k__BackingField; // 0x194
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <MoonMeshColor>k__BackingField; // 0x1A4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <SunCloudColor>k__BackingField; // 0x1B4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <MoonCloudColor>k__BackingField; // 0x1C4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <FogColor>k__BackingField; // 0x1D4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <GroundColor>k__BackingField; // 0x1E4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <AmbientColor>k__BackingField; // 0x1F4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <MoonHaloColor>k__BackingField; // 0x204
	private TOD_Sky.ReflectionProbeState ReflectionCur; // 0x218
	private TOD_Sky.ReflectionProbeState ReflectionSrc; // 0x220
	private TOD_Sky.ReflectionProbeState ReflectionDst; // 0x228
	public static float ReflectionUpdateSlowdown; // 0x8
	public static int ReflectionResolution; // 0xC
	public static float ReflectionUpdateInterval; // 0x10
	public static ReflectionProbeTimeSlicingMode ReflectionTimeSlicing; // 0x14
	private float timeSinceLightUpdate; // 0x230
	private float timeSinceAmbientUpdate; // 0x234
	private float timeSinceReflectionUpdate; // 0x238
	private const int TOD_SAMPLES = 2;
	private Vector3 kBetaMie; // 0x23C
	private Vector4 kSun; // 0x248
	private Vector4 k4PI; // 0x258
	private Vector4 kRadius; // 0x268
	private Vector4 kScale; // 0x278
	private const float pi = 3,141593;
	private const float tau = 6,283185;

	// Properties
	public static List<TOD_Sky> Instances { get; }
	public static TOD_Sky Instance { get; }
	public bool Initialized { get; set; }
	public bool Headless { get; }
	public TOD_Components Components { get; set; }
	public TOD_Resources Resources { get; set; }
	public bool IsDay { get; set; }
	public bool IsNight { get; set; }
	public float Radius { get; }
	public float Diameter { get; }
	public float LerpValue { get; set; }
	public float SunZenith { get; set; }
	public float SunAltitude { get; set; }
	public float SunAzimuth { get; set; }
	public float MoonZenith { get; set; }
	public float MoonAltitude { get; set; }
	public float MoonAzimuth { get; set; }
	public float SunsetTime { get; set; }
	public float SunriseTime { get; set; }
	public float LocalSiderealTime { get; set; }
	public float LightZenith { get; }
	public float LightIntensity { get; }
	public float SunVisibility { get; set; }
	public float MoonVisibility { get; set; }
	public Vector3 SunDirection { get; set; }
	public Vector3 MoonDirection { get; set; }
	public Vector3 LightDirection { get; set; }
	public Vector3 LocalSunDirection { get; set; }
	public Vector3 LocalMoonDirection { get; set; }
	public Vector3 LocalLightDirection { get; set; }
	public Color SunLightColor { get; set; }
	public Color MoonLightColor { get; set; }
	public Color LightColor { get; }
	public Color SunRayColor { get; set; }
	public Color MoonRayColor { get; set; }
	public Color SunSkyColor { get; set; }
	public Color MoonSkyColor { get; set; }
	public Color SunMeshColor { get; set; }
	public Color MoonMeshColor { get; set; }
	public Color SunCloudColor { get; set; }
	public Color MoonCloudColor { get; set; }
	public Color FogColor { get; set; }
	public Color GroundColor { get; set; }
	public Color AmbientColor { get; set; }
	public Color MoonHaloColor { get; set; }
	public ReflectionProbe Probe { get; }
	public GameObject ProbeInstance { get; }
	public MonoBehaviour ProbeEx { get; }

	// Methods

	// RVA: 0x12D5120 Offset: 0x12D4520 VA: 0x1812D5120
	public static List<TOD_Sky> get_Instances() { }

	// RVA: 0x12D5050 Offset: 0x12D4450 VA: 0x1812D5050
	public static TOD_Sky get_Instance() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC26F70 Offset: 0xC26370 VA: 0x180C26F70
	public bool get_Initialized() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC27450 Offset: 0xC26850 VA: 0x180C27450
	private void set_Initialized(bool value) { }

	// RVA: 0x12D5030 Offset: 0x12D4430 VA: 0x1812D5030
	public bool get_Headless() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x9321E0 Offset: 0x9315E0 VA: 0x1809321E0
	public TOD_Components get_Components() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC53340 Offset: 0xC52740 VA: 0x180C53340
	private void set_Components(TOD_Components value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x972280 Offset: 0x971680 VA: 0x180972280
	public TOD_Resources get_Resources() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xA2BE00 Offset: 0xA2B200 VA: 0x180A2BE00
	private void set_Resources(TOD_Resources value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5180 Offset: 0x12D4580 VA: 0x1812D5180
	public bool get_IsDay() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5550 Offset: 0x12D4950 VA: 0x1812D5550
	private void set_IsDay(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5190 Offset: 0x12D4590 VA: 0x1812D5190
	public bool get_IsNight() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5560 Offset: 0x12D4960 VA: 0x1812D5560
	private void set_IsNight(bool value) { }

	// RVA: 0x12D5430 Offset: 0x12D4830 VA: 0x1812D5430
	public float get_Radius() { }

	// RVA: 0x12D4FD0 Offset: 0x12D43D0 VA: 0x1812D4FD0
	public float get_Diameter() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCBC0 Offset: 0x5DBFC0 VA: 0x1805DCBC0
	public float get_LerpValue() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5DCDB0 Offset: 0x5DC1B0 VA: 0x1805DCDB0
	private void set_LerpValue(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D54F0 Offset: 0x12D48F0 VA: 0x1812D54F0
	public float get_SunZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5750 Offset: 0x12D4B50 VA: 0x1812D5750
	private void set_SunZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5470 Offset: 0x12D4870 VA: 0x1812D5470
	public float get_SunAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D56B0 Offset: 0x12D4AB0 VA: 0x1812D56B0
	private void set_SunAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5480 Offset: 0x12D4880 VA: 0x1812D5480
	public float get_SunAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D56C0 Offset: 0x12D4AC0 VA: 0x1812D56C0
	private void set_SunAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D53C0 Offset: 0x12D47C0 VA: 0x1812D53C0
	public float get_MoonZenith() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D56A0 Offset: 0x12D4AA0 VA: 0x1812D56A0
	private void set_MoonZenith(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5320 Offset: 0x12D4720 VA: 0x1812D5320
	public float get_MoonAltitude() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D55F0 Offset: 0x12D49F0 VA: 0x1812D55F0
	private void set_MoonAltitude(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5330 Offset: 0x12D4730 VA: 0x1812D5330
	public float get_MoonAzimuth() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5600 Offset: 0x12D4A00 VA: 0x1812D5600
	private void set_MoonAzimuth(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5510 Offset: 0x12D4910 VA: 0x1812D5510
	public float get_SunsetTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5770 Offset: 0x12D4B70 VA: 0x1812D5770
	private void set_SunsetTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5500 Offset: 0x12D4900 VA: 0x1812D5500
	public float get_SunriseTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5760 Offset: 0x12D4B60 VA: 0x1812D5760
	private void set_SunriseTime(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x112CDC0 Offset: 0x112C1C0 VA: 0x18112CDC0
	public float get_LocalSiderealTime() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x112D5C0 Offset: 0x112C9C0 VA: 0x18112D5C0
	private void set_LocalSiderealTime(float value) { }

	// RVA: 0x12D5240 Offset: 0x12D4640 VA: 0x1812D5240
	public float get_LightZenith() { }

	// RVA: 0x12D5210 Offset: 0x12D4610 VA: 0x1812D5210
	public float get_LightIntensity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D54E0 Offset: 0x12D48E0 VA: 0x1812D54E0
	public float get_SunVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5740 Offset: 0x12D4B40 VA: 0x1812D5740
	private void set_SunVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x112CC10 Offset: 0x112C010 VA: 0x18112CC10
	public float get_MoonVisibility() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5690 Offset: 0x12D4A90 VA: 0x1812D5690
	private void set_MoonVisibility(float value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5490 Offset: 0x12D4890 VA: 0x1812D5490
	public Vector3 get_SunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D56E0 Offset: 0x12D4AE0 VA: 0x1812D56E0
	private void set_SunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5350 Offset: 0x12D4750 VA: 0x1812D5350
	public Vector3 get_MoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5620 Offset: 0x12D4A20 VA: 0x1812D5620
	private void set_MoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D51F0 Offset: 0x12D45F0 VA: 0x1812D51F0
	public Vector3 get_LightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5570 Offset: 0x12D4970 VA: 0x1812D5570
	private void set_LightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5300 Offset: 0x12D4700 VA: 0x1812D5300
	public Vector3 get_LocalSunDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D55D0 Offset: 0x12D49D0 VA: 0x1812D55D0
	private void set_LocalSunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D52E0 Offset: 0x12D46E0 VA: 0x1812D52E0
	public Vector3 get_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D55B0 Offset: 0x12D49B0 VA: 0x1812D55B0
	private void set_LocalMoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D52C0 Offset: 0x12D46C0 VA: 0x1812D52C0
	public Vector3 get_LocalLightDirection() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5590 Offset: 0x12D4990 VA: 0x1812D5590
	private void set_LocalLightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D54B0 Offset: 0x12D48B0 VA: 0x1812D54B0
	public Color get_SunLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5700 Offset: 0x12D4B00 VA: 0x1812D5700
	private void set_SunLightColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5380 Offset: 0x12D4780 VA: 0x1812D5380
	public Color get_MoonLightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5650 Offset: 0x12D4A50 VA: 0x1812D5650
	private void set_MoonLightColor(Color value) { }

	// RVA: 0x12D51A0 Offset: 0x12D45A0 VA: 0x1812D51A0
	public Color get_LightColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D54D0 Offset: 0x12D48D0 VA: 0x1812D54D0
	public Color get_SunRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5720 Offset: 0x12D4B20 VA: 0x1812D5720
	public void set_SunRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D53A0 Offset: 0x12D47A0 VA: 0x1812D53A0
	public Color get_MoonRayColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5670 Offset: 0x12D4A70 VA: 0x1812D5670
	public void set_MoonRayColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xEC5480 Offset: 0xEC4880 VA: 0x180EC5480
	public Color get_SunSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5730 Offset: 0x12D4B30 VA: 0x1812D5730
	private void set_SunSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D53B0 Offset: 0x12D47B0 VA: 0x1812D53B0
	public Color get_MoonSkyColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5680 Offset: 0x12D4A80 VA: 0x1812D5680
	private void set_MoonSkyColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D54C0 Offset: 0x12D48C0 VA: 0x1812D54C0
	public Color get_SunMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5710 Offset: 0x12D4B10 VA: 0x1812D5710
	private void set_SunMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5390 Offset: 0x12D4790 VA: 0x1812D5390
	public Color get_MoonMeshColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5660 Offset: 0x12D4A60 VA: 0x1812D5660
	private void set_MoonMeshColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xC62A20 Offset: 0xC61E20 VA: 0x180C62A20
	public Color get_SunCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D56D0 Offset: 0x12D4AD0 VA: 0x1812D56D0
	private void set_SunCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5340 Offset: 0x12D4740 VA: 0x1812D5340
	public Color get_MoonCloudColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5610 Offset: 0x12D4A10 VA: 0x1812D5610
	private void set_MoonCloudColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5010 Offset: 0x12D4410 VA: 0x1812D5010
	public Color get_FogColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5530 Offset: 0x12D4930 VA: 0x1812D5530
	private void set_FogColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5020 Offset: 0x12D4420 VA: 0x1812D5020
	public Color get_GroundColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5540 Offset: 0x12D4940 VA: 0x1812D5540
	private void set_GroundColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D4FC0 Offset: 0x12D43C0 VA: 0x1812D4FC0
	public Color get_AmbientColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5520 Offset: 0x12D4920 VA: 0x1812D5520
	private void set_AmbientColor(Color value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5370 Offset: 0x12D4770 VA: 0x1812D5370
	public Color get_MoonHaloColor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D5640 Offset: 0x12D4A40 VA: 0x1812D5640
	private void set_MoonHaloColor(Color value) { }

	// RVA: 0x12D5410 Offset: 0x12D4810 VA: 0x1812D5410
	public ReflectionProbe get_Probe() { }

	// RVA: 0x12D53F0 Offset: 0x12D47F0 VA: 0x1812D53F0
	public GameObject get_ProbeInstance() { }

	// RVA: 0x12D53D0 Offset: 0x12D47D0 VA: 0x1812D53D0
	public MonoBehaviour get_ProbeEx() { }

	// RVA: 0x12CD190 Offset: 0x12CC590 VA: 0x1812CD190
	public Vector3 OrbitalToUnity(float radius, float theta, float phi) { }

	// RVA: 0x12CD0D0 Offset: 0x12CC4D0 VA: 0x1812CD0D0
	public Vector3 OrbitalToLocal(float theta, float phi) { }

	// RVA: 0x12CE8B0 Offset: 0x12CDCB0 VA: 0x1812CE8B0
	public Color SampleAtmosphere(Vector3 direction, bool directLight = True) { }

	// RVA: 0x12CE750 Offset: 0x12CDB50 VA: 0x1812CE750
	public SphericalHarmonicsL2 RenderToSphericalHarmonics() { }

	// RVA: 0x12CD730 Offset: 0x12CCB30 VA: 0x1812CD730
	public SphericalHarmonicsL2 RenderToSphericalHarmonics(float intensity, float saturation) { }

	// RVA: 0x12CD2A0 Offset: 0x12CC6A0 VA: 0x1812CD2A0
	public void RenderToCubemap(RenderTexture targetTexture) { }

	// RVA: 0x12CD3E0 Offset: 0x12CC7E0 VA: 0x1812CD3E0
	public void RenderToProbe() { }

	// RVA: 0x12CD260 Offset: 0x12CC660 VA: 0x1812CD260
	public bool ReflectionIsUpdating() { }

	// RVA: 0x12D2DB0 Offset: 0x12D21B0 VA: 0x1812D2DB0
	private void UpdateProbeBlending(float lerp) { }

	// RVA: 0x12D2EA0 Offset: 0x12D22A0 VA: 0x1812D2EA0
	private void UpdateProbeProperties(ReflectionProbe probe) { }

	// RVA: 0x12CEC30 Offset: 0x12CE030 VA: 0x1812CEC30
	public Color SampleFogColor(bool directLight = True) { }

	// RVA: 0x12CEEE0 Offset: 0x12CE2E0 VA: 0x1812CEEE0
	public Color SampleSkyColor() { }

	// RVA: 0x12CEB70 Offset: 0x12CDF70 VA: 0x1812CEB70
	public Color SampleEquatorColor() { }

	// RVA: 0x12D2D30 Offset: 0x12D2130 VA: 0x1812D2D30
	public void UpdateFog() { }

	// RVA: 0x12D0400 Offset: 0x12CF800 VA: 0x1812D0400
	public void UpdateAmbient() { }

	// RVA: 0x12D3790 Offset: 0x12D2B90 VA: 0x1812D3790
	public void UpdateReflection() { }

	// RVA: 0x12CCA30 Offset: 0x12CBE30 VA: 0x1812CCA30
	public void DelayReflectionUpdate() { }

	// RVA: 0x12CCE20 Offset: 0x12CC220 VA: 0x1812CCE20
	public void LoadParameters(string xml) { }

	// RVA: 0x12CEFF0 Offset: 0x12CE3F0 VA: 0x1812CEFF0
	public string SaveParameters() { }

	// RVA: 0x12D3180 Offset: 0x12D2580 VA: 0x1812D3180
	private void UpdateQualitySettings() { }

	// RVA: 0x12D3890 Offset: 0x12D2C90 VA: 0x1812D3890
	private void UpdateRenderSettings() { }

	// RVA: 0x12D3E70 Offset: 0x12D3270 VA: 0x1812D3E70
	private void UpdateShaderKeywords() { }

	// RVA: 0x12D4070 Offset: 0x12D3470 VA: 0x1812D4070
	private void UpdateShaderProperties() { }

	// RVA: 0x12CF560 Offset: 0x12CE960 VA: 0x1812CF560
	private float ShaderScale(float inCos) { }

	// RVA: 0x12CF240 Offset: 0x12CE640 VA: 0x1812CF240
	private float ShaderMiePhase(float eyeCos, float eyeCos2) { }

	// RVA: 0x12CF540 Offset: 0x12CE940 VA: 0x1812CF540
	private float ShaderRayleighPhase(float eyeCos2) { }

	// RVA: 0x12CF450 Offset: 0x12CE850 VA: 0x1812CF450
	private Color ShaderNightSkyColor(Vector3 dir) { }

	// RVA: 0x12CF310 Offset: 0x12CE710 VA: 0x1812CF310
	private Color ShaderMoonHaloColor(Vector3 dir) { }

	// RVA: 0x12D01B0 Offset: 0x12CF5B0 VA: 0x1812D01B0
	private Color TOD_HDR2LDR(Color color) { }

	// RVA: 0x12D0150 Offset: 0x12CF550 VA: 0x1812D0150
	private Color TOD_GAMMA2LINEAR(Color color) { }

	// RVA: 0x12D0330 Offset: 0x12CF730 VA: 0x1812D0330
	private Color TOD_LINEAR2GAMMA(Color color) { }

	// RVA: 0x12CF610 Offset: 0x12CEA10 VA: 0x1812CF610
	private Color ShaderScatteringColor(Vector3 dir, bool directLight = True) { }

	// RVA: 0x12CCA40 Offset: 0x12CBE40 VA: 0x1812CCA40
	private void Initialize() { }

	// RVA: 0x12CC880 Offset: 0x12CBC80 VA: 0x1812CC880
	private void Cleanup() { }

	// RVA: 0x12CD080 Offset: 0x12CC480 VA: 0x1812CD080
	protected void OnEnable() { }

	// RVA: 0x12CD070 Offset: 0x12CC470 VA: 0x1812CD070
	protected void OnDisable() { }

	// RVA: 0x12CCB40 Offset: 0x12CBF40 VA: 0x1812CCB40
	protected void LateUpdate() { }

	// RVA: 0x12CD090 Offset: 0x12CC490 VA: 0x1812CD090
	protected void OnValidate() { }

	// RVA: 0x12D3CC0 Offset: 0x12D30C0 VA: 0x1812D3CC0
	private void UpdateScattering() { }

	// RVA: 0x12D0B70 Offset: 0x12CFF70 VA: 0x1812D0B70
	private void UpdateCelestials() { }

	// RVA: 0x12D4EB0 Offset: 0x12D42B0 VA: 0x1812D4EB0
	public void .ctor() { }

	// RVA: 0x12D4DF0 Offset: 0x12D41F0 VA: 0x1812D4DF0
	private static void .cctor() { }

}

public class TOD_Sky.ReflectionProbeState // TypeDefIndex: 8109
{	// Fields
	public ReflectionProbe Probe; // 0x10
	public GameObject ProbeInstance; // 0x18
	public MonoBehaviour ProbeEx; // 0x20
	public int ProbeRenderID; // 0x28

	// Methods

	// RVA: 0x12CB740 Offset: 0x12CAB40 VA: 0x1812CB740
	public void InitializePrimary(Vector3 position, GameObject prefab) { }

	// RVA: 0x12CBB00 Offset: 0x12CAF00 VA: 0x1812CBB00
	public void InitializeSecondary(Vector3 position) { }

	// RVA: 0x12CBCA0 Offset: 0x12CB0A0 VA: 0x1812CBCA0
	public void .ctor() { }

}

public class TOD_Time : MonoBehaviour // TypeDefIndex: 8110
{	// Fields
	[TooltipAttribute] // RVA: 0x90330 Offset: 0x8F730 VA: 0x180090330
	[TOD_MinAttribute] // RVA: 0x90330 Offset: 0x8F730 VA: 0x180090330
	public float DayLengthInMinutes; // 0x18
	[TooltipAttribute] // RVA: 0x90570 Offset: 0x8F970 VA: 0x180090570
	public bool ProgressTime; // 0x1C
	[TooltipAttribute] // RVA: 0x906C0 Offset: 0x8FAC0 VA: 0x1800906C0
	public bool UseDeviceDate; // 0x1D
	[TooltipAttribute] // RVA: 0x90770 Offset: 0x8FB70 VA: 0x180090770
	public bool UseDeviceTime; // 0x1E
	[TooltipAttribute] // RVA: 0x90900 Offset: 0x8FD00 VA: 0x180090900
	public bool UseTimeCurve; // 0x1F
	[TooltipAttribute] // RVA: 0x90A60 Offset: 0x8FE60 VA: 0x180090A60
	public AnimationCurve TimeCurve; // 0x20
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnSecond; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnMinute; // 0x30
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnHour; // 0x38
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnDay; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnMonth; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnYear; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnSunrise; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Action OnSunset; // 0x60
	private TOD_Sky sky; // 0x68
	private AnimationCurve timeCurve; // 0x70
	private AnimationCurve timeCurveInverse; // 0x78
	private float timeFraction; // 0x80

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6870 Offset: 0x12D5C70 VA: 0x1812D6870
	public void add_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6D70 Offset: 0x12D6170 VA: 0x1812D6D70
	public void remove_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6730 Offset: 0x12D5B30 VA: 0x1812D6730
	public void add_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6C30 Offset: 0x12D6030 VA: 0x1812D6C30
	public void remove_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6690 Offset: 0x12D5A90 VA: 0x1812D6690
	public void add_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6B90 Offset: 0x12D5F90 VA: 0x1812D6B90
	public void remove_OnHour(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D65F0 Offset: 0x12D59F0 VA: 0x1812D65F0
	public void add_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6AF0 Offset: 0x12D5EF0 VA: 0x1812D6AF0
	public void remove_OnDay(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D67D0 Offset: 0x12D5BD0 VA: 0x1812D67D0
	public void add_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6CD0 Offset: 0x12D60D0 VA: 0x1812D6CD0
	public void remove_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6A50 Offset: 0x12D5E50 VA: 0x1812D6A50
	public void add_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6F50 Offset: 0x12D6350 VA: 0x1812D6F50
	public void remove_OnYear(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6910 Offset: 0x12D5D10 VA: 0x1812D6910
	public void add_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6E10 Offset: 0x12D6210 VA: 0x1812D6E10
	public void remove_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D69B0 Offset: 0x12D5DB0 VA: 0x1812D69B0
	public void add_OnSunset(Action value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x12D6EB0 Offset: 0x12D62B0 VA: 0x1812D6EB0
	public void remove_OnSunset(Action value) { }

	// RVA: 0x12D6370 Offset: 0x12D5770 VA: 0x1812D6370
	public void RefreshTimeCurve() { }

	// RVA: 0x12D5B10 Offset: 0x12D4F10 VA: 0x1812D5B10
	public float ApplyTimeCurve(float deltaTime) { }

	// RVA: 0x12D57C0 Offset: 0x12D4BC0 VA: 0x1812D57C0
	public void AddHours(float hours, bool adjust = True) { }

	// RVA: 0x12D5AF0 Offset: 0x12D4EF0 VA: 0x1812D5AF0
	public void AddSeconds(float seconds, bool adjust = True) { }

	// RVA: 0x12D6110 Offset: 0x12D5510 VA: 0x1812D6110
	private void CalculateLinearTangents(Keyframe[] keys) { }

	// RVA: 0x12D5C30 Offset: 0x12D5030 VA: 0x1812D5C30
	private void ApproximateCurve(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse) { }

	// RVA: 0x12D5EC0 Offset: 0x12D52C0 VA: 0x1812D5EC0
	protected void Awake() { }

	// RVA: 0x12D6440 Offset: 0x12D5840 VA: 0x1812D6440
	protected void Update() { }

	// RVA: 0x12D6590 Offset: 0x12D5990 VA: 0x1812D6590
	public void .ctor() { }

}

public static class TOD_Util // TypeDefIndex: 8111
{	// Methods

	// RVA: 0x12D7290 Offset: 0x12D6690 VA: 0x1812D7290
	public static Color MulRGB(Color color, float multiplier) { }

	// RVA: 0x12D7220 Offset: 0x12D6620 VA: 0x1812D7220
	public static Color MulRGBA(Color color, float multiplier) { }

	// RVA: 0x12D7420 Offset: 0x12D6820 VA: 0x1812D7420
	public static Color PowRGB(Color color, float power) { }

	// RVA: 0x12D7300 Offset: 0x12D6700 VA: 0x1812D7300
	public static Color PowRGBA(Color color, float power) { }

	// RVA: 0x12D75D0 Offset: 0x12D69D0 VA: 0x1812D75D0
	public static Color SatRGB(Color color, float saturation) { }

	// RVA: 0x12D7520 Offset: 0x12D6920 VA: 0x1812D7520
	public static Color SatRGBA(Color color, float saturation) { }

	// RVA: 0x12D70E0 Offset: 0x12D64E0 VA: 0x1812D70E0
	public static Color AdjustRGB(Color color, float intensity, float saturation) { }

	// RVA: 0x12D6FF0 Offset: 0x12D63F0 VA: 0x1812D6FF0
	public static Color AdjustRGBA(Color color, float intensity, float saturation) { }

	// RVA: 0x12D71C0 Offset: 0x12D65C0 VA: 0x1812D71C0
	public static Color ApplyAlpha(Color color) { }

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58A750 Offset: 0x589B50 VA: 0x18058A750
	|-TOD_Util.Swap<object>
	|-TOD_Util.Swap<TOD_Sky.ReflectionProbeState>
	*/

}

public abstract class TOD_Audio : MonoBehaviour // TypeDefIndex: 8112
{	// Fields
	private AudioSource audioComponent; // 0x18

	// Methods

	// RVA: 0x106FCD0 Offset: 0x106F0D0 VA: 0x18106FCD0
	protected float GetVolume() { }

	// RVA: 0x106FD60 Offset: 0x106F160 VA: 0x18106FD60
	protected void SetVolume(float value) { }

	// RVA: 0x106FC80 Offset: 0x106F080 VA: 0x18106FC80
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

public class TOD_AudioAtDay : TOD_Audio // TypeDefIndex: 8113
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28

	// Methods

	// RVA: 0x106F6B0 Offset: 0x106EAB0 VA: 0x18106F6B0
	protected void Start() { }

	// RVA: 0x106F750 Offset: 0x106EB50 VA: 0x18106F750
	protected void Update() { }

	// RVA: 0x595490 Offset: 0x594890 VA: 0x180595490
	public void .ctor() { }

}

public class TOD_AudioAtNight : TOD_Audio // TypeDefIndex: 8114
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxVolume; // 0x28

	// Methods

	// RVA: 0x106F860 Offset: 0x106EC60 VA: 0x18106F860
	protected void Start() { }

	// RVA: 0x106F900 Offset: 0x106ED00 VA: 0x18106F900
	protected void Update() { }

	// RVA: 0x595490 Offset: 0x594890 VA: 0x180595490
	public void .ctor() { }

}

public class TOD_AudioAtTime : TOD_Audio // TypeDefIndex: 8115
{	// Fields
	public AnimationCurve Volume; // 0x20

	// Methods

	// RVA: 0x106FA10 Offset: 0x106EE10 VA: 0x18106FA10
	protected void Update() { }

	// RVA: 0x106FAB0 Offset: 0x106EEB0 VA: 0x18106FAB0
	public void .ctor() { }

}

public abstract class TOD_Light : MonoBehaviour // TypeDefIndex: 8116
{	// Fields
	private Light lightComponent; // 0x18

	// Methods

	// RVA: 0x1073300 Offset: 0x1072700 VA: 0x181073300
	protected float GetIntensity() { }

	// RVA: 0x1073390 Offset: 0x1072790 VA: 0x181073390
	protected void SetIntensity(float value) { }

	// RVA: 0x10732B0 Offset: 0x10726B0 VA: 0x1810732B0
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

public class TOD_LightAtDay : TOD_Light // TypeDefIndex: 8117
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28

	// Methods

	// RVA: 0x1072CE0 Offset: 0x10720E0 VA: 0x181072CE0
	protected void Start() { }

	// RVA: 0x1072D80 Offset: 0x1072180 VA: 0x181072D80
	protected void Update() { }

	// RVA: 0x595490 Offset: 0x594890 VA: 0x180595490
	public void .ctor() { }

}

public class TOD_LightAtNight : TOD_Light // TypeDefIndex: 8118
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxIntensity; // 0x28

	// Methods

	// RVA: 0x1072E90 Offset: 0x1072290 VA: 0x181072E90
	protected void Start() { }

	// RVA: 0x1072F30 Offset: 0x1072330 VA: 0x181072F30
	protected void Update() { }

	// RVA: 0x595490 Offset: 0x594890 VA: 0x180595490
	public void .ctor() { }

}

public class TOD_LightAtTime : TOD_Light // TypeDefIndex: 8119
{	// Fields
	public AnimationCurve Intensity; // 0x20

	// Methods

	// RVA: 0x1073040 Offset: 0x1072440 VA: 0x181073040
	protected void Update() { }

	// RVA: 0x10730E0 Offset: 0x10724E0 VA: 0x1810730E0
	public void .ctor() { }

}

public class TOD_LoadSkyFromFile : MonoBehaviour // TypeDefIndex: 8120
{	// Fields
	public TOD_Sky sky; // 0x18
	public TextAsset textAsset; // 0x20

	// Methods

	// RVA: 0x1073440 Offset: 0x1072840 VA: 0x181073440
	protected void Start() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public abstract class TOD_Particle : MonoBehaviour // TypeDefIndex: 8121
{	// Fields
	private ParticleSystem particleComponent; // 0x18

	// Methods

	// RVA: 0x1073DF0 Offset: 0x10731F0 VA: 0x181073DF0
	protected float GetEmission() { }

	// RVA: 0x1073E90 Offset: 0x1073290 VA: 0x181073E90
	protected void SetEmission(float value) { }

	// RVA: 0x1073DA0 Offset: 0x10731A0 VA: 0x181073DA0
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

public class TOD_ParticleAtDay : TOD_Particle // TypeDefIndex: 8122
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28

	// Methods

	// RVA: 0x10737D0 Offset: 0x1072BD0 VA: 0x1810737D0
	protected void Start() { }

	// RVA: 0x1073870 Offset: 0x1072C70 VA: 0x181073870
	protected void Update() { }

	// RVA: 0x595490 Offset: 0x594890 VA: 0x180595490
	public void .ctor() { }

}

public class TOD_ParticleAtNight : TOD_Particle // TypeDefIndex: 8123
{	// Fields
	public float fadeTime; // 0x20
	private float lerpTime; // 0x24
	private float maxEmission; // 0x28

	// Methods

	// RVA: 0x1073980 Offset: 0x1072D80 VA: 0x181073980
	protected void Start() { }

	// RVA: 0x1073A20 Offset: 0x1072E20 VA: 0x181073A20
	protected void Update() { }

	// RVA: 0x595490 Offset: 0x594890 VA: 0x180595490
	public void .ctor() { }

}

public class TOD_ParticleAtTime : TOD_Particle // TypeDefIndex: 8124
{	// Fields
	public AnimationCurve Emission; // 0x20

	// Methods

	// RVA: 0x1073B30 Offset: 0x1072F30 VA: 0x181073B30
	protected void Update() { }

	// RVA: 0x1073BD0 Offset: 0x1072FD0 VA: 0x181073BD0
	public void .ctor() { }

}

public abstract class TOD_Render : MonoBehaviour // TypeDefIndex: 8125
{	// Fields
	private Renderer rendererComponent; // 0x18

	// Methods

	// RVA: 0x10747D0 Offset: 0x1073BD0 VA: 0x1810747D0
	protected void SetState(bool value) { }

	// RVA: 0x1074780 Offset: 0x1073B80 VA: 0x181074780
	protected void Awake() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

}

public class TOD_RenderAtDay : TOD_Render // TypeDefIndex: 8126
{	// Methods

	// RVA: 0x10745C0 Offset: 0x10739C0 VA: 0x1810745C0
	protected void Start() { }

	// RVA: 0x1074630 Offset: 0x1073A30 VA: 0x181074630
	protected void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class TOD_RenderAtNight : TOD_Render // TypeDefIndex: 8127
{	// Methods

	// RVA: 0x10746A0 Offset: 0x1073AA0 VA: 0x1810746A0
	protected void Start() { }

	// RVA: 0x1074710 Offset: 0x1073B10 VA: 0x181074710
	protected void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class TOD_WeatherManager : MonoBehaviour // TypeDefIndex: 8128
{	// Fields
	public ParticleSystem RainParticleSystem; // 0x18
	public float FadeTime; // 0x20
	public TOD_WeatherManager.RainType Rain; // 0x24
	public TOD_WeatherManager.CloudType Clouds; // 0x28
	public TOD_WeatherManager.AtmosphereType Atmosphere; // 0x2C
	private float cloudOpacityMax; // 0x30
	private float cloudBrightnessMax; // 0x34
	private float atmosphereBrightnessMax; // 0x38
	private float rainEmissionMax; // 0x3C
	private float cloudOpacity; // 0x40
	private float cloudCoverage; // 0x44
	private float cloudBrightness; // 0x48
	private float atmosphereFog; // 0x4C
	private float atmosphereBrightness; // 0x50
	private float rainEmission; // 0x54

	// Methods

	// RVA: 0x12D7660 Offset: 0x12D6A60 VA: 0x1812D7660
	private float GetRainEmission() { }

	// RVA: 0x12D7700 Offset: 0x12D6B00 VA: 0x1812D7700
	private void SetRainEmission(float value) { }

	// RVA: 0x12D77A0 Offset: 0x12D6BA0 VA: 0x1812D77A0
	protected void Start() { }

	// RVA: 0x12D7870 Offset: 0x12D6C70 VA: 0x1812D7870
	protected void Update() { }

	// RVA: 0x4C4CC0 Offset: 0x4C40C0 VA: 0x1804C4CC0
	public void .ctor() { }

}

public enum TOD_WeatherManager.RainType // TypeDefIndex: 8129
{	// Fields
	public int value__; // 0x0
	public const TOD_WeatherManager.RainType None = 0;
	public const TOD_WeatherManager.RainType Light = 1;
	public const TOD_WeatherManager.RainType Heavy = 2;

}

public enum TOD_WeatherManager.CloudType // TypeDefIndex: 8130
{	// Fields
	public int value__; // 0x0
	public const TOD_WeatherManager.CloudType None = 0;
	public const TOD_WeatherManager.CloudType Few = 1;
	public const TOD_WeatherManager.CloudType Scattered = 2;
	public const TOD_WeatherManager.CloudType Broken = 3;
	public const TOD_WeatherManager.CloudType Overcast = 4;

}

public enum TOD_WeatherManager.AtmosphereType // TypeDefIndex: 8131
{	// Fields
	public int value__; // 0x0
	public const TOD_WeatherManager.AtmosphereType Clear = 0;
	public const TOD_WeatherManager.AtmosphereType Storm = 1;
	public const TOD_WeatherManager.AtmosphereType Dust = 2;
	public const TOD_WeatherManager.AtmosphereType Fog = 3;

}

