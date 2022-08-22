public class MicrophoneStandIOEntity : IOEntity, IAudioConnectionSource // TypeDefIndex: 9448
{	public int PowerCost; // 0x288
	public TriggerBase InstrumentTrigger; // 0x290
	public bool IsStatic; // 0x298
	private List<InstrumentKeyController> nearbyInstruments; // 0x2A0
	private Dictionary<InstrumentKeyController, List<Sound>> activeSounds; // 0x2A8
	private List<ConnectedSpeaker> connectedRepeaters; // 0x2B0
	private TimeSince lastNote; // 0x2B8
	private float fakeInput; // 0x2BC
	private int lastFrameMove; // 0x2C0

	public float VolumeVisualisationMultiplier { get; }


	protected override void ClientInit(Entity info) { }

	private void FindNearbyInstruments() { }

	public void PlayNote(InstrumentKeyController key, SoundDefinition def, float velocity, NoteBindingCollection collection) { }

	public void StopNote(InstrumentKeyController key, float fadeOutTime = 0,1) { }

	public void SpeakerConnected(ConnectedSpeaker speaker) { }

	public void SpeakerDisconnected(ConnectedSpeaker repeater) { }

	public AudioSource GetSource() { }

	public float get_VolumeVisualisationMultiplier() { }

	public float GetFakeInput() { }

	private int GetActiveSoundsCount() { }

	public IOEntity ToEntity() { }

	public void .ctor() { }

}

