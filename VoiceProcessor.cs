public class VoiceProcessor : EntityComponentBase // TypeDefIndex: 11383
{
	public AudioSource mouthSpeaker; 
	public PlayerVoiceSpeaker playerSpeaker; 
	public float volumeMultiplier; 
	private uint optimalRate; 
	private uint bufferSize; 
	private float[] buffer; 
	private uint dataReceived; 
	private uint playbackBuffer; 
	private uint dataPosition; 
	private bool Initialized; 
	public float currentVolume; 
	private List<VoiceProcessor> subProcessors; 
	private bool isPlaying; 
	private bool stopping; 
	private float[] volumeData; 
	internal float volumeVelocity; 
	private static MemoryStream decompressStream; 


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

