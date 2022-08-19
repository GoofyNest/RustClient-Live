public class Explosion_Bloom : MonoBehaviour // TypeDefIndex: 11486
{	// Fields
	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public Explosion_Bloom.Settings settings; // 0x18
	[SerializeField] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	[HideInInspector] // RVA: 0x71590 Offset: 0x70990 VA: 0x180071590
	private Shader m_Shader; // 0x30
	private Material m_Material; // 0x38
	private const int kMaxIterations = 16;
	private RenderTexture[] m_blurBuffer1; // 0x40
	private RenderTexture[] m_blurBuffer2; // 0x48
	private int m_Threshold; // 0x50
	private int m_Curve; // 0x54
	private int m_PrefilterOffs; // 0x58
	private int m_SampleScale; // 0x5C
	private int m_Intensity; // 0x60
	private int m_BaseTex; // 0x64

	// Properties
	public Shader shader { get; }
	public Material material { get; }
	public static bool supportsDX11 { get; }

	// Methods

	// RVA: 0x8C1140 Offset: 0x8C0540 VA: 0x1808C1140
	public Shader get_shader() { }

	// RVA: 0x8C1010 Offset: 0x8C0410 VA: 0x1808C1010
	public Material get_material() { }

	// RVA: 0x8C01B0 Offset: 0x8BF5B0 VA: 0x1808C01B0
	public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect) { }

	// RVA: 0x8C00F0 Offset: 0x8BF4F0 VA: 0x1808C00F0
	public static Material CheckShaderAndCreateMaterial(Shader s) { }

	// RVA: 0x8C11D0 Offset: 0x8C05D0 VA: 0x1808C11D0
	public static bool get_supportsDX11() { }

	// RVA: 0x8C0060 Offset: 0x8BF460 VA: 0x1808C0060
	private void Awake() { }

	// RVA: 0x8C05E0 Offset: 0x8BF9E0 VA: 0x1808C05E0
	private void OnEnable() { }

	// RVA: 0x8C0530 Offset: 0x8BF930 VA: 0x1808C0530
	private void OnDisable() { }

	// RVA: 0x8C0630 Offset: 0x8BFA30 VA: 0x1808C0630
	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	// RVA: 0x8C0F80 Offset: 0x8C0380 VA: 0x1808C0F80
	public void .ctor() { }

}

public struct Explosion_Bloom.Settings // TypeDefIndex: 11487
{	// Fields
	[SerializeField] // RVA: 0xB68B0 Offset: 0xB5CB0 VA: 0x1800B68B0
	[TooltipAttribute] // RVA: 0xB68B0 Offset: 0xB5CB0 VA: 0x1800B68B0
	public float threshold; // 0x0
	[SerializeField] // RVA: 0xB69B0 Offset: 0xB5DB0 VA: 0x1800B69B0
	[RangeAttribute] // RVA: 0xB69B0 Offset: 0xB5DB0 VA: 0x1800B69B0
	[TooltipAttribute] // RVA: 0xB69B0 Offset: 0xB5DB0 VA: 0x1800B69B0
	public float softKnee; // 0x4
	[SerializeField] // RVA: 0xB6BD0 Offset: 0xB5FD0 VA: 0x1800B6BD0
	[RangeAttribute] // RVA: 0xB6BD0 Offset: 0xB5FD0 VA: 0x1800B6BD0
	[TooltipAttribute] // RVA: 0xB6BD0 Offset: 0xB5FD0 VA: 0x1800B6BD0
	public float radius; // 0x8
	[SerializeField] // RVA: 0xB6E00 Offset: 0xB6200 VA: 0x1800B6E00
	[TooltipAttribute] // RVA: 0xB6E00 Offset: 0xB6200 VA: 0x1800B6E00
	public float intensity; // 0xC
	[SerializeField] // RVA: 0xB6EC0 Offset: 0xB62C0 VA: 0x1800B6EC0
	[TooltipAttribute] // RVA: 0xB6EC0 Offset: 0xB62C0 VA: 0x1800B6EC0
	public bool highQuality; // 0x10
	[SerializeField] // RVA: 0xB7020 Offset: 0xB6420 VA: 0x1800B7020
	[TooltipAttribute] // RVA: 0xB7020 Offset: 0xB6420 VA: 0x1800B7020
	public bool antiFlicker; // 0x11

	// Properties
	public float thresholdGamma { get; set; }
	public float thresholdLinear { get; set; }
	public static Explosion_Bloom.Settings defaultSettings { get; }

	// Methods

	// RVA: 0xF2280 Offset: 0xF1680 VA: 0x1800F2280
	public void set_thresholdGamma(float value) { }

