public class ShoutcastStreamer : MonoBehaviour, IClientComponent // TypeDefIndex: 9019
{	// Fields
	public string Host; // 0x18
	public AudioSource Source; // 0x20
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static int MaxAudioStreams; // 0x0
	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static bool DebugStreams; // 0x4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool StreamingAnalytics; // 0x5
	private static bool _allowInternetStreams; // 0x6
	private static HashSet<ShoutcastStreamer> activeStreams; // 0x8
	public RadioPlaylist[] BuiltinRadios; // 0x28
	public ShoutcastStream Stream; // 0x30
	private bool _readingData; // 0x38
	private AudioClip streamClip; // 0x40
	private int sampleRate; // 0x48
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private uint <CurrentReadIndex>k__BackingField; // 0x4C
	private const uint BufferStartCutOff = 81920;
	private bool canUpdate; // 0x50
	private bool wantsShutdown; // 0x51
	private RadioPlaylist currentPlaylist; // 0x58
	private TimeUntil nextStatLog; // 0x60
	private const float StatLogInterval = 60;
	private bool waitAudio; // 0x64
	private float waitUntilBuffer; // 0x68

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool AllowInternetStreams { get; set; }
	public static int ActiveStreamCount { get; }
	public uint CurrentReadIndex { get; set; }
	public bool IsConnected { get; }
	public bool IsPlayingBuiltinAudio { get; }
	private uint BufferedData { get; }
	private float BufferedPercentage { get; }

	// Methods

	// RVA: 0x5B34E0 Offset: 0x5B28E0 VA: 0x1805B34E0
	public static bool get_AllowInternetStreams() { }

	// RVA: 0x5B3630 Offset: 0x5B2A30 VA: 0x1805B3630
	public static void set_AllowInternetStreams(bool value) { }

	// RVA: 0x5B3470 Offset: 0x5B2870 VA: 0x1805B3470
	public static int get_ActiveStreamCount() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B35A0 Offset: 0x5B29A0 VA: 0x1805B35A0
	public uint get_CurrentReadIndex() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5B3950 Offset: 0x5B2D50 VA: 0x1805B3950
	public void set_CurrentReadIndex(uint value) { }

	// RVA: 0x5B35B0 Offset: 0x5B29B0 VA: 0x1805B35B0
	public bool get_IsConnected() { }

	// RVA: 0x5B35D0 Offset: 0x5B29D0 VA: 0x1805B35D0
	public bool get_IsPlayingBuiltinAudio() { }

	// RVA: 0x5B1CA0 Offset: 0x5B10A0 VA: 0x1805B1CA0
	public void Connect(string host, bool localPlayer = False) { }

	// RVA: 0x5B2580 Offset: 0x5B1980 VA: 0x1805B2580
	private RadioPlaylist GetPlaylistforUrl(string url) { }

	// RVA: 0x5B2980 Offset: 0x5B1D80 VA: 0x1805B2980
	private void PlayPlaylist() { }

	// RVA: 0x5B2880 Offset: 0x5B1C80 VA: 0x1805B2880
	public void OnStreamsAllowedToggled(bool allowed) { }

	// RVA: 0x5B2280 Offset: 0x5B1680 VA: 0x1805B2280
	public void Disconnect(bool playSafeAfterDisconnect = False) { }

	// RVA: 0x5B2610 Offset: 0x5B1A10 VA: 0x1805B2610
	private void OnAudioRead(float[] data) { }

	// RVA: 0x5B2AE0 Offset: 0x5B1EE0 VA: 0x1805B2AE0
	public static int ProcessStreamData(float[] data, float[] floatSamples, ref uint readIndex, uint writeIndex) { }

	// RVA: 0x5B2D70 Offset: 0x5B2170 VA: 0x1805B2D70
	protected void Update() { }

	// RVA: 0x5B2D10 Offset: 0x5B2110 VA: 0x1805B2D10
	public void ResetSample(uint read) { }

	// RVA: 0x5B3540 Offset: 0x5B2940 VA: 0x1805B3540
	private uint get_BufferedData() { }

	// RVA: 0x5B3560 Offset: 0x5B2960 VA: 0x1805B3560
	private float get_BufferedPercentage() { }

	[AsyncStateMachineAttribute] // RVA: 0xCBE60 Offset: 0xCB260 VA: 0x1800CBE60
	// RVA: 0x5B2C40 Offset: 0x5B2040 VA: 0x1805B2C40
	private void ReadData() { }

	// RVA: 0x5B2870 Offset: 0x5B1C70 VA: 0x1805B2870
	private void OnDisable() { }

	// RVA: 0x5B3420 Offset: 0x5B2820 VA: 0x1805B3420
	public void .ctor() { }

	// RVA: 0x5B3370 Offset: 0x5B2770 VA: 0x1805B3370
	private static void .cctor() { }

}

private struct ShoutcastStreamer.<ReadData>d__46 : IAsyncStateMachine // TypeDefIndex: 9020
{	// Fields
	public int <>1__state; // 0x0
	public AsyncVoidMethodBuilder <>t__builder; // 0x8
	public ShoutcastStreamer <>4__this; // 0x28
	private TaskAwaiter<bool> <>u__1; // 0x30

	// Methods

	// RVA: 0xF3530 Offset: 0xF2930 VA: 0x1800F3530 Slot: 4
	private void MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0xF1420 Offset: 0xF0820 VA: 0x1800F1420 Slot: 5
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

