public class MixerSnapshotManager : SingletonComponent<MixerSnapshotManager>, IClientComponent // TypeDefIndex: 10713
{
	public AudioMixerSnapshot defaultSnapshot; 
	public AudioMixerSnapshot underwaterSnapshot; 
	public AudioMixerSnapshot loadingSnapshot; 
	public AudioMixerSnapshot woundedSnapshot; 
	public AudioMixerSnapshot cctvSnapshot; 
	public SoundDefinition underwaterInSound; 
	public SoundDefinition underwaterOutSound; 
	public AudioMixerSnapshot recordingSnapshot; 
	public SoundDefinition woundedLoop; 
	private Sound woundedLoopSound; 
	public SoundDefinition cctvModeLoopDef; 
	private Sound cctvModeLoop; 
	public SoundDefinition cctvModeStartDef; 
	public SoundDefinition cctvModeStopDef; 
	public float deafness; 
	private bool cctvMode; 
	internal AudioMixerSnapshot currentState; 


	protected override void Awake() { }

	private void Update() { }

	public void SetCCTVMode(bool enabled) { }

	private void DoWoundedLoop() { }

	private AudioMixerSnapshot GetTargetState(bool isUnderwater) { }

	public void .ctor() { }

}

