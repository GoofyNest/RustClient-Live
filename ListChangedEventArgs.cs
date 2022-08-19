public class ListChangedEventArgs : EventArgs // TypeDefIndex: 2725
{	// Fields
	private ListChangedType listChangedType; // 0x10
	private int newIndex; // 0x14
	private int oldIndex; // 0x18
	private PropertyDescriptor propDesc; // 0x20

	// Properties
	public ListChangedType ListChangedType { get; }
	public int NewIndex { get; }
	public int OldIndex { get; }

	// Methods

	// RVA: 0x15A3080 Offset: 0x15A2480 VA: 0x1815A3080
	public void .ctor(ListChangedType listChangedType, int newIndex) { }

	// RVA: 0x15A2FE0 Offset: 0x15A23E0 VA: 0x1815A2FE0
	public void .ctor(ListChangedType listChangedType, int newIndex, PropertyDescriptor propDesc) { }

	// RVA: 0x15A2F60 Offset: 0x15A2360 VA: 0x1815A2F60
	public void .ctor(ListChangedType listChangedType, PropertyDescriptor propDesc) { }

	// RVA: 0x15A2EE0 Offset: 0x15A22E0 VA: 0x1815A2EE0
	public void .ctor(ListChangedType listChangedType, int newIndex, int oldIndex) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480
	public ListChangedType get_ListChangedType() { }

	// RVA: 0x596230 Offset: 0x595630 VA: 0x180596230
	public int get_NewIndex() { }

	// RVA: 0x4BE200 Offset: 0x4BD600 VA: 0x1804BE200
	public int get_OldIndex() { }

}