	// RVA: 0xF9AB0 Offset: 0xF8EB0 VA: 0x1800F9AB0
	public float get_thresholdGamma() { }

	// RVA: 0xF9B30 Offset: 0xF8F30 VA: 0x1800F9B30
	public void set_thresholdLinear(float value) { }

	// RVA: 0xF9B20 Offset: 0xF8F20 VA: 0x1800F9B20
	public float get_thresholdLinear() { }

	// RVA: 0x8C6AB0 Offset: 0x8C5EB0 VA: 0x1808C6AB0
	public static Explosion_Bloom.Settings get_defaultSettings() { }

}

public class ExplosionDemoGUI : MonoBehaviour // TypeDefIndex: 11488
{	// Fields
	public GameObject[] Prefabs; // 0x18
	public float reactivateTime; // 0x20
	public Light Sun; // 0x28
	private int currentNomber; // 0x30
	private GameObject currentInstance; // 0x38
	private GUIStyle guiStyleHeader; // 0x40
	private float sunIntensity; // 0x48
	private float dpiScale; // 0x4C

	// Methods

	// RVA: 0x8BFB10 Offset: 0x8BEF10 VA: 0x1808BFB10
	private void Start() { }

	// RVA: 0x8BF7C0 Offset: 0x8BEBC0 VA: 0x1808BF7C0
	private void OnGUI() { }

	// RVA: 0x8BF5F0 Offset: 0x8BE9F0 VA: 0x1808BF5F0
	private void ChangeCurrent(int delta) { }

	// RVA: 0x8BFD30 Offset: 0x8BF130 VA: 0x1808BFD30
	public void .ctor() { }

}

public class ExplosionDemoReactivator : MonoBehaviour // TypeDefIndex: 11489
{	// Fields
	public float TimeDelayToReactivate; // 0x18

	// Methods

	// RVA: 0x8BFE70 Offset: 0x8BF270 VA: 0x1808BFE70
	private void Start() { }

	// RVA: 0x8BFDA0 Offset: 0x8BF1A0 VA: 0x1808BFDA0
	private void Reactivate() { }

	// RVA: 0x8BFEC0 Offset: 0x8BF2C0 VA: 0x1808BFEC0
	public void .ctor() { }

}

public class ExplosionPlatformActivator : MonoBehaviour // TypeDefIndex: 11490
{	// Fields
	public GameObject Effect; // 0x18
	public float TimeDelay; // 0x20
	public float DefaultRepeatTime; // 0x24
	public float NearRepeatTime; // 0x28
	private float currentTime; // 0x2C
	private float currentRepeatTime; // 0x30
	private bool canUpdate; // 0x34

	// Methods

	// RVA: 0x8BFF20 Offset: 0x8BF320 VA: 0x1808BFF20
	private void Start() { }

	// RVA: 0x8BFED0 Offset: 0x8BF2D0 VA: 0x1808BFED0
	private void Init() { }

	// RVA: 0x8BFF70 Offset: 0x8BF370 VA: 0x1808BFF70
	private void Update() { }

	// RVA: 0x8BFF00 Offset: 0x8BF300 VA: 0x1808BFF00
	private void OnTriggerEnter(Collider coll) { }

	// RVA: 0x8BFF10 Offset: 0x8BF310 VA: 0x1808BFF10
	private void OnTriggerExit(Collider other) { }

	// RVA: 0x8C0040 Offset: 0x8BF440 VA: 0x1808C0040
	public void .ctor() { }

}

public class ExplosionsFPS : MonoBehaviour // TypeDefIndex: 11491
{	// Fields
	private readonly GUIStyle guiStyleHeader; // 0x18
	private float timeleft; // 0x20
	private float fps; // 0x24
	private int frames; // 0x28

	// Methods

	// RVA: 0x8C1780 Offset: 0x8C0B80 VA: 0x1808C1780
	private void Awake() { }

	// RVA: 0x8C1810 Offset: 0x8C0C10 VA: 0x1808C1810
	private void OnGUI() { }

	// RVA: 0x8C18F0 Offset: 0x8C0CF0 VA: 0x1808C18F0
	private void Update() { }

	// RVA: 0x8C1950 Offset: 0x8C0D50 VA: 0x1808C1950
	public void .ctor() { }

}

public class ExplosionsBillboard : MonoBehaviour // TypeDefIndex: 11492
{	// Fields
	public Camera Camera; // 0x18
	public bool Active; // 0x20
	public bool AutoInitCamera; // 0x21
	private GameObject myContainer; // 0x28
	private Transform t; // 0x30
	private Transform camT; // 0x38
	private Transform contT; // 0x40

