public enum AmbientMode // TypeDefIndex: 3814
{	// Fields
	public int value__; // 0x0
	public const AmbientMode Skybox = 0;
	public const AmbientMode Trilight = 1;
	public const AmbientMode Flat = 3;
	public const AmbientMode Custom = 4;

}

public class AmbienceDefinition : ScriptableObject // TypeDefIndex: 8969
{	// Fields
	[HeaderAttribute] // RVA: 0x8CB00 Offset: 0x8BF00 VA: 0x18008CB00
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

	// Methods

	// RVA: 0xAA12D0 Offset: 0xAA06D0 VA: 0x180AA12D0
	public void .ctor() { }

}

public class AmbienceDefinition.ValueRange // TypeDefIndex: 8970
{	// Fields
	public float min; // 0x10
	public float max; // 0x14

	// Methods

	// RVA: 0x7CDEB0 Offset: 0x7CD2B0 VA: 0x1807CDEB0
	public void .ctor(float min, float max) { }

}

public class AmbienceDefinitionList : ScriptableObject // TypeDefIndex: 8971
{	// Fields
	public List<AmbienceDefinition> defs; // 0x18

	// Methods

	// RVA: 0x4C0870 Offset: 0x4BFC70 VA: 0x1804C0870
	public void .ctor() { }

}

