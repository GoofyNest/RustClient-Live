public class X509ChainElement // TypeDefIndex: 2823
{
	private X509Certificate2 certificate; 
	private X509ChainStatus[] status; 
	private string info; 
	private X509ChainStatusFlags compressed_status_flags; 

public X509Certificate2 Certificate { get; }
public X509ChainStatus[] ChainElementStatus { get; }
internal X509ChainStatusFlags StatusFlags { get; set; }


internal void .ctor(X509Certificate2 certificate) { }

public X509Certificate2 get_Certificate() { }

public X509ChainStatus[] get_ChainElementStatus() { }

internal X509ChainStatusFlags get_StatusFlags() { }

internal void set_StatusFlags(X509ChainStatusFlags value) { }

private int Count(X509ChainStatusFlags flags) { }

private void Set(X509ChainStatus[] status, ref int position, X509ChainStatusFlags flags, X509ChainStatusFlags mask) { }

internal void UncompressFlags() { }

}

