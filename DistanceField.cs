public class DistanceField // TypeDefIndex: 11356
{	// Fields
	private static readonly int[] GaussOffsets; // 0x0
	private static readonly float[] GaussWeights; // 0x8

	// Methods

	// RVA: 0x9C8160 Offset: 0x9C7560 VA: 0x1809C8160
	public static void Generate(in int size, in byte threshold, in byte[] image, ref float[] distanceField) { }

	// RVA: 0x9C9040 Offset: 0x9C8440 VA: 0x1809C9040
	private static float SampleClamped(float[] data, int size, int x, int y) { }

	// RVA: 0x9C8FC0 Offset: 0x9C83C0 VA: 0x1809C8FC0
	private static Vector3 SampleClamped(Vector3[] data, int size, int x, int y) { }

	// RVA: 0x9C8F60 Offset: 0x9C8360 VA: 0x1809C8F60
	private static ushort SampleClamped(ushort[] data, int size, int x, int y) { }

	// RVA: 0x9C7A30 Offset: 0x9C6E30 VA: 0x1809C7A30
	public static void GenerateVectors(in int size, in float[] distanceField, ref Vector3[] vectorField) { }

	// RVA: 0x9C7640 Offset: 0x9C6A40 VA: 0x1809C7640
	public static void ApplyGaussianBlur(int size, float[] distanceField, int steps = 1) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x9C90A0 Offset: 0x9C84A0 VA: 0x1809C90A0
	private static void .cctor() { }

}

