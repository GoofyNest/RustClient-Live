internal sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 62
{	// Fields
	private bool readOnly; // 0x18

	// Methods

	// RVA: 0x1057B30 Offset: 0x1056F30 VA: 0x181057B30
	public void .ctor() { }

	// RVA: 0x1595C50 Offset: 0x1595050 VA: 0x181595C50
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x1595C20 Offset: 0x1595020 VA: 0x181595C20 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

}

public sealed class X509ExtensionCollection : CollectionBase, IEnumerable // TypeDefIndex: 1720
{	// Fields
	private bool readOnly; // 0x18

	// Properties
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x1057B30 Offset: 0x1056F30 VA: 0x181057B30
	public void .ctor() { }

	// RVA: 0x227C1A0 Offset: 0x227B5A0 VA: 0x18227C1A0
	public void .ctor(ASN1 asn1) { }

	// RVA: 0x227BFE0 Offset: 0x227B3E0 VA: 0x18227BFE0
	public int IndexOf(string oid) { }

	// RVA: 0x1595C20 Offset: 0x1595020 VA: 0x181595C20 Slot: 18
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x227C2C0 Offset: 0x227B6C0 VA: 0x18227C2C0
	public X509Extension get_Item(string oid) { }

}

public sealed class X509ExtensionCollection : ICollection, IEnumerable // TypeDefIndex: 2832
{	// Fields
	private static byte[] Empty; // 0x0
	private ArrayList _list; // 0x10

	// Properties
	public int Count { get; }
	public object SyncRoot { get; }
	public X509Extension Item { get; }

	// Methods

	// RVA: 0x14DCFF0 Offset: 0x14DC3F0 VA: 0x1814DCFF0
	internal void .ctor(X509Certificate cert) { }

	// RVA: 0xB147D0 Offset: 0xB13BD0 VA: 0x180B147D0 Slot: 5
	public int get_Count() { }

	// RVA: 0x4B0E80 Offset: 0x4B0280 VA: 0x1804B0E80 Slot: 6
	public object get_SyncRoot() { }

	// RVA: 0x14DD460 Offset: 0x14DC860 VA: 0x1814DD460
	public X509Extension get_Item(string oid) { }

	// RVA: 0x14DCDF0 Offset: 0x14DC1F0 VA: 0x1814DCDF0 Slot: 4
	private void System.Collections.ICollection.CopyTo(Array array, int index) { }

	// RVA: 0x14DCD60 Offset: 0x14DC160 VA: 0x1814DCD60
	public X509ExtensionEnumerator GetEnumerator() { }

	// RVA: 0x14DCF10 Offset: 0x14DC310 VA: 0x1814DCF10 Slot: 7
	private IEnumerator System.Collections.IEnumerable.GetEnumerator() { }

	// RVA: 0x14DCFA0 Offset: 0x14DC3A0 VA: 0x1814DCFA0
	private static void .cctor() { }

}

