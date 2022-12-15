public enum AudioSpeakerMode // TypeDefIndex: 4003
{

public enum AudioSpeakerMode
	public int value__;
	[ObsoleteAttribute]
	public const AudioSpeakerMode Raw = 0;
	public const AudioSpeakerMode Mono = 1;
	public const AudioSpeakerMode Stereo = 2;
	public const AudioSpeakerMode Quad = 3;
	public const AudioSpeakerMode Surround = 4;
	public const AudioSpeakerMode Mode5point1 = 5;
	public const AudioSpeakerMode Mode7point1 = 6;
	public const AudioSpeakerMode Prologic = 7;

}

public enum AudioDataLoadState // TypeDefIndex: 4004
{
	public int value__;
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;

}

public struct AudioConfiguration // TypeDefIndex: 4005
{
	public AudioSpeakerMode speakerMode;
	public int dspBufferSize;
	public int sampleRate;
	public int numRealVoices;
	public int numVirtualVoices;

}

public enum AudioSourceCurveType // TypeDefIndex: 4007
{
	public int value__;
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;

}

public enum AudioReverbPreset // TypeDefIndex: 4008
{
	public int value__;
	public const AudioReverbPreset Off = 0;
	public const AudioReverbPreset Generic = 1;
	public const AudioReverbPreset PaddedCell = 2;
	public const AudioReverbPreset Room = 3;
	public const AudioReverbPreset Bathroom = 4;
	public const AudioReverbPreset Livingroom = 5;
	public const AudioReverbPreset Stoneroom = 6;
	public const AudioReverbPreset Auditorium = 7;
	public const AudioReverbPreset Concerthall = 8;
	public const AudioReverbPreset Cave = 9;
	public const AudioReverbPreset Arena = 10;
	public const AudioReverbPreset Hangar = 11;
	public const AudioReverbPreset CarpetedHallway = 12;
	public const AudioReverbPreset Hallway = 13;
	public const AudioReverbPreset StoneCorridor = 14;
	public const AudioReverbPreset Alley = 15;
	public const AudioReverbPreset Forest = 16;
	public const AudioReverbPreset City = 17;
	public const AudioReverbPreset Mountains = 18;
	public const AudioReverbPreset Quarry = 19;
	public const AudioReverbPreset Plain = 20;
	public const AudioReverbPreset ParkingLot = 21;
	public const AudioReverbPreset SewerPipe = 22;
	public const AudioReverbPreset Underwater = 23;
	public const AudioReverbPreset Drugged = 24;
	public const AudioReverbPreset Dizzy = 25;
	public const AudioReverbPreset Psychotic = 26;
	public const AudioReverbPreset User = 27;

}

public sealed class AudioSettings // TypeDefIndex: 4009
{
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged;

	public static AudioSpeakerMode speakerMode { get; }
	public static double dspTime { get; }
	public static int outputSampleRate { get; }


	private static AudioSpeakerMode GetSpeakerMode() { }

	[NativeThrowsAttribute]
	[NativeMethodAttribute]
	private static bool SetConfiguration(AudioConfiguration config) { }

	[NativeMethodAttribute]
	private static int GetSampleRate() { }

	public static AudioSpeakerMode get_speakerMode() { }

	[NativeMethodAttribute]
	public static double get_dspTime() { }

	public static int get_outputSampleRate() { }

	[NativeMethodAttribute]
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	public static AudioConfiguration GetConfiguration() { }

	public static bool Reset(AudioConfiguration config) { }

	[RequiredByNativeCodeAttribute]
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

}

