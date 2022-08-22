public class LightGroupAtTime : FacepunchBehaviour // TypeDefIndex: 9196
{	public float IntensityOverride; // 0x18
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


	private void Clear() { }

	private void Awake() { }

	private void OnEnable() { }

	private void OnDisable() { }

	public virtual float GetIntensity() { }

	public virtual float GetPowerScale() { }

	private void UpdateLights() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class LightGroupAtTime.LightGroupWorkQueue : PersistentObjectWorkQueue<LightGroupAtTime> // TypeDefIndex: 9197
{
	protected override void RunJob(LightGroupAtTime entity) { }

	public void .ctor() { }

}

