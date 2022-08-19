public class MeshPaintable : BaseMeshPaintable // TypeDefIndex: 9203
{	// Fields
	public string replacementTextureName; // 0x18
	public int textureWidth; // 0x20
	public int textureHeight; // 0x24
	public Color clearColor; // 0x28
	public Texture2D targetTexture; // 0x38
	public bool hasChanges; // 0x40
	private RectInt areaClamp; // 0x44

	// Properties
	public override Texture2D TargetTexture { get; set; }
	public override bool HasChanges { get; set; }

	// Methods

	// RVA: 0x962D80 Offset: 0x962180 VA: 0x180962D80
	private void OnDisable() { }

	// RVA: 0x962E80 Offset: 0x962280 VA: 0x180962E80
	private void Shutdown() { }

	// RVA: 0x5DCC00 Offset: 0x5DC000 VA: 0x1805DCC00 Slot: 4
	public override Texture2D get_TargetTexture() { }

	// RVA: 0x5089D0 Offset: 0x507DD0 VA: 0x1805089D0 Slot: 5
	public override void set_TargetTexture(Texture2D value) { }

	// RVA: 0x7E53F0 Offset: 0x7E47F0 VA: 0x1807E53F0 Slot: 6
	public override bool get_HasChanges() { }

	// RVA: 0x80DB50 Offset: 0x80CF50 VA: 0x18080DB50 Slot: 7
	public override void set_HasChanges(bool value) { }

	// RVA: 0x962840 Offset: 0x961C40 VA: 0x180962840 Slot: 8
	public override void Init(MeshPaintableSource source, bool isSelected) { }

	// RVA: 0x962350 Offset: 0x961750 VA: 0x180962350 Slot: 9
	public override void Clear() { }

	// RVA: 0x962320 Offset: 0x961720 VA: 0x180962320 Slot: 10
	public override void Apply() { }

	// RVA: 0x962420 Offset: 0x961820 VA: 0x180962420 Slot: 11
	public override void DrawTexture(Vector2 uv, float width, float height, Texture2D texture, Color textureColor) { }

	// RVA: 0x4D1BF0 Offset: 0x4D0FF0 VA: 0x1804D1BF0 Slot: 12
	public override bool ShouldHit(RaycastHit info) { }

	// RVA: 0x962F30 Offset: 0x962330 VA: 0x180962F30
	public void .ctor() { }

}

