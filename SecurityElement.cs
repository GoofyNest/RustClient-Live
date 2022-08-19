public sealed class SecurityElement // TypeDefIndex: 905
{	// Fields
	private string text; // 0x10
	private string tag; // 0x18
	private ArrayList attributes; // 0x20
	private ArrayList children; // 0x28
	private static readonly char[] invalid_tag_chars; // 0x0
	private static readonly char[] invalid_text_chars; // 0x8
	private static readonly char[] invalid_attr_name_chars; // 0x10
	private static readonly char[] invalid_attr_value_chars; // 0x18
	private static readonly char[] invalid_chars; // 0x20

	// Properties
	public Hashtable Attributes { get; }
	public ArrayList Children { get; }
	public string Tag { get; }
	public string Text { get; set; }
	internal string m_strText { set; }

	// Methods

	// RVA: 0x17BFA40 Offset: 0x17BEE40 VA: 0x1817BFA40
	public void .ctor(string tag) { }

	// RVA: 0x17BFA50 Offset: 0x17BEE50 VA: 0x1817BFA50
	public void .ctor(string tag, string text) { }

	// RVA: 0x17BFD00 Offset: 0x17BF100 VA: 0x1817BFD00
	public Hashtable get_Attributes() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	public ArrayList get_Children() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Tag() { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Text() { }

	// RVA: 0x17BFF70 Offset: 0x17BF370 VA: 0x1817BFF70
	public void set_Text(string value) { }

	// RVA: 0x17BE590 Offset: 0x17BD990 VA: 0x1817BE590
	public void AddAttribute(string name, string value) { }

	// RVA: 0x17BE730 Offset: 0x17BDB30 VA: 0x1817BE730
	public void AddChild(SecurityElement child) { }

	// RVA: 0x17BE800 Offset: 0x17BDC00 VA: 0x1817BE800
	public static string Escape(string str) { }

	// RVA: 0x17BF770 Offset: 0x17BEB70 VA: 0x1817BF770
	private static string Unescape(string str) { }

	// RVA: 0x17BE9E0 Offset: 0x17BDDE0 VA: 0x1817BE9E0
	public static SecurityElement FromString(string xml) { }

	// RVA: 0x17BECF0 Offset: 0x17BE0F0 VA: 0x1817BECF0
	public static bool IsValidAttributeName(string name) { }

	// RVA: 0x17BED70 Offset: 0x17BE170 VA: 0x1817BED70
	public static bool IsValidAttributeValue(string value) { }

	// RVA: 0x17BEDF0 Offset: 0x17BE1F0 VA: 0x1817BEDF0
	public static bool IsValidTag(string tag) { }

	// RVA: 0x17BEE70 Offset: 0x17BE270 VA: 0x1817BEE70
	public static bool IsValidText(string text) { }

	// RVA: 0x17BEEF0 Offset: 0x17BE2F0 VA: 0x1817BEEF0
	public SecurityElement SearchForChildByTag(string tag) { }

	// RVA: 0x17BF1F0 Offset: 0x17BE5F0 VA: 0x1817BF1F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x17BF280 Offset: 0x17BE680 VA: 0x1817BF280
	private void ToXml(ref StringBuilder s, int level) { }

	// RVA: 0x17BEB20 Offset: 0x17BDF20 VA: 0x1817BEB20
	internal SecurityElement.SecurityAttribute GetAttribute(string name) { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	internal void set_m_strText(string value) { }

	// RVA: 0x17BF030 Offset: 0x17BE430 VA: 0x1817BF030
	internal string SearchForTextOfLocalName(string strLocalName) { }

	// RVA: 0x17BF880 Offset: 0x17BEC80 VA: 0x1817BF880
	private static void .cctor() { }

}

internal class SecurityElement.SecurityAttribute // TypeDefIndex: 906
{	// Fields
	private string _name; // 0x10
	private string _value; // 0x18

	// Properties
	public string Name { get; }
	public string Value { get; }

	// Methods

	// RVA: 0x17BD770 Offset: 0x17BCB70 VA: 0x1817BD770
	public void .ctor(string name, string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public string get_Name() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Value() { }

}

