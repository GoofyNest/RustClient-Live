internal sealed class SizedArray : ICloneable // TypeDefIndex: 1119
{	// Fields
	internal object[] objects; // 0x10
	internal object[] negObjects; // 0x18

	// Properties
	internal object Item { get; set; }

	// Methods

	// RVA: 0x11FE9E0 Offset: 0x11FDDE0 VA: 0x1811FE9E0
	internal void .ctor() { }

	// RVA: 0x11FE960 Offset: 0x11FDD60 VA: 0x1811FE960
	internal void .ctor(int length) { }

	// RVA: 0x11FEA60 Offset: 0x11FDE60 VA: 0x1811FEA60
	private void .ctor(SizedArray sizedArray) { }

	// RVA: 0x11FE680 Offset: 0x11FDA80 VA: 0x1811FE680 Slot: 4
	public object Clone() { }

	// RVA: 0x11FEB40 Offset: 0x11FDF40 VA: 0x1811FEB40
	internal object get_Item(int index) { }

	// RVA: 0x11FEBC0 Offset: 0x11FDFC0 VA: 0x1811FEBC0
	internal void set_Item(int index, object value) { }

	// RVA: 0x11FE790 Offset: 0x11FDB90 VA: 0x1811FE790
	internal void IncreaseCapacity(int index) { }

}

