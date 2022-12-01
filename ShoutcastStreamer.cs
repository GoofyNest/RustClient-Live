public class ShoutcastStreamer : MonoBehaviour, IClientComponent // TypeDefIndex: 10750
{
	public string Host;
	public AudioSource Source;
	[ClientVar]
	public static int MaxAudioStreams;
	[ClientVar]
	public static bool DebugStreams;
	[ClientVar]
	public static bool StreamingAnalytics;
	private static bool _allowInternetStreams;
	private static HashSet<ShoutcastStreamer> activeStreams;
	public RadioPlaylist[] BuiltinRadios;
	public ShoutcastStream Stream;
	private bool _readingData;
	private AudioClip streamClip;
	private int sampleRate;
	[CompilerGeneratedAttribute]
	private uint <CurrentReadIndex>k__BackingField;
	private const uint BufferStartCutOff = 81920;
	private bool canUpdate;
	private bool wantsShutdown;
	private RadioPlaylist currentPlaylist;
	private TimeUntil nextStatLog;
	private const float StatLogInterval = 60;
	private bool waitAudio;
	private float waitUntilBuffer;

	[ClientVar]
	public static bool AllowInternetStreams { get; set; }
	public static int ActiveStreamCount { get; }
	public uint CurrentReadIndex { get; set; }
	public bool IsConnected { get; }
	public bool IsPlayingBuiltinAudio { get; }
	private uint BufferedData { get; }
	private float BufferedPercentage { get; }


	public static bool get_AllowInternetStreams() { }

	public static void set_AllowInternetStreams(bool value) { }

	public static int get_ActiveStreamCount() { }

	[CompilerGeneratedAttribute]
	public uint get_CurrentReadIndex() { }

	[CompilerGeneratedAttribute]
	public void set_CurrentReadIndex(uint value) { }

	public bool get_IsConnected() { }

	public bool get_IsPlayingBuiltinAudio() { }

	public void Connect(string host, bool localPlayer = False) { }

	private RadioPlaylist GetPlaylistforUrl(string url) { }

	private void PlayPlaylist() { }

	public void OnStreamsAllowedToggled(bool allowed) { }

	public void Disconnect(bool playSafeAfterDisconnect = False) { }

	private void OnAudioRead(float[] data) { }

	public static int ProcessStreamData(float[] data, float[] floatSamples, ref uint readIndex, uint writeIndex) { }

	protected void Update() { }

	public void ResetSample(uint read) { }

	private uint get_BufferedData() { }

	private float get_BufferedPercentage() { }

	[AsyncStateMachineAttribute]
	private void ReadData() { }

	private void OnDisable() { }

	public void .ctor() { }

	private static void .cctor() { }

}

private struct ShoutcastStreamer.<ReadData>d__46 : IAsyncStateMachine // TypeDefIndex: 10751
{
	public int <>1__state;
	public AsyncVoidMethodBuilder <>t__builder;
	public ShoutcastStreamer <>4__this;
	private TaskAwaiter<bool> <>u__1;


	private void MoveNext() { }

	[DebuggerHiddenAttribute]
	private void SetStateMachine(IAsyncStateMachine stateMachine) { }

}

