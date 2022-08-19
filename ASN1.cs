internal class ASN1 // TypeDefIndex: 45
{	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1634520 Offset: 0x1633920 VA: 0x181634520
	public void .ctor(byte tag) { }

	// RVA: 0x16344E0 Offset: 0x16338E0 VA: 0x1816344E0
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1634340 Offset: 0x1633740 VA: 0x181634340
	public void .ctor(byte[] data) { }

	// RVA: 0x1634560 Offset: 0x1633960 VA: 0x181634560
	public int get_Count() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public byte get_Tag() { }

	// RVA: 0x1634660 Offset: 0x1633A60 VA: 0x181634660
	public int get_Length() { }

	// RVA: 0x1634670 Offset: 0x1633A70 VA: 0x181634670
	public byte[] get_Value() { }

	// RVA: 0x1634710 Offset: 0x1633B10 VA: 0x181634710
	public void set_Value(byte[] value) { }

	// RVA: 0x16333E0 Offset: 0x16327E0 VA: 0x1816333E0
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1633480 Offset: 0x1632880 VA: 0x181633480
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1633340 Offset: 0x1632740 VA: 0x181633340
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1633980 Offset: 0x1632D80 VA: 0x181633980 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1633660 Offset: 0x1632A60 VA: 0x181633660
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1633510 Offset: 0x1632910 VA: 0x181633510
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1634580 Offset: 0x1633980 VA: 0x181634580
	public ASN1 get_Item(int index) { }

	// RVA: 0x1633870 Offset: 0x1632C70 VA: 0x181633870
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1634070 Offset: 0x1633470 VA: 0x181634070 Slot: 3
	public override string ToString() { }

}

public class ASN1 // TypeDefIndex: 1704
{	// Fields
	private byte m_nTag; // 0x10
	private byte[] m_aValue; // 0x18
	private ArrayList elist; // 0x20

	// Properties
	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }

	// Methods

	// RVA: 0x1634520 Offset: 0x1633920 VA: 0x181634520
	public void .ctor(byte tag) { }

	// RVA: 0x16344E0 Offset: 0x16338E0 VA: 0x1816344E0
	public void .ctor(byte tag, byte[] data) { }

	// RVA: 0x1AA90B0 Offset: 0x1AA84B0 VA: 0x181AA90B0
	public void .ctor(byte[] data) { }

	// RVA: 0x1634560 Offset: 0x1633960 VA: 0x181634560
	public int get_Count() { }

	// RVA: 0x497E20 Offset: 0x497220 VA: 0x180497E20
	public byte get_Tag() { }

	// RVA: 0x1634660 Offset: 0x1633A60 VA: 0x181634660
	public int get_Length() { }

	// RVA: 0x1AA9330 Offset: 0x1AA8730 VA: 0x181AA9330
	public byte[] get_Value() { }

	// RVA: 0x1AA93D0 Offset: 0x1AA87D0 VA: 0x181AA93D0
	public void set_Value(byte[] value) { }

	// RVA: 0x16333E0 Offset: 0x16327E0 VA: 0x1816333E0
	private bool CompareArray(byte[] array1, byte[] array2) { }

	// RVA: 0x1633480 Offset: 0x1632880 VA: 0x181633480
	public bool CompareValue(byte[] value) { }

	// RVA: 0x1AA81E0 Offset: 0x1AA75E0 VA: 0x181AA81E0
	public ASN1 Add(ASN1 asn1) { }

	// RVA: 0x1AA86F0 Offset: 0x1AA7AF0 VA: 0x181AA86F0 Slot: 4
	public virtual byte[] GetBytes() { }

	// RVA: 0x1AA83D0 Offset: 0x1AA77D0 VA: 0x181AA83D0
	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	// RVA: 0x1AA8280 Offset: 0x1AA7680 VA: 0x181AA8280
	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	// RVA: 0x1AA9250 Offset: 0x1AA8650 VA: 0x181AA9250
	public ASN1 get_Item(int index) { }

	// RVA: 0x1AA85E0 Offset: 0x1AA79E0 VA: 0x181AA85E0
	public ASN1 Element(int index, byte anTag) { }

	// RVA: 0x1AA8DE0 Offset: 0x1AA81E0 VA: 0x181AA8DE0 Slot: 3
	public override string ToString() { }

}