	// Methods

	// RVA: 0x8C1200 Offset: 0x8C0600 VA: 0x1808C1200
	private void Awake() { }

	// RVA: 0x8C1490 Offset: 0x8C0890 VA: 0x1808C1490
	private void Update() { }

	// RVA: 0x8C1690 Offset: 0x8C0A90 VA: 0x1808C1690
	public void .ctor() { }

}

public class ExplosionsDeactivateRendererByTime : MonoBehaviour // TypeDefIndex: 11493
{	// Fields
	public float TimeDelay; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8C16A0 Offset: 0x8C0AA0 VA: 0x1808C16A0
	private void Awake() { }

	// RVA: 0x8C16F0 Offset: 0x8C0AF0 VA: 0x1808C16F0
	private void DeactivateRenderer() { }

	// RVA: 0x8C1720 Offset: 0x8C0B20 VA: 0x1808C1720
	private void OnEnable() { }

	// RVA: 0x58B1C0 Offset: 0x58A5C0 VA: 0x18058B1C0
	public void .ctor() { }

}

public class ExplosionsLightCurves : MonoBehaviour // TypeDefIndex: 11494
{	// Fields
	public AnimationCurve LightCurve; // 0x18
	public float GraphTimeMultiplier; // 0x20
	public float GraphIntensityMultiplier; // 0x24
	private bool canUpdate; // 0x28
	private float startTime; // 0x2C
	private Light lightSource; // 0x30

	// Methods

	// RVA: 0x8C19C0 Offset: 0x8C0DC0 VA: 0x1808C19C0
	private void Awake() { }

	// RVA: 0x8C1A50 Offset: 0x8C0E50 VA: 0x1808C1A50
	private void OnEnable() { }

	// RVA: 0x8C1A70 Offset: 0x8C0E70 VA: 0x1808C1A70
	private void Update() { }

	// RVA: 0x8C1AE0 Offset: 0x8C0EE0 VA: 0x1808C1AE0
	public void .ctor() { }

}

public class ExplosionsParticleSystemScaler : MonoBehaviour // TypeDefIndex: 11495
{	// Fields
	public float particlesScale; // 0x18

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Start() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private void Update() { }

	// RVA: 0x58B1C0 Offset: 0x58A5C0 VA: 0x18058B1C0
	public void .ctor() { }

}

public class ExplosionsScaleCurves : MonoBehaviour // TypeDefIndex: 11496
{	// Fields
	public AnimationCurve ScaleCurveX; // 0x18
	public AnimationCurve ScaleCurveY; // 0x20
	public AnimationCurve ScaleCurveZ; // 0x28
	public Vector3 GraphTimeMultiplier; // 0x30
	public Vector3 GraphScaleMultiplier; // 0x3C
	private float startTime; // 0x48
	private Transform t; // 0x50
	private float evalX; // 0x58
	private float evalY; // 0x5C
	private float evalZ; // 0x60

	// Methods

	// RVA: 0x8C1B40 Offset: 0x8C0F40 VA: 0x1808C1B40
	private void Awake() { }

	// RVA: 0x8C1B70 Offset: 0x8C0F70 VA: 0x1808C1B70
	private void OnEnable() { }

	// RVA: 0x8C1BA0 Offset: 0x8C0FA0 VA: 0x1808C1BA0
	private void Update() { }

	// RVA: 0x8C1CD0 Offset: 0x8C10D0 VA: 0x1808C1CD0
	public void .ctor() { }

}

public class ExplosionsShaderColorGradient : MonoBehaviour // TypeDefIndex: 11497
{	// Fields
	public string ShaderProperty; // 0x18
	public int MaterialID; // 0x20
	public Gradient Color; // 0x28
	public float TimeMultiplier; // 0x30
	private bool canUpdate; // 0x34
	private Material matInstance; // 0x38
	private int propertyID; // 0x40
	private float startTime; // 0x44
	private Color oldColor; // 0x48

	// Methods

	// RVA: 0x8C1E10 Offset: 0x8C1210 VA: 0x1808C1E10
	private void Start() { }

	// RVA: 0x8C1DF0 Offset: 0x8C11F0 VA: 0x1808C1DF0
	private void OnEnable() { }

	// RVA: 0x8C1F80 Offset: 0x8C1380 VA: 0x1808C1F80
	private void Update() { }

	// RVA: 0x8C2050 Offset: 0x8C1450 VA: 0x1808C2050
	public void .ctor() { }

}

