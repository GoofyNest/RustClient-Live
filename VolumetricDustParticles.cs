public class VolumetricDustParticles : MonoBehaviour // TypeDefIndex: 13359
{
	[RangeAttribute]
	public float alpha;
	[RangeAttribute]
	public float size;
	public VolumetricDustParticles.Direction direction;
	public float speed;
	public float density;
	[RangeAttribute]
	public float spawnMaxDistance;
	public bool cullingEnabled;
	public float cullingMaxDistance;
	[CompilerGeneratedAttribute]
	private bool <isCulled>k__BackingField;
	public static bool isFeatureSupported;
	private ParticleSystem m_Particles;
	private ParticleSystemRenderer m_Renderer;
	private static bool ms_NoMainCameraLogged;
	private static Camera ms_MainCamera;
	private VolumetricLightBeam m_Master;

	public bool isCulled { get; set; }
	public bool particlesAreInstantiated { get; }
	public int particlesCurrentCount { get; }
	public int particlesMaxCount { get; }
	public Camera mainCamera { get; }


	[CompilerGeneratedAttribute]
	public bool get_isCulled() { }

	[CompilerGeneratedAttribute]
	private void set_isCulled(bool value) { }

	public bool get_particlesAreInstantiated() { }

	public int get_particlesCurrentCount() { }

	public int get_particlesMaxCount() { }

	public Camera get_mainCamera() { }

	private void Start() { }

	private void InstantiateParticleSystem() { }

	private void OnEnable() { }

	private void SetActiveAndPlay() { }

	private void OnDisable() { }

	private void OnDestroy() { }

	private void Update() { }

	private void SetParticleProperties() { }

	private void UpdateCulling() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum VolumetricDustParticles.Direction // TypeDefIndex: 13360
{
	public int value__;
	public const VolumetricDustParticles.Direction Beam = 0;
	public const VolumetricDustParticles.Direction Random = 1;

}

