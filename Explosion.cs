public class Explosion_Bloom : MonoBehaviour // TypeDefIndex: 11486
{	[SerializeField] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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

	public Shader shader { get; }
	public Material material { get; }
	public static bool supportsDX11 { get; }


	public Shader get_shader() { }

	public Material get_material() { }

	public static bool IsSupported(Shader s, bool needDepth, bool needHdr, MonoBehaviour effect) { }

	public static Material CheckShaderAndCreateMaterial(Shader s) { }

	public static bool get_supportsDX11() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	private void OnRenderImage(RenderTexture source, RenderTexture destination) { }

	public void .ctor() { }

}

public struct Explosion_Bloom.Settings // TypeDefIndex: 11487
{	[SerializeField] // RVA: 0xB68B0 Offset: 0xB5CB0 VA: 0x1800B68B0
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

	public float thresholdGamma { get; set; }
	public float thresholdLinear { get; set; }
	public static Explosion_Bloom.Settings defaultSettings { get; }


	public void set_thresholdGamma(float value) { }

	public float get_thresholdGamma() { }

	public void set_thresholdLinear(float value) { }

	public float get_thresholdLinear() { }

	public static Explosion_Bloom.Settings get_defaultSettings() { }

}

public class ExplosionDemoGUI : MonoBehaviour // TypeDefIndex: 11488
{	public GameObject[] Prefabs; // 0x18
	public float reactivateTime; // 0x20
	public Light Sun; // 0x28
	private int currentNomber; // 0x30
	private GameObject currentInstance; // 0x38
	private GUIStyle guiStyleHeader; // 0x40
	private float sunIntensity; // 0x48
	private float dpiScale; // 0x4C


	private void Start() { }

	private void OnGUI() { }

	private void ChangeCurrent(int delta) { }

	public void .ctor() { }

}

public class ExplosionDemoReactivator : MonoBehaviour // TypeDefIndex: 11489
{	public float TimeDelayToReactivate; // 0x18


	private void Start() { }

	private void Reactivate() { }

	public void .ctor() { }

}

public class ExplosionPlatformActivator : MonoBehaviour // TypeDefIndex: 11490
{	public GameObject Effect; // 0x18
	public float TimeDelay; // 0x20
	public float DefaultRepeatTime; // 0x24
	public float NearRepeatTime; // 0x28
	private float currentTime; // 0x2C
	private float currentRepeatTime; // 0x30
	private bool canUpdate; // 0x34


	private void Start() { }

	private void Init() { }

	private void Update() { }

	private void OnTriggerEnter(Collider coll) { }

	private void OnTriggerExit(Collider other) { }

	public void .ctor() { }

}

public class ExplosionsFPS : MonoBehaviour // TypeDefIndex: 11491
{	private readonly GUIStyle guiStyleHeader; // 0x18
	private float timeleft; // 0x20
	private float fps; // 0x24
	private int frames; // 0x28


	private void Awake() { }

	private void OnGUI() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsBillboard : MonoBehaviour // TypeDefIndex: 11492
{	public Camera Camera; // 0x18
	public bool Active; // 0x20
	public bool AutoInitCamera; // 0x21
	private GameObject myContainer; // 0x28
	private Transform t; // 0x30
	private Transform camT; // 0x38
	private Transform contT; // 0x40


	private void Awake() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsDeactivateRendererByTime : MonoBehaviour // TypeDefIndex: 11493
{	public float TimeDelay; // 0x18
	private Renderer rend; // 0x20


	private void Awake() { }

	private void DeactivateRenderer() { }

	private void OnEnable() { }

	public void .ctor() { }

}

public class ExplosionsLightCurves : MonoBehaviour // TypeDefIndex: 11494
{	public AnimationCurve LightCurve; // 0x18
	public float GraphTimeMultiplier; // 0x20
	public float GraphIntensityMultiplier; // 0x24
	private bool canUpdate; // 0x28
	private float startTime; // 0x2C
	private Light lightSource; // 0x30


	private void Awake() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsParticleSystemScaler : MonoBehaviour // TypeDefIndex: 11495
{	public float particlesScale; // 0x18


	private void Start() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsScaleCurves : MonoBehaviour // TypeDefIndex: 11496
{	public AnimationCurve ScaleCurveX; // 0x18
	public AnimationCurve ScaleCurveY; // 0x20
	public AnimationCurve ScaleCurveZ; // 0x28
	public Vector3 GraphTimeMultiplier; // 0x30
	public Vector3 GraphScaleMultiplier; // 0x3C
	private float startTime; // 0x48
	private Transform t; // 0x50
	private float evalX; // 0x58
	private float evalY; // 0x5C
	private float evalZ; // 0x60


	private void Awake() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsShaderColorGradient : MonoBehaviour // TypeDefIndex: 11497
{	public string ShaderProperty; // 0x18
	public int MaterialID; // 0x20
	public Gradient Color; // 0x28
	public float TimeMultiplier; // 0x30
	private bool canUpdate; // 0x34
	private Material matInstance; // 0x38
	private int propertyID; // 0x40
	private float startTime; // 0x44
	private Color oldColor; // 0x48


	private void Start() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsShaderFloatCurves : MonoBehaviour // TypeDefIndex: 11498
{	public string ShaderProperty; // 0x18
	public int MaterialID; // 0x20
	public AnimationCurve FloatPropertyCurve; // 0x28
	public float GraphTimeMultiplier; // 0x30
	public float GraphScaleMultiplier; // 0x34
	private bool canUpdate; // 0x38
	private Material matInstance; // 0x40
	private int propertyID; // 0x48
	private float startTime; // 0x4C


	private void Start() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsShaderQueue : MonoBehaviour // TypeDefIndex: 11499
{	public int AddQueue; // 0x18
	private Renderer rend; // 0x20


	private void Start() { }

	private void SetProjectorQueue() { }

	private void OnDisable() { }

	public void .ctor() { }

}

internal class ExplosionsSpriteSheetAnimation : MonoBehaviour // TypeDefIndex: 11500
{	public int TilesX; // 0x18
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


	private void Start() { }

	private void InitDefaultVariables() { }

	private void Play() { }

	private void PlayDelay() { }

	private void OnEnable() { }

	private void OnDisable() { }

	[IteratorStateMachineAttribute] // RVA: 0xB7210 Offset: 0xB6610 VA: 0x1800B7210
	private IEnumerator UpdateCorutine() { }

	private void UpdateFrame() { }

	private void Update() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

private sealed class ExplosionsSpriteSheetAnimation.<UpdateCorutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 11501
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public ExplosionsSpriteSheetAnimation <>4__this; // 0x20

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

