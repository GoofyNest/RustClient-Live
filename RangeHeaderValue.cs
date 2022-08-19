public class RangeHeaderValue : ICloneable // TypeDefIndex: 5804
{	// Fields
	private List<RangeItemHeaderValue> ranges; // 0x10
	private string unit; // 0x18

	// Properties
	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }

	// Methods

	// RVA: 0x1090F50 Offset: 0x1090350 VA: 0x181090F50
	public void .ctor() { }

	// RVA: 0x1090D10 Offset: 0x1090110 VA: 0x181090D10
	private void .ctor(RangeHeaderValue source) { }

	// RVA: 0x1090FA0 Offset: 0x10903A0 VA: 0x181090FA0
	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	// RVA: 0x497710 Offset: 0x496B10 VA: 0x180497710
	public string get_Unit() { }

	// RVA: 0x1090230 Offset: 0x108F630 VA: 0x181090230 Slot: 4
	private object System.ICloneable.Clone() { }

	// RVA: 0x10900F0 Offset: 0x108F4F0 VA: 0x1810900F0 Slot: 0
	public override bool Equals(object obj) { }

	// RVA: 0x10901B0 Offset: 0x108F5B0 VA: 0x1810901B0 Slot: 2
	public override int GetHashCode() { }

	// RVA: 0x1090450 Offset: 0x108F850 VA: 0x181090450
	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	// RVA: 0x1090290 Offset: 0x108F690 VA: 0x181090290 Slot: 3
	public override string ToString() { }

}

