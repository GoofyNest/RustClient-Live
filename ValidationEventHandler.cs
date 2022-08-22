public sealed class ValidationEventHandler : MulticastDelegate // TypeDefIndex: 2288
{
	public void .ctor(object object, IntPtr method) { }

	public virtual void Invoke(object sender, ValidationEventArgs e) { }

	public virtual IAsyncResult BeginInvoke(object sender, ValidationEventArgs e, AsyncCallback callback, object object) { }

	public virtual void EndInvoke(IAsyncResult result) { }

}

