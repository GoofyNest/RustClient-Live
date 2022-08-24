public sealed class UnhandledExceptionEventHandler : MulticastDelegate // TypeDefIndex: 331
{

public void .ctor(object object, IntPtr method) { }

public virtual void Invoke(object sender, UnhandledExceptionEventArgs e) { }

public virtual IAsyncResult BeginInvoke(object sender, UnhandledExceptionEventArgs e, AsyncCallback callback, object object) { }

public virtual void EndInvoke(IAsyncResult result) { }

}

