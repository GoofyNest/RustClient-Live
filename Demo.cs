public class DemoHeader : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6464
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1E5B510 Offset: 0x1E5A910 VA: 0x181E5B510
	public static void ResetToPool(DemoHeader instance) { }

	// RVA: 0x1E5B240 Offset: 0x1E5A640 VA: 0x181E5B240
	public void ResetToPool() { }

	// RVA: 0x1E5B180 Offset: 0x1E5A580 VA: 0x181E5B180 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E59B30 Offset: 0x1E58F30 VA: 0x181E59B30
	public void CopyTo(DemoHeader instance) { }

	// RVA: 0x1E59CD0 Offset: 0x1E590D0 VA: 0x181E59CD0
	public DemoHeader Copy() { }

	// RVA: 0x1E5AB50 Offset: 0x1E59F50 VA: 0x181E5AB50
	public static DemoHeader Deserialize(Stream stream) { }

	// RVA: 0x1E59EC0 Offset: 0x1E592C0 VA: 0x181E59EC0
	public static DemoHeader DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5A4A0 Offset: 0x1E598A0 VA: 0x181E5A4A0
	public static DemoHeader DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5ABD0 Offset: 0x1E59FD0 VA: 0x181E5ABD0
	public static DemoHeader Deserialize(byte[] buffer) { }

	// RVA: 0x1E5B200 Offset: 0x1E5A600 VA: 0x181E5B200
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5C7D0 Offset: 0x1E5BBD0 VA: 0x181E5C7D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5C7F0 Offset: 0x1E5BBF0 VA: 0x181E5C7F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoHeader previous) { }

	// RVA: 0x1E5B220 Offset: 0x1E5A620 VA: 0x181E5B220 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5AA50 Offset: 0x1E59E50 VA: 0x181E5AA50
	public static DemoHeader Deserialize(byte[] buffer, DemoHeader instance, bool isDelta = False) { }

	// RVA: 0x1E5ACF0 Offset: 0x1E5A0F0 VA: 0x181E5ACF0
	public static DemoHeader Deserialize(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E59F40 Offset: 0x1E59340 VA: 0x181E59F40
	public static DemoHeader DeserializeLengthDelimited(Stream stream, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5A530 Offset: 0x1E59930 VA: 0x181E5A530
	public static DemoHeader DeserializeLength(Stream stream, int length, DemoHeader instance, bool isDelta) { }

	// RVA: 0x1E5B7D0 Offset: 0x1E5ABD0 VA: 0x181E5B7D0
	public static void SerializeDelta(Stream stream, DemoHeader instance, DemoHeader previous) { }

	// RVA: 0x1E5C1E0 Offset: 0x1E5B5E0 VA: 0x181E5C1E0
	public static void Serialize(Stream stream, DemoHeader instance) { }

	// RVA: 0x1E5C7C0 Offset: 0x1E5BBC0 VA: 0x181E5C7C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5C7D0 Offset: 0x1E5BBD0 VA: 0x181E5C7D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5C0D0 Offset: 0x1E5B4D0 VA: 0x181E5C0D0
	public static byte[] SerializeToBytes(DemoHeader instance) { }

	// RVA: 0x1E5C020 Offset: 0x1E5B420 VA: 0x181E5C020
	public static void SerializeLengthDelimited(Stream stream, DemoHeader instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class DemoShot : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6466
{	// Fields
	public bool ShouldPool; // 0x10
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

	// Methods

	// RVA: 0x1E678B0 Offset: 0x1E66CB0 VA: 0x181E678B0
	public static void ResetToPool(DemoShot instance) { }

	// RVA: 0x1E67B60 Offset: 0x1E66F60 VA: 0x181E67B60
	public void ResetToPool() { }

	// RVA: 0x1E677F0 Offset: 0x1E66BF0 VA: 0x181E677F0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E66190 Offset: 0x1E65590 VA: 0x181E66190
	public void CopyTo(DemoShot instance) { }

	// RVA: 0x1E664B0 Offset: 0x1E658B0 VA: 0x181E664B0
	public DemoShot Copy() { }

	// RVA: 0x1E670D0 Offset: 0x1E664D0 VA: 0x181E670D0
	public static DemoShot Deserialize(Stream stream) { }

	// RVA: 0x1E66530 Offset: 0x1E65930 VA: 0x181E66530
	public static DemoShot DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E67040 Offset: 0x1E66440 VA: 0x181E67040
	public static DemoShot DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E67150 Offset: 0x1E66550 VA: 0x181E67150
	public static DemoShot Deserialize(byte[] buffer) { }

	// RVA: 0x1E67870 Offset: 0x1E66C70 VA: 0x181E67870
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E692D0 Offset: 0x1E686D0 VA: 0x181E692D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E692F0 Offset: 0x1E686F0 VA: 0x181E692F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShot previous) { }

	// RVA: 0x1E67890 Offset: 0x1E66C90 VA: 0x181E67890 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E67270 Offset: 0x1E66670 VA: 0x181E67270
	public static DemoShot Deserialize(byte[] buffer, DemoShot instance, bool isDelta = False) { }

	// RVA: 0x1E67370 Offset: 0x1E66770 VA: 0x181E67370
	public static DemoShot Deserialize(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E665B0 Offset: 0x1E659B0 VA: 0x181E665B0
	public static DemoShot DeserializeLengthDelimited(Stream stream, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E66B10 Offset: 0x1E65F10 VA: 0x181E66B10
	public static DemoShot DeserializeLength(Stream stream, int length, DemoShot instance, bool isDelta) { }

	// RVA: 0x1E67E10 Offset: 0x1E67210 VA: 0x181E67E10
	public static void SerializeDelta(Stream stream, DemoShot instance, DemoShot previous) { }

	// RVA: 0x1E689C0 Offset: 0x1E67DC0 VA: 0x181E689C0
	public static void Serialize(Stream stream, DemoShot instance) { }

	// RVA: 0x1E692C0 Offset: 0x1E686C0 VA: 0x181E692C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E692D0 Offset: 0x1E686D0 VA: 0x181E692D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E688B0 Offset: 0x1E67CB0 VA: 0x181E688B0
	public static byte[] SerializeToBytes(DemoShot instance) { }

	// RVA: 0x1E68800 Offset: 0x1E67C00 VA: 0x181E68800
	public static void SerializeLengthDelimited(Stream stream, DemoShot instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class DemoShotVectorTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6467
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotVectorKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E659F0 Offset: 0x1E64DF0 VA: 0x181E659F0
	public static void ResetToPool(DemoShotVectorTrack instance) { }

	// RVA: 0x1E65900 Offset: 0x1E64D00 VA: 0x181E65900
	public void ResetToPool() { }

	// RVA: 0x1E65840 Offset: 0x1E64C40 VA: 0x181E65840 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E64B40 Offset: 0x1E63F40 VA: 0x181E64B40
	public void CopyTo(DemoShotVectorTrack instance) { }

	// RVA: 0x1E64C80 Offset: 0x1E64080 VA: 0x181E64C80
	public DemoShotVectorTrack Copy() { }

	// RVA: 0x1E657C0 Offset: 0x1E64BC0 VA: 0x181E657C0
	public static DemoShotVectorTrack Deserialize(Stream stream) { }

	// RVA: 0x1E64FE0 Offset: 0x1E643E0 VA: 0x181E64FE0
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E65060 Offset: 0x1E64460 VA: 0x181E65060
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E656A0 Offset: 0x1E64AA0 VA: 0x181E656A0
	public static DemoShotVectorTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E658C0 Offset: 0x1E64CC0 VA: 0x181E658C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E66150 Offset: 0x1E65550 VA: 0x181E66150 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E66170 Offset: 0x1E65570 VA: 0x181E66170 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotVectorTrack previous) { }

	// RVA: 0x1E658E0 Offset: 0x1E64CE0 VA: 0x181E658E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E653A0 Offset: 0x1E647A0 VA: 0x181E653A0
	public static DemoShotVectorTrack Deserialize(byte[] buffer, DemoShotVectorTrack instance, bool isDelta = False) { }

	// RVA: 0x1E654A0 Offset: 0x1E648A0 VA: 0x181E654A0
	public static DemoShotVectorTrack Deserialize(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E64D00 Offset: 0x1E64100 VA: 0x181E64D00
	public static DemoShotVectorTrack DeserializeLengthDelimited(Stream stream, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E650F0 Offset: 0x1E644F0 VA: 0x181E650F0
	public static DemoShotVectorTrack DeserializeLength(Stream stream, int length, DemoShotVectorTrack instance, bool isDelta) { }

	// RVA: 0x1E65AE0 Offset: 0x1E64EE0 VA: 0x181E65AE0
	public static void SerializeDelta(Stream stream, DemoShotVectorTrack instance, DemoShotVectorTrack previous) { }

	// RVA: 0x1E65F00 Offset: 0x1E65300 VA: 0x181E65F00
	public static void Serialize(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x1E66140 Offset: 0x1E65540 VA: 0x181E66140
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E66150 Offset: 0x1E65550 VA: 0x181E66150
	public void ToProto(Stream stream) { }

	// RVA: 0x1E65DF0 Offset: 0x1E651F0 VA: 0x181E65DF0
	public static byte[] SerializeToBytes(DemoShotVectorTrack instance) { }

	// RVA: 0x1E65D40 Offset: 0x1E65140 VA: 0x181E65D40
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorTrack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public struct DemoShotVectorKeyframe : IProto // TypeDefIndex: 6468
{	// Fields
	public float keyframeTime; // 0x0
	public Vector3 keyFrameValue; // 0x4

	// Methods

	// RVA: 0x18B67F0 Offset: 0x18B5BF0 VA: 0x1818B67F0
	public static void ResetToPool(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void CopyTo(DemoShotVectorKeyframe instance) { }

	// RVA: 0xF2B30 Offset: 0xF1F30 VA: 0x1800F2B30
	public DemoShotVectorKeyframe Copy() { }

	// RVA: 0x1E64520 Offset: 0x1E63920 VA: 0x181E64520
	public static DemoShotVectorKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E63C50 Offset: 0x1E63050 VA: 0x181E63C50
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E63EF0 Offset: 0x1E632F0 VA: 0x181E63EF0
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E64170 Offset: 0x1E63570 VA: 0x181E64170
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231CE0 Offset: 0x2310E0 VA: 0x180231CE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231D60 Offset: 0x231160 VA: 0x180231D60 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231D90 Offset: 0x231190 VA: 0x180231D90
	public void WriteToStreamDelta(Stream stream, DemoShotVectorKeyframe previous) { }

	// RVA: 0x231D10 Offset: 0x231110 VA: 0x180231D10 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E643F0 Offset: 0x1E637F0 VA: 0x181E643F0
	public static DemoShotVectorKeyframe Deserialize(byte[] buffer, ref DemoShotVectorKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E64270 Offset: 0x1E63670 VA: 0x181E64270
	public static DemoShotVectorKeyframe Deserialize(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E63C90 Offset: 0x1E63090 VA: 0x181E63C90
	public static DemoShotVectorKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E63F30 Offset: 0x1E63330 VA: 0x181E63F30
	public static DemoShotVectorKeyframe DeserializeLength(Stream stream, int length, ref DemoShotVectorKeyframe instance, bool isDelta) { }

	// RVA: 0x1E64560 Offset: 0x1E63960 VA: 0x181E64560
	public static void SerializeDelta(Stream stream, DemoShotVectorKeyframe instance, DemoShotVectorKeyframe previous) { }

	// RVA: 0x1E649B0 Offset: 0x1E63DB0 VA: 0x181E649B0
	public static void Serialize(Stream stream, DemoShotVectorKeyframe instance) { }

	// RVA: 0x231D40 Offset: 0x231140 VA: 0x180231D40
	public byte[] ToProtoBytes() { }

	// RVA: 0x231D60 Offset: 0x231160 VA: 0x180231D60
	public void ToProto(Stream stream) { }

	// RVA: 0x1E64890 Offset: 0x1E63C90 VA: 0x181E64890
	public static byte[] SerializeToBytes(DemoShotVectorKeyframe instance) { }

	// RVA: 0x1E647E0 Offset: 0x1E63BE0 VA: 0x181E647E0
	public static void SerializeLengthDelimited(Stream stream, DemoShotVectorKeyframe instance) { }

}

public class DemoShotFloatTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6469
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotFloatKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E5E500 Offset: 0x1E5D900 VA: 0x181E5E500
	public static void ResetToPool(DemoShotFloatTrack instance) { }

	// RVA: 0x1E5E5F0 Offset: 0x1E5D9F0 VA: 0x181E5E5F0
	public void ResetToPool() { }

	// RVA: 0x1E5E440 Offset: 0x1E5D840 VA: 0x181E5E440 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5D460 Offset: 0x1E5C860 VA: 0x181E5D460
	public void CopyTo(DemoShotFloatTrack instance) { }

	// RVA: 0x1E5D570 Offset: 0x1E5C970 VA: 0x181E5D570
	public DemoShotFloatTrack Copy() { }

	// RVA: 0x1E5DF60 Offset: 0x1E5D360 VA: 0x181E5DF60
	public static DemoShotFloatTrack Deserialize(Stream stream) { }

	// RVA: 0x1E5D8C0 Offset: 0x1E5CCC0 VA: 0x181E5D8C0
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5D940 Offset: 0x1E5CD40 VA: 0x181E5D940
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5E180 Offset: 0x1E5D580 VA: 0x181E5E180
	public static DemoShotFloatTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E5E4C0 Offset: 0x1E5D8C0 VA: 0x181E5E4C0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E5ED20 Offset: 0x1E5E120 VA: 0x181E5ED20 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E5ED40 Offset: 0x1E5E140 VA: 0x181E5ED40 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotFloatTrack previous) { }

	// RVA: 0x1E5E4E0 Offset: 0x1E5D8E0 VA: 0x181E5E4E0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5DE60 Offset: 0x1E5D260 VA: 0x181E5DE60
	public static DemoShotFloatTrack Deserialize(byte[] buffer, DemoShotFloatTrack instance, bool isDelta = False) { }

	// RVA: 0x1E5DC70 Offset: 0x1E5D070 VA: 0x181E5DC70
	public static DemoShotFloatTrack Deserialize(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E5D5F0 Offset: 0x1E5C9F0 VA: 0x181E5D5F0
	public static DemoShotFloatTrack DeserializeLengthDelimited(Stream stream, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E5D9D0 Offset: 0x1E5CDD0 VA: 0x181E5D9D0
	public static DemoShotFloatTrack DeserializeLength(Stream stream, int length, DemoShotFloatTrack instance, bool isDelta) { }

	// RVA: 0x1E5E6E0 Offset: 0x1E5DAE0 VA: 0x181E5E6E0
	public static void SerializeDelta(Stream stream, DemoShotFloatTrack instance, DemoShotFloatTrack previous) { }

	// RVA: 0x1E5EAE0 Offset: 0x1E5DEE0 VA: 0x181E5EAE0
	public static void Serialize(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x1E5ED10 Offset: 0x1E5E110 VA: 0x181E5ED10
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E5ED20 Offset: 0x1E5E120 VA: 0x181E5ED20
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5E9D0 Offset: 0x1E5DDD0 VA: 0x181E5E9D0
	public static byte[] SerializeToBytes(DemoShotFloatTrack instance) { }

	// RVA: 0x1E5E920 Offset: 0x1E5DD20 VA: 0x181E5E920
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatTrack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public struct DemoShotFloatKeyframe : IProto // TypeDefIndex: 6470
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValue; // 0x4

	// Methods

	// RVA: 0x1E46F40 Offset: 0x1E46340 VA: 0x181E46F40
	public static void ResetToPool(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void CopyTo(DemoShotFloatKeyframe instance) { }

	// RVA: 0xF21A0 Offset: 0xF15A0 VA: 0x1800F21A0
	public DemoShotFloatKeyframe Copy() { }

	// RVA: 0x1E5CEC0 Offset: 0x1E5C2C0 VA: 0x181E5CEC0
	public static DemoShotFloatKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E5C810 Offset: 0x1E5BC10 VA: 0x181E5C810
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5CCA0 Offset: 0x1E5C0A0 VA: 0x181E5CCA0
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5CCD0 Offset: 0x1E5C0D0 VA: 0x181E5CCD0
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231960 Offset: 0x230D60 VA: 0x180231960
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x2319C0 Offset: 0x230DC0 VA: 0x1802319C0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x2319E0 Offset: 0x230DE0 VA: 0x1802319E0
	public void WriteToStreamDelta(Stream stream, DemoShotFloatKeyframe previous) { }

	// RVA: 0x231980 Offset: 0x230D80 VA: 0x180231980 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5CDC0 Offset: 0x1E5C1C0 VA: 0x181E5CDC0
	public static DemoShotFloatKeyframe Deserialize(byte[] buffer, ref DemoShotFloatKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E5CEF0 Offset: 0x1E5C2F0 VA: 0x181E5CEF0
	public static DemoShotFloatKeyframe Deserialize(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E5C840 Offset: 0x1E5BC40 VA: 0x181E5C840
	public static DemoShotFloatKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E5CA80 Offset: 0x1E5BE80 VA: 0x181E5CA80
	public static DemoShotFloatKeyframe DeserializeLength(Stream stream, int length, ref DemoShotFloatKeyframe instance, bool isDelta) { }

	// RVA: 0x1E5D060 Offset: 0x1E5C460 VA: 0x181E5D060
	public static void SerializeDelta(Stream stream, DemoShotFloatKeyframe instance, DemoShotFloatKeyframe previous) { }

	// RVA: 0x1E5D380 Offset: 0x1E5C780 VA: 0x181E5D380
	public static void Serialize(Stream stream, DemoShotFloatKeyframe instance) { }

	// RVA: 0x2319A0 Offset: 0x230DA0 VA: 0x1802319A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x2319C0 Offset: 0x230DC0 VA: 0x1802319C0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5D260 Offset: 0x1E5C660 VA: 0x181E5D260
	public static byte[] SerializeToBytes(DemoShotFloatKeyframe instance) { }

	// RVA: 0x1E5D1B0 Offset: 0x1E5C5B0 VA: 0x181E5D1B0
	public static void SerializeLengthDelimited(Stream stream, DemoShotFloatKeyframe instance) { }

}

public class DemoShotQuaternionTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6471
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public long trackType; // 0x18
	public List<DemoShotQuaternionKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E63380 Offset: 0x1E62780 VA: 0x181E63380
	public static void ResetToPool(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E63470 Offset: 0x1E62870 VA: 0x181E63470
	public void ResetToPool() { }

	// RVA: 0x1E632C0 Offset: 0x1E626C0 VA: 0x181E632C0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E62580 Offset: 0x1E61980 VA: 0x181E62580
	public void CopyTo(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E62690 Offset: 0x1E61A90 VA: 0x181E62690
	public DemoShotQuaternionTrack Copy() { }

	// RVA: 0x1E63240 Offset: 0x1E62640 VA: 0x181E63240
	public static DemoShotQuaternionTrack Deserialize(Stream stream) { }

	// RVA: 0x1E62A10 Offset: 0x1E61E10 VA: 0x181E62A10
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E62D70 Offset: 0x1E62170 VA: 0x181E62D70
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E62E00 Offset: 0x1E62200 VA: 0x181E62E00
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E63340 Offset: 0x1E62740 VA: 0x181E63340
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E63C10 Offset: 0x1E63010 VA: 0x181E63C10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E63C30 Offset: 0x1E63030 VA: 0x181E63C30 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E63360 Offset: 0x1E62760 VA: 0x181E63360 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E62F20 Offset: 0x1E62320 VA: 0x181E62F20
	public static DemoShotQuaternionTrack Deserialize(byte[] buffer, DemoShotQuaternionTrack instance, bool isDelta = False) { }

	// RVA: 0x1E63020 Offset: 0x1E62420 VA: 0x181E63020
	public static DemoShotQuaternionTrack Deserialize(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E62710 Offset: 0x1E61B10 VA: 0x181E62710
	public static DemoShotQuaternionTrack DeserializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E62A90 Offset: 0x1E61E90 VA: 0x181E62A90
	public static DemoShotQuaternionTrack DeserializeLength(Stream stream, int length, DemoShotQuaternionTrack instance, bool isDelta) { }

	// RVA: 0x1E63560 Offset: 0x1E62960 VA: 0x181E63560
	public static void SerializeDelta(Stream stream, DemoShotQuaternionTrack instance, DemoShotQuaternionTrack previous) { }

	// RVA: 0x1E639A0 Offset: 0x1E62DA0 VA: 0x181E639A0
	public static void Serialize(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E63C00 Offset: 0x1E63000 VA: 0x181E63C00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E63C10 Offset: 0x1E63010 VA: 0x181E63C10
	public void ToProto(Stream stream) { }

	// RVA: 0x1E63890 Offset: 0x1E62C90 VA: 0x181E63890
	public static byte[] SerializeToBytes(DemoShotQuaternionTrack instance) { }

	// RVA: 0x1E637E0 Offset: 0x1E62BE0 VA: 0x181E637E0
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionTrack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public struct DemoShotQuaternionKeyframe : IProto // TypeDefIndex: 6472
{	// Fields
	public float keyframeTime; // 0x0
	public float keyFrameValueX; // 0x4
	public float keyFrameValueY; // 0x8
	public float keyFrameValueZ; // 0xC
	public float keyFrameValueW; // 0x10

	// Methods

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	public static void ResetToPool(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0xF1DA0 Offset: 0xF11A0 VA: 0x1800F1DA0
	public void CopyTo(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231BC0 Offset: 0x230FC0 VA: 0x180231BC0
	public DemoShotQuaternionKeyframe Copy() { }

	// RVA: 0x1E61A60 Offset: 0x1E60E60 VA: 0x181E61A60
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E613C0 Offset: 0x1E607C0 VA: 0x181E613C0
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E61720 Offset: 0x1E60B20 VA: 0x181E61720
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E61BD0 Offset: 0x1E60FD0 VA: 0x181E61BD0
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231BD0 Offset: 0x230FD0 VA: 0x180231BD0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231C90 Offset: 0x231090 VA: 0x180231C90
	public void WriteToStreamDelta(Stream stream, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x231C00 Offset: 0x231000 VA: 0x180231C00 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E61AA0 Offset: 0x1E60EA0 VA: 0x181E61AA0
	public static DemoShotQuaternionKeyframe Deserialize(byte[] buffer, ref DemoShotQuaternionKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E61CE0 Offset: 0x1E610E0 VA: 0x181E61CE0
	public static DemoShotQuaternionKeyframe Deserialize(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61400 Offset: 0x1E60800 VA: 0x181E61400
	public static DemoShotQuaternionKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61760 Offset: 0x1E60B60 VA: 0x181E61760
	public static DemoShotQuaternionKeyframe DeserializeLength(Stream stream, int length, ref DemoShotQuaternionKeyframe instance, bool isDelta) { }

	// RVA: 0x1E61F20 Offset: 0x1E61320 VA: 0x181E61F20
	public static void SerializeDelta(Stream stream, DemoShotQuaternionKeyframe instance, DemoShotQuaternionKeyframe previous) { }

	// RVA: 0x1E623F0 Offset: 0x1E617F0 VA: 0x181E623F0
	public static void Serialize(Stream stream, DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x231C30 Offset: 0x231030 VA: 0x180231C30
	public byte[] ToProtoBytes() { }

	// RVA: 0x231C60 Offset: 0x231060 VA: 0x180231C60
	public void ToProto(Stream stream) { }

	// RVA: 0x1E622C0 Offset: 0x1E616C0 VA: 0x181E622C0
	public static byte[] SerializeToBytes(DemoShotQuaternionKeyframe instance) { }

	// RVA: 0x1E62200 Offset: 0x1E61600 VA: 0x181E62200
	public static void SerializeLengthDelimited(Stream stream, DemoShotQuaternionKeyframe instance) { }

}

public class DemoShotParentTrack : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6473
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public ulong parentId; // 0x18
	public List<DemoShotParentKeyframe> keyframes; // 0x20

	// Methods

	// RVA: 0x1E60B20 Offset: 0x1E5FF20 VA: 0x181E60B20
	public static void ResetToPool(DemoShotParentTrack instance) { }

	// RVA: 0x1E60C10 Offset: 0x1E60010 VA: 0x181E60C10
	public void ResetToPool() { }

	// RVA: 0x1E60A60 Offset: 0x1E5FE60 VA: 0x181E60A60 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1E5FD10 Offset: 0x1E5F110 VA: 0x181E5FD10
	public void CopyTo(DemoShotParentTrack instance) { }

	// RVA: 0x1E5FEA0 Offset: 0x1E5F2A0 VA: 0x181E5FEA0
	public DemoShotParentTrack Copy() { }

	// RVA: 0x1E607E0 Offset: 0x1E5FBE0 VA: 0x181E607E0
	public static DemoShotParentTrack Deserialize(Stream stream) { }

	// RVA: 0x1E5FF20 Offset: 0x1E5F320 VA: 0x181E5FF20
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E60280 Offset: 0x1E5F680 VA: 0x181E60280
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E606C0 Offset: 0x1E5FAC0 VA: 0x181E606C0
	public static DemoShotParentTrack Deserialize(byte[] buffer) { }

	// RVA: 0x1E60AE0 Offset: 0x1E5FEE0 VA: 0x181E60AE0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1E61380 Offset: 0x1E60780 VA: 0x181E61380 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1E613A0 Offset: 0x1E607A0 VA: 0x181E613A0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, DemoShotParentTrack previous) { }

	// RVA: 0x1E60B00 Offset: 0x1E5FF00 VA: 0x181E60B00 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E605C0 Offset: 0x1E5F9C0 VA: 0x181E605C0
	public static DemoShotParentTrack Deserialize(byte[] buffer, DemoShotParentTrack instance, bool isDelta = False) { }

	// RVA: 0x1E60860 Offset: 0x1E5FC60 VA: 0x181E60860
	public static DemoShotParentTrack Deserialize(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E5FFA0 Offset: 0x1E5F3A0 VA: 0x181E5FFA0
	public static DemoShotParentTrack DeserializeLengthDelimited(Stream stream, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E60310 Offset: 0x1E5F710 VA: 0x181E60310
	public static DemoShotParentTrack DeserializeLength(Stream stream, int length, DemoShotParentTrack instance, bool isDelta) { }

	// RVA: 0x1E60D00 Offset: 0x1E60100 VA: 0x181E60D00
	public static void SerializeDelta(Stream stream, DemoShotParentTrack instance, DemoShotParentTrack previous) { }

	// RVA: 0x1E61130 Offset: 0x1E60530 VA: 0x181E61130
	public static void Serialize(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x1E61370 Offset: 0x1E60770 VA: 0x181E61370
	public byte[] ToProtoBytes() { }

	// RVA: 0x1E61380 Offset: 0x1E60780 VA: 0x181E61380
	public void ToProto(Stream stream) { }

	// RVA: 0x1E61020 Offset: 0x1E60420 VA: 0x181E61020
	public static byte[] SerializeToBytes(DemoShotParentTrack instance) { }

	// RVA: 0x1E60F70 Offset: 0x1E60370 VA: 0x181E60F70
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentTrack instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public struct DemoShotParentKeyframe : IProto // TypeDefIndex: 6474
{	// Fields
	public float keyframeTime; // 0x0
	public uint keyFrameParentId; // 0x4
	public string keyFrameParentName; // 0x8

	// Methods

	// RVA: 0x1E5F710 Offset: 0x1E5EB10 VA: 0x181E5F710
	public static void ResetToPool(DemoShotParentKeyframe instance) { }

	// RVA: 0x231A00 Offset: 0x230E00 VA: 0x180231A00
	public void CopyTo(DemoShotParentKeyframe instance) { }

	// RVA: 0x231A30 Offset: 0x230E30 VA: 0x180231A30
	public DemoShotParentKeyframe Copy() { }

	// RVA: 0x1E5F2F0 Offset: 0x1E5E6F0 VA: 0x181E5F2F0
	public static DemoShotParentKeyframe Deserialize(Stream stream) { }

	// RVA: 0x1E5F000 Offset: 0x1E5E400 VA: 0x181E5F000
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1E5F040 Offset: 0x1E5E440 VA: 0x181E5F040
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1E5F330 Offset: 0x1E5E730 VA: 0x181E5F330
	public static DemoShotParentKeyframe Deserialize(byte[] buffer) { }

	// RVA: 0x231A70 Offset: 0x230E70 VA: 0x180231A70
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x231AF0 Offset: 0x230EF0 VA: 0x180231AF0 Slot: 4
	public void WriteToStream(Stream stream) { }

	// RVA: 0x231B20 Offset: 0x230F20 VA: 0x180231B20
	public void WriteToStreamDelta(Stream stream, DemoShotParentKeyframe previous) { }

	// RVA: 0x231AA0 Offset: 0x230EA0 VA: 0x180231AA0 Slot: 5
	public void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1E5F430 Offset: 0x1E5E830 VA: 0x181E5F430
	public static DemoShotParentKeyframe Deserialize(byte[] buffer, ref DemoShotParentKeyframe instance, bool isDelta = False) { }

	// RVA: 0x1E5F560 Offset: 0x1E5E960 VA: 0x181E5F560
	public static DemoShotParentKeyframe Deserialize(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E5ED60 Offset: 0x1E5E160 VA: 0x181E5ED60
	public static DemoShotParentKeyframe DeserializeLengthDelimited(Stream stream, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E5F080 Offset: 0x1E5E480 VA: 0x181E5F080
	public static DemoShotParentKeyframe DeserializeLength(Stream stream, int length, ref DemoShotParentKeyframe instance, bool isDelta) { }

	// RVA: 0x1E5F760 Offset: 0x1E5EB60 VA: 0x181E5F760
	public static void SerializeDelta(Stream stream, DemoShotParentKeyframe instance, DemoShotParentKeyframe previous) { }

	// RVA: 0x1E5FB70 Offset: 0x1E5EF70 VA: 0x181E5FB70
	public static void Serialize(Stream stream, DemoShotParentKeyframe instance) { }

	// RVA: 0x231AD0 Offset: 0x230ED0 VA: 0x180231AD0
	public byte[] ToProtoBytes() { }

	// RVA: 0x231AF0 Offset: 0x230EF0 VA: 0x180231AF0
	public void ToProto(Stream stream) { }

	// RVA: 0x1E5FA50 Offset: 0x1E5EE50 VA: 0x181E5FA50
	public static byte[] SerializeToBytes(DemoShotParentKeyframe instance) { }

	// RVA: 0x1E5F9A0 Offset: 0x1E5EDA0 VA: 0x181E5F9A0
	public static void SerializeLengthDelimited(Stream stream, DemoShotParentKeyframe instance) { }

}

public class DemoClient : Client, IDisposable // TypeDefIndex: 6692
{	// Fields
	protected Reader demoFile; // 0x70

	// Properties
	public override bool IsPlaying { get; }
	public bool PlayingFinished { get; }

	// Methods

	// RVA: 0x22099E0 Offset: 0x2208DE0 VA: 0x1822099E0
	public void .ctor(Reader demoFile) { }

	// RVA: 0x2209290 Offset: 0x2208690 VA: 0x182209290 Slot: 14
	public virtual void Dispose() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 11
	public override bool IsConnected() { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 7
	public override bool get_IsPlaying() { }

	// RVA: 0x2209B90 Offset: 0x2208F90 VA: 0x182209B90
	public bool get_PlayingFinished() { }

	// RVA: 0x22098C0 Offset: 0x2208CC0 VA: 0x1822098C0
	public void UpdatePlayback(long frameTime) { }

	// RVA: 0x2209820 Offset: 0x2208C20 VA: 0x182209820
	private bool PlaybackPacket() { }

	// RVA: 0x22092C0 Offset: 0x22086C0 VA: 0x1822092C0
	private void HandleMessage(IntPtr data, int size) { }

}

public class DemoShotPlayback : MonoBehaviour // TypeDefIndex: 9178
{	// Fields
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DemoShot <CurrentShot>k__BackingField; // 0x18
	private bool playing; // 0x20
	public static DemoShotPlayback Instance; // 0x0
	public bool ShouldLoop; // 0x21

	// Properties
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

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x8FB9B0 Offset: 0x8FADB0 VA: 0x1808FB9B0
	public static bool get_IsPlayingShot() { }

	// RVA: 0x8FB8C0 Offset: 0x8FACC0 VA: 0x1808FB8C0
	public float get_CurrentShotTime() { }

	// RVA: 0x8FADD0 Offset: 0x8FA1D0 VA: 0x1808FADD0
	public void Setup(DemoShot shot) { }

	// RVA: 0x8FAC80 Offset: 0x8FA080 VA: 0x1808FAC80
	public void PlayFromStart() { }

	// RVA: 0x8FAC00 Offset: 0x8FA000 VA: 0x1808FAC00
	public void PauseShot() { }

	// RVA: 0x8FACE0 Offset: 0x8FA0E0 VA: 0x1808FACE0
	public void ResumeShot() { }

	// RVA: 0x8FA770 Offset: 0x8F9B70 VA: 0x1808FA770
	public void EndShot() { }

	// RVA: 0x8FAFA0 Offset: 0x8FA3A0 VA: 0x1808FAFA0
	private void Update() { }

	// RVA: 0x8FAA80 Offset: 0x8F9E80 VA: 0x1808FAA80
	private void OnDrawGizmosSelected() { }

	// RVA: 0x8FB8A0 Offset: 0x8FACA0 VA: 0x1808FB8A0
	public string get_CurrentShotName() { }

	// RVA: 0x8FBA90 Offset: 0x8FAE90 VA: 0x1808FBA90
	public float get_ShotPlaybackProgress() { }

	// RVA: 0x8FBA70 Offset: 0x8FAE70 VA: 0x1808FBA70
	public float get_ShotLength() { }

	// RVA: 0x8FBA40 Offset: 0x8FAE40 VA: 0x1808FBA40
	public float get_ShotEndTime() { }

	// RVA: 0x8FB960 Offset: 0x8FAD60 VA: 0x1808FB960
	public bool get_IsPaused() { }

	// RVA: 0x8FB880 Offset: 0x8FAC80 VA: 0x1808FB880
	public DemoShotVectorTrack get_CameraPositionTrack() { }

	// RVA: 0x8FBAC0 Offset: 0x8FAEC0 VA: 0x1808FBAC0
	public float get_ShotStartTime() { }

	// RVA: 0x8FB940 Offset: 0x8FAD40 VA: 0x1808FB940
	public bool get_HasDofData() { }

	// RVA: 0x8FAD30 Offset: 0x8FA130 VA: 0x1808FAD30
	public void SetShotTime(float newTime) { }

	// RVA: 0x8FA6C0 Offset: 0x8F9AC0 VA: 0x1808FA6C0
	public float ClampTimeToShotRange(float val) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class DemoShotRecorder : SingletonComponent<DemoShotRecorder> // TypeDefIndex: 9179
{	// Fields
	private DemoShot recordingShot; // 0x18
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

	// Properties
	public RealTimeUntil CountdownEnds { get; set; }
	public bool IsInCountdown { get; }
	public float CurrentShotTime { get; }
	public string CurrentShotName { get; }
	public float ShotStartTime { get; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4BB390 Offset: 0x4BA790 VA: 0x1804BB390
	public RealTimeUntil get_CountdownEnds() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x7E8DF0 Offset: 0x7E81F0 VA: 0x1807E8DF0
	private void set_CountdownEnds(RealTimeUntil value) { }

	// RVA: 0x8FECD0 Offset: 0x8FE0D0 VA: 0x1808FECD0
	public bool get_IsInCountdown() { }

	// RVA: 0x8FC870 Offset: 0x8FBC70 VA: 0x1808FC870
	public static void CreateNewShot(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x8FEC40 Offset: 0x8FE040 VA: 0x1808FEC40
	public float get_CurrentShotTime() { }

	// RVA: 0x8FEC20 Offset: 0x8FE020 VA: 0x1808FEC20
	public string get_CurrentShotName() { }

	// RVA: 0x8FECF0 Offset: 0x8FE0F0 VA: 0x1808FECF0
	public float get_ShotStartTime() { }

	[IteratorStateMachineAttribute] // RVA: 0xD6470 Offset: 0xD5870 VA: 0x1800D6470
	// RVA: 0x8FEA00 Offset: 0x8FDE00 VA: 0x1808FEA00
	private IEnumerator StartRecording(string shotName, DemoShotRecorder.RecorderSettings withSettings) { }

	// RVA: 0x8FC800 Offset: 0x8FBC00 VA: 0x1808FC800
	public void CancelRecording() { }

	// RVA: 0x8FC9B0 Offset: 0x8FBDB0 VA: 0x1808FC9B0
	public void FinishRecording() { }

	// RVA: 0x8FD5E0 Offset: 0x8FC9E0 VA: 0x1808FD5E0
	public static string GetShotDirectory(string demoName, bool createDirectory = False) { }

	// RVA: 0x8FD070 Offset: 0x8FC470 VA: 0x1808FD070
	public static string GetFilePath(string shotName, string demoName, string folderName, bool createDirectory = False) { }

	// RVA: 0x8FD160 Offset: 0x8FC560 VA: 0x1808FD160
	public static Dictionary<string, List<string>> GetPathsOfAllShots(string demoName) { }

	// RVA: 0x8FE820 Offset: 0x8FDC20 VA: 0x1808FE820
	private static int SortWithTrailingNumber(string x, string y) { }

	// RVA: 0x8FD6E0 Offset: 0x8FCAE0 VA: 0x1808FD6E0
	public static string GetTrailingFolder(string path) { }

	// RVA: 0x8FEAB0 Offset: 0x8FDEB0 VA: 0x1808FEAB0
	private void Update() { }

	// RVA: 0x8FD9A0 Offset: 0x8FCDA0 VA: 0x1808FD9A0
	private void RecordCameraState() { }

	// RVA: 0x8FE390 Offset: 0x8FD790 VA: 0x1808FE390
	private void RecordKeyframe(Vector3 value, DemoShotVectorTrack track) { }

	// RVA: 0x8FE190 Offset: 0x8FD590 VA: 0x1808FE190
	private void RecordKeyframe(float value, DemoShotFloatTrack track) { }

	// RVA: 0x8FDEC0 Offset: 0x8FD2C0 VA: 0x1808FDEC0
	private void RecordKeyframe(Quaternion value, DemoShotQuaternionTrack track) { }

	// RVA: 0x8FE620 Offset: 0x8FDA20 VA: 0x1808FE620
	private void RecordParent(BaseEntity parent, string bone, DemoShotParentTrack track) { }

	// RVA: 0x8FD920 Offset: 0x8FCD20 VA: 0x1808FD920
	private DemoShotVectorTrack InitialiseKeyframeVectorTrack() { }

	// RVA: 0x8FD8A0 Offset: 0x8FCCA0 VA: 0x1808FD8A0
	private DemoShotQuaternionTrack InitialiseKeyframeQuaternionTrack() { }

	// RVA: 0x8FD7A0 Offset: 0x8FCBA0 VA: 0x1808FD7A0
	private DemoShotFloatTrack InitialiseKeyframeFloatTrack() { }

	// RVA: 0x8FD820 Offset: 0x8FCC20 VA: 0x1808FD820
	private DemoShotParentTrack InitialiseKeyframeParentTrack() { }

	// RVA: 0x8FEBC0 Offset: 0x8FDFC0 VA: 0x1808FEBC0
	public void .ctor() { }

	// RVA: 0x8FEB70 Offset: 0x8FDF70 VA: 0x1808FEB70
	private static void .cctor() { }

}

public struct DemoShotRecorder.RecorderSettings // TypeDefIndex: 9180
{	// Fields
	public bool Countdown; // 0x0
	public bool PauseOnSave; // 0x1
	public bool ReturnToShotStart; // 0x2
	public string FolderName; // 0x8
	public bool RecordDof; // 0x10

}

private sealed class DemoShotRecorder.<StartRecording>d__23 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 9181
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18
	public DemoShotRecorder <>4__this; // 0x20
	public DemoShotRecorder.RecorderSettings withSettings; // 0x28
	public string shotName; // 0x40
	private float <waitTime>5__2; // 0x48
	private float <leftover>5__3; // 0x4C

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x8FF6A0 Offset: 0x8FEAA0 VA: 0x1808FF6A0 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8FFF20 Offset: 0x8FF320 VA: 0x1808FFF20 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public static class DemoShotHelpers // TypeDefIndex: 9182
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F76A0 Offset: 0x8F6AA0 VA: 0x1808F76A0
	public static Vector3 GetVectorFromTrack(DemoShotVectorTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F72F0 Offset: 0x8F66F0 VA: 0x1808F72F0
	public static Quaternion GetQuaternionFromTrack(DemoShotQuaternionTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F6760 Offset: 0x8F5B60 VA: 0x1808F6760
	public static float GetFloatFromTrack(DemoShotFloatTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F7140 Offset: 0x8F6540 VA: 0x1808F7140
	public static DemoShotParentKeyframe GetParentFromTrack(DemoShotParentTrack track, float time) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F6A20 Offset: 0x8F5E20 VA: 0x1808F6A20
	public static void GetKeyframesInRange(DemoShotVectorTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F6CB0 Offset: 0x8F60B0 VA: 0x1808F6CB0
	public static void GetKeyframesInRange(DemoShotQuaternionTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F6F20 Offset: 0x8F6320 VA: 0x1808F6F20
	public static void GetKeyframesInRange(DemoShotFloatTrack track, float start, float end, List<KeyframeView.UIKeyframeValue> results) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F7AF0 Offset: 0x8F6EF0 VA: 0x1808F7AF0
	public static Quaternion ToQuaternion(DemoShotQuaternionKeyframe keyframe) { }

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x8F7AC0 Offset: 0x8F6EC0 VA: 0x1808F7AC0
	public static DemoShotQuaternionKeyframe ToKeyframe(Quaternion value, float time) { }

}

public class DemoPlaybackUI : SingletonComponent<DemoPlaybackUI> // TypeDefIndex: 10854
{	// Fields
	public GameObject Root; // 0x18

	// Methods

	// RVA: 0x8F3250 Offset: 0x8F2650 VA: 0x1808F3250
	private void Start() { }

	// RVA: 0x8F3310 Offset: 0x8F2710 VA: 0x1808F3310
	public void Toggle(bool state) { }

	// RVA: 0x8F3390 Offset: 0x8F2790 VA: 0x1808F3390
	public void .ctor() { }

}

public class DemoPlaybackWidget : MonoBehaviour // TypeDefIndex: 10855
{	// Fields
	public RustSlider DemoProgress; // 0x18
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

	// Methods

	// RVA: 0x8F41B0 Offset: 0x8F35B0 VA: 0x1808F41B0
	private void Update() { }

	// RVA: 0x8F4100 Offset: 0x8F3500 VA: 0x1808F4100
	private void SetRectTransformAnchoredX(float xPos, RectTransform t) { }

	// RVA: 0x8F3CA0 Offset: 0x8F30A0 VA: 0x1808F3CA0
	public void OnClickedSlider(float value) { }

	// RVA: 0x8F4160 Offset: 0x8F3560 VA: 0x1808F4160
	private void TimelineScrubCheck() { }

	// RVA: 0x8F3730 Offset: 0x8F2B30 VA: 0x1808F3730
	public void OnClickedPlay() { }

	// RVA: 0x8F36A0 Offset: 0x8F2AA0 VA: 0x1808F36A0
	public void OnClickedPause() { }

	// RVA: 0x8F33F0 Offset: 0x8F27F0 VA: 0x1808F33F0
	public void OnClickedBackToStart() { }

	// RVA: 0x8F3FA0 Offset: 0x8F33A0 VA: 0x1808F3FA0
	public void OnClickedToEnd() { }

	// RVA: 0x8F3570 Offset: 0x8F2970 VA: 0x1808F3570
	public void OnClickedLoop() { }

	// RVA: 0x8F34F0 Offset: 0x8F28F0 VA: 0x1808F34F0
	public void OnClickedCancelShot() { }

	// RVA: 0x8F3600 Offset: 0x8F2A00 VA: 0x1808F3600
	public void OnClickedNextFrame() { }

	[IteratorStateMachineAttribute] // RVA: 0x7FDC0 Offset: 0x7F1C0 VA: 0x18007FDC0
	// RVA: 0x8F4BF0 Offset: 0x8F3FF0 VA: 0x1808F4BF0
	private IEnumerator WaitAndPause() { }

	// RVA: 0x8F3AC0 Offset: 0x8F2EC0 VA: 0x1808F3AC0
	public void OnClickedPreviousFrame() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

private sealed class DemoPlaybackWidget.<WaitAndPause>d__28 : IEnumerator<object>, IEnumerator, IDisposable // TypeDefIndex: 10856
{	// Fields
	private int <>1__state; // 0x10
	private object <>2__current; // 0x18

	// Properties
	private object System.Collections.Generic.IEnumerator<System.Object>.Current { get; }
	private object System.Collections.IEnumerator.Current { get; }

	// Methods

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497770 Offset: 0x496B70 VA: 0x180497770
	public void .ctor(int <>1__state) { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.IDisposable.Dispose() { }

	// RVA: 0x900190 Offset: 0x8FF590 VA: 0x180900190 Slot: 6
	private bool MoveNext() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 4
	private object System.Collections.Generic.IEnumerator<System.Object>.get_Current() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x900250 Offset: 0x8FF650 VA: 0x180900250 Slot: 8
	private void System.Collections.IEnumerator.Reset() { }

	[DebuggerHiddenAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 7
	private object System.Collections.IEnumerator.get_Current() { }

}

public class DemoRootFade : MonoBehaviour // TypeDefIndex: 10857
{	// Fields
	public CanvasGroup Canvas; // 0x18
	public static bool ToggleHide; // 0x0

	// Methods

	// RVA: 0x8F5EE0 Offset: 0x8F52E0 VA: 0x1808F5EE0
	private void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class DemoShotButton : RustButton, IPointerClickHandler, IEventSystemHandler // TypeDefIndex: 10858
{	// Fields
	public bool FireEventOnClicked; // 0x98

	// Methods

	// RVA: 0x8F6090 Offset: 0x8F5490 VA: 0x1808F6090 Slot: 42
	public override void OnPointerDown(PointerEventData eventData) { }

	// RVA: 0x8F60B0 Offset: 0x8F54B0 VA: 0x1808F60B0 Slot: 43
	public override void OnPointerUp(PointerEventData eventData) { }

	// RVA: 0x8F6070 Offset: 0x8F5470 VA: 0x1808F6070 Slot: 44
	public void OnPointerClick(PointerEventData eventData) { }

	// RVA: 0x70B670 Offset: 0x70AA70 VA: 0x18070B670
	public void .ctor() { }

}

public class DemoShotEntry : MonoBehaviour, IDraggable // TypeDefIndex: 10859
{	// Fields
	public RustButton PlayButton; // 0x18
	public Sprite DragSprite; // 0x20
	public RustInput RenameInput; // 0x28
	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private DemoShot <CurrentShot>k__BackingField; // 0x30

	// Properties
	public DemoShot CurrentShot { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	public DemoShot get_CurrentShot() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	private void set_CurrentShot(DemoShot value) { }

	// RVA: 0x8F6640 Offset: 0x8F5A40 VA: 0x1808F6640
	public void Populate(DemoShot shot, string folder) { }

	// RVA: 0x8F6350 Offset: 0x8F5750 VA: 0x1808F6350
	public void OnClicked() { }

	// RVA: 0x8F66A0 Offset: 0x8F5AA0 VA: 0x1808F66A0
	public void StopShot() { }

	// RVA: 0x8F61A0 Offset: 0x8F55A0 VA: 0x1808F61A0
	public void OnClickedDelete() { }

	// RVA: 0x8F6740 Offset: 0x8F5B40 VA: 0x1808F6740
	public void TogglePlayingRoot(bool state) { }

	// RVA: 0x8F6610 Offset: 0x8F5A10 VA: 0x1808F6610
	public void PopulateRename() { }

	// RVA: 0x8F60D0 Offset: 0x8F54D0 VA: 0x1808F60D0
	public void ApplyRename() { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0 Slot: 4
	public object GetDragData() { }

	// RVA: 0x8F6170 Offset: 0x8F5570 VA: 0x1808F6170 Slot: 5
	public string GetDragType() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 6
	public Sprite GetDragSprite() { }

	// RVA: 0x8F63B0 Offset: 0x8F57B0 VA: 0x1808F63B0
	public void OnDroppedValue(object data) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class DemoShotListFolderWidget : MonoBehaviour // TypeDefIndex: 10860
{	// Fields
	public RustButton FolderName; // 0x18
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

	// Properties
	public bool CurrentState { get; set; }
	public string cachedFolderName { get; set; }

	// Methods

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5ABE90 Offset: 0x5AB290 VA: 0x1805ABE90
	public bool get_CurrentState() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x5ABEA0 Offset: 0x5AB2A0 VA: 0x1805ABEA0
	private void set_CurrentState(bool value) { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60
	public string get_cachedFolderName() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x54FB70 Offset: 0x54EF70 VA: 0x18054FB70
	private void set_cachedFolderName(string value) { }

	// RVA: 0x8F81A0 Offset: 0x8F75A0 VA: 0x1808F81A0
	public void Populate(string folderName, bool state) { }

	// RVA: 0x8F82C0 Offset: 0x8F76C0 VA: 0x1808F82C0
	public void ToggleState() { }

	// RVA: 0x8F82D0 Offset: 0x8F76D0 VA: 0x1808F82D0
	public void ToggleState(bool state) { }

	// RVA: 0x8F7B50 Offset: 0x8F6F50 VA: 0x1808F7B50
	public void AddChild(DemoShotEntry shot) { }

	// RVA: 0x8F8380 Offset: 0x8F7780 VA: 0x1808F8380
	private void UpdateCountText() { }

	// RVA: 0x8F7EB0 Offset: 0x8F72B0 VA: 0x1808F7EB0
	public void OnDroppedValue(object data) { }

	// RVA: 0x8F8100 Offset: 0x8F7500 VA: 0x1808F8100
	public void OnRightClick() { }

	// RVA: 0x8F7BA0 Offset: 0x8F6FA0 VA: 0x1808F7BA0
	public void OnClickedDeleteFolder() { }

	// RVA: 0x8F7CF0 Offset: 0x8F70F0 VA: 0x1808F7CF0
	public void OnClickedRenameFolder() { }

	// RVA: 0x8F8410 Offset: 0x8F7810 VA: 0x1808F8410
	public void .ctor() { }

}

public class DemoShotListRootFolder : MonoBehaviour // TypeDefIndex: 10861
{	// Methods

	// RVA: 0x8F8420 Offset: 0x8F7820 VA: 0x1808F8420
	public void OnDroppedValue(object data) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class DemoShotListWidget : SingletonComponent<DemoShotListWidget> // TypeDefIndex: 10862
{	// Fields
	public GameObjectRef ShotListEntry; // 0x18
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

	// Properties
	private int TotalShotCount { get; }

	// Methods

	// RVA: 0x8F8F00 Offset: 0x8F8300 VA: 0x1808F8F00
	private void OnEnable() { }

	// RVA: 0x8F94A0 Offset: 0x8F88A0 VA: 0x1808F94A0
	public void UpdateAvailableShots() { }

	// RVA: 0x8F9230 Offset: 0x8F8630 VA: 0x1808F9230
	public void SetCurrentlyPlaying(DemoShot shot) { }

	// RVA: 0x8FA590 Offset: 0x8F9990 VA: 0x1808FA590
	private int get_TotalShotCount() { }

	// RVA: 0x8F8B10 Offset: 0x8F7F10 VA: 0x1808F8B10
	public string GetDefaultNewShotName() { }

	// RVA: 0x8F8870 Offset: 0x8F7C70 VA: 0x1808F8870
	public void DeleteShot(DemoShot shotName) { }

	// RVA: 0x8F9060 Offset: 0x8F8460 VA: 0x1808F9060
	public void RenameShot(DemoShot shotToRename, string newName) { }

	// RVA: 0x8F8670 Offset: 0x8F7A70 VA: 0x1808F8670
	public void CreateFolder() { }

	// RVA: 0x8F9390 Offset: 0x8F8790 VA: 0x1808F9390
	public void ToggleOpen(bool state) { }

	// RVA: 0x8F9380 Offset: 0x8F8780 VA: 0x1808F9380
	public void ToggleOpen() { }

	// RVA: 0x8F89C0 Offset: 0x8F7DC0 VA: 0x1808F89C0
	public List<string> GetCurrentFolders() { }

	// RVA: 0x8F8D50 Offset: 0x8F8150 VA: 0x1808F8D50
	public void MoveShotToFolder(DemoShot shot, string targetFolder) { }

	// RVA: 0x8F8F10 Offset: 0x8F8310 VA: 0x1808F8F10
	public void RenameFolder(string oldName, string newName) { }

	// RVA: 0x8F8770 Offset: 0x8F7B70 VA: 0x1808F8770
	public void DeleteFolder(string folderName) { }

	// RVA: 0x8FA4A0 Offset: 0x8F98A0 VA: 0x1808FA4A0
	public void .ctor() { }

}

public class DemoShotRecordWidget : MonoBehaviour // TypeDefIndex: 10863
{	// Fields
	public RustInput NameInput; // 0x18
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

	// Methods

	// RVA: 0x8FC140 Offset: 0x8FB540 VA: 0x1808FC140
	private void Start() { }

	// RVA: 0x8FBE20 Offset: 0x8FB220 VA: 0x1808FBE20
	private void OnEnable() { }

	// RVA: 0x8FC330 Offset: 0x8FB730 VA: 0x1808FC330
	public void UpdateShotName() { }

	// RVA: 0x8FC3C0 Offset: 0x8FB7C0 VA: 0x1808FC3C0
	private void Update() { }

	// RVA: 0x8FBB50 Offset: 0x8FAF50 VA: 0x1808FBB50
	public void OnClickedStartRecording() { }

	// RVA: 0x8FBAE0 Offset: 0x8FAEE0 VA: 0x1808FBAE0
	public void OnClickedFinish() { }

	// RVA: 0x8FC230 Offset: 0x8FB630 VA: 0x1808FC230
	public void Toggle(bool state) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

public class DemoText : MonoBehaviour // TypeDefIndex: 10864
{	// Fields
	public RustText TimeText; // 0x18
	public RustText TotalSecondText; // 0x20
	public RustText TimeScaleText; // 0x28
	public RustText FilenameText; // 0x30
	public RustText DateTimeText; // 0x38
	public RustText ParentText; // 0x40
	public RustText DofText; // 0x48
	public GameObject InternalRoot; // 0x50
	public GameObject ParentRoot; // 0x58
	public GameObject DofRoot; // 0x60

	// Methods

	// RVA: 0x9AF5A0 Offset: 0x9AE9A0 VA: 0x1809AF5A0
	private void Update() { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	public void .ctor() { }

}

public class DemoRecorder : SingletonComponent<DemoRecorder> // TypeDefIndex: 10869
{	// Fields
	public RustInput Input; // 0x18
	public GameObject RecordingUnderlay; // 0x20
	private bool IsOpen; // 0x28

	// Methods

	// RVA: 0x8F5480 Offset: 0x8F4880 VA: 0x1808F5480 Slot: 6
	protected override void Awake() { }

	// RVA: 0x8F57D0 Offset: 0x8F4BD0 VA: 0x1808F57D0
	public void Open() { }

	// RVA: 0x8F5CB0 Offset: 0x8F50B0 VA: 0x1808F5CB0
	public void Update() { }

	// RVA: 0x8F5590 Offset: 0x8F4990 VA: 0x1808F5590
	public void Close() { }

	// RVA: 0x8F5BF0 Offset: 0x8F4FF0 VA: 0x1808F5BF0
	public void SubmitRecord() { }

	// RVA: 0x8F5B70 Offset: 0x8F4F70 VA: 0x1808F5B70
	public void Record() { }

	// RVA: 0x8F5E80 Offset: 0x8F5280 VA: 0x1808F5E80
	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: 0x4E2D90 Offset: 0x4E2190 VA: 0x1804E2D90
	private void <Close>b__6_0() { }

}

public class DemoRecorderProgress : SingletonComponent<DemoRecorderProgress> // TypeDefIndex: 10870
{	// Fields
	public RustText RecordingLabel; // 0x18
	public RustText ProgressLabel; // 0x20
	public GameObject RecordingUnderlay; // 0x28
	private CanvasGroup canvasGroup; // 0x30
	private NeedsCursor needsCursor; // 0x38

	// Methods

	// RVA: 0x8F4C40 Offset: 0x8F4040 VA: 0x1808F4C40 Slot: 6
	protected override void Awake() { }

	// RVA: 0x8F4DE0 Offset: 0x8F41E0 VA: 0x1808F4DE0
	public void Open(string recordingName) { }

	// RVA: 0x8F5030 Offset: 0x8F4430 VA: 0x1808F5030
	public void Update() { }

	// RVA: 0x8F4CF0 Offset: 0x8F40F0 VA: 0x1808F4CF0
	public void Close() { }

	// RVA: 0x8F4D60 Offset: 0x8F4160 VA: 0x1808F4D60
	public void EnableCursor(bool enable) { }

	// RVA: 0x8F4F80 Offset: 0x8F4380 VA: 0x1808F4F80
	public void Stop() { }

	// RVA: 0x8F5420 Offset: 0x8F4820 VA: 0x1808F5420
	public void .ctor() { }

}

public class DemoItem : RustButton // TypeDefIndex: 11098
{	// Fields
	public Demos demos; // 0x98
	public int itemId; // 0xA0
	public RustText nameText; // 0xA8
	public RustText dateText; // 0xB0
	public RustText lengthText; // 0xB8

	// Methods

	// RVA: 0x8F31C0 Offset: 0x8F25C0 VA: 0x1808F31C0
	public void OnClicked() { }

	// RVA: 0x8F30A0 Offset: 0x8F24A0 VA: 0x1808F30A0 Slot: 30
	protected override void ApplyStyle(StyleAsset.Group s) { }

	// RVA: 0x70B670 Offset: 0x70AA70 VA: 0x18070B670
	public void .ctor() { }

}

public class Demos : SingletonComponent<Demos>, VirtualScroll.IDataSource // TypeDefIndex: 11099
{	// Fields
	public VirtualScroll virtualScroll; // 0x18
	public GameObject deletePopup; // 0x20
	private readonly List<Demos.DemoInfo> _demoInfo; // 0x28
	private readonly List<Demos.DemoInfo> _sortedDemoInfo; // 0x30
	private DemoItem _selectedItem; // 0x38
	private string sortOrder; // 0x40

	// Methods

	// RVA: 0x9AFCC0 Offset: 0x9AF0C0 VA: 0x1809AFCC0 Slot: 6
	protected override void Awake() { }

	// RVA: 0x9AFE90 Offset: 0x9AF290 VA: 0x1809AFE90
	private void DeselectItem() { }

	// RVA: 0x9B0900 Offset: 0x9AFD00 VA: 0x1809B0900
	private void Populate() { }

	// RVA: 0x9B0BF0 Offset: 0x9AFFF0 VA: 0x1809B0BF0
	private void Rebuild() { }

	// RVA: 0x9B0870 Offset: 0x9AFC70 VA: 0x1809B0870
	public void OrderBy(string strBy) { }

	// RVA: 0x9AFF40 Offset: 0x9AF340 VA: 0x1809AFF40 Slot: 8
	public int GetItemCount() { }

	// RVA: 0x9B0C90 Offset: 0x9B0090 VA: 0x1809B0C90 Slot: 9
	public void SetItemData(int i, GameObject obj) { }

	// RVA: 0x9AFF80 Offset: 0x9AF380 VA: 0x1809AFF80
	private IOrderedEnumerable<Demos.DemoInfo> GetSortedInfo() { }

	// RVA: 0x9B0610 Offset: 0x9AFA10 VA: 0x1809B0610
	public void OnItemClicked(DemoItem item) { }

	// RVA: 0x9B0590 Offset: 0x9AF990 VA: 0x1809B0590
	public void OnDeleteItem() { }

	// RVA: 0x9AFCE0 Offset: 0x9AF0E0 VA: 0x1809AFCE0
	public void DeleteItem() { }

	// RVA: 0x9B0760 Offset: 0x9AFB60 VA: 0x1809B0760
	public void OnPlayItem() { }

	// RVA: 0x9B0830 Offset: 0x9AFC30 VA: 0x1809B0830
	public void OpenDemosFolder() { }

	// RVA: 0x9B0C80 Offset: 0x9B0080 VA: 0x1809B0C80
	public void Refresh() { }

	// RVA: 0x9B1000 Offset: 0x9B0400 VA: 0x1809B1000
	public void .ctor() { }

}

private struct Demos.DemoInfo // TypeDefIndex: 11100
{	// Fields
	public string path; // 0x0
	public string name; // 0x8
	public DateTime date; // 0x10
	public TimeSpan length; // 0x18

	// Methods

	// RVA: 0xFABB0 Offset: 0xF9FB0 VA: 0x1800FABB0
	public void .ctor(string path, string name, DateTime date, TimeSpan length) { }

}

private sealed class Demos.<>c // TypeDefIndex: 11101
{	// Fields
	public static readonly Demos.<>c <>9; // 0x0
	public static Func<Demos.DemoInfo, string> <>9__14_0; // 0x8
	public static Func<Demos.DemoInfo, string> <>9__14_1; // 0x10
	public static Func<Demos.DemoInfo, DateTime> <>9__14_2; // 0x18
	public static Func<Demos.DemoInfo, DateTime> <>9__14_3; // 0x20
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_4; // 0x28
	public static Func<Demos.DemoInfo, TimeSpan> <>9__14_5; // 0x30
	public static Func<Demos.DemoInfo, string> <>9__14_6; // 0x38

	// Methods

	// RVA: 0x9CA840 Offset: 0x9C9C40 VA: 0x1809CA840
	private static void .cctor() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9CA670 Offset: 0x9C9A70 VA: 0x1809CA670
	internal string <GetSortedInfo>b__14_0(Demos.DemoInfo x) { }

	// RVA: 0x9CA670 Offset: 0x9C9A70 VA: 0x1809CA670
	internal string <GetSortedInfo>b__14_1(Demos.DemoInfo x) { }

	// RVA: 0x9CA690 Offset: 0x9C9A90 VA: 0x1809CA690
	internal DateTime <GetSortedInfo>b__14_2(Demos.DemoInfo x) { }

	// RVA: 0x9CA690 Offset: 0x9C9A90 VA: 0x1809CA690
	internal DateTime <GetSortedInfo>b__14_3(Demos.DemoInfo x) { }

	// RVA: 0x9CA6B0 Offset: 0x9C9AB0 VA: 0x1809CA6B0
	internal TimeSpan <GetSortedInfo>b__14_4(Demos.DemoInfo x) { }

	// RVA: 0x9CA6B0 Offset: 0x9C9AB0 VA: 0x1809CA6B0
	internal TimeSpan <GetSortedInfo>b__14_5(Demos.DemoInfo x) { }

	// RVA: 0x9CA670 Offset: 0x9C9A70 VA: 0x1809CA670
	internal string <GetSortedInfo>b__14_6(Demos.DemoInfo x) { }

}

private sealed class Demos.<>c__DisplayClass17_0 // TypeDefIndex: 11102
{	// Fields
	public Demos.DemoInfo demoInfo; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9CA820 Offset: 0x9C9C20 VA: 0x1809CA820
	internal bool <DeleteItem>b__0(Demos.DemoInfo x) { }

}

public class Demo : ConsoleSystem // TypeDefIndex: 11903
{	// Fields
	public static uint Version; // 0x0
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

	// Properties
	[ClientVar] // RVA: 0x811C0 Offset: 0x805C0 VA: 0x1800811C0
	public static bool hud { get; set; }
	public static float TimeScale { get; }
	public static string lastRecordedDemoName { get; set; }

	// Methods

	// RVA: 0x6D7360 Offset: 0x6D6760 VA: 0x1806D7360
	public static bool get_hud() { }

	// RVA: 0x6D8EF0 Offset: 0x6D82F0 VA: 0x1806D8EF0
	public static void set_hud(bool value) { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D95E0 Offset: 0x6D89E0 VA: 0x1806D95E0
	public static void togglehud(ConsoleSystem.Arg arg) { }

	// RVA: 0x6D72C0 Offset: 0x6D66C0 VA: 0x1806D72C0
	public static float get_TimeScale() { }

	[ClientVar] // RVA: 0x815F0 Offset: 0x809F0 VA: 0x1800815F0
	// RVA: 0x6D86E0 Offset: 0x6D7AE0 VA: 0x1806D86E0
	public static string record(string filename) { }

	[ClientVar] // RVA: 0x96230 Offset: 0x95630 VA: 0x180096230
	// RVA: 0x6D8D30 Offset: 0x6D8130 VA: 0x1806D8D30
	public static void recorder() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D9290 Offset: 0x6D8690 VA: 0x1806D9290
	public static string stop() { }

	[ClientVar] // RVA: 0x71070 Offset: 0x70470 VA: 0x180071070
	// RVA: 0x6D78A0 Offset: 0x6D6CA0 VA: 0x1806D78A0
	public static string play(string filename) { }

	// RVA: 0x6D6E10 Offset: 0x6D6210 VA: 0x1806D6E10
	public static void TryRunDemoCfg(string demoName) { }

	[ClientVar] // RVA: 0x96400 Offset: 0x95800 VA: 0x180096400
	// RVA: 0x6D90A0 Offset: 0x6D84A0 VA: 0x1806D90A0
	public static string skip(float seconds) { }

	[ClientVar] // RVA: 0x964D0 Offset: 0x958D0 VA: 0x1800964D0
	// RVA: 0x6D7400 Offset: 0x6D6800 VA: 0x1806D7400
	public static string jump(float seconds) { }

	[ClientVar] // RVA: 0x96610 Offset: 0x95A10 VA: 0x180096610
	// RVA: 0x6D8110 Offset: 0x6D7510 VA: 0x1806D8110
	public static string playernames() { }

	[ClientVar] // RVA: 0x96730 Offset: 0x95B30 VA: 0x180096730
	// RVA: 0x6D7170 Offset: 0x6D6570 VA: 0x1806D7170
	public static void browser() { }

	// RVA: 0x6D73C0 Offset: 0x6D67C0 VA: 0x1806D73C0
	public static string get_lastRecordedDemoName() { }

	// RVA: 0x6D9060 Offset: 0x6D8460 VA: 0x1806D9060
	public static void set_lastRecordedDemoName(string value) { }

	[ClientVar] // RVA: 0x96900 Offset: 0x95D00 VA: 0x180096900
	// RVA: 0x6D9520 Offset: 0x6D8920 VA: 0x1806D9520
	public static string toggleNVG(ConsoleSystem.Arg args) { }

	[ClientVar] // RVA: 0x96970 Offset: 0x95D70 VA: 0x180096970
	// RVA: 0x6D7650 Offset: 0x6D6A50 VA: 0x1806D7650
	public static string pause() { }

	[ClientVar] // RVA: 0x969F0 Offset: 0x95DF0 VA: 0x1800969F0
	// RVA: 0x6D8DA0 Offset: 0x6D81A0 VA: 0x1806D8DA0
	public static string resume() { }

	// RVA: 0x6D7730 Offset: 0x6D6B30 VA: 0x1806D7730
	public static string playShot(DemoShot shot) { }

	[ClientVar] // RVA: 0x96B10 Offset: 0x95F10 VA: 0x180096B10
	// RVA: 0x6D8630 Offset: 0x6D7A30 VA: 0x1806D8630
	public static void readcfg() { }

	// RVA: 0x6D7110 Offset: 0x6D6510 VA: 0x1806D7110
	public void .ctor() { }

	// RVA: 0x6D7060 Offset: 0x6D6460 VA: 0x1806D7060
	private static void .cctor() { }

}

public class Demo.Header : DemoHeader, IDemoHeader // TypeDefIndex: 11904
{	// Properties
	private long Network.IDemoHeader.Length { get; set; }

	// Methods

	// RVA: 0x54FB60 Offset: 0x54EF60 VA: 0x18054FB60 Slot: 15
	private long Network.IDemoHeader.get_Length() { }

	// RVA: 0x6E4670 Offset: 0x6E3A70 VA: 0x1806E4670 Slot: 16
	private void Network.IDemoHeader.set_Length(long value) { }

	// RVA: 0x6E4680 Offset: 0x6E3A80 VA: 0x1806E4680 Slot: 17
	public void Write(BinaryWriter writer) { }

	// RVA: 0x6E4730 Offset: 0x6E3B30 VA: 0x1806E4730
	public void .ctor() { }

}

