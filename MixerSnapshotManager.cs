public class MixerSnapshotManager : SingletonComponent<MixerSnapshotManager>, IClientComponent // TypeDefIndex: 8997
{	public AudioMixerSnapshot defaultSnapshot; // 0x18
	public AudioMixerSnapshot underwaterSnapshot; // 0x20
	public AudioMixerSnapshot loadingSnapshot; // 0x28
	public AudioMixerSnapshot woundedSnapshot; // 0x30
	public AudioMixerSnapshot cctvSnapshot; // 0x38
	public SoundDefinition underwaterInSound; // 0x40
	public SoundDefinition underwaterOutSound; // 0x48
	public AudioMixerSnapshot recordingSnapshot; // 0x50
	public SoundDefinition woundedLoop; // 0x58
	private Sound woundedLoopSound; // 0x60
	public SoundDefinition cctvModeLoopDef; // 0x68
	private Sound cctvModeLoop; // 0x70
	public SoundDefinition cctvModeStartDef; // 0x78
	public SoundDefinition cctvModeStopDef; // 0x80
	public float deafness; // 0x88
	private bool cctvMode; // 0x8C
	internal AudioMixerSnapshot currentState; // 0x90


	protected override void Awake() { }

	private void Update() { }

	public void SetCCTVMode(bool enabled) { }

	private void DoWoundedLoop() { }

	private AudioMixerSnapshot GetTargetState(bool isUnderwater) { }

	public void .ctor() { }

}

