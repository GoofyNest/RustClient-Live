internal class ASN1 // TypeDefIndex: 45
{
	private byte m_nTag;
	private byte[] m_aValue;
	private ArrayList elist;

	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }


	public void .ctor(byte tag) { }

	public void .ctor(byte tag, byte[] data) { }

	public void .ctor(byte[] data) { }

	public int get_Count() { }

	public byte get_Tag() { }

	public int get_Length() { }

	public byte[] get_Value() { }

	public void set_Value(byte[] value) { }

	private bool CompareArray(byte[] array1, byte[] array2) { }

	public bool CompareValue(byte[] value) { }

	public ASN1 Add(ASN1 asn1) { }

	public virtual byte[] GetBytes() { }

	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	public ASN1 get_Item(int index) { }

	public ASN1 Element(int index, byte anTag) { }

	public override string ToString() { }

}

public class ASN1 // TypeDefIndex: 1704
{
	private byte m_nTag;
	private byte[] m_aValue;
	private ArrayList elist;

	public int Count { get; }
	public byte Tag { get; }
	public int Length { get; }
	public byte[] Value { get; set; }
	public ASN1 Item { get; }


	public void .ctor(byte tag) { }

	public void .ctor(byte tag, byte[] data) { }

	public void .ctor(byte[] data) { }

	public int get_Count() { }

	public byte get_Tag() { }

	public int get_Length() { }

	public byte[] get_Value() { }

	public void set_Value(byte[] value) { }

	private bool CompareArray(byte[] array1, byte[] array2) { }

	public bool CompareValue(byte[] value) { }

	public ASN1 Add(ASN1 asn1) { }

	public virtual byte[] GetBytes() { }

	protected void Decode(byte[] asn1, ref int anPos, int anLength) { }

	protected void DecodeTLV(byte[] asn1, ref int pos, out byte tag, out int length, out byte[] content) { }

	public ASN1 get_Item(int index) { }

	public ASN1 Element(int index, byte anTag) { }

	public override string ToString() { }

}

