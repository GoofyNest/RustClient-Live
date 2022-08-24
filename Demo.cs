public class DemoHeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6464
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint version; 
	public string level; 
	public uint levelSeed; 
	public uint levelSize; 
	public string checksum; 
	public ulong localclient; 
	public Vector3 position; 
	public Vector3 rotation; 
	public string levelUrl; 
	public long recordedTime; 
	public long length; 
	public List<FileStorageCacheData> fileStorage; 


public static void ResetToPool(DemoHeader instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DemoHeader instance) { }

public DemoHeader Copy() { }

public static DemoHeader Deserialize(Stream stream) { }

public static DemoHeader DeserializeLengthDelimited(Stream stream) { }

public static DemoHeader DeserializeLength(Stream stream, int length) { }

public static DemoHeader Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DemoHeader previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoHeader Deserialize(byte[] buffer, DemoHeader instance, bool isDelta = False) { }

public static DemoHeader Deserialize(Stream stream, DemoHeader instance, bool isDelta) { }

public static DemoHeader DeserializeLengthDelimited(Stream stream, DemoHeader instance, bool isDelta) { }

public static DemoHeader DeserializeLength(Stream stream, int length, DemoHeader instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoHeader instance, DemoHeader previous) { }

public static void Serialize(Stream stream, DemoHeader instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoHeader instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoHeader instance) { }

public void .ctor() { }

}

public class DemoShot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6466
{
	public bool ShouldPool; 
	private bool _disposed; 
	public string shotName; 
	public string demoName; 
	public float shotStart; 
	public float shotLength; 
	public DemoShotVectorTrack camPos; 
	public DemoShotQuaternionTrack camRot; 
	public DemoShotFloatTrack camFov; 
	public DemoShotFloatTrack camDofDist; 
	public DemoShotFloatTrack camDofFocalSize; 
	public DemoShotFloatTrack camDofAperture; 
	public DemoShotParentTrack camParent; 
	public string folderName; 


public static void ResetToPool(DemoShot instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DemoShot instance) { }

public DemoShot Copy() { }

public static DemoShot Deserialize(Stream stream) { }

public static DemoShot DeserializeLengthDelimited(Stream stream) { }

public static DemoShot DeserializeLength(Stream stream, int length) { }

public static DemoShot Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DemoShot previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShot Deserialize(byte[] buffer, DemoShot instance, bool isDelta = False) { }

public static DemoShot Deserialize(Stream stream, DemoShot instance, bool isDelta) { }

public static DemoShot DeserializeLengthDelimited(Stream stream, DemoShot instance, bool isDelta) { }

public static DemoShot DeserializeLength(Stream stream, int length, DemoShot instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShot instance, DemoShot previous) { }

public static void Serialize(Stream stream, DemoShot instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShot instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShot instance) { }

public void .ctor() { }

}

public class DemoShotVectorTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6467
{
	public bool ShouldPool; 
	private bool _disposed; 
	public long trackType; 
	public List<DemoShotVectorKeyframe> keyframes; 


public static void ResetToPool(DemoShotVectorTrack instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DemoShotVectorTrack instance) { }

public DemoShotVectorTrack Copy() { }

public static DemoShotVectorTrack Deserialize(Stream stream) { }

public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream) { }

public static DemoShotVectorTrack DeserializeLength(Stream stream, int length) { }

public static DemoShotVectorTrack Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DemoShotVectorTrack previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotVectorTrack Deserialize(byte[] buffer, DemoShotVectorTrack instance, bool isDelta = False) { }

public static DemoShotVectorTrack Deserialize(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

public static DemoShotVectorTrack DeserializeLength(Stream stream, int length, DemoShotVectorTrack instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotVectorTrack instance, DemoShotVectorTrack previous) { }

public static void Serialize(Stream stream, DemoShotVectorTrack instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotVectorTrack instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotVectorTrack instance) { }

public void .ctor() { }

}

