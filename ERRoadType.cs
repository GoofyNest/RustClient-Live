public class ERRoadType // TypeDefIndex: 7243
{
	public double id;
	public string roadTypeName;
	public List<Vector2> roadShape;
	public List<Vector2> roadShapeExt;
	public List<bool> doConnectionTri;
	public List<float> roadShapeUVs;
	public List<float> roadShapeExtUVs;
	public List<float> roadShapeUVs2;
	public List<bool> hardEdge;
	public float roadWidth;
	public float faceDistance;
	public float angleTreshold;
	public bool sidewalks;
	public float sidewalkHeight;
	public float sidewalkWidth;
	public Material roadMaterial;
	public PhysicMaterial roadPhysicsMaterial;
	public Material connectionMaterial;
	public bool isSideObject;
	public List<ERSORoad> soData;
	public List<ERSORoadExt> soDataExt;
	public List<ERSORoadLog> soDataLog;
	public int layer;
	public string tag;
	public bool hasMeshCollider;
	public bool terrainDeformation;
	private ERRoadShape ᙃ;


	public void .ctor() { }

	public void Update() { }

	public static QDQDOOQQDQODD GetRoadType(ERRoadType t, ERModularBase baseScript) { }

}

