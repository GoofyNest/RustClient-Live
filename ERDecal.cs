public class ERDecal : ScriptableObject // TypeDefIndex: 7213
{	// Fields
	public int id; // 0x18
	public string name; // 0x20
	public ERDecalType type; // 0x28
	public double roadType1; // 0x30
	public double roadType2; // 0x38
	public int connection; // 0x40
	public GameObject decalPrefab; // 0x48
	public float baseWidth; // 0x50
	public float meshWidth; // 0x54
	public float scale; // 0x58
	public Vector3 localScale; // 0x5C
	public int priority; // 0x68
	public bool collapsed; // 0x6C
	public float heightOffset; // 0x70
	public Material material; // 0x78
	public Vector2 uvLeftTop; // 0x80
	public Vector2 uvRightBottom; // 0x88
	public float width; // 0x90
	public float length; // 0x94
	public float xOffset; // 0x98
	public float startOffset; // 0x9C
	public float endOffset; // 0xA0
	public float endRotation; // 0xA4
	public List<Vector2> uvBreakPoints; // 0xA8
	public List<float> distances; // 0xB0
	public ERDecalPosition position; // 0xB8
	public Vector2 uvLeftTop1; // 0xBC
	public Vector2 uvRightBottom1; // 0xC4
	public Vector2 uvLeftTop2; // 0xCC
	public Vector2 uvRightBottom2; // 0xD4
	public float width1; // 0xDC
	public float width2; // 0xE0

	// Methods

	// RVA: 0x989F00 Offset: 0x989300 VA: 0x180989F00
	public void Init(GameObject prefab, float baseWidth) { }

	// RVA: 0x989C70 Offset: 0x989070 VA: 0x180989C70
	public static ERDecal CreateInstance(GameObject prefab, float baseWidth) { }

	// RVA: 0x989A00 Offset: 0x988E00 VA: 0x180989A00
	public static void CopyDecal(ERDecalClass source, ERDecal target) { }

	// RVA: 0x98A870 Offset: 0x989C70 VA: 0x18098A870
	public static void OODDOCCOCC(ERDecal source, ERDecal target) { }

	// RVA: 0x98A4A0 Offset: 0x9898A0 VA: 0x18098A4A0
	public void OCQCQCOCOO() { }

	// RVA: 0x98A320 Offset: 0x989720 VA: 0x18098A320
	public static ERDecal OCQCDQDODQ(int id, List<ERDecal> decalPresets) { }

	// RVA: 0x989D50 Offset: 0x989150 VA: 0x180989D50
	public static List<ERDecal> FilterByType(List<ERDecal> lst, ERDecalType type) { }

	// RVA: 0x98AA50 Offset: 0x989E50 VA: 0x18098AA50
	public static string[] OQDOCOQOQD(ref List<ERDecal> decals, string firstItem, int id1, int id2, ref int _index1, ref int _index2, ERDecalType type, ERDecalPosition position) { }

	// RVA: 0x98A6A0 Offset: 0x989AA0 VA: 0x18098A6A0
	public static int ODCOCCOOOO(List<ERDecal> decals, int tindex, ERDecalType type) { }

	// RVA: 0x98A110 Offset: 0x989510 VA: 0x18098A110
	public static GameObject[] OCCODDOQDO(List<ERDecal> decals, ref List<int> priority, ref List<float> scale) { }

	// RVA: 0x989FB0 Offset: 0x9893B0 VA: 0x180989FB0
	public void MatchDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

	// RVA: 0x98ADF0 Offset: 0x98A1F0 VA: 0x18098ADF0
	public void SetBreakPointDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

	// RVA: 0x98AEB0 Offset: 0x98A2B0 VA: 0x18098AEB0
	public void .ctor() { }

}

