public class SortKey // TypeDefIndex: 733
{	// Fields
	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	// Properties
	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }

	// Methods

	// RVA: 0x1380AA0 Offset: 0x137FEA0 VA: 0x181380AA0
	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	// RVA: 0x1381190 Offset: 0x1380590 VA: 0x181381190
	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	// RVA: 0x1381210 Offset: 0x1380610 VA: 0x181381210
	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460 Slot: 4
	public virtual string get_OriginalString() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 5
	public virtual byte[] get_KeyData() { }

	// RVA: 0x1380C70 Offset: 0x1380070 VA: 0x181380C70 Slot: 0
	public override bool Equals(object value) { }

	// RVA: 0x1380E20 Offset: 0x1380220 VA: 0x181380E20 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1380EB0 Offset: 0x13802B0 VA: 0x181380EB0 Slot: 3
	public override string ToString() { }

	// RVA: 0x13811E0 Offset: 0x13805E0 VA: 0x1813811E0
	internal void .ctor() { }

}