public struct DemoShotVectorKeyframe : IProto // TypeDefIndex: 6468
{
	public float keyframeTime; 
	public Vector3 keyFrameValue; 


public static void ResetToPool(DemoShotVectorKeyframe instance) { }

public void CopyTo(DemoShotVectorKeyframe instance) { }

public DemoShotVectorKeyframe Copy() { }

public static DemoShotVectorKeyframe Deserialize(Stream stream) { }

public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream) { }

public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length) { }

public static DemoShotVectorKeyframe Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public void WriteToStream(Stream stream) { }

public void WriteToStreamDelta(Stream stream, DemoShotVectorKeyframe previous) { }

public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotVectorKeyframe Deserialize(byte[] buffer, ref DemoShotVectorKeyframe instance, bool isDelta = False) { }

public static DemoShotVectorKeyframe Deserialize(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length, ref DemoShotVectorKeyframe instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotVectorKeyframe instance, DemoShotVectorKeyframe previous) { }

public static void Serialize(Stream stream, DemoShotVectorKeyframe instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotVectorKeyframe instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotVectorKeyframe instance) { }

}

public class DemoShotFloatTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6469
{
	public bool ShouldPool; 
	private bool _disposed; 
	public long trackType; 
	public List<DemoShotFloatKeyframe> keyframes; 


public static void ResetToPool(DemoShotFloatTrack instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DemoShotFloatTrack instance) { }

public DemoShotFloatTrack Copy() { }

public static DemoShotFloatTrack Deserialize(Stream stream) { }

public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream) { }

public static DemoShotFloatTrack DeserializeLength(Stream stream, int length) { }

public static DemoShotFloatTrack Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DemoShotFloatTrack previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotFloatTrack Deserialize(byte[] buffer, DemoShotFloatTrack instance, bool isDelta = False) { }

public static DemoShotFloatTrack Deserialize(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

public static DemoShotFloatTrack DeserializeLength(Stream stream, int length, DemoShotFloatTrack instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotFloatTrack instance, DemoShotFloatTrack previous) { }

public static void Serialize(Stream stream, DemoShotFloatTrack instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotFloatTrack instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotFloatTrack instance) { }

public void .ctor() { }

}

public struct DemoShotFloatKeyframe : IProto // TypeDefIndex: 6470
{
	public float keyframeTime; 
	public float keyFrameValue; 


public static void ResetToPool(DemoShotFloatKeyframe instance) { }

public void CopyTo(DemoShotFloatKeyframe instance) { }

public DemoShotFloatKeyframe Copy() { }

public static DemoShotFloatKeyframe Deserialize(Stream stream) { }

public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream) { }

public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length) { }

public static DemoShotFloatKeyframe Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public void WriteToStream(Stream stream) { }

public void WriteToStreamDelta(Stream stream, DemoShotFloatKeyframe previous) { }

public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotFloatKeyframe Deserialize(byte[] buffer, ref DemoShotFloatKeyframe instance, bool isDelta = False) { }

public static DemoShotFloatKeyframe Deserialize(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length, ref DemoShotFloatKeyframe instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotFloatKeyframe instance, DemoShotFloatKeyframe previous) { }

public static void Serialize(Stream stream, DemoShotFloatKeyframe instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotFloatKeyframe instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotFloatKeyframe instance) { }

}

public class DemoShotQuaternionTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6471
{
	public bool ShouldPool; 
	private bool _disposed; 
	public long trackType; 
	public List<DemoShotQuaternionKeyframe> keyframes; 


public static void ResetToPool(DemoShotQuaternionTrack instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DemoShotQuaternionTrack instance) { }

public DemoShotQuaternionTrack Copy() { }

public static DemoShotQuaternionTrack Deserialize(Stream stream) { }

public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream) { }

public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length) { }

public static DemoShotQuaternionTrack Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DemoShotQuaternionTrack previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotQuaternionTrack Deserialize(byte[] buffer, DemoShotQuaternionTrack instance, bool isDelta = False) { }

public static DemoShotQuaternionTrack Deserialize(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length, DemoShotQuaternionTrack instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotQuaternionTrack instance, DemoShotQuaternionTrack previous) { }

