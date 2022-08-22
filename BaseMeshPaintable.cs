public abstract class BaseMeshPaintable : MonoBehaviour, IClientComponent // TypeDefIndex: 9201
{	private static MaterialPropertyBlock _block; // 0x1770

	protected static MaterialPropertyBlock Block { get; }
	public abstract Texture2D TargetTexture { get; set; }
	public abstract bool HasChanges { get; set; }


	protected static MaterialPropertyBlock get_Block() { }

	public abstract Texture2D get_TargetTexture();

	public abstract void set_TargetTexture(Texture2D value);

	public abstract bool get_HasChanges();

	public abstract void set_HasChanges(bool value);

	public abstract void Init(MeshPaintableSource source, bool isSelected);

	public abstract void Clear();

	public abstract void Apply();

	public abstract void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor);

	public abstract bool ShouldHit(RaycastHit info);

	protected static Color Blend(bool isPaintBrush, Color color, Color textureColor, Color targetPixel) { }

	protected void .ctor() { }

	private static void .cctor() { }

}

