public static class Math // TypeDefIndex: 266
{
	private static double doubleRoundLimit; 
private const int maxRoundingDigits = 15;
	private static double[] roundPower10Double; 
public const double PI = 3,14159265358979;
public const double E = 2,71828182845905;


public static double Acos(double d) { }

public static double Asin(double d) { }

public static double Atan(double d) { }

public static double Atan2(double y, double x) { }

public static double Ceiling(double a) { }

public static double Cos(double d) { }

public static double Cosh(double value) { }

public static double Floor(double d) { }

private static double InternalRound(double value, int digits, MidpointRounding mode) { }

private static double InternalTruncate(double d) { }

public static double Sin(double a) { }

public static double Tan(double a) { }

public static double Sinh(double value) { }

public static double Round(double a) { }

public static double Round(double value, MidpointRounding mode) { }

public static double Round(double value, int digits, MidpointRounding mode) { }

public static Decimal Round(Decimal d) { }

private static double SplitFractionDouble(double* value) { }

public static double Truncate(double d) { }

	[ReliabilityContractAttribute] 
public static double Sqrt(double d) { }

public static double Log(double d) { }

public static double Log10(double d) { }

public static double Exp(double d) { }

public static double Pow(double x, double y) { }

public static int Abs(int value) { }

private static int AbsHelper(int value) { }

public static long Abs(long value) { }

private static long AbsHelper(long value) { }

public static float Abs(float value) { }

public static double Abs(double value) { }

	[ReliabilityContractAttribute] 
	[CLSCompliantAttribute] 
public static sbyte Max(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] 
public static byte Max(byte val1, byte val2) { }

	[ReliabilityContractAttribute] 
public static short Max(short val1, short val2) { }

	[ReliabilityContractAttribute] 
	[CLSCompliantAttribute] 
public static ushort Max(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] 
public static int Max(int val1, int val2) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
public static uint Max(uint val1, uint val2) { }

	[ReliabilityContractAttribute] 
public static long Max(long val1, long val2) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
public static ulong Max(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] 
public static float Max(float val1, float val2) { }

	[ReliabilityContractAttribute] 
public static double Max(double val1, double val2) { }

	[ReliabilityContractAttribute] 
public static Decimal Max(Decimal val1, Decimal val2) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
public static sbyte Min(sbyte val1, sbyte val2) { }

	[ReliabilityContractAttribute] 
public static byte Min(byte val1, byte val2) { }

	[ReliabilityContractAttribute] 
public static short Min(short val1, short val2) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
public static ushort Min(ushort val1, ushort val2) { }

	[ReliabilityContractAttribute] 
public static int Min(int val1, int val2) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
public static uint Min(uint val1, uint val2) { }

	[ReliabilityContractAttribute] 
public static long Min(long val1, long val2) { }

	[CLSCompliantAttribute] 
	[ReliabilityContractAttribute] 
public static ulong Min(ulong val1, ulong val2) { }

	[ReliabilityContractAttribute] 
public static float Min(float val1, float val2) { }

	[ReliabilityContractAttribute] 
public static double Min(double val1, double val2) { }

	[ReliabilityContractAttribute] 
public static Decimal Min(Decimal val1, Decimal val2) { }

public static double Log(double a, double newBase) { }

public static int Sign(int value) { }

public static int Sign(long value) { }

public static int Sign(double value) { }

public static long DivRem(long a, long b, out long result) { }

private static void .cctor() { }

}

public static class math // TypeDefIndex: 7099
{

public static class math 

public static float2 float2(float x, float y) { }

public static uint hash(float2 v) { }

public static uint hash(float3 v) { }

public static float4 float4(float x, float y, float z, float w) { }

public static float4 float4(float3 xyz, float w) { }

public static uint hash(float4 v) { }

public static uint hash(half2 v) { }

public static int2 int2(int x, int y) { }

public static uint hash(int2 v) { }

public static int asint(float x) { }

public static uint2 asuint(int2 x) { }

public static uint asuint(float x) { }

public static uint2 asuint(float2 x) { }

public static uint3 asuint(float3 x) { }

public static uint4 asuint(float4 x) { }

public static float asfloat(int x) { }

public static float asfloat(uint x) { }

public static int min(int x, int y) { }

public static int2 min(int2 x, int2 y) { }

public static float min(float x, float y) { }

public static int max(int x, int y) { }

public static int2 max(int2 x, int2 y) { }

public static float max(float x, float y) { }

public static float3 lerp(float3 x, float3 y, float s) { }

public static float4 lerp(float4 x, float4 y, float s) { }

public static int2 clamp(int2 x, int2 a, int2 b) { }

public static float clamp(float x, float a, float b) { }

public static float dot(float3 x, float3 y) { }

public static float dot(float4 x, float4 y) { }

public static float cos(float x) { }

public static float acos(float x) { }

public static float sin(float x) { }

public static float rcp(float x) { }

public static float sqrt(float x) { }

public static float rsqrt(float x) { }

public static float3 normalizesafe(float3 x, float3 defaultvalue) { }

public static float length(float3 x) { }

public static float3 cross(float3 x, float3 y) { }

public static bool any(float2 x) { }

public static uint select(uint a, uint b, bool c) { }

public static float3 select(float3 a, float3 b, bool c) { }

public static float3 project(float3 a, float3 b) { }

public static void sincos(float x, out float s, out float c) { }

public static uint csum(uint2 x) { }

public static uint csum(uint3 x) { }

public static uint csum(uint4 x) { }

public static float f16tof32(uint x) { }

public static quaternion quaternion(float4 value) { }

public static quaternion inverse(quaternion q) { }

public static float dot(quaternion a, quaternion b) { }

public static quaternion normalize(quaternion q) { }

public static quaternion mul(quaternion a, quaternion b) { }

public static float3 mul(quaternion q, float3 v) { }

public static float3 rotate(quaternion q, float3 v) { }

public static quaternion nlerp(quaternion q1, quaternion q2, float t) { }

public static quaternion slerp(quaternion q1, quaternion q2, float t) { }

public static uint hash(quaternion q) { }

public static RigidTransform RigidTransform(quaternion rot, float3 pos) { }

public static RigidTransform inverse(RigidTransform t) { }

public static RigidTransform mul(RigidTransform a, RigidTransform b) { }

public static uint hash(RigidTransform t) { }

public static uint2 uint2(uint x, uint y) { }

public static uint hash(uint2 v) { }

public static uint3 uint3(uint x, uint y, uint z) { }

public static uint hash(uint3 v) { }

public static uint4 uint4(uint x, uint y, uint z, uint w) { }

public static uint hash(uint4 v) { }

}

internal struct math.IntFloatUnion // TypeDefIndex: 7100
{
	public int intValue; 
	public float floatValue; 

}

