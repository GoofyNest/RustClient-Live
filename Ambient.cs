public enum AmbientMode // TypeDefIndex: 3816
{
	public int value__; 
	public const AmbientMode Skybox = 0;
	public const AmbientMode Trilight = 1;
	public const AmbientMode Flat = 3;
	public const AmbientMode Custom = 4;

}

public class AmbienceDefinition : ScriptableObject // TypeDefIndex: 10684
{
	[HeaderAttribute] 
	public List<SoundDefinition> sounds; 
	[HorizontalAttribute] 
	public AmbienceDefinition.ValueRange stingFrequency; 
	[HeaderAttribute] 
	[InspectorFlagsAttribute] 
	public TerrainBiome.Enum biomes; 
	[InspectorFlagsAttribute] 
	public TerrainTopology.Enum topologies; 
	public EnvironmentType environmentType; 
	public bool useEnvironmentType; 
	public AnimationCurve time; 
	[HorizontalAttribute] 
	public AmbienceDefinition.ValueRange rain; 
	[HorizontalAttribute] 
	public AmbienceDefinition.ValueRange wind; 
	[HorizontalAttribute] 
	public AmbienceDefinition.ValueRange snow; 


	public void .ctor() { }

}

public class AmbienceDefinition.ValueRange // TypeDefIndex: 10685
{
	public float min; 
	public float max; 


	public void .ctor(float min, float max) { }

}

public class AmbienceDefinitionList : ScriptableObject // TypeDefIndex: 10686
{
	public List<AmbienceDefinition> defs; 


	public void .ctor() { }

}

public class AmbienceEmitter : MonoBehaviour, IClientComponent, IComparable<AmbienceEmitter> // TypeDefIndex: 10687
{
	public AmbienceDefinitionList baseAmbience; 
	public AmbienceDefinitionList stings; 
	public bool isStatic; 
	public bool followCamera; 
	public bool isBaseEmitter; 
	public bool active; 
	public float cameraDistanceSq; 
	public BoundingSphere boundingSphere; 
	public float crossfadeTime; 
	[CompilerGeneratedAttribute] 
	private TerrainTopology.Enum <currentTopology>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private TerrainBiome.Enum <currentBiome>k__BackingField; 
	public Dictionary<AmbienceDefinition, float> nextStingTime; 
	public float deactivateTime; 
	public bool playUnderwater; 
	public bool playAbovewater; 
	private Sound baseSound; 
	private SoundModulation.Modulator occlusionGain; 
	private SoundModulation.Modulator pitchModulator; 
	private float lastCrossfade; 
	private List<int> biomeReadings; 
	private List<int> topologyReadings; 
	private int readingsToKeep; 
	private Vector3 lastPosition; 
	private Dictionary<int, int> readingOccurences; 

	public TerrainTopology.Enum currentTopology { get; set; }
	public TerrainBiome.Enum currentBiome { get; set; }


	[CompilerGeneratedAttribute] 
	public TerrainTopology.Enum get_currentTopology() { }

	[CompilerGeneratedAttribute] 
	private void set_currentTopology(TerrainTopology.Enum value) { }

	[CompilerGeneratedAttribute] 
	public TerrainBiome.Enum get_currentBiome() { }

	[CompilerGeneratedAttribute] 
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

public class AmbienceLocalStings : MonoBehaviour // TypeDefIndex: 10688
{
	public float maxDistance; 
	public float stingRadius; 
	public float stingFrequency; 
	public float stingFrequencyVariance; 
	public SoundDefinition[] stingSounds; 
	private SynchronizedClock stingClock; 


	private void PlaySting(uint seed) { }

	private void Start() { }

	private void Update() { }

	public void .ctor() { }

}

public class AmbienceManager : SingletonComponent<AmbienceManager>, IClientComponent // TypeDefIndex: 10689
{
	public List<AmbienceManager.EmitterTypeLimit> localEmitterLimits; 
	public AmbienceManager.EmitterTypeLimit catchallEmitterLimit; 
	public int maxActiveLocalEmitters; 
	public int activeLocalEmitters; 
	public List<AmbienceEmitter> cameraEmitters; 
	public List<AmbienceEmitter> emittersInRange; 
	public List<AmbienceEmitter> activeEmitters; 
	public float localEmitterRange; 
	public List<AmbienceZone> currentAmbienceZones; 
	public bool isUnderwater; 
	private Dictionary<AmbienceDefinitionList, AmbienceManager.EmitterTypeLimit> emitterLimitByAmbience; 
	private float tickInterval; 
	private float lastTick; 
	private List<AmbienceManager.AmbienceGroup> ambienceGroups; 
	private Dictionary<AmbienceDefinitionList, AmbienceManager.AmbienceGroup> ambienceGroupsByDef; 


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

public class AmbienceManager.EmitterTypeLimit // TypeDefIndex: 10690
{
	public List<AmbienceDefinitionList> ambience; 
	public int limit; 
	public int active; 


