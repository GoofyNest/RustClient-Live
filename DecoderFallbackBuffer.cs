public abstract class DecoderFallbackBuffer // TypeDefIndex: 440
{	// Fields
	internal byte* byteStart; // 0x10
	internal char* charEnd; // 0x18

	// Properties
	public abstract int Remaining { get; }

	// Methods

	// RVA: -1 Offset: -1 Slot: 4
	public abstract bool Fallback(byte[] bytesUnknown, int index);

	// RVA: -1 Offset: -1 Slot: 5
	public abstract char GetNextChar();

	// RVA: -1 Offset: -1 Slot: 6
	public abstract int get_Remaining();

	// RVA: 0x18A6880 Offset: 0x18A5C80 VA: 0x1818A6880 Slot: 7
	public virtual void Reset() { }

	// RVA: 0x18A6860 Offset: 0x18A5C60 VA: 0x1818A6860
	internal void InternalReset() { }

	// RVA: 0x18A6850 Offset: 0x18A5C50 VA: 0x1818A6850
	internal void InternalInitialize(byte* byteStart, char* charEnd) { }

	// RVA: 0x18A6410 Offset: 0x18A5810 VA: 0x1818A6410 Slot: 8
	internal virtual bool InternalFallback(byte[] bytes, byte* pBytes, ref char* chars) { }

	// RVA: 0x18A6640 Offset: 0x18A5A40 VA: 0x1818A6640 Slot: 9
	internal virtual int InternalFallback(byte[] bytes, byte* pBytes) { }

	// RVA: 0x18A68B0 Offset: 0x18A5CB0 VA: 0x1818A68B0
	internal void ThrowLastBytesRecursive(byte[] bytesUnknown) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

}

