public struct TextureData // TypeDefIndex: 10314
{	// Fields
	public int width; // 0x0
	public int height; // 0x4
	public Color32[] colors; // 0x8

	// Methods

	// RVA: 0xF9720 Offset: 0xF8B20 VA: 0x1800F9720
	public void .ctor(Texture2D tex) { }

	// RVA: 0xF9240 Offset: 0xF8640 VA: 0x1800F9240
	public Color32 GetColor(int x, int y) { }

	// RVA: 0xF9670 Offset: 0xF8A70 VA: 0x1800F9670
	public int GetShort(int x, int y) { }

	// RVA: 0xF9320 Offset: 0xF8720 VA: 0x1800F9320
	public int GetInt(int x, int y) { }

	// RVA: 0xF9280 Offset: 0xF8680 VA: 0x1800F9280
	public float GetFloat(int x, int y) { }

	// RVA: 0xF92D0 Offset: 0xF86D0 VA: 0x1800F92D0
	public float GetHalf(int x, int y) { }

	// RVA: 0xF96C0 Offset: 0xF8AC0 VA: 0x1800F96C0
	public Vector4 GetVector(int x, int y) { }

	// RVA: 0xF9640 Offset: 0xF8A40 VA: 0x1800F9640
	public Vector3 GetNormal(int x, int y) { }

	// RVA: 0xF9370 Offset: 0xF8770 VA: 0x1800F9370
	public Color32 GetInterpolatedColor(float x, float y) { }

	// RVA: 0xF93A0 Offset: 0xF87A0 VA: 0x1800F93A0
	public int GetInterpolatedInt(float x, float y) { }

	// RVA: 0xF94F0 Offset: 0xF88F0 VA: 0x1800F94F0
	public int GetInterpolatedShort(float x, float y) { }

	// RVA: 0xF9380 Offset: 0xF8780 VA: 0x1800F9380
	public float GetInterpolatedFloat(float x, float y) { }

	// RVA: 0xF9390 Offset: 0xF8790 VA: 0x1800F9390
	public float GetInterpolatedHalf(float x, float y) { }

	// RVA: 0xF9610 Offset: 0xF8A10 VA: 0x1800F9610
	public Vector4 GetInterpolatedVector(float x, float y) { }

	// RVA: 0xF94C0 Offset: 0xF88C0 VA: 0x1800F94C0
	public Vector3 GetInterpolatedNormal(float x, float y) { }

}

