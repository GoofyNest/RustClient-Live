public class ContentDispositionHeaderValue : ICloneable // TypeDefIndex: 5763
{	// Fields
	private string dispositionType; // 0x10
	private List<NameValueHeaderValue> parameters; // 0x18

	// Properties
	public ICollection<NameValueHeaderValue> Parameters { get; }

	// Methods

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	private void .ctor() { }

	// RVA: 0x1081C00 Offset: 0x1081000 VA: 0x181081C00
	protected void .ctor(ContentDispositionHeaderValue source) { }

	// RVA: 0x1081E90 Offset: 0x1081290 VA: 0x181081E90
	public ICollection<NameValueHeaderValue> get_Parameters() { }

	// RVA: 0x1081990 Offset: 0x1080D90 VA: 0x181081990 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x1081850 Offset: 0x1080C50 VA: 0x181081850 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x1081910 Offset: 0x1080D10 VA: 0x181081910 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x10819F0 Offset: 0x1080DF0 VA: 0x1810819F0 Slot: 3
	public override string ToString() { }

	// RVA: 0x1081A50 Offset: 0x1080E50 VA: 0x181081A50
	public static bool TryParse(string input, out ContentDispositionHeaderValue parsedValue) { }

}

