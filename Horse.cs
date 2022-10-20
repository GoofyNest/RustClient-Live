public class Horse : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6370
{
	public bool ShouldPool; 
	private bool _disposed; 
	public int runState; 
	public int numStorageSlots; 
	public int breedIndex; 
	public float staminaSeconds; 
	public float currentMaxStaminaSeconds; 
	public float maxSpeed; 


	public static void ResetToPool(Horse instance) { }

	public void ResetToPool() { }

	public virtual void Dispose() { }

	public virtual void EnterPool() { }

	public virtual void LeavePool() { }

	public void CopyTo(Horse instance) { }

	public Horse Copy() { }

	public static Horse Deserialize(Stream stream) { }

	public static Horse DeserializeLengthDelimited(Stream stream) { }

	public static Horse DeserializeLength(Stream stream, int length) { }

	public static Horse Deserialize(byte[] buffer) { }

	public void FromProto(Stream stream, bool isDelta = False) { }

	public virtual void WriteToStream(Stream stream) { }

	public virtual void WriteToStreamDelta(Stream stream, Horse previous) { }

	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	public static Horse Deserialize(byte[] buffer, Horse instance, bool isDelta = False) { }

	public static Horse Deserialize(Stream stream, Horse instance, bool isDelta) { }

	public static Horse DeserializeLengthDelimited(Stream stream, Horse instance, bool isDelta) { }

	public static Horse DeserializeLength(Stream stream, int length, Horse instance, bool isDelta) { }

	public static void SerializeDelta(Stream stream, Horse instance, Horse previous) { }

	public static void Serialize(Stream stream, Horse instance) { }

	public byte[] ToProtoBytes() { }

	public void ToProto(Stream stream) { }

	public static byte[] SerializeToBytes(Horse instance) { }

	public static void SerializeLengthDelimited(Stream stream, Horse instance) { }

	public void .ctor() { }

}

public class Horse : BaseAnimalNPC // TypeDefIndex: 10642
{
	[ServerVar] 
	public static float Population; 

	public override float RealisticMass { get; }
	public override BaseEntity.TraitFlag Traits { get; }


	public override float get_RealisticMass() { }

	public override BaseEntity.TraitFlag get_Traits() { }

	public override string Categorize() { }

	public void .ctor() { }

	private static void .cctor() { }

}

