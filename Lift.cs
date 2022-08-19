public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6338
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14

	// Methods

	// RVA: 0x1F19540 Offset: 0x1F18940 VA: 0x181F19540
	public static void ResetToPool(Lift instance) { }

	// RVA: 0x1F194C0 Offset: 0x1F188C0 VA: 0x181F194C0
	public void ResetToPool() { }

	// RVA: 0x1F19390 Offset: 0x1F18790 VA: 0x181F19390 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(Lift instance) { }

	// RVA: 0x1F18A10 Offset: 0x1F17E10 VA: 0x181F18A10
	public Lift Copy() { }

	// RVA: 0x1F191D0 Offset: 0x1F185D0 VA: 0x181F191D0
	public static Lift Deserialize(Stream stream) { }

	// RVA: 0x1F18CA0 Offset: 0x1F180A0 VA: 0x181F18CA0
	public static Lift DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1F18F20 Offset: 0x1F18320 VA: 0x181F18F20
	public static Lift DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1F18FB0 Offset: 0x1F183B0 VA: 0x181F18FB0
	public static Lift Deserialize(byte[] buffer) { }

	// RVA: 0x1F19480 Offset: 0x1F18880 VA: 0x181F19480
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1F19A10 Offset: 0x1F18E10 VA: 0x181F19A10 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1F19AE0 Offset: 0x1F18EE0 VA: 0x181F19AE0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, Lift previous) { }

	// RVA: 0x1F194A0 Offset: 0x1F188A0 VA: 0x181F194A0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1F190D0 Offset: 0x1F184D0 VA: 0x181F190D0
	public static Lift Deserialize(byte[] buffer, Lift instance, bool isDelta = False) { }

	// RVA: 0x1F19250 Offset: 0x1F18650 VA: 0x181F19250
	public static Lift Deserialize(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F18A80 Offset: 0x1F17E80 VA: 0x181F18A80
	public static Lift DeserializeLengthDelimited(Stream stream, Lift instance, bool isDelta) { }

	// RVA: 0x1F18D20 Offset: 0x1F18120 VA: 0x181F18D20
	public static Lift DeserializeLength(Stream stream, int length, Lift instance, bool isDelta) { }

	// RVA: 0x1F195C0 Offset: 0x1F189C0 VA: 0x181F195C0
	public static void SerializeDelta(Stream stream, Lift instance, Lift previous) { }

	// RVA: 0x1F19930 Offset: 0x1F18D30 VA: 0x181F19930
	public static void Serialize(Stream stream, Lift instance) { }

	// RVA: 0x1F19A00 Offset: 0x1F18E00 VA: 0x181F19A00
	public byte[] ToProtoBytes() { }

	// RVA: 0x1F19A10 Offset: 0x1F18E10 VA: 0x181F19A10
	public void ToProto(Stream stream) { }

	// RVA: 0x1F19780 Offset: 0x1F18B80 VA: 0x181F19780
	public static byte[] SerializeToBytes(Lift instance) { }

	// RVA: 0x1F196D0 Offset: 0x1F18AD0 VA: 0x181F196D0
	public static void SerializeLengthDelimited(Stream stream, Lift instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class Lift : AnimatedBuildingBlock // TypeDefIndex: 8403
{	// Fields
	private Option __menuOption_Menu_UseLift; // 0x270
	public GameObjectRef triggerPrefab; // 0x2C8
	public string triggerBone; // 0x2D0
	public float resetDelay; // 0x2D8

	// Properties
	public override bool HasMenuOptions { get; }

	// Methods

	// RVA: 0x6C3F80 Offset: 0x6C3380 VA: 0x1806C3F80 Slot: 49
	public override void GetMenuOptions(List<Option> list) { }

	// RVA: 0x6C43C0 Offset: 0x6C37C0 VA: 0x1806C43C0 Slot: 50
	public override bool get_HasMenuOptions() { }

	// RVA: 0x6C42B0 Offset: 0x6C36B0 VA: 0x1806C42B0 Slot: 35
	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Description] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Icon] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	// RVA: 0x6C4270 Offset: 0x6C3670 VA: 0x1806C4270
	public void Menu_UseLift(BasePlayer player) { }

	// RVA: 0x498A60 Offset: 0x497E60 VA: 0x180498A60
	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 72
	public override bool NeedsCrosshair() { }

	// RVA: 0x6C43A0 Offset: 0x6C37A0 VA: 0x1806C43A0
	public void .ctor() { }

}

