public static class MeshCache // TypeDefIndex: 9152
{	public static Dictionary<Mesh, MeshCache.Data> dictionary; // 0x2C84F54


	public static MeshCache.Data Get(Mesh mesh) { }

	private static void .cctor() { }

}

public class MeshCache.Data // TypeDefIndex: 9153
{	public Mesh mesh; // 0x10
	public Vector3[] vertices; // 0x18
	public Vector3[] normals; // 0x20
	public Vector4[] tangents; // 0x28
	public Color32[] colors32; // 0x30
	public int[] triangles; // 0x38
	public Vector2[] uv; // 0x40
	public Vector2[] uv2; // 0x48
	public Vector2[] uv3; // 0x50
	public Vector2[] uv4; // 0x58


	public void .ctor() { }

}

