public static class GenericsUtil // TypeDefIndex: 4817
{

	public static TDst Cast<TSrc, TDst>(TSrc obj) { }
	/* GenericInstMethod :
	|
	|-GenericsUtil.Cast<bool, bool>
	|-GenericsUtil.Cast<bool, byte>
	|-GenericsUtil.Cast<bool, sbyte>
	|-GenericsUtil.Cast<byte, bool>
	|-GenericsUtil.Cast<byte, byte>
	|-GenericsUtil.Cast<byte, sbyte>
	|-GenericsUtil.Cast<sbyte, bool>
	|-GenericsUtil.Cast<sbyte, byte>
	|-GenericsUtil.Cast<sbyte, sbyte>
	|
	|-GenericsUtil.Cast<bool, short>
	|-GenericsUtil.Cast<bool, ushort>
	|-GenericsUtil.Cast<byte, short>
	|-GenericsUtil.Cast<byte, ushort>
	|-GenericsUtil.Cast<sbyte, short>
	|-GenericsUtil.Cast<sbyte, ushort>
	|
	|-GenericsUtil.Cast<bool, int>
	|-GenericsUtil.Cast<bool, uint>
	|-GenericsUtil.Cast<byte, int>
	|-GenericsUtil.Cast<byte, uint>
	|-GenericsUtil.Cast<sbyte, int>
	|-GenericsUtil.Cast<sbyte, uint>
	|
	|-GenericsUtil.Cast<bool, long>
	|-GenericsUtil.Cast<bool, object>
	|-GenericsUtil.Cast<bool, ulong>
	|-GenericsUtil.Cast<byte, long>
	|-GenericsUtil.Cast<byte, object>
	|-GenericsUtil.Cast<byte, ulong>
	|-GenericsUtil.Cast<sbyte, long>
	|-GenericsUtil.Cast<sbyte, object>
	|-GenericsUtil.Cast<sbyte, ulong>
	|
	|-GenericsUtil.Cast<bool, float>
	|-GenericsUtil.Cast<byte, float>
	|-GenericsUtil.Cast<sbyte, float>
	|
	|-GenericsUtil.Cast<bool, Color>
	|-GenericsUtil.Cast<byte, Color>
	|-GenericsUtil.Cast<sbyte, Color>
	|
	|-GenericsUtil.Cast<bool, Ray>
	|-GenericsUtil.Cast<byte, Ray>
	|-GenericsUtil.Cast<sbyte, Ray>
	|
	|-GenericsUtil.Cast<bool, Vector3>
	|-GenericsUtil.Cast<byte, Vector3>
	|-GenericsUtil.Cast<sbyte, Vector3>
	|
	|-GenericsUtil.Cast<Guid, int>
	|-GenericsUtil.Cast<Color, int>
	|-GenericsUtil.Cast<Color, uint>
	|
	|-GenericsUtil.Cast<Guid, long>
	|-GenericsUtil.Cast<Guid, object>
	|-GenericsUtil.Cast<Color, long>
	|-GenericsUtil.Cast<Color, object>
	|-GenericsUtil.Cast<Color, ulong>
	|
	|-GenericsUtil.Cast<int, bool>
	|-GenericsUtil.Cast<int, byte>
	|-GenericsUtil.Cast<int, sbyte>
	|-GenericsUtil.Cast<uint, bool>
	|-GenericsUtil.Cast<uint, byte>
	|-GenericsUtil.Cast<uint, sbyte>
	|
	|-GenericsUtil.Cast<int, double>
	|
	|-GenericsUtil.Cast<int, Guid>
	|-GenericsUtil.Cast<int, Color>
	|-GenericsUtil.Cast<uint, Color>
	|
	|-GenericsUtil.Cast<int, short>
	|-GenericsUtil.Cast<int, ushort>
	|-GenericsUtil.Cast<uint, short>
	|-GenericsUtil.Cast<uint, ushort>
	|
	|-GenericsUtil.Cast<int, int>
	|-GenericsUtil.Cast<int, uint>
	|-GenericsUtil.Cast<uint, int>
	|-GenericsUtil.Cast<uint, uint>
	|
	|-GenericsUtil.Cast<int, long>
	|-GenericsUtil.Cast<int, object>
	|-GenericsUtil.Cast<int, ulong>
	|-GenericsUtil.Cast<uint, long>
	|-GenericsUtil.Cast<uint, object>
	|-GenericsUtil.Cast<uint, ulong>
	|
	|-GenericsUtil.Cast<int, float>
	|-GenericsUtil.Cast<uint, float>
	|
	|-GenericsUtil.Cast<int, Ray>
	|-GenericsUtil.Cast<uint, Ray>
	|
	|-GenericsUtil.Cast<int, Vector3>
	|-GenericsUtil.Cast<uint, Vector3>
	|
	|-GenericsUtil.Cast<long, int>
	|-GenericsUtil.Cast<ulong, int>
	|-GenericsUtil.Cast<ulong, uint>
	|
	|-GenericsUtil.Cast<long, long>
	|-GenericsUtil.Cast<long, object>
	|-GenericsUtil.Cast<ulong, long>
	|-GenericsUtil.Cast<ulong, object>
	|-GenericsUtil.Cast<ulong, ulong>
	|
	|-GenericsUtil.Cast<object, bool>
	|-GenericsUtil.Cast<object, byte>
	|-GenericsUtil.Cast<object, sbyte>
	|
	|-GenericsUtil.Cast<object, double>
	|
	|-GenericsUtil.Cast<object, Guid>
	|-GenericsUtil.Cast<object, Color>
	|
	|-GenericsUtil.Cast<object, short>
	|-GenericsUtil.Cast<object, ushort>
	|
	|-GenericsUtil.Cast<object, int>
	|-GenericsUtil.Cast<object, uint>
	|
	|-GenericsUtil.Cast<object, long>
	|-GenericsUtil.Cast<object, object>
	|-GenericsUtil.Cast<object, ulong>
	|
	|-GenericsUtil.Cast<object, float>
	|
	|-GenericsUtil.Cast<object, Ray>
	|
	|-GenericsUtil.Cast<object, Vector3>
	|
	|-GenericsUtil.Cast<float, bool>
	|-GenericsUtil.Cast<float, byte>
	|-GenericsUtil.Cast<float, sbyte>
	|
	|-GenericsUtil.Cast<float, short>
	|-GenericsUtil.Cast<float, ushort>
	|
	|-GenericsUtil.Cast<float, int>
	|-GenericsUtil.Cast<float, uint>
	|
	|-GenericsUtil.Cast<float, long>
	|-GenericsUtil.Cast<float, object>
	|-GenericsUtil.Cast<float, ulong>
	|
	|-GenericsUtil.Cast<float, float>
	|
	|-GenericsUtil.Cast<float, Color>
	|
	|-GenericsUtil.Cast<float, Ray>
	|
	|-GenericsUtil.Cast<float, Vector3>
	|
	|-GenericsUtil.Cast<ulong, bool>
	|-GenericsUtil.Cast<ulong, byte>
	|-GenericsUtil.Cast<ulong, sbyte>
	|
	|-GenericsUtil.Cast<ulong, short>
	|-GenericsUtil.Cast<ulong, ushort>
	|
	|-GenericsUtil.Cast<ulong, float>
	|
	|-GenericsUtil.Cast<ulong, Color>
	|
	|-GenericsUtil.Cast<ulong, Ray>
	|
	|-GenericsUtil.Cast<ulong, Vector3>
	|
	|-GenericsUtil.Cast<Color, bool>
	|-GenericsUtil.Cast<Color, byte>
	|-GenericsUtil.Cast<Color, sbyte>
	|
	|-GenericsUtil.Cast<Color, short>
	|-GenericsUtil.Cast<Color, ushort>
	|
	|-GenericsUtil.Cast<Color, float>
	|
	|-GenericsUtil.Cast<Color, Color>
	|
	|-GenericsUtil.Cast<Color, Ray>
	|
	|-GenericsUtil.Cast<Color, Vector3>
	|
	|-GenericsUtil.Cast<Ray, bool>
	|-GenericsUtil.Cast<Ray, byte>
	|-GenericsUtil.Cast<Ray, sbyte>
	|
	|-GenericsUtil.Cast<Ray, short>
	|-GenericsUtil.Cast<Ray, ushort>
	|
	|-GenericsUtil.Cast<Ray, int>
	|-GenericsUtil.Cast<Ray, uint>
	|
	|-GenericsUtil.Cast<Ray, long>
	|-GenericsUtil.Cast<Ray, object>
	|-GenericsUtil.Cast<Ray, ulong>
	|
	|-GenericsUtil.Cast<Ray, float>
	|
	|-GenericsUtil.Cast<Ray, Color>
	|
	|-GenericsUtil.Cast<Ray, Ray>
	|
	|-GenericsUtil.Cast<Ray, Vector3>
	|
	|-GenericsUtil.Cast<Vector3, bool>
	|-GenericsUtil.Cast<Vector3, byte>
	|-GenericsUtil.Cast<Vector3, sbyte>
	|
	|-GenericsUtil.Cast<Vector3, short>
	|-GenericsUtil.Cast<Vector3, ushort>
	|
	|-GenericsUtil.Cast<Vector3, int>
	|-GenericsUtil.Cast<Vector3, uint>
	|
	|-GenericsUtil.Cast<Vector3, long>
	|-GenericsUtil.Cast<Vector3, object>
	|-GenericsUtil.Cast<Vector3, ulong>
	|
	|-GenericsUtil.Cast<Vector3, float>
	|
	|-GenericsUtil.Cast<Vector3, Color>
	|
	|-GenericsUtil.Cast<Vector3, Ray>
	|
	|-GenericsUtil.Cast<Vector3, Vector3>
	*/

	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-GenericsUtil.Swap<List<PlaceMonuments.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsOffshore.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRailside.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRoadside.SpawnInfo>>
	|-GenericsUtil.Swap<object>
	|-GenericsUtil.Swap<float[]>
	*/

}