public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 4010
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(bool deviceWasChanged) { }

	public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip : Object // TypeDefIndex: 4011
{
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private AudioClip.PCMReaderCallback m_PCMReaderCallback;
	[CompilerGeneratedAttribute]
	[DebuggerBrowsableAttribute]
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback;

	[NativePropertyAttribute]
	public float length { get; }
	[NativePropertyAttribute]
	public int samples { get; }
	[NativePropertyAttribute]
	public int channels { get; }
	public int frequency { get; }
	public AudioDataLoadState loadState { get; }


	private void .ctor() { }

	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	private static AudioClip Construct_Internal() { }

	private string GetName() { }

	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	public float get_length() { }

	public int get_samples() { }

	public int get_channels() { }

	public int get_frequency() { }

	public bool LoadAudioData() { }

	public bool UnloadAudioData() { }

	[NativeMethodAttribute]
	public AudioDataLoadState get_loadState() { }

	public bool GetData(float[] data, int offsetSamples) { }

	public bool SetData(float[] data, int offsetSamples) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGeneratedAttribute]
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute]
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute]
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGeneratedAttribute]
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCodeAttribute]
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute]
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 4012
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(float[] data) { }

	public virtual IAsyncResult BeginInvoke(float[] data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 4013
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(int position) { }

	public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4016
{

[StaticAccessorAttribute]
[RequireComponent]
public sealed class AudioListener : AudioBehaviour

[RequireComponent]
[StaticAccessorAttribute]
public sealed class AudioSource : AudioBehaviour
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute]
	public float time { get; set; }
	[NativePropertyAttribute]
	public int timeSamples { get; set; }
	[NativePropertyAttribute]
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool loop { set; }
	public bool playOnAwake { set; }
	[NativePropertyAttribute]
	public float panStereo { get; set; }
	[NativePropertyAttribute]
	public float spatialBlend { set; }
	public float dopplerLevel { set; }
	public float spread { get; set; }
	public int priority { set; }
	public bool mute { set; }
	public float maxDistance { get; set; }


	private static float GetPitch(AudioSource source) { }

	private static void SetPitch(AudioSource source, float pitch) { }

	private static void PlayHelper(AudioSource source, ulong delay) { }

	private void Play(double delay) { }

	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute]
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute]
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	public float get_volume() { }

	public void set_volume(float value) { }

	public float get_pitch() { }

	public void set_pitch(float value) { }

	public float get_time() { }

	public void set_time(float value) { }

	[NativeMethodAttribute]
	public int get_timeSamples() { }

	[NativeMethodAttribute]
	public void set_timeSamples(int value) { }

	public AudioClip get_clip() { }

	public void set_clip(AudioClip value) { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute]
	public void Play() { }

	public void PlayDelayed(float delay) { }

	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute]
	public void PlayOneShot(AudioClip clip) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	public void Stop() { }

	public void Pause() { }

	public void UnPause() { }

	[NativeNameAttribute]
	public bool get_isPlaying() { }

	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	public void set_loop(bool value) { }

	public void set_playOnAwake(bool value) { }

	public float get_panStereo() { }

	public void set_panStereo(float value) { }

	public void set_spatialBlend(float value) { }

	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	public void set_dopplerLevel(float value) { }

	public float get_spread() { }

	public void set_spread(float value) { }

	public void set_priority(int value) { }

	public void set_mute(bool value) { }

	public float get_maxDistance() { }

	public void set_maxDistance(float value) { }

	public void GetOutputData(float[] samples, int channel) { }

	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

}

public sealed class AudioReverbZone : Behaviour // TypeDefIndex: 4017
{
	public float minDistance { get; set; }
	public float maxDistance { get; set; }
	public AudioReverbPreset reverbPreset { set; }
	public int room { get; set; }
	public int roomHF { get; set; }
	public int roomLF { get; set; }
	public float decayTime { get; set; }
	public float decayHFRatio { get; set; }
	public int reflections { get; set; }
	public float reflectionsDelay { get; set; }
	public int reverb { get; set; }
	public float reverbDelay { get; set; }
	public float HFReference { get; set; }
	public float LFReference { get; set; }
	public float diffusion { get; set; }
	public float density { get; set; }


	public float get_minDistance() { }

