public class TextureSampler // TypeDefIndex: 5613
{	// Fields
	private Color[] _data; // 0x10
	private int _height; // 0x18
	private int _width; // 0x1C

	// Methods

	// RVA: 0x199E860 Offset: 0x199DC60 VA: 0x18199E860
	public Color GetPixelBilinear(float u, float v) { }

	// RVA: 0x199EC80 Offset: 0x199E080 VA: 0x18199EC80
	public Color GetPixel(float x, float y) { }

	// RVA: 0x199ED40 Offset: 0x199E140 VA: 0x18199ED40
	private float Mod(float x, float y) { }

	// RVA: 0x199EDC0 Offset: 0x199E1C0 VA: 0x18199EDC0
	private float WrapBetween(float value, float min, float max) { }

	// RVA: 0x199EE60 Offset: 0x199E260 VA: 0x18199EE60
	public void .ctor(Texture2D source) { }

}

