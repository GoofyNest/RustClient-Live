public class FireworkShell : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 8272
{	public float fuseLengthMin; // 0x18
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


	public virtual void Init(MortarFirework firework) { }

	public void ToggleExplosionLight(bool wantsOn) { }

	public virtual void Update() { }

	public virtual void Cleanup() { }

	public float SoundDelayTime() { }

	public void PlaySound() { }

	public virtual void Explode() { }

	public virtual float CalculateFuseLength() { }

	public void .ctor() { }

}

