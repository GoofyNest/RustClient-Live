public class RadiationOverlay : MonoBehaviour // TypeDefIndex: 9133
{	public SoundDefinition[] geigerSounds; // 0x18
	public PostProcessVolume postProcessVolume; // 0x20
	private Sound sound; // 0x28
	private float smoothRadiationCurrent; // 0x30
	private float smoothRadiationVelocity; // 0x34
	private float smoothRadiationExposureCurrent; // 0x38
	private float smoothRadiationExposureVelocity; // 0x3C


	public void Awake() { }

	protected void Update() { }

	private void UpdateSound(float exposure) { }

	private float GetRadationFraction() { }

	private float GetRadationExposureFraction() { }

	public void .ctor() { }

}

