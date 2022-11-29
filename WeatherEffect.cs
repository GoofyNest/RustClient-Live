public abstract class WeatherEffect : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 11814
{
	public ParticleSystem[] emitOnStart; 
	public ParticleSystem[] emitOnStop; 
	public ParticleSystem[] emitOnLoop; 
	private float currentIntensity; 
	private float[] maxEmissionRates; 
	private Action invokeUpdate; 


	protected void Awake() { }

	protected void OnEnable() { }

	protected void OnDisable() { }

	protected void InvokeUpdate() { }

	protected abstract float GetCurrentIntensity();

	protected abstract float GetUpdateInterval(float intensity);

	protected abstract void UpdatePosition(float intensity);

	protected void .ctor() { }

}

