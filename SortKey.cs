public class SortKey // TypeDefIndex: 733
{
	private readonly string source; 
	private readonly byte[] key; 
	private readonly CompareOptions options; 
	private readonly int lcid; 

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

