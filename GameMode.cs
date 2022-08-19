public class GameMode : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6399
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public List<GameMode.TeamInfo> teams; // 0x18
	public List<GameMode.ScoreColumn> scoreColumns; // 0x20
	public List<GameMode.PlayerScore> playerScores; // 0x28

	// Methods

	// RVA: 0x1D57EF0 Offset: 0x1D572F0 VA: 0x181D57EF0
	public static void ResetToPool(GameMode instance) { }

	// RVA: 0x1D57AD0 Offset: 0x1D56ED0 VA: 0x181D57AD0
	public void ResetToPool() { }

	// RVA: 0x1D57A10 Offset: 0x1D56E10 VA: 0x181D57A10 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D56480 Offset: 0x1D55880 VA: 0x181D56480
	public void CopyTo(GameMode instance) { }

	// RVA: 0x1D56980 Offset: 0x1D55D80 VA: 0x181D56980
	public GameMode Copy() { }

	// RVA: 0x1D574F0 Offset: 0x1D568F0 VA: 0x181D574F0
	public static GameMode Deserialize(Stream stream) { }

	// RVA: 0x1D56E70 Offset: 0x1D56270 VA: 0x181D56E70
	public static GameMode DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D56EF0 Offset: 0x1D562F0 VA: 0x181D56EF0
	public static GameMode DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D573D0 Offset: 0x1D567D0 VA: 0x181D573D0
	public static GameMode Deserialize(byte[] buffer) { }

	// RVA: 0x1D57A90 Offset: 0x1D56E90 VA: 0x181D57A90
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D58EA0 Offset: 0x1D582A0 VA: 0x181D58EA0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D58EC0 Offset: 0x1D582C0 VA: 0x181D58EC0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode previous) { }

	// RVA: 0x1D57AB0 Offset: 0x1D56EB0 VA: 0x181D57AB0 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D57570 Offset: 0x1D56970 VA: 0x181D57570
	public static GameMode Deserialize(byte[] buffer, GameMode instance, bool isDelta = False) { }

	// RVA: 0x1D57670 Offset: 0x1D56A70 VA: 0x181D57670
	public static GameMode Deserialize(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D56A00 Offset: 0x1D55E00 VA: 0x181D56A00
	public static GameMode DeserializeLengthDelimited(Stream stream, GameMode instance, bool isDelta) { }

	// RVA: 0x1D56F80 Offset: 0x1D56380 VA: 0x181D56F80
	public static GameMode DeserializeLength(Stream stream, int length, GameMode instance, bool isDelta) { }

	// RVA: 0x1D58310 Offset: 0x1D57710 VA: 0x181D58310
	public static void SerializeDelta(Stream stream, GameMode instance, GameMode previous) { }

	// RVA: 0x1D58990 Offset: 0x1D57D90 VA: 0x181D58990
	public static void Serialize(Stream stream, GameMode instance) { }

	// RVA: 0x1D58E90 Offset: 0x1D58290 VA: 0x181D58E90
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D58EA0 Offset: 0x1D582A0 VA: 0x181D58EA0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D58880 Offset: 0x1D57C80 VA: 0x181D58880
	public static byte[] SerializeToBytes(GameMode instance) { }

	// RVA: 0x1D587D0 Offset: 0x1D57BD0 VA: 0x181D587D0
	public static void SerializeLengthDelimited(Stream stream, GameMode instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class GameMode.TeamInfo : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6400
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public int score; // 0x14

	// Methods

	// RVA: 0x1D65BE0 Offset: 0x1D64FE0 VA: 0x181D65BE0
	public static void ResetToPool(GameMode.TeamInfo instance) { }

	// RVA: 0x1D65B60 Offset: 0x1D64F60 VA: 0x181D65B60
	public void ResetToPool() { }

	// RVA: 0x1D65AA0 Offset: 0x1D64EA0 VA: 0x181D65AA0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1BF9250 Offset: 0x1BF8650 VA: 0x181BF9250
	public void CopyTo(GameMode.TeamInfo instance) { }

	// RVA: 0x1D65120 Offset: 0x1D64520 VA: 0x181D65120
	public GameMode.TeamInfo Copy() { }

	// RVA: 0x1D65900 Offset: 0x1D64D00 VA: 0x181D65900
	public static GameMode.TeamInfo Deserialize(Stream stream) { }

	// RVA: 0x1D65190 Offset: 0x1D64590 VA: 0x181D65190
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D65630 Offset: 0x1D64A30 VA: 0x181D65630
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D65980 Offset: 0x1D64D80 VA: 0x181D65980
	public static GameMode.TeamInfo Deserialize(byte[] buffer) { }

	// RVA: 0x1D65B20 Offset: 0x1D64F20 VA: 0x181D65B20
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D660B0 Offset: 0x1D654B0 VA: 0x181D660B0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D66180 Offset: 0x1D65580 VA: 0x181D66180 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.TeamInfo previous) { }

	// RVA: 0x1D65B40 Offset: 0x1D64F40 VA: 0x181D65B40 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D65800 Offset: 0x1D64C00 VA: 0x181D65800
	public static GameMode.TeamInfo Deserialize(byte[] buffer, GameMode.TeamInfo instance, bool isDelta = False) { }

	// RVA: 0x1D656C0 Offset: 0x1D64AC0 VA: 0x181D656C0
	public static GameMode.TeamInfo Deserialize(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D65210 Offset: 0x1D64610 VA: 0x181D65210
	public static GameMode.TeamInfo DeserializeLengthDelimited(Stream stream, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D65430 Offset: 0x1D64830 VA: 0x181D65430
	public static GameMode.TeamInfo DeserializeLength(Stream stream, int length, GameMode.TeamInfo instance, bool isDelta) { }

	// RVA: 0x1D65C60 Offset: 0x1D65060 VA: 0x181D65C60
	public static void SerializeDelta(Stream stream, GameMode.TeamInfo instance, GameMode.TeamInfo previous) { }

	// RVA: 0x1D65FD0 Offset: 0x1D653D0 VA: 0x181D65FD0
	public static void Serialize(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x1D660A0 Offset: 0x1D654A0 VA: 0x181D660A0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D660B0 Offset: 0x1D654B0 VA: 0x181D660B0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D65E20 Offset: 0x1D65220 VA: 0x181D65E20
	public static byte[] SerializeToBytes(GameMode.TeamInfo instance) { }

	// RVA: 0x1D65D70 Offset: 0x1D65170 VA: 0x181D65D70
	public static void SerializeLengthDelimited(Stream stream, GameMode.TeamInfo instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class GameMode.ScoreColumn : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6401
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string name; // 0x18

	// Methods

	// RVA: 0x1D63430 Offset: 0x1D62830 VA: 0x181D63430
	public static void ResetToPool(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D633A0 Offset: 0x1D627A0 VA: 0x181D633A0
	public void ResetToPool() { }

	// RVA: 0x1D632E0 Offset: 0x1D626E0 VA: 0x181D632E0 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D62910 Offset: 0x1D61D10 VA: 0x181D62910
	public void CopyTo(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D62940 Offset: 0x1D61D40 VA: 0x181D62940
	public GameMode.ScoreColumn Copy() { }

	// RVA: 0x1D62FF0 Offset: 0x1D623F0 VA: 0x181D62FF0
	public static GameMode.ScoreColumn Deserialize(Stream stream) { }

	// RVA: 0x1D629C0 Offset: 0x1D61DC0 VA: 0x181D629C0
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D62E60 Offset: 0x1D62260 VA: 0x181D62E60
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D631C0 Offset: 0x1D625C0 VA: 0x181D631C0
	public static GameMode.ScoreColumn Deserialize(byte[] buffer) { }

	// RVA: 0x1D63360 Offset: 0x1D62760 VA: 0x181D63360
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D63920 Offset: 0x1D62D20 VA: 0x181D63920 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D63940 Offset: 0x1D62D40 VA: 0x181D63940 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D63380 Offset: 0x1D62780 VA: 0x181D63380 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D62EF0 Offset: 0x1D622F0 VA: 0x181D62EF0
	public static GameMode.ScoreColumn Deserialize(byte[] buffer, GameMode.ScoreColumn instance, bool isDelta = False) { }

	// RVA: 0x1D63070 Offset: 0x1D62470 VA: 0x181D63070
	public static GameMode.ScoreColumn Deserialize(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D62A40 Offset: 0x1D61E40 VA: 0x181D62A40
	public static GameMode.ScoreColumn DeserializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D62C60 Offset: 0x1D62060 VA: 0x181D62C60
	public static GameMode.ScoreColumn DeserializeLength(Stream stream, int length, GameMode.ScoreColumn instance, bool isDelta) { }

	// RVA: 0x1D634C0 Offset: 0x1D628C0 VA: 0x181D634C0
	public static void SerializeDelta(Stream stream, GameMode.ScoreColumn instance, GameMode.ScoreColumn previous) { }

	// RVA: 0x1D637E0 Offset: 0x1D62BE0 VA: 0x181D637E0
	public static void Serialize(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x1D63910 Offset: 0x1D62D10 VA: 0x181D63910
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D63920 Offset: 0x1D62D20 VA: 0x181D63920
	public void ToProto(Stream stream) { }

	// RVA: 0x1D636D0 Offset: 0x1D62AD0 VA: 0x181D636D0
	public static byte[] SerializeToBytes(GameMode.ScoreColumn instance) { }

	// RVA: 0x1D63620 Offset: 0x1D62A20 VA: 0x181D63620
	public static void SerializeLengthDelimited(Stream stream, GameMode.ScoreColumn instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class GameMode.PlayerScore : IDisposable, Pool.IPooled, IProto // TypeDefIndex: 6402
{	// Fields
	public bool ShouldPool; // 0x10
	private bool _disposed; // 0x11
	public string playerName; // 0x18
	public ulong userid; // 0x20
	public List<int> scores; // 0x28
	public int team; // 0x30

	// Methods

	// RVA: 0x1D620D0 Offset: 0x1D614D0 VA: 0x181D620D0
	public static void ResetToPool(GameMode.PlayerScore instance) { }

	// RVA: 0x1D61FA0 Offset: 0x1D613A0 VA: 0x181D61FA0
	public void ResetToPool() { }

	// RVA: 0x1D61C70 Offset: 0x1D61070 VA: 0x181D61C70 Slot: 9
	public virtual void Dispose() { }

	// RVA: 0x10A09B0 Offset: 0x109FDB0 VA: 0x1810A09B0 Slot: 10
	public virtual void EnterPool() { }

	// RVA: 0x10A09E0 Offset: 0x109FDE0 VA: 0x1810A09E0 Slot: 11
	public virtual void LeavePool() { }

	// RVA: 0x1D60610 Offset: 0x1D5FA10 VA: 0x181D60610
	public void CopyTo(GameMode.PlayerScore instance) { }

	// RVA: 0x1D60740 Offset: 0x1D5FB40 VA: 0x181D60740
	public GameMode.PlayerScore Copy() { }

	// RVA: 0x1D61070 Offset: 0x1D60470 VA: 0x181D61070
	public static GameMode.PlayerScore Deserialize(Stream stream) { }

	// RVA: 0x1D60C20 Offset: 0x1D60020 VA: 0x181D60C20
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream) { }

	// RVA: 0x1D60CA0 Offset: 0x1D600A0 VA: 0x181D60CA0
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length) { }

	// RVA: 0x1D61320 Offset: 0x1D60720 VA: 0x181D61320
	public static GameMode.PlayerScore Deserialize(byte[] buffer) { }

	// RVA: 0x1D61CF0 Offset: 0x1D610F0 VA: 0x181D61CF0
	public void FromProto(Stream stream, bool isDelta = False) { }

	// RVA: 0x1D628D0 Offset: 0x1D61CD0 VA: 0x181D628D0 Slot: 12
	public virtual void WriteToStream(Stream stream) { }

	// RVA: 0x1D628F0 Offset: 0x1D61CF0 VA: 0x181D628F0 Slot: 13
	public virtual void WriteToStreamDelta(Stream stream, GameMode.PlayerScore previous) { }

	// RVA: 0x1D61F80 Offset: 0x1D61380 VA: 0x181D61F80 Slot: 14
	public virtual void ReadFromStream(Stream stream, int size, bool isDelta = False) { }

	// RVA: 0x1D61900 Offset: 0x1D60D00 VA: 0x181D61900
	public static GameMode.PlayerScore Deserialize(byte[] buffer, GameMode.PlayerScore instance, bool isDelta = False) { }

	// RVA: 0x1D61670 Offset: 0x1D60A70 VA: 0x181D61670
	public static GameMode.PlayerScore Deserialize(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D608C0 Offset: 0x1D5FCC0 VA: 0x181D608C0
	public static GameMode.PlayerScore DeserializeLengthDelimited(Stream stream, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D60D30 Offset: 0x1D60130 VA: 0x181D60D30
	public static GameMode.PlayerScore DeserializeLength(Stream stream, int length, GameMode.PlayerScore instance, bool isDelta) { }

	// RVA: 0x1D62200 Offset: 0x1D61600 VA: 0x181D62200
	public static void SerializeDelta(Stream stream, GameMode.PlayerScore instance, GameMode.PlayerScore previous) { }

	// RVA: 0x1D62680 Offset: 0x1D61A80 VA: 0x181D62680
	public static void Serialize(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x1D628C0 Offset: 0x1D61CC0 VA: 0x181D628C0
	public byte[] ToProtoBytes() { }

	// RVA: 0x1D628D0 Offset: 0x1D61CD0 VA: 0x181D628D0
	public void ToProto(Stream stream) { }

	// RVA: 0x1D62570 Offset: 0x1D61970 VA: 0x181D62570
	public static byte[] SerializeToBytes(GameMode.PlayerScore instance) { }

	// RVA: 0x1D624C0 Offset: 0x1D618C0 VA: 0x181D624C0
	public static void SerializeLengthDelimited(Stream stream, GameMode.PlayerScore instance) { }

	// RVA: 0x101B930 Offset: 0x101AD30 VA: 0x18101B930
	public void .ctor() { }

}

public class gamemode : ConsoleSystem // TypeDefIndex: 11920
{	// Methods

	// RVA: 0x370F80 Offset: 0x370380 VA: 0x180370F80
	public void .ctor() { }

}

