public class RangeHeaderValue : ICloneable // TypeDefIndex: 5804
{
	private List<RangeItemHeaderValue> ranges; 
	private string unit; 

	public ICollection<RangeItemHeaderValue> Ranges { get; }
	public string Unit { get; }


	public void .ctor() { }

	private void .ctor(RangeHeaderValue source) { }

	public ICollection<RangeItemHeaderValue> get_Ranges() { }

	public string get_Unit() { }

	private object System.ICloneable.Clone() { }

	public override bool Equals(object obj) { }

	public override int GetHashCode() { }

	public static bool TryParse(string input, out RangeHeaderValue parsedValue) { }

	public override string ToString() { }

}