public static void Serialize(Stream stream, DemoShotQuaternionTrack instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotQuaternionTrack instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance) { }

public void .ctor() { }

}

public struct DemoShotQuaternionKeyframe : IProto // TypeDefIndex: 6472
{
	public float keyframeTime; 
	public float keyFrameValueX; 
	public float keyFrameValueY; 
	public float keyFrameValueZ; 
	public float keyFrameValueW; 


public static void ResetToPool(DemoShotQuaternionKeyframe instance) { }

public void CopyTo(DemoShotQuaternionKeyframe instance) { }

public DemoShotQuaternionKeyframe Copy() { }

public static DemoShotQuaternionKeyframe Deserialize(Stream stream) { }

public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream) { }

public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length) { }

public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public void WriteToStream(Stream stream) { }

public void WriteToStreamDelta(Stream stream, DemoShotQuaternionKeyframe previous) { }

public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer, ref DemoShotQuaternionKeyframe instance, bool isDelta = False) { }

public static DemoShotQuaternionKeyframe Deserialize(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotQuaternionKeyframe instance, DemoShotQuaternionKeyframe previous) { }

public static void Serialize(Stream stream, DemoShotQuaternionKeyframe instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotQuaternionKeyframe instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionKeyframe instance) { }

}

public class DemoShotParentTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6473
{
	public bool ShouldPool; 
	private bool _disposed; 
	public ulong parentId; 
	public List<DemoShotParentKeyframe> keyframes; 


public static void ResetToPool(DemoShotParentTrack instance) { }

public void ResetToPool() { }

public virtual void Dispose() { }

public virtual void EnterPool() { }

public virtual void LeavePool() { }

public void CopyTo(DemoShotParentTrack instance) { }

public DemoShotParentTrack Copy() { }

public static DemoShotParentTrack Deserialize(Stream stream) { }

public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream) { }

public static DemoShotParentTrack DeserializeLength(Stream stream, int length) { }

public static DemoShotParentTrack Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public virtual void WriteToStream(Stream stream) { }

public virtual void WriteToStreamDelta(Stream stream, DemoShotParentTrack previous) { }

public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotParentTrack Deserialize(byte[] buffer, DemoShotParentTrack instance, bool isDelta = False) { }

public static DemoShotParentTrack Deserialize(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

public static DemoShotParentTrack DeserializeLength(Stream stream, int length, DemoShotParentTrack instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotParentTrack instance, DemoShotParentTrack previous) { }

public static void Serialize(Stream stream, DemoShotParentTrack instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotParentTrack instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotParentTrack instance) { }

public void .ctor() { }

}

public struct DemoShotParentKeyframe : IProto // TypeDefIndex: 6474
{
	public float keyframeTime; 
	public uint keyFrameParentId; 
	public string keyFrameParentName; 


public static void ResetToPool(DemoShotParentKeyframe instance) { }

public void CopyTo(DemoShotParentKeyframe instance) { }

public DemoShotParentKeyframe Copy() { }

public static DemoShotParentKeyframe Deserialize(Stream stream) { }

public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream) { }

public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length) { }

public static DemoShotParentKeyframe Deserialize(byte[] buffer) { }

public void FromProto(Stream stream, bool isDelta = False) { }

public void WriteToStream(Stream stream) { }

public void WriteToStreamDelta(Stream stream, DemoShotParentKeyframe previous) { }

public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

public static DemoShotParentKeyframe Deserialize(byte[] buffer, ref DemoShotParentKeyframe instance, bool isDelta = False) { }

public static DemoShotParentKeyframe Deserialize(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length, ref DemoShotParentKeyframe instance, bool isDelta) { }

public static void SerializeDelta(Stream stream, DemoShotParentKeyframe instance, DemoShotParentKeyframe previous) { }

public static void Serialize(Stream stream, DemoShotParentKeyframe instance) { }

public byte[] ToProtoBytes() { }

public void ToProto(Stream stream) { }

public static byte[] SerializeToBytes(DemoShotParentKeyframe instance) { }

public static void SerializeLengthDelimited(Stream stream, DemoShotParentKeyframe instance) { }

}

