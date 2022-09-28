public class FlashbangOverlay : MonoBehaviour, IClientComponent // TypeDefIndex: 10801
{
	public static FlashbangOverlay Instance; 
	public PostProcessVolume postProcessVolume; 
	public AnimationCurve burnIntensityCurve; 
	public AnimationCurve whiteoutIntensityCurve; 
	public SoundDefinition deafLoopDef; 
	private FlashbangEffect flashbangEffect; 
	private float flashLength; 
	private TimeSince flashTime; 
	private Sound deafLoop; 
	private SoundModulation.Modulator deafGain; 


	protected void Awake() { }

	public void Flash(float time) { }

	private void Update() { }

	public void UpdateAudio() { }

	public void ShutdownAudio() { }

	private void OnDestroy() { }

	public void .ctor() { }

}

