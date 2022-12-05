public static class Config // TypeDefIndex: 8266
{
	public const string LibraryName = "EOSSDK-Win64-Shipping";
	public const CallingConvention LibraryCallingConvention = 2;

}

public class Config : ScriptableObject // TypeDefIndex: 13342
{
	public int geometryLayerID;
	public string geometryTag;
	public int geometryRenderQueue;
	public bool forceSinglePass;
	[SerializeField]
	[HighlightNullAttribute]
	private Shader beamShader1Pass;
	[FormerlySerializedAsAttribute]
	[FormerlySerializedAsAttribute]
	[SerializeField]
	[HighlightNullAttribute]
	private Shader beamShader2Pass;
	public int sharedMeshSides;
	public int sharedMeshSegments;
	[RangeAttribute]
	public float globalNoiseScale;
	public Vector3 globalNoiseVelocity;
	[HighlightNullAttribute]
	public TextAsset noise3DData;
	public int noise3DSize;
	[HighlightNullAttribute]
	public ParticleSystem dustParticlesPrefab;
	private static Config m_Instance;

	public Shader beamShader { get; }
	public Vector4 globalNoiseParam { get; }
	public static Config Instance { get; }


	public Shader get_beamShader() { }

	public Vector4 get_globalNoiseParam() { }

	public void Reset() { }

	public ParticleSystem NewVolumetricDustParticles() { }

	public static Config get_Instance() { }

	public void .ctor() { }

	private static void .cctor() { }

}

