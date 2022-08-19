public class LightGroupAtTime : FacepunchBehaviour // TypeDefIndex: 9196
{	// Fields
	public float IntensityOverride; // 0x18
	public AnimationCurve IntensityScaleOverTime; // 0x20
	public Transform SearchRoot; // 0x28
	[HeaderAttribute] // RVA: 0xD8D70 Offset: 0xD8170 VA: 0x1800D8D70
	public bool requiresPower; // 0x30
	[TooltipAttribute] // RVA: 0xD8FE0 Offset: 0xD83E0 VA: 0x1800D8FE0
	public Transform powerOverrideTransform; // 0x38
	private List<KeyValuePair<Light, float>> lights; // 0x40
	private List<KeyValuePair<AmbientLightLOD, float>> lightLODs; // 0x48
	private List<KeyValuePair<Renderer, Color>> renderers; // 0x50
	private List<VolumetricLightBeam> beams; // 0x58
	private List<CoverageQueryFlare> coverageQueryFlares; // 0x60
	private List<DistanceFlareLOD> distanceFlares; // 0x68
	private MaterialPropertyBlock block; // 0x70
	private float intensityOverride; // 0x78
	private int lightIndex; // 0x7C
	private int lightLODIndex; // 0x80
	private int beamIndex; // 0x84
	private int rendererIndex; // 0x88
	private int simpleFlareIndex; // 0x8C
	private int distanceFlareIndex; // 0x90
	private readonly int EmissionPropertyID; // 0x94
	private readonly int ColorFlatPropertyID; // 0x98
	private readonly int LightsPerFrame; // 0x9C
	private readonly int LightLODsPerFrame; // 0xA0
	private readonly int BeamsPerFrame; // 0xA4
	private readonly int RenderersPerFrame; // 0xA8
	private readonly int SimpleFlaresPerFrame; // 0xAC
	private readonly int DistanceFlaresPerFrame; // 0xB0
	public static LightGroupAtTime.LightGroupWorkQueue WorkQueue; // 0x0
	private IOEntity cachedPowerEnt; // 0xB8

	// Methods

	// RVA: 0x4EC770 Offset: 0x4EBB70 VA: 0x1804EC770
	private void Clear() { }

	// RVA: 0x4EC700 Offset: 0x4EBB00 VA: 0x1804EC700
	private void Awake() { }

	// RVA: 0x4ECC80 Offset: 0x4EC080 VA: 0x1804ECC80
	private void OnEnable() { }

	// RVA: 0x4ECC00 Offset: 0x4EC000 VA: 0x1804ECC00
	private void OnDisable() { }

	// RVA: 0x4EC820 Offset: 0x4EBC20 VA: 0x1804EC820 Slot: 4
	public virtual float GetIntensity() { }

	// RVA: 0x4EC940 Offset: 0x4EBD40 VA: 0x1804EC940 Slot: 5
	public virtual float GetPowerScale() { }

	// RVA: 0x4ED160 Offset: 0x4EC560 VA: 0x1804ED160
	private void UpdateLights() { }

	// RVA: 0x4EDA50 Offset: 0x4ECE50 VA: 0x1804EDA50
	public void .ctor() { }

	// RVA: 0x4ED9D0 Offset: 0x4ECDD0 VA: 0x1804ED9D0
	private static void .cctor() { }

}

public class LightGroupAtTime.LightGroupWorkQueue : PersistentObjectWorkQueue<LightGroupAtTime> // TypeDefIndex: 9197
{	// Methods

	// RVA: 0x4EDE60 Offset: 0x4ED260 VA: 0x1804EDE60 Slot: 5
	protected override void RunJob(LightGroupAtTime entity) { }

	// RVA: 0x4EDE80 Offset: 0x4ED280 VA: 0x1804EDE80
	public void .ctor() { }

}