public class DemoClient : Client, IDisposable // TypeDefIndex: 6692
{
	protected Reader demoFile; 

public override bool IsPlaying { get; }
public bool PlayingFinished { get; }


public void .ctor(Reader demoFile) { }

public virtual void Dispose() { }

public override bool IsConnected() { }

public override bool get_IsPlaying() { }

public bool get_PlayingFinished() { }

public void UpdatePlayback(long frameTime) { }

private bool PlaybackPacket() { }

private void HandleMessage(IntPtr data, int size) { }

}

public class DemoShotPlayback : MonoBehaviour // TypeDefIndex: 9178
{
	[CompilerGeneratedAttribute] 
	private DemoShot <CurrentShot>k__BackingField; 
	private bool playing; 
	public static DemoShotPlayback Instance; 
	public bool ShouldLoop; 

public DemoShot CurrentShot { get; set; }
public static bool IsPlayingShot { get; }
public float CurrentShotTime { get; }
public string CurrentShotName { get; }
public float ShotPlaybackProgress { get; }
public float ShotLength { get; }
public float ShotEndTime { get; }
public bool IsPaused { get; }
public DemoShotVectorTrack CameraPositionTrack { get; }
public float ShotStartTime { get; }
public bool HasDofData { get; }


	[CompilerGeneratedAttribute] 
public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] 
private void set_CurrentShot(DemoShot value) { }

public static bool get_IsPlayingShot() { }

public float get_CurrentShotTime() { }

public void Setup(DemoShot shot) { }

public void PlayFromStart() { }

public void PauseShot() { }

public void ResumeShot() { }

public void EndShot() { }

private void Update() { }

private void OnDrawGizmosSelected() { }

public string get_CurrentShotName() { }

public float get_ShotPlaybackProgress() { }

public float get_ShotLength() { }

public float get_ShotEndTime() { }

public bool get_IsPaused() { }

public DemoShotVectorTrack get_CameraPositionTrack() { }

public float get_ShotStartTime() { }

public bool get_HasDofData() { }

public void SetShotTime(float newTime) { }

public float ClampTimeToShotRange(float val) { }

public void .ctor() { }

private static void .cctor() { }

}

public class DemoShotRecorder : SingletonComponent<DemoShotRecorder> // TypeDefIndex: 9179
{
	private DemoShot recordingShot; 
	private float lastKeyframe; 
	private bool hasStarted; 
	[CompilerGeneratedAttribute] 
	private RealTimeUntil <CountdownEnds>k__BackingField; 
public const float CountdownDuration = 3;
	private CameraMan.CameraState startSettings; 
	private DemoShotRecorder.RecorderSettings settings; 
	public static string lastSavedShotName; 
	private string preRecordShotName; 
	private float countdownStartTime; 

public RealTimeUntil CountdownEnds { get; set; }
public bool IsInCountdown { get; }
public float CurrentShotTime { get; }
public string CurrentShotName { get; }
public float ShotStartTime { get; }


	[CompilerGeneratedAttribute] 
public RealTimeUntil get_CountdownEnds() { }

	[CompilerGeneratedAttribute] 
private void set_CountdownEnds(RealTimeUntil value) { }

public bool get_IsInCountdown() { }

public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

public float get_CurrentShotTime() { }

public string get_CurrentShotName() { }

public float get_ShotStartTime() { }

