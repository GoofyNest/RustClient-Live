public class RadiationOverlay : MonoBehaviour // TypeDefIndex: 9133
{	// Fields
	public SoundDefinition[] geigerSounds; // 0x18
	public PostProcessVolume postProcessVolume; // 0x20
	private Sound sound; // 0x28
	private float smoothRadiationCurrent; // 0x30
	private float smoothRadiationVelocity; // 0x34
	private float smoothRadiationExposureCurrent; // 0x38
	private float smoothRadiationExposureVelocity; // 0x3C

	// Methods

	// RVA: 0x6A1460 Offset: 0x6A0860 VA: 0x1806A1460
	public void Awake() { }

	// RVA: 0x6A1A00 Offset: 0x6A0E00 VA: 0x1806A1A00
	protected void Update() { }

	// RVA: 0x6A1800 Offset: 0x6A0C00 VA: 0x1806A1800
	private void UpdateSound(float exposure) { }

	// RVA: 0x6A1650 Offset: 0x6A0A50 VA: 0x1806A1650
	private float GetRadationFraction() { }

	// RVA: 0x6A1490 Offset: 0x6A0890 VA: 0x1806A1490
	private float GetRadationExposureFraction() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

