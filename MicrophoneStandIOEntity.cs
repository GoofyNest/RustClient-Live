public class MicrophoneStandIOEntity : IOEntity, IAudioConnectionSource // TypeDefIndex: 9448
{	// Fields
	public int PowerCost; // 0x288
	public TriggerBase InstrumentTrigger; // 0x290
	public bool IsStatic; // 0x298
	private List<InstrumentKeyController> nearbyInstruments; // 0x2A0
	private Dictionary<InstrumentKeyController, List<Sound>> activeSounds; // 0x2A8
	private List<ConnectedSpeaker> connectedRepeaters; // 0x2B0
	private TimeSince lastNote; // 0x2B8
	private float fakeInput; // 0x2BC
	private int lastFrameMove; // 0x2C0

	// Properties
	public float VolumeVisualisationMultiplier { get; }

	// Methods

	// RVA: 0x9665B0 Offset: 0x9659B0 VA: 0x1809665B0 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x966690 Offset: 0x965A90 VA: 0x180966690
	private void FindNearbyInstruments() { }

	// RVA: 0x966DF0 Offset: 0x9661F0 VA: 0x180966DF0
	public void PlayNote(InstrumentKeyController key, SoundDefinition def, float velocity, NoteBindingCollection collection) { }

	// RVA: 0x9671C0 Offset: 0x9665C0 VA: 0x1809671C0
	public void StopNote(InstrumentKeyController key, float fadeOutTime = 0,1) { }

	// RVA: 0x967080 Offset: 0x966480 VA: 0x180967080 Slot: 159
	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	// RVA: 0x967160 Offset: 0x966560 VA: 0x180967160 Slot: 160
	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	// RVA: 0x966D50 Offset: 0x966150 VA: 0x180966D50 Slot: 161
	public AudioSource GetSource() { }

	// RVA: 0x550110 Offset: 0x54F510 VA: 0x180550110 Slot: 162
	public float get_VolumeVisualisationMultiplier() { }

	// RVA: 0x966C50 Offset: 0x966050 VA: 0x180966C50 Slot: 163
	public float GetFakeInput() { }

	// RVA: 0x966B10 Offset: 0x965F10 VA: 0x180966B10
	private int GetActiveSoundsCount() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 164
	public IOEntity ToEntity() { }

	// RVA: 0x967380 Offset: 0x966780 VA: 0x180967380
	public void .ctor() { }

}

