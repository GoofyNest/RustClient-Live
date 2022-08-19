public enum AudioSpeakerMode // TypeDefIndex: 3998
{
// Namespace: UnityEngine
public enum AudioSpeakerMode // TypeDefIndex: 3998
	// Fields
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
{	// Fields
	public int value__; // 0x0
	public const AudioDataLoadState Unloaded = 0;
	public const AudioDataLoadState Loading = 1;
	public const AudioDataLoadState Loaded = 2;
	public const AudioDataLoadState Failed = 3;

}

public struct AudioConfiguration // TypeDefIndex: 4000
{	// Fields
	public AudioSpeakerMode speakerMode; // 0x0
	public int dspBufferSize; // 0x4
	public int sampleRate; // 0x8
	public int numRealVoices; // 0xC
	public int numVirtualVoices; // 0x10

}

public enum AudioSourceCurveType // TypeDefIndex: 4002
{	// Fields
	public int value__; // 0x0
	public const AudioSourceCurveType CustomRolloff = 0;
	public const AudioSourceCurveType SpatialBlend = 1;
	public const AudioSourceCurveType ReverbZoneMix = 2;
	public const AudioSourceCurveType Spread = 3;

}

public enum AudioReverbPreset // TypeDefIndex: 4003
{	// Fields
	public int value__; // 0x0
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
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private static AudioSettings.AudioConfigurationChangeHandler OnAudioConfigurationChanged; // 0x126CF

	// Properties
	public static AudioSpeakerMode speakerMode { get; }
	public static double dspTime { get; }
	public static int outputSampleRate { get; }

	// Methods

	// RVA: 0x22F48C0 Offset: 0x22F3CC0 VA: 0x1822F48C0
	private static AudioSpeakerMode GetSpeakerMode() { }

	[NativeThrowsAttribute] // RVA: 0xB3DB0 Offset: 0xB31B0 VA: 0x1800B3DB0
	[NativeMethodAttribute] // RVA: 0xB3DB0 Offset: 0xB31B0 VA: 0x1800B3DB0
	// RVA: 0x22F49C0 Offset: 0x22F3DC0 VA: 0x1822F49C0
	private static bool SetConfiguration(AudioConfiguration config) { }

	[NativeMethodAttribute] // RVA: 0xB3F10 Offset: 0xB3310 VA: 0x1800B3F10
	// RVA: 0x22F4890 Offset: 0x22F3C90 VA: 0x1822F4890
	private static int GetSampleRate() { }

	// RVA: 0x22F48C0 Offset: 0x22F3CC0 VA: 0x1822F48C0
	public static AudioSpeakerMode get_speakerMode() { }

	[NativeMethodAttribute] // RVA: 0xB40A0 Offset: 0xB34A0 VA: 0x1800B40A0
	// RVA: 0x22F4A00 Offset: 0x22F3E00 VA: 0x1822F4A00
	public static double get_dspTime() { }

	// RVA: 0x22F4890 Offset: 0x22F3C90 VA: 0x1822F4890
	public static int get_outputSampleRate() { }

	[NativeMethodAttribute] // RVA: 0xB4110 Offset: 0xB3510 VA: 0x1800B4110
	// RVA: 0x22F4840 Offset: 0x22F3C40 VA: 0x1822F4840
	public static void GetDSPBufferSize(out int bufferLength, out int numBuffers) { }

	// RVA: 0x22F47F0 Offset: 0x22F3BF0 VA: 0x1822F47F0
	public static AudioConfiguration GetConfiguration() { }

	// RVA: 0x22F4940 Offset: 0x22F3D40 VA: 0x1822F4940
	public static bool Reset(AudioConfiguration config) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F48F0 Offset: 0x22F3CF0 VA: 0x1822F48F0
	internal static void InvokeOnAudioConfigurationChanged(bool deviceWasChanged) { }

	// RVA: 0x22F4980 Offset: 0x22F3D80 VA: 0x1822F4980
	private static bool SetConfiguration_Injected(ref AudioConfiguration config) { }

	// RVA: 0x22F47B0 Offset: 0x22F3BB0 VA: 0x1822F47B0
	private static void GetConfiguration_Injected(out AudioConfiguration ret) { }

}

public sealed class AudioSettings.AudioConfigurationChangeHandler : MulticastDelegate // TypeDefIndex: 4005
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xA496F0 Offset: 0xA48AF0 VA: 0x180A496F0 Slot: 12
	public virtual void Invoke(bool deviceWasChanged) { }

	// RVA: 0x22F3970 Offset: 0x22F2D70 VA: 0x1822F3970 Slot: 13
	public virtual IAsyncResult BeginInvoke(bool deviceWasChanged, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip : Object // TypeDefIndex: 4006
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private AudioClip.PCMReaderCallback m_PCMReaderCallback; // 0x18
	[CompilerGeneratedAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	[DebuggerBrowsableAttribute] // RVA: 0x707F0 Offset: 0x6FBF0 VA: 0x1800707F0
	private AudioClip.PCMSetPositionCallback m_PCMSetPositionCallback; // 0x20

	// Properties
	[NativePropertyAttribute] // RVA: 0xB4940 Offset: 0xB3D40 VA: 0x1800B4940
	public float length { get; }
	[NativePropertyAttribute] // RVA: 0xB4A70 Offset: 0xB3E70 VA: 0x1800B4A70
	public int samples { get; }
	[NativePropertyAttribute] // RVA: 0xB4C10 Offset: 0xB4010 VA: 0x1800B4C10
	public int channels { get; }
	public int frequency { get; }
	public AudioDataLoadState loadState { get; }

	// Methods

	// RVA: 0x22F3530 Offset: 0x22F2930 VA: 0x1822F3530
	private void .ctor() { }

	// RVA: 0x22F3150 Offset: 0x22F2550 VA: 0x1822F3150
	private static bool GetData(AudioClip clip, [Out] float[] data, int numSamples, int samplesOffset) { }

	// RVA: 0x22F3480 Offset: 0x22F2880 VA: 0x1822F3480
	private static bool SetData(AudioClip clip, float[] data, int numsamples, int samplesOffset) { }

	// RVA: 0x22F2C10 Offset: 0x22F2010 VA: 0x1822F2C10
	private static AudioClip Construct_Internal() { }

	// RVA: 0x22F31C0 Offset: 0x22F25C0 VA: 0x1822F31C0
	private string GetName() { }

	// RVA: 0x22F2C40 Offset: 0x22F2040 VA: 0x1822F2C40
	private void CreateUserSound(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x22F3770 Offset: 0x22F2B70 VA: 0x1822F3770
	public float get_length() { }

	// RVA: 0x22F37F0 Offset: 0x22F2BF0 VA: 0x1822F37F0
	public int get_samples() { }

	// RVA: 0x22F36F0 Offset: 0x22F2AF0 VA: 0x1822F36F0
	public int get_channels() { }

	// RVA: 0x22F3730 Offset: 0x22F2B30 VA: 0x1822F3730
	public int get_frequency() { }

	// RVA: 0x22F3240 Offset: 0x22F2640 VA: 0x1822F3240
	public bool LoadAudioData() { }

	// RVA: 0x22F34F0 Offset: 0x22F28F0 VA: 0x1822F34F0
	public bool UnloadAudioData() { }

	[NativeMethodAttribute] // RVA: 0xB4520 Offset: 0xB3920 VA: 0x1800B4520
	// RVA: 0x22F37B0 Offset: 0x22F2BB0 VA: 0x1822F37B0
	public AudioDataLoadState get_loadState() { }

	// RVA: 0x22F2FF0 Offset: 0x22F23F0 VA: 0x1822F2FF0
	public bool GetData(float[] data, int offsetSamples) { }

	// RVA: 0x22F3280 Offset: 0x22F2680 VA: 0x1822F3280
	public bool SetData(float[] data, int offsetSamples) { }

	// RVA: 0x22F2CE0 Offset: 0x22F20E0 VA: 0x1822F2CE0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream) { }

	// RVA: 0x22F2CB0 Offset: 0x22F20B0 VA: 0x1822F2CB0
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback) { }

	// RVA: 0x22F2D10 Offset: 0x22F2110 VA: 0x1822F2D10
	public static AudioClip Create(string name, int lengthSamples, int channels, int frequency, bool stream, AudioClip.PCMReaderCallback pcmreadercallback, AudioClip.PCMSetPositionCallback pcmsetpositioncallback) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F35B0 Offset: 0x22F29B0 VA: 0x1822F35B0
	private void add_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F3830 Offset: 0x22F2C30 VA: 0x1822F3830
	private void remove_m_PCMReaderCallback(AudioClip.PCMReaderCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F3650 Offset: 0x22F2A50 VA: 0x1822F3650
	private void add_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F38D0 Offset: 0x22F2CD0 VA: 0x1822F38D0
	private void remove_m_PCMSetPositionCallback(AudioClip.PCMSetPositionCallback value) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F3200 Offset: 0x22F2600 VA: 0x1822F3200
	private void InvokePCMReaderCallback_Internal(float[] data) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F3220 Offset: 0x22F2620 VA: 0x1822F3220
	private void InvokePCMSetPositionCallback_Internal(int position) { }

}

public sealed class AudioClip.PCMReaderCallback : MulticastDelegate // TypeDefIndex: 4007
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x12DD910 Offset: 0x12DCD10 VA: 0x1812DD910 Slot: 12
	public virtual void Invoke(float[] data) { }

	// RVA: 0x497210 Offset: 0x496610 VA: 0x180497210 Slot: 13
	public virtual IAsyncResult BeginInvoke(float[] data, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioClip.PCMSetPositionCallback : MulticastDelegate // TypeDefIndex: 4008
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x1A378D0 Offset: 0x1A36CD0 VA: 0x181A378D0 Slot: 12
	public virtual void Invoke(int position) { }

	// RVA: 0x22F5970 Offset: 0x22F4D70 VA: 0x1822F5970 Slot: 13
	public virtual IAsyncResult BeginInvoke(int position, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4011
{
// Namespace: UnityEngine
[StaticAccessorAttribute] // RVA: 0xB6040 Offset: 0xB5440 VA: 0x1800B6040
[RequireComponent] // RVA: 0xB6040 Offset: 0xB5440 VA: 0x1800B6040
public sealed class AudioListener : AudioBehaviour // TypeDefIndex: 4010

// Namespace: UnityEngine
[RequireComponent] // RVA: 0xB6410 Offset: 0xB5810 VA: 0x1800B6410
[StaticAccessorAttribute] // RVA: 0xB6410 Offset: 0xB5810 VA: 0x1800B6410
public sealed class AudioSource : AudioBehaviour // TypeDefIndex: 4011
	// Properties
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

	// Methods

	// RVA: 0x22F4A90 Offset: 0x22F3E90 VA: 0x1822F4A90
	private static float GetPitch(AudioSource source) { }

	// RVA: 0x22F51D0 Offset: 0x22F45D0 VA: 0x1822F51D0
	private static void SetPitch(AudioSource source, float pitch) { }

	// RVA: 0x22F4E30 Offset: 0x22F4230 VA: 0x1822F4E30
	private static void PlayHelper(AudioSource source, ulong delay) { }

	// RVA: 0x22F5130 Offset: 0x22F4530 VA: 0x1822F5130
	private void Play(double delay) { }

	// RVA: 0x22F4E80 Offset: 0x22F4280 VA: 0x1822F4E80
	private static void PlayOneShotHelper(AudioSource source, AudioClip clip, float volumeScale) { }

	// RVA: 0x22F5260 Offset: 0x22F4660 VA: 0x1822F5260
	private void Stop(bool stopOneShots) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x22F5180 Offset: 0x22F4580 VA: 0x1822F5180
	private static void SetCustomCurveHelper(AudioSource source, AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x22F4A30 Offset: 0x22F3E30 VA: 0x1822F4A30
	private static void GetOutputDataHelper(AudioSource source, [Out] float[] samples, int channel) { }

	[NativeThrowsAttribute] // RVA: 0x80970 Offset: 0x7FD70 VA: 0x180080970
	// RVA: 0x22F4AD0 Offset: 0x22F3ED0 VA: 0x1822F4AD0
	private static void GetSpectrumDataHelper(AudioSource source, [Out] float[] samples, int channel, FFTWindow window) { }

	// RVA: 0x22F54F0 Offset: 0x22F48F0 VA: 0x1822F54F0
	public float get_volume() { }

	// RVA: 0x22F5920 Offset: 0x22F4D20 VA: 0x1822F5920
	public void set_volume(float value) { }

	// RVA: 0x22F4A90 Offset: 0x22F3E90 VA: 0x1822F4A90
	public float get_pitch() { }

	// RVA: 0x22F51D0 Offset: 0x22F45D0 VA: 0x1822F51D0
	public void set_pitch(float value) { }

	// RVA: 0x22F54B0 Offset: 0x22F48B0 VA: 0x1822F54B0
	public float get_time() { }

	// RVA: 0x22F58D0 Offset: 0x22F4CD0 VA: 0x1822F58D0
	public void set_time(float value) { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x22F5470 Offset: 0x22F4870 VA: 0x1822F5470
	public int get_timeSamples() { }

	[NativeMethodAttribute] // RVA: 0x90400 Offset: 0x8F800 VA: 0x180090400
	// RVA: 0x22F5890 Offset: 0x22F4C90 VA: 0x1822F5890
	public void set_timeSamples(int value) { }

	// RVA: 0x22F52F0 Offset: 0x22F46F0 VA: 0x1822F52F0
	public AudioClip get_clip() { }

	// RVA: 0x22F5530 Offset: 0x22F4930 VA: 0x1822F5530
	public void set_clip(AudioClip value) { }

	// RVA: 0x22F53B0 Offset: 0x22F47B0 VA: 0x1822F53B0
	public AudioMixerGroup get_outputAudioMixerGroup() { }

	// RVA: 0x22F56C0 Offset: 0x22F4AC0 VA: 0x1822F56C0
	public void set_outputAudioMixerGroup(AudioMixerGroup value) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F50F0 Offset: 0x22F44F0 VA: 0x1822F50F0
	public void Play() { }

	// RVA: 0x22F4DC0 Offset: 0x22F41C0 VA: 0x1822F4DC0
	public void PlayDelayed(float delay) { }

	// RVA: 0x22F5090 Offset: 0x22F4490 VA: 0x1822F5090
	public void PlayScheduled(double time) { }

	[ExcludeFromDocsAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F4FC0 Offset: 0x22F43C0 VA: 0x1822F4FC0
	public void PlayOneShot(AudioClip clip) { }

	// RVA: 0x22F4EE0 Offset: 0x22F42E0 VA: 0x1822F4EE0
	public void PlayOneShot(AudioClip clip, float volumeScale) { }

	// RVA: 0x22F5220 Offset: 0x22F4620 VA: 0x1822F5220
	public void Stop() { }

	// RVA: 0x22F4B40 Offset: 0x22F3F40 VA: 0x1822F4B40
	public void Pause() { }

	// RVA: 0x22F52B0 Offset: 0x22F46B0 VA: 0x1822F52B0
	public void UnPause() { }

	[NativeNameAttribute] // RVA: 0xB85D0 Offset: 0xB79D0 VA: 0x1800B85D0
	// RVA: 0x22F5330 Offset: 0x22F4730 VA: 0x1822F5330
	public bool get_isPlaying() { }

	// RVA: 0x22F4B80 Offset: 0x22F3F80 VA: 0x1822F4B80
	public static void PlayClipAtPoint(AudioClip clip, Vector3 position, float volume) { }

	// RVA: 0x22F55D0 Offset: 0x22F49D0 VA: 0x1822F55D0
	public void set_loop(bool value) { }

	// RVA: 0x22F5760 Offset: 0x22F4B60 VA: 0x1822F5760
	public void set_playOnAwake(bool value) { }

	// RVA: 0x22F53F0 Offset: 0x22F47F0 VA: 0x1822F53F0
	public float get_panStereo() { }

	// RVA: 0x22F5710 Offset: 0x22F4B10 VA: 0x1822F5710
	public void set_panStereo(float value) { }

	// RVA: 0x22F57F0 Offset: 0x22F4BF0 VA: 0x1822F57F0
	public void set_spatialBlend(float value) { }

	// RVA: 0x22F5180 Offset: 0x22F4580 VA: 0x1822F5180
	public void SetCustomCurve(AudioSourceCurveType type, AnimationCurve curve) { }

	// RVA: 0x22F5580 Offset: 0x22F4980 VA: 0x1822F5580
	public void set_dopplerLevel(float value) { }

	// RVA: 0x22F5430 Offset: 0x22F4830 VA: 0x1822F5430
	public float get_spread() { }

	// RVA: 0x22F5840 Offset: 0x22F4C40 VA: 0x1822F5840
	public void set_spread(float value) { }

	// RVA: 0x22F57B0 Offset: 0x22F4BB0 VA: 0x1822F57B0
	public void set_priority(int value) { }

	// RVA: 0x22F5670 Offset: 0x22F4A70 VA: 0x1822F5670
	public void set_mute(bool value) { }

	// RVA: 0x22F5370 Offset: 0x22F4770 VA: 0x1822F5370
	public float get_maxDistance() { }

	// RVA: 0x22F5620 Offset: 0x22F4A20 VA: 0x1822F5620
	public void set_maxDistance(float value) { }

	// RVA: 0x22F4A30 Offset: 0x22F3E30 VA: 0x1822F4A30
	public void GetOutputData(float[] samples, int channel) { }

	// RVA: 0x22F4AD0 Offset: 0x22F3ED0 VA: 0x1822F4AD0
	public void GetSpectrumData(float[] samples, int channel, FFTWindow window) { }

}

public sealed class AudioReverbZone : Behaviour // TypeDefIndex: 4012
{	// Properties
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

	// Methods

	// RVA: 0x22F40D0 Offset: 0x22F34D0 VA: 0x1822F40D0
	public float get_minDistance() { }

	// RVA: 0x22F4500 Offset: 0x22F3900 VA: 0x1822F4500
	public void set_minDistance(float value) { }

	// RVA: 0x22F4090 Offset: 0x22F3490 VA: 0x1822F4090
	public float get_maxDistance() { }

	// RVA: 0x22F44B0 Offset: 0x22F38B0 VA: 0x1822F44B0
	public void set_maxDistance(float value) { }

	// RVA: 0x22F4630 Offset: 0x22F3A30 VA: 0x1822F4630
	public void set_reverbPreset(AudioReverbPreset value) { }

	// RVA: 0x22F4290 Offset: 0x22F3690 VA: 0x1822F4290
	public int get_room() { }

	// RVA: 0x22F4730 Offset: 0x22F3B30 VA: 0x1822F4730
	public void set_room(int value) { }

	// RVA: 0x22F4210 Offset: 0x22F3610 VA: 0x1822F4210
	public int get_roomHF() { }

	// RVA: 0x22F46B0 Offset: 0x22F3AB0 VA: 0x1822F46B0
	public void set_roomHF(int value) { }

	// RVA: 0x22F4250 Offset: 0x22F3650 VA: 0x1822F4250
	public int get_roomLF() { }

	// RVA: 0x22F46F0 Offset: 0x22F3AF0 VA: 0x1822F46F0
	public void set_roomLF(int value) { }

	// RVA: 0x22F3FD0 Offset: 0x22F33D0 VA: 0x1822F3FD0
	public float get_decayTime() { }

	// RVA: 0x22F43C0 Offset: 0x22F37C0 VA: 0x1822F43C0
	public void set_decayTime(float value) { }

	// RVA: 0x22F3F90 Offset: 0x22F3390 VA: 0x1822F3F90
	public float get_decayHFRatio() { }

	// RVA: 0x22F4370 Offset: 0x22F3770 VA: 0x1822F4370
	public void set_decayHFRatio(float value) { }

	// RVA: 0x22F4150 Offset: 0x22F3550 VA: 0x1822F4150
	public int get_reflections() { }

	// RVA: 0x22F45A0 Offset: 0x22F39A0 VA: 0x1822F45A0
	public void set_reflections(int value) { }

	// RVA: 0x22F4110 Offset: 0x22F3510 VA: 0x1822F4110
	public float get_reflectionsDelay() { }

	// RVA: 0x22F4550 Offset: 0x22F3950 VA: 0x1822F4550
	public void set_reflectionsDelay(float value) { }

	// RVA: 0x22F41D0 Offset: 0x22F35D0 VA: 0x1822F41D0
	public int get_reverb() { }

	// RVA: 0x22F4670 Offset: 0x22F3A70 VA: 0x1822F4670
	public void set_reverb(int value) { }

	// RVA: 0x22F4190 Offset: 0x22F3590 VA: 0x1822F4190
	public float get_reverbDelay() { }

	// RVA: 0x22F45E0 Offset: 0x22F39E0 VA: 0x1822F45E0
	public void set_reverbDelay(float value) { }

	// RVA: 0x22F3F10 Offset: 0x22F3310 VA: 0x1822F3F10
	public float get_HFReference() { }

	// RVA: 0x22F42D0 Offset: 0x22F36D0 VA: 0x1822F42D0
	public void set_HFReference(float value) { }

	// RVA: 0x22F3F50 Offset: 0x22F3350 VA: 0x1822F3F50
	public float get_LFReference() { }

	// RVA: 0x22F4320 Offset: 0x22F3720 VA: 0x1822F4320
	public void set_LFReference(float value) { }

	// RVA: 0x22F4050 Offset: 0x22F3450 VA: 0x1822F4050
	public float get_diffusion() { }

	// RVA: 0x22F4460 Offset: 0x22F3860 VA: 0x1822F4460
	public void set_diffusion(float value) { }

	// RVA: 0x22F4010 Offset: 0x22F3410 VA: 0x1822F4010
	public float get_density() { }

	// RVA: 0x22F4410 Offset: 0x22F3810 VA: 0x1822F4410
	public void set_density(float value) { }

}

public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4014
{
// Namespace: UnityEngine.Audio
[NativeHeaderAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[NativeHeaderAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[StaticAccessorAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[NativeHeaderAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
[RequiredByNativeCodeAttribute] // RVA: 0xB8C10 Offset: 0xB8010 VA: 0x1800B8C10
public struct AudioClipPlayable : IEquatable<AudioClipPlayable> // TypeDefIndex: 4014
	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23E000 Offset: 0x23D400 VA: 0x18023E000 Slot: 4
	public bool Equals(AudioClipPlayable other) { }

}

public class AudioMixer : Object // TypeDefIndex: 4015
{	// Methods

	// RVA: 0x22F3EB0 Offset: 0x22F32B0 VA: 0x1822F3EB0
	internal void .ctor() { }

	// RVA: 0x22F3C10 Offset: 0x22F3010 VA: 0x1822F3C10
	internal void TransitionToSnapshot(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0xB9070 Offset: 0xB8470 VA: 0x1800B9070
	// RVA: 0x22F3BB0 Offset: 0x22F2FB0 VA: 0x1822F3BB0
	private void TransitionToSnapshotInternal(AudioMixerSnapshot snapshot, float timeToReach) { }

	[NativeMethodAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F3B50 Offset: 0x22F2F50 VA: 0x1822F3B50
	public bool SetFloat(string name, float value) { }

	[NativeMethodAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F3AF0 Offset: 0x22F2EF0 VA: 0x1822F3AF0
	public bool GetFloat(string name, out float value) { }

}

public class AudioMixerGroup : Object // TypeDefIndex: 4016
{	// Methods

	// RVA: 0x22F39F0 Offset: 0x22F2DF0 VA: 0x1822F39F0
	internal void .ctor() { }

}

public struct AudioMixerPlayable : IEquatable<AudioMixerPlayable> // TypeDefIndex: 4017
{	// Fields
	private PlayableHandle m_Handle; // 0x0

	// Methods

	// RVA: 0x212D50 Offset: 0x212150 VA: 0x180212D50 Slot: 5
	public PlayableHandle GetHandle() { }

	// RVA: 0x23E090 Offset: 0x23D490 VA: 0x18023E090 Slot: 4
	public bool Equals(AudioMixerPlayable other) { }

}

public class AudioMixerSnapshot : Object // TypeDefIndex: 4018
{	// Properties
	[NativePropertyAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public AudioMixer audioMixer { get; }

	// Methods

	// RVA: 0x22F3AB0 Offset: 0x22F2EB0 VA: 0x1822F3AB0
	public AudioMixer get_audioMixer() { }

	// RVA: 0x22F3A50 Offset: 0x22F2E50 VA: 0x1822F3A50
	public void TransitionTo(float timeToReach) { }

}

public struct AudioPlayableOutput // TypeDefIndex: 4019
{	// Fields
	private PlayableOutputHandle m_Handle; // 0x0

}

public class AudioSampleProvider // TypeDefIndex: 4020
{	// Fields
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private AudioSampleProvider.SampleFramesHandler sampleFramesAvailable; // 0x10
	[DebuggerBrowsableAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	[CompilerGeneratedAttribute] // RVA: 0x70650 Offset: 0x6FA50 VA: 0x180070650
	private AudioSampleProvider.SampleFramesHandler sampleFramesOverflow; // 0x18

	// Methods

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F4770 Offset: 0x22F3B70 VA: 0x1822F4770
	private void InvokeSampleFramesAvailable(int sampleFrameCount) { }

	[RequiredByNativeCodeAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x22F4790 Offset: 0x22F3B90 VA: 0x1822F4790
	private void InvokeSampleFramesOverflow(int droppedSampleFrameCount) { }

}

public sealed class AudioSampleProvider.SampleFramesHandler : MulticastDelegate // TypeDefIndex: 4021
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0x22F5A80 Offset: 0x22F4E80 VA: 0x1822F5A80 Slot: 12
	public virtual void Invoke(AudioSampleProvider provider, uint sampleFrameCount) { }

	// RVA: 0x22F59F0 Offset: 0x22F4DF0 VA: 0x1822F59F0 Slot: 13
	public virtual IAsyncResult BeginInvoke(AudioSampleProvider provider, uint sampleFrameCount, AsyncCallback callback, object object) { }

	// RVA: 0x497050 Offset: 0x496450 VA: 0x180497050 Slot: 14
	public virtual void EndInvoke(IAsyncResult result) { }

}

public class AudioEntity : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6416
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int colourMode; // 0x14
	public int volumeRange; // 0x18
	public int speed; // 0x1C
	public int gradient; // 0x20

	// Methods

	// RVA: 0x1FF35F0 Offset: 0x1FF29F0 VA: 0x181FF35F0
	public static void ResetToPool(AudioEntity instance) { }

	// RVA: 0x1FF3550 Offset: 0x1FF2950 VA: 0x181FF3550
	public void ResetToPool() { }

	// RVA: 0x1FF3200 Offset: 0x1FF2600 VA: 0x181FF3200 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1C01DA0 Offset: 0x1C011A0 VA: 0x181C01DA0
	public void CopyTo(AudioEntity instance) { }

	// RVA: 0x1FF2070 Offset: 0x1FF1470 VA: 0x181FF2070
	public AudioEntity Copy() { }

	// RVA: 0x1FF2CC0 Offset: 0x1FF20C0 VA: 0x181FF2CC0
	public static AudioEntity Deserialize(Stream stream) { }

	// RVA: 0x1FF20F0 Offset: 0x1FF14F0 VA: 0x181FF20F0
	public static AudioEntity DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1FF2450 Offset: 0x1FF1850 VA: 0x181FF2450
	public static AudioEntity DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1FF29B0 Offset: 0x1FF1DB0 VA: 0x181FF29B0
	public static AudioEntity Deserialize(byte[] buffer) { }

	// RVA: 0x1FF3320 Offset: 0x1FF2720 VA: 0x181FF3320
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1FF3BD0 Offset: 0x1FF2FD0 VA: 0x181FF3BD0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1FF3BF0 Offset: 0x1FF2FF0 VA: 0x181FF3BF0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, AudioEntity previous) { }

	// RVA: 0x1FF3530 Offset: 0x1FF2930 VA: 0x181FF3530 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1FF2F10 Offset: 0x1FF2310 VA: 0x181FF2F10
	public static AudioEntity Deserialize(byte[] buffer, AudioEntity instance, bool isDelta = False) { }

	// RVA: 0x1FF27A0 Offset: 0x1FF1BA0 VA: 0x181FF27A0
	public static AudioEntity Deserialize(Stream stream, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF2170 Offset: 0x1FF1570 VA: 0x181FF2170
	public static AudioEntity DeserializeLengthDelimited(Stream stream, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF24E0 Offset: 0x1FF18E0 VA: 0x181FF24E0
	public static AudioEntity DeserializeLength(Stream stream, int length, AudioEntity instance, bool isDelta) { }

	// RVA: 0x1FF3690 Offset: 0x1FF2A90 VA: 0x181FF3690
	public static void SerializeDelta(Stream stream, AudioEntity instance, AudioEntity previous) { }

	// RVA: 0x1FF3A70 Offset: 0x1FF2E70 VA: 0x181FF3A70
	public static void Serialize(Stream stream, AudioEntity instance) { }

	// RVA: 0x1FF3BC0 Offset: 0x1FF2FC0 VA: 0x181FF3BC0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1FF3BD0 Offset: 0x1FF2FD0 VA: 0x181FF3BD0
	public void ToProto(Stream stream) { }

	// RVA: 0x1FF3960 Offset: 0x1FF2D60 VA: 0x181FF3960
	public static byte[] SerializeToBytes(AudioEntity instance) { }

	// RVA: 0x1FF38B0 Offset: 0x1FF2CB0 VA: 0x181FF38B0
	public static void SerializeLengthDelimited(Stream stream, AudioEntity instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class AudioVisualisationEntity : IOEntity // TypeDefIndex: 8307
{	// Fields
	private Option __menuOption_ChangeLightSettings; // 0x288
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

	// Properties
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

	// Methods

	// RVA: 0x834D70 Offset: 0x834170 VA: 0x180834D70 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x835F00 Offset: 0x835300 VA: 0x180835F00 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x835330 Offset: 0x834730 VA: 0x180835330 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x835FD0 Offset: 0x8353D0 VA: 0x180835FD0
	public AudioVisualisationEntity.LightColour get_currentColour() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836010 Offset: 0x835410 VA: 0x180836010
	private void set_currentColour(AudioVisualisationEntity.LightColour value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836000 Offset: 0x835400 VA: 0x180836000
	public AudioVisualisationEntity.VolumeSensitivity get_currentVolumeSensitivity() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836040 Offset: 0x835440 VA: 0x180836040
	private void set_currentVolumeSensitivity(AudioVisualisationEntity.VolumeSensitivity value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x835FF0 Offset: 0x8353F0 VA: 0x180835FF0
	public AudioVisualisationEntity.Speed get_currentSpeed() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836030 Offset: 0x835430 VA: 0x180836030
	private void set_currentSpeed(AudioVisualisationEntity.Speed value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x835FE0 Offset: 0x8353E0 VA: 0x180835FE0
	public int get_currentGradient() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x836020 Offset: 0x835420 VA: 0x180836020
	private void set_currentGradient(int value) { }

	// RVA: 0x835190 Offset: 0x834590 VA: 0x180835190 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x835970 Offset: 0x834D70 VA: 0x180835970
	private void UpdateInvoke() { }

	// RVA: 0x835840 Offset: 0x834C40 VA: 0x180835840 Slot: 27
	public override void ResetState() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 159
	protected virtual void UpdateVisualisation(float volume, bool force = False) { }

	[BaseEntity.RPC_Client] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x834C80 Offset: 0x834080 VA: 0x180834C80
	private void Client_PlayAudioFrom(BaseEntity.RPCMessage msg) { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 160
	public virtual bool get_ShowColourOption() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 161
	public virtual bool get_ShowVolumeOption() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 162
	public virtual bool get_ShowSpeedOption() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 163
	public virtual bool get_ShowPatternOption() { }

	// RVA: 0x498AD0 Offset: 0x497ED0 VA: 0x180498AD0 Slot: 164
	public virtual bool get_ShowGradientOption() { }

	// RVA: 0x835EA0 Offset: 0x8352A0 VA: 0x180835EA0
	protected bool get_HasAudioSource() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 165
	protected virtual void UpdateVisualSettings() { }

	[BaseEntity.Menu] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	[BaseEntity.Menu.Description] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	[BaseEntity.Menu.ShowIf] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	[BaseEntity.Menu.Icon] // RVA: 0xB1EE0 Offset: 0xB12E0 VA: 0x1800B1EE0
	// RVA: 0x834B80 Offset: 0x833F80 VA: 0x180834B80
	public void ChangeLightSettings(BasePlayer player) { }

	// RVA: 0x8358D0 Offset: 0x834CD0 VA: 0x1808358D0
	public void SendNewLightSettings(int newColour, int newVolumeRange, int newSpeed, int newGradient) { }

	// RVA: 0x575940 Offset: 0x574D40 VA: 0x180575940
	private bool CanChangeLightSettings(BasePlayer player) { }

	// RVA: 0x2F99A0 Offset: 0x2F8DA0 VA: 0x1802F99A0 Slot: 131
	public override bool DisplayHealthInfo(BasePlayer player) { }

	// RVA: 0x835090 Offset: 0x834490 VA: 0x180835090 Slot: 34
	public override void Load(BaseNetworkable.LoadInfo info) { }

	// RVA: 0x835E30 Offset: 0x835230 VA: 0x180835E30
	public void .ctor() { }

	// RVA: 0x835DE0 Offset: 0x8351E0 VA: 0x180835DE0
	private static void .cctor() { }

}

public enum AudioVisualisationEntity.LightColour // TypeDefIndex: 8308
{	// Fields
	public int value__; // 0x0
	public const AudioVisualisationEntity.LightColour Red = 0;
	public const AudioVisualisationEntity.LightColour Green = 1;
	public const AudioVisualisationEntity.LightColour Blue = 2;
	public const AudioVisualisationEntity.LightColour Yellow = 3;
	public const AudioVisualisationEntity.LightColour Pink = 4;

}

public enum AudioVisualisationEntity.VolumeSensitivity // TypeDefIndex: 8309
{	// Fields
	public int value__; // 0x0
	public const AudioVisualisationEntity.VolumeSensitivity Small = 0;
	public const AudioVisualisationEntity.VolumeSensitivity Medium = 1;
	public const AudioVisualisationEntity.VolumeSensitivity Large = 2;

}

public enum AudioVisualisationEntity.Speed // TypeDefIndex: 8310
{	// Fields
	public int value__; // 0x0
	public const AudioVisualisationEntity.Speed Low = 0;
	public const AudioVisualisationEntity.Speed Medium = 1;
	public const AudioVisualisationEntity.Speed High = 2;

}

public class AudioAlarm : IOEntity // TypeDefIndex: 8699
{	// Methods

	// RVA: 0x833390 Offset: 0x832790 VA: 0x180833390
	public void .ctor() { }

}

public class AudioSettings : MonoBehaviour // TypeDefIndex: 9121
{	// Fields
	public AudioMixer mixer; // 0x18

	// Methods

	// RVA: 0x833740 Offset: 0x832B40 VA: 0x180833740
	private void Update() { }

	// RVA: 0x8336C0 Offset: 0x832AC0 VA: 0x1808336C0
	private float LinearToDecibel(float linear) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class AudioVisualisationEntityLight : AudioVisualisationEntity // TypeDefIndex: 9434
{	// Fields
	public Light TargetLight; // 0x320
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

	// Properties
	public override bool ShowColourOption { get; }
	public override bool ShowSpeedOption { get; }
	public override bool ShowVolumeOption { get; }

	// Methods

	// RVA: 0x833D00 Offset: 0x833100 VA: 0x180833D00 Slot: 14
	protected override void ClientInit(Entity info) { }

	// RVA: 0x834800 Offset: 0x833C00 VA: 0x180834800 Slot: 159
	protected override void UpdateVisualisation(float volume, bool force = False) { }

	// RVA: 0x833EB0 Offset: 0x8332B0 VA: 0x180833EB0
	private float GetCurrentSpeedValue() { }

	// RVA: 0x833EF0 Offset: 0x8332F0 VA: 0x180833EF0
	private void GetCurrentVolumeRange(out float min, out float max) { }

	// RVA: 0x8342A0 Offset: 0x8336A0 VA: 0x1808342A0
	private void UpdateLightComponentSettings() { }

	// RVA: 0x833DD0 Offset: 0x8331D0 VA: 0x180833DD0
	private AudioVisualisationEntityLight.LightColourSet EnumToColour(AudioVisualisationEntity.LightColour colour) { }

	// RVA: 0x834390 Offset: 0x833790 VA: 0x180834390
	private void UpdateRenderer(float volumeNormalised) { }

	// RVA: 0x834700 Offset: 0x833B00 VA: 0x180834700 Slot: 165
	protected override void UpdateVisualSettings() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 160
	public override bool get_ShowColourOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 162
	public override bool get_ShowSpeedOption() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 161
	public override bool get_ShowVolumeOption() { }

	// RVA: 0x833F40 Offset: 0x833340 VA: 0x180833F40 Slot: 80
	public override void OnFlagsChanged(BaseEntity.Flags old, BaseEntity.Flags next) { }

	// RVA: 0x834AC0 Offset: 0x833EC0 VA: 0x180834AC0
	public void .ctor() { }

	// RVA: 0x834A60 Offset: 0x833E60 VA: 0x180834A60
	private static void .cctor() { }

}

public struct AudioVisualisationEntityLight.LightColourSet // TypeDefIndex: 9435
{	// Fields
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color LightColor; // 0x0
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color SecondaryLightColour; // 0x10
	[ColorUsageAttribute] // RVA: 0x859B0 Offset: 0x84DB0 VA: 0x1800859B0
	public Color EmissionColour; // 0x20

}

public class AudioInterceptComponent : MonoBehaviour // TypeDefIndex: 9455
{	// Fields
	public OggEncoder Encoder; // 0x18
	private float[] strippedData; // 0x20
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static bool debugChannels; // 0x0

	// Methods

	// RVA: 0x8333F0 Offset: 0x8327F0 VA: 0x1808333F0
	private void OnAudioFilterRead(float[] data, int channels) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class Audio : ConsoleSystem // TypeDefIndex: 11879
{	// Fields
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
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

	// Properties
	[ClientVar] // RVA: 0x88050 Offset: 0x87450 VA: 0x180088050
	public static int speakers { get; set; }

	// Methods

	// RVA: 0x6C8AE0 Offset: 0x6C7EE0 VA: 0x1806C8AE0
	public static int get_speakers() { }

	// RVA: 0x6C9EA0 Offset: 0x6C92A0 VA: 0x1806C9EA0
	public static void set_speakers(int value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6C9C50 Offset: 0x6C9050 VA: 0x1806C9C50
	public static void printSounds(ConsoleSystem.Arg arg) { }

	[ClientVar] // RVA: 0x890E0 Offset: 0x884E0 VA: 0x1800890E0
	// RVA: 0x6C8AF0 Offset: 0x6C7EF0 VA: 0x1806C8AF0
	public static void printEngineSounds(ConsoleSystem.Arg arg) { }

	// RVA: 0x6C8A80 Offset: 0x6C7E80 VA: 0x1806C8A80
	public void .ctor() { }

	// RVA: 0x6C8950 Offset: 0x6C7D50 VA: 0x1806C8950
	private static void .cctor() { }

}