	public void set_minDistance(float value) { }

	public float get_maxDistance() { }

	public void set_maxDistance(float value) { }

	public void set_reverbPreset(AudioReverbPreset value) { }

	public int get_room() { }

	public void set_room(int value) { }

	public int get_roomHF() { }

	public void set_roomHF(int value) { }

	public int get_roomLF() { }

	public void set_roomLF(int value) { }

	public float get_decayTime() { }

	public void set_decayTime(float value) { }

	public float get_decayHFRatio() { }

	public void set_decayHFRatio(float value) { }

	public int get_reflections() { }

	public void set_reflections(int value) { }

	public float get_reflectionsDelay() { }

	public void set_reflectionsDelay(float value) { }

	public int get_reverb() { }

	public void set_reverb(int value) { }

	public float get_reverbDelay() { }

	public void set_reverbDelay(float value) { }

	public float get_HFReference() { }

	public void set_HFReference(float value) { }

	public float get_LFReference() { }

	public void set_LFReference(float value) { }

	public float get_diffusion() { }

	public void set_diffusion(float value) { }

	public float get_density() { }

	public void set_density(float value) { }

}

public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4019
{

[NativeHeaderAttribute]
[NativeHeaderAttribute]
[StaticAccessorAttribute]
[NativeHeaderAttribute]
[RequiredByNativeCodeAttribute]
public struct AudioClipPlayable : IEquatable<AudioClipPlayable>
	private PlayableHandle m_Handle;


	public PlayableHandle GetHandle() { }

	public bool Equals(AudioClipPlayable other) { }

}

public class AudioMixer : Object // TypeDefIndex: 4020
{

	internal void .ctor() { }

	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute]
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute]
	public bool SetFloat(string name, float value) { }

	[NativeMethodAttribute]
	public bool GetFloat(string name, out float value) { }

}

public class AudioMixerGroup : Object // TypeDefIndex: 4021
{

	internal void .ctor() { }

}

public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 4022
{
	private PlayableHandle m_Handle;


	public PlayableHandle GetHandle() { }

	public bool Equals(AudioMixerPlayable other) { }

}

public class AudioMixerSnapshot : Object // TypeDefIndex: 4023
{
	[NativePropertyAttribute]
	public AudioMixer audioMixer { get; }


	public AudioMixer get_audioMixer() { }

	public void TransitionTo(float timeToReach) { }

}

public struct AudioPlayableOutput // TypeDefIndex: 4024
{
	private PlayableOutputHandle m_Handle;

}

public class AudioSampleProvider // TypeDefIndex: 4025
{
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable;
	[DebuggerBrowsableAttribute]
	[CompilerGeneratedAttribute]
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow;


