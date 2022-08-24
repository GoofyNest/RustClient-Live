internal class ListMap : ObjectMap // TypeDefIndex: 2129
{
	private XmlTypeMapElementInfoList _itemInfo; 
	private string _choiceMember; 

public string ChoiceMember { set; }
public XmlTypeMapElementInfoList ItemInfo { get; set; }


public void set_ChoiceMember(string value) { }

public XmlTypeMapElementInfoList get_ItemInfo() { }

public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

public XmlTypeMapElementInfo FindTextElement() { }

public void GetArrayType(int itemCount, out string localName, out string ns) { }

public override bool Equals(object other) { }

public override int GetHashCode() { }

public void .ctor() { }

}

