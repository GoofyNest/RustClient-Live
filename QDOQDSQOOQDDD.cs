public class QDOQDSQOOQDDD // TypeDefIndex: 7171
{	// Fields
	public int crossingElementLeftIndex; // 0x10
	public int crossingElementRightIndex; // 0x14
	public Vector3 centerHandleV3; // 0x18
	public Vector3 centerHandleV3_2; // 0x24
	public Vector3 leftHandleV3; // 0x30
	public Vector3 rightHandleV3; // 0x3C
	public bool renderFlag; // 0x48
	public bool leftConnectionHandle; // 0x49
	public bool rightConnectionHandle; // 0x4A
	public float sidewalkWidth1; // 0x4C
	public float sidewalkWidth2; // 0x50
	public float curbHeight; // 0x54
	public float curbDepth; // 0x58
	public bool beveledCurb; // 0x5C
	public float beveledHeight; // 0x60
	public float beveledDepth; // 0x64
	public bool outerCurb; // 0x68
	public bool roadSideCurbUVControl; // 0x69
	public bool outerSideCurbUVControl; // 0x6A
	public Material sidewalkMaterial; // 0x70
	public List<float> sidewalkUVs; // 0x78
	public List<float> curbUVs; // 0x80
	public bool lockUVs; // 0x88
	public float cornerRadius; // 0x8C
	public int cornerSegments; // 0x90
	public float innerSegmentDistance; // 0x94
	public float startAngle; // 0x98

	// Methods

	// RVA: 0xB58260 Offset: 0xB57660 VA: 0x180B58260
	public void .ctor(ERModularBase scr) { }

	// RVA: 0xB58110 Offset: 0xB57510 VA: 0x180B58110
	public void CopyFromSidewalk(ERSideWalk sw) { }

	// RVA: 0xB581F0 Offset: 0xB575F0 VA: 0x180B581F0
	public static bool ERSidewalkMatch(QDOQDSQOOQDDD sw1, QDOQDSQOOQDDD sw2) { }

}

