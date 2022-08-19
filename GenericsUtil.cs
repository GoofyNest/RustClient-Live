public static class GenericsUtil // TypeDefIndex: 4817
{	// Methods

	// RVA: -1 Offset: -1
	public static TDst Cast<TSrc, TDst>(TSrc obj) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x14A98A0 Offset: 0x14A8CA0 VA: 0x1814A98A0
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
	|-RVA: 0x14A9B30 Offset: 0x14A8F30 VA: 0x1814A9B30
	|-GenericsUtil.Cast<bool, short>
	|-GenericsUtil.Cast<bool, ushort>
	|-GenericsUtil.Cast<byte, short>
	|-GenericsUtil.Cast<byte, ushort>
	|-GenericsUtil.Cast<sbyte, short>
	|-GenericsUtil.Cast<sbyte, ushort>
	|
	|-RVA: 0x14A9C70 Offset: 0x14A9070 VA: 0x1814A9C70
	|-GenericsUtil.Cast<bool, int>
	|-GenericsUtil.Cast<bool, uint>
	|-GenericsUtil.Cast<byte, int>
	|-GenericsUtil.Cast<byte, uint>
	|-GenericsUtil.Cast<sbyte, int>
	|-GenericsUtil.Cast<sbyte, uint>
	|
	|-RVA: 0x14A9DB0 Offset: 0x14A91B0 VA: 0x1814A9DB0
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
	|-RVA: 0x14AA040 Offset: 0x14A9440 VA: 0x1814AA040
	|-GenericsUtil.Cast<bool, float>
	|-GenericsUtil.Cast<byte, float>
	|-GenericsUtil.Cast<sbyte, float>
	|
	|-RVA: 0x14A99E0 Offset: 0x14A8DE0 VA: 0x1814A99E0
	|-GenericsUtil.Cast<bool, Color>
	|-GenericsUtil.Cast<byte, Color>
	|-GenericsUtil.Cast<sbyte, Color>
	|
	|-RVA: 0x14A9EF0 Offset: 0x14A92F0 VA: 0x1814A9EF0
	|-GenericsUtil.Cast<bool, Ray>
	|-GenericsUtil.Cast<byte, Ray>
	|-GenericsUtil.Cast<sbyte, Ray>
	|
	|-RVA: 0x14AA180 Offset: 0x14A9580 VA: 0x1814AA180
	|-GenericsUtil.Cast<bool, Vector3>
	|-GenericsUtil.Cast<byte, Vector3>
	|-GenericsUtil.Cast<sbyte, Vector3>
	|
	|-RVA: 0x14AA6A0 Offset: 0x14A9AA0 VA: 0x1814AA6A0
	|-GenericsUtil.Cast<Guid, int>
	|-GenericsUtil.Cast<Color, int>
	|-GenericsUtil.Cast<Color, uint>
	|
	|-RVA: 0x14AA7E0 Offset: 0x14A9BE0 VA: 0x1814AA7E0
	|-GenericsUtil.Cast<Guid, long>
	|-GenericsUtil.Cast<Guid, object>
	|-GenericsUtil.Cast<Color, long>
	|-GenericsUtil.Cast<Color, object>
	|-GenericsUtil.Cast<Color, ulong>
	|
	|-RVA: 0x14AAD20 Offset: 0x14AA120 VA: 0x1814AAD20
	|-GenericsUtil.Cast<int, bool>
	|-GenericsUtil.Cast<int, byte>
	|-GenericsUtil.Cast<int, sbyte>
	|-GenericsUtil.Cast<uint, bool>
	|-GenericsUtil.Cast<uint, byte>
	|-GenericsUtil.Cast<uint, sbyte>
	|
	|-RVA: 0x14AAFB0 Offset: 0x14AA3B0 VA: 0x1814AAFB0
	|-GenericsUtil.Cast<int, double>
	|
	|-RVA: 0x14AAE60 Offset: 0x14AA260 VA: 0x1814AAE60
	|-GenericsUtil.Cast<int, Guid>
	|-GenericsUtil.Cast<int, Color>
	|-GenericsUtil.Cast<uint, Color>
	|
	|-RVA: 0x14AB0F0 Offset: 0x14AA4F0 VA: 0x1814AB0F0
	|-GenericsUtil.Cast<int, short>
	|-GenericsUtil.Cast<int, ushort>
	|-GenericsUtil.Cast<uint, short>
	|-GenericsUtil.Cast<uint, ushort>
	|
	|-RVA: 0x14AB230 Offset: 0x14AA630 VA: 0x1814AB230
	|-GenericsUtil.Cast<int, int>
	|-GenericsUtil.Cast<int, uint>
	|-GenericsUtil.Cast<uint, int>
	|-GenericsUtil.Cast<uint, uint>
	|
	|-RVA: 0x14AB360 Offset: 0x14AA760 VA: 0x1814AB360
	|-GenericsUtil.Cast<int, long>
	|-GenericsUtil.Cast<int, object>
	|-GenericsUtil.Cast<int, ulong>
	|-GenericsUtil.Cast<uint, long>
	|-GenericsUtil.Cast<uint, object>
	|-GenericsUtil.Cast<uint, ulong>
	|
	|-RVA: 0x14AB5F0 Offset: 0x14AA9F0 VA: 0x1814AB5F0
	|-GenericsUtil.Cast<int, float>
	|-GenericsUtil.Cast<uint, float>
	|
	|-RVA: 0x14AB4A0 Offset: 0x14AA8A0 VA: 0x1814AB4A0
	|-GenericsUtil.Cast<int, Ray>
	|-GenericsUtil.Cast<uint, Ray>
	|
	|-RVA: 0x14AB730 Offset: 0x14AAB30 VA: 0x1814AB730
	|-GenericsUtil.Cast<int, Vector3>
	|-GenericsUtil.Cast<uint, Vector3>
	|
	|-RVA: 0x14AB880 Offset: 0x14AAC80 VA: 0x1814AB880
	|-GenericsUtil.Cast<long, int>
	|-GenericsUtil.Cast<ulong, int>
	|-GenericsUtil.Cast<ulong, uint>
	|
	|-RVA: 0x14AB9C0 Offset: 0x14AADC0 VA: 0x1814AB9C0
	|-GenericsUtil.Cast<long, long>
	|-GenericsUtil.Cast<long, object>
	|-GenericsUtil.Cast<ulong, long>
	|-GenericsUtil.Cast<ulong, object>
	|-GenericsUtil.Cast<ulong, ulong>
	|
	|-RVA: 0x14AC570 Offset: 0x14AB970 VA: 0x1814AC570
	|-GenericsUtil.Cast<object, bool>
	|-GenericsUtil.Cast<object, byte>
	|-GenericsUtil.Cast<object, sbyte>
	|
	|-RVA: 0x14AC810 Offset: 0x14ABC10 VA: 0x1814AC810
	|-GenericsUtil.Cast<object, double>
	|
	|-RVA: 0x14AC6B0 Offset: 0x14ABAB0 VA: 0x1814AC6B0
	|-GenericsUtil.Cast<object, Guid>
	|-GenericsUtil.Cast<object, Color>
	|
	|-RVA: 0x14AC950 Offset: 0x14ABD50 VA: 0x1814AC950
	|-GenericsUtil.Cast<object, short>
	|-GenericsUtil.Cast<object, ushort>
	|
	|-RVA: 0x14ACA90 Offset: 0x14ABE90 VA: 0x1814ACA90
	|-GenericsUtil.Cast<object, int>
	|-GenericsUtil.Cast<object, uint>
	|
	|-RVA: 0x14ACBD0 Offset: 0x14ABFD0 VA: 0x1814ACBD0
	|-GenericsUtil.Cast<object, long>
	|-GenericsUtil.Cast<object, object>
	|-GenericsUtil.Cast<object, ulong>
	|
	|-RVA: 0x14ACE70 Offset: 0x14AC270 VA: 0x1814ACE70
	|-GenericsUtil.Cast<object, float>
	|
	|-RVA: 0x14ACD10 Offset: 0x14AC110 VA: 0x1814ACD10
	|-GenericsUtil.Cast<object, Ray>
	|
	|-RVA: 0x14ACFB0 Offset: 0x14AC3B0 VA: 0x1814ACFB0
	|-GenericsUtil.Cast<object, Vector3>
	|
	|-RVA: 0x14AD110 Offset: 0x14AC510 VA: 0x1814AD110
	|-GenericsUtil.Cast<float, bool>
	|-GenericsUtil.Cast<float, byte>
	|-GenericsUtil.Cast<float, sbyte>
	|
	|-RVA: 0x14AD3A0 Offset: 0x14AC7A0 VA: 0x1814AD3A0
	|-GenericsUtil.Cast<float, short>
	|-GenericsUtil.Cast<float, ushort>
	|
	|-RVA: 0x14AD4E0 Offset: 0x14AC8E0 VA: 0x1814AD4E0
	|-GenericsUtil.Cast<float, int>
	|-GenericsUtil.Cast<float, uint>
	|
	|-RVA: 0x14AD620 Offset: 0x14ACA20 VA: 0x1814AD620
	|-GenericsUtil.Cast<float, long>
	|-GenericsUtil.Cast<float, object>
	|-GenericsUtil.Cast<float, ulong>
	|
	|-RVA: 0x14AD8C0 Offset: 0x14ACCC0 VA: 0x1814AD8C0
	|-GenericsUtil.Cast<float, float>
	|
	|-RVA: 0x14AD250 Offset: 0x14AC650 VA: 0x1814AD250
	|-GenericsUtil.Cast<float, Color>
	|
	|-RVA: 0x14AD760 Offset: 0x14ACB60 VA: 0x1814AD760
	|-GenericsUtil.Cast<float, Ray>
	|
	|-RVA: 0x14ADA00 Offset: 0x14ACE00 VA: 0x1814ADA00
	|-GenericsUtil.Cast<float, Vector3>
	|
	|-RVA: 0x14ADB50 Offset: 0x14ACF50 VA: 0x1814ADB50
	|-GenericsUtil.Cast<ulong, bool>
	|-GenericsUtil.Cast<ulong, byte>
	|-GenericsUtil.Cast<ulong, sbyte>
	|
	|-RVA: 0x14ADDE0 Offset: 0x14AD1E0 VA: 0x1814ADDE0
	|-GenericsUtil.Cast<ulong, short>
	|-GenericsUtil.Cast<ulong, ushort>
	|
	|-RVA: 0x14AE070 Offset: 0x14AD470 VA: 0x1814AE070
	|-GenericsUtil.Cast<ulong, float>
	|
	|-RVA: 0x14ADC90 Offset: 0x14AD090 VA: 0x1814ADC90
	|-GenericsUtil.Cast<ulong, Color>
	|
	|-RVA: 0x14ADF20 Offset: 0x14AD320 VA: 0x1814ADF20
	|-GenericsUtil.Cast<ulong, Ray>
	|
	|-RVA: 0x14AE1B0 Offset: 0x14AD5B0 VA: 0x1814AE1B0
	|-GenericsUtil.Cast<ulong, Vector3>
	|
	|-RVA: 0x14AA2D0 Offset: 0x14A96D0 VA: 0x1814AA2D0
	|-GenericsUtil.Cast<Color, bool>
	|-GenericsUtil.Cast<Color, byte>
	|-GenericsUtil.Cast<Color, sbyte>
	|
	|-RVA: 0x14AA560 Offset: 0x14A9960 VA: 0x1814AA560
	|-GenericsUtil.Cast<Color, short>
	|-GenericsUtil.Cast<Color, ushort>
	|
	|-RVA: 0x14AAA80 Offset: 0x14A9E80 VA: 0x1814AAA80
	|-GenericsUtil.Cast<Color, float>
	|
	|-RVA: 0x14AA410 Offset: 0x14A9810 VA: 0x1814AA410
	|-GenericsUtil.Cast<Color, Color>
	|
	|-RVA: 0x14AA920 Offset: 0x14A9D20 VA: 0x1814AA920
	|-GenericsUtil.Cast<Color, Ray>
	|
	|-RVA: 0x14AABC0 Offset: 0x14A9FC0 VA: 0x1814AABC0
	|-GenericsUtil.Cast<Color, Vector3>
	|
	|-RVA: 0x14ABB00 Offset: 0x14AAF00 VA: 0x1814ABB00
	|-GenericsUtil.Cast<Ray, bool>
	|-GenericsUtil.Cast<Ray, byte>
	|-GenericsUtil.Cast<Ray, sbyte>
	|
	|-RVA: 0x14ABDA0 Offset: 0x14AB1A0 VA: 0x1814ABDA0
	|-GenericsUtil.Cast<Ray, short>
	|-GenericsUtil.Cast<Ray, ushort>
	|
	|-RVA: 0x14ABEE0 Offset: 0x14AB2E0 VA: 0x1814ABEE0
	|-GenericsUtil.Cast<Ray, int>
	|-GenericsUtil.Cast<Ray, uint>
	|
	|-RVA: 0x14AC020 Offset: 0x14AB420 VA: 0x1814AC020
	|-GenericsUtil.Cast<Ray, long>
	|-GenericsUtil.Cast<Ray, object>
	|-GenericsUtil.Cast<Ray, ulong>
	|
	|-RVA: 0x14AC2C0 Offset: 0x14AB6C0 VA: 0x1814AC2C0
	|-GenericsUtil.Cast<Ray, float>
	|
	|-RVA: 0x14ABC40 Offset: 0x14AB040 VA: 0x1814ABC40
	|-GenericsUtil.Cast<Ray, Color>
	|
	|-RVA: 0x14AC160 Offset: 0x14AB560 VA: 0x1814AC160
	|-GenericsUtil.Cast<Ray, Ray>
	|
	|-RVA: 0x14AC410 Offset: 0x14AB810 VA: 0x1814AC410
	|-GenericsUtil.Cast<Ray, Vector3>
	|
	|-RVA: 0x14AE300 Offset: 0x14AD700 VA: 0x1814AE300
	|-GenericsUtil.Cast<Vector3, bool>
	|-GenericsUtil.Cast<Vector3, byte>
	|-GenericsUtil.Cast<Vector3, sbyte>
	|
	|-RVA: 0x14AE5A0 Offset: 0x14AD9A0 VA: 0x1814AE5A0
	|-GenericsUtil.Cast<Vector3, short>
	|-GenericsUtil.Cast<Vector3, ushort>
	|
	|-RVA: 0x14AE6E0 Offset: 0x14ADAE0 VA: 0x1814AE6E0
	|-GenericsUtil.Cast<Vector3, int>
	|-GenericsUtil.Cast<Vector3, uint>
	|
	|-RVA: 0x14AE820 Offset: 0x14ADC20 VA: 0x1814AE820
	|-GenericsUtil.Cast<Vector3, long>
	|-GenericsUtil.Cast<Vector3, object>
	|-GenericsUtil.Cast<Vector3, ulong>
	|
	|-RVA: 0x14AEAC0 Offset: 0x14ADEC0 VA: 0x1814AEAC0
	|-GenericsUtil.Cast<Vector3, float>
	|
	|-RVA: 0x14AE440 Offset: 0x14AD840 VA: 0x1814AE440
	|-GenericsUtil.Cast<Vector3, Color>
	|
	|-RVA: 0x14AE960 Offset: 0x14ADD60 VA: 0x1814AE960
	|-GenericsUtil.Cast<Vector3, Ray>
	|
	|-RVA: 0x14AEC00 Offset: 0x14AE000 VA: 0x1814AEC00
	|-GenericsUtil.Cast<Vector3, Vector3>
	*/

	// RVA: -1 Offset: -1
	public static void Swap<T>(ref T a, ref T b) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x58A750 Offset: 0x589B50 VA: 0x18058A750
	|-GenericsUtil.Swap<List<PlaceMonuments.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsOffshore.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRailside.SpawnInfo>>
	|-GenericsUtil.Swap<List<PlaceMonumentsRoadside.SpawnInfo>>
	|-GenericsUtil.Swap<object>
	|-GenericsUtil.Swap<float[]>
	*/

}

