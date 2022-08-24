internal sealed class SchemaEntity : IDtdEntityInfo // TypeDefIndex: 2278
{
	private XmlQualifiedName qname; 
	private string url; 
	private string pubid; 
	private string text; 
	private XmlQualifiedName ndata; 
	private int lineNumber; 
	private int linePosition; 
	private bool isParameter; 
	private bool isExternal; 
	private bool parsingInProgress; 
	private bool isDeclaredInExternal; 
	private string baseURI; 
	private string declaredURI; 

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


	internal void .ctor(XmlQualifiedName qname, bool isParameter) { }

	private string System.Xml.IDtdEntityInfo.get_Name() { }

	private bool System.Xml.IDtdEntityInfo.get_IsExternal() { }

	private bool System.Xml.IDtdEntityInfo.get_IsDeclaredInExternal() { }

	private bool System.Xml.IDtdEntityInfo.get_IsUnparsedEntity() { }

	private bool System.Xml.IDtdEntityInfo.get_IsParameterEntity() { }

	private string System.Xml.IDtdEntityInfo.get_BaseUriString() { }

	private string System.Xml.IDtdEntityInfo.get_DeclaredUriString() { }

	private string System.Xml.IDtdEntityInfo.get_SystemId() { }

	private string System.Xml.IDtdEntityInfo.get_PublicId() { }

	private string System.Xml.IDtdEntityInfo.get_Text() { }

	private int System.Xml.IDtdEntityInfo.get_LineNumber() { }

	private int System.Xml.IDtdEntityInfo.get_LinePosition() { }

	internal static bool IsPredefinedEntity(string n) { }

	internal XmlQualifiedName get_Name() { }

	internal string get_Url() { }

	internal void set_Url(string value) { }

	internal string get_Pubid() { }

	internal void set_Pubid(string value) { }

	internal bool get_IsExternal() { }

	internal void set_IsExternal(bool value) { }

	internal bool get_DeclaredInExternal() { }

	internal void set_DeclaredInExternal(bool value) { }

	internal XmlQualifiedName get_NData() { }

	internal void set_NData(XmlQualifiedName value) { }

	internal string get_Text() { }

	internal void set_Text(string value) { }

	internal int get_Line() { }

	internal void set_Line(int value) { }

	internal int get_Pos() { }

	internal void set_Pos(int value) { }

	internal string get_BaseURI() { }

	internal void set_BaseURI(string value) { }

	internal bool get_ParsingInProgress() { }

	internal void set_ParsingInProgress(bool value) { }

	internal string get_DeclaredURI() { }

	internal void set_DeclaredURI(string value) { }

}

