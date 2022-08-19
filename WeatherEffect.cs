public abstract class WeatherEffect : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10068
{	// Fields
	public ParticleSystem[] emitOnStart; // 0x18
	public ParticleSystem[] emitOnStop; // 0x20
	public ParticleSystem[] emitOnLoop; // 0x28
	private float currentIntensity; // 0x30
	private float[] maxEmissionRates; // 0x38
	private Action invokeUpdate; // 0x40

	// Methods

	// RVA: 0x89C2F0 Offset: 0x89B6F0 VA: 0x18089C2F0
	protected void Awake() { }

	// RVA: 0x89C880 Offset: 0x89BC80 VA: 0x18089C880
	protected void OnEnable() { }

	// RVA: 0x89C870 Offset: 0x89BC70 VA: 0x18089C870
	protected void OnDisable() { }

	// RVA: 0x89C470 Offset: 0x89B870 VA: 0x18089C470
	protected void InvokeUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: -1 Offset: -1 Slot: 7
	protected abstract float GetUpdateInterval(float intensity);

	// RVA: -1 Offset: -1 Slot: 8
	protected abstract void UpdatePosition(float intensity);

	// RVA: 0x89C890 Offset: 0x89BC90 VA: 0x18089C890
	protected void .ctor() { }

}

