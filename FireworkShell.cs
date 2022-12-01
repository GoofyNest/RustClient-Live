public class FireworkShell : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 9988
{
	public float fuseLengthMin;
	public float fuseLengthMax;
	public float speedMin;
	public float speedMax;
	public ParticleSystem explodePFX;
	public SoundPlayer explodeSound;
	public float inaccuracyDegrees;
	public LightEx explosionLight;
	public float lifetime;
	private float speed;
	protected bool exploded;


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

