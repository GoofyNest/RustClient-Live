public class FlashbangOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 9128
{	// Fields
	public static FlashbangOverlay Instance; // 0x0
	public PostProcessVolume postProcessVolume; // 0x18
	public AnimationCurve burnIntensityCurve; // 0x20
	public AnimationCurve whiteoutIntensityCurve; // 0x28
	public SoundDefinition deafLoopDef; // 0x30
	private FlashbangEffect flashbangEffect; // 0x38
	private float flashLength; // 0x40
	private TimeSince flashTime; // 0x44
	private Sound deafLoop; // 0x48
	private SoundModulation.Modulator deafGain; // 0x50

	// Methods

	// RVA: 0x78EC70 Offset: 0x78E070 VA: 0x18078EC70
	protected void Awake() { }

	// RVA: 0x78ED00 Offset: 0x78E100 VA: 0x18078ED00
	public void Flash(float time) { }

	// RVA: 0x78F300 Offset: 0x78E700 VA: 0x18078F300
	private void Update() { }

	// RVA: 0x78F050 Offset: 0x78E450 VA: 0x18078F050
	public void UpdateAudio() { }

	// RVA: 0x78EF00 Offset: 0x78E300 VA: 0x18078EF00
	public void ShutdownAudio() { }

	// RVA: 0x78ED80 Offset: 0x78E180 VA: 0x18078ED80
	private void OnDestroy() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