	public void .ctor() { }

}

public class AmbienceManager.AmbienceGroup // TypeDefIndex: 10691
{
	public AmbienceDefinitionList ambienceDefinition; 
	public HashSet<AmbienceEmitter> emitters; 
	public CullingGroup cullingGroup; 
	public BoundingSphere[] cullGroupSpheres; 
	public List<AmbienceEmitter> emittersBySphereIdx; 
	public bool cullingGroupDirty; 


	public void OnCullingGroupChange(CullingGroupEvent evt) { }

	public void .ctor() { }

}

public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent // TypeDefIndex: 10692
{
	public int baseEmitterCount; 
	public int baseEmitterDistance; 
	public GameObjectRef emitterPrefab; 


	private void Start() { }

	private void CreateBaseEmitters() { }

	public void .ctor() { }

}

public class AmbienceZone : TriggerBase, IClientComponentEx // TypeDefIndex: 10693
{
	public AmbienceDefinitionList baseAmbience; 
	public AmbienceDefinitionList stings; 
	public float priority; 
	public bool overrideCrossfadeTime; 
	public float crossfadeTime; 


	private void Awake() { }

	internal override GameObject InterestedInObject(GameObject obj) { }

	internal override void OnEntityEnter(BaseEntity ent) { }

	internal override void OnEntityLeave(BaseEntity ent) { }

	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	public void .ctor() { }

}

public class AmbientLightLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 13045
{
	public bool isDynamic; 
	public float enabledRadius; 
	public bool toggleFade; 
	public float toggleFadeDuration; 
	private Light lightComponent; 
	private LightOccludee lightOccludee; 
	private LightEx lightEx; 
	private VolumetricLightBeam volumetricBeam; 
	private LODCell cell; 
	private float targetIntensity; 
	private float targetFadeDuration; 
	private LODEnvironmentMode EnvironmentMode; 
	private float fadeStartTime; 
	private float fadeEndTime; 
	private bool fadeToState; 
	private bool queuedState; 


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

public enum AmbientOcclusionMode // TypeDefIndex: 13504
{
	public int value__; 
	public const AmbientOcclusionMode ScalableAmbientObscurance = 0;
	public const AmbientOcclusionMode MultiScaleVolumetricObscurance = 1;

}

public enum AmbientOcclusionQuality // TypeDefIndex: 13505
{
	public int value__; 
	public const AmbientOcclusionQuality Lowest = 0;
	public const AmbientOcclusionQuality Low = 1;
	public const AmbientOcclusionQuality Medium = 2;
	public const AmbientOcclusionQuality High = 3;
	public const AmbientOcclusionQuality Ultra = 4;

}

public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode> // TypeDefIndex: 13506
{

	public void .ctor() { }

}

public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 13507
{

	public void .ctor() { }

}

public sealed class AmbientOcclusion : PostProcessEffectSettings // TypeDefIndex: 13508
{
	[TooltipAttribute] 
	public AmbientOcclusionModeParameter mode; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter intensity; 
	[ColorUsageAttribute] 
	[TooltipAttribute] 
	public ColorParameter color; 
	[TooltipAttribute] 
	public BoolParameter ambientOnly; 
	[RangeAttribute] 
	public FloatParameter noiseFilterTolerance; 
	[RangeAttribute] 
	public FloatParameter blurTolerance; 
	[RangeAttribute] 
	public FloatParameter upsampleTolerance; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter thicknessModifier; 
	[RangeAttribute] 
	[TooltipAttribute] 
	public FloatParameter directLightingStrength; 
	[TooltipAttribute] 
	public FloatParameter radius; 
	[TooltipAttribute] 
	public AmbientOcclusionQualityParameter quality; 


	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	public void .ctor() { }

}

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 13510
{
	private IAmbientOcclusionMethod[] m_Methods; 


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