public class AmbienceEmitter : MonoBehaviour, IClientComponent, IComparable<AmbienceEmitter> // TypeDefIndex: 8972
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x18
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

	// Properties
	public TerrainTopology.Enum currentTopology { get; set; }
	public TerrainBiome.Enum currentBiome { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5F7C90 Offset: 0x5F7090 VA: 0x1805F7C90
	public TerrainTopology.Enum get_currentTopology() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8B0DE0 Offset: 0x8B01E0 VA: 0x1808B0DE0
	private void set_currentTopology(TerrainTopology.Enum value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C80 Offset: 0x5B1080 VA: 0x1805B1C80
	public TerrainBiome.Enum get_currentBiome() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B1C90 Offset: 0x5B1090 VA: 0x1805B1C90
	private void set_currentBiome(TerrainBiome.Enum value) { }

	// RVA: 0xAA1420 Offset: 0xAA0820 VA: 0x180AA1420
	protected void Awake() { }

	// RVA: 0xAA24E0 Offset: 0xAA18E0 VA: 0x180AA24E0
	protected void OnEnable() { }

	// RVA: 0xAA2350 Offset: 0xAA1750 VA: 0x180AA2350
	protected void OnDisable() { }

	// RVA: 0xAA2200 Offset: 0xAA1600 VA: 0x180AA2200
	protected void OnDestroy() { }

	// RVA: 0xAA1830 Offset: 0xAA0C30 VA: 0x180AA1830
	public void FadeOut(float fadeTimeOverride = -1) { }

	// RVA: 0xAA21E0 Offset: 0xAA15E0 VA: 0x180AA21E0
	public bool IsFadingOut() { }

	// RVA: 0xAA33D0 Offset: 0xAA27D0 VA: 0x180AA33D0
	public void Reset() { }

	// RVA: 0xAA3430 Offset: 0xAA2830 VA: 0x180AA3430
	public void SetBaseAmbience(AmbienceDefinitionList ambienceList) { }

	// RVA: 0xAA16C0 Offset: 0xAA0AC0 VA: 0x180AA16C0
	public void DoUpdate() { }

	// RVA: 0xAA3920 Offset: 0xAA2D20 VA: 0x180AA3920
	public void Tick() { }

	// RVA: 0xAA3A70 Offset: 0xAA2E70 VA: 0x180AA3A70
	public void UpdateCameraDistance() { }

	// RVA: 0xAA36D0 Offset: 0xAA2AD0 VA: 0x180AA36D0
	public void StartImmediately() { }

	// RVA: 0xAA2DA0 Offset: 0xAA21A0 VA: 0x180AA2DA0
	private void ReadAndUpdateEnvironment() { }

	// RVA: 0xAA2FB0 Offset: 0xAA23B0 VA: 0x180AA2FB0
	private void ReadEnvironment() { }

	// RVA: 0xAA3B20 Offset: 0xAA2F20 VA: 0x180AA3B20
	private void UpdateCurrentEnvironment() { }

	// RVA: 0xAA1CF0 Offset: 0xAA10F0 VA: 0x180AA1CF0
	private int GetMostCommonReading(List<int> readings) { }

	// RVA: 0xAA1F90 Offset: 0xAA1390 VA: 0x180AA1F90
	private float GetScore(AmbienceDefinition definition, float rain, float snow, float wind, bool underground) { }

	// RVA: 0xAA3960 Offset: 0xAA2D60 VA: 0x180AA3960
	private void UpdateBaseSound(float crossFadeTimeOverride = -1) { }

	// RVA: 0xAA1EE0 Offset: 0xAA12E0 VA: 0x180AA1EE0
	public SoundModulation.Modulator GetPitchModulator() { }

	// RVA: 0xAA3700 Offset: 0xAA2B00 VA: 0x180AA3700
	private void StartSound(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA15B0 Offset: 0xAA09B0 VA: 0x180AA15B0
	private void CrossfadeTo(SoundDefinition def, float fadeTime) { }

	// RVA: 0xAA1B50 Offset: 0xAA0F50 VA: 0x180AA1B50
	public SoundDefinition GetBaseSound() { }

	// RVA: 0xAA1880 Offset: 0xAA0C80 VA: 0x180AA1880
	private SoundDefinition GetBaseSound(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA2610 Offset: 0xAA1A10 VA: 0x180AA2610
	public void PlayStings() { }

	// RVA: 0xAA2860 Offset: 0xAA1C60 VA: 0x180AA2860
	private void PlayStings(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA3260 Offset: 0xAA2660 VA: 0x180AA3260
	private void ResetStingTimes(AmbienceDefinitionList ambienceDefinitionList) { }

	// RVA: 0xAA1E90 Offset: 0xAA1290 VA: 0x180AA1E90
	public float GetNextStingTime(AmbienceDefinition sting) { }

	// RVA: 0xAA1580 Offset: 0xAA0980 VA: 0x180AA1580 Slot: 4
	public int CompareTo(AmbienceEmitter other) { }

	// RVA: 0xAA3B60 Offset: 0xAA2F60 VA: 0x180AA3B60
	public void .ctor() { }

}

public class AmbienceLocalStings : MonoBehaviour // TypeDefIndex: 8973
{	// Fields
	public float maxDistance; // 0x18
	public float stingRadius; // 0x1C
	public float stingFrequency; // 0x20
	public float stingFrequencyVariance; // 0x24
	public SoundDefinition[] stingSounds; // 0x28
	private SynchronizedClock stingClock; // 0x30

	// Methods

	// RVA: 0xAA3C90 Offset: 0xAA3090 VA: 0x180AA3C90
	private void PlaySting(uint seed) { }

	// RVA: 0xAA3F20 Offset: 0xAA3320 VA: 0x180AA3F20
	private void Start() { }

	// RVA: 0xAA3FD0 Offset: 0xAA33D0 VA: 0x180AA3FD0
	private void Update() { }

	// RVA: 0xAA3FF0 Offset: 0xAA33F0 VA: 0x180AA3FF0
	public void .ctor() { }

}

public class AmbienceManager : SingletonComponent<AmbienceManager>, IClientComponent // TypeDefIndex: 8974
{	// Fields
	public List<AmbienceManager.EmitterTypeLimit> localEmitterLimits; // 0x18
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

	// Methods

	// RVA: 0xAA5450 Offset: 0xAA4850 VA: 0x180AA5450
	private void Start() { }

	// RVA: 0xAA4D20 Offset: 0xAA4120 VA: 0x180AA4D20
	private void OnApplicationQuit() { }

	// RVA: 0xAA4F20 Offset: 0xAA4320 VA: 0x180AA4F20
	private void OnDisable() { }

	// RVA: 0xAA6060 Offset: 0xAA5460 VA: 0x180AA6060
	private void Update() { }

	// RVA: 0xAA5B50 Offset: 0xAA4F50 VA: 0x180AA5B50
	private void Tick() { }

	// RVA: 0xAA5890 Offset: 0xAA4C90 VA: 0x180AA5890
	private void TickLocalEmitters() { }

	// RVA: 0xAA4790 Offset: 0xAA3B90 VA: 0x180AA4790
	public void DeactivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA4070 Offset: 0xAA3470 VA: 0x180AA4070
	public void ActivateEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA5590 Offset: 0xAA4990 VA: 0x180AA5590
	private void TickCameraEmitters() { }

	// RVA: 0xAA52D0 Offset: 0xAA46D0 VA: 0x180AA52D0
	private void SortLocalEmitters() { }

	// RVA: 0xAA4A40 Offset: 0xAA3E40 VA: 0x180AA4A40
	private AmbienceManager.EmitterTypeLimit EmitterLimit(AmbienceEmitter emitter) { }

	// RVA: 0xAA4E40 Offset: 0xAA4240 VA: 0x180AA4E40
	public void OnCullingGroupChange(CullingGroupEvent evt, AmbienceManager.AmbienceGroup group) { }

	// RVA: 0xAA49A0 Offset: 0xAA3DA0 VA: 0x180AA49A0
	public void EmitterLeaveRange(AmbienceEmitter emitter) { }

	// RVA: 0xAA41C0 Offset: 0xAA35C0 VA: 0x180AA41C0
	public void AddEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA4FF0 Offset: 0xAA43F0 VA: 0x180AA4FF0
	public void RemoveEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA4160 Offset: 0xAA3560 VA: 0x180AA4160
	public void AddCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA4F90 Offset: 0xAA4390 VA: 0x180AA4F90
	public void RemoveCameraEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA5B90 Offset: 0xAA4F90 VA: 0x180AA5B90
	private void UpdateCullingGroups() { }

	// RVA: 0xAA44B0 Offset: 0xAA38B0 VA: 0x180AA44B0
	private AmbienceManager.AmbienceGroup AmbienceGroupForEmitter(AmbienceEmitter emitter) { }

	// RVA: 0xAA4AD0 Offset: 0xAA3ED0 VA: 0x180AA4AD0
	public void EnableAdvancedAmbience() { }

	// RVA: 0xAA47F0 Offset: 0xAA3BF0 VA: 0x180AA47F0
	public void DisableAdvancedAmbience() { }

	// RVA: 0xAA5270 Offset: 0xAA4670 VA: 0x180AA5270
	private void SortEmitters(List<AmbienceEmitter> emitterList) { }

	// RVA: 0xAA50A0 Offset: 0xAA44A0 VA: 0x180AA50A0
	private void SortEmitters(List<AmbienceEmitter> emitterList, int left, int right) { }

	// RVA: 0xAA45B0 Offset: 0xAA39B0 VA: 0x180AA45B0
	public void AmbienceZoneEntered(AmbienceZone zone) { }

	// RVA: 0xAA4610 Offset: 0xAA3A10 VA: 0x180AA4610
	public void AmbienceZoneExited(AmbienceZone zone) { }

	// RVA: 0xAA4670 Offset: 0xAA3A70 VA: 0x180AA4670
	public AmbienceZone CurrentAmbienceZone() { }

	// RVA: 0xAA6550 Offset: 0xAA5950 VA: 0x180AA6550
	public void .ctor() { }

}

public class AmbienceManager.EmitterTypeLimit // TypeDefIndex: 8975
{	// Fields
	public List<AmbienceDefinitionList> ambience; // 0x10
	public int limit; // 0x18
	public int active; // 0x1C

	// Methods

	// RVA: 0x83A450 Offset: 0x839850 VA: 0x18083A450
	public void .ctor() { }

}

public class AmbienceManager.AmbienceGroup // TypeDefIndex: 8976
{	// Fields
	public AmbienceDefinitionList ambienceDefinition; // 0x10
	public HashSet<AmbienceEmitter> emitters; // 0x18
	public CullingGroup cullingGroup; // 0x20
	public BoundingSphere[] cullGroupSpheres; // 0x28
	public List<AmbienceEmitter> emittersBySphereIdx; // 0x30
	public bool cullingGroupDirty; // 0x38

	// Methods

	// RVA: 0x81F900 Offset: 0x81ED00 VA: 0x18081F900
	public void OnCullingGroupChange(CullingGroupEvent evt) { }

	// RVA: 0x81F980 Offset: 0x81ED80 VA: 0x18081F980
	public void .ctor() { }

}

public class AmbienceSpawnEmitters : MonoBehaviour, IClientComponent // TypeDefIndex: 8977
{	// Fields
	public int baseEmitterCount; // 0x18
	public int baseEmitterDistance; // 0x1C
	public GameObjectRef emitterPrefab; // 0x20

	// Methods

	// RVA: 0x81FE00 Offset: 0x81F200 VA: 0x18081FE00
	private void Start() { }

	// RVA: 0x81FA40 Offset: 0x81EE40 VA: 0x18081FA40
	private void CreateBaseEmitters() { }

	// RVA: 0x81FE10 Offset: 0x81F210 VA: 0x18081FE10
	public void .ctor() { }

}

public class AmbienceZone : TriggerBase, IClientComponentEx // TypeDefIndex: 8978
{	// Fields
	public AmbienceDefinitionList baseAmbience; // 0x30
	public AmbienceDefinitionList stings; // 0x38
	public float priority; // 0x40
	public bool overrideCrossfadeTime; // 0x44
	public float crossfadeTime; // 0x48

	// Methods

	// RVA: 0x81FE30 Offset: 0x81F230 VA: 0x18081FE30
	private void Awake() { }

	// RVA: 0x81FE50 Offset: 0x81F250 VA: 0x18081FE50 Slot: 6
	internal override GameObject InterestedInObject(GameObject obj) { }

	// RVA: 0x81FFB0 Offset: 0x81F3B0 VA: 0x18081FFB0 Slot: 8
	internal override void OnEntityEnter(BaseEntity ent) { }

	// RVA: 0x820030 Offset: 0x81F430 VA: 0x180820030 Slot: 9
	internal override void OnEntityLeave(BaseEntity ent) { }

	// RVA: 0x8200B0 Offset: 0x81F4B0 VA: 0x1808200B0 Slot: 16
	public virtual void PreClientComponentCull(IPrefabProcessor p) { }

	// RVA: 0x8201F0 Offset: 0x81F5F0 VA: 0x1808201F0
	public void .ctor() { }

}

public class AmbientLightLOD : FacepunchBehaviour, ILOD, IClientComponent // TypeDefIndex: 11293
{	// Fields
	public bool isDynamic; // 0x18
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

	// Methods

	// RVA: 0x820690 Offset: 0x81FA90 VA: 0x180820690
	private float GetDistance() { }

	// RVA: 0x820200 Offset: 0x81F600 VA: 0x180820200
	protected void Awake() { }

	// RVA: 0x820830 Offset: 0x81FC30 VA: 0x180820830
	protected void OnEnable() { }

	// RVA: 0x820760 Offset: 0x81FB60 VA: 0x180820760
	protected void OnDisable() { }

	// RVA: 0x820AE0 Offset: 0x81FEE0 VA: 0x180820AE0
	private void ToggleLight(bool state) { }

	// RVA: 0x8204F0 Offset: 0x81F8F0 VA: 0x1808204F0
	private void FadingToggle() { }

	// RVA: 0x820980 Offset: 0x81FD80 VA: 0x180820980
	public void SetLightActive(bool lightOn) { }

	// RVA: 0x820AC0 Offset: 0x81FEC0 VA: 0x180820AC0
	public void SetTargetIntensity(float intensity, float fadeDuration = -1) { }

	// RVA: 0x8208F0 Offset: 0x81FCF0 VA: 0x1808208F0 Slot: 5
	public void RefreshLOD() { }

	// RVA: 0x8202F0 Offset: 0x81F6F0 VA: 0x1808202F0 Slot: 4
	public void ChangeLOD() { }

	// RVA: 0x8208D0 Offset: 0x81FCD0 VA: 0x1808208D0
	protected void OnValidate() { }

	// RVA: 0x820C30 Offset: 0x820030 VA: 0x180820C30
	public void .ctor() { }

}

public enum AmbientOcclusionMode // TypeDefIndex: 11752
{	// Fields
	public int value__; // 0x0
	public const AmbientOcclusionMode ScalableAmbientObscurance = 0;
	public const AmbientOcclusionMode MultiScaleVolumetricObscurance = 1;

}

public enum AmbientOcclusionQuality // TypeDefIndex: 11753
{	// Fields
	public int value__; // 0x0
	public const AmbientOcclusionQuality Lowest = 0;
	public const AmbientOcclusionQuality Low = 1;
	public const AmbientOcclusionQuality Medium = 2;
	public const AmbientOcclusionQuality High = 3;
	public const AmbientOcclusionQuality Ultra = 4;

}

public sealed class AmbientOcclusionModeParameter : ParameterOverride<AmbientOcclusionMode> // TypeDefIndex: 11754
{	// Methods

	// RVA: 0x9CA900 Offset: 0x9C9D00 VA: 0x1809CA900
	public void .ctor() { }

}

public sealed class AmbientOcclusionQualityParameter : ParameterOverride<AmbientOcclusionQuality> // TypeDefIndex: 11755
{	// Methods

	// RVA: 0x9CA940 Offset: 0x9C9D40 VA: 0x1809CA940
	public void .ctor() { }

}

public sealed class AmbientOcclusion : PostProcessEffectSettings // TypeDefIndex: 11756
{	// Fields
	[TooltipAttribute] // RVA: 0xE7CB0 Offset: 0xE70B0 VA: 0x1800E7CB0
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

	// Methods

	// RVA: 0x9CAF70 Offset: 0x9CA370 VA: 0x1809CAF70 Slot: 4
	public override bool IsEnabledAndSupported(PostProcessRenderContext context) { }

	// RVA: 0x9CB380 Offset: 0x9CA780 VA: 0x1809CB380
	public void .ctor() { }

}

internal sealed class AmbientOcclusionRenderer : PostProcessEffectRenderer<AmbientOcclusion> // TypeDefIndex: 11758
{	// Fields
	private IAmbientOcclusionMethod[] m_Methods; // 0x20

	// Methods

	// RVA: 0x9CAC00 Offset: 0x9CA000 VA: 0x1809CAC00 Slot: 4
	public override void Init() { }

	// RVA: 0x9CAD80 Offset: 0x9CA180 VA: 0x1809CAD80
	public bool IsAmbientOnly(PostProcessRenderContext context) { }

	// RVA: 0x9CAB90 Offset: 0x9C9F90 VA: 0x1809CAB90
	public IAmbientOcclusionMethod Get() { }

	// RVA: 0x9CA980 Offset: 0x9C9D80 VA: 0x1809CA980 Slot: 5
	public override DepthTextureMode GetCameraFlags() { }

	// RVA: 0x9CAE10 Offset: 0x9CA210 VA: 0x1809CAE10 Slot: 7
	public override void Release() { }

	// RVA: 0x9CAB10 Offset: 0x9C9F10 VA: 0x1809CAB10
	public ScalableAO GetScalableAO() { }

	// RVA: 0x9CAA90 Offset: 0x9C9E90 VA: 0x1809CAA90
	public MultiScaleVO GetMultiScaleVO() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 8
	public override void Render(PostProcessRenderContext context) { }

	// RVA: 0x9CAF30 Offset: 0x9CA330 VA: 0x1809CAF30
	public void .ctor() { }

}

