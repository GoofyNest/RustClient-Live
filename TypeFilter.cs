public sealed class TypeFilter : MulticastDelegate // TypeDefIndex: 553
{
	public void .ctor(object object, IntPtr method) { }

	public virtual bool Invoke(Type m, object filterCriteria) { }

	public virtual IAsyncResult BeginInvoke(Type m, object filterCriteria, AsyncCallback callback, object object) { }

	public virtual bool EndInvoke(IAsyncResult result) { }

}

