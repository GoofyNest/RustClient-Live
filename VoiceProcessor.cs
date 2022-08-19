public class VoiceProcessor : EntityComponentBase // TypeDefIndex: 9663
{	// Fields
	public AudioSource mouthSpeaker; // 0x18
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

	// Methods

	// RVA: 0x7E16C0 Offset: 0x7E0AC0 VA: 0x1807E16C0
	private void InitializeSpeaker() { }

	// RVA: 0x7E1390 Offset: 0x7E0790 VA: 0x1807E1390
	public void ClientUpdate() { }

	// RVA: 0x7E1940 Offset: 0x7E0D40 VA: 0x1807E1940
	private void OnDisable() { }

	// RVA: 0x7E1ED0 Offset: 0x7E12D0 VA: 0x1807E1ED0
	public void StopPlayback() { }

	// RVA: 0x7E1DF0 Offset: 0x7E11F0 VA: 0x1807E1DF0
	private void StartPlaying() { }

	// RVA: 0x7E1D60 Offset: 0x7E1160 VA: 0x1807E1D60
	private bool ShouldMute() { }

	// RVA: 0x7E1870 Offset: 0x7E0C70 VA: 0x1807E1870
	private void OnAudioRead(float[] data) { }

	// RVA: 0x7E1AB0 Offset: 0x7E0EB0 VA: 0x1807E1AB0
	public void Receive(byte[] data) { }

	// RVA: 0x7E1F60 Offset: 0x7E1360 VA: 0x1807E1F60
	private void WriteToClip(byte[] uncompressed, int iSize) { }

	// RVA: 0x7E1CF0 Offset: 0x7E10F0 VA: 0x1807E1CF0
	public void RegisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x7E1650 Offset: 0x7E0A50 VA: 0x1807E1650
	public void DeregisterSubProcessor(VoiceProcessor processor) { }

	// RVA: 0x7E1A20 Offset: 0x7E0E20 VA: 0x1807E1A20
	public void ReceiveDataFromOtherProcessor(byte[] data, int size, VoiceProcessor fromProcessor) { }

	// RVA: 0x7E21D0 Offset: 0x7E15D0 VA: 0x1807E21D0
	private void WriteToClip(float f) { }

	// RVA: 0x7E2280 Offset: 0x7E1680 VA: 0x1807E2280
	public void .ctor() { }

	// RVA: 0x7E2220 Offset: 0x7E1620 VA: 0x1807E2220
	private static void .cctor() { }

}

