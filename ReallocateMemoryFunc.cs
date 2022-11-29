public sealed class ReallocateMemoryFunc : MulticastDelegate // TypeDefIndex: 9880
{

	public void .ctor(object object, IntPtr method) { }

	public virtual IntPtr Invoke(IntPtr pointer, UIntPtr sizeInBytes, UIntPtr alignment) { }

	public virtual IAsyncResult BeginInvoke(IntPtr pointer, UIntPtr sizeInBytes, UIntPtr alignment, AsyncCallback callback, object object) { }

	public virtual IntPtr EndInvoke(IAsyncResult result) { }

}

