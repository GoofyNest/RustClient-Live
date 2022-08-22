public class ExcavatorEffects : MonoBehaviour // TypeDefIndex: 9628
{	public static ExcavatorEffects instance; // 0x0
	public ParticleSystemContainer[] miningParticles; // 0x18
	public SoundPlayer[] miningSounds; // 0x20
	public SoundFollowCollider[] beltSounds; // 0x28
	public SoundPlayer[] miningStartSounds; // 0x30
	public GameObject[] ambientMetalRattles; // 0x38
	public bool wasMining; // 0x40


	public void Awake() { }

	public void OnDestroy() { }

	public void SetMining(bool isMining, bool force = False) { }

	public void .ctor() { }

}