	[RequiredByNativeCodeAttribute]
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute]
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 4026
{

	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class AudioEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6427
{
	public bool ShouldPool;
	private bool _disposed;
	public int colourMode;
	public int volumeRange;
	public int speed;
	public int gradient;


	public static void ResetToPool(AudioEntity instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(AudioEntity instance) { }

	public AudioEntity Copy() { }

	public static AudioEntity Deserialize(Stream stream) { }

	public static AudioEntity DeserializeLengthDelimited(Stream stream) { }

	public static AudioEntity DeserializeLength(Stream stream, int length) { }

	public static AudioEntity Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, AudioEntity previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static AudioEntity Deserialize(byte[] buffer, AudioEntity instance, bool isDelta = False) { }

	public static AudioEntity Deserialize(Stream stream, AudioEntity instance, bool isDelta) { }

	public static AudioEntity DeserializeLengthDelimited(Stream stream, AudioEntity instance, bool isDelta) { }

	public static AudioEntity DeserializeLength(Stream stream, int length, AudioEntity instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, AudioEntity instance, AudioEntity previous) { }

	public static void Serialize(Stream stream, AudioEntity instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(AudioEntity instance) { }

	public static void SerializeLengthDelimited(Stream stream, AudioEntity instance) { }

	public void .ctor() { }

}

public struct AudioBeforeRenderCallbackInfo : ICallbackInfo // TypeDefIndex: 8656
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<AudioBuffer> <Buffer>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <ParticipantId>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }
	public ProductUserId ParticipantId { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Nullable<AudioBuffer> get_Buffer() { }

	[CompilerGeneratedAttribute]
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_ParticipantId() { }

	[CompilerGeneratedAttribute]
	public void set_ParticipantId(ProductUserId value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref AudioBeforeRenderCallbackInfoInternal other) { }

}

internal struct AudioBeforeRenderCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeRenderCallbackInfo>, ISettable<AudioBeforeRenderCallbackInfo>, IDisposable // TypeDefIndex: 8657
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private IntPtr m_Buffer;
	private IntPtr m_ParticipantId;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }
	public ProductUserId ParticipantId { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public Nullable<AudioBuffer> get_Buffer() { }

	public void set_Buffer(Nullable<AudioBuffer> value) { }

	public ProductUserId get_ParticipantId() { }

	public void set_ParticipantId(ProductUserId value) { }

	public void Set(ref AudioBeforeRenderCallbackInfo other) { }

	public void Set(ref Nullable<AudioBeforeRenderCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioBeforeRenderCallbackInfo output) { }

}

public struct AudioBeforeSendCallbackInfo : ICallbackInfo // TypeDefIndex: 8658
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private Nullable<AudioBuffer> <Buffer>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Nullable<AudioBuffer> get_Buffer() { }

	[CompilerGeneratedAttribute]
	public void set_Buffer(Nullable<AudioBuffer> value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref AudioBeforeSendCallbackInfoInternal other) { }

}

internal struct AudioBeforeSendCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioBeforeSendCallbackInfo>, ISettable<AudioBeforeSendCallbackInfo>, IDisposable // TypeDefIndex: 8659
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private IntPtr m_Buffer;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public Nullable<AudioBuffer> Buffer { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public Nullable<AudioBuffer> get_Buffer() { }

	public void set_Buffer(Nullable<AudioBuffer> value) { }

	public void Set(ref AudioBeforeSendCallbackInfo other) { }

	public void Set(ref Nullable<AudioBeforeSendCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioBeforeSendCallbackInfo output) { }

}

public struct AudioBuffer // TypeDefIndex: 8660
{
	[CompilerGeneratedAttribute]
	private short[] <Frames>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <SampleRate>k__BackingField;
	[CompilerGeneratedAttribute]
	private uint <Channels>k__BackingField;

	public short[] Frames { get; set; }
	public uint SampleRate { get; set; }
	public uint Channels { get; set; }


	[CompilerGeneratedAttribute]
	public short[] get_Frames() { }

	[CompilerGeneratedAttribute]
	public void set_Frames(short[] value) { }

	[CompilerGeneratedAttribute]
	public uint get_SampleRate() { }

	[CompilerGeneratedAttribute]
	public void set_SampleRate(uint value) { }

	[CompilerGeneratedAttribute]
	public uint get_Channels() { }

	[CompilerGeneratedAttribute]
	public void set_Channels(uint value) { }

	internal void Set(ref AudioBufferInternal other) { }

}

internal struct AudioBufferInternal : IGettable<AudioBuffer>, ISettable<AudioBuffer>, IDisposable // TypeDefIndex: 8661
{
	private int m_ApiVersion;
	private IntPtr m_Frames;
	private uint m_FramesCount;
	private uint m_SampleRate;
	private uint m_Channels;

	public short[] Frames { get; set; }
	public uint SampleRate { get; set; }
	public uint Channels { get; set; }


	public short[] get_Frames() { }

	public void set_Frames(short[] value) { }

	public uint get_SampleRate() { }

	public void set_SampleRate(uint value) { }

	public uint get_Channels() { }

