public class FirecrackerRepeater : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8755
{	// Fields
	public GameObjectRef singleExplosionEffect; // 0x18
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

	// Methods

	// RVA: 0x7876A0 Offset: 0x786AA0 VA: 0x1807876A0
	private void Start() { }

	// RVA: 0x787300 Offset: 0x786700 VA: 0x180787300
	public void OnDestroy() { }

	// RVA: 0x786EC0 Offset: 0x7862C0 VA: 0x180786EC0
	public void Begin() { }

	// RVA: 0x787260 Offset: 0x786660 VA: 0x180787260
	public float GetProgress() { }

	// RVA: 0x787940 Offset: 0x786D40 VA: 0x180787940
	public void Update() { }

	// RVA: 0x787360 Offset: 0x786760 VA: 0x180787360
	public void SetTwistAmount(int index, Vector3 twistAmountToUse) { }

	// RVA: 0x786F00 Offset: 0x786300 VA: 0x180786F00
	public void Explode() { }

	// RVA: 0x787D10 Offset: 0x787110 VA: 0x180787D10
	public void .ctor() { }

}

