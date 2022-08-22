public class MissionPoint : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6451
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string identifier; // 0x18
	public Vector3 location; // 0x20


	public static void ResetToPool(MissionPoint instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(MissionPoint instance) { }

	public MissionPoint Copy() { }

	public static MissionPoint Deserialize(Stream stream) { }

	public static MissionPoint DeserializeLengthDelimited(Stream stream) { }

	public static MissionPoint DeserializeLength(Stream stream, int length) { }

	public static MissionPoint Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, MissionPoint previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static MissionPoint Deserialize(byte[] buffer, MissionPoint instance, bool isDelta = False) { }

	public static MissionPoint Deserialize(Stream stream, MissionPoint instance, bool isDelta) { }

	public static MissionPoint DeserializeLengthDelimited(Stream stream, MissionPoint instance, bool isDelta) { }

	public static MissionPoint DeserializeLength(Stream stream, int length, MissionPoint instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, MissionPoint instance, MissionPoint previous) { }

	public static void Serialize(Stream stream, MissionPoint instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(MissionPoint instance) { }

	public static void SerializeLengthDelimited(Stream stream, MissionPoint instance) { }

	public void .ctor() { }

}

public class MissionPoint : MonoBehaviour // TypeDefIndex: 10214
{	public bool dropToGround; // 0x18
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


	public static int TypeToIndex(int id) { }

	public static int IndexToType(int idx) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum MissionPoint.MissionPointEnum // TypeDefIndex: 10215
{	public int value__; // 0x0
	public const MissionPoint.MissionPointEnum EasyMonument = 1;
	public const MissionPoint.MissionPointEnum MediumMonument = 2;
	public const MissionPoint.MissionPointEnum HardMonument = 4;
	public const MissionPoint.MissionPointEnum Item_Hidespot = 8;
	public const MissionPoint.MissionPointEnum Underwater = 128;

}

