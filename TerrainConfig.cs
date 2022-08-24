public class TerrainConfig : ScriptableObject // TypeDefIndex: 10309
{
	public bool CastShadows; 
	public LayerMask GroundMask; 
	public LayerMask WaterMask; 
	public PhysicMaterial GenericMaterial; 
	public Material Material; 
	public Material MarginMaterial; 
	public Texture[] AlbedoArrays; 
	public Texture[] NormalArrays; 
	public float HeightMapErrorMin; 
	public float HeightMapErrorMax; 
	public float BaseMapDistanceMin; 
	public float BaseMapDistanceMax; 
	public float ShaderLodMin; 
	public float ShaderLodMax; 
	public TerrainConfig.SplatType[] Splats; 
	private string snowMatName; 
	private string grassMatName; 
	private string sandMatName; 
	private List<string> dirtMatNames; 
	private List<string> stoneyMatNames; 

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
{
	public Color Color; 
	[RangeAttribute] 
	public float Smoothness; 
	[RangeAttribute] 
	public float NormalIntensity; 
	[RangeAttribute] 
	public float BlendFactor; 
	[RangeAttribute] 
	public float BlendFalloff; 


	public void .ctor() { }

}

public class TerrainConfig.SplatType // TypeDefIndex: 10311
{
	public string Name; 
	[FormerlySerializedAsAttribute] 
	public Color AridColor; 
	public TerrainConfig.SplatOverlay AridOverlay; 
	[FormerlySerializedAsAttribute] 
	public Color TemperateColor; 
	public TerrainConfig.SplatOverlay TemperateOverlay; 
	[FormerlySerializedAsAttribute] 
	public Color TundraColor; 
	public TerrainConfig.SplatOverlay TundraOverlay; 
	[FormerlySerializedAsAttribute] 
	public Color ArcticColor; 
	public TerrainConfig.SplatOverlay ArcticOverlay; 
	public PhysicMaterial Material; 
	public float SplatTiling; 
	[RangeAttribute] 
	public float UVMIXMult; 
	public float UVMIXStart; 
	public float UVMIXDist; 


	public void .ctor() { }

}

public enum TerrainConfig.GroundType // TypeDefIndex: 10312
{
	public int value__; 
	public const TerrainConfig.GroundType None = 0;
	public const TerrainConfig.GroundType HardSurface = 1;
	public const TerrainConfig.GroundType Grass = 2;
	public const TerrainConfig.GroundType Sand = 3;
	public const TerrainConfig.GroundType Snow = 4;
	public const TerrainConfig.GroundType Dirt = 5;
	public const TerrainConfig.GroundType Gravel = 6;

}

