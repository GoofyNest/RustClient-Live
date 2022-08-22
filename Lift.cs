public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6338
{	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int floor; // 0x14


	public static void ResetToPool(Lift instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Lift instance) { }

	public Lift Copy() { }

	public static Lift Deserialize(Stream stream) { }

	public static Lift DeserializeLengthDelimited(Stream stream) { }

	public static Lift DeserializeLength(Stream stream, int length) { }

	public static Lift Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Lift previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Lift Deserialize(byte[] buffer, Lift instance, bool isDelta = False) { }

	public static Lift Deserialize(Stream stream, Lift instance, bool isDelta) { }

	public static Lift DeserializeLengthDelimited(Stream stream, Lift instance, bool isDelta) { }

	public static Lift DeserializeLength(Stream stream, int length, Lift instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Lift instance, Lift previous) { }

	public static void Serialize(Stream stream, Lift instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Lift instance) { }

	public static void SerializeLengthDelimited(Stream stream, Lift instance) { }

	public void .ctor() { }

}

public class Lift : AnimatedBuildingBlock // TypeDefIndex: 8403
{	private Option __menuOption_Menu_UseLift; // 0x270
	public GameObjectRef triggerPrefab; // 0x2C8
	public string triggerBone; // 0x2D0
	public float resetDelay; // 0x2D8

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Description] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.Icon] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	[BaseEntity.Menu.ShowIf] // RVA: 0x7DA70 Offset: 0x7CE70 VA: 0x18007DA70
	public void Menu_UseLift(BasePlayer player) { }

	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	public override bool NeedsCrosshair() { }

	public void .ctor() { }

}

