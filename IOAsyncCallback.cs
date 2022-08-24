internal sealed class IOAsyncCallback : MulticastDelegate // TypeDefIndex: 2593
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(IOAsyncResult ioares) { }

public virtual IAsyncResult BeginInvoke(IOAsyncResult ioares, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