private static class GenericsUtil.CastImpl<TSrc, TDst> // TypeDefIndex: 4818
{
	[ThreadStaticAttribute] 
	public static TSrc Value; 


	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-GenericsUtil.CastImpl<bool, bool>..cctor
	|
	|-GenericsUtil.CastImpl<bool, byte>..cctor
	|
	|-GenericsUtil.CastImpl<bool, short>..cctor
	|
	|-GenericsUtil.CastImpl<bool, int>..cctor
	|
	|-GenericsUtil.CastImpl<bool, long>..cctor
	|
	|-GenericsUtil.CastImpl<bool, object>..cctor
	|
	|-GenericsUtil.CastImpl<bool, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<bool, float>..cctor
	|
	|-GenericsUtil.CastImpl<bool, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<bool, uint>..cctor
	|
	|-GenericsUtil.CastImpl<bool, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<bool, Color>..cctor
	|
	|-GenericsUtil.CastImpl<bool, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<bool, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<byte, bool>..cctor
	|
	|-GenericsUtil.CastImpl<byte, byte>..cctor
	|
	|-GenericsUtil.CastImpl<byte, short>..cctor
	|
	|-GenericsUtil.CastImpl<byte, int>..cctor
	|
	|-GenericsUtil.CastImpl<byte, long>..cctor
	|
	|-GenericsUtil.CastImpl<byte, object>..cctor
	|
	|-GenericsUtil.CastImpl<byte, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<byte, float>..cctor
	|
	|-GenericsUtil.CastImpl<byte, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<byte, uint>..cctor
	|
	|-GenericsUtil.CastImpl<byte, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<byte, Color>..cctor
	|
	|-GenericsUtil.CastImpl<byte, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<byte, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<double, int>..cctor
	|
	|-GenericsUtil.CastImpl<double, object>..cctor
	|
	|-GenericsUtil.CastImpl<Guid, int>..cctor
	|
	|-GenericsUtil.CastImpl<Guid, long>..cctor
	|
	|-GenericsUtil.CastImpl<Guid, object>..cctor
	|
	|-GenericsUtil.CastImpl<short, bool>..cctor
	|
	|-GenericsUtil.CastImpl<short, byte>..cctor
	|
	|-GenericsUtil.CastImpl<short, int>..cctor
	|
	|-GenericsUtil.CastImpl<short, object>..cctor
	|
	|-GenericsUtil.CastImpl<short, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<short, float>..cctor
	|
	|-GenericsUtil.CastImpl<short, uint>..cctor
	|
	|-GenericsUtil.CastImpl<short, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<short, Color>..cctor
	|
	|-GenericsUtil.CastImpl<short, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<short, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<int, bool>..cctor
	|
	|-GenericsUtil.CastImpl<int, byte>..cctor
	|
	|-GenericsUtil.CastImpl<int, double>..cctor
	|
	|-GenericsUtil.CastImpl<int, Guid>..cctor
	|
	|-GenericsUtil.CastImpl<int, short>..cctor
	|
	|-GenericsUtil.CastImpl<int, int>..cctor
	|
	|-GenericsUtil.CastImpl<int, long>..cctor
	|
	|-GenericsUtil.CastImpl<int, object>..cctor
	|
	|-GenericsUtil.CastImpl<int, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<int, float>..cctor
	|
	|-GenericsUtil.CastImpl<int, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<int, uint>..cctor
	|
	|-GenericsUtil.CastImpl<int, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<int, Color>..cctor
	|
	|-GenericsUtil.CastImpl<int, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<int, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<long, bool>..cctor
	|
	|-GenericsUtil.CastImpl<long, byte>..cctor
	|
	|-GenericsUtil.CastImpl<long, Guid>..cctor
	|
	|-GenericsUtil.CastImpl<long, int>..cctor
	|
	|-GenericsUtil.CastImpl<long, long>..cctor
	|
	|-GenericsUtil.CastImpl<long, object>..cctor
	|
	|-GenericsUtil.CastImpl<long, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<long, float>..cctor
	|
	|-GenericsUtil.CastImpl<long, uint>..cctor
	|
	|-GenericsUtil.CastImpl<long, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<long, Color>..cctor
	|
	|-GenericsUtil.CastImpl<long, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<long, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<object, bool>..cctor
	|
	|-GenericsUtil.CastImpl<object, byte>..cctor
	|
	|-GenericsUtil.CastImpl<object, double>..cctor
	|
	|-GenericsUtil.CastImpl<object, Guid>..cctor
	|
	|-GenericsUtil.CastImpl<object, short>..cctor
	|
	|-GenericsUtil.CastImpl<object, int>..cctor
	|
	|-GenericsUtil.CastImpl<object, long>..cctor
	|
	|-GenericsUtil.CastImpl<object, object>..cctor
	|
	|-GenericsUtil.CastImpl<object, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<object, float>..cctor
	|
	|-GenericsUtil.CastImpl<object, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<object, uint>..cctor
	|
	|-GenericsUtil.CastImpl<object, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<object, Color>..cctor
	|
	|-GenericsUtil.CastImpl<object, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<object, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, bool>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, byte>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, short>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, int>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, long>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, object>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, float>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, uint>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, Color>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<sbyte, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<float, bool>..cctor
	|
	|-GenericsUtil.CastImpl<float, byte>..cctor
	|
	|-GenericsUtil.CastImpl<float, short>..cctor
	|
	|-GenericsUtil.CastImpl<float, int>..cctor
	|
	|-GenericsUtil.CastImpl<float, long>..cctor
	|
	|-GenericsUtil.CastImpl<float, object>..cctor
	|
	|-GenericsUtil.CastImpl<float, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<float, float>..cctor
	|
	|-GenericsUtil.CastImpl<float, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<float, uint>..cctor
	|
	|-GenericsUtil.CastImpl<float, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<float, Color>..cctor
	|
	|-GenericsUtil.CastImpl<float, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<float, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, bool>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, byte>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, int>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, object>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, float>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, uint>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, Color>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<ushort, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<uint, bool>..cctor
	|
	|-GenericsUtil.CastImpl<uint, byte>..cctor
	|
	|-GenericsUtil.CastImpl<uint, short>..cctor
	|
	|-GenericsUtil.CastImpl<uint, int>..cctor
	|
	|-GenericsUtil.CastImpl<uint, long>..cctor
	|
	|-GenericsUtil.CastImpl<uint, object>..cctor
	|
	|-GenericsUtil.CastImpl<uint, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<uint, float>..cctor
	|
	|-GenericsUtil.CastImpl<uint, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<uint, uint>..cctor
	|
	|-GenericsUtil.CastImpl<uint, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<uint, Color>..cctor
	|
	|-GenericsUtil.CastImpl<uint, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<uint, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, bool>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, byte>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, short>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, int>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, long>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, object>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, float>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, uint>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, Color>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<ulong, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<Color, bool>..cctor
	|
	|-GenericsUtil.CastImpl<Color, byte>..cctor
	|
	|-GenericsUtil.CastImpl<Color, short>..cctor
	|
	|-GenericsUtil.CastImpl<Color, int>..cctor
	|
	|-GenericsUtil.CastImpl<Color, long>..cctor
	|
	|-GenericsUtil.CastImpl<Color, object>..cctor
	|
	|-GenericsUtil.CastImpl<Color, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<Color, float>..cctor
	|
	|-GenericsUtil.CastImpl<Color, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<Color, uint>..cctor
	|
	|-GenericsUtil.CastImpl<Color, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<Color, Color>..cctor
	|
	|-GenericsUtil.CastImpl<Color, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<Color, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, bool>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, byte>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, short>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, int>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, long>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, object>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, float>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, uint>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, Color>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<Ray, Vector3>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, bool>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, byte>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, short>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, int>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, long>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, object>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, sbyte>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, float>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, ushort>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, uint>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, ulong>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, Color>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, Ray>..cctor
	|
	|-GenericsUtil.CastImpl<Vector3, Vector3>..cctor
	*/

}

