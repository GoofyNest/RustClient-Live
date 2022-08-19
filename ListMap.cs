internal class ListMap : ObjectMap // TypeDefIndex: 2129
{	// Fields
	private XmlTypeMapElementInfoList _itemInfo; // 0x10
	private string _choiceMember; // 0x18

	// Properties
	public string ChoiceMember { set; }
	public XmlTypeMapElementInfoList ItemInfo { get; set; }

	// Methods

	// RVA: 0x4D0180 Offset: 0x4CF580 VA: 0x1804D0180
	public void set_ChoiceMember(string value) { }

	// RVA: 0x4B9460 Offset: 0x4B8860 VA: 0x1804B9460
	public XmlTypeMapElementInfoList get_ItemInfo() { }

	// RVA: 0x4B94C0 Offset: 0x4B88C0 VA: 0x1804B94C0
	public void set_ItemInfo(XmlTypeMapElementInfoList value) { }

	// RVA: 0x10FBB00 Offset: 0x10FAF00 VA: 0x1810FBB00
	public XmlTypeMapElementInfo FindElement(object ob, int index, object memberValue) { }

	// RVA: 0x10FC130 Offset: 0x10FB530 VA: 0x1810FC130
	public XmlTypeMapElementInfo FindElement(string elementName, string ns) { }

	// RVA: 0x10FC330 Offset: 0x10FB730 VA: 0x1810FC330
	public XmlTypeMapElementInfo FindTextElement() { }

	// RVA: 0x10FC510 Offset: 0x10FB910 VA: 0x1810FC510
	public void GetArrayType(int itemCount, out string localName, out string ns) { }

	// RVA: 0x10FB980 Offset: 0x10FAD80 VA: 0x1810FB980 Slot: 0
	public override bool Equals(object other) { }

	// RVA: 0xCC95C0 Offset: 0xCC89C0 VA: 0x180CC95C0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

}

