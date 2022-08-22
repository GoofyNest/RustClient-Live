public enum AmbientMode // TypeDefIndex: 3814
{	public int value__; // 0x0
	public const AmbientMode Skybox = 0;
	public const AmbientMode Trilight = 1;
	public const AmbientMode Flat = 3;
	public const AmbientMode Custom = 4;

}

public class AmbienceDefinition : ScriptableObject // TypeDefIndex: 8969
{	[HeaderAttribute] // RVA: 0x8CB00 Offset: 0x8BF00 VA: 0x18008CB00
	public List<SoundDefinition> sounds; // 0x18
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public AmbienceDefinition.ValueRange stingFrequency; // 0x20
	[HeaderAttribute] // RVA: 0xC8ED0 Offset: 0xC82D0 VA: 0x1800C8ED0
	[InspectorFlagsAttribute] // RVA: 0xC8ED0 Offset: 0xC82D0 VA: 0x1800C8ED0
	public TerrainBiome.Enum biomes; // 0x28
	[InspectorFlagsAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TerrainTopology.Enum topologies; // 0x2C
	public EnvironmentType environmentType; // 0x30
	public bool useEnvironmentType; // 0x34
	public AnimationCurve time; // 0x38
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public AmbienceDefinition.ValueRange rain; // 0x40
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public AmbienceDefinition.ValueRange wind; // 0x48
	[HorizontalAttribute] // RVA: 0xC8DE0 Offset: 0xC81E0 VA: 0x1800C8DE0
	public AmbienceDefinition.ValueRange snow; // 0x50


	public void .ctor() { }

}

public class AmbienceDefinition.ValueRange // TypeDefIndex: 8970
{	public float min; // 0x10
	public float max; // 0x14


	public void .ctor(float min, float max) { }

}

public class AmbienceDefinitionList : ScriptableObject // TypeDefIndex: 8971
{	public List<AmbienceDefinition> defs; // 0x18


	public void .ctor() { }

}

public class AmbienceEmitter : MonoBehaviour, IClientComponent, IComparable<AmbienceEmitter> // TypeDefIndex: 8972
{	public AmbienceDefinitionList baseAmbience; // 0x18
	public AmbienceDefinitionList stings; // 0x20
	public bool isStatic; // 0x28
	public bool followCamera; // 0x29
	public bool isBaseEmitter; // 0x2A
	public bool active; // 0x2B
	public float cameraDistanceSq; // 0x2C
	public BoundingSphere boundingSphere; // 0x30
	public float crossfadeTime; // 0x40
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TerrainTopology.Enum <currentTopology>k__BackingField; // 0x44
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private TerrainBiome.Enum <currentBiome>k__BackingField; // 0x48
	public Dictionary<AmbienceDefinition, float> nextStingTime; // 0x50
	public float deactivateTime; // 0x58
	public bool playUnderwater; // 0x5C
	public bool playAbovewater; // 0x5D
	private Sound baseSound; // 0x60
	private SoundModulation.Modulator occlusionGain; // 0x68
	private SoundModulation.Modulator pitchModulator; // 0x70
	private float lastCrossfade; // 0x78
	private List<int> biomeReadings; // 0x80
	private List<int> topologyReadings; // 0x88
	private int readingsToKeep; // 0x90
	private Vector3 lastPosition; // 0x94
	private Dictionary<int, int> readingOccurences; // 0xA0

