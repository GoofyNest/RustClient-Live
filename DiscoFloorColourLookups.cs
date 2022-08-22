public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent // TypeDefIndex: 9439
{	public float[] InOutLookup; // 0x98
	public float[] RadialLookup; // 0xA0
	public float[] RippleLookup; // 0xA8
	public float[] CheckerLookup; // 0xB0
	public float[] BlockLookup; // 0xB8
	public Gradient[] ColourGradients; // 0xC0


	public float[] GetLookup(DiscoFloorMesh.PatternType pattern) { }

	public Gradient GetColourGradient(int index) { }

	protected override Type GetIndexedType() { }

	public void .ctor() { }

}

