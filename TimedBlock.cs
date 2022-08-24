internal class TimedBlock : IComparable<TimedBlock> // TypeDefIndex: 5634
{
	public readonly DateTime deadline; 
	public readonly Action block; 
	public readonly string blockName; 


public void .ctor(DateTime deadline, Action block, string blockName) { }

public int CompareTo(TimedBlock other) { }

public override string ToString() { }

}