	[IteratorStateMachineAttribute] 
private IEnumerator StartRecording(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

public void CancelRecording() { }

public void FinishRecording() { }

public static string GetShotDirectory(string demoName, bool createDirectory = False) { }

public static string GetFilePath(string shotName, string demoName, string folderName, bool createDirectory = False) { }

public static Dictionary<string, List<string>> GetPathsOfAllShots(string demoName) { }

private static int SortWithTrailingNumber(string x, string y) { }

public static string GetTrailingFolder(string path) { }

private void Update() { }

private void RecordCameraState() { }

private void RecordKeyframe(Vector3 value, DemoShotVectorTrack track) { }

private void RecordKeyframe(float value, DemoShotFloatTrack track) { }

private void RecordKeyframe(Quaternion value, DemoShotQuaternionTrack track) { }

private void RecordParent(BaseEntity parent, string bone, DemoShotParentTrack track) { }

private DemoShotVectorTrack InitialiseKeyframeVectorTrack() { }

private DemoShotQuaternionTrack InitialiseKeyframeQuaternionTrack() { }

private DemoShotFloatTrack InitialiseKeyframeFloatTrack() { }

private DemoShotParentTrack InitialiseKeyframeParentTrack() { }

public void .ctor() { }

private static void .cctor() { }

}

public struct DemoShotRecorder.RecorderSettings // TypeDefIndex: 9180
{
	public bool Countdown; 
	public bool PauseOnSave; 
	public bool ReturnToShotStart; 
	public string FolderName; 
	public bool RecordDof; 

}

private sealed class DemoShotRecorder.<StartRecording>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9181
{
	private int <>1__state; 
	private object <>2__current; 
	public DemoShotRecorder <>4__this; 
	public DemoShotRecorder.RecorderSettings withSettings; 
	public string shotName; 
	private float <waitTime>5__2; 
	private float <leftover>5__3; 

private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

}

public static class DemoShotHelpers // TypeDefIndex: 9182
{

	[ExtensionAttribute] 
public static Vector3 GetVectorFromTrack(DemoShotVectorTrack track, float time) { }

	[ExtensionAttribute] 
public static Quaternion GetQuaternionFromTrack(DemoShotQuaternionTrack track, float time) { }

	[ExtensionAttribute] 
public static float GetFloatFromTrack(DemoShotFloatTrack track, float time) { }

	[ExtensionAttribute] 
public static DemoShotParentKeyframe GetParentFromTrack(DemoShotParentTrack track, float time) { }

	[ExtensionAttribute] 
public static void GetKeyframesInRange(DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] 
public static void GetKeyframesInRange(DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] 
public static void GetKeyframesInRange(DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] 
public static Quaternion ToQuaternion(DemoShotQuaternionKeyframe keyframe) { }

	[ExtensionAttribute] 
public static DemoShotQuaternionKeyframe ToKeyframe(Quaternion value, float time) { }

}

public class DemoPlaybackUI : SingletonComponent<DemoPlaybackUI> // TypeDefIndex: 10854
{
	public GameObject Root; 


private void Start() { }

public void Toggle(bool state) { }

public void .ctor() { }

}

public class DemoPlaybackWidget : MonoBehaviour // TypeDefIndex: 10855
{
	public RustSlider DemoProgress; 
	public RustText DemoName; 
	public RustText DemoDuration; 
	public RustText DemoCurrentTime; 
	public GameObject PausedRoot; 
	public GameObject PlayingRoot; 
	public RectTransform DemoPlaybackHandle; 
	public RectTransform ShotPlaybackWindow; 
	public RustButton LoopButton; 
	public GameObject ShotButtonRoot; 
	public RustText ShotNameText; 
	public GameObject ShotNameRoot; 
	public RectTransform ShotRecordWindow; 
	private bool blockProgressInput; 
	private bool isDraggingSlider; 
	private RealTimeSince lastDrag; 
	private bool pausedAtStartOfDrag; 


private void Update() { }

private void SetRectTransformAnchoredX(float xPos, RectTransform t) { }

public void OnClickedSlider(float value) { }

private void TimelineScrubCheck() { }

public void OnClickedPlay() { }

public void OnClickedPause() { }

public void OnClickedBackToStart() { }

public void OnClickedToEnd() { }

public void OnClickedLoop() { }

public void OnClickedCancelShot() { }

public void OnClickedNextFrame() { }

	[IteratorStateMachineAttribute] 
private IEnumerator WaitAndPause() { }

public void OnClickedPreviousFrame() { }

public void .ctor() { }

}

private sealed class DemoPlaybackWidget.<WaitAndPause>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10856
{
	private int <>1__state; 
	private object <>2__current; 

private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] 
public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] 
private void System.IDisposable.Dispose() { }

