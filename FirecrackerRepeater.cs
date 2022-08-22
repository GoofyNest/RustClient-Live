public class FirecrackerRepeater : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8755
{	public GameObjectRef singleExplosionEffect; // 0x18
	public Transform[] parts; // 0x20
	public float partWidth; // 0x28
	public float partLength; // 0x2C
	public Quaternion[] targetRotations; // 0x30
	public Quaternion[] initialRotations; // 0x38
	public Renderer[] renderers; // 0x40
	public Material materialSource; // 0x48
	public float explodeRepeatMin; // 0x50
	public float explodeRepeatMax; // 0x54
	public float explodeLerpSpeed; // 0x58
	public Vector3 twistAmount; // 0x5C
	public float fuseLength; // 0x68
	public float explodeStrength; // 0x6C
	public float explodeDirBlend; // 0x70
	public float duration; // 0x74
	public ParticleSystemContainer smokeParticle; // 0x78
	private float nextExplodeTime; // 0x80
	private float nextPartTime; // 0x84
	private int explodingPartIndex; // 0x88
	private Material instancedMaterial; // 0x90
	private bool lit; // 0x98
	private float startTime; // 0x9C


	private void Start() { }

	public void OnDestroy() { }

	public void Begin() { }

	public float GetProgress() { }

	public void Update() { }

	public void SetTwistAmount(int index, Vector3 twistAmountToUse) { }

	public void Explode() { }

	public void .ctor() { }

}

