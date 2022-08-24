public abstract class DecoderFallbackBuffer // TypeDefIndex: 440
{
	internal byte* byteStart; 
	internal char* charEnd; 

public abstract int Remaining { get; }


public abstract bool Fallback(byte[] bytesUnknown, int index);

public abstract char GetNextChar();

public abstract int get_Remaining();

public virtual void Reset() { }

internal void InternalReset() { }

internal void InternalInitialize(byte* byteStart, char* charEnd) { }

internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

protected void .ctor() { }

}

