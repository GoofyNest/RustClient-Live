public class SortKey // TypeDefIndex: 733
{	private readonly string source; // 0x10
	private readonly byte[] key; // 0x18
	private readonly CompareOptions options; // 0x20
	private readonly int lcid; // 0x24

	public virtual string OriginalString { get; }
	public virtual byte[] KeyData { get; }


	public static int Compare(SortKey sortkey1, SortKey sortkey2) { }

	internal void .ctor(int lcid, string source, CompareOptions opt) { }

	internal void .ctor(int lcid, string source, byte[] buffer, CompareOptions opt, int lv1Length, int lv2Length, int lv3Length, int kanaSmallLength, int markTypeLength, int katakanaLength, int kanaWidthLength, int identLength) { }

	public virtual string get_OriginalString() { }

	public virtual byte[] get_KeyData() { }

	public override bool Equals(object value) { }

	public override int GetHashCode() { }

	public override string ToString() { }

	internal void .ctor() { }

}

