public class NeonMeshPaintableSource : MeshPaintableSource // TypeDefIndex: 8834
{	public NeonSign neonSign; // 0x90
	public float editorEmissionScale; // 0x98
	public AnimationCurve lightingCurve; // 0xA0
	public Color topLeft; // 0xA8
	public Color topRight; // 0xB8
	public Color bottomLeft; // 0xC8
	public Color bottomRight; // 0xD8


	public override void UpdateMaterials(MaterialPropertyBlock block, Texture2D textureOverride, bool forEditing = False, bool isSelected = False) { }

	public override Color32[] UpdateFrom(Texture2D input) { }

	public void .ctor() { }

	[CompilerGeneratedAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	private Color <UpdateFrom>g__GetColorForRegion|8_0(int x, int y, int regionWidth, int regionHeight, ref NeonMeshPaintableSource.<>c__DisplayClass8_0 ) { }

}

private struct NeonMeshPaintableSource.<>c__DisplayClass8_0 // TypeDefIndex: 8835
{	public int width; // 0x0
	public Color32[] pixels; // 0x8
	public NeonMeshPaintableSource <>4__this; // 0x10

}

