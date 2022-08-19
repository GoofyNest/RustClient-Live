internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 2278
{	// Fields
	private XmlQualifiedName qname; // 0x10
	private string url; // 0x18
	private string pubid; // 0x20
	private string text; // 0x28
	private XmlQualifiedName ndata; // 0x30
	private int lineNumber; // 0x38
	private int linePosition; // 0x3C
	private bool isParameter; // 0x40
	private bool isExternal; // 0x41
	private bool parsingInProgress; // 0x42
	private bool isDeclaredInExternal; // 0x43
	private string baseURI; // 0x48
	private string declaredURI; // 0x50

	// Properties
	private string System.Xml.IDtdEntityInfo.Name { get; }
	private bool System.Xml.IDtdEntityInfo.IsExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsDeclaredInExternal { get; }
	private bool System.Xml.IDtdEntityInfo.IsUnparsedEntity { get; }
	private bool System.Xml.IDtdEntityInfo.IsParameterEntity { get; }
	private string System.Xml.IDtdEntityInfo.BaseUriString { get; }
	private string System.Xml.IDtdEntityInfo.DeclaredUriString { get; }
	private string System.Xml.IDtdEntityInfo.SystemId { get; }
	private string System.Xml.IDtdEntityInfo.PublicId { get; }
	private string System.Xml.IDtdEntityInfo.Text { get; }
	private int System.Xml.IDtdEntityInfo.LineNumber { get; }
	private int System.Xml.IDtdEntityInfo.LinePosition { get; }
	internal XmlQualifiedName Name { get; }
	internal string Url { get; set; }
	internal string Pubid { get; set; }
	internal bool IsExternal { get; set; }
	internal bool DeclaredInExternal { get; set; }
	internal XmlQualifiedName NData { get; set; }
	internal string Text { get; set; }
	internal int Line { get; set; }
	internal int Pos { get; set; }
	internal string BaseURI { get; set; }
	internal bool ParsingInProgress { get; set; }
	internal string DeclaredURI { get; set; }

	// Methods

	// RVA: 0xEE1D80 Offset: 0xEE1180 VA: 0x180EE1D80
	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	// RVA: 0xB242C0 Offset: 0xB236C0 VA: 0x180B242C0 Slot: 4
	private string System.Xml.IDtdEntityInfo.get_Name() { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40 Slot: 5
	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	// RVA: 0xEE1D30 Offset: 0xEE1130 VA: 0x180EE1D30 Slot: 6
	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	// RVA: 0xEE1D50 Offset: 0xEE1150 VA: 0x180EE1D50 Slot: 7
	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0 Slot: 8
	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	// RVA: 0xEE1C90 Offset: 0xEE1090 VA: 0x180EE1C90 Slot: 9
	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	// RVA: 0xEE1CE0 Offset: 0xEE10E0 VA: 0x180EE1CE0 Slot: 10
	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710 Slot: 11
	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00 Slot: 12
	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230 Slot: 13
	private string System.Xml.IDtdEntityInfo.get_Text() { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70 Slot: 14
	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790 Slot: 15
	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	// RVA: 0xEE1BF0 Offset: 0xEE0FF0 VA: 0x180EE1BF0
	internal static bool IsPredefinedEntity(string n) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_Url() { }

	// RVA: 0xEE1F20 Offset: 0xEE1320 VA: 0x180EE1F20
	internal void set_Url(string value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal string get_Pubid() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_Pubid(string value) { }

	// RVA: 0xEE1D40 Offset: 0xEE1140 VA: 0x180EE1D40
	internal bool get_IsExternal() { }

	// RVA: 0xEE1EE0 Offset: 0xEE12E0 VA: 0x180EE1EE0
	internal void set_IsExternal(bool value) { }

	// RVA: 0xEE1D30 Offset: 0xEE1130 VA: 0x180EE1D30
	internal bool get_DeclaredInExternal() { }

	// RVA: 0xEE1ED0 Offset: 0xEE12D0 VA: 0x180EE1ED0
	internal void set_DeclaredInExternal(bool value) { }

	// RVA: 0x4A2EE0 Offset: 0x4A22E0 VA: 0x1804A2EE0
	internal XmlQualifiedName get_NData() { }

	// RVA: 0x4A2F10 Offset: 0x4A2310 VA: 0x1804A2F10
	internal void set_NData(XmlQualifiedName value) { }

	// RVA: 0x7CE230 Offset: 0x7CD630 VA: 0x1807CE230
	internal string get_Text() { }

	// RVA: 0xEE1F00 Offset: 0xEE1300 VA: 0x180EE1F00
	internal void set_Text(string value) { }

	// RVA: 0x516B70 Offset: 0x515F70 VA: 0x180516B70
	internal int get_Line() { }

	// RVA: 0xC53FC0 Offset: 0xC533C0 VA: 0x180C53FC0
	internal void set_Line(int value) { }

	// RVA: 0x5FC790 Offset: 0x5FBB90 VA: 0x1805FC790
	internal int get_Pos() { }

	// RVA: 0x8B1150 Offset: 0x8B0550 VA: 0x1808B1150
	internal void set_Pos(int value) { }

	// RVA: 0xEE1E20 Offset: 0xEE1220 VA: 0x180EE1E20
	internal string get_BaseURI() { }

	// RVA: 0x5F7050 Offset: 0x5F6450 VA: 0x1805F7050
	internal void set_BaseURI(string value) { }

	// RVA: 0xEE1EC0 Offset: 0xEE12C0 VA: 0x180EE1EC0
	internal bool get_ParsingInProgress() { }

	// RVA: 0xEE1EF0 Offset: 0xEE12F0 VA: 0x180EE1EF0
	internal void set_ParsingInProgress(bool value) { }

	// RVA: 0xEE1E70 Offset: 0xEE1270 VA: 0x180EE1E70
	internal string get_DeclaredURI() { }

	// RVA: 0x4CC370 Offset: 0x4CB770 VA: 0x1804CC370
	internal void set_DeclaredURI(string value) { }

}

