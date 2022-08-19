public sealed class ReflectionTypeLoadException : SystemException, ISerializable // TypeDefIndex: 548
{	// Fields
	private Type[] _classes; // 0x88
	private Exception[] _exceptions; // 0x90

	// Properties
	public Type[] Types { get; }

	// Methods

	// RVA: 0x18CFF20 Offset: 0x18CF320 VA: 0x1818CFF20
	private void .ctor() { }

	// RVA: 0x18CFF80 Offset: 0x18CF380 VA: 0x1818CFF80
	public void .ctor(Type[] classes, Exception[] exceptions) { }

	// RVA: 0x18CFFF0 Offset: 0x18CF3F0 VA: 0x1818CFFF0
	internal void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x58DBD0 Offset: 0x58CFD0 VA: 0x18058DBD0
	public Type[] get_Types() { }

	// RVA: 0x18CFDF0 Offset: 0x18CF1F0 VA: 0x1818CFDF0 Slot: 10
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

}

