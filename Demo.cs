public class DemoHeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6464
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public uint version; // 0x14
	public string level; // 0x18
	public uint levelSeed; // 0x20
	public uint levelSize; // 0x24
	public string checksum; // 0x28
	public ulong localclient; // 0x30
	public Vector3 position; // 0x38
	public Vector3 rotation; // 0x44
	public string levelUrl; // 0x50
	public long recordedTime; // 0x58
	public long length; // 0x60
	public List<FileStorageCacheData> fileStorage; // 0x68


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
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string shotName; // 0x18
	public string demoName; // 0x20
	public float shotStart; // 0x28
	public float shotLength; // 0x2C
	public DemoShotVectorTrack camPos; // 0x30
	public DemoShotQuaternionTrack camRot; // 0x38
	public DemoShotFloatTrack camFov; // 0x40
	public DemoShotFloatTrack camDofDist; // 0x48
	public DemoShotFloatTrack camDofFocalSize; // 0x50
	public DemoShotFloatTrack camDofAperture; // 0x58
	public DemoShotParentTrack camParent; // 0x60
	public string folderName; // 0x68


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
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotVectorKeyframe> keyframes; // 0x20


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
{	public float keyframeTime; // 0x0
	public Vector3 keyFrameValue; // 0x4


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
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotFloatKeyframe> keyframes; // 0x20


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
{	public float keyframeTime; // 0x0
	public float keyFrameValue; // 0x4


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
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotQuaternionKeyframe> keyframes; // 0x20


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
{	public float keyframeTime; // 0x0
	public float keyFrameValueX; // 0x4
	public float keyFrameValueY; // 0x8
	public float keyFrameValueZ; // 0xC
	public float keyFrameValueW; // 0x10


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
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong parentId; // 0x18
	public List<DemoShotParentKeyframe> keyframes; // 0x20


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
{	public float keyframeTime; // 0x0
	public uint keyFrameParentId; // 0x4
	public string keyFrameParentName; // 0x8


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
{	protected Reader demoFile; // 0x70

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
{	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DemoShot <CurrentShot>k__BackingField; // 0x18
	private bool playing; // 0x20
	public static DemoShotPlayback Instance; // 0x0
	public bool ShouldLoop; // 0x21

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


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	private DemoShot recordingShot; // 0x18
	private float lastKeyframe; // 0x20
	private bool hasStarted; // 0x24
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private RealTimeUntil <CountdownEnds>k__BackingField; // 0x28
	public const float CountdownDuration = 3;
	private CameraMan.CameraState startSettings; // 0x2C
	private DemoShotRecorder.RecorderSettings settings; // 0x50
	public static string lastSavedShotName; // 0x0
	private string preRecordShotName; // 0x68
	private float countdownStartTime; // 0x70

	public RealTimeUntil CountdownEnds { get; set; }
	public bool IsInCountdown { get; }
	public float CurrentShotTime { get; }
	public string CurrentShotName { get; }
	public float ShotStartTime { get; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public RealTimeUntil get_CountdownEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CountdownEnds(RealTimeUntil value) { }

	public bool get_IsInCountdown() { }

	public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	public float get_CurrentShotTime() { }

	public string get_CurrentShotName() { }

	public float get_ShotStartTime() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6470 Offset: 0xD5870 VA: 0x1800D6470
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
{	public bool Countdown; // 0x0
	public bool PauseOnSave; // 0x1
	public bool ReturnToShotStart; // 0x2
	public string FolderName; // 0x8
	public bool RecordDof; // 0x10

}

private sealed class DemoShotRecorder.<StartRecording>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9181
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DemoShotRecorder <>4__this; // 0x20
	public DemoShotRecorder.RecorderSettings withSettings; // 0x28
	public string shotName; // 0x40
	private float <waitTime>5__2; // 0x48
	private float <leftover>5__3; // 0x4C

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public static class DemoShotHelpers // TypeDefIndex: 9182
{
	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Vector3 GetVectorFromTrack(DemoShotVectorTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Quaternion GetQuaternionFromTrack(DemoShotQuaternionTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static float GetFloatFromTrack(DemoShotFloatTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static DemoShotParentKeyframe GetParentFromTrack(DemoShotParentTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void GetKeyframesInRange(DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void GetKeyframesInRange(DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static void GetKeyframesInRange(DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static Quaternion ToQuaternion(DemoShotQuaternionKeyframe keyframe) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static DemoShotQuaternionKeyframe ToKeyframe(Quaternion value, float time) { }

}

public class DemoPlaybackUI : SingletonComponent<DemoPlaybackUI> // TypeDefIndex: 10854
{	public GameObject Root; // 0x18


	private void Start() { }

	public void Toggle(bool state) { }

	public void .ctor() { }

}

public class DemoPlaybackWidget : MonoBehaviour // TypeDefIndex: 10855
{	public RustSlider DemoProgress; // 0x18
	public RustText DemoName; // 0x20
	public RustText DemoDuration; // 0x28
	public RustText DemoCurrentTime; // 0x30
	public GameObject PausedRoot; // 0x38
	public GameObject PlayingRoot; // 0x40
	public RectTransform DemoPlaybackHandle; // 0x48
	public RectTransform ShotPlaybackWindow; // 0x50
	public RustButton LoopButton; // 0x58
	public GameObject ShotButtonRoot; // 0x60
	public RustText ShotNameText; // 0x68
	public GameObject ShotNameRoot; // 0x70
	public RectTransform ShotRecordWindow; // 0x78
	private bool blockProgressInput; // 0x80
	private bool isDraggingSlider; // 0x81
	private RealTimeSince lastDrag; // 0x84
	private bool pausedAtStartOfDrag; // 0x88


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

	[IteratorStateMachineAttribute] // RVA: 0x7FDC0 Offset: 0x7F1C0 VA: 0x18007FDC0
	private IEnumerator WaitAndPause() { }

	public void OnClickedPreviousFrame() { }

	public void .ctor() { }

}

private sealed class DemoPlaybackWidget.<WaitAndPause>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10856
{	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }


	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.IDisposable.Dispose() { }

	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private object System.Collections.IEnumerator.get_Current() { }

}

public class DemoRootFade : MonoBehaviour // TypeDefIndex: 10857
{	public CanvasGroup Canvas; // 0x18
	public static bool ToggleHide; // 0x0


	private void Update() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class DemoShotButton : RustButton, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 10858
{	public bool FireEventOnClicked; // 0x98


	public override void OnPointerDown(PointerEventData eventData) { }

	public override void OnPointerUp(PointerEventData eventData) { }

	public void OnPointerClick(PointerEventData eventData) { }

	public void .ctor() { }

}

public class DemoShotEntry : MonoBehaviour, IDraggable // TypeDefIndex: 10859
{	public RustButton PlayButton; // 0x18
	public Sprite DragSprite; // 0x20
	public RustInput RenameInput; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DemoShot <CurrentShot>k__BackingField; // 0x30

	public DemoShot CurrentShot { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public RustButton FolderName; // 0x18
	public Transform ChildRoot; // 0x20
	public GameObject UpArrow; // 0x28
	public GameObject DownArrow; // 0x30
	public RustText CountText; // 0x38
	public GameObject OpenRoot; // 0x40
	public GameObject ModifyRoot; // 0x48
	public RustInput FolderRenameInput; // 0x50
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private bool <CurrentState>k__BackingField; // 0x58
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private string <cachedFolderName>k__BackingField; // 0x60

	public bool CurrentState { get; set; }
	public string cachedFolderName { get; set; }


	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public bool get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void set_CurrentState(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public string get_cachedFolderName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
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
{	public GameObjectRef ShotListEntry; // 0x18
	public GameObjectRef FolderEntry; // 0x20
	public Transform ShotListParent; // 0x28
	public RustInput FolderNameInput; // 0x30
	public GameObject ShotsRoot; // 0x38
	public GameObject NoShotsRoot; // 0x40
	public GameObject TopUpArrow; // 0x48
	public GameObject TopDownArrow; // 0x50
	public Canvas DragCanvas; // 0x58
	private Dictionary<string, List<DemoShot>> foundShots; // 0x60
	private List<DemoShotEntry> spawnedEntries; // 0x68
	private List<DemoShotListFolderWidget> spawnedFolders; // 0x70
	private bool isOpen; // 0x78

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
{	public RustInput NameInput; // 0x18
	public GameObject RecordingRoot; // 0x20
	public GameObject PreRecordingRoot; // 0x28
	public RustButton CountdownToggle; // 0x30
	public RustButton PauseOnSaveToggle; // 0x38
	public RustButton ReturnToStartToggle; // 0x40
	public RustButton RecordDofToggle; // 0x48
	public RustOption FolderDropdown; // 0x50
	public GameObject RecordingUnderlay; // 0x58
	public AudioSource CountdownAudio; // 0x60
	public GameObject ShotRecordTime; // 0x68
	public RustText ShotRecordTimeText; // 0x70
	public RustText ShotNameText; // 0x78
	public GameObject RecordingInProcessRoot; // 0x80
	public GameObject CountdownActiveRoot; // 0x88
	public GameObject CountdownActiveSliderRoot; // 0x90
	public RustSlider CountdownActiveSlider; // 0x98
	public RustText CountdownActiveText; // 0xA0
	public static DemoShotRecordWidget Instance; // 0x0


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
{	public RustText TimeText; // 0x18
	public RustText TotalSecondText; // 0x20
	public RustText TimeScaleText; // 0x28
	public RustText FilenameText; // 0x30
	public RustText DateTimeText; // 0x38
	public RustText ParentText; // 0x40
	public RustText DofText; // 0x48
	public GameObject InternalRoot; // 0x50
	public GameObject ParentRoot; // 0x58
	public GameObject DofRoot; // 0x60


	private void Update() { }

	public void .ctor() { }

}

public class DemoRecorder : SingletonComponent<DemoRecorder> // TypeDefIndex: 10869
{	public RustInput Input; // 0x18
	public GameObject RecordingUnderlay; // 0x20
	private bool IsOpen; // 0x28


	protected override void Awake() { }

	public void Open() { }

	public void Update() { }

	public void Close() { }

	public void SubmitRecord() { }

	public void Record() { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private void <Close>b__6_0() { }

}

public class DemoRecorderProgress : SingletonComponent<DemoRecorderProgress> // TypeDefIndex: 10870
{	public RustText RecordingLabel; // 0x18
	public RustText ProgressLabel; // 0x20
	public GameObject RecordingUnderlay; // 0x28
	private CanvasGroup canvasGroup; // 0x30
	private NeedsCursor needsCursor; // 0x38


	protected override void Awake() { }

	public void Open(string recordingName) { }

	public void Update() { }

	public void Close() { }

	public void EnableCursor(bool enable) { }

	public void Stop() { }

	public void .ctor() { }

}

public class DemoItem : RustButton // TypeDefIndex: 11098
{	public Demos demos; // 0x98
	public int itemId; // 0xA0
	public RustText nameText; // 0xA8
	public RustText dateText; // 0xB0
	public RustText lengthText; // 0xB8


	public void OnClicked() { }

	protected override void ApplyStyle(StyleAsset.Group s) { }

	public void .ctor() { }

}

public class Demos : SingletonComponent<Demos>, VirtualScroll.IDataSource // TypeDefIndex: 11099
{	public VirtualScroll virtualScroll; // 0x18
	public GameObject deletePopup; // 0x20
	private readonly List<Demos.DemoInfo> _demoInfo; // 0x28
	private readonly List<Demos.DemoInfo> _sortedDemoInfo; // 0x30
	private DemoItem _selectedItem; // 0x38
	private string sortOrder; // 0x40


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
{	public string path; // 0x0
	public string name; // 0x8
	public DateTime date; // 0x10
	public TimeSpan length; // 0x18


	public void .ctor(string path, string name, DateTime date, TimeSpan length) { }

}

private sealed class Demos.<>c // TypeDefIndex: 11101
{	public static readonly Demos.<>c <>9; // 0x0
	public static Func<Demos.DemoInfo, string> <>9__14_0; // 0x8
	public static Func<Demos.DemoInfo, string> <>9__14_1; // 0x10
	public static Func<Demos.DemoInfo, DateTime> <>9__14_2; // 0x18
	public static Func<Demos.DemoInfo, DateTime> <>9__14_3; // 0x20
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_4; // 0x28
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_5; // 0x30
	public static Func<Demos.DemoInfo, string> <>9__14_6; // 0x38


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
{	public Demos.DemoInfo demoInfo; // 0x10


	public void .ctor() { }

	internal bool <DeleteItem>b__0(Demos.DemoInfo x) { }

}

public class Demo : ConsoleSystem // TypeDefIndex: 11903
{	public static uint Version; // 0x0
	private static bool _hud; // 0x4
	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static float timescale; // 0x8
	private static bool renableNametags; // 0xC
	[ClientVar] // RVA: 0x95F00 Offset: 0x95300 VA: 0x180095F00
	public static bool autoDebugCam; // 0xD
	[ClientVar] // RVA: 0x96010 Offset: 0x95410 VA: 0x180096010
	public static bool compressShotKeyframes; // 0xE
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool showLocalPlayerNameTag; // 0xF

	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool hud { get; set; }
	public static float TimeScale { get; }
	public static string lastRecordedDemoName { get; set; }


	public static bool get_hud() { }

	public static void set_hud(bool value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static void togglehud(ConsoleSystem.Arg arg) { }

	public static float get_TimeScale() { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	public static string record(string filename) { }

	[ClientVar] // RVA: 0x96230 Offset: 0x95630 VA: 0x180096230
	public static void recorder() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string stop() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	public static string play(string filename) { }

	public static void TryRunDemoCfg(string demoName) { }

	[ClientVar] // RVA: 0x96400 Offset: 0x95800 VA: 0x180096400
	public static string skip(float seconds) { }

	[ClientVar] // RVA: 0x964D0 Offset: 0x958D0 VA: 0x1800964D0
	public static string jump(float seconds) { }

	[ClientVar] // RVA: 0x96610 Offset: 0x95A10 VA: 0x180096610
	public static string playernames() { }

	[ClientVar] // RVA: 0x96730 Offset: 0x95B30 VA: 0x180096730
	public static void browser() { }

	public static string get_lastRecordedDemoName() { }

	public static void set_lastRecordedDemoName(string value) { }

	[ClientVar] // RVA: 0x96900 Offset: 0x95D00 VA: 0x180096900
	public static string toggleNVG(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x96970 Offset: 0x95D70 VA: 0x180096970
	public static string pause() { }

	[ClientVar] // RVA: 0x969F0 Offset: 0x95DF0 VA: 0x1800969F0
	public static string resume() { }

	public static string playShot(DemoShot shot) { }

	[ClientVar] // RVA: 0x96B10 Offset: 0x95F10 VA: 0x180096B10
	public static void readcfg() { }

	public void .ctor() { }

	private static void .cctor() { }

}

public class Demo.Header : DemoHeader, IDemoHeader // TypeDefIndex: 11904
{	private long Network.IDemoHeader.Length { get; set; }


	private long Network.IDemoHeader.get_Length() { }

	private void Network.IDemoHeader.set_Length(long value) { }

	public void Write(BinaryWriter writer) { }

	public void .ctor() { }

}

