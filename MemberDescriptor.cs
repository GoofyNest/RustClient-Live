public abstract class MemberDescriptor // TypeDefIndex: 2729
{	// Fields
	private string name; // 0x10
	private string displayName; // 0x18
	private int nameHash; // 0x20
	private AttributeCollection attributeCollection; // 0x28
	private Attribute[] attributes; // 0x30
	private Attribute[] originalAttributes; // 0x38
	private bool attributesFiltered; // 0x40
	private bool attributesFilled; // 0x41
	private int metadataVersion; // 0x44
	private string category; // 0x48
	private string description; // 0x50
	private object lockCookie; // 0x58

	// Properties
	protected virtual Attribute[] AttributeArray { get; set; }
	public virtual AttributeCollection Attributes { get; }
	public virtual string Name { get; }
	protected virtual int NameHashCode { get; }
	public virtual string DisplayName { get; }

	// Methods

	// RVA: 0x15A4DC0 Offset: 0x15A41C0 VA: 0x1815A4DC0
	protected void .ctor(string name, Attribute[] attributes) { }

	// RVA: 0x15A4F00 Offset: 0x15A4300 VA: 0x1815A4F00
	protected void .ctor(MemberDescriptor oldMemberDescriptor, Attribute[] newAttributes) { }

	// RVA: 0x15A52E0 Offset: 0x15A46E0 VA: 0x1815A52E0 Slot: 4
	protected virtual Attribute[] get_AttributeArray() { }

	// RVA: 0x15A5580 Offset: 0x15A4980 VA: 0x1815A5580 Slot: 5
	protected virtual void set_AttributeArray(Attribute[] value) { }

	// RVA: 0x15A5310 Offset: 0x15A4710 VA: 0x1815A5310 Slot: 6
	public virtual AttributeCollection get_Attributes() { }

	// RVA: 0x15A5540 Offset: 0x15A4940 VA: 0x1815A5540 Slot: 7
	public virtual string get_Name() { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 8
	protected virtual int get_NameHashCode() { }

	// RVA: 0x15A5410 Offset: 0x15A4810 VA: 0x1815A5410 Slot: 9
	public virtual string get_DisplayName() { }

	// RVA: 0x15A40E0 Offset: 0x15A34E0 VA: 0x1815A40E0
	private void CheckAttributesValid() { }

	// RVA: 0x15A41C0 Offset: 0x15A35C0 VA: 0x1815A41C0 Slot: 10
	protected virtual AttributeCollection CreateAttributeCollection() { }

	// RVA: 0x15A4230 Offset: 0x15A3630 VA: 0x1815A4230 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15A44D0 Offset: 0x15A38D0 VA: 0x1815A44D0 Slot: 11
	protected virtual void FillAttributes(IList attributeList) { }

	// RVA: 0x15A4600 Offset: 0x15A3A00 VA: 0x1815A4600
	private void FilterAttributesIfNeeded() { }

	// RVA: 0x15A4AE0 Offset: 0x15A3EE0 VA: 0x1815A4AE0
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType) { }

	// RVA: 0x15A4B60 Offset: 0x15A3F60 VA: 0x1815A4B60
	protected static MethodInfo FindMethod(Type componentClass, string name, Type[] args, Type returnType, bool publicOnly) { }

	// RVA: 0x4D0170 Offset: 0x4CF570 VA: 0x1804D0170 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15A4C10 Offset: 0x15A4010 VA: 0x1815A4C10 Slot: 12
	protected virtual object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15A4D10 Offset: 0x15A4110 VA: 0x1815A4D10
	protected static ISite GetSite(object component) { }

}