public class ExplosionsShaderFloatCurves : MonoBehaviour // TypeDefIndex: 11498
{	// Fields
	public string ShaderProperty; // 0x18
	public int MaterialID; // 0x20
	public AnimationCurve FloatPropertyCurve; // 0x28
	public float GraphTimeMultiplier; // 0x30
	public float GraphScaleMultiplier; // 0x34
	private bool canUpdate; // 0x38
	private Material matInstance; // 0x40
	private int propertyID; // 0x48
	private float startTime; // 0x4C

	// Methods

	// RVA: 0x8C20F0 Offset: 0x8C14F0 VA: 0x1808C20F0
	private void Start() { }

	// RVA: 0x8C20D0 Offset: 0x8C14D0 VA: 0x1808C20D0
	private void OnEnable() { }

	// RVA: 0x8C2230 Offset: 0x8C1630 VA: 0x1808C2230
	private void Update() { }

	// RVA: 0x8C22B0 Offset: 0x8C16B0 VA: 0x1808C22B0
	public void .ctor() { }

}

public class ExplosionsShaderQueue : MonoBehaviour // TypeDefIndex: 11499
{	// Fields
	public int AddQueue; // 0x18
	private Renderer rend; // 0x20

	// Methods

	// RVA: 0x8C2450 Offset: 0x8C1850 VA: 0x1808C2450
	private void Start() { }

	// RVA: 0x8C23D0 Offset: 0x8C17D0 VA: 0x1808C23D0
	private void SetProjectorQueue() { }

	// RVA: 0x8C2340 Offset: 0x8C1740 VA: 0x1808C2340
	private void OnDisable() { }

	// RVA: 0x8C2540 Offset: 0x8C1940 VA: 0x1808C2540
	public void .ctor() { }

}

internal class ExplosionsSpriteSheetAnimation : MonoBehaviour // TypeDefIndex: 11500
{	// Fields
	public int TilesX; // 0x18
	public int TilesY; // 0x1C
	public float AnimationFPS; // 0x20
	public bool IsInterpolateFrames; // 0x24
	public int StartFrameOffset; // 0x28
	public bool IsLoop; // 0x2C
	public float StartDelay; // 0x30
	public AnimationCurve FrameOverTime; // 0x38
	private bool isInizialised; // 0x40
	private int index; // 0x44
	private int count; // 0x48
	private int allCount; // 0x4C
	private float animationLifeTime; // 0x50
	private bool isVisible; // 0x54
	private bool isCorutineStarted; // 0x55
	private Renderer currentRenderer; // 0x58
	private Material instanceMaterial; // 0x60
	private float currentInterpolatedTime; // 0x68
	private float animationStartTime; // 0x6C
	private bool animationStoped; // 0x70

	// Methods

	// RVA: 0x8C29F0 Offset: 0x8C1DF0 VA: 0x1808C29F0
	private void Start() { }

	// RVA: 0x8C2550 Offset: 0x8C1950 VA: 0x1808C2550
	private void InitDefaultVariables() { }

	// RVA: 0x8C2970 Offset: 0x8C1D70 VA: 0x1808C2970
	private void Play() { }

	// RVA: 0x8C2900 Offset: 0x8C1D00 VA: 0x1808C2900
	private void PlayDelay() { }

	// RVA: 0x8C28D0 Offset: 0x8C1CD0 VA: 0x1808C28D0
	private void OnEnable() { }

	// RVA: 0x8C2880 Offset: 0x8C1C80 VA: 0x1808C2880
	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB7210 Offset: 0xB6610 VA: 0x1800B7210
	// RVA: 0x8C2A60 Offset: 0x8C1E60 VA: 0x1808C2A60
	private IEnumerator UpdateCorutine() { }

	// RVA: 0x8C2AD0 Offset: 0x8C1ED0 VA: 0x1808C2AD0
	private void UpdateFrame() { }

	// RVA: 0x8C2C00 Offset: 0x8C2000 VA: 0x1808C2C00
	private void Update() { }

	// RVA: 0x8C27D0 Offset: 0x8C1BD0 VA: 0x1808C27D0
	private void OnDestroy() { }

	// RVA: 0x8C2DD0 Offset: 0x8C21D0 VA: 0x1808C2DD0
	public void .ctor() { }

}

private sealed class ExplosionsSpriteSheetAnimation.<UpdateCorutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11501
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExplosionsSpriteSheetAnimation <>4__this; // 0x20

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8C9670 Offset: 0x8C8A70 VA: 0x1808C9670 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8C9920 Offset: 0x8C8D20 VA: 0x1808C9920 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

