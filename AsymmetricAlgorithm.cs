public abstract class AsymmetricAlgorithm : IDisposable // TypeDefIndex: 938
{	// Fields
	protected int KeySizeValue; // 0x10
	protected KeySizes[] LegalKeySizesValue; // 0x18

	// Properties
	public virtual int KeySize { get; set; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	protected void .ctor() { }

	// RVA: 0x16F11C0 Offset: 0x16F05C0 VA: 0x1816F11C0 Slot: 4
	public void Dispose() { }

	// RVA: 0x16F11C0 Offset: 0x16F05C0 VA: 0x1816F11C0
	public void Clear() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	protected virtual void Dispose(bool disposing) { }

	// RVA: 0x36A480 Offset: 0x369880 VA: 0x18036A480 Slot: 6
	public virtual int get_KeySize() { }

	// RVA: 0x16F12D0 Offset: 0x16F06D0 VA: 0x1816F12D0 Slot: 7
	public virtual void set_KeySize(int value) { }

	// RVA: 0x16F1230 Offset: 0x16F0630 VA: 0x1816F1230 Slot: 8
	public virtual void FromXmlString(string xmlString) { }

	// RVA: 0x16F1280 Offset: 0x16F0680 VA: 0x1816F1280 Slot: 9
	public virtual string ToXmlString(bool includePrivateParameters) { }

}

