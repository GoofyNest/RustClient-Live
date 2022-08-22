public class TerrainConfig : ScriptableObject // TypeDefIndex: 10309
{	public bool CastShadows; // 0x18
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

	public Texture AlbedoArray { get; }
	public Texture NormalArray { get; }


	public Texture get_AlbedoArray() { }

	public Texture get_NormalArray() { }

	public PhysicMaterial[] GetPhysicMaterials() { }

	public Color[] GetAridColors() { }

	public void GetAridOverlayConstants(out Color[] color, out Vector4[] param) { }

	public Color[] GetTemperateColors() { }

	public void GetTemperateOverlayConstants(out Color[] color, out Vector4[] param) { }

	public Color[] GetTundraColors() { }

	public void GetTundraOverlayConstants(out Color[] color, out Vector4[] param) { }

	public Color[] GetArcticColors() { }

	public void GetArcticOverlayConstants(out Color[] color, out Vector4[] param) { }

	public float[] GetSplatTiling() { }

	public float GetMaxSplatTiling() { }

	public float GetMinSplatTiling() { }

	public Vector3[] GetPackedUVMIX() { }

	public TerrainConfig.GroundType GetCurrentGroundType(bool isGrounded, RaycastHit hit) { }

	public void .ctor() { }

}

public class TerrainConfig.SplatOverlay // TypeDefIndex: 10310
{	public Color Color; // 0x10
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float Smoothness; // 0x20
	[RangeAttribute] // RVA: 0x71260 Offset: 0x70660 VA: 0x180071260
	public float NormalIntensity; // 0x24
	[RangeAttribute] // RVA: 0xC65E0 Offset: 0xC59E0 VA: 0x1800C65E0
	public float BlendFactor; // 0x28
	[RangeAttribute] // RVA: 0xC68D0 Offset: 0xC5CD0 VA: 0x1800C68D0
	public float BlendFalloff; // 0x2C


	public void .ctor() { }

}

public class TerrainConfig.SplatType // TypeDefIndex: 10311
{	public string Name; // 0x10
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


	public void .ctor() { }

}

public enum TerrainConfig.GroundType // TypeDefIndex: 10312
{	public int value__; // 0x0
	public const TerrainConfig.GroundType None = 0;
	public const TerrainConfig.GroundType HardSurface = 1;
	public const TerrainConfig.GroundType Grass = 2;
	public const TerrainConfig.GroundType Sand = 3;
	public const TerrainConfig.GroundType Snow = 4;
	public const TerrainConfig.GroundType Dirt = 5;
	public const TerrainConfig.GroundType Gravel = 6;

}

