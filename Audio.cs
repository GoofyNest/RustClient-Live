public enum AudioSpeakerMode // TypeDefIndex: 3998
{
public enum AudioSpeakerMode // TypeDefIndex: 3998
	public int value__; // 0x0
	[ObsoleteAttribute] // RVA: 0xB3930 Offset: 0xB2D30 VA: 0x1800B3930
	public const AudioSpeakerMode Raw = 0;
	public const AudioSpeakerMode Mono = 1;
	public const AudioSpeakerMode Stereo = 2;
	public const AudioSpeakerMode Quad = 3;
	public const AudioSpeakerMode Surround = 4;
	public const AudioSpeakerMode Mode5point1 = 5;
	public const AudioSpeakerMode Mode7point1 = 6;
	public const AudioSpeakerMode Prologic = 7;

}

public enum AudioDataLoadState // TypeDefIndex: 3999
{	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;

}

public struct AudioConfiguration // TypeDefIndex: 4000
{	public AudioSpeakerMode speakerMode; // 0x0
	public int dspBufferSize; // 0x4
	public int sampleRate; // 0x8
	public int numRealVoices; // 0xC
	public int numVirtualVoices; // 0x10

}

public enum AudioSourceCurveType // TypeDefIndex: 4002
{	public int value__; // 0x0
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;

}

public enum AudioReverbPreset // TypeDefIndex: 4003
{	public int value__; // 0x0
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

public sealed class AudioSettings // TypeDefIndex: 4004
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x126CF

	public static AudioSpeakerMode speakerMode { get; }
	public static double dspTime { get; }
	public static int outputSampleRate { get; }


	private static AudioSpeakerMode GetSpeakerMode() { }

	[NativeThrowsAttribute] // RVA: 0xB3DB0 Offset: 0xB31B0 VA: 0x1800B3DB0
	[NativeMethodAttribute] // RVA: 0xB3DB0 Offset: 0xB31B0 VA: 0x1800B3DB0
	private static bool SetConfiguration(AudioConfiguration config) { }

	[NativeMethodAttribute] // RVA: 0xB3F10 Offset: 0xB3310 VA: 0x1800B3F10
	private static int GetSampleRate() { }

	public static AudioSpeakerMode get_speakerMode() { }

	[NativeMethodAttribute] // RVA: 0xB40A0 Offset: 0xB34A0 VA: 0x1800B40A0
	public static double get_dspTime() { }

	public static int get_outputSampleRate() { }

	[NativeMethodAttribute] // RVA: 0xB4110 Offset: 0xB3510 VA: 0x1800B4110
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	public static AudioConfiguration GetConfiguration() { }

	public static bool Reset(AudioConfiguration config) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

}

