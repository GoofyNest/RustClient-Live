internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 21
{	// Fields
	private RuntimeGPtrArrayHandle handle; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F66B0 Offset: 0x1F5AB0 VA: 0x1801F66B0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F69B0 Offset: 0x1F5DB0 VA: 0x1801F69B0 Slot: 4
	public void Dispose() { }

	// RVA: 0x1F6800 Offset: 0x1F5C00 VA: 0x1801F6800
	internal int get_Length() { }

	// RVA: 0x1F67F0 Offset: 0x1F5BF0 VA: 0x1801F67F0
	internal IntPtr get_Item(int i) { }

}

