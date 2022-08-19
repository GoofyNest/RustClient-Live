public class ERSOMarkerExt : ScriptableObject // TypeDefIndex: 7237
{	// Fields
	public SideObject sideObject; // 0x18
	public double id; // 0x20
	public bool active; // 0x28
	public float startOffset; // 0x2C
	public float endOffset; // 0x30
	public bool splineActive; // 0x34
	public float sidewaysDistance; // 0x38
	public float xPosition; // 0x3C
	public Vector3 startOffsetV3; // 0x40
	public Vector3 endOffsetV3; // 0x4C
	public Vector3 startOffsetDir; // 0x58
	public Vector3 endOffsetDir; // 0x64
	public Vector3 startOffsetV3nb; // 0x70
	public Vector3 endOffsetV3nb; // 0x7C
	public int curStartInt; // 0x88
	public int curEndInt; // 0x8C
	public bool startOffsetActive; // 0x90
	public bool endOffsetActive; // 0x91
	public List<Vector2> nodeList; // 0x98
	public List<Vector3> nodeShapeVecsGlobal; // 0xA0
	public int shapeTransitionType; // 0xA8
	public Vector3 rotation; // 0xAC
	public float rotationAngle; // 0xB8
	public float rotationDistance; // 0xBC
	public float rotationCenter; // 0xC0
	public ERRoadSide side; // 0xC4
	public ERSOMarkerExt otherSide; // 0xC8

	// Methods

	// RVA: 0xA54DF0 Offset: 0xA541F0 VA: 0x180A54DF0
	public void Init(SideObject so, bool flag) { }

	// RVA: 0xA54F20 Offset: 0xA54320 VA: 0x180A54F20
	public void OODOOOQQCO(ERSOMarkerExt source) { }

	// RVA: 0xA54CB0 Offset: 0xA540B0 VA: 0x180A54CB0
	public void Copy(ERSOMarkerExt source) { }

	// RVA: 0xA54CE0 Offset: 0xA540E0 VA: 0x180A54CE0
	public static ERSOMarkerExt CreateInstance(SideObject so, bool flag) { }

	// RVA: 0xA54ED0 Offset: 0xA542D0 VA: 0x180A54ED0
	public void ODCOCDOOCQ(SideObject so) { }

	// RVA: 0xA551D0 Offset: 0xA545D0 VA: 0x180A551D0
	public void .ctor() { }

}

