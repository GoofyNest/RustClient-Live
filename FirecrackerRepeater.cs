public class FirecrackerRepeater : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10466
{
	public GameObjectRef singleExplosionEffect; 
	public Transform[] parts; 
	public float partWidth; 
	public float partLength; 
	public Quaternion[] targetRotations; 
	public Quaternion[] initialRotations; 
	public Renderer[] renderers; 
	public Material materialSource; 
	public float explodeRepeatMin; 
	public float explodeRepeatMax; 
	public float explodeLerpSpeed; 
	public Vector3 twistAmount; 
	public float fuseLength; 
	public float explodeStrength; 
	public float explodeDirBlend; 
	public float duration; 
	public ParticleSystemContainer smokeParticle; 
	private float nextExplodeTime; 
	private float nextPartTime; 
	private int explodingPartIndex; 
	private Material instancedMaterial; 
	private bool lit; 
	private float startTime; 


	private void Start() { }

	public void OnDestroy() { }

	public void Begin() { }

	public float GetProgress() { }

	public void Update() { }

	public void SetTwistAmount(int index, Vector3 twistAmountToUse) { }

	public void Explode() { }

	public void .ctor() { }

}