private bool MoveNext() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] 
private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] 
private object System.Collections.IEnumerator.get_Current() { }

}

public class DemoRootFade : MonoBehaviour // TypeDefIndex: 10857
{
	public CanvasGroup Canvas; 
	public static bool ToggleHide; 


private void Update() { }

public void .ctor() { }

private static void .cctor() { }

}

public class DemoShotButton : RustButton, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 10858
{
	public bool FireEventOnClicked; 


public override void OnPointerDown(PointerEventData eventData) { }

public override void OnPointerUp(PointerEventData eventData) { }

public void OnPointerClick(PointerEventData eventData) { }

public void .ctor() { }

}

public class DemoShotEntry : MonoBehaviour, IDraggable // TypeDefIndex: 10859
{
	public RustButton PlayButton; 
	public Sprite DragSprite; 
	public RustInput RenameInput; 
	[CompilerGeneratedAttribute] 
	private DemoShot <CurrentShot>k__BackingField; 

public DemoShot CurrentShot { get; set; }


	[CompilerGeneratedAttribute] 
public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] 
private void set_CurrentShot(DemoShot value) { }

public void Populate(DemoShot shot, string folder) { }

public void OnClicked() { }

public void StopShot() { }

public void OnClickedDelete() { }

public void TogglePlayingRoot(bool state) { }

public void PopulateRename() { }

public void ApplyRename() { }

public object GetDragData() { }

public string GetDragType() { }

public Sprite GetDragSprite() { }

public void OnDroppedValue(object data) { }

public void .ctor() { }

}

public class DemoShotListFolderWidget : MonoBehaviour // TypeDefIndex: 10860
{
	public RustButton FolderName; 
	public Transform ChildRoot; 
	public GameObject UpArrow; 
	public GameObject DownArrow; 
	public RustText CountText; 
	public GameObject OpenRoot; 
	public GameObject ModifyRoot; 
	public RustInput FolderRenameInput; 
	[CompilerGeneratedAttribute] 
	private bool <CurrentState>k__BackingField; 
	[CompilerGeneratedAttribute] 
	private string <cachedFolderName>k__BackingField; 

public bool CurrentState { get; set; }
public string cachedFolderName { get; set; }


	[CompilerGeneratedAttribute] 
public bool get_CurrentState() { }

	[CompilerGeneratedAttribute] 
private void set_CurrentState(bool value) { }

	[CompilerGeneratedAttribute] 
public string get_cachedFolderName() { }

	[CompilerGeneratedAttribute] 
private void set_cachedFolderName(string value) { }

public void Populate(string folderName, bool state) { }

public void ToggleState() { }

public void ToggleState(bool state) { }

public void AddChild(DemoShotEntry shot) { }

private void UpdateCountText() { }

public void OnDroppedValue(object data) { }

public void OnRightClick() { }

public void OnClickedDeleteFolder() { }

public void OnClickedRenameFolder() { }

public void .ctor() { }

}

public class DemoShotListRootFolder : MonoBehaviour // TypeDefIndex: 10861
{

public void OnDroppedValue(object data) { }

public void .ctor() { }

}

public class DemoShotListWidget : SingletonComponent<DemoShotListWidget> // TypeDefIndex: 10862
{
	public GameObjectRef ShotListEntry; 
	public GameObjectRef FolderEntry; 
	public Transform ShotListParent; 
	public RustInput FolderNameInput; 
	public GameObject ShotsRoot; 
	public GameObject NoShotsRoot; 
	public GameObject TopUpArrow; 
	public GameObject TopDownArrow; 
	public Canvas DragCanvas; 
	private Dictionary<string, List<DemoShot>> foundShots; 
	private List<DemoShotEntry> spawnedEntries; 
	private List<DemoShotListFolderWidget> spawnedFolders; 
	private bool isOpen; 

private int TotalShotCount { get; }


private void OnEnable() { }

public void UpdateAvailableShots() { }

public void SetCurrentlyPlaying(DemoShot shot) { }

private int get_TotalShotCount() { }

public string GetDefaultNewShotName() { }

public void DeleteShot(DemoShot shotName) { }

public void RenameShot(DemoShot shotToRename, string newName) { }

public void CreateFolder() { }

public void ToggleOpen(bool state) { }

public void ToggleOpen() { }

public List<string> GetCurrentFolders() { }

public void MoveShotToFolder(DemoShot shot, string targetFolder) { }

public void RenameFolder(string oldName, string newName) { }

public void DeleteFolder(string folderName) { }

public void .ctor() { }

}

