public struct TextureData // TypeDefIndex: 12043
{
	public int width; 
	public int height; 
	public Color32[] colors; 


	public void .ctor(Texture2D tex) { }

	public Color32 GetColor(int x, int y) { }

	public int GetShort(int x, int y) { }

	public int GetInt(int x, int y) { }

	public float GetFloat(int x, int y) { }

	public float GetHalf(int x, int y) { }

	public Vector4 GetVector(int x, int y) { }

	public Vector3 GetNormal(int x, int y) { }

	public Color32 GetInterpolatedColor(float x, float y) { }

	public int GetInterpolatedInt(float x, float y) { }

	public int GetInterpolatedShort(float x, float y) { }

	public float GetInterpolatedFloat(float x, float y) { }

	public float GetInterpolatedHalf(float x, float y) { }

	public Vector4 GetInterpolatedVector(float x, float y) { }

	public Vector3 GetInterpolatedNormal(float x, float y) { }

}

