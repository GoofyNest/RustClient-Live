public class MeshPaintable : BaseMeshPaintable // TypeDefIndex: 9203
{	public string replacementTextureName; // 0x18
	public int textureWidth; // 0x20
	public int textureHeight; // 0x24
	public Color clearColor; // 0x28
	public Texture2D targetTexture; // 0x38
	public bool hasChanges; // 0x40
	private RectInt areaClamp; // 0x44

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