	public void set_Channels(uint value) { }

	public void Set(ref AudioBuffer other) { }

	public void Set(ref Nullable<AudioBuffer> other) { }

	public void Dispose() { }

	public void Get(out AudioBuffer output) { }

}

public struct AudioDevicesChangedCallbackInfo : ICallbackInfo // TypeDefIndex: 8662
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;

	public object ClientData { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref AudioDevicesChangedCallbackInfoInternal other) { }

}

internal struct AudioDevicesChangedCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioDevicesChangedCallbackInfo>, ISettable<AudioDevicesChangedCallbackInfo>, IDisposable // TypeDefIndex: 8663
{
	private IntPtr m_ClientData;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public void Set(ref AudioDevicesChangedCallbackInfo other) { }

	public void Set(ref Nullable<AudioDevicesChangedCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioDevicesChangedCallbackInfo output) { }

}

public struct AudioInputDeviceInfo // TypeDefIndex: 8664
{
	[CompilerGeneratedAttribute]
	private bool <DefaultDevice>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <DeviceId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <DeviceName>k__BackingField;

	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }


	[CompilerGeneratedAttribute]
	public bool get_DefaultDevice() { }

	[CompilerGeneratedAttribute]
	public void set_DefaultDevice(bool value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_DeviceId() { }

	[CompilerGeneratedAttribute]
	public void set_DeviceId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_DeviceName() { }

	[CompilerGeneratedAttribute]
	public void set_DeviceName(Utf8String value) { }

	internal void Set(ref AudioInputDeviceInfoInternal other) { }

}

internal struct AudioInputDeviceInfoInternal : IGettable<AudioInputDeviceInfo>, ISettable<AudioInputDeviceInfo>, IDisposable // TypeDefIndex: 8665
{
	private int m_ApiVersion;
	private int m_DefaultDevice;
	private IntPtr m_DeviceId;
	private IntPtr m_DeviceName;

	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }


	public bool get_DefaultDevice() { }

	public void set_DefaultDevice(bool value) { }

	public Utf8String get_DeviceId() { }

	public void set_DeviceId(Utf8String value) { }

	public Utf8String get_DeviceName() { }

	public void set_DeviceName(Utf8String value) { }

	public void Set(ref AudioInputDeviceInfo other) { }

	public void Set(ref Nullable<AudioInputDeviceInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioInputDeviceInfo output) { }

}

public struct AudioInputStateCallbackInfo : ICallbackInfo // TypeDefIndex: 8666
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private RTCAudioInputStatus <Status>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioInputStatus Status { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public RTCAudioInputStatus get_Status() { }

	[CompilerGeneratedAttribute]
	public void set_Status(RTCAudioInputStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref AudioInputStateCallbackInfoInternal other) { }

}

internal struct AudioInputStateCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioInputStateCallbackInfo>, ISettable<AudioInputStateCallbackInfo>, IDisposable // TypeDefIndex: 8667
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private RTCAudioInputStatus m_Status;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioInputStatus Status { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public RTCAudioInputStatus get_Status() { }

	public void set_Status(RTCAudioInputStatus value) { }

	public void Set(ref AudioInputStateCallbackInfo other) { }

	public void Set(ref Nullable<AudioInputStateCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioInputStateCallbackInfo output) { }

}