	public TerrainTopology.Enum currentTopology { get; set; }
	public TerrainBiome.Enum currentBiome { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TerrainTopology.Enum get_currentTopology() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentTopology(TerrainTopology.Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public TerrainBiome.Enum get_currentBiome() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentBiome(TerrainBiome.Enum value) { }

	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void OnDestroy() { }

	public void FadeOut(float fadeTimeOverride = -1) { }

	public bool IsFadingOut() { }

	public void Reset() { }

	public void SetBaseAmbience(AmbienceDefinitionList ambienceList) { }

	public void DoUpdate() { }

	public void Tick() { }

	public void UpdateCameraDistance() { }

	public void StartImmediately() { }

	private void ReadAndUpdateEnvironment() { }

	private void ReadEnvironment() { }

	private void UpdateCurrentEnvironment() { }

	private int GetMostCommonReading(List<int> readings) { }

	private float GetScore(AmbienceDefinition definition, float rain, float snow, float wind, bool underground) { }

	private void UpdateBaseSound(float crossFadeTimeOverride = -1) { }

	public SoundModulation.Modulator GetPitchModulator() { }

	private void StartSound(SoundDefinition def, float fadeTime) { }

	private void CrossfadeTo(SoundDefinition def, float fadeTime) { }

	public SoundDefinition GetBaseSound() { }

	private SoundDefinition GetBaseSound(AmbienceDefinitionList ambienceDefinitionList) { }

	public void PlayStings() { }

	private void PlayStings(AmbienceDefinitionList ambienceDefinitionList) { }

	private void ResetStingTimes(AmbienceDefinitionList ambienceDefinitionList) { }

	public float GetNextStingTime(AmbienceDefinition sting) { }

	public int CompareTo(AmbienceEmitter other) { }

	public void .ctor() { }

}

public class AmbienceLocalStings : MonoBehaviour // TypeDefIndex: 8973
{	public float maxDistance; // 0x18
	public float stingRadius; // 0x1C
	public float stingFrequency; // 0x20
	public float stingFrequencyVariance; // 0x24
	public SoundDefinition[] stingSounds; // 0x28
	private SynchronizedClock stingClock; // 0x30


	private void PlaySting(uint seed) { }

	private void Start() { }

	private void Update() { }

	public void .ctor() { }

}

public class AmbienceManager : SingletonComponent<AmbienceManager>, IClientComponent // TypeDefIndex: 8974
{	public List<AmbienceManager.EmitterTypeLimit> localEmitterLimits; // 0x18
	public AmbienceManager.EmitterTypeLimit catchallEmitterLimit; // 0x20
	public int maxActiveLocalEmitters; // 0x28
	public int activeLocalEmitters; // 0x2C
	public List<AmbienceEmitter> cameraEmitters; // 0x30
	public List<AmbienceEmitter> emittersInRange; // 0x38
	public List<AmbienceEmitter> activeEmitters; // 0x40
	public float localEmitterRange; // 0x48
	public List<AmbienceZone> currentAmbienceZones; // 0x50
	public bool isUnderwater; // 0x58
	private Dictionary<AmbienceDefinitionList, AmbienceManager.EmitterTypeLimit> emitterLimitByAmbience; // 0x60
	private float tickInterval; // 0x68
	private float lastTick; // 0x6C
	private List<AmbienceManager.AmbienceGroup> ambienceGroups; // 0x70
	private Dictionary<AmbienceDefinitionList, AmbienceManager.AmbienceGroup> ambienceGroupsByDef; // 0x78


	private void Start() { }

	private void OnApplicationQuit() { }

	private void OnDisable() { }

	private void Update() { }

	private void Tick() { }

	private void TickLocalEmitters() { }

	public void DeactivateEmitter(AmbienceEmitter emitter) { }

	public void ActivateEmitter(AmbienceEmitter emitter) { }

	private void TickCameraEmitters() { }

	private void SortLocalEmitters() { }

	private AmbienceManager.EmitterTypeLimit EmitterLimit(AmbienceEmitter emitter) { }

	public void OnCullingGroupChange(CullingGroupEvent evt, AmbienceManager.AmbienceGroup group) { }

	public void EmitterLeaveRange(AmbienceEmitter emitter) { }

	public void AddEmitter(AmbienceEmitter emitter) { }

	public void RemoveEmitter(AmbienceEmitter emitter) { }

	public void AddCameraEmitter(AmbienceEmitter emitter) { }

	public void RemoveCameraEmitter(AmbienceEmitter emitter) { }

	private void UpdateCullingGroups() { }

	private AmbienceManager.AmbienceGroup AmbienceGroupForEmitter(AmbienceEmitter emitter) { }

	public void EnableAdvancedAmbience() { }

	public void DisableAdvancedAmbience() { }

	private void SortEmitters(List<AmbienceEmitter> emitterList) { }

	private void SortEmitters(List<AmbienceEmitter> emitterList, int left, int right) { }

	public void AmbienceZoneEntered(AmbienceZone zone) { }

	public void AmbienceZoneExited(AmbienceZone zone) { }

	public AmbienceZone CurrentAmbienceZone() { }

	public void .ctor() { }

}

public class AmbienceManager.EmitterTypeLimit // TypeDefIndex: 8975
{	public List<AmbienceDefinitionList> ambience; // 0x10
	public int limit; // 0x18
	public int active; // 0x1C


	public void .ctor() { }

}

public class AmbienceManager.AmbienceGroup // TypeDefIndex: 8976
{	public AmbienceDefinitionList ambienceDefinition; // 0x10
	public HashSet<AmbienceEmitter> emitters; // 0x18
	public CullingGroup cullingGroup; // 0x20
	public BoundingSphere[] cullGroupSpheres; // 0x28
	public List<AmbienceEmitter> emittersBySphereIdx; // 0x30
	public bool cullingGroupDirty; // 0x38


	public void OnCullingGroupChange(CullingGroupEvent evt) { }

	public void .ctor() { }

}

public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent // TypeDefIndex: 8977
{	public int baseEmitterCount; // 0x18
	public int baseEmitterDistance; // 0x1C
	public GameObjectRef emitterPrefab; // 0x20


	private void Start() { }

	private void CreateBaseEmitters() { }

	public void .ctor() { }

}

public class AmbienceZone : TriggerBase, IClientComponentEx // TypeDefIndex: 8978
{	public AmbienceDefinitionList baseAmbience; // 0x30
	public AmbienceDefinitionList stings; // 0x38
	public float priority; // 0x40
	public bool overrideCrossfadeTime; // 0x44
	public float crossfadeTime; // 0x48


	private void Awake() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	internal override void OnEntityLeave(BaseEntity ent) { }

	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	public void .ctor() { }

}

public class AmbientLightLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 11293
{	public bool isDynamic; // 0x18
	public float enabledRadius; // 0x1C
	public bool toggleFade; // 0x20
	public float toggleFadeDuration; // 0x24
	private Light lightComponent; // 0x28
	private LightOccludee lightOccludee; // 0x30
	private LightEx lightEx; // 0x38
	private VolumetricLightBeam volumetricBeam; // 0x40
	private LODCell cell; // 0x48
	private float targetIntensity; // 0x50
	private float targetFadeDuration; // 0x54
	private LODEnvironmentMode EnvironmentMode; // 0x58
	private float fadeStartTime; // 0x5C
	private float fadeEndTime; // 0x60
	private bool fadeToState; // 0x64
	private bool queuedState; // 0x65


	private float GetDistance() { }

	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	private void ToggleLight(bool state) { }

	private void FadingToggle() { }

	public void SetLightActive(bool lightOn) { }

	public void SetTargetIntensity(float intensity, float fadeDuration = -1) { }

	public void RefreshLOD() { }

	public void ChangeLOD() { }

	protected void OnValidate() { }

	public void .ctor() { }

}

public enum AmbientOcclusionMode // TypeDefIndex: 11752
{	public int value__; // 0x0
	public const AmbientOcclusionMode ScalableAmbientObscurance = 0;
	public const AmbientOcclusionMode MultiScaleVolumetricObscurance = 1;

}

public enum AmbientOcclusionQuality // TypeDefIndex: 11753
{	public int value__; // 0x0
	public const AmbientOcclusionQuality Lowest = 0;
	public const AmbientOcclusionQuality Low = 1;
	public const AmbientOcclusionQuality Medium = 2;
	public const AmbientOcclusionQuality High = 3;
	public const AmbientOcclusionQuality Ultra = 4;

}

public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode> // TypeDefIndex: 11754
{
	public void .ctor() { }

}

public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 11755
{
	public void .ctor() { }

}

public sealed class AmbientOcclusion : PostProcessEffectSettings // TypeDefIndex: 11756
{	[TooltipAttribute] // RVA: 0xE7CB0 Offset: 0xE70B0 VA: 0x1800E7CB0
	public AmbientOcclusionModeParameter mode; // 0x30
	[RangeAttribute] // RVA: 0xE7D80 Offset: 0xE7180 VA: 0x1800E7D80
	[TooltipAttribute] // RVA: 0xE7D80 Offset: 0xE7180 VA: 0x1800E7D80
	public FloatParameter intensity; // 0x38
	[ColorUsageAttribute] // RVA: 0xE9120 Offset: 0xE8520 VA: 0x1800E9120
	[TooltipAttribute] // RVA: 0xE9120 Offset: 0xE8520 VA: 0x1800E9120
	public ColorParameter color; // 0x40
	[TooltipAttribute] // RVA: 0xE9350 Offset: 0xE8750 VA: 0x1800E9350
	public BoolParameter ambientOnly; // 0x48
	[RangeAttribute] // RVA: 0xE93C0 Offset: 0xE87C0 VA: 0x1800E93C0
	public FloatParameter noiseFilterTolerance; // 0x50
	[RangeAttribute] // RVA: 0xE9480 Offset: 0xE8880 VA: 0x1800E9480
	public FloatParameter blurTolerance; // 0x58
	[RangeAttribute] // RVA: 0xE9510 Offset: 0xE8910 VA: 0x1800E9510
	public FloatParameter upsampleTolerance; // 0x60
	[RangeAttribute] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	[TooltipAttribute] // RVA: 0xE96F0 Offset: 0xE8AF0 VA: 0x1800E96F0
	public FloatParameter thicknessModifier; // 0x68
	[RangeAttribute] // RVA: 0xE9880 Offset: 0xE8C80 VA: 0x1800E9880
	[TooltipAttribute] // RVA: 0xE9880 Offset: 0xE8C80 VA: 0x1800E9880
	public FloatParameter directLightingStrength; // 0x70
	[TooltipAttribute] // RVA: 0xE9A70 Offset: 0xE8E70 VA: 0x1800E9A70
	public FloatParameter radius; // 0x78
	[TooltipAttribute] // RVA: 0xE9B30 Offset: 0xE8F30 VA: 0x1800E9B30
	public AmbientOcclusionQualityParameter quality; // 0x80


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 11758
{	private IAmbientOcclusionMethod[] m_Methods; // 0x20


	public override void Init() { }

	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	public IAmbientOcclusionMethod Get() { }

	public override DepthTextureMode GetCameraFlags() { }

	public override void Release() { }

	public ScalableAO GetScalableAO() { }

	public MultiScaleVO GetMultiScaleVO() { }

	public override void Render(PostProcessRenderContext context) { }

	public void .ctor() { }

}

