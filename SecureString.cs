public sealed class SecureString : IDisposable // TypeDefIndex: 903
{
	private int length; 
	private bool disposed; 
	private byte[] data; 

public int Length { get; }


public void .ctor() { }

	[CLSCompliantAttribute] 
public void .ctor(char* value, int length) { }

public int get_Length() { }

public void Dispose() { }

private void Encrypt() { }

private void Decrypt() { }

private void Alloc(int length, bool realloc) { }

internal byte[] GetBuffer() { }

}

