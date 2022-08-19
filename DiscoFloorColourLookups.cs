public class DiscoFloorColourLookups : PrefabAttribute, IClientComponent // TypeDefIndex: 9439
{	// Fields
	public float[] InOutLookup; // 0x98
	public float[] RadialLookup; // 0xA0
	public float[] RippleLookup; // 0xA8
	public float[] CheckerLookup; // 0xB0
	public float[] BlockLookup; // 0xB8
	public Gradient[] ColourGradients; // 0xC0

	// Methods

	// RVA: 0x9C5F10 Offset: 0x9C5310 VA: 0x1809C5F10
	public float[] GetLookup(DiscoFloorMesh.PatternType pattern) { }

	// RVA: 0x9C5E10 Offset: 0x9C5210 VA: 0x1809C5E10
	public Gradient GetColourGradient(int index) { }

	// RVA: 0x9C5EB0 Offset: 0x9C52B0 VA: 0x1809C5EB0 Slot: 7
	protected override Type GetIndexedType() { }

	// RVA: 0x9C5F50 Offset: 0x9C5350 VA: 0x1809C5F50
	public void .ctor() { }

}

