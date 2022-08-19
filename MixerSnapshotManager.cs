public class MixerSnapshotManager : SingletonComponent<MixerSnapshotManager>, IClientComponent // TypeDefIndex: 8997
{	// Fields
	public AudioMixerSnapshot defaultSnapshot; // 0x18
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

	// Methods

	// RVA: 0x768B00 Offset: 0x767F00 VA: 0x180768B00 Slot: 6
	protected override void Awake() { }

	// RVA: 0x769040 Offset: 0x768440 VA: 0x180769040
	private void Update() { }

	// RVA: 0x769030 Offset: 0x768430 VA: 0x180769030
	public void SetCCTVMode(bool enabled) { }

	// RVA: 0x768BC0 Offset: 0x767FC0 VA: 0x180768BC0
	private void DoWoundedLoop() { }

	// RVA: 0x768DD0 Offset: 0x7681D0 VA: 0x180768DD0
	private AudioMixerSnapshot GetTargetState(bool isUnderwater) { }

	// RVA: 0x769700 Offset: 0x768B00 VA: 0x180769700
	public void .ctor() { }

}

