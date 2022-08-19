public class ExcavatorEffects : MonoBehaviour // TypeDefIndex: 9628
{	// Fields
	public static ExcavatorEffects instance; // 0x0
	public ParticleSystemContainer[] miningParticles; // 0x18
	public SoundPlayer[] miningSounds; // 0x20
	public SoundFollowCollider[] beltSounds; // 0x28
	public SoundPlayer[] miningStartSounds; // 0x30
	public GameObject[] ambientMetalRattles; // 0x38
	public bool wasMining; // 0x40

	// Methods

	// RVA: 0x8BD9E0 Offset: 0x8BCDE0 VA: 0x1808BD9E0
	public void Awake() { }

	// RVA: 0x8BDA40 Offset: 0x8BCE40 VA: 0x1808BDA40
	public void OnDestroy() { }

	// RVA: 0x8BDA80 Offset: 0x8BCE80 VA: 0x1808BDA80
	public void SetMining(bool isMining, bool force = False) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

