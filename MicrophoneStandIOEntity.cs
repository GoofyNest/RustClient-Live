public class MicrophoneStandIOEntity : IOEntity, IAudioConnectionSource // TypeDefIndex: 11190
{
	public int PowerCost;
	public TriggerBase InstrumentTrigger;
	public bool IsStatic;
	private List<InstrumentKeyController> nearbyInstruments;
	private Dictionary<InstrumentKeyController, List<Sound>> activeSounds;
	private List<ConnectedSpeaker> connectedRepeaters;
	private TimeSince lastNote;
	private float fakeInput;
	private int lastFrameMove;

	public float VolumeVisualisationMultiplier { get; }


	protected override void ClientInit(Entity info) { }

	private void FindNearbyInstruments() { }

	public void PlayNote(InstrumentKeyController key, SoundDefinition def, float velocity, NoteBindingCollection collection, float pitchOffset) { }

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