public class DemoShotRecordWidget : MonoBehaviour // TypeDefIndex: 10863
{
	public RustInput NameInput; 
	public GameObject RecordingRoot; 
	public GameObject PreRecordingRoot; 
	public RustButton CountdownToggle; 
	public RustButton PauseOnSaveToggle; 
	public RustButton ReturnToStartToggle; 
	public RustButton RecordDofToggle; 
	public RustOption FolderDropdown; 
	public GameObject RecordingUnderlay; 
	public AudioSource CountdownAudio; 
	public GameObject ShotRecordTime; 
	public RustText ShotRecordTimeText; 
	public RustText ShotNameText; 
	public GameObject RecordingInProcessRoot; 
	public GameObject CountdownActiveRoot; 
	public GameObject CountdownActiveSliderRoot; 
	public RustSlider CountdownActiveSlider; 
	public RustText CountdownActiveText; 
	public static DemoShotRecordWidget Instance; 


private void Start() { }

private void OnEnable() { }

public void UpdateShotName() { }

private void Update() { }

public void OnClickedStartRecording() { }

public void OnClickedFinish() { }

public void Toggle(bool state) { }

public void .ctor() { }

private static void .cctor() { }

}

public class DemoText : MonoBehaviour // TypeDefIndex: 10864
{
	public RustText TimeText; 
	public RustText TotalSecondText; 
	public RustText TimeScaleText; 
	public RustText FilenameText; 
	public RustText DateTimeText; 
	public RustText ParentText; 
	public RustText DofText; 
	public GameObject InternalRoot; 
	public GameObject ParentRoot; 
	public GameObject DofRoot; 


private void Update() { }

public void .ctor() { }

}

public class DemoRecorder : SingletonComponent<DemoRecorder> // TypeDefIndex: 10869
{
	public RustInput Input; 
	public GameObject RecordingUnderlay; 
	private bool IsOpen; 


protected override void Awake() { }

public void Open() { }

public void Update() { }

public void Close() { }

public void SubmitRecord() { }

public void Record() { }

public void .ctor() { }

	[CompilerGeneratedAttribute] 
private void <Close>b__6_0() { }

}

public class DemoRecorderProgress : SingletonComponent<DemoRecorderProgress> // TypeDefIndex: 10870
{
	public RustText RecordingLabel; 
	public RustText ProgressLabel; 
	public GameObject RecordingUnderlay; 
	private CanvasGroup canvasGroup; 
	private NeedsCursor needsCursor; 


protected override void Awake() { }

public void Open(string recordingName) { }

public void Update() { }

public void Close() { }

public void EnableCursor(bool enable) { }

public void Stop() { }

public void .ctor() { }

}

public class DemoItem : RustButton // TypeDefIndex: 11098
{
	public Demos demos; 
	public int itemId; 
	public RustText nameText; 
	public RustText dateText; 
	public RustText lengthText; 


public void OnClicked() { }

protected override void ApplyStyle(StyleAsset.Group s) { }

public void .ctor() { }

}

public class Demos : SingletonComponent<Demos>, VirtualScroll.IDataSource // TypeDefIndex: 11099
{
	public VirtualScroll virtualScroll; 
	public GameObject deletePopup; 
	private readonly List<Demos.DemoInfo> _demoInfo; 
	private readonly List<Demos.DemoInfo> _sortedDemoInfo; 
	private DemoItem _selectedItem; 
	private string sortOrder; 


protected override void Awake() { }

private void DeselectItem() { }

private void Populate() { }

private void Rebuild() { }

public void OrderBy(string strBy) { }

public int GetItemCount() { }

public void SetItemData(int i, GameObject obj) { }

private IOrderedEnumerable<Demos.DemoInfo> GetSortedInfo() { }

public void OnItemClicked(DemoItem item) { }

public void OnDeleteItem() { }

public void DeleteItem() { }

public void OnPlayItem() { }

public void OpenDemosFolder() { }

public void Refresh() { }

public void .ctor() { }

}

