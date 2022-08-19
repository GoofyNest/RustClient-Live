public class ERLocalGrid : ScriptableObject // TypeDefIndex: 7212
{	// Fields
	public int id; // 0x18
	public string name; // 0x20
	public bool gridActive; // 0x28
	public bool gridGUIActive; // 0x29
	public Color gridColor; // 0x2C
	public float gridSize; // 0x3C
	public float gridRadius; // 0x40
	public float gridRotation; // 0x44
	public Vector3 tl; // 0x48
	public Vector3 bl; // 0x54
	public Vector3 br; // 0x60
	public float xOffset; // 0x6C
	public float yOffset; // 0x70
	public Vector3 OOCDQCOOQC; // 0x74

	// Methods

	// RVA: 0x99AA90 Offset: 0x999E90 VA: 0x18099AA90
	public void Init(ERModularBase scr) { }

	// RVA: 0x99A7A0 Offset: 0x999BA0 VA: 0x18099A7A0
	public static ERLocalGrid CreateInstance(ERModularBase scr) { }

	// RVA: 0x99A880 Offset: 0x999C80 VA: 0x18099A880
	public static string[] GridNames(ERModularBase scr) { }

	// RVA: 0x99AB30 Offset: 0x999F30 VA: 0x18099AB30
	public void SetOffsets(ERModularBase scr, Vector3 pos, Vector3 v) { }

	// RVA: 0x99AB80 Offset: 0x999F80 VA: 0x18099AB80
	public void .ctor() { }

}

