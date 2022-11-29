public class TOD_Animation : MonoBehaviour // TypeDefIndex: 8086
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float CameraMovement; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float WindDegrees; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float WindSpeed; 
	[CompilerGeneratedAttribute] 
	private Vector3 <CloudUV>k__BackingField; 
	private TOD_Sky sky; 

	public Vector3 CloudUV { get; set; }
	public Vector3 OffsetUV { get; }


	[CompilerGeneratedAttribute] 
	public Vector3 get_CloudUV() { }

	[CompilerGeneratedAttribute] 
	public void set_CloudUV(Vector3 value) { }

	public Vector3 get_OffsetUV() { }

	protected void Start() { }

	public void Update() { }

	public void .ctor() { }

}

public class TOD_MinAttribute : PropertyAttribute // TypeDefIndex: 8087
{
	public float min; 


	public void .ctor(float min) { }

}

public class TOD_MaxAttribute : PropertyAttribute // TypeDefIndex: 8088
{
	public float max; 


	public void .ctor(float max) { }

}

public class TOD_RangeAttribute : PropertyAttribute // TypeDefIndex: 8089
{
	public float min; 
	public float max; 


	public void .ctor(float min, float max) { }

}

public class TOD_Billboard : MonoBehaviour // TypeDefIndex: 8090
{
	public float Altitude; 
	public float Azimuth; 
	public float Distance; 
	public float Size; 


	private T GetComponentInParents<T>() { }
	/* GenericInstMethod :
	|
	|-TOD_Billboard.GetComponentInParents<object>
	*/

	public void .ctor() { }

}

public class TOD_Camera : MonoBehaviour // TypeDefIndex: 8091
{
	public TOD_Sky sky; 
	public bool DomePosToCamera; 
	public Vector3 DomePosOffset; 
	public bool DomeScaleToFarClip; 
	public float DomeScaleFactor; 
	private Camera cameraComponent; 
	private Transform cameraTransform; 

	public bool HDR { get; }
	public float NearClipPlane { get; }
	public float FarClipPlane { get; }
	public Color BackgroundColor { get; }


	public bool get_HDR() { }

	public float get_NearClipPlane() { }

	public float get_FarClipPlane() { }

	public Color get_BackgroundColor() { }

	protected void OnValidate() { }

	protected void OnEnable() { }

	protected void Update() { }

	protected void OnPreCull() { }

	private TOD_Sky FindSky(bool fallback = False) { }

	public void DoDomeScaleToFarClip() { }

	public void DoDomePosToCamera() { }

	public void .ctor() { }

}

public class TOD_Components : MonoBehaviour // TypeDefIndex: 8092
{
	public GameObject Space; 
	public GameObject Stars; 
	public GameObject Sun; 
	public GameObject Moon; 
	public GameObject Atmosphere; 
	public GameObject Clear; 
	public GameObject Clouds; 
	public GameObject Billboards; 
	public GameObject Light; 
	[CompilerGeneratedAttribute] 
	private Transform <DomeTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <SpaceTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <StarTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <SunTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <MoonTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <AtmosphereTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <ClearTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <CloudTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <BillboardTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Transform <LightTransform>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <SpaceRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <StarRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <SunRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <MoonRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <AtmosphereRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <ClearRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer <CloudRenderer>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Renderer[] <BillboardRenderers>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <SpaceMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <StarMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <SunMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <MoonMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <AtmosphereMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <ClearMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter <CloudMeshFilter>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private MeshFilter[] <BillboardMeshFilters>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <SpaceMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <StarMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <SunMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <MoonMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <AtmosphereMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <ClearMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material <CloudMaterial>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Material[] <BillboardMaterials>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Light <LightSource>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Sky <Sky>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Animation <Animation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Time <Time>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Camera <Camera>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Rays <Rays>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Scattering <Scattering>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Shadows <Shadows>k__BackingField; 

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


	[CompilerGeneratedAttribute] 
	public Transform get_DomeTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_DomeTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_SpaceTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_SpaceTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_StarTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_StarTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_SunTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_SunTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_MoonTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_MoonTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_AtmosphereTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_AtmosphereTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_ClearTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_ClearTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_CloudTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_CloudTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_BillboardTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_BillboardTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Transform get_LightTransform() { }

