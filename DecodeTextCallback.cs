public sealed class DecodeTextCallback : MulticastDelegate // TypeDefIndex: 7606
{

	public void .ctor(object object, IntPtr method) { }

	public virtual string Invoke(byte[] bytes, ReadingSettings settings) { }

	public virtual IAsyncResult BeginInvoke(byte[] bytes, ReadingSettings settings, AsyncCallback callback, object object) { }

	public virtual string EndInvoke(IAsyncResult result) { }

}

