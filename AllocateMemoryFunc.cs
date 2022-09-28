public sealed class AllocateMemoryFunc : MulticastDelegate // TypeDefIndex: 9817
{

	public void .ctor(object object, IntPtr method) { }

	public virtual IntPtr Invoke(UIntPtr sizeInBytes, UIntPtr alignment) { }

	public virtual IAsyncResult BeginInvoke(UIntPtr sizeInBytes, UIntPtr alignment, AsyncCallback callback, object object) { }

	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

