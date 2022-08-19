internal sealed class SerializationFieldInfo : FieldInfo // TypeDefIndex: 1057
{	// Fields
	private RuntimeFieldInfo m_field; // 0x10
	private string m_serializationName; // 0x18

	// Properties
	public override Module Module { get; }
	public override int MetadataToken { get; }
	public override string Name { get; }
	public override Type DeclaringType { get; }
	public override Type ReflectedType { get; }
	public override Type FieldType { get; }
	internal RuntimeFieldInfo FieldInfo { get; }
	public override RuntimeFieldHandle FieldHandle { get; }
	public override FieldAttributes Attributes { get; }

	// Methods

	// RVA: 0xBC4380 Offset: 0xBC3780 VA: 0x180BC4380 Slot: 16
	public override Module get_Module() { }

	// RVA: 0xBC4160 Offset: 0xBC3560 VA: 0x180BC4160 Slot: 15
	public override int get_MetadataToken() { }

	// RVA: 0x12A19F0 Offset: 0x12A0DF0 VA: 0x1812A19F0
	internal void .ctor(RuntimeFieldInfo field, string namePrefix) { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 8
	public override string get_Name() { }

	// RVA: 0xBC42E0 Offset: 0xBC36E0 VA: 0x180BC42E0 Slot: 9
	public override Type get_DeclaringType() { }

	// RVA: 0xBC4350 Offset: 0xBC3750 VA: 0x180BC4350 Slot: 10
	public override Type get_ReflectedType() { }

	// RVA: 0x12A1730 Offset: 0x12A0B30 VA: 0x1812A1730 Slot: 11
	public override object[] GetCustomAttributes(bool inherit) { }

	// RVA: 0x12A1700 Offset: 0x12A0B00 VA: 0x1812A1700 Slot: 12
	public override object[] GetCustomAttributes(Type attributeType, bool inherit) { }

	// RVA: 0x12A1990 Offset: 0x12A0D90 VA: 0x1812A1990 Slot: 13
	public override bool IsDefined(Type attributeType, bool inherit) { }

	// RVA: 0x12A1AA0 Offset: 0x12A0EA0 VA: 0x1812A1AA0 Slot: 19
	public override Type get_FieldType() { }

	// RVA: 0xD605F0 Offset: 0xD5F9F0 VA: 0x180D605F0 Slot: 20
	public override object GetValue(object obj) { }

	// RVA: 0x12A1760 Offset: 0x12A0B60 VA: 0x1812A1760
	internal object InternalGetValue(object obj) { }

	// RVA: 0x12A19C0 Offset: 0x12A0DC0 VA: 0x1812A19C0 Slot: 27
	public override void SetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x12A1850 Offset: 0x12A0C50 VA: 0x1812A1850
	internal void InternalSetValue(object obj, object value, BindingFlags invokeAttr, Binder binder, CultureInfo culture) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal RuntimeFieldInfo get_FieldInfo() { }

	// RVA: 0xBC43E0 Offset: 0xBC37E0 VA: 0x180BC43E0 Slot: 18
	public override RuntimeFieldHandle get_FieldHandle() { }

	// RVA: 0xBC4410 Offset: 0xBC3810 VA: 0x180BC4410 Slot: 17
	public override FieldAttributes get_Attributes() { }

}

