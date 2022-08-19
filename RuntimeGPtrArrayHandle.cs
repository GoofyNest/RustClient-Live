internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 10
{	// Fields
	private RuntimeStructs.GPtrArray* value; // 0x0

	// Properties
	internal int Length { get; }
	internal IntPtr Item { get; }

	// Methods

	// RVA: 0x1F66B0 Offset: 0x1F5AB0 VA: 0x1801F66B0
	internal void .ctor(IntPtr ptr) { }

	// RVA: 0x1F6800 Offset: 0x1F5C00 VA: 0x1801F6800
	internal int get_Length() { }

	// RVA: 0x1F67F0 Offset: 0x1F5BF0 VA: 0x1801F67F0
	internal IntPtr get_Item(int i) { }

	// RVA: 0x1F67E0 Offset: 0x1F5BE0 VA: 0x1801F67E0
	internal IntPtr Lookup(int i) { }

	// RVA: 0x1644DB0 Offset: 0x16441B0 VA: 0x181644DB0
	private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

	// RVA: 0x1644D90 Offset: 0x1644190 VA: 0x181644D90
	internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

}

