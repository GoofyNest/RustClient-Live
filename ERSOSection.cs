public struct ERSOSection // TypeDefIndex: 7204
{
	public Vector3 startPosition;
	public Vector3 endPosition;
	public Vector3 p2;
	public Vector3 p3;
	public Vector3 ms1;
	public Vector3 ms2;
	public Vector3 ms3;
	public Vector3 ms4;
	public Vector3 me1;
	public Vector3 me2;
	public Vector3 me3;
	public Vector3 me4;
	public Vector3 startSplinePointOrig;
	public float startDistance;
	public int startSplinePointObject;
	public int startSplinePoint;
	public int endSplinePoint;
	public float startFraction;
	public float endFraction;
	public float hsStart;
	public float hsEnd;
	public int startSplinePointGeo;
	public float startDistanceGeo;
	public int endSplinePointGeo;
	public float endDistanceGeo;
	public float maxHeightDifference;
	public SideObject so;
	public bool forceSo;
	public ERRoadSide roadSide;
	public double soid;
	public bool acceptBarriers;
	public bool active;
	public double linkedSoId1;
	public double linkedSoId2;


	public void .ctor(Vector3 _startPos, Vector3 _endPos, int _startIndex, int _endIndex, float _startFraction, float _endFraction, float _hsStart, float _hsEnd) { }

	public static ERSOSection GetERSOSection(ERModularRoad road, int listIndex, ref int index, int leftright, ref string soType, ref List<ERSOSection> sections) { }

	public static ERSOSection AdjustEndOffset(ERSOSection target, ERSOSection source) { }

}

