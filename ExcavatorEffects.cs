public class ExcavatorEffects : MonoBehaviour // TypeDefIndex: 11370
{
	public static ExcavatorEffects instance;
	public ParticleSystemContainer[] miningParticles;
	public SoundPlayer[] miningSounds;
	public SoundFollowCollider[] beltSounds;
	public SoundPlayer[] miningStartSounds;
	public GameObject[] ambientMetalRattles;
	public bool wasMining;


	public void Awake() { }

	public void OnDestroy() { }

	public void SetMining(bool isMining, bool force = False) { }

	public void .ctor() { }

}

