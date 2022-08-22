public sealed class Pointer : ISerializable // TypeDefIndex: 546
{	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18


	private void .ctor() { }

	private void .ctor(SerializationInfo info, StreamingContext context) { }

	public static object Box(void* ptr, Type type) { }

	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class PointER // TypeDefIndex: 6874
{	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18


	public void .ctor(float x, float y, float z) { }

	public override int GetHashCode() { }

	public override bool Equals(object obj) { }

	public static bool op_Equality(PointER left, PointER right) { }

}

