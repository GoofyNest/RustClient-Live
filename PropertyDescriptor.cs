public abstract class PropertyDescriptor : MemberDescriptor // TypeDefIndex: 2734
{	// Fields
	private TypeConverter converter; // 0x60
	private Hashtable valueChangedHandlers; // 0x68
	private object[] editors; // 0x70
	private Type[] editorTypes; // 0x78
	private int editorCount; // 0x80

	// Properties
	public abstract Type ComponentType { get; }
	public virtual TypeConverter Converter { get; }
	public abstract bool IsReadOnly { get; }
	public abstract Type PropertyType { get; }

	// Methods

	// RVA: 0x15AD970 Offset: 0x15ACD70 VA: 0x1815AD970
	protected void .ctor(string name, Attribute[] attrs) { }

	// RVA: 0x15AD960 Offset: 0x15ACD60 VA: 0x1815AD960
	protected void .ctor(MemberDescriptor descr, Attribute[] attrs) { }

	// RVA: -1 Offset: -1 Slot: 13
	public abstract Type get_ComponentType();

	// RVA: 0x15AD980 Offset: 0x15ACD80 VA: 0x1815AD980 Slot: 14
	public virtual TypeConverter get_Converter() { }

	// RVA: -1 Offset: -1 Slot: 15
	public abstract bool get_IsReadOnly();

	// RVA: -1 Offset: -1 Slot: 16
	public abstract Type get_PropertyType();

	// RVA: 0x15AD1C0 Offset: 0x15AC5C0 VA: 0x1815AD1C0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x15ACF90 Offset: 0x15AC390 VA: 0x1815ACF90
	protected object CreateInstance(Type type) { }

	// RVA: 0x15AD350 Offset: 0x15AC750 VA: 0x1815AD350 Slot: 11
	protected override void FillAttributes(IList attributeList) { }

	// RVA: 0x15AD4B0 Offset: 0x15AC8B0 VA: 0x1815AD4B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x15AD510 Offset: 0x15AC910 VA: 0x1815AD510 Slot: 12
	protected override object GetInvocationTarget(Type type, object instance) { }

	// RVA: 0x15AD670 Offset: 0x15ACA70 VA: 0x1815AD670
	protected Type GetTypeFromName(string typeName) { }

	// RVA: -1 Offset: -1 Slot: 17
	public abstract object GetValue(object component);

	// RVA: 0x15AD8C0 Offset: 0x15ACCC0 VA: 0x1815AD8C0 Slot: 18
	protected virtual void OnValueChanged(object component, EventArgs e) { }

	// RVA: -1 Offset: -1 Slot: 19
	public abstract void SetValue(object component, object value);

	// RVA: -1 Offset: -1 Slot: 20
	public abstract bool ShouldSerializeValue(object component);

}

