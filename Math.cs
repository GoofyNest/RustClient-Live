public static class Math // TypeDefIndex: 266
{	// Fields
	private static double doubleRoundLimit; // 0x0
	private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; // 0x8
	public const double PI = 3,14159265358979;
	public const double E = 2,71828182845905;

	// Methods

	// RVA: 0x166F980 Offset: 0x166ED80 VA: 0x18166F980
	public static double Acos(double d) { }

	// RVA: 0x166F990 Offset: 0x166ED90 VA: 0x18166F990
	public static double Asin(double d) { }

	// RVA: 0x166F9B0 Offset: 0x166EDB0 VA: 0x18166F9B0
	public static double Atan(double d) { }

	// RVA: 0x166F9A0 Offset: 0x166EDA0 VA: 0x18166F9A0
	public static double Atan2(double y, double x) { }

	// RVA: 0x166F9C0 Offset: 0x166EDC0 VA: 0x18166F9C0
	public static double Ceiling(double a) { }

	// RVA: 0x166F9D0 Offset: 0x166EDD0 VA: 0x18166F9D0
	public static double Cos(double d) { }

	// RVA: 0x166F9E0 Offset: 0x166EDE0 VA: 0x18166F9E0
	public static double Cosh(double value) { }

	// RVA: 0x166FA10 Offset: 0x166EE10 VA: 0x18166FA10
	public static double Floor(double d) { }

	// RVA: 0x166FA20 Offset: 0x166EE20 VA: 0x18166FA20
	private static double InternalRound(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x166FC80 Offset: 0x166F080 VA: 0x18166FC80
	private static double InternalTruncate(double d) { }

	// RVA: 0x1670710 Offset: 0x166FB10 VA: 0x181670710
	public static double Sin(double a) { }

	// RVA: 0x1670750 Offset: 0x166FB50 VA: 0x181670750
	public static double Tan(double a) { }

	// RVA: 0x1670720 Offset: 0x166FB20 VA: 0x181670720
	public static double Sinh(double value) { }

	// RVA: 0x16703F0 Offset: 0x166F7F0 VA: 0x1816703F0
	public static double Round(double a) { }

	// RVA: 0x1670270 Offset: 0x166F670 VA: 0x181670270
	public static double Round(double value, MidpointRounding mode) { }

	// RVA: 0x1670400 Offset: 0x166F800 VA: 0x181670400
	public static double Round(double value, int digits, MidpointRounding mode) { }

	// RVA: 0x1670590 Offset: 0x166F990 VA: 0x181670590
	public static Decimal Round(Decimal d) { }

	// RVA: 0x1670730 Offset: 0x166FB30 VA: 0x181670730
	private static double SplitFractionDouble(double* value) { }

	// RVA: 0x1670760 Offset: 0x166FB60 VA: 0x181670760
	public static double Truncate(double d) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670740 Offset: 0x166FB40 VA: 0x181670740
	public static double Sqrt(double d) { }

	// RVA: 0x166FE50 Offset: 0x166F250 VA: 0x18166FE50
	public static double Log(double d) { }

	// RVA: 0x166FCE0 Offset: 0x166F0E0 VA: 0x18166FCE0
	public static double Log10(double d) { }

	// RVA: 0x166FA00 Offset: 0x166EE00 VA: 0x18166FA00
	public static double Exp(double d) { }

	// RVA: 0x1670260 Offset: 0x166F660 VA: 0x181670260
	public static double Pow(double x, double y) { }

	// RVA: 0x166F8B0 Offset: 0x166ECB0 VA: 0x18166F8B0
	public static int Abs(int value) { }

	// RVA: 0x166F750 Offset: 0x166EB50 VA: 0x18166F750
	private static int AbsHelper(int value) { }

	// RVA: 0x166F7D0 Offset: 0x166EBD0 VA: 0x18166F7D0
	public static long Abs(long value) { }

	// RVA: 0x166F6C0 Offset: 0x166EAC0 VA: 0x18166F6C0
	private static long AbsHelper(long value) { }

	// RVA: 0x166F970 Offset: 0x166ED70 VA: 0x18166F970
	public static float Abs(float value) { }

	// RVA: 0x166F8A0 Offset: 0x166ECA0 VA: 0x18166F8A0
	public static double Abs(double value) { }

	[ReliabilityContractAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	[CLSCompliantAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	// RVA: 0x166FF00 Offset: 0x166F300 VA: 0x18166FF00
	public static sbyte Max(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x166FE70 Offset: 0x166F270 VA: 0x18166FE70
	public static byte Max(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670050 Offset: 0x166F450 VA: 0x181670050
	public static short Max(short val1, short val2) { }

	[ReliabilityContractAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	[CLSCompliantAttribute] // RVA: 0x7D700 Offset: 0x7CB00 VA: 0x18007D700
	// RVA: 0x166FE90 Offset: 0x166F290 VA: 0x18166FE90
	public static ushort Max(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x166FFB0 Offset: 0x166F3B0 VA: 0x18166FFB0
	public static int Max(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	[ReliabilityContractAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	// RVA: 0x166FE80 Offset: 0x166F280 VA: 0x18166FE80
	public static uint Max(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x166FE60 Offset: 0x166F260 VA: 0x18166FE60
	public static long Max(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	[ReliabilityContractAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	// RVA: 0x166FEF0 Offset: 0x166F2F0 VA: 0x18166FEF0
	public static ulong Max(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x166FEA0 Offset: 0x166F2A0 VA: 0x18166FEA0
	public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x166FFC0 Offset: 0x166F3C0 VA: 0x18166FFC0
	public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x166FF10 Offset: 0x166F310 VA: 0x18166FF10
	public static Decimal Max(Decimal val1, Decimal val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	[ReliabilityContractAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	// RVA: 0x1670250 Offset: 0x166F650 VA: 0x181670250
	public static sbyte Min(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670110 Offset: 0x166F510 VA: 0x181670110
	public static byte Min(byte val1, byte val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670120 Offset: 0x166F520 VA: 0x181670120
	public static short Min(short val1, short val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	[ReliabilityContractAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	// RVA: 0x16700F0 Offset: 0x166F4F0 VA: 0x1816700F0
	public static ushort Min(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670220 Offset: 0x166F620 VA: 0x181670220
	public static int Min(int val1, int val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	[ReliabilityContractAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	// RVA: 0x1670240 Offset: 0x166F640 VA: 0x181670240
	public static uint Min(uint val1, uint val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670100 Offset: 0x166F500 VA: 0x181670100
	public static long Min(long val1, long val2) { }

	[CLSCompliantAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	[ReliabilityContractAttribute] // RVA: 0x7DB80 Offset: 0x7CF80 VA: 0x18007DB80
	// RVA: 0x1670230 Offset: 0x166F630 VA: 0x181670230
	public static ulong Min(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670130 Offset: 0x166F530 VA: 0x181670130
	public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670060 Offset: 0x166F460 VA: 0x181670060
	public static double Min(double val1, double val2) { }

	[ReliabilityContractAttribute] // RVA: 0x76C70 Offset: 0x76070 VA: 0x180076C70
	// RVA: 0x1670180 Offset: 0x166F580 VA: 0x181670180
	public static Decimal Min(Decimal val1, Decimal val2) { }

	// RVA: 0x166FCF0 Offset: 0x166F0F0 VA: 0x18166FCF0
	public static double Log(double a, double newBase) { }

	// RVA: 0x16706D0 Offset: 0x166FAD0 VA: 0x1816706D0
	public static int Sign(int value) { }

	// RVA: 0x16706F0 Offset: 0x166FAF0 VA: 0x1816706F0
	public static int Sign(long value) { }

	// RVA: 0x1670610 Offset: 0x166FA10 VA: 0x181670610
	public static int Sign(double value) { }

	// RVA: 0x166F9F0 Offset: 0x166EDF0 VA: 0x18166F9F0
	public static long DivRem(long a, long b, out long result) { }

	// RVA: 0x1670810 Offset: 0x166FC10 VA: 0x181670810
	private static void .cctor() { }

}

public static class math // TypeDefIndex: 7099
{
// Namespace: Unity.Mathematics
public static class math // TypeDefIndex: 7099
	// Methods

	// RVA: 0x22A9830 Offset: 0x22A8C30 VA: 0x1822A9830
	public static float2 float2(float x, float y) { }

	// RVA: 0x22A9AA0 Offset: 0x22A8EA0 VA: 0x1822A9AA0
	public static uint hash(float2 v) { }

	// RVA: 0x22A9CC0 Offset: 0x22A90C0 VA: 0x1822A9CC0
	public static uint hash(float3 v) { }

	// RVA: 0x22A9880 Offset: 0x22A8C80 VA: 0x1822A9880
	public static float4 float4(float x, float y, float z, float w) { }

	// RVA: 0x22A9840 Offset: 0x22A8C40 VA: 0x1822A9840
	public static float4 float4(float3 xyz, float w) { }

	// RVA: 0x22A98E0 Offset: 0x22A8CE0 VA: 0x1822A98E0
	public static uint hash(float4 v) { }

	// RVA: 0x22A98A0 Offset: 0x22A8CA0 VA: 0x1822A98A0
	public static uint hash(half2 v) { }

	// RVA: 0x22A9D60 Offset: 0x22A9160 VA: 0x1822A9D60
	public static int2 int2(int x, int y) { }

	// RVA: 0x22A9A70 Offset: 0x22A8E70 VA: 0x1822A9A70
	public static uint hash(int2 v) { }

	// RVA: 0x22A93C0 Offset: 0x22A87C0 VA: 0x1822A93C0
	public static int asint(float x) { }

	// RVA: 0x226C7F0 Offset: 0x226BBF0 VA: 0x18226C7F0
	public static uint2 asuint(int2 x) { }

	// RVA: 0x22A93C0 Offset: 0x22A87C0 VA: 0x1822A93C0
	public static uint asuint(float x) { }

	// RVA: 0x22A94A0 Offset: 0x22A88A0 VA: 0x1822A94A0
	public static uint2 asuint(float2 x) { }

	// RVA: 0x22A93D0 Offset: 0x22A87D0 VA: 0x1822A93D0
	public static uint3 asuint(float3 x) { }

	// RVA: 0x22A9440 Offset: 0x22A8840 VA: 0x1822A9440
	public static uint4 asuint(float4 x) { }

	// RVA: 0x22A93B0 Offset: 0x22A87B0 VA: 0x1822A93B0
	public static float asfloat(int x) { }

	// RVA: 0x22A93B0 Offset: 0x22A87B0 VA: 0x1822A93B0
	public static float asfloat(uint x) { }

	// RVA: 0x22AA0B0 Offset: 0x22A94B0 VA: 0x1822AA0B0
	public static int min(int x, int y) { }

	// RVA: 0x22AA080 Offset: 0x22A9480 VA: 0x1822AA080
	public static int2 min(int2 x, int2 y) { }

	// RVA: 0x22398F0 Offset: 0x2238CF0 VA: 0x1822398F0
	public static float min(float x, float y) { }

	// RVA: 0x22AA070 Offset: 0x22A9470 VA: 0x1822AA070
	public static int max(int x, int y) { }

	// RVA: 0x22AA040 Offset: 0x22A9440 VA: 0x1822AA040
	public static int2 max(int2 x, int2 y) { }

	// RVA: 0x223A030 Offset: 0x2239430 VA: 0x18223A030
	public static float max(float x, float y) { }

	// RVA: 0x22A9F80 Offset: 0x22A9380 VA: 0x1822A9F80
	public static float3 lerp(float3 x, float3 y, float s) { }

	// RVA: 0x22A9EC0 Offset: 0x22A92C0 VA: 0x1822A9EC0
	public static float4 lerp(float4 x, float4 y, float s) { }

	// RVA: 0x22A94E0 Offset: 0x22A88E0 VA: 0x1822A94E0
	public static int2 clamp(int2 x, int2 a, int2 b) { }

	// RVA: 0x22A9520 Offset: 0x22A8920 VA: 0x1822A9520
	public static float clamp(float x, float a, float b) { }

	// RVA: 0x22A9730 Offset: 0x22A8B30 VA: 0x1822A9730
	public static float dot(float3 x, float3 y) { }

	// RVA: 0x22A96E0 Offset: 0x22A8AE0 VA: 0x1822A96E0
	public static float dot(float4 x, float4 y) { }

	// RVA: 0x22A9590 Offset: 0x22A8990 VA: 0x1822A9590
	public static float cos(float x) { }

	// RVA: 0x22A9320 Offset: 0x22A8720 VA: 0x1822A9320
	public static float acos(float x) { }

	// RVA: 0x22AA9A0 Offset: 0x22A9DA0 VA: 0x1822AA9A0
	public static float sin(float x) { }

	// RVA: 0x22AA8E0 Offset: 0x22A9CE0 VA: 0x1822AA8E0
	public static float rcp(float x) { }

	// RVA: 0x22AAF00 Offset: 0x22AA300 VA: 0x1822AAF00
	public static float sqrt(float x) { }

	// RVA: 0x22AA8F0 Offset: 0x22A9CF0 VA: 0x1822AA8F0
	public static float rsqrt(float x) { }

	// RVA: 0x22AA670 Offset: 0x22A9A70 VA: 0x1822AA670
	public static float3 normalizesafe(float3 x, float3 defaultvalue) { }

	// RVA: 0x22A9E20 Offset: 0x22A9220 VA: 0x1822A9E20
	public static float length(float3 x) { }

	// RVA: 0x22A95F0 Offset: 0x22A89F0 VA: 0x1822A95F0
	public static float3 cross(float3 x, float3 y) { }

	// RVA: 0x22A9380 Offset: 0x22A8780 VA: 0x1822A9380
	public static bool any(float2 x) { }

	// RVA: 0x22AA960 Offset: 0x22A9D60 VA: 0x1822AA960
	public static uint select(uint a, uint b, bool c) { }

	// RVA: 0x22AA970 Offset: 0x22A9D70 VA: 0x1822AA970
	public static float3 select(float3 a, float3 b, bool c) { }

	// RVA: 0x22AA7A0 Offset: 0x22A9BA0 VA: 0x1822AA7A0
	public static float3 project(float3 a, float3 b) { }

	// RVA: 0x22AAA00 Offset: 0x22A9E00 VA: 0x1822AAA00
	public static void sincos(float x, out float s, out float c) { }

	// RVA: 0x22A9680 Offset: 0x22A8A80 VA: 0x1822A9680
	public static uint csum(uint2 x) { }

	// RVA: 0x22A9690 Offset: 0x22A8A90 VA: 0x1822A9690
	public static uint csum(uint3 x) { }

	// RVA: 0x22A96B0 Offset: 0x22A8AB0 VA: 0x1822A96B0
	public static uint csum(uint4 x) { }

	// RVA: 0x22A97C0 Offset: 0x22A8BC0 VA: 0x1822A97C0
	public static float f16tof32(uint x) { }

	// RVA: 0x22AA8D0 Offset: 0x22A9CD0 VA: 0x1822AA8D0
	public static quaternion quaternion(float4 value) { }

	// RVA: 0x22A9D70 Offset: 0x22A9170 VA: 0x1822A9D70
	public static quaternion inverse(quaternion q) { }

	// RVA: 0x22A9770 Offset: 0x22A8B70 VA: 0x1822A9770
	public static float dot(quaternion a, quaternion b) { }

	// RVA: 0x22AA540 Offset: 0x22A9940 VA: 0x1822AA540
	public static quaternion normalize(quaternion q) { }

	// RVA: 0x223A200 Offset: 0x2239600 VA: 0x18223A200
	public static quaternion mul(quaternion a, quaternion b) { }

	// RVA: 0x223A080 Offset: 0x2239480 VA: 0x18223A080
	public static float3 mul(quaternion q, float3 v) { }

	// RVA: 0x223A080 Offset: 0x2239480 VA: 0x18223A080
	public static float3 rotate(quaternion q, float3 v) { }

	// RVA: 0x22AA3C0 Offset: 0x22A97C0 VA: 0x1822AA3C0
	public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22AAAD0 Offset: 0x22A9ED0 VA: 0x1822AAAD0
	public static quaternion slerp(quaternion q1, quaternion q2, float t) { }

	// RVA: 0x22A98E0 Offset: 0x22A8CE0 VA: 0x1822A98E0
	public static uint hash(quaternion q) { }

	// RVA: 0x22A9300 Offset: 0x22A8700 VA: 0x1822A9300
	public static RigidTransform RigidTransform(quaternion rot, float3 pos) { }

	// RVA: 0x2239D70 Offset: 0x2239170 VA: 0x182239D70
	public static RigidTransform inverse(RigidTransform t) { }

	// RVA: 0x22AA0C0 Offset: 0x22A94C0 VA: 0x1822AA0C0
	public static RigidTransform mul(RigidTransform a, RigidTransform b) { }

	// RVA: 0x22A9B60 Offset: 0x22A8F60 VA: 0x1822A9B60
	public static uint hash(RigidTransform t) { }

	// RVA: 0x22A9D60 Offset: 0x22A9160 VA: 0x1822A9D60
	public static uint2 uint2(uint x, uint y) { }

	// RVA: 0x22A98C0 Offset: 0x22A8CC0 VA: 0x1822A98C0
	public static uint hash(uint2 v) { }

	// RVA: 0x22AAF60 Offset: 0x22AA360 VA: 0x1822AAF60
	public static uint3 uint3(uint x, uint y, uint z) { }

	// RVA: 0x22A9AF0 Offset: 0x22A8EF0 VA: 0x1822A9AF0
	public static uint hash(uint3 v) { }

	// RVA: 0x22AAF70 Offset: 0x22AA370 VA: 0x1822AAF70
	public static uint4 uint4(uint x, uint y, uint z, uint w) { }

	// RVA: 0x22A99C0 Offset: 0x22A8DC0 VA: 0x1822A99C0
	public static uint hash(uint4 v) { }

}

internal struct math.IntFloatUnion // TypeDefIndex: 7100
{	// Fields
	public int intValue; // 0x0
	public float floatValue; // 0x0

}