private static class GenericsUtil.CastImpl<TSrc, TDst> // TypeDefIndex: 4818
{	// Fields
	[ThreadStaticAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	public static TSrc Value; // 0xFFFFFFFF

	// Methods

	// RVA: -1 Offset: -1
	private static void .cctor() { }
	/* GenericInstMethod :
	|
	|-RVA: 0x15DE3C0 Offset: 0x15DD7C0 VA: 0x1815DE3C0
	|-GenericsUtil.CastImpl<bool, bool>..cctor
	|
	|-RVA: 0x15D8F60 Offset: 0x15D8360 VA: 0x1815D8F60
	|-GenericsUtil.CastImpl<bool, byte>..cctor
	|
	|-RVA: 0x15DDE20 Offset: 0x15DD220 VA: 0x1815DDE20
	|-GenericsUtil.CastImpl<bool, short>..cctor
	|
	|-RVA: 0x15D7E80 Offset: 0x15D7280 VA: 0x1815D7E80
	|-GenericsUtil.CastImpl<bool, int>..cctor
	|
	|-RVA: 0x15D8420 Offset: 0x15D7820 VA: 0x1815D8420
	|-GenericsUtil.CastImpl<bool, long>..cctor
	|
	|-RVA: 0x15D9410 Offset: 0x15D8810 VA: 0x1815D9410
	|-GenericsUtil.CastImpl<bool, object>..cctor
	|
	|-RVA: 0x15DE960 Offset: 0x15DDD60 VA: 0x1815DE960
	|-GenericsUtil.CastImpl<bool, sbyte>..cctor
	|
	|-RVA: 0x15DF3B0 Offset: 0x15DE7B0 VA: 0x1815DF3B0
	|-GenericsUtil.CastImpl<bool, float>..cctor
	|
	|-RVA: 0x15DB3F0 Offset: 0x15DA7F0 VA: 0x1815DB3F0
	|-GenericsUtil.CastImpl<bool, ushort>..cctor
	|
	|-RVA: 0x15D89C0 Offset: 0x15D7DC0 VA: 0x1815D89C0
	|-GenericsUtil.CastImpl<bool, uint>..cctor
	|
	|-RVA: 0x15DE4B0 Offset: 0x15DD8B0 VA: 0x1815DE4B0
	|-GenericsUtil.CastImpl<bool, ulong>..cctor
	|
	|-RVA: 0x15D98C0 Offset: 0x15D8CC0 VA: 0x1815D98C0
	|-GenericsUtil.CastImpl<bool, Color>..cctor
	|
	|-RVA: 0x15D9F50 Offset: 0x15D9350 VA: 0x1815D9F50
	|-GenericsUtil.CastImpl<bool, Ray>..cctor
	|
	|-RVA: 0x15D8510 Offset: 0x15D7910 VA: 0x1815D8510
	|-GenericsUtil.CastImpl<bool, Vector3>..cctor
	|
	|-RVA: 0x15DA9A0 Offset: 0x15D9DA0 VA: 0x1815DA9A0
	|-GenericsUtil.CastImpl<byte, bool>..cctor
	|
	|-RVA: 0x15D96E0 Offset: 0x15D8AE0 VA: 0x1815D96E0
	|-GenericsUtil.CastImpl<byte, byte>..cctor
	|
	|-RVA: 0x15DF2C0 Offset: 0x15DE6C0 VA: 0x1815DF2C0
	|-GenericsUtil.CastImpl<byte, short>..cctor
	|
	|-RVA: 0x15D9D70 Offset: 0x15D9170 VA: 0x1815D9D70
	|-GenericsUtil.CastImpl<byte, int>..cctor
	|
	|-RVA: 0x15DCA70 Offset: 0x15DBE70 VA: 0x1815DCA70
	|-GenericsUtil.CastImpl<byte, long>..cctor
	|
	|-RVA: 0x15DC5C0 Offset: 0x15DB9C0 VA: 0x1815DC5C0
	|-GenericsUtil.CastImpl<byte, object>..cctor
	|
	|-RVA: 0x15D7D90 Offset: 0x15D7190 VA: 0x1815D7D90
	|-GenericsUtil.CastImpl<byte, sbyte>..cctor
	|
	|-RVA: 0x15D99B0 Offset: 0x15D8DB0 VA: 0x1815D99B0
	|-GenericsUtil.CastImpl<byte, float>..cctor
	|
	|-RVA: 0x15DD4C0 Offset: 0x15DC8C0 VA: 0x1815DD4C0
	|-GenericsUtil.CastImpl<byte, ushort>..cctor
	|
	|-RVA: 0x15D8C90 Offset: 0x15D8090 VA: 0x1815D8C90
	|-GenericsUtil.CastImpl<byte, uint>..cctor
	|
	|-RVA: 0x15D8600 Offset: 0x15D7A00 VA: 0x1815D8600
	|-GenericsUtil.CastImpl<byte, ulong>..cctor
	|
	|-RVA: 0x15DB120 Offset: 0x15DA520 VA: 0x1815DB120
	|-GenericsUtil.CastImpl<byte, Color>..cctor
	|
	|-RVA: 0x15D7F70 Offset: 0x15D7370 VA: 0x1815D7F70
	|-GenericsUtil.CastImpl<byte, Ray>..cctor
	|
	|-RVA: 0x15DB990 Offset: 0x15DAD90 VA: 0x1815DB990
	|-GenericsUtil.CastImpl<byte, Vector3>..cctor
	|
	|-RVA: 0x15DD2E0 Offset: 0x15DC6E0 VA: 0x1815DD2E0
	|-GenericsUtil.CastImpl<double, int>..cctor
	|
	|-RVA: 0x15DE5A0 Offset: 0x15DD9A0 VA: 0x1815DE5A0
	|-GenericsUtil.CastImpl<double, object>..cctor
	|
	|-RVA: 0x15DC020 Offset: 0x15DB420 VA: 0x1815DC020
	|-GenericsUtil.CastImpl<Guid, int>..cctor
	|
	|-RVA: 0x15DA310 Offset: 0x15D9710 VA: 0x1815DA310
	|-GenericsUtil.CastImpl<Guid, long>..cctor
	|
	|-RVA: 0x15D8AB0 Offset: 0x15D7EB0 VA: 0x1815D8AB0
	|-GenericsUtil.CastImpl<Guid, object>..cctor
	|
	|-RVA: 0x15DF0E0 Offset: 0x15DE4E0 VA: 0x1815DF0E0
	|-GenericsUtil.CastImpl<short, bool>..cctor
	|
	|-RVA: 0x15DB4E0 Offset: 0x15DA8E0 VA: 0x1815DB4E0
	|-GenericsUtil.CastImpl<short, byte>..cctor
	|
	|-RVA: 0x15D9B90 Offset: 0x15D8F90 VA: 0x1815D9B90
	|-GenericsUtil.CastImpl<short, int>..cctor
	|
	|-RVA: 0x15DA220 Offset: 0x15D9620 VA: 0x1815DA220
	|-GenericsUtil.CastImpl<short, object>..cctor
	|
	|-RVA: 0x15DD6A0 Offset: 0x15DCAA0 VA: 0x1815DD6A0
	|-GenericsUtil.CastImpl<short, sbyte>..cctor
	|
	|-RVA: 0x15DCD40 Offset: 0x15DC140 VA: 0x1815DCD40
	|-GenericsUtil.CastImpl<short, float>..cctor
	|
	|-RVA: 0x15DCE30 Offset: 0x15DC230 VA: 0x1815DCE30
	|-GenericsUtil.CastImpl<short, uint>..cctor
	|
	|-RVA: 0x15DD1F0 Offset: 0x15DC5F0 VA: 0x1815DD1F0
	|-GenericsUtil.CastImpl<short, ulong>..cctor
	|
	|-RVA: 0x15DA400 Offset: 0x15D9800 VA: 0x1815DA400
	|-GenericsUtil.CastImpl<short, Color>..cctor
	|
	|-RVA: 0x15DD790 Offset: 0x15DCB90 VA: 0x1815DD790
	|-GenericsUtil.CastImpl<short, Ray>..cctor
	|
	|-RVA: 0x15D95F0 Offset: 0x15D89F0 VA: 0x1815D95F0
	|-GenericsUtil.CastImpl<short, Vector3>..cctor
	|
	|-RVA: 0x15DDD30 Offset: 0x15DD130 VA: 0x1815DDD30
	|-GenericsUtil.CastImpl<int, bool>..cctor
	|
	|-RVA: 0x15DE780 Offset: 0x15DDB80 VA: 0x1815DE780
	|-GenericsUtil.CastImpl<int, byte>..cctor
	|
	|-RVA: 0x15DA5E0 Offset: 0x15D99E0 VA: 0x1815DA5E0
	|-GenericsUtil.CastImpl<int, double>..cctor
	|
	|-RVA: 0x15DC980 Offset: 0x15DBD80 VA: 0x1815DC980
	|-GenericsUtil.CastImpl<int, Guid>..cctor
	|
	|-RVA: 0x15DC4D0 Offset: 0x15DB8D0 VA: 0x1815DC4D0
	|-GenericsUtil.CastImpl<int, short>..cctor
	|
	|-RVA: 0x15DAA90 Offset: 0x15D9E90 VA: 0x1815DAA90
	|-GenericsUtil.CastImpl<int, int>..cctor
	|
	|-RVA: 0x15DBF30 Offset: 0x15DB330 VA: 0x1815DBF30
	|-GenericsUtil.CastImpl<int, long>..cctor
	|
	|-RVA: 0x15DBE40 Offset: 0x15DB240 VA: 0x1815DBE40
	|-GenericsUtil.CastImpl<int, object>..cctor
	|
	|-RVA: 0x15DED20 Offset: 0x15DE120 VA: 0x1815DED20
	|-GenericsUtil.CastImpl<int, sbyte>..cctor
	|
	|-RVA: 0x15DEA50 Offset: 0x15DDE50 VA: 0x1815DEA50
	|-GenericsUtil.CastImpl<int, float>..cctor
	|
	|-RVA: 0x15DCF20 Offset: 0x15DC320 VA: 0x1815DCF20
	|-GenericsUtil.CastImpl<int, ushort>..cctor
	|
	|-RVA: 0x15DB210 Offset: 0x15DA610 VA: 0x1815DB210
	|-GenericsUtil.CastImpl<int, uint>..cctor
	|
	|-RVA: 0x15DE2D0 Offset: 0x15DD6D0 VA: 0x1815DE2D0
	|-GenericsUtil.CastImpl<int, ulong>..cctor
	|
	|-RVA: 0x15DAC70 Offset: 0x15DA070 VA: 0x1815DAC70
	|-GenericsUtil.CastImpl<int, Color>..cctor
	|
	|-RVA: 0x15DAF40 Offset: 0x15DA340 VA: 0x1815DAF40
	|-GenericsUtil.CastImpl<int, Ray>..cctor
	|
	|-RVA: 0x15DBB70 Offset: 0x15DAF70 VA: 0x1815DBB70
	|-GenericsUtil.CastImpl<int, Vector3>..cctor
	|
	|-RVA: 0x15DAE50 Offset: 0x15DA250 VA: 0x1815DAE50
	|-GenericsUtil.CastImpl<long, bool>..cctor
	|
	|-RVA: 0x15DC890 Offset: 0x15DBC90 VA: 0x1815DC890
	|-GenericsUtil.CastImpl<long, byte>..cctor
	|
	|-RVA: 0x15DE0F0 Offset: 0x15DD4F0 VA: 0x1815DE0F0
	|-GenericsUtil.CastImpl<long, Guid>..cctor
	|
	|-RVA: 0x15DCB60 Offset: 0x15DBF60 VA: 0x1815DCB60
	|-GenericsUtil.CastImpl<long, int>..cctor
	|
	|-RVA: 0x15DEF00 Offset: 0x15DE300 VA: 0x1815DEF00
	|-GenericsUtil.CastImpl<long, long>..cctor
	|
	|-RVA: 0x15DEC30 Offset: 0x15DE030 VA: 0x1815DEC30
	|-GenericsUtil.CastImpl<long, object>..cctor
	|
	|-RVA: 0x15DB030 Offset: 0x15DA430 VA: 0x1815DB030
	|-GenericsUtil.CastImpl<long, sbyte>..cctor
	|
	|-RVA: 0x15DC2F0 Offset: 0x15DB6F0 VA: 0x1815DC2F0
	|-GenericsUtil.CastImpl<long, float>..cctor
	|
	|-RVA: 0x15DA8B0 Offset: 0x15D9CB0 VA: 0x1815DA8B0
	|-GenericsUtil.CastImpl<long, uint>..cctor
	|
	|-RVA: 0x15DDC40 Offset: 0x15DD040 VA: 0x1815DDC40
	|-GenericsUtil.CastImpl<long, ulong>..cctor
	|
	|-RVA: 0x15DB6C0 Offset: 0x15DAAC0 VA: 0x1815DB6C0
	|-GenericsUtil.CastImpl<long, Color>..cctor
	|
	|-RVA: 0x15DBD50 Offset: 0x15DB150 VA: 0x1815DBD50
	|-GenericsUtil.CastImpl<long, Ray>..cctor
	|
	|-RVA: 0x15D88D0 Offset: 0x15D7CD0 VA: 0x1815D88D0
	|-GenericsUtil.CastImpl<long, Vector3>..cctor
	|
	|-RVA: 0x15DD010 Offset: 0x15DC410 VA: 0x1815DD010
	|-GenericsUtil.CastImpl<object, bool>..cctor
	|
	|-RVA: 0x15D9140 Offset: 0x15D8540 VA: 0x1815D9140
	|-GenericsUtil.CastImpl<object, byte>..cctor
	|
	|-RVA: 0x15DE690 Offset: 0x15DDA90 VA: 0x1815DE690
	|-GenericsUtil.CastImpl<object, double>..cctor
	|
	|-RVA: 0x15DA6D0 Offset: 0x15D9AD0 VA: 0x1815DA6D0
	|-GenericsUtil.CastImpl<object, Guid>..cctor
	|
	|-RVA: 0x15DE1E0 Offset: 0x15DD5E0 VA: 0x1815DE1E0
	|-GenericsUtil.CastImpl<object, short>..cctor
	|
	|-RVA: 0x15DB8A0 Offset: 0x15DACA0 VA: 0x1815DB8A0
	|-GenericsUtil.CastImpl<object, int>..cctor
	|
	|-RVA: 0x15D8E70 Offset: 0x15D8270 VA: 0x1815D8E70
	|-GenericsUtil.CastImpl<object, long>..cctor
	|
	|-RVA: 0x15DD3D0 Offset: 0x15DC7D0 VA: 0x1815DD3D0
	|-GenericsUtil.CastImpl<object, object>..cctor
	|
	|-RVA: 0x15DB7B0 Offset: 0x15DABB0 VA: 0x1815DB7B0
	|-GenericsUtil.CastImpl<object, sbyte>..cctor
	|
	|-RVA: 0x15D8BA0 Offset: 0x15D7FA0 VA: 0x1815D8BA0
	|-GenericsUtil.CastImpl<object, float>..cctor
	|
	|-RVA: 0x15DDB50 Offset: 0x15DCF50 VA: 0x1815DDB50
	|-GenericsUtil.CastImpl<object, ushort>..cctor
	|
	|-RVA: 0x15DF1D0 Offset: 0x15DE5D0 VA: 0x1815DF1D0
	|-GenericsUtil.CastImpl<object, uint>..cctor
	|
	|-RVA: 0x15D9AA0 Offset: 0x15D8EA0 VA: 0x1815D9AA0
	|-GenericsUtil.CastImpl<object, ulong>..cctor
	|
	|-RVA: 0x15D8150 Offset: 0x15D7550 VA: 0x1815D8150
	|-GenericsUtil.CastImpl<object, Color>..cctor
	|
	|-RVA: 0x15DC3E0 Offset: 0x15DB7E0 VA: 0x1815DC3E0
	|-GenericsUtil.CastImpl<object, Ray>..cctor
	|
	|-RVA: 0x15DA040 Offset: 0x15D9440 VA: 0x1815DA040
	|-GenericsUtil.CastImpl<object, Vector3>..cctor
	|
	|-RVA: 0x15DEB40 Offset: 0x15DDF40 VA: 0x1815DEB40
	|-GenericsUtil.CastImpl<sbyte, bool>..cctor
	|
	|-RVA: 0x15DC200 Offset: 0x15DB600 VA: 0x1815DC200
	|-GenericsUtil.CastImpl<sbyte, byte>..cctor
	|
	|-RVA: 0x15D9050 Offset: 0x15D8450 VA: 0x1815D9050
	|-GenericsUtil.CastImpl<sbyte, short>..cctor
	|
	|-RVA: 0x15D87E0 Offset: 0x15D7BE0 VA: 0x1815D87E0
	|-GenericsUtil.CastImpl<sbyte, int>..cctor
	|
	|-RVA: 0x15D86F0 Offset: 0x15D7AF0 VA: 0x1815D86F0
	|-GenericsUtil.CastImpl<sbyte, long>..cctor
	|
	|-RVA: 0x15DE870 Offset: 0x15DDC70 VA: 0x1815DE870
	|-GenericsUtil.CastImpl<sbyte, object>..cctor
	|
	|-RVA: 0x15DB5D0 Offset: 0x15DA9D0 VA: 0x1815DB5D0
	|-GenericsUtil.CastImpl<sbyte, sbyte>..cctor
	|
	|-RVA: 0x15DBA80 Offset: 0x15DAE80 VA: 0x1815DBA80
	|-GenericsUtil.CastImpl<sbyte, float>..cctor
	|
	|-RVA: 0x15D9500 Offset: 0x15D8900 VA: 0x1815D9500
	|-GenericsUtil.CastImpl<sbyte, ushort>..cctor
	|
	|-RVA: 0x15D9E60 Offset: 0x15D9260 VA: 0x1815D9E60
	|-GenericsUtil.CastImpl<sbyte, uint>..cctor
	|
	|-RVA: 0x15DEFF0 Offset: 0x15DE3F0 VA: 0x1815DEFF0
	|-GenericsUtil.CastImpl<sbyte, ulong>..cctor
	|
	|-RVA: 0x15DC110 Offset: 0x15DB510 VA: 0x1815DC110
	|-GenericsUtil.CastImpl<sbyte, Color>..cctor
	|
	|-RVA: 0x15DF4A0 Offset: 0x15DE8A0 VA: 0x1815DF4A0
	|-GenericsUtil.CastImpl<sbyte, Ray>..cctor
	|
	|-RVA: 0x15D9C80 Offset: 0x15D9080 VA: 0x1815D9C80
	|-GenericsUtil.CastImpl<sbyte, Vector3>..cctor
	|
	|-RVA: 0x15D97D0 Offset: 0x15D8BD0 VA: 0x1815D97D0
	|-GenericsUtil.CastImpl<float, bool>..cctor
	|
	|-RVA: 0x15D8060 Offset: 0x15D7460 VA: 0x1815D8060
	|-GenericsUtil.CastImpl<float, byte>..cctor
	|
	|-RVA: 0x15DAB80 Offset: 0x15D9F80 VA: 0x1815DAB80
	|-GenericsUtil.CastImpl<float, short>..cctor
	|
	|-RVA: 0x15DDF10 Offset: 0x15DD310 VA: 0x1815DDF10
	|-GenericsUtil.CastImpl<float, int>..cctor
	|
	|-RVA: 0x15DDA60 Offset: 0x15DCE60 VA: 0x1815DDA60
	|-GenericsUtil.CastImpl<float, long>..cctor
	|
	|-RVA: 0x15D9320 Offset: 0x15D8720 VA: 0x1815D9320
	|-GenericsUtil.CastImpl<float, object>..cctor
	|
	|-RVA: 0x15D8240 Offset: 0x15D7640 VA: 0x1815D8240
	|-GenericsUtil.CastImpl<float, sbyte>..cctor
	|
	|-RVA: 0x15DB300 Offset: 0x15DA700 VA: 0x1815DB300
	|-GenericsUtil.CastImpl<float, float>..cctor
	|
	|-RVA: 0x15D9230 Offset: 0x15D8630 VA: 0x1815D9230
	|-GenericsUtil.CastImpl<float, ushort>..cctor
	|
	|-RVA: 0x15DBC60 Offset: 0x15DB060 VA: 0x1815DBC60
	|-GenericsUtil.CastImpl<float, uint>..cctor
	|
	|-RVA: 0x15DA130 Offset: 0x15D9530 VA: 0x1815DA130
	|-GenericsUtil.CastImpl<float, ulong>..cctor
	|
	|-RVA: 0x15DD100 Offset: 0x15DC500 VA: 0x1815DD100
	|-GenericsUtil.CastImpl<float, Color>..cctor
	|
	|-RVA: 0x15D8D80 Offset: 0x15D8180 VA: 0x1815D8D80
	|-GenericsUtil.CastImpl<float, Ray>..cctor
	|
	|-RVA: 0x15DD880 Offset: 0x15DCC80 VA: 0x1815DD880
	|-GenericsUtil.CastImpl<float, Vector3>..cctor
	|
	|-RVA: 0x15DD5B0 Offset: 0x15DC9B0 VA: 0x1815DD5B0
	|-GenericsUtil.CastImpl<ushort, bool>..cctor
	|
	|-RVA: 0x15DAD60 Offset: 0x15DA160 VA: 0x1815DAD60
	|-GenericsUtil.CastImpl<ushort, byte>..cctor
	|
	|-RVA: 0x15DC6B0 Offset: 0x15DBAB0 VA: 0x1815DC6B0
	|-GenericsUtil.CastImpl<ushort, int>..cctor
	|
	|-RVA: 0x15DE000 Offset: 0x15DD400 VA: 0x1815DE000
	|-GenericsUtil.CastImpl<ushort, object>..cctor
	|
	|-RVA: 0x15DCC50 Offset: 0x15DC050 VA: 0x1815DCC50
	|-GenericsUtil.CastImpl<ushort, sbyte>..cctor
	|
	|-RVA: 0x15DD970 Offset: 0x15DCD70 VA: 0x1815DD970
	|-GenericsUtil.CastImpl<ushort, float>..cctor
	|
	|-RVA: 0x15D8330 Offset: 0x15D7730 VA: 0x1815D8330
	|-GenericsUtil.CastImpl<ushort, uint>..cctor
	|
	|-RVA: 0x15DA7C0 Offset: 0x15D9BC0 VA: 0x1815DA7C0
	|-GenericsUtil.CastImpl<ushort, ulong>..cctor
	|
	|-RVA: 0x15DA4F0 Offset: 0x15D98F0 VA: 0x1815DA4F0
	|-GenericsUtil.CastImpl<ushort, Color>..cctor
	|
	|-RVA: 0x15DEE10 Offset: 0x15DE210 VA: 0x1815DEE10
	|-GenericsUtil.CastImpl<ushort, Ray>..cctor
	|
	|-RVA: 0x15DC7A0 Offset: 0x15DBBA0 VA: 0x1815DC7A0
	|-GenericsUtil.CastImpl<ushort, Vector3>..cctor
	|
	|-RVA: 0x15D7CA0 Offset: 0x15D70A0 VA: 0x1815D7CA0
	|-GenericsUtil.CastImpl<uint, bool>..cctor
	|
	|-RVA: 0x17E98A0 Offset: 0x17E8CA0 VA: 0x1817E98A0
	|-GenericsUtil.CastImpl<uint, byte>..cctor
	|
	|-RVA: 0x17E97B0 Offset: 0x17E8BB0 VA: 0x1817E97B0
	|-GenericsUtil.CastImpl<uint, short>..cctor
	|
	|-RVA: 0x17EB5B0 Offset: 0x17EA9B0 VA: 0x1817EB5B0
	|-GenericsUtil.CastImpl<uint, int>..cctor
	|
	|-RVA: 0x17E9B70 Offset: 0x17E8F70 VA: 0x1817E9B70
	|-GenericsUtil.CastImpl<uint, long>..cctor
	|
	|-RVA: 0x17E8E50 Offset: 0x17E8250 VA: 0x1817E8E50
	|-GenericsUtil.CastImpl<uint, object>..cctor
	|
	|-RVA: 0x17EA2F0 Offset: 0x17E96F0 VA: 0x1817EA2F0
	|-GenericsUtil.CastImpl<uint, sbyte>..cctor
	|
	|-RVA: 0x17EA110 Offset: 0x17E9510 VA: 0x1817EA110
	|-GenericsUtil.CastImpl<uint, float>..cctor
	|
	|-RVA: 0x17EAB60 Offset: 0x17E9F60 VA: 0x1817EAB60
	|-GenericsUtil.CastImpl<uint, ushort>..cctor
	|
	|-RVA: 0x17EB790 Offset: 0x17EAB90 VA: 0x1817EB790
	|-GenericsUtil.CastImpl<uint, uint>..cctor
	|
	|-RVA: 0x17EAD40 Offset: 0x17EA140 VA: 0x1817EAD40
	|-GenericsUtil.CastImpl<uint, ulong>..cctor
	|
	|-RVA: 0x17E95D0 Offset: 0x17E89D0 VA: 0x1817E95D0
	|-GenericsUtil.CastImpl<uint, Color>..cctor
	|
	|-RVA: 0x17EB1F0 Offset: 0x17EA5F0 VA: 0x1817EB1F0
	|-GenericsUtil.CastImpl<uint, Ray>..cctor
	|
	|-RVA: 0x17EA7A0 Offset: 0x17E9BA0 VA: 0x1817EA7A0
	|-GenericsUtil.CastImpl<uint, Vector3>..cctor
	|
	|-RVA: 0x17EBA60 Offset: 0x17EAE60 VA: 0x1817EBA60
	|-GenericsUtil.CastImpl<ulong, bool>..cctor
	|
	|-RVA: 0x17E9990 Offset: 0x17E8D90 VA: 0x1817E9990
	|-GenericsUtil.CastImpl<ulong, byte>..cctor
	|
	|-RVA: 0x17E9D50 Offset: 0x17E9150 VA: 0x1817E9D50
	|-GenericsUtil.CastImpl<ulong, short>..cctor
	|
	|-RVA: 0x17EB970 Offset: 0x17EAD70 VA: 0x1817EB970
	|-GenericsUtil.CastImpl<ulong, int>..cctor
	|
	|-RVA: 0x17EAE30 Offset: 0x17EA230 VA: 0x1817EAE30
	|-GenericsUtil.CastImpl<ulong, long>..cctor
	|
	|-RVA: 0x17E8F40 Offset: 0x17E8340 VA: 0x1817E8F40
	|-GenericsUtil.CastImpl<ulong, object>..cctor
	|
	|-RVA: 0x17E9300 Offset: 0x17E8700 VA: 0x1817E9300
	|-GenericsUtil.CastImpl<ulong, sbyte>..cctor
	|
	|-RVA: 0x17EB010 Offset: 0x17EA410 VA: 0x1817EB010
	|-GenericsUtil.CastImpl<ulong, float>..cctor
	|
	|-RVA: 0x17E9A80 Offset: 0x17E8E80 VA: 0x1817E9A80
	|-GenericsUtil.CastImpl<ulong, ushort>..cctor
	|
	|-RVA: 0x17EC000 Offset: 0x17EB400 VA: 0x1817EC000
	|-GenericsUtil.CastImpl<ulong, uint>..cctor
	|
	|-RVA: 0x17EA6B0 Offset: 0x17E9AB0 VA: 0x1817EA6B0
	|-GenericsUtil.CastImpl<ulong, ulong>..cctor
	|
	|-RVA: 0x17EC1E0 Offset: 0x17EB5E0 VA: 0x1817EC1E0
	|-GenericsUtil.CastImpl<ulong, Color>..cctor
	|
	|-RVA: 0x17EA4D0 Offset: 0x17E98D0 VA: 0x1817EA4D0
	|-GenericsUtil.CastImpl<ulong, Ray>..cctor
	|
	|-RVA: 0x17E9F30 Offset: 0x17E9330 VA: 0x1817E9F30
	|-GenericsUtil.CastImpl<ulong, Vector3>..cctor
	|
	|-RVA: 0x17EA980 Offset: 0x17E9D80 VA: 0x1817EA980
	|-GenericsUtil.CastImpl<Color, bool>..cctor
	|
	|-RVA: 0x17EBD30 Offset: 0x17EB130 VA: 0x1817EBD30
	|-GenericsUtil.CastImpl<Color, byte>..cctor
	|
	|-RVA: 0x17EB100 Offset: 0x17EA500 VA: 0x1817EB100
	|-GenericsUtil.CastImpl<Color, short>..cctor
	|
	|-RVA: 0x17E94E0 Offset: 0x17E88E0 VA: 0x1817E94E0
	|-GenericsUtil.CastImpl<Color, int>..cctor
	|
	|-RVA: 0x17EC4B0 Offset: 0x17EB8B0 VA: 0x1817EC4B0
	|-GenericsUtil.CastImpl<Color, long>..cctor
	|
	|-RVA: 0x17E86D0 Offset: 0x17E7AD0 VA: 0x1817E86D0
	|-GenericsUtil.CastImpl<Color, object>..cctor
	|
	|-RVA: 0x17EB3D0 Offset: 0x17EA7D0 VA: 0x1817EB3D0
	|-GenericsUtil.CastImpl<Color, sbyte>..cctor
	|
	|-RVA: 0x17EC3C0 Offset: 0x17EB7C0 VA: 0x1817EC3C0
	|-GenericsUtil.CastImpl<Color, float>..cctor
	|
	|-RVA: 0x17EBE20 Offset: 0x17EB220 VA: 0x1817EBE20
	|-GenericsUtil.CastImpl<Color, ushort>..cctor
	|
	|-RVA: 0x17E9210 Offset: 0x17E8610 VA: 0x1817E9210
	|-GenericsUtil.CastImpl<Color, uint>..cctor
	|
	|-RVA: 0x17EB6A0 Offset: 0x17EAAA0 VA: 0x1817EB6A0
	|-GenericsUtil.CastImpl<Color, ulong>..cctor
	|
	|-RVA: 0x17EC0F0 Offset: 0x17EB4F0 VA: 0x1817EC0F0
	|-GenericsUtil.CastImpl<Color, Color>..cctor
	|
	|-RVA: 0x17EAA70 Offset: 0x17E9E70 VA: 0x1817EAA70
	|-GenericsUtil.CastImpl<Color, Ray>..cctor
	|
	|-RVA: 0x17EA200 Offset: 0x17E9600 VA: 0x1817EA200
	|-GenericsUtil.CastImpl<Color, Vector3>..cctor
	|
	|-RVA: 0x17EB2E0 Offset: 0x17EA6E0 VA: 0x1817EB2E0
	|-GenericsUtil.CastImpl<Ray, bool>..cctor
	|
	|-RVA: 0x17E8D60 Offset: 0x17E8160 VA: 0x1817E8D60
	|-GenericsUtil.CastImpl<Ray, byte>..cctor
	|
	|-RVA: 0x17E8A90 Offset: 0x17E7E90 VA: 0x1817E8A90
	|-GenericsUtil.CastImpl<Ray, short>..cctor
	|
	|-RVA: 0x17E88B0 Offset: 0x17E7CB0 VA: 0x1817E88B0
	|-GenericsUtil.CastImpl<Ray, int>..cctor
	|
	|-RVA: 0x17EB4C0 Offset: 0x17EA8C0 VA: 0x1817EB4C0
	|-GenericsUtil.CastImpl<Ray, long>..cctor
	|
	|-RVA: 0x17EB880 Offset: 0x17EAC80 VA: 0x1817EB880
	|-GenericsUtil.CastImpl<Ray, object>..cctor
	|
	|-RVA: 0x17EBB50 Offset: 0x17EAF50 VA: 0x1817EBB50
	|-GenericsUtil.CastImpl<Ray, sbyte>..cctor
	|
	|-RVA: 0x17EA3E0 Offset: 0x17E97E0 VA: 0x1817EA3E0
	|-GenericsUtil.CastImpl<Ray, float>..cctor
	|
	|-RVA: 0x17EBC40 Offset: 0x17EB040 VA: 0x1817EBC40
	|-GenericsUtil.CastImpl<Ray, ushort>..cctor
	|
	|-RVA: 0x17E9030 Offset: 0x17E8430 VA: 0x1817E9030
	|-GenericsUtil.CastImpl<Ray, uint>..cctor
	|
	|-RVA: 0x17E9E40 Offset: 0x17E9240 VA: 0x1817E9E40
	|-GenericsUtil.CastImpl<Ray, ulong>..cctor
	|
	|-RVA: 0x17E8C70 Offset: 0x17E8070 VA: 0x1817E8C70
	|-GenericsUtil.CastImpl<Ray, Color>..cctor
	|
	|-RVA: 0x17E9C60 Offset: 0x17E9060 VA: 0x1817E9C60
	|-GenericsUtil.CastImpl<Ray, Ray>..cctor
	|
	|-RVA: 0x17EA020 Offset: 0x17E9420 VA: 0x1817EA020
	|-GenericsUtil.CastImpl<Ray, Vector3>..cctor
	|
	|-RVA: 0x17E8B80 Offset: 0x17E7F80 VA: 0x1817E8B80
	|-GenericsUtil.CastImpl<Vector3, bool>..cctor
	|
	|-RVA: 0x17EAC50 Offset: 0x17EA050 VA: 0x1817EAC50
	|-GenericsUtil.CastImpl<Vector3, byte>..cctor
	|
	|-RVA: 0x17EA890 Offset: 0x17E9C90 VA: 0x1817EA890
	|-GenericsUtil.CastImpl<Vector3, short>..cctor
	|
	|-RVA: 0x17EA5C0 Offset: 0x17E99C0 VA: 0x1817EA5C0
	|-GenericsUtil.CastImpl<Vector3, int>..cctor
	|
	|-RVA: 0x17E96C0 Offset: 0x17E8AC0 VA: 0x1817E96C0
	|-GenericsUtil.CastImpl<Vector3, long>..cctor
	|
	|-RVA: 0x17E84F0 Offset: 0x17E78F0 VA: 0x1817E84F0
	|-GenericsUtil.CastImpl<Vector3, object>..cctor
	|
	|-RVA: 0x17E85E0 Offset: 0x17E79E0 VA: 0x1817E85E0
	|-GenericsUtil.CastImpl<Vector3, sbyte>..cctor
	|
	|-RVA: 0x17EAF20 Offset: 0x17EA320 VA: 0x1817EAF20
	|-GenericsUtil.CastImpl<Vector3, float>..cctor
	|
	|-RVA: 0x17E87C0 Offset: 0x17E7BC0 VA: 0x1817E87C0
	|-GenericsUtil.CastImpl<Vector3, ushort>..cctor
	|
	|-RVA: 0x17E9120 Offset: 0x17E8520 VA: 0x1817E9120
	|-GenericsUtil.CastImpl<Vector3, uint>..cctor
	|
	|-RVA: 0x17EC2D0 Offset: 0x17EB6D0 VA: 0x1817EC2D0
	|-GenericsUtil.CastImpl<Vector3, ulong>..cctor
	|
	|-RVA: 0x17EBF10 Offset: 0x17EB310 VA: 0x1817EBF10
	|-GenericsUtil.CastImpl<Vector3, Color>..cctor
	|
	|-RVA: 0x17E89A0 Offset: 0x17E7DA0 VA: 0x1817E89A0
	|-GenericsUtil.CastImpl<Vector3, Ray>..cctor
	|
	|-RVA: 0x17E93F0 Offset: 0x17E87F0 VA: 0x1817E93F0
	|-GenericsUtil.CastImpl<Vector3, Vector3>..cctor
	*/

}

