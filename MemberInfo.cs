public abstract class MemberInfo : ICustomAttributeProvider, _MemberInfo // TypeDefIndex: 535
{	// Properties
	public abstract MemberTypes MemberType { get; }
	public abstract string Name { get; }
	public abstract Type DeclaringType { get; }
	public abstract Type ReflectedType { get; }
	public virtual int MetadataToken { get; }
	public virtual Module Module { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: -1 Offset: -1 Slot: 7
	public abstract MemberTypes get_MemberType();

	// RVA: -1 Offset: -1 Slot: 8
	public abstract string get_Name();

	// RVA: -1 Offset: -1 Slot: 9
	public abstract Type get_DeclaringType();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract Type get_ReflectedType();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract object[] GetCustomAttributes(bool inherit);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract object[] GetCustomAttributes(Type attributeType, bool inherit);

	// RVA: -1 Offset: -1 Slot: 13
	public abstract bool IsDefined(Type attributeType, bool inherit);

	// RVA: 0x18C67A0 Offset: 0x18C5BA0 VA: 0x1818C67A0 Slot: 14
	public virtual IList<CustomAttributeData> GetCustomAttributesData() { }

	// RVA: 0x18C67F0 Offset: 0x18C5BF0 VA: 0x1818C67F0 Slot: 15
	public virtual int get_MetadataToken() { }

	// RVA: 0x18C6800 Offset: 0x18C5C00 VA: 0x1818C6800 Slot: 16
	public virtual Module get_Module() { }

	// RVA: 0x18C6930 Offset: 0x18C5D30 VA: 0x1818C6930
	public static bool op_Equality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x18C6CF0 Offset: 0x18C60F0 VA: 0x1818C6CF0
	public static bool op_Inequality(MemberInfo left, MemberInfo right) { }

	// RVA: 0x18C6790 Offset: 0x18C5B90 VA: 0x1818C6790 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

}

