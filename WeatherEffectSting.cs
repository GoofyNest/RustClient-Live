public abstract class WeatherEffectSting : BaseMonoBehaviour, IClientComponent // TypeDefIndex: 10074
{	// Fields
	public float frequency; // 0x18
	public float variance; // 0x1C
	public GameObjectRef[] effects; // 0x20
	private SynchronizedClock stingClock; // 0x28

	// Methods

	// RVA: 0x89C030 Offset: 0x89B430 VA: 0x18089C030
	private void PlaySting(uint seed) { }

	// RVA: 0x89BE40 Offset: 0x89B240 VA: 0x18089BE40
	protected void Awake() { }

	// RVA: 0x89BEF0 Offset: 0x89B2F0 VA: 0x18089BEF0
	protected void LateUpdate() { }

	// RVA: -1 Offset: -1 Slot: 6
	protected abstract float GetCurrentIntensity();

	// RVA: 0x89C270 Offset: 0x89B670 VA: 0x18089C270
	protected void .ctor() { }

}

