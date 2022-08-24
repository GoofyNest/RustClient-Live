internal abstract class X509ChainImpl : IDisposable // TypeDefIndex: 2826
{
public abstract bool IsValid { get; }
public abstract X509ChainPolicy ChainPolicy { get; set; }
public abstract X509ChainStatus[] ChainStatus { get; }


public abstract bool get_IsValid();

public abstract X509ChainPolicy get_ChainPolicy();

public abstract void set_ChainPolicy(X509ChainPolicy value);

public abstract X509ChainStatus[] get_ChainStatus();

public abstract bool Build(X509Certificate2 certificate);

public abstract void Reset();

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

protected override void Finalize() { }

protected void .ctor() { }

}

