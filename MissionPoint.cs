public class MissionPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string identifier; // 0x18
	public Vector3 location; // 0x20

	// Methods

	// RVA: 0x1F49180 Offset: 0x1F48580 VA: 0x181F49180
	public static void ResetToPool(MissionPoint instance) { }

	// RVA: 0x1F490D0 Offset: 0x1F484D0 VA: 0x181F490D0
	public void ResetToPool() { }

	// RVA: 0x1F49010 Offset: 0x1F48410 VA: 0x181F49010 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1F48530 Offset: 0x1F47930 VA: 0x181F48530
	public void CopyTo(MissionPoint instance) { }

	// RVA: 0x1F48580 Offset: 0x1F47980 VA: 0x181F48580
	public MissionPoint Copy() { }

	// RVA: 0x1F48F90 Offset: 0x1F48390 VA: 0x181F48F90
	public static MissionPoint Deserialize(Stream stream) { }

	// RVA: 0x1F48880 Offset: 0x1F47C80 VA: 0x181F48880
	public static MissionPoint DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F48900 Offset: 0x1F47D00 VA: 0x181F48900
	public static MissionPoint DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F48CD0 Offset: 0x1F480D0 VA: 0x181F48CD0
	public static MissionPoint Deserialize(byte[] buffer) { }

	// RVA: 0x1F49090 Offset: 0x1F48490 VA: 0x181F49090
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F498E0 Offset: 0x1F48CE0 VA: 0x181F498E0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F49900 Offset: 0x1F48D00 VA: 0x181F49900 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, MissionPoint previous) { }

	// RVA: 0x1F490B0 Offset: 0x1F484B0 VA: 0x181F490B0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F48BD0 Offset: 0x1F47FD0 VA: 0x181F48BD0
	public static MissionPoint Deserialize(byte[] buffer, MissionPoint instance, bool isDelta = False) { }

	// RVA: 0x1F48DF0 Offset: 0x1F481F0 VA: 0x181F48DF0
	public static MissionPoint Deserialize(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F48610 Offset: 0x1F47A10 VA: 0x181F48610
	public static MissionPoint DeserializeLengthDelimited(Stream stream, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F48990 Offset: 0x1F47D90 VA: 0x181F48990
	public static MissionPoint DeserializeLength(Stream stream, int length, MissionPoint instance, bool isDelta) { }

	// RVA: 0x1F49230 Offset: 0x1F48630 VA: 0x181F49230
	public static void SerializeDelta(Stream stream, MissionPoint instance, MissionPoint previous) { }

	// RVA: 0x1F496D0 Offset: 0x1F48AD0 VA: 0x181F496D0
	public static void Serialize(Stream stream, MissionPoint instance) { }

	// RVA: 0x1F498D0 Offset: 0x1F48CD0 VA: 0x181F498D0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F498E0 Offset: 0x1F48CE0 VA: 0x181F498E0
	public void ToProto(Stream stream) { }

	// RVA: 0x1F495C0 Offset: 0x1F489C0 VA: 0x181F495C0
	public static byte[] SerializeToBytes(MissionPoint instance) { }

	// RVA: 0x1F49510 Offset: 0x1F48910 VA: 0x181F49510
	public static void SerializeLengthDelimited(Stream stream, MissionPoint instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class MissionPoint : MonoBehaviour // TypeDefIndex: 10214
{	// Fields
	public bool dropToGround; // 0x18
	public const int COUNT = 8;
	public const int EVERYTHING = -1;
	public const int NOTHING = 0;
	public const int EASY_MONUMENT = 1;
	public const int MED_MONUMENT = 2;
	public const int HARD_MONUMENT = 4;
	public const int ITEM_HIDESPOT = 8;
	public const int UNDERWATER = 128;
	public const int EASY_MONUMENT_IDX = 0;
	public const int MED_MONUMENT_IDX = 1;
	public const int HARD_MONUMENT_IDX = 2;
	public const int ITEM_HIDESPOT_IDX = 3;
	public const int FOREST_IDX = 4;
	public const int ROADSIDE_IDX = 5;
	public const int BEACH = 6;
	public const int UNDERWATER_IDX = 7;
	private static Dictionary<int, int> type2index; // 0x0

	// Methods

	// RVA: 0x765FA0 Offset: 0x7653A0 VA: 0x180765FA0
	public static int TypeToIndex(int id) { }

	// RVA: 0x765F90 Offset: 0x765390 VA: 0x180765F90
	public static int IndexToType(int idx) { }

	// RVA: 0x766110 Offset: 0x765510 VA: 0x180766110
	public void .ctor() { }

	// RVA: 0x766020 Offset: 0x765420 VA: 0x180766020
	private static void .cctor() { }

}

public enum MissionPoint.MissionPointEnum // TypeDefIndex: 10215
{	// Fields
	public int value__; // 0x0
	public const MissionPoint.MissionPointEnum EasyMonument = 1;
	public const MissionPoint.MissionPointEnum MediumMonument = 2;
	public const MissionPoint.MissionPointEnum HardMonument = 4;
	public const MissionPoint.MissionPointEnum Item_Hidespot = 8;
	public const MissionPoint.MissionPointEnum Underwater = 128;

}

