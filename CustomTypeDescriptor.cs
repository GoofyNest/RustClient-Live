public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2681
{
// Namespace: System.ComponentModel
public class ComponentConverter : ReferenceConverter // TypeDefIndex: 2679

// Namespace: System.ComponentModel
public class CultureInfoConverter : TypeConverter // TypeDefIndex: 2680

// Namespace: System.ComponentModel
public abstract class CustomTypeDescriptor : ICustomTypeDescriptor // TypeDefIndex: 2681
	// Fields
	private ICustomTypeDescriptor _parent; // 0x10

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x159A300 Offset: 0x1599700 VA: 0x18159A300 Slot: 9
	public virtual AttributeCollection GetAttributes() { }

	// RVA: 0x159A3F0 Offset: 0x15997F0 VA: 0x18159A3F0 Slot: 10
	public virtual TypeConverter GetConverter() { }

	// RVA: 0x159A4C0 Offset: 0x15998C0 VA: 0x18159A4C0 Slot: 11
	public virtual PropertyDescriptorCollection GetProperties() { }

	// RVA: 0x159A5B0 Offset: 0x15999B0 VA: 0x18159A5B0 Slot: 12
	public virtual PropertyDescriptorCollection GetProperties(Attribute[] attributes) { }

	// RVA: 0x159A6A0 Offset: 0x1599AA0 VA: 0x18159A6A0 Slot: 13
	public virtual object GetPropertyOwner(PropertyDescriptor pd) { }

}

