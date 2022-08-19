public class ERMaterial : ScriptableObject // TypeDefIndex: 7223
{	// Fields
	public int id; // 0x18
	public string name; // 0x20
	public double roadType1ID; // 0x28
	public double roadType2ID; // 0x30
	public double roadType3ID; // 0x38
	public Material road1Material; // 0x40
	public Material road2Material; // 0x48
	public Material road3Material; // 0x50
	public float connectorLength1; // 0x58
	public float connectorLength2; // 0x5C
	public float connectorLength3; // 0x60
	public float road1Stretch; // 0x64
	public float road2Stretch; // 0x68
	public float road3Stretch; // 0x6C
	public int road1StretchType; // 0x70
	public int road2StretchType; // 0x74
	public int road3StretchType; // 0x78
	public int subdivide1; // 0x7C
	public int subdivide2; // 0x80
	public int subdivide3; // 0x84
	public float resolution; // 0x88
	public bool blend; // 0x8C
	public float blendDistance; // 0x90
	public int blendSection; // 0x94
	public bool triangleStrip; // 0x98
	public float triangleStripDistance; // 0x9C
	public float triangleStripUVStart; // 0xA0
	public float triangleStripUVEnd; // 0xA4
	public Material triangleStripMaterial; // 0xA8

	// Methods

	// RVA: 0x99C840 Offset: 0x99BC40 VA: 0x18099C840
	public void Init(ERModularBase scr) { }

	// RVA: 0x99C760 Offset: 0x99BB60 VA: 0x18099C760
	public static ERMaterial CreateInstance(ERModularBase scr) { }

	// RVA: 0x99C8E0 Offset: 0x99BCE0 VA: 0x18099C8E0
	public static string[] OCQOOCOQQC(ERModularBase scr) { }

	// RVA: 0x99CFE0 Offset: 0x99C3E0 VA: 0x18099CFE0
	public static ERMaterial OQDQOCCODO(ERModularBase scr, ERIConnector prefab, ref int targetRoad, ref int index) { }

	// RVA: 0x99CA10 Offset: 0x99BE10 VA: 0x18099CA10
	public static Material OOQCDDQODC(ERModularBase scr, ERIConnector prefab) { }

	// RVA: 0x99D1E0 Offset: 0x99C5E0 VA: 0x18099D1E0
	public void .ctor() { }

}

