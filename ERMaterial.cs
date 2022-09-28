public class ERMaterial : ScriptableObject // TypeDefIndex: 7196
{
	public int id; 
	public string name; 
	public double roadType1ID; 
	public double roadType2ID; 
	public double roadType3ID; 
	public Material road1Material; 
	public Material road2Material; 
	public Material road3Material; 
	public float connectorLength1; 
	public float connectorLength2; 
	public float connectorLength3; 
	public float road1Stretch; 
	public float road2Stretch; 
	public float road3Stretch; 
	public int road1StretchType; 
	public int road2StretchType; 
	public int road3StretchType; 
	public int subdivide1; 
	public int subdivide2; 
	public int subdivide3; 
	public float resolution; 
	public bool blend; 
	public float blendDistance; 
	public int blendSection; 
	public bool triangleStrip; 
	public float triangleStripDistance; 
	public float triangleStripUVStart; 
	public float triangleStripUVEnd; 
	public Material triangleStripMaterial; 


	public void Init(ERModularBase scr) { }

	public static ERMaterial CreateInstance(ERModularBase scr) { }

	public static string[] OCQOOCOQQC(ERModularBase scr) { }

	public static ERMaterial OQDQOCCODO(ERModularBase scr, ERIConnector prefab, ref int targetRoad, ref int index) { }

	public static Material OOQCDDQODC(ERModularBase scr, ERIConnector prefab) { }

	public void .ctor() { }

}

