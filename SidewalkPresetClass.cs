public class SidewalkPresetClass // TypeDefIndex: 7255
{	// Fields
	public string presetName; // 0x10
	public double id; // 0x18
	public double timestamp; // 0x20
	public float sidewalkWidth1; // 0x28
	public float sidewalkWidth2; // 0x2C
	public float curbHeight; // 0x30
	public float curbDepth; // 0x34
	public bool beveledCurb; // 0x38
	public float beveledHeight; // 0x3C
	public float beveledDepth; // 0x40
	public bool outerCurb; // 0x44
	public bool roadSideCurbUVControl; // 0x45
	public bool outerSideCurbUVControl; // 0x46
	public Material sidewalkMaterial; // 0x48
	public List<Vector2> shape; // 0x50
	public List<float> sidewalkUVs; // 0x58
	public List<float> curbUVs; // 0x60
	public bool lockUVs; // 0x68

	// Methods

	// RVA: 0x22BFD50 Offset: 0x22BF150 VA: 0x1822BFD50
	public void .ctor(QDOQDSQOOQDDD corner, string name) { }

}