private struct Demos.DemoInfo // TypeDefIndex: 11100
{
	public string path; 
	public string name; 
	public DateTime date; 
	public TimeSpan length; 


public void .ctor(string path, string name, DateTime date, TimeSpan length) { }

}

private sealed class Demos.<>c // TypeDefIndex: 11101
{
	public static readonly Demos.<>c <>9; 
	public static Func<Demos.DemoInfo, string> <>9__14_0; 
	public static Func<Demos.DemoInfo, string> <>9__14_1; 
	public static Func<Demos.DemoInfo, DateTime> <>9__14_2; 
	public static Func<Demos.DemoInfo, DateTime> <>9__14_3; 
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_4; 
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_5; 
	public static Func<Demos.DemoInfo, string> <>9__14_6; 


private static void .cctor() { }

public void .ctor() { }

internal string <GetSortedInfo>b__14_0(Demos.DemoInfo x) { }

internal string <GetSortedInfo>b__14_1(Demos.DemoInfo x) { }

internal DateTime <GetSortedInfo>b__14_2(Demos.DemoInfo x) { }

internal DateTime <GetSortedInfo>b__14_3(Demos.DemoInfo x) { }

internal TimeSpan <GetSortedInfo>b__14_4(Demos.DemoInfo x) { }

internal TimeSpan <GetSortedInfo>b__14_5(Demos.DemoInfo x) { }

internal string <GetSortedInfo>b__14_6(Demos.DemoInfo x) { }

}

private sealed class Demos.<>c__DisplayClass17_0 // TypeDefIndex: 11102
{
	public Demos.DemoInfo demoInfo; 


public void .ctor() { }

internal bool <DeleteItem>b__0(Demos.DemoInfo x) { }

}

public class Demo : ConsoleSystem // TypeDefIndex: 11903
{
	public static uint Version; 
	private static bool _hud; 
	[ClientVar] 
	public static float timescale; 
	private static bool renableNametags; 
	[ClientVar] 
	public static bool autoDebugCam; 
	[ClientVar] 
	public static bool compressShotKeyframes; 
	[ClientVar] 
	public static bool showLocalPlayerNameTag; 

	[ClientVar] 
public static bool hud { get; set; }
public static float TimeScale { get; }
public static string lastRecordedDemoName { get; set; }


public static bool get_hud() { }

public static void set_hud(bool value) { }

	[ClientVar] 
public static void togglehud(ConsoleSystem.Arg arg) { }

public static float get_TimeScale() { }

	[ClientVar] 
public static string record(string filename) { }

	[ClientVar] 
public static void recorder() { }

	[ClientVar] 
public static string stop() { }

	[ClientVar] 
public static string play(string filename) { }

public static void TryRunDemoCfg(string demoName) { }

	[ClientVar] 
public static string skip(float seconds) { }

	[ClientVar] 
public static string jump(float seconds) { }

	[ClientVar] 
public static string playernames() { }

	[ClientVar] 
public static void browser() { }

public static string get_lastRecordedDemoName() { }

public static void set_lastRecordedDemoName(string value) { }

	[ClientVar] 
public static string toggleNVG(ConsoleSystem.Arg args) { }

	[ClientVar] 
public static string pause() { }

	[ClientVar] 
public static string resume() { }

public static string playShot(DemoShot shot) { }

	[ClientVar] 
public static void readcfg() { }

public void .ctor() { }

private static void .cctor() { }

}

public class Demo.Header : DemoHeader, IDemoHeader // TypeDefIndex: 11904
{
private long Network.IDemoHeader.Length { get; set; }


private long Network.IDemoHeader.get_Length() { }

private void Network.IDemoHeader.set_Length(long value) { }

public void Write(BinaryWriter writer) { }

public void .ctor() { }

}