public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 4005
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(bool deviceWasChanged) { }

	public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip : Object // TypeDefIndex: 4006
{	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	[NativePropertyAttribute] // RVA: 0xB4940 Offset: 0xB3D40 VA: 0x1800B4940
	public float length { get; }
	[NativePropertyAttribute] // RVA: 0xB4A70 Offset: 0xB3E70 VA: 0x1800B4A70
	public int samples { get; }
	[NativePropertyAttribute] // RVA: 0xB4C10 Offset: 0xB4010 VA: 0x1800B4C10
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

	[NativeMethodAttribute] // RVA: 0xB4520 Offset: 0xB3920 VA: 0x1800B4520
	public AudioDataLoadState get_loadState() { }

	public bool GetData(float[] data, int offsetSamples) { }

	public bool SetData(float[] data, int offsetSamples) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 4007
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(float[] data) { }

	public virtual IAsyncResult BeginInvoke(float[] data, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 4008
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(int position) { }

	public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4011
{
[StaticAccessorAttribute] // RVA: 0xB6040 Offset: 0xB5440 VA: 0x1800B6040
[RequireComponent] // RVA: 0xB6040 Offset: 0xB5440 VA: 0x1800B6040
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 4010

[RequireComponent] // RVA: 0xB6410 Offset: 0xB5810 VA: 0x1800B6410
[StaticAccessorAttribute] // RVA: 0xB6410 Offset: 0xB5810 VA: 0x1800B6410
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4011
	public float volume { get; set; }
	public float pitch { get; set; }
	[NativePropertyAttribute] // RVA: 0xB86D0 Offset: 0xB7AD0 VA: 0x1800B86D0
	public float time { get; set; }
	[NativePropertyAttribute] // RVA: 0xB8810 Offset: 0xB7C10 VA: 0x1800B8810
	public int timeSamples { get; set; }
	[NativePropertyAttribute] // RVA: 0xB8870 Offset: 0xB7C70 VA: 0x1800B8870
	public AudioClip clip { get; set; }
	public AudioMixerGroup outputAudioMixerGroup { get; set; }
	public bool isPlaying { get; }
	public bool loop { set; }
	public bool playOnAwake { set; }
	[NativePropertyAttribute] // RVA: 0xB8940 Offset: 0xB7D40 VA: 0x1800B8940
	public float panStereo { get; set; }
	[NativePropertyAttribute] // RVA: 0xB8970 Offset: 0xB7D70 VA: 0x1800B8970
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

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	public float get_volume() { }

	public void set_volume(float value) { }

	public float get_pitch() { }

	public void set_pitch(float value) { }

	public float get_time() { }

	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	public void set_timeSamples(int value) { }

	public AudioClip get_clip() { }

	public void set_clip(AudioClip value) { }

	public AudioMixerGroup get_outputAudioMixerGroup() { }

	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void Play() { }

	public void PlayDelayed(float delay) { }

	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void PlayOneShot(AudioClip clip) { }

	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	public void Stop() { }

	public void Pause() { }

	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xB85D0 Offset: 0xB79D0 VA: 0x1800B85D0
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

public sealed class AudioReverbZone : Behaviour // TypeDefIndex: 4012
{	public float minDistance { get; set; }
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

public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4014
{
[NativeHeaderAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[NativeHeaderAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[StaticAccessorAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[NativeHeaderAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[RequiredByNativeCodeAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4014
	private PlayableHandle m_Handle; // 0x0


	public PlayableHandle GetHandle() { }

	public bool Equals(AudioClipPlayable other) { }

}

public class AudioMixer : Object // TypeDefIndex: 4015
{
	internal void .ctor() { }

	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0xB9070 Offset: 0xB8470 VA: 0x1800B9070
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool SetFloat(string name, float value) { }

	[NativeMethodAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool GetFloat(string name, out float value) { }

}

public class AudioMixerGroup : Object // TypeDefIndex: 4016
{
	internal void .ctor() { }

}

public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 4017
{	private PlayableHandle m_Handle; // 0x0


	public PlayableHandle GetHandle() { }

	public bool Equals(AudioMixerPlayable other) { }

}

public class AudioMixerSnapshot : Object // TypeDefIndex: 4018
{	[NativePropertyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AudioMixer audioMixer { get; }


	public AudioMixer get_audioMixer() { }

	public void TransitionTo(float timeToReach) { }

}

public struct AudioPlayableOutput // TypeDefIndex: 4019
{	private PlayableOutputHandle m_Handle; // 0x0

}

public class AudioSampleProvider // TypeDefIndex: 4020
{	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18


	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 4021
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

public class AudioEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6416
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int colourMode; // 0x14
	public int volumeRange; // 0x18
	public int speed; // 0x1C
	public int gradient; // 0x20


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

public class AudioVisualisationEntity : IOEntity // TypeDefIndex: 8307
{	private Option __menuOption_ChangeLightSettings; // 0x288
	private EntityRef<BaseEntity> connectedTo; // 0x2E0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AudioVisualisationEntity.LightColour <currentColour>k__BackingField; // 0x2F0
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AudioVisualisationEntity.VolumeSensitivity <currentVolumeSensitivity>k__BackingField; // 0x2F4
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private AudioVisualisationEntity.Speed <currentSpeed>k__BackingField; // 0x2F8
	public GameObjectRef SettingsDialog; // 0x300
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private int <currentGradient>k__BackingField; // 0x308
	private IAudioConnectionSource currentSource; // 0x310
	private static float[] bands; // 0x0
	private float roughPeak; // 0x318

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

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AudioVisualisationEntity.LightColour get_currentColour() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentColour(AudioVisualisationEntity.LightColour value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AudioVisualisationEntity.VolumeSensitivity get_currentVolumeSensitivity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentVolumeSensitivity(AudioVisualisationEntity.VolumeSensitivity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AudioVisualisationEntity.Speed get_currentSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentSpeed(AudioVisualisationEntity.Speed value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public int get_currentGradient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_currentGradient(int value) { }

	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	private void UpdateInvoke() { }

	public override void ResetState() { }

	protected virtual void UpdateVisualisation(float volume, bool force = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	public virtual bool get_ShowColourOption() { }

	public virtual bool get_ShowVolumeOption() { }

	public virtual bool get_ShowSpeedOption() { }

	public virtual bool get_ShowPatternOption() { }

	public virtual bool get_ShowGradientOption() { }

	protected bool get_HasAudioSource() { }

	protected virtual void UpdateVisualSettings() { }

	[BaseEntity.Menu] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	[BaseEntity.Menu.Description] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	[BaseEntity.Menu.Icon] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	public void ChangeLightSettings(BasePlayer player) { }

	public void SendNewLightSettings(int newColour, int newVolumeRange, int newSpeed, int newGradient) { }

	private bool CanChangeLightSettings(BasePlayer player) { }

	public override bool DisplayHealthInfo(BasePlayer player) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum AudioVisualisationEntity.LightColour // TypeDefIndex: 8308
{	public int value__; // 0x0
	public const AudioVisualisationEntity.LightColour Red = 0;
	public const AudioVisualisationEntity.LightColour Green = 1;
	public const AudioVisualisationEntity.LightColour Blue = 2;
	public const AudioVisualisationEntity.LightColour Yellow = 3;
	public const AudioVisualisationEntity.LightColour Pink = 4;

}

public enum AudioVisualisationEntity.VolumeSensitivity // TypeDefIndex: 8309
{	public int value__; // 0x0
	public const AudioVisualisationEntity.VolumeSensitivity Small = 0;
	public const AudioVisualisationEntity.VolumeSensitivity Medium = 1;
	public const AudioVisualisationEntity.VolumeSensitivity Large = 2;

}

public enum AudioVisualisationEntity.Speed // TypeDefIndex: 8310
{	public int value__; // 0x0
	public const AudioVisualisationEntity.Speed Low = 0;
	public const AudioVisualisationEntity.Speed Medium = 1;
	public const AudioVisualisationEntity.Speed High = 2;

}

public class AudioAlarm : IOEntity // TypeDefIndex: 8699
{
	public void .ctor() { }

}

public class AudioSettings : MonoBehaviour // TypeDefIndex: 9121
{	public AudioMixer mixer; // 0x18


	private void Update() { }

	private float LinearToDecibel(float linear) { }

	public void .ctor() { }

}

public class AudioVisualisationEntityLight : AudioVisualisationEntity // TypeDefIndex: 9434
{	public Light TargetLight; // 0x320
	public Light SecondaryLight; // 0x328
	public MeshRenderer[] TargetRenderer; // 0x330
	public AudioVisualisationEntityLight.LightColourSet RedColour; // 0x338
	public AudioVisualisationEntityLight.LightColourSet GreenColour; // 0x368
	public AudioVisualisationEntityLight.LightColourSet BlueColour; // 0x398
	public AudioVisualisationEntityLight.LightColourSet YellowColour; // 0x3C8
	public AudioVisualisationEntityLight.LightColourSet PinkColour; // 0x3F8
	public float lightMinIntensity; // 0x428
	public float lightMaxIntensity; // 0x42C
	private static MaterialPropertyBlock block; // 0x0
	private static int emissionColourId; // 0x8
	private float lastVolume; // 0x430

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

public struct AudioVisualisationEntityLight.LightColourSet // TypeDefIndex: 9435
{	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color LightColor; // 0x0
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color SecondaryLightColour; // 0x10
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color EmissionColour; // 0x20

}

public class AudioInterceptComponent : MonoBehaviour // TypeDefIndex: 9455
{	public OggEncoder Encoder; // 0x18
	private float[] strippedData; // 0x20
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debugChannels; // 0x0


	private void OnAudioFilterRead(float[] data, int channels) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Audio : ConsoleSystem // TypeDefIndex: 11879
{	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float master; // 0x0
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float musicvolume; // 0x4
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float musicvolumemenu; // 0x8
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float game; // 0xC
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float voices; // 0x10
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float instruments; // 0x14
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static float voiceProps; // 0x18
	[ClientVar] // RVA: 0x889E0 Offset: 0x87DE0 VA: 0x1800889E0
	public static bool ambience; // 0x1C
	[ClientVar] // RVA: 0x88B00 Offset: 0x87F00 VA: 0x180088B00
	public static float framebudget; // 0x20
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float minupdatefraction; // 0x24
	[ClientVar] // RVA: 0x88F10 Offset: 0x88310 VA: 0x180088F10
	public static bool advancedocclusion; // 0x28
	[ClientVar] // RVA: 0x88F90 Offset: 0x88390 VA: 0x180088F90
	public static bool hqsoundfade; // 0x29
	[ClientVar] // RVA: 0x89040 Offset: 0x88440 VA: 0x180089040
	public static bool debugVoiceLimiting; // 0x2A

	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static int speakers { get; set; }


	public static int get_speakers() { }

	public static void set_speakers(int value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void printSounds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x890E0 Offset: 0x884E0 VA: 0x1800890E0
	public static void printEngineSounds(ConsoleSystem.Arg arg) { }

	public void .ctor() { }

	private static void .cctor() { }

}

