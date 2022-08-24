internal struct RuntimeGPtrArrayHandle // TypeDefIndex: 10
{
	private RuntimeStructs.GPtrArray* value; 

internal int Length { get; }
internal IntPtr Item { get; }


internal void .ctor(IntPtr ptr) { }

internal int get_Length() { }

internal IntPtr get_Item(int i) { }

internal IntPtr Lookup(int i) { }

private static void GPtrArrayFree(RuntimeStructs.GPtrArray* value) { }

internal static void DestroyAndFree(ref RuntimeGPtrArrayHandle h) { }

}

