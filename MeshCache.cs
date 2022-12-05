public static class MeshCache // TypeDefIndex: 10887
{
	public static Dictionary<Mesh, MeshCache.Data> dictionary;


	public static MeshCache.Data Get(Mesh mesh) { }

	private static void .cctor() { }

}

public class MeshCache.Data // TypeDefIndex: 10888
{
	public Mesh mesh;
	public Vector3[] vertices;
	public Vector3[] normals;
	public Vector4[] tangents;
	public Color32[] colors32;
	public int[] triangles;
	public Vector2[] uv;
	public Vector2[] uv2;
	public Vector2[] uv3;
	public Vector2[] uv4;


	public void .ctor() { }

}

