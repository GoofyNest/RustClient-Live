public class Config : ScriptableObject // TypeDefIndex: 11534
{	// Fields
	public int geometryLayerID; // 0x18
	public string geometryTag; // 0x20
	public int geometryRenderQueue; // 0x28
	public bool forceSinglePass; // 0x2C
	[SerializeField] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	[HighlightNullAttribute] // RVA: 0x93360 Offset: 0x92760 VA: 0x180093360
	private Shader beamShader1Pass; // 0x30
	[FormerlySerializedAsAttribute] // RVA: 0xBEEE0 Offset: 0xBE2E0 VA: 0x1800BEEE0
	[FormerlySerializedAsAttribute] // RVA: 0xBEEE0 Offset: 0xBE2E0 VA: 0x1800BEEE0
	[SerializeField] // RVA: 0xBEEE0 Offset: 0xBE2E0 VA: 0x1800BEEE0
	[HighlightNullAttribute] // RVA: 0xBEEE0 Offset: 0xBE2E0 VA: 0x1800BEEE0
	private Shader beamShader2Pass; // 0x38
	public int sharedMeshSides; // 0x40
	public int sharedMeshSegments; // 0x44
	[RangeAttribute] // RVA: 0xBF120 Offset: 0xBE520 VA: 0x1800BF120
	public float globalNoiseScale; // 0x48
	public Vector3 globalNoiseVelocity; // 0x4C
	[HighlightNullAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public TextAsset noise3DData; // 0x58
	public int noise3DSize; // 0x60
	[HighlightNullAttribute] // RVA: 0x70A20 Offset: 0x6FE20 VA: 0x180070A20
	public ParticleSystem dustParticlesPrefab; // 0x68
	private static Config m_Instance; // 0x0

	// Properties
	public Shader beamShader { get; }
	public Vector4 globalNoiseParam { get; }
	public static Config Instance { get; }

	// Methods

	// RVA: 0x1118650 Offset: 0x1117A50 VA: 0x181118650
	public Shader get_beamShader() { }

	// RVA: 0x1118660 Offset: 0x1117A60 VA: 0x181118660
	public Vector4 get_globalNoiseParam() { }

	// RVA: 0x1118220 Offset: 0x1117620 VA: 0x181118220
	public void Reset() { }

	// RVA: 0x1118050 Offset: 0x1117450 VA: 0x181118050
	public ParticleSystem NewVolumetricDustParticles() { }

	// RVA: 0x1118490 Offset: 0x1117890 VA: 0x181118490
	public static Config get_Instance() { }

	// RVA: 0x11183E0 Offset: 0x11177E0 VA: 0x1811183E0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

