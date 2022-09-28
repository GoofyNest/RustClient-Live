public class Lift : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6339
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int floor; 


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

public class Lift : AnimatedBuildingBlock // TypeDefIndex: 10074
{
	private Option __menuOption_Menu_UseLift; 
	public GameObjectRef triggerPrefab; 
	public string triggerBone; 
	public float resetDelay; 

	public override bool HasMenuOptions { get; }


	public override void GetMenuOptions(List<Option> list) { }

	public override bool get_HasMenuOptions() { }

	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	[BaseEntity.Menu] 
	[BaseEntity.Menu.Description] 
	[BaseEntity.Menu.Icon] 
	[BaseEntity.Menu.ShowIf] 
	public void Menu_UseLift(BasePlayer player) { }

	public bool Menu_UseLift_ShowIf(BasePlayer player) { }

	public override bool NeedsCrosshair() { }

	public void .ctor() { }

}

