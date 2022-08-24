internal abstract class X509CertificateImpl : IDisposable // TypeDefIndex: 1018
{
	private byte[] cachedCertificateHash; 

public abstract bool IsValid { get; }


public abstract bool get_IsValid();

protected void ThrowIfContextInvalid() { }

public abstract X509CertificateImpl Clone();

public abstract string GetIssuerName(bool legacyV1Mode);

public abstract string GetSubjectName(bool legacyV1Mode);

public abstract byte[] GetRawCertData();

public abstract DateTime GetValidFrom();

public abstract DateTime GetValidUntil();

public byte[] GetCertHash() { }

protected abstract byte[] GetCertHash(bool lazy);

public override int GetHashCode() { }

public abstract bool Equals(X509CertificateImpl other, out bool result);

public abstract byte[] GetSerialNumber();

public abstract string ToString(bool full);

public override bool Equals(object obj) { }

public void Dispose() { }

protected virtual void Dispose(bool disposing) { }

protected override void Finalize() { }

protected void .ctor() { }

}

