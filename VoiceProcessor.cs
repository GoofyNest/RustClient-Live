public class VoiceProcessor : EntityComponentBase // TypeDefIndex: 9663
{	public AudioSource mouthSpeaker; // 0x18
	public PlayerVoiceSpeaker playerSpeaker; // 0x20
	public float volumeMultiplier; // 0x28
	private uint optimalRate; // 0x2C
	private uint bufferSize; // 0x30
	private float[] buffer; // 0x38
	private uint dataReceived; // 0x40
	private uint playbackBuffer; // 0x44
	private uint dataPosition; // 0x48
	private bool Initialized; // 0x4C
	public float currentVolume; // 0x50
	private List<VoiceProcessor> subProcessors; // 0x58
	private bool isPlaying; // 0x60
	private bool stopping; // 0x61
	private float[] volumeData; // 0x68
	internal float volumeVelocity; // 0x70
	private static MemoryStream decompressStream; // 0x0


	private void InitializeSpeaker() { }

	public void ClientUpdate() { }

	private void OnDisable() { }

	public void StopPlayback() { }

	private void StartPlaying() { }

	private bool ShouldMute() { }

	private void OnAudioRead(float[] data) { }

	public void Receive(byte[] data) { }

	private void WriteToClip(byte[] uncompressed, int iSize) { }

	public void RegisterSubProcessor(VoiceProcessor processor) { }

	public void DeregisterSubProcessor(VoiceProcessor processor) { }

	public void ReceiveDataFromOtherProcessor(byte[] data, int size, VoiceProcessor fromProcessor) { }

	private void WriteToClip(float f) { }

	public void .ctor() { }

	private static void .cctor() { }

}

