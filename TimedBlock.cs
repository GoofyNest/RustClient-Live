internal class TimedBlock : IComparable<TimedBlock> // TypeDefIndex: 5634
{	public readonly DateTime deadline; // 0x10
	public readonly Action block; // 0x18
	public readonly string blockName; // 0x20


	public void .ctor(DateTime deadline, Action block, string blockName) { }

	public int CompareTo(TimedBlock other) { }

	public override string ToString() { }

}

