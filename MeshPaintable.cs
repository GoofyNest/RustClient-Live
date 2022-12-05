public class MeshPaintable : BaseMeshPaintable // TypeDefIndex: 10940
{
	public string replacementTextureName;
	public int textureWidth;
	public int textureHeight;
	public Color clearColor;
	public Texture2D targetTexture;
	public bool hasChanges;
	private RectInt areaClamp;

	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }


	private void OnDisable() { }

	private void Shutdown() { }

	public override Texture2D get_TargetTexture() { }

	public override void set_TargetTexture(Texture2D value) { }

	public override bool get_HasChanges() { }

	public override void set_HasChanges(bool value) { }

	public override void Init(MeshPaintableSource source, bool isSelected) { }

	public override void Clear() { }

	public override void Apply() { }

	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	public override bool ShouldHit(RaycastHit info) { }

	public void .ctor() { }

}