public struct AudioOutputDeviceInfo // TypeDefIndex: 8668
{
	[CompilerGeneratedAttribute]
	private bool <DefaultDevice>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <DeviceId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <DeviceName>k__BackingField;

	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }


	[CompilerGeneratedAttribute]
	public bool get_DefaultDevice() { }

	[CompilerGeneratedAttribute]
	public void set_DefaultDevice(bool value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_DeviceId() { }

	[CompilerGeneratedAttribute]
	public void set_DeviceId(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_DeviceName() { }

	[CompilerGeneratedAttribute]
	public void set_DeviceName(Utf8String value) { }

	internal void Set(ref AudioOutputDeviceInfoInternal other) { }

}

internal struct AudioOutputDeviceInfoInternal : IGettable<AudioOutputDeviceInfo>, ISettable<AudioOutputDeviceInfo>, IDisposable // TypeDefIndex: 8669
{
	private int m_ApiVersion;
	private int m_DefaultDevice;
	private IntPtr m_DeviceId;
	private IntPtr m_DeviceName;

	public bool DefaultDevice { get; set; }
	public Utf8String DeviceId { get; set; }
	public Utf8String DeviceName { get; set; }


	public bool get_DefaultDevice() { }

	public void set_DefaultDevice(bool value) { }

	public Utf8String get_DeviceId() { }

	public void set_DeviceId(Utf8String value) { }

	public Utf8String get_DeviceName() { }

	public void set_DeviceName(Utf8String value) { }

	public void Set(ref AudioOutputDeviceInfo other) { }

	public void Set(ref Nullable<AudioOutputDeviceInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioOutputDeviceInfo output) { }

}

public struct AudioOutputStateCallbackInfo : ICallbackInfo // TypeDefIndex: 8670
{
	[CompilerGeneratedAttribute]
	private object <ClientData>k__BackingField;
	[CompilerGeneratedAttribute]
	private ProductUserId <LocalUserId>k__BackingField;
	[CompilerGeneratedAttribute]
	private Utf8String <RoomName>k__BackingField;
	[CompilerGeneratedAttribute]
	private RTCAudioOutputStatus <Status>k__BackingField;

	public object ClientData { get; set; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioOutputStatus Status { get; set; }


	[CompilerGeneratedAttribute]
	public object get_ClientData() { }

	[CompilerGeneratedAttribute]
	public void set_ClientData(object value) { }

	[CompilerGeneratedAttribute]
	public ProductUserId get_LocalUserId() { }

	[CompilerGeneratedAttribute]
	public void set_LocalUserId(ProductUserId value) { }

	[CompilerGeneratedAttribute]
	public Utf8String get_RoomName() { }

	[CompilerGeneratedAttribute]
	public void set_RoomName(Utf8String value) { }

	[CompilerGeneratedAttribute]
	public RTCAudioOutputStatus get_Status() { }

	[CompilerGeneratedAttribute]
	public void set_Status(RTCAudioOutputStatus value) { }

	public Nullable<Result> GetResultCode() { }

	internal void Set(ref AudioOutputStateCallbackInfoInternal other) { }

}

internal struct AudioOutputStateCallbackInfoInternal : ICallbackInfoInternal, IGettable<AudioOutputStateCallbackInfo>, ISettable<AudioOutputStateCallbackInfo>, IDisposable // TypeDefIndex: 8671
{
	private IntPtr m_ClientData;
	private IntPtr m_LocalUserId;
	private IntPtr m_RoomName;
	private RTCAudioOutputStatus m_Status;

	public object ClientData { get; set; }
	public IntPtr ClientDataAddress { get; }
	public ProductUserId LocalUserId { get; set; }
	public Utf8String RoomName { get; set; }
	public RTCAudioOutputStatus Status { get; set; }


	public object get_ClientData() { }

	public void set_ClientData(object value) { }

	public IntPtr get_ClientDataAddress() { }

	public ProductUserId get_LocalUserId() { }

	public void set_LocalUserId(ProductUserId value) { }

	public Utf8String get_RoomName() { }

	public void set_RoomName(Utf8String value) { }

	public RTCAudioOutputStatus get_Status() { }

	public void set_Status(RTCAudioOutputStatus value) { }

	public void Set(ref AudioOutputStateCallbackInfo other) { }

	public void Set(ref Nullable<AudioOutputStateCallbackInfo> other) { }

	public void Dispose() { }

	public void Get(out AudioOutputStateCallbackInfo output) { }

}

public class AudioVisualisationEntity : IOEntity // TypeDefIndex: 10025
{
	private Option __menuOption_ChangeLightSettings;
	private EntityRef<BaseEntity> connectedTo;
	[CompilerGeneratedAttribute]
	private AudioVisualisationEntity.LightColour <currentColour>k__BackingField;
	[CompilerGeneratedAttribute]
	private AudioVisualisationEntity.VolumeSensitivity <currentVolumeSensitivity>k__BackingField;
	[CompilerGeneratedAttribute]
	private AudioVisualisationEntity.Speed <currentSpeed>k__BackingField;
	public GameObjectRef SettingsDialog;
	[CompilerGeneratedAttribute]
	private int <currentGradient>k__BackingField;
	private IAudioConnectionSource currentSource;
	private static float[] bands;
	private float roughPeak;

	public override bool HasMenuOptions { get; }
	public AudioVisualisationEntity.LightColour currentColour { get; set; }
	public AudioVisualisationEntity.VolumeSensitivity currentVolumeSensitivity { get; set; }
	public AudioVisualisationEntity.Speed currentSpeed { get; set; }
	public int currentGradient { get; set; }
	public virtual bool ShowColourOption { get; }
	public virtual bool ShowVolumeOption { get; }
	public virtual bool ShowSpeedOption { get; }
	public virtual bool ShowPatternOption { get; }
	public virtual bool ShowGradientOption { get; }
	protected bool HasAudioSource { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute]
	public AudioVisualisationEntity.LightColour get_currentColour() { }

	[CompilerGeneratedAttribute]
	private void set_currentColour(AudioVisualisationEntity.LightColour value) { }

	[CompilerGeneratedAttribute]
	public AudioVisualisationEntity.VolumeSensitivity get_currentVolumeSensitivity() { }

	[CompilerGeneratedAttribute]
	private void set_currentVolumeSensitivity(AudioVisualisationEntity.VolumeSensitivity value) { }

	[CompilerGeneratedAttribute]
	public AudioVisualisationEntity.Speed get_currentSpeed() { }

	[CompilerGeneratedAttribute]
	private void set_currentSpeed(AudioVisualisationEntity.Speed value) { }

	[CompilerGeneratedAttribute]
	public int get_currentGradient() { }

	[CompilerGeneratedAttribute]
	private void set_currentGradient(int value) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void UpdateInvoke() { }

	public override void ResetState() { }

	protected virtual void UpdateVisualisation(float volume, bool force = False) { }

	[BaseEntity.RPC_Client]
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	public virtual bool get_ShowColourOption() { }

	public virtual bool get_ShowVolumeOption() { }

	public virtual bool get_ShowSpeedOption() { }

	public virtual bool get_ShowPatternOption() { }

	public virtual bool get_ShowGradientOption() { }

	protected bool get_HasAudioSource() { }

	protected virtual void UpdateVisualSettings() { }

	[BaseEntity.Menu]
	[BaseEntity.Menu.Description]
	[BaseEntity.Menu.ShowIf]
	[BaseEntity.Menu.Icon]
	public void ChangeLightSettings(BasePlayer player) { }

	public void SendNewLightSettings(int newColour, int newVolumeRange, int newSpeed, int newGradient) { }

	private bool CanChangeLightSettings(BasePlayer player) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum AudioVisualisationEntity.LightColour // TypeDefIndex: 10026
{
	public int value__;
	public const AudioVisualisationEntity.LightColour Red = 0;
	public const AudioVisualisationEntity.LightColour Green = 1;
	public const AudioVisualisationEntity.LightColour Blue = 2;
	public const AudioVisualisationEntity.LightColour Yellow = 3;
	public const AudioVisualisationEntity.LightColour Pink = 4;

}

public enum AudioVisualisationEntity.VolumeSensitivity // TypeDefIndex: 10027
{
	public int value__;
	public const AudioVisualisationEntity.VolumeSensitivity Small = 0;
	public const AudioVisualisationEntity.VolumeSensitivity Medium = 1;
	public const AudioVisualisationEntity.VolumeSensitivity Large = 2;

}

public enum AudioVisualisationEntity.Speed // TypeDefIndex: 10028
{
	public int value__;
	public const AudioVisualisationEntity.Speed Low = 0;
	public const AudioVisualisationEntity.Speed Medium = 1;
	public const AudioVisualisationEntity.Speed High = 2;

}

public class AudioAlarm : IOEntity // TypeDefIndex: 10428
{

	public void .ctor() { }

}

public class AudioSettings : MonoBehaviour // TypeDefIndex: 10864
{
	public AudioMixer mixer;


	private void Update() { }

	private float LinearToDecibel(float linear) { }

	public void .ctor() { }

}

public class AudioVisualisationEntityLight : AudioVisualisationEntity // TypeDefIndex: 11185
{
	public Light TargetLight;
	public Light SecondaryLight;
	public MeshRenderer[] TargetRenderer;
	public AudioVisualisationEntityLight.LightColourSet RedColour;
	public AudioVisualisationEntityLight.LightColourSet GreenColour;
	public AudioVisualisationEntityLight.LightColourSet BlueColour;
	public AudioVisualisationEntityLight.LightColourSet YellowColour;
	public AudioVisualisationEntityLight.LightColourSet PinkColour;
	public float lightMinIntensity;
	public float lightMaxIntensity;
	private static MaterialPropertyBlock block;
	private static int emissionColourId;
	private float lastVolume;

	public override bool ShowColourOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }


	protected override void ClientInit(Entity info) { }

	protected override void UpdateVisualisation(float volume, bool force = False) { }

	private float GetCurrentSpeedValue() { }

	private void GetCurrentVolumeRange(out float min, out float max) { }

	private void UpdateLightComponentSettings() { }

	private AudioVisualisationEntityLight.LightColourSet EnumToColour(AudioVisualisationEntity.LightColour colour) { }

	private void UpdateRenderer(float volumeNormalised) { }

	protected override void UpdateVisualSettings() { }

	public override bool get_ShowColourOption() { }

	public override bool get_ShowSpeedOption() { }

	public override bool get_ShowVolumeOption() { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public struct AudioVisualisationEntityLight.LightColourSet // TypeDefIndex: 11186
{
	[ColorUsageAttribute]
	public Color LightColor;
	[ColorUsageAttribute]
	public Color SecondaryLightColour;
	[ColorUsageAttribute]
	public Color EmissionColour;

}

public class AudioInterceptComponent : MonoBehaviour // TypeDefIndex: 11206
{
	public OggEncoder Encoder;
	private float[] strippedData;
	[ClientVar]
	public static bool debugChannels;


	private void OnAudioFilterRead(float[] data, int channels) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Audio : ConsoleSystem // TypeDefIndex: 13698
{
	[ClientVar]
	public static float master;
	[ClientVar]
	public static float musicvolume;
	[ClientVar]
	public static float musicvolumemenu;
	[ClientVar]
	public static float game;
	[ClientVar]
	public static float voices;
	[ClientVar]
	public static float instruments;
	[ClientVar]
	public static float voiceProps;
	[ClientVar]
	public static float eventAudio;
	[ClientVar]
	public static bool ambience;
	[ClientVar]
	public static float framebudget;
	[ClientVar]
	public static float minupdatefraction;
	[ClientVar]
	public static bool advancedocclusion;
	[ClientVar]
	public static bool hqsoundfade;
	[ClientVar]
	public static bool debugVoiceLimiting;

	[ClientVar]
	public static int speakers { get; set; }


	public static int get_speakers() { }

	public static void set_speakers(int value) { }

	[ClientVar]
	public static void printSounds(ConsoleSystem.Arg arg) { }

	[ClientVar]
	public static void printEngineSounds(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

