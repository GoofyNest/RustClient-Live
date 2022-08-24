public class DistanceField // TypeDefIndex: 11356
{
	private static readonly int[] GaussOffsets; 
	private static readonly float[] GaussWeights; 


	public static void Generate(in int size, in byte threshold, in byte[] image, ref float[] distanceField) { }

	private static float SampleClamped(float[] data, int size, int x, int y) { }

	private static Vector3 SampleClamped(Vector3[] data, int size, int x, int y) { }

	private static ushort SampleClamped(ushort[] data, int size, int x, int y) { }

	public static void GenerateVectors(in int size, in float[] distanceField, ref Vector3[] vectorField) { }

	public static void ApplyGaussianBlur(int size, float[] distanceField, int steps = 1) { }

	public void .ctor() { }

	private static void .cctor() { }

}

