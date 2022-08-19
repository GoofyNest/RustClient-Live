public class TerrainConfig : ScriptableObject // TypeDefIndex: 10309
{	// Fields
	public bool CastShadows; // 0x18
	public LayerMask GroundMask; // 0x1C
	public LayerMask WaterMask; // 0x20
	public PhysicMaterial GenericMaterial; // 0x28
	public Material Material; // 0x30
	public Material MarginMaterial; // 0x38
	public Texture[] AlbedoArrays; // 0x40
	public Texture[] NormalArrays; // 0x48
	public float HeightMapErrorMin; // 0x50
	public float HeightMapErrorMax; // 0x54
	public float BaseMapDistanceMin; // 0x58
	public float BaseMapDistanceMax; // 0x5C
	public float ShaderLodMin; // 0x60
	public float ShaderLodMax; // 0x64
	public TerrainConfig.SplatType[] Splats; // 0x68
	private string snowMatName; // 0x70
	private string grassMatName; // 0x78
	private string sandMatName; // 0x80
	private List<string> dirtMatNames; // 0x88
	private List<string> stoneyMatNames; // 0x90

	// Properties
	public Texture AlbedoArray { get; }
	public Texture NormalArray { get; }

	// Methods

	// RVA: 0x1139AF0 Offset: 0x1138EF0 VA: 0x181139AF0
	public Texture get_AlbedoArray() { }

	// RVA: 0x1139B90 Offset: 0x1138F90 VA: 0x181139B90
	public Texture get_NormalArray() { }

	// RVA: 0x1139260 Offset: 0x1138660 VA: 0x181139260
	public PhysicMaterial[] GetPhysicMaterials() { }

	// RVA: 0x1138820 Offset: 0x1137C20 VA: 0x181138820
	public Color[] GetAridColors() { }

	// RVA: 0x11388F0 Offset: 0x1137CF0 VA: 0x1811388F0
	public void GetAridOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x1139470 Offset: 0x1138870 VA: 0x181139470
	public Color[] GetTemperateColors() { }

	// RVA: 0x1139540 Offset: 0x1138940 VA: 0x181139540
	public void GetTemperateOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x1139740 Offset: 0x1138B40 VA: 0x181139740
	public Color[] GetTundraColors() { }

	// RVA: 0x1139810 Offset: 0x1138C10 VA: 0x181139810
	public void GetTundraOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x1138550 Offset: 0x1137950 VA: 0x181138550
	public Color[] GetArcticColors() { }

	// RVA: 0x1138620 Offset: 0x1137A20 VA: 0x181138620
	public void GetArcticOverlayConstants(out Color[] color, out Vector4[] param) { }

	// RVA: 0x11393A0 Offset: 0x11387A0 VA: 0x1811393A0
	public float[] GetSplatTiling() { }

	// RVA: 0x1139030 Offset: 0x1138430 VA: 0x181139030
	public float GetMaxSplatTiling() { }

	// RVA: 0x11390A0 Offset: 0x11384A0 VA: 0x1811390A0
	public float GetMinSplatTiling() { }

	// RVA: 0x1139110 Offset: 0x1138510 VA: 0x181139110
	public Vector3[] GetPackedUVMIX() { }

	// RVA: 0x1138AF0 Offset: 0x1137EF0 VA: 0x181138AF0
	public TerrainConfig.GroundType GetCurrentGroundType(bool isGrounded, RaycastHit hit) { }

	// RVA: 0x1139A10 Offset: 0x1138E10 VA: 0x181139A10
	public void .ctor() { }

}

public class TerrainConfig.SplatOverlay // TypeDefIndex: 10310
{	// Fields
	public Color Color; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Smoothness; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float NormalIntensity; // 0x24
	[RangeAttribute] // RVA: 0xC65E0 Offset: 0xC59E0 VA: 0x1800C65E0
	public float BlendFactor; // 0x28
	[RangeAttribute] // RVA: 0xC68D0 Offset: 0xC5CD0 VA: 0x1800C68D0
	public float BlendFalloff; // 0x2C

	// Methods

	// RVA: 0x112F860 Offset: 0x112EC60 VA: 0x18112F860
	public void .ctor() { }

}

public class TerrainConfig.SplatType // TypeDefIndex: 10311
{	// Fields
	public string Name; // 0x10
	[FormerlySerializedAsAttribute] // RVA: 0xC6940 Offset: 0xC5D40 VA: 0x1800C6940
	public Color AridColor; // 0x18
	public TerrainConfig.SplatOverlay AridOverlay; // 0x28
	[FormerlySerializedAsAttribute] // RVA: 0xC6AA0 Offset: 0xC5EA0 VA: 0x1800C6AA0
	public Color TemperateColor; // 0x30
	public TerrainConfig.SplatOverlay TemperateOverlay; // 0x40
	[FormerlySerializedAsAttribute] // RVA: 0xC6B50 Offset: 0xC5F50 VA: 0x1800C6B50
	public Color TundraColor; // 0x48
	public TerrainConfig.SplatOverlay TundraOverlay; // 0x58
	[FormerlySerializedAsAttribute] // RVA: 0xC6B50 Offset: 0xC5F50 VA: 0x1800C6B50
	public Color ArcticColor; // 0x60
	public TerrainConfig.SplatOverlay ArcticOverlay; // 0x70
	public PhysicMaterial Material; // 0x78
	public float SplatTiling; // 0x80
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float UVMIXMult; // 0x84
	public float UVMIXStart; // 0x88
	public float UVMIXDist; // 0x8C

	// Methods

	// RVA: 0x112F8D0 Offset: 0x112ECD0 VA: 0x18112F8D0
	public void .ctor() { }

}

public enum TerrainConfig.GroundType // TypeDefIndex: 10312
{	// Fields
	public int value__; // 0x0
	public const TerrainConfig.GroundType None = 0;
	public const TerrainConfig.GroundType HardSurface = 1;
	public const TerrainConfig.GroundType Grass = 2;
	public const TerrainConfig.GroundType Sand = 3;
	public const TerrainConfig.GroundType Snow = 4;
	public const TerrainConfig.GroundType Dirt = 5;
	public const TerrainConfig.GroundType Gravel = 6;

}

