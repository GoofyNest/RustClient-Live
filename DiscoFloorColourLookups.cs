public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent // TypeDefIndex: 9439
{
	public float[] InOutLookup; 
	public float[] RadialLookup; 
	public float[] RippleLookup; 
	public float[] CheckerLookup; 
	public float[] BlockLookup; 
	public Gradient[] ColourGradients; 


public float[] GetLookup(DiscoFloorMesh.PatternType pattern) { }

public Gradient GetColourGradient(int index) { }

protected override Type GetIndexedType() { }

public void .ctor() { }

}

