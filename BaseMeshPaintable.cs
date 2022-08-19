public abstract class BaseMeshPaintable : MonoBehaviour, IClientComponent // TypeDefIndex: 9201
{	// Fields
	private static MaterialPropertyBlock _block; // 0x1770

	// Properties
	protected static MaterialPropertyBlock Block { get; }
	public abstract Texture2D TargetTexture { get; set; }
	public abstract bool HasChanges { get; set; }

	// Methods

	// RVA: 0xA256B0 Offset: 0xA24AB0 VA: 0x180A256B0
	protected static MaterialPropertyBlock get_Block() { }

	// RVA: -1 Offset: -1 Slot: 4
	public abstract Texture2D get_TargetTexture();

	// RVA: -1 Offset: -1 Slot: 5
	public abstract void set_TargetTexture(Texture2D value);

	// RVA: -1 Offset: -1 Slot: 6
	public abstract bool get_HasChanges();

	// RVA: -1 Offset: -1 Slot: 7
	public abstract void set_HasChanges(bool value);

	// RVA: -1 Offset: -1 Slot: 8
	public abstract void Init(MeshPaintableSource source, bool isSelected);

	// RVA: -1 Offset: -1 Slot: 9
	public abstract void Clear();

	// RVA: -1 Offset: -1 Slot: 10
	public abstract void Apply();

	// RVA: -1 Offset: -1 Slot: 11
	public abstract void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor);

	// RVA: -1 Offset: -1 Slot: 12
	public abstract bool ShouldHit(RaycastHit info);

	// RVA: 0x952BB0 Offset: 0x951FB0 VA: 0x180952BB0
	protected static Color Blend(bool isPaintBrush, Color color, Color textureColor, Color targetPixel) { }

	// RVA: 0x2F91F0 Offset: 0x2F85F0 VA: 0x1802F91F0
	protected void .ctor() { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0
	private static void .cctor() { }

}

