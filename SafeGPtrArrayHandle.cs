internal struct SafeGPtrArrayHandle : IDisposable // TypeDefIndex: 21
{
	private RuntimeGPtrArrayHandle handle;

	internal int Length { get; }
	internal IntPtr Item { get; }


	internal void .ctor(IntPtr ptr) { }

	public void Dispose() { }

	internal int get_Length() { }

	internal IntPtr get_Item(int i) { }

}

