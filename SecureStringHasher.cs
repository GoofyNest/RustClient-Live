internal class SecureStringHasher : IEqualityComparer<string> // TypeDefIndex: 1866
{	// Fields
	private static SecureStringHasher.HashCodeOfStringDelegate hashCodeDelegate; // 0x0
	private int hashCodeRandomizer; // 0x10

	// Methods

	// RVA: 0x10FEC50 Offset: 0x10FE050 VA: 0x1810FEC50
	public void .ctor() { }

	// RVA: 0x10FE8A0 Offset: 0x10FDCA0 VA: 0x1810FE8A0 Slot: 4
	public bool Equals(string x, string y) { }

	// RVA: 0x10FEA80 Offset: 0x10FDE80 VA: 0x1810FEA80 Slot: 5
	public int GetHashCode(string key) { }

	// RVA: 0x10FEA00 Offset: 0x10FDE00 VA: 0x1810FEA00
	private static int GetHashCodeOfString(string key, int sLen, long additionalEntropy) { }

	// RVA: 0x10FE8C0 Offset: 0x10FDCC0 VA: 0x1810FE8C0
	private static SecureStringHasher.HashCodeOfStringDelegate GetHashCodeDelegate() { }

}

private sealed class SecureStringHasher.HashCodeOfStringDelegate : MulticastDelegate // TypeDefIndex: 1867
{	// Methods

	// RVA: 0x4971F0 Offset: 0x4965F0 VA: 0x1804971F0
	public void .ctor(object object, IntPtr method) { }

	// RVA: 0xB95ED0 Offset: 0xB952D0 VA: 0x180B95ED0 Slot: 12
	public virtual int Invoke(string s, int sLen, long additionalEntropy) { }

	// RVA: 0x10FB510 Offset: 0x10FA910 VA: 0x1810FB510 Slot: 13
	public virtual IAsyncResult BeginInvoke(string s, int sLen, long additionalEntropy, AsyncCallback callback, object object) { }

	// RVA: 0xB95EA0 Offset: 0xB952A0 VA: 0x180B95EA0 Slot: 14
	public virtual int EndInvoke(IAsyncResult result) { }

}

