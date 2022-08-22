public class ERRoadType // TypeDefIndex: 7227
{	public double id; // 0x10
	public string roadTypeName; // 0x18
	public List<Vector2> roadShape; // 0x20
	public List<Vector2> roadShapeExt; // 0x28
	public List<bool> doConnectionTri; // 0x30
	public List<float> roadShapeUVs; // 0x38
	public List<float> roadShapeExtUVs; // 0x40
	public List<float> roadShapeUVs2; // 0x48
	public List<bool> hardEdge; // 0x50
	public float roadWidth; // 0x58
	public float faceDistance; // 0x5C
	public float angleTreshold; // 0x60
	public bool sidewalks; // 0x64
	public float sidewalkHeight; // 0x68
	public float sidewalkWidth; // 0x6C
	public Material roadMaterial; // 0x70
	public PhysicMaterial roadPhysicsMaterial; // 0x78
	public Material connectionMaterial; // 0x80
	public bool isSideObject; // 0x88
	public List<ERSORoad> soData; // 0x90
	public List<ERSORoadExt> soDataExt; // 0x98
	public List<ERSORoadLog> soDataLog; // 0xA0
	public int layer; // 0xA8
	public string tag; // 0xB0
	public bool hasMeshCollider; // 0xB8
	public bool terrainDeformation; // 0xB9
	private ERRoadShape ᙃ; // 0xC0


	public void .ctor() { }

	public void Update() { }

	public static QDQDOOQQDQODD GetRoadType(ERRoadType t, ERModularBase baseScript) { }

}

