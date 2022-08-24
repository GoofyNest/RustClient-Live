internal sealed class SimpleAsyncCallback : MulticastDelegate // TypeDefIndex: 3021
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(SimpleAsyncResult result) { }

public virtual IAsyncResult BeginInvoke(SimpleAsyncResult result, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

