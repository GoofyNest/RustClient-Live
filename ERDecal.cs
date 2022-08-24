public class ERDecal : ScriptableObject // TypeDefIndex: 7213
{
	public int id; 
	public string name; 
	public ERDecalType type; 
	public double roadType1; 
	public double roadType2; 
	public int connection; 
	public GameObject decalPrefab; 
	public float baseWidth; 
	public float meshWidth; 
	public float scale; 
	public Vector3 localScale; 
	public int priority; 
	public bool collapsed; 
	public float heightOffset; 
	public Material material; 
	public Vector2 uvLeftTop; 
	public Vector2 uvRightBottom; 
	public float width; 
	public float length; 
	public float xOffset; 
	public float startOffset; 
	public float endOffset; 
	public float endRotation; 
	public List<Vector2> uvBreakPoints; 
	public List<float> distances; 
	public ERDecalPosition position; 
	public Vector2 uvLeftTop1; 
	public Vector2 uvRightBottom1; 
	public Vector2 uvLeftTop2; 
	public Vector2 uvRightBottom2; 
	public float width1; 
	public float width2; 


public void Init(GameObject prefab, float baseWidth) { }

public static ERDecal CreateInstance(GameObject prefab, float baseWidth) { }

public static void CopyDecal(ERDecalClass source, ERDecal target) { }

public static void OODDOCCOCC(ERDecal source, ERDecal target) { }

public void OCQCQCOCOO() { }

public static ERDecal OCQCDQDODQ(int id, List<ERDecal> decalPresets) { }

public static List<ERDecal> FilterByType(List<ERDecal> lst, ERDecalType type) { }

public static string[] OQDOCOQOQD(ref List<ERDecal> decals, string firstItem, int id1, int id2, ref int _index1, ref int _index2, ERDecalType type, ERDecalPosition position) { }

public static int ODCOCCOOOO(List<ERDecal> decals, int tindex, ERDecalType type) { }

public static GameObject[] OCCODDOQDO(List<ERDecal> decals, ref List<int> priority, ref List<float> scale) { }

public void MatchDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

public void SetBreakPointDistances(ref List<float> distances, List<Vector2> uvBreakPoints, float length) { }

public void .ctor() { }

}

