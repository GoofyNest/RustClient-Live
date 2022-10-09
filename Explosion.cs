public class Explosion_Bloom : MonoBehaviour // TypeDefIndex: 13227
{
	[SerializeField] 
	public Explosion_Bloom.Settings settings; 
	[SerializeField] 
	[HideInInspector] 
	private Shader m_Shader; 
	private Material m_Material; 
	private const int kMaxIterations = 16;
	private RenderTexture[] m_blurBuffer1; 
	private RenderTexture[] m_blurBuffer2; 
	private int m_Threshold; 
	private int m_Curve; 
	private int m_PrefilterOffs; 
	private int m_SampleScale; 
	private int m_Intensity; 
	private int m_BaseTex; 

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

public struct Explosion_Bloom.Settings // TypeDefIndex: 13228
{
	[SerializeField] 
	[TooltipAttribute] 
	public float threshold; 
	[SerializeField] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float softKnee; 
	[SerializeField] 
	[RangeAttribute] 
	[TooltipAttribute] 
	public float radius; 
	[SerializeField] 
	[TooltipAttribute] 
	public float intensity; 
	[SerializeField] 
	[TooltipAttribute] 
	public bool highQuality; 
	[SerializeField] 
	[TooltipAttribute] 
	public bool antiFlicker; 

	public float thresholdGamma { get; set; }
	public float thresholdLinear { get; set; }
	public static Explosion_Bloom.Settings defaultSettings { get; }


	public void set_thresholdGamma(float value) { }

	public float get_thresholdGamma() { }

	public void set_thresholdLinear(float value) { }

	public float get_thresholdLinear() { }

	public static Explosion_Bloom.Settings get_defaultSettings() { }

}

public class ExplosionDemoGUI : MonoBehaviour // TypeDefIndex: 13229
{
	public GameObject[] Prefabs; 
	public float reactivateTime; 
	public Light Sun; 
	private int currentNomber; 
	private GameObject currentInstance; 
	private GUIStyle guiStyleHeader; 
	private float sunIntensity; 
	private float dpiScale; 


	private void Start() { }

	private void OnGUI() { }

	private void ChangeCurrent(int delta) { }

	public void .ctor() { }

}

public class ExplosionDemoReactivator : MonoBehaviour // TypeDefIndex: 13230
{
	public float TimeDelayToReactivate; 


	private void Start() { }

	private void Reactivate() { }

	public void .ctor() { }

}

public class ExplosionPlatformActivator : MonoBehaviour // TypeDefIndex: 13231
{
	public GameObject Effect; 
	public float TimeDelay; 
	public float DefaultRepeatTime; 
	public float NearRepeatTime; 
	private float currentTime; 
	private float currentRepeatTime; 
	private bool canUpdate; 


	private void Start() { }

	private void Init() { }

	private void Update() { }

	private void OnTriggerEnter(Collider coll) { }

	private void OnTriggerExit(Collider other) { }

	public void .ctor() { }

}

public class ExplosionsFPS : MonoBehaviour // TypeDefIndex: 13232
{
	private readonly GUIStyle guiStyleHeader; 
	private float timeleft; 
	private float fps; 
	private int frames; 


	private void Awake() { }

	private void OnGUI() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsBillboard : MonoBehaviour // TypeDefIndex: 13233
{
	public Camera Camera; 
	public bool Active; 
	public bool AutoInitCamera; 
	private GameObject myContainer; 
	private Transform t; 
	private Transform camT; 
	private Transform contT; 


	private void Awake() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsDeactivateRendererByTime : MonoBehaviour // TypeDefIndex: 13234
{
	public float TimeDelay; 
	private Renderer rend; 


	private void Awake() { }

	private void DeactivateRenderer() { }

	private void OnEnable() { }

	public void .ctor() { }

}

public class ExplosionsLightCurves : MonoBehaviour // TypeDefIndex: 13235
{
	public AnimationCurve LightCurve; 
	public float GraphTimeMultiplier; 
	public float GraphIntensityMultiplier; 
	private bool canUpdate; 
	private float startTime; 
	private Light lightSource; 


	private void Awake() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsParticleSystemScaler : MonoBehaviour // TypeDefIndex: 13236
{
	public float particlesScale; 


	private void Start() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsScaleCurves : MonoBehaviour // TypeDefIndex: 13237
{
	public AnimationCurve ScaleCurveX; 
	public AnimationCurve ScaleCurveY; 
	public AnimationCurve ScaleCurveZ; 
	public Vector3 GraphTimeMultiplier; 
	public Vector3 GraphScaleMultiplier; 
	private float startTime; 
	private Transform t; 
	private float evalX; 
	private float evalY; 
	private float evalZ; 


	private void Awake() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsShaderColorGradient : MonoBehaviour // TypeDefIndex: 13238
{
	public string ShaderProperty; 
	public int MaterialID; 
	public Gradient Color; 
	public float TimeMultiplier; 
	private bool canUpdate; 
	private Material matInstance; 
	private int propertyID; 
	private float startTime; 
	private Color oldColor; 


	private void Start() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsShaderFloatCurves : MonoBehaviour // TypeDefIndex: 13239
{
	public string ShaderProperty; 
	public int MaterialID; 
	public AnimationCurve FloatPropertyCurve; 
	public float GraphTimeMultiplier; 
	public float GraphScaleMultiplier; 
	private bool canUpdate; 
	private Material matInstance; 
	private int propertyID; 
	private float startTime; 


	private void Start() { }

	private void OnEnable() { }

	private void Update() { }

	public void .ctor() { }

}

public class ExplosionsShaderQueue : MonoBehaviour // TypeDefIndex: 13240
{
	public int AddQueue; 
	private Renderer rend; 


	private void Start() { }

	private void SetProjectorQueue() { }

	private void OnDisable() { }

	public void .ctor() { }

}

internal class ExplosionsSpriteSheetAnimation : MonoBehaviour // TypeDefIndex: 13241
{
	public int TilesX; 
	public int TilesY; 
	public float AnimationFPS; 
	public bool IsInterpolateFrames; 
	public int StartFrameOffset; 
	public bool IsLoop; 
	public float StartDelay; 
	public AnimationCurve FrameOverTime; 
	private bool isInizialised; 
	private int index; 
	private int count; 
	private int allCount; 
	private float animationLifeTime; 
	private bool isVisible; 
	private bool isCorutineStarted; 
	private Renderer currentRenderer; 
	private Material instanceMaterial; 
	private float currentInterpolatedTime; 
	private float animationStartTime; 
	private bool animationStoped; 


	private void Start() { }

	private void InitDefaultVariables() { }

	private void Play() { }

	private void PlayDelay() { }

	private void OnEnable() { }

	private void OnDisable() { }

	[IteratorStateMachineAttribute] 
	private IEnumerator UpdateCorutine() { }

	private void UpdateFrame() { }

	private void Update() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

private sealed class ExplosionsSpriteSheetAnimation.<UpdateCorutine>d__26 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 13242
{
	private int <>1__state; 
	private object <>2__current; 
	public ExplosionsSpriteSheetAnimation <>4__this; 

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
	private object System.Collections.IEnumerator.get_Current() { }

}