	[CompilerGeneratedAttribute] 
	public void set_LightTransform(Transform value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_SpaceRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_SpaceRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_StarRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_StarRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_SunRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_SunRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_MoonRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_MoonRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_AtmosphereRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_AtmosphereRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_ClearRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_ClearRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer get_CloudRenderer() { }

	[CompilerGeneratedAttribute] 
	public void set_CloudRenderer(Renderer value) { }

	[CompilerGeneratedAttribute] 
	public Renderer[] get_BillboardRenderers() { }

	[CompilerGeneratedAttribute] 
	public void set_BillboardRenderers(Renderer[] value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_SpaceMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_SpaceMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_StarMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_StarMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_SunMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_SunMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_MoonMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_MoonMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_AtmosphereMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_AtmosphereMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_ClearMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_ClearMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter get_CloudMeshFilter() { }

	[CompilerGeneratedAttribute] 
	public void set_CloudMeshFilter(MeshFilter value) { }

	[CompilerGeneratedAttribute] 
	public MeshFilter[] get_BillboardMeshFilters() { }

	[CompilerGeneratedAttribute] 
	public void set_BillboardMeshFilters(MeshFilter[] value) { }

	[CompilerGeneratedAttribute] 
	public Material get_SpaceMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_SpaceMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_StarMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_StarMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_SunMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_SunMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_MoonMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_MoonMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_AtmosphereMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_AtmosphereMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_ClearMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_ClearMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material get_CloudMaterial() { }

	[CompilerGeneratedAttribute] 
	public void set_CloudMaterial(Material value) { }

	[CompilerGeneratedAttribute] 
	public Material[] get_BillboardMaterials() { }

	[CompilerGeneratedAttribute] 
	public void set_BillboardMaterials(Material[] value) { }

	[CompilerGeneratedAttribute] 
	public Light get_LightSource() { }

	[CompilerGeneratedAttribute] 
	public void set_LightSource(Light value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Sky get_Sky() { }

	[CompilerGeneratedAttribute] 
	public void set_Sky(TOD_Sky value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Animation get_Animation() { }

	[CompilerGeneratedAttribute] 
	public void set_Animation(TOD_Animation value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Time get_Time() { }

	[CompilerGeneratedAttribute] 
	public void set_Time(TOD_Time value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Camera get_Camera() { }

	[CompilerGeneratedAttribute] 
	public void set_Camera(TOD_Camera value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Rays get_Rays() { }

	[CompilerGeneratedAttribute] 
	public void set_Rays(TOD_Rays value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Scattering get_Scattering() { }

	[CompilerGeneratedAttribute] 
	public void set_Scattering(TOD_Scattering value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Shadows get_Shadows() { }

	[CompilerGeneratedAttribute] 
	public void set_Shadows(TOD_Shadows value) { }

	public void Initialize() { }

	public void .ctor() { }

}

public enum TOD_MoonPositionType // TypeDefIndex: 8093
{
	public int value__; 
	public const TOD_MoonPositionType OppositeToSun = 0;
	public const TOD_MoonPositionType Realistic = 1;

}

public enum TOD_StarsPositionType // TypeDefIndex: 8094
{
	public int value__; 
	public const TOD_StarsPositionType Static = 0;
	public const TOD_StarsPositionType Rotating = 1;

}

public enum TOD_FogType // TypeDefIndex: 8095
{
	public int value__; 
	public const TOD_FogType None = 0;
	public const TOD_FogType Atmosphere = 1;
	public const TOD_FogType Directional = 2;
	public const TOD_FogType Gradient = 3;

}

public enum TOD_AmbientType // TypeDefIndex: 8096
{
	public int value__; 
	public const TOD_AmbientType None = 0;
	public const TOD_AmbientType Color = 1;
	public const TOD_AmbientType Gradient = 2;
	public const TOD_AmbientType Spherical = 3;

}

public enum TOD_ReflectionType // TypeDefIndex: 8097
{
	public int value__; 
	public const TOD_ReflectionType None = 0;
	public const TOD_ReflectionType Cubemap = 1;

}

public enum TOD_ColorSpaceType // TypeDefIndex: 8098
{
	public int value__; 
	public const TOD_ColorSpaceType Auto = 0;
	public const TOD_ColorSpaceType Linear = 1;
	public const TOD_ColorSpaceType Gamma = 2;

}

public enum TOD_ColorRangeType // TypeDefIndex: 8099
{
	public int value__; 
	public const TOD_ColorRangeType Auto = 0;
	public const TOD_ColorRangeType HDR = 1;
	public const TOD_ColorRangeType LDR = 2;

}

public enum TOD_ColorOutputType // TypeDefIndex: 8100
{
	public int value__; 
	public const TOD_ColorOutputType Raw = 0;
	public const TOD_ColorOutputType Dithered = 1;

}

public enum TOD_CloudQualityType // TypeDefIndex: 8101
{
	public int value__; 
	public const TOD_CloudQualityType Low = 0;
	public const TOD_CloudQualityType Medium = 1;
	public const TOD_CloudQualityType High = 2;

}

public enum TOD_MeshQualityType // TypeDefIndex: 8102
{
	public int value__; 
	public const TOD_MeshQualityType Low = 0;
	public const TOD_MeshQualityType Medium = 1;
	public const TOD_MeshQualityType High = 2;

}

public enum TOD_StarQualityType // TypeDefIndex: 8103
{
	public int value__; 
	public const TOD_StarQualityType Low = 0;
	public const TOD_StarQualityType Medium = 1;
	public const TOD_StarQualityType High = 2;

}

public enum TOD_SkyQualityType // TypeDefIndex: 8104
{
	public int value__; 
	public const TOD_SkyQualityType PerVertex = 0;
	public const TOD_SkyQualityType PerPixel = 1;

}

public abstract class TOD_ImageEffect : MonoBehaviour // TypeDefIndex: 8105
{
	public TOD_Sky sky; 
	protected Camera cam; 
	private bool supportsDepth; 
	private bool supportsHdr; 
	private static Vector3[] frustumCornersArray; 


	protected Material CreateMaterial(Shader shader) { }

	private TOD_Sky FindSky(bool fallback = False) { }

	protected void Awake() { }

	protected bool CheckSupport(bool needDepth = False, bool needHdr = False) { }

	protected void DrawBorder(RenderTexture dest, Material material) { }

	protected Matrix4x4 FrustumCorners() { }

	protected RenderTexture GetSkyMask(RenderTexture source, Material skyMaskMaterial, Material screenClearMaterial, TOD_ImageEffect.ResolutionType resolution, Vector3 lightPos, int blurIterations, float blurRadius, float maxRadius) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

public enum TOD_ImageEffect.ResolutionType // TypeDefIndex: 8106
{
	public int value__; 
	public const TOD_ImageEffect.ResolutionType Low = 0;
	public const TOD_ImageEffect.ResolutionType Normal = 1;
	public const TOD_ImageEffect.ResolutionType High = 2;

}

public class TOD_Parameters // TypeDefIndex: 8107
{
	public TOD_CycleParameters Cycle; 
	public TOD_WorldParameters World; 
	public TOD_AtmosphereParameters Atmosphere; 
	public TOD_DayParameters Day; 
	public TOD_NightParameters Night; 
	public TOD_SunParameters Sun; 
	public TOD_MoonParameters Moon; 
	public TOD_LightParameters Light; 
	public TOD_StarParameters Stars; 
	public TOD_CloudParameters Clouds; 
	public TOD_FogParameters Fog; 
	public TOD_AmbientParameters Ambient; 
	public TOD_ReflectionParameters Reflection; 


	public void .ctor() { }

	public void .ctor(TOD_Sky sky) { }

	public void ToSky(TOD_Sky sky) { }

}

public class TOD_CycleParameters // TypeDefIndex: 8108
{
	[TooltipAttribute] 
	public float Hour; 
	[TooltipAttribute] 
	public int Day; 
	[TooltipAttribute] 
	public int Month; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public int Year; 

	public DateTime DateTime { get; set; }
	public long Ticks { get; set; }


	public DateTime get_DateTime() { }

	public void set_DateTime(DateTime value) { }

	public long get_Ticks() { }

	public void set_Ticks(long value) { }

	public void .ctor() { }

}

public class TOD_WorldParameters // TypeDefIndex: 8109
{
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Latitude; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float Longitude; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float UTC; 


	public void .ctor() { }

}

public class TOD_AtmosphereParameters // TypeDefIndex: 8110
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float RayleighMultiplier; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MieMultiplier; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Brightness; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Contrast; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Directionality; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Fogginess; 


	public void .ctor() { }

}

public class TOD_DayParameters // TypeDefIndex: 8111
{
	[TooltipAttribute] 
	public Gradient SunColor; 
	[TooltipAttribute] 
	public Gradient LightColor; 
	[TooltipAttribute] 
	public Gradient RayColor; 
	[TooltipAttribute] 
	public Gradient SkyColor; 
	[TooltipAttribute] 
	public Gradient CloudColor; 
	[TooltipAttribute] 
	public Gradient FogColor; 
	[TooltipAttribute] 
	public Gradient AmbientColor; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float LightIntensity; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float ShadowStrength; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float AmbientMultiplier; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float ReflectionMultiplier; 


	public void .ctor() { }

}

public class TOD_NightParameters // TypeDefIndex: 8112
{
	[TooltipAttribute] 
	public Gradient MoonColor; 
	[TooltipAttribute] 
	public Gradient LightColor; 
	[TooltipAttribute] 
	public Gradient RayColor; 
	[TooltipAttribute] 
	public Gradient SkyColor; 
	[TooltipAttribute] 
	public Gradient CloudColor; 
	[TooltipAttribute] 
	public Gradient FogColor; 
	[TooltipAttribute] 
	public Gradient AmbientColor; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float LightIntensity; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float ShadowStrength; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float AmbientMultiplier; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float ReflectionMultiplier; 


	public void .ctor() { }

}

public class TOD_SunParameters // TypeDefIndex: 8113
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MeshSize; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MeshBrightness; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MeshContrast; 


	public void .ctor() { }

}

public class TOD_MoonParameters // TypeDefIndex: 8114
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MeshSize; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MeshBrightness; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MeshContrast; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float HaloSize; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float HaloBrightness; 
	[TooltipAttribute] 
	public TOD_MoonPositionType Position; 


	public void .ctor() { }

}

public class TOD_StarParameters // TypeDefIndex: 8115
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Size; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Brightness; 
	[TooltipAttribute] 
	public TOD_StarsPositionType Position; 


	public void .ctor() { }

}

public class TOD_CloudParameters // TypeDefIndex: 8116
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Size; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Opacity; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Coverage; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Sharpness; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Coloring; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Attenuation; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float Saturation; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Scattering; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Brightness; 


	public void .ctor() { }

}

public class TOD_LightParameters // TypeDefIndex: 8117
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float UpdateInterval; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float MinimumHeight; 


	public void .ctor() { }

}

public class TOD_FogParameters // TypeDefIndex: 8118
{
	[TooltipAttribute] 
	public TOD_FogType Mode; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public float HeightBias; 


	public void .ctor() { }

}

public class TOD_AmbientParameters // TypeDefIndex: 8119
{
	[TooltipAttribute] 
	public TOD_AmbientType Mode; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Saturation; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float UpdateInterval; 


	public void .ctor() { }

}

public class TOD_ReflectionParameters // TypeDefIndex: 8120
{
	[TooltipAttribute] 
	public TOD_ReflectionType Mode; 
	[TooltipAttribute] 
	public ReflectionProbeClearFlags ClearFlags; 
	[TooltipAttribute] 
	public LayerMask CullingMask; 
	[TooltipAttribute] 
	public GameObject ProbePrefab; 


	public void .ctor() { }

}

public class TOD_Rays : TOD_ImageEffect // TypeDefIndex: 8121
{
	public Shader GodRayShader; 
	public Shader ScreenClearShader; 
	public Shader SkyMaskShader; 
	[TooltipAttribute] 
	public bool UseDepthTexture; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public TOD_Rays.BlendModeType BlendMode; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float Intensity; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public TOD_ImageEffect.ResolutionType Resolution; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public int BlurIterations; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float BlurRadius; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MaxRadius; 
	private Material godRayMaterial; 
	private Material screenClearMaterial; 
	private Material skyMaskMaterial; 
	private const int PASS_SCREEN = 0;
	private const int PASS_ADD = 1;


	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public enum TOD_Rays.BlendModeType // TypeDefIndex: 8122
{
	public int value__; 
	public const TOD_Rays.BlendModeType Screen = 0;
	public const TOD_Rays.BlendModeType Add = 1;

}

public class TOD_Resources : MonoBehaviour // TypeDefIndex: 8123
{
	public Material Skybox; 
	public Mesh MoonLOD0; 
	public Mesh MoonLOD1; 
	public Mesh MoonLOD2; 
	public Mesh SkyLOD0; 
	public Mesh SkyLOD1; 
	public Mesh SkyLOD2; 
	public Mesh CloudsLOD0; 
	public Mesh CloudsLOD1; 
	public Mesh CloudsLOD2; 
	public Mesh StarsLOD0; 
	public Mesh StarsLOD1; 
	public Mesh StarsLOD2; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunLightColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonLightColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunSkyColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonSkyColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunMeshColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonMeshColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunCloudColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonCloudColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_FogColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_GroundColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_AmbientColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_LightDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_LocalSunDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_LocalMoonDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_LocalLightDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_Contrast>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_Brightness>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_Fogginess>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_Directionality>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonHaloPower>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonHaloColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudSize>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudOpacity>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudCoverage>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudSharpness>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudDensity>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudColoring>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudAttenuation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudSaturation>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudScattering>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudBrightness>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudMultiplier>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudOffset>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_CloudWind>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_StarSize>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_StarBrightness>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_StarVisibility>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunMeshContrast>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_SunMeshBrightness>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonMeshContrast>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_MoonMeshBrightness>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_kBetaMie>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_kSun>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_k4PI>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_kRadius>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_kScale>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_World2Sky>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private int <ID_Sky2World>k__BackingField; 

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


	[CompilerGeneratedAttribute] 
	public int get_ID_SunLightColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunLightColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonLightColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonLightColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_SunSkyColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunSkyColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonSkyColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonSkyColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_SunMeshColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunMeshColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonMeshColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonMeshColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_SunCloudColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunCloudColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonCloudColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonCloudColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_FogColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_FogColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_GroundColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_GroundColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_AmbientColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_AmbientColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_SunDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunDirection(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonDirection(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_LightDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_LightDirection(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_LocalSunDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_LocalSunDirection(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_LocalMoonDirection(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_LocalLightDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_LocalLightDirection(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_Contrast() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_Contrast(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_Brightness() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_Brightness(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_Fogginess() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_Fogginess(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_Directionality() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_Directionality(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonHaloPower() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonHaloPower(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonHaloColor() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonHaloColor(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudSize() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudSize(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudOpacity() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudOpacity(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudCoverage() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudCoverage(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudSharpness() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudSharpness(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudDensity() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudDensity(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudColoring() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudColoring(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudAttenuation() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudAttenuation(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudSaturation() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudSaturation(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudScattering() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudScattering(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudBrightness() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudBrightness(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudMultiplier() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudMultiplier(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudOffset() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudOffset(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_CloudWind() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_CloudWind(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_StarSize() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_StarSize(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_StarBrightness() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_StarBrightness(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_StarVisibility() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_StarVisibility(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_SunMeshContrast() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunMeshContrast(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_SunMeshBrightness() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_SunMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonMeshContrast() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonMeshContrast(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_MoonMeshBrightness() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_MoonMeshBrightness(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_kBetaMie() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_kBetaMie(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_kSun() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_kSun(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_k4PI() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_k4PI(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_kRadius() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_kRadius(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_kScale() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_kScale(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_World2Sky() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_World2Sky(int value) { }

	[CompilerGeneratedAttribute] 
	public int get_ID_Sky2World() { }

	[CompilerGeneratedAttribute] 
	private void set_ID_Sky2World(int value) { }

	public void Initialize() { }

	public void .ctor() { }

}

public class TOD_Scattering : TOD_ImageEffect // TypeDefIndex: 8124
{
	public Shader ScatteringShader; 
	public Shader ScreenClearShader; 
	public Shader SkyMaskShader; 
	public Texture2D DitheringTexture; 
	[TooltipAttribute] 
	public bool SinglePass; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float GlobalDensity; 
	[TooltipAttribute] 
	[RangeAttribute] 
	public float HeightFalloff; 
	[TooltipAttribute] 
	public float StartDistance; 
	[TooltipAttribute] 
	public float ZeroLevel; 
	[HeaderAttribute] 
	[TooltipAttribute] 
	public TOD_ImageEffect.ResolutionType Resolution; 
	[TooltipAttribute] 
	[TOD_RangeAttribute] 
	public int BlurIterations; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float BlurRadius; 
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float MaxRadius; 
	private Material scatteringMaterial; 
	private Material screenClearMaterial; 
	private Material skyMaskMaterial; 


	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void OnPreCull() { }

	protected void OnPostRender() { }

	[ImageEffectOpaque] 
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class TOD_Shadows : TOD_ImageEffect // TypeDefIndex: 8125
{
	public Shader ShadowShader; 
	public Texture2D CloudTexture; 
	[HeaderAttribute] 
	[RangeAttribute] 
	public float Cutoff; 
	[RangeAttribute] 
	public float Fade; 
	[RangeAttribute] 
	public float Intensity; 
	private Material shadowMaterial; 


	protected void OnEnable() { }

	protected void OnDisable() { }

	[ImageEffectOpaque] 
	protected void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public class TOD_Sky : MonoBehaviour // TypeDefIndex: 8126
{
	private static List<TOD_Sky> instances; 
	[TooltipAttribute] 
	public TOD_ColorSpaceType ColorSpace; 
	[TooltipAttribute] 
	public TOD_ColorRangeType ColorRange; 
	[TooltipAttribute] 
	public TOD_ColorOutputType ColorOutput; 
	[TooltipAttribute] 
	public TOD_SkyQualityType SkyQuality; 
	[TooltipAttribute] 
	public TOD_CloudQualityType CloudQuality; 
	[TooltipAttribute] 
	public TOD_MeshQualityType MeshQuality; 
	[TooltipAttribute] 
	public TOD_StarQualityType StarQuality; 
	public TOD_CycleParameters Cycle; 
	public TOD_WorldParameters World; 
	public TOD_AtmosphereParameters Atmosphere; 
	public TOD_DayParameters Day; 
	public TOD_NightParameters Night; 
	public TOD_SunParameters Sun; 
	public TOD_MoonParameters Moon; 
	public TOD_StarParameters Stars; 
	public TOD_CloudParameters Clouds; 
	public TOD_LightParameters Light; 
	public TOD_FogParameters Fog; 
	public TOD_AmbientParameters Ambient; 
	public TOD_ReflectionParameters Reflection; 
	[CompilerGeneratedAttribute] 
	private bool <Initialized>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Components <Components>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TOD_Resources <Resources>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsDay>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private bool <IsNight>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <LerpValue>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <SunZenith>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <SunAltitude>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <SunAzimuth>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <MoonZenith>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <MoonAltitude>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <MoonAzimuth>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <SunsetTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <SunriseTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <LocalSiderealTime>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <SunVisibility>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private float <MoonVisibility>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <SunDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <MoonDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <LightDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <LocalSunDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <LocalMoonDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Vector3 <LocalLightDirection>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <SunLightColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <MoonLightColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <SunRayColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <MoonRayColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <SunSkyColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <MoonSkyColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <SunMeshColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <MoonMeshColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <SunCloudColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <MoonCloudColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <FogColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <GroundColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <AmbientColor>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private Color <MoonHaloColor>k__BackingField; 
	private TOD_Sky.ReflectionProbeState ReflectionCur; 
	private TOD_Sky.ReflectionProbeState ReflectionSrc; 
	private TOD_Sky.ReflectionProbeState ReflectionDst; 
	public static float ReflectionUpdateSpeed; 
	public static int ReflectionResolution; 
	public static float ReflectionUpdateInterval; 
	public static ReflectionProbeTimeSlicingMode ReflectionTimeSlicing; 
	private float timeSinceLightUpdate; 
	private float timeSinceAmbientUpdate; 
	private float timeSinceReflectionUpdate; 
	private const int TOD_SAMPLES = 2;
	private Vector3 kBetaMie; 
	private Vector4 kSun; 
	private Vector4 k4PI; 
	private Vector4 kRadius; 
	private Vector4 kScale; 
	private const float pi = 3,141593;
	private const float tau = 6,283185;

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


	public static List<TOD_Sky> get_Instances() { }

	public static TOD_Sky get_Instance() { }

	[CompilerGeneratedAttribute] 
	public bool get_Initialized() { }

	[CompilerGeneratedAttribute] 
	private void set_Initialized(bool value) { }

	public bool get_Headless() { }

	[CompilerGeneratedAttribute] 
	public TOD_Components get_Components() { }

	[CompilerGeneratedAttribute] 
	private void set_Components(TOD_Components value) { }

	[CompilerGeneratedAttribute] 
	public TOD_Resources get_Resources() { }

	[CompilerGeneratedAttribute] 
	private void set_Resources(TOD_Resources value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsDay() { }

	[CompilerGeneratedAttribute] 
	private void set_IsDay(bool value) { }

	[CompilerGeneratedAttribute] 
	public bool get_IsNight() { }

	[CompilerGeneratedAttribute] 
	private void set_IsNight(bool value) { }

	public float get_Radius() { }

	public float get_Diameter() { }

	[CompilerGeneratedAttribute] 
	public float get_LerpValue() { }

	[CompilerGeneratedAttribute] 
	private void set_LerpValue(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_SunZenith() { }

	[CompilerGeneratedAttribute] 
	private void set_SunZenith(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_SunAltitude() { }

	[CompilerGeneratedAttribute] 
	private void set_SunAltitude(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_SunAzimuth() { }

	[CompilerGeneratedAttribute] 
	private void set_SunAzimuth(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_MoonZenith() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonZenith(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_MoonAltitude() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonAltitude(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_MoonAzimuth() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonAzimuth(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_SunsetTime() { }

	[CompilerGeneratedAttribute] 
	private void set_SunsetTime(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_SunriseTime() { }

	[CompilerGeneratedAttribute] 
	private void set_SunriseTime(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_LocalSiderealTime() { }

	[CompilerGeneratedAttribute] 
	private void set_LocalSiderealTime(float value) { }

	public float get_LightZenith() { }

	public float get_LightIntensity() { }

	[CompilerGeneratedAttribute] 
	public float get_SunVisibility() { }

	[CompilerGeneratedAttribute] 
	private void set_SunVisibility(float value) { }

	[CompilerGeneratedAttribute] 
	public float get_MoonVisibility() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonVisibility(float value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_SunDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_SunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_MoonDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_LightDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_LightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_LocalSunDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_LocalSunDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_LocalMoonDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_LocalMoonDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Vector3 get_LocalLightDirection() { }

	[CompilerGeneratedAttribute] 
	private void set_LocalLightDirection(Vector3 value) { }

	[CompilerGeneratedAttribute] 
	public Color get_SunLightColor() { }

	[CompilerGeneratedAttribute] 
	private void set_SunLightColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_MoonLightColor() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonLightColor(Color value) { }

	public Color get_LightColor() { }

	[CompilerGeneratedAttribute] 
	public Color get_SunRayColor() { }

	[CompilerGeneratedAttribute] 
	public void set_SunRayColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_MoonRayColor() { }

	[CompilerGeneratedAttribute] 
	public void set_MoonRayColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_SunSkyColor() { }

	[CompilerGeneratedAttribute] 
	private void set_SunSkyColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_MoonSkyColor() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonSkyColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_SunMeshColor() { }

	[CompilerGeneratedAttribute] 
	private void set_SunMeshColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_MoonMeshColor() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonMeshColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_SunCloudColor() { }

	[CompilerGeneratedAttribute] 
	private void set_SunCloudColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_MoonCloudColor() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonCloudColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_FogColor() { }

	[CompilerGeneratedAttribute] 
	private void set_FogColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_GroundColor() { }

	[CompilerGeneratedAttribute] 
	private void set_GroundColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_AmbientColor() { }

	[CompilerGeneratedAttribute] 
	private void set_AmbientColor(Color value) { }

	[CompilerGeneratedAttribute] 
	public Color get_MoonHaloColor() { }

	[CompilerGeneratedAttribute] 
	private void set_MoonHaloColor(Color value) { }

	public ReflectionProbe get_Probe() { }

	public GameObject get_ProbeInstance() { }

	public Vector3 OrbitalToUnity(float radius, float theta, float phi) { }

	public Vector3 OrbitalToLocal(float theta, float phi) { }

	public Color SampleAtmosphere(Vector3 direction, bool directLight = True) { }

	public SphericalHarmonicsL2 RenderToSphericalHarmonics() { }

	public SphericalHarmonicsL2 RenderToSphericalHarmonics(float intensity, float saturation) { }

	public void RenderToCubemap(RenderTexture targetTexture) { }

	public void RenderToProbe() { }

	public bool ReflectionIsUpdating() { }

	private void UpdateProbeBlending(float lerp) { }

	private void UpdateProbeProperties(ReflectionProbe probe) { }

	public Color SampleFogColor(bool directLight = True) { }

	public Color SampleSkyColor() { }

	public Color SampleEquatorColor() { }

	public void UpdateFog() { }

	public void UpdateAmbient() { }

	public void UpdateReflection() { }

	public void DelayReflectionUpdate() { }

	public void LoadParameters(string xml) { }

	public string SaveParameters() { }

	private void UpdateQualitySettings() { }

	private void UpdateRenderSettings() { }

	private void UpdateShaderKeywords() { }

	private void UpdateShaderProperties() { }

	private float ShaderScale(float inCos) { }

	private float ShaderMiePhase(float eyeCos, float eyeCos2) { }

	private float ShaderRayleighPhase(float eyeCos2) { }

	private Color ShaderNightSkyColor(Vector3 dir) { }

	private Color ShaderMoonHaloColor(Vector3 dir) { }

	private Color TOD_HDR2LDR(Color color) { }

	private Color TOD_GAMMA2LINEAR(Color color) { }

	private Color TOD_LINEAR2GAMMA(Color color) { }

	private Color ShaderScatteringColor(Vector3 dir, bool directLight = True) { }

	private void Initialize() { }

	private void Cleanup() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void LateUpdate() { }

	protected void OnValidate() { }

	private void UpdateScattering() { }

	private void UpdateCelestials() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class TOD_Sky.ReflectionProbeState // TypeDefIndex: 8127
{
	public ReflectionProbe Probe; 
	public GameObject ProbeInstance; 
	public int ProbeRenderID; 


	public void InitializePrimary(Vector3 position, GameObject prefab) { }

	public void InitializeSecondary(Vector3 position) { }

	public void .ctor() { }

}

public class TOD_Time : MonoBehaviour // TypeDefIndex: 8128
{
	[TooltipAttribute] 
	[TOD_MinAttribute] 
	public float DayLengthInMinutes; 
	[TooltipAttribute] 
	public bool ProgressTime; 
	[TooltipAttribute] 
	public bool UseDeviceDate; 
	[TooltipAttribute] 
	public bool UseDeviceTime; 
	[TooltipAttribute] 
	public bool UseTimeCurve; 
	[TooltipAttribute] 
	public AnimationCurve TimeCurve; 
	[CompilerGeneratedAttribute] 
	private Action OnSecond; 
	[CompilerGeneratedAttribute] 
	private Action OnMinute; 
	[CompilerGeneratedAttribute] 
	private Action OnHour; 
	[CompilerGeneratedAttribute] 
	private Action OnDay; 
	[CompilerGeneratedAttribute] 
	private Action OnMonth; 
	[CompilerGeneratedAttribute] 
	private Action OnYear; 
	[CompilerGeneratedAttribute] 
	private Action OnSunrise; 
	[CompilerGeneratedAttribute] 
	private Action OnSunset; 
	private TOD_Sky sky; 
	private AnimationCurve timeCurve; 
	private AnimationCurve timeCurveInverse; 
	private float timeFraction; 


	[CompilerGeneratedAttribute] 
	public void add_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnSecond(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnMinute(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnHour(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnHour(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnDay(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnDay(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnMonth(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnYear(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnYear(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnSunrise(Action value) { }

	[CompilerGeneratedAttribute] 
	public void add_OnSunset(Action value) { }

	[CompilerGeneratedAttribute] 
	public void remove_OnSunset(Action value) { }

	public void RefreshTimeCurve() { }

	public float ApplyTimeCurve(float deltaTime) { }

	public void AddHours(float hours, bool adjust = True) { }

	public void AddSeconds(float seconds, bool adjust = True) { }

	private void CalculateLinearTangents(Keyframe[] keys) { }

	private void ApproximateCurve(AnimationCurve source, out AnimationCurve approxCurve, out AnimationCurve approxInverse) { }

	protected void Awake() { }

	protected void Update() { }

	public void .ctor() { }

}

public static class TOD_Util // TypeDefIndex: 8129
{

	public static Color MulRGB(Color color, float multiplier) { }

	public static Color MulRGBA(Color color, float multiplier) { }

	public static Color PowRGB(Color color, float power) { }

	public static Color PowRGBA(Color color, float power) { }

	public static Color SatRGB(Color color, float saturation) { }

	public static Color SatRGBA(Color color, float saturation) { }

	public static Color AdjustRGB(Color color, float intensity, float saturation) { }

	public static Color AdjustRGBA(Color color, float intensity, float saturation) { }

	public static Color ApplyAlpha(Color color) { }

	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-TOD_Util.Swap<object>
	|-TOD_Util.Swap<TOD_Sky.ReflectionProbeState>
	*/

}

public abstract class TOD_Audio : MonoBehaviour // TypeDefIndex: 8130
{
	private AudioSource audioComponent; 


	protected float GetVolume() { }

	protected void SetVolume(float value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_AudioAtDay : TOD_Audio // TypeDefIndex: 8131
{
	public float fadeTime; 
	private float lerpTime; 
	private float maxVolume; 


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_AudioAtNight : TOD_Audio // TypeDefIndex: 8132
{
	public float fadeTime; 
	private float lerpTime; 
	private float maxVolume; 


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_AudioAtTime : TOD_Audio // TypeDefIndex: 8133
{
	public AnimationCurve Volume; 


	protected void Update() { }

	public void .ctor() { }

}

public abstract class TOD_Light : MonoBehaviour // TypeDefIndex: 8134
{
	private Light lightComponent; 


	protected float GetIntensity() { }

	protected void SetIntensity(float value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_LightAtDay : TOD_Light // TypeDefIndex: 8135
{
	public float fadeTime; 
	private float lerpTime; 
	private float maxIntensity; 


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_LightAtNight : TOD_Light // TypeDefIndex: 8136
{
	public float fadeTime; 
	private float lerpTime; 
	private float maxIntensity; 


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_LightAtTime : TOD_Light // TypeDefIndex: 8137
{
	public AnimationCurve Intensity; 


	protected void Update() { }

	public void .ctor() { }

}

public class TOD_LoadSkyFromFile : MonoBehaviour // TypeDefIndex: 8138
{
	public TOD_Sky sky; 
	public TextAsset textAsset; 


	protected void Start() { }

	public void .ctor() { }

}

public abstract class TOD_Particle : MonoBehaviour // TypeDefIndex: 8139
{
	private ParticleSystem particleComponent; 


	protected float GetEmission() { }

	protected void SetEmission(float value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_ParticleAtDay : TOD_Particle // TypeDefIndex: 8140
{
	public float fadeTime; 
	private float lerpTime; 
	private float maxEmission; 


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_ParticleAtNight : TOD_Particle // TypeDefIndex: 8141
{
	public float fadeTime; 
	private float lerpTime; 
	private float maxEmission; 


	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_ParticleAtTime : TOD_Particle // TypeDefIndex: 8142
{
	public AnimationCurve Emission; 


	protected void Update() { }

	public void .ctor() { }

}

public abstract class TOD_Render : MonoBehaviour // TypeDefIndex: 8143
{
	private Renderer rendererComponent; 


	protected void SetState(bool value) { }

	protected void Awake() { }

	protected void .ctor() { }

}

public class TOD_RenderAtDay : TOD_Render // TypeDefIndex: 8144
{

	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_RenderAtNight : TOD_Render // TypeDefIndex: 8145
{

	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public class TOD_WeatherManager : MonoBehaviour // TypeDefIndex: 8146
{
	public ParticleSystem RainParticleSystem; 
	public float FadeTime; 
	public TOD_WeatherManager.RainType Rain; 
	public TOD_WeatherManager.CloudType Clouds; 
	public TOD_WeatherManager.AtmosphereType Atmosphere; 
	private float cloudOpacityMax; 
	private float cloudBrightnessMax; 
	private float atmosphereBrightnessMax; 
	private float rainEmissionMax; 
	private float cloudOpacity; 
	private float cloudCoverage; 
	private float cloudBrightness; 
	private float atmosphereFog; 
	private float atmosphereBrightness; 
	private float rainEmission; 


	private float GetRainEmission() { }

	private void SetRainEmission(float value) { }

	protected void Start() { }

	protected void Update() { }

	public void .ctor() { }

}

public enum TOD_WeatherManager.RainType // TypeDefIndex: 8147
{
	public int value__; 
	public const TOD_WeatherManager.RainType None = 0;
	public const TOD_WeatherManager.RainType Light = 1;
	public const TOD_WeatherManager.RainType Heavy = 2;

}

public enum TOD_WeatherManager.CloudType // TypeDefIndex: 8148
{
	public int value__; 
	public const TOD_WeatherManager.CloudType None = 0;
	public const TOD_WeatherManager.CloudType Few = 1;
	public const TOD_WeatherManager.CloudType Scattered = 2;
	public const TOD_WeatherManager.CloudType Broken = 3;
	public const TOD_WeatherManager.CloudType Overcast = 4;

}

public enum TOD_WeatherManager.AtmosphereType // TypeDefIndex: 8149
{
	public int value__; 
	public const TOD_WeatherManager.AtmosphereType Clear = 0;
	public const TOD_WeatherManager.AtmosphereType Storm = 1;
	public const TOD_WeatherManager.AtmosphereType Dust = 2;
	public const TOD_WeatherManager.AtmosphereType Fog = 3;

}

