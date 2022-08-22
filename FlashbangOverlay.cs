public class FlashbangOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 9128
{	public static FlashbangOverlay Instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public AnimationCurve burnIntensityCurve; // 0x20
	public AnimationCurve whiteoutIntensityCurve; // 0x28
	public SoundDefinition deafLoopDef; // 0x30
	private FlashbangEffect flashbangEffect; // 0x38
	private float flashLength; // 0x40
	private TimeSince flashTime; // 0x44
	private Sound deafLoop; // 0x48
	private SoundModulation.Modulator deafGain; // 0x50


	protected void Awake() { }

	public void Flash(float time) { }

	private void Update() { }

	public void UpdateAudio() { }

	public void ShutdownAudio() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

