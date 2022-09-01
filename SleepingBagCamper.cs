public class SleepingBagCamper : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6420
{
	public bool ShouldPool; 
	private bool _disposed; 
	public uint seatID; 


	public static void ResetToPool(SleepingBagCamper instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(SleepingBagCamper instance) { }

	public SleepingBagCamper Copy() { }

	public static SleepingBagCamper Deserialize(Stream stream) { }

	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream) { }

	public static SleepingBagCamper DeserializeLength(Stream stream, int length) { }

	public static SleepingBagCamper Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, SleepingBagCamper previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static SleepingBagCamper Deserialize(byte[] buffer, SleepingBagCamper instance, bool isDelta = False) { }

	public static SleepingBagCamper Deserialize(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	public static SleepingBagCamper DeserializeLengthDelimited(Stream stream, SleepingBagCamper instance, bool isDelta) { }

	public static SleepingBagCamper DeserializeLength(Stream stream, int length, SleepingBagCamper instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, SleepingBagCamper instance, SleepingBagCamper previous) { }

	public static void Serialize(Stream stream, SleepingBagCamper instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(SleepingBagCamper instance) { }

	public static void SerializeLengthDelimited(Stream stream, SleepingBagCamper instance) { }

	public void .ctor() { }

}

public class SleepingBagCamper : SleepingBag // TypeDefIndex: 8642
{
	public EntityRef<BaseVehicleSeat> AssociatedSeat; 


	public override bool OnRpcMessage(BasePlayer player, uint rpc, Message msg) { }

	public override void Load(BaseNetworkable.LoadInfo info) { }

	public override bool Menu_MakeBed_ShowIf(BasePlayer player) { }

	public void Menu_ClearBed(BasePlayer player) { }

	public bool Menu_ClearBed_ShowIf(BasePlayer player) { }

	public override bool CanRename_Test(BasePlayer player) { }

	public void .ctor() { }

}

