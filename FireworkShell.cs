public class FireworkShell : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8272
{	// Fields
	public float fuseLengthMin; // 0x18
	public float fuseLengthMax; // 0x1C
	public float speedMin; // 0x20
	public float speedMax; // 0x24
	public ParticleSystem explodePFX; // 0x28
	public SoundPlayer explodeSound; // 0x30
	public float inaccuracyDegrees; // 0x38
	public LightEx explosionLight; // 0x40
	public float lifetime; // 0x48
	private float speed; // 0x4C
	protected bool exploded; // 0x50

	// Methods

	// RVA: 0x788380 Offset: 0x787780 VA: 0x180788380 Slot: 6
	public virtual void Init(MortarFirework firework) { }

	// RVA: 0x7886A0 Offset: 0x787AA0 VA: 0x1807886A0
	public void ToggleExplosionLight(bool wantsOn) { }

	// RVA: 0x788740 Offset: 0x787B40 VA: 0x180788740 Slot: 7
	public virtual void Update() { }

	// RVA: 0x788060 Offset: 0x787460 VA: 0x180788060 Slot: 8
	public virtual void Cleanup() { }

	// RVA: 0x788530 Offset: 0x787930 VA: 0x180788530
	public float SoundDelayTime() { }

	// RVA: 0x788510 Offset: 0x787910 VA: 0x180788510
	public void PlaySound() { }

	// RVA: 0x7880F0 Offset: 0x7874F0 VA: 0x1807880F0 Slot: 9
	public virtual void Explode() { }

	// RVA: 0x788040 Offset: 0x787440 VA: 0x180788040 Slot: 10
	public virtual float CalculateFuseLength() { }

	// RVA: 0x7889E0 Offset: 0x787DE0 VA: 0x1807889E0
	public void .ctor() { }

}

