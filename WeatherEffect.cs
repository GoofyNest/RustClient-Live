public abstract class WeatherEffect : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10068
{	public ParticleSystem[] emitOnStart; // 0x18
	public ParticleSystem[] emitOnStop; // 0x20
	public ParticleSystem[] emitOnLoop; // 0x28
	private float currentIntensity; // 0x30
	private float[] maxEmissionRates; // 0x38
	private Action invokeUpdate; // 0x40


	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void InvokeUpdate() { }

	protected abstract float GetCurrentIntensity();

	protected abstract float GetUpdateInterval(float intensity);

	protected abstract void UpdatePosition(float intensity);

	protected void .ctor() { }

}

