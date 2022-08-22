internal sealed class CachingEventHandler : MulticastDelegate // TypeDefIndex: 1942
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(XsdCachingReader cachingReader) { }

	public virtual IAsyncResult BeginInvoke(XsdCachingReader cachingReader, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

