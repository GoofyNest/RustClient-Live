public sealed class Pointer : ISerializable // TypeDefIndex: 546
{	// Fields
	private void* _ptr; // 0x10
	private RuntimeType _ptrType; // 0x18

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x18CEEA0 Offset: 0x18CE2A0 VA: 0x1818CEEA0
	private void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18CEC20 Offset: 0x18CE020 VA: 0x1818CEC20
	public static object Box(void* ptr, Type type) { }

	// RVA: 0x18CEE10 Offset: 0x18CE210 VA: 0x1818CEE10 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

}

public class PointER // TypeDefIndex: 6874
{	// Fields
	public float x; // 0x10
	public float y; // 0x14
	public float z; // 0x18

	// Methods

	// RVA: 0x23129A0 Offset: 0x2311DA0 VA: 0x1823129A0
	public void .ctor(float x, float y, float z) { }

	// RVA: 0x2312900 Offset: 0x2311D00 VA: 0x182312900 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2312840 Offset: 0x2311C40 VA: 0x182312840 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x23129F0 Offset: 0x2311DF0 VA: 0x1823129F0
	public static bool op_Equality(PointER left, PointER right) { }

}

