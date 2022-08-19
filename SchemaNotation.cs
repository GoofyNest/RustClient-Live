internal sealed class SchemaNotation // TypeDefIndex: 2284
{	// Fields
	private XmlQualifiedName name; // 0x10
	private string systemLiteral; // 0x18
	private string pubid; // 0x20

	// Properties
	internal XmlQualifiedName Name { get; }
	internal string SystemLiteral { get; set; }
	internal string Pubid { get; set; }

	// Methods

	// RVA: 0x6C0000 Offset: 0x6BF400 VA: 0x1806C0000
	internal void .ctor(XmlQualifiedName name) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	internal XmlQualifiedName get_Name() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	internal string get_SystemLiteral() { }

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	internal void set_SystemLiteral(string value) { }

	// RVA: 0x497E00 Offset: 0x497200 VA: 0x180497E00
	internal string get_Pubid() { }

	// RVA: 0x497E30 Offset: 0x497230 VA: 0x180497E30
	internal void set_Pubid(string value) { }

}

