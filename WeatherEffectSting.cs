public abstract class WeatherEffectSting : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 11827
{
	public float frequency;
	public float variance;
	public GameObjectRef[] effects;
	private SynchronizedClock stingClock;


	private void PlaySting(uint seed) { }

	protected void Awake() { }

	protected void LateUpdate() { }

	protected abstract float GetCurrentIntensity();

	protected void .ctor() { }

}

