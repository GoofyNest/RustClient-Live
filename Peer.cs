internal class Peer // TypeDefIndex: 7334
{	// Fields
	private IntPtr ptr; // 0x10
	private static byte[] ByteBuffer; // 0x0

	// Properties
	public virtual ulong incomingGUID { get; }
	public virtual uint incomingAddressInt { get; }
	public virtual uint incomingPort { get; }
	public string incomingAddress { get; }
	public virtual int incomingBits { get; }
	public virtual int incomingBitsUnread { get; }
	public virtual int incomingBytes { get; }
	public virtual int incomingBytesUnread { get; }

	// Methods

	// RVA: 0x22C8C10 Offset: 0x22C8010 VA: 0x1822C8C10
	public static Peer CreateServer(string ip, int port, int maxConnections) { }

	// RVA: 0x22C8740 Offset: 0x22C7B40 VA: 0x1822C8740
	public static Peer CreateConnection(string hostname, int port, int retries, int retryDelay, int timeout) { }

	// RVA: 0x22C8680 Offset: 0x22C7A80 VA: 0x1822C8680
	public void Close() { }

	// RVA: 0x22C99E0 Offset: 0x22C8DE0 VA: 0x1822C99E0
	public uint PendingReceiveCount() { }

	// RVA: 0x22C9E20 Offset: 0x22C9220 VA: 0x1822C9E20
	public bool Receive() { }

	// RVA: 0x22CA8F0 Offset: 0x22C9CF0 VA: 0x1822CA8F0 Slot: 4
	public virtual ulong get_incomingGUID() { }

	// RVA: 0x22CA5E0 Offset: 0x22C99E0 VA: 0x1822CA5E0 Slot: 5
	public virtual uint get_incomingAddressInt() { }

	// RVA: 0x22CA980 Offset: 0x22C9D80 VA: 0x1822CA980 Slot: 6
	public virtual uint get_incomingPort() { }

	// RVA: 0x22CA670 Offset: 0x22C9A70 VA: 0x1822CA670
	public string get_incomingAddress() { }

	// RVA: 0x22CA800 Offset: 0x22C9C00 VA: 0x1822CA800 Slot: 7
	public virtual int get_incomingBits() { }

	// RVA: 0x22CA770 Offset: 0x22C9B70 VA: 0x1822CA770 Slot: 8
	public virtual int get_incomingBitsUnread() { }

	// RVA: 0x22CA8C0 Offset: 0x22C9CC0 VA: 0x1822CA8C0 Slot: 9
	public virtual int get_incomingBytes() { }

	// RVA: 0x22CA890 Offset: 0x22C9C90 VA: 0x1822CA890 Slot: 10
	public virtual int get_incomingBytesUnread() { }

	// RVA: 0x22CA230 Offset: 0x22C9630 VA: 0x1822CA230 Slot: 11
	public virtual void SetReadPos(int bitsOffset) { }

	// RVA: 0x22C9D70 Offset: 0x22C9170 VA: 0x1822C9D70 Slot: 12
	protected virtual bool Read(byte* data, int length) { }

	// RVA: 0x22C9D20 Offset: 0x22C9120 VA: 0x1822C9D20
	public int ReadBytes(byte[] buffer, int offset, int length) { }

	// RVA: 0x22C9B30 Offset: 0x22C8F30 VA: 0x1822C9B30
	public byte ReadByte() { }

	// RVA: 0x22C9AA0 Offset: 0x22C8EA0 VA: 0x1822C9AA0 Slot: 13
	public virtual IntPtr RawData() { }

	// RVA: 0x22C9C20 Offset: 0x22C9020 VA: 0x1822C9C20
	public int ReadBytes(MemoryStream memoryStream, int length) { }

	// RVA: 0x22C9FD0 Offset: 0x22C93D0 VA: 0x1822C9FD0 Slot: 14
	public virtual void SendStart() { }

	// RVA: 0x22CA380 Offset: 0x22C9780 VA: 0x1822CA380
	public void WriteByte(byte val) { }

	// RVA: 0x22CA400 Offset: 0x22C9800 VA: 0x1822CA400
	public void WriteBytes(byte[] val, int offset, int length) { }

	// RVA: 0x22CA3B0 Offset: 0x22C97B0 VA: 0x1822CA3B0
	public void WriteBytes(byte[] val) { }

	// RVA: 0x22CA440 Offset: 0x22C9840 VA: 0x1822CA440
	public void WriteBytes(MemoryStream stream) { }

	// RVA: 0x22CA4D0 Offset: 0x22C98D0 VA: 0x1822CA4D0 Slot: 15
	protected virtual void Write(byte* data, int size) { }

	// RVA: 0x22C9EE0 Offset: 0x22C92E0 VA: 0x1822C9EE0 Slot: 16
	public virtual uint SendBroadcast(Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CA060 Offset: 0x22C9460 VA: 0x1822CA060 Slot: 17
	public virtual uint SendTo(ulong guid, Priority priority, SendMethod reliability, sbyte channel) { }

	// RVA: 0x22CA160 Offset: 0x22C9560 VA: 0x1822CA160
	public void SendUnconnectedMessage(byte* data, int length, uint adr, ushort port) { }

	// RVA: 0x22C9010 Offset: 0x22C8410 VA: 0x1822C9010
	public string GetAddress(ulong guid) { }

	// RVA: 0x22CA2D0 Offset: 0x22C96D0 VA: 0x1822CA2D0
	private static string StringFromPointer(IntPtr p) { }

	// RVA: 0x22CA370 Offset: 0x22C9770 VA: 0x1822CA370
	public int ToRaknetPriority(Priority priority) { }

	// RVA: 0x22CA350 Offset: 0x22C9750 VA: 0x1822CA350
	public int ToRaknetPacketReliability(SendMethod reliability) { }

	// RVA: 0x22C9920 Offset: 0x22C8D20 VA: 0x1822C9920
	public void Kick(Connection connection) { }

	// RVA: 0x22C8610 Offset: 0x22C7A10 VA: 0x1822C8610 Slot: 18
	protected virtual void Check() { }

	// RVA: 0x22C94C0 Offset: 0x22C88C0 VA: 0x1822C94C0 Slot: 19
	public virtual string GetStatisticsString(ulong guid) { }

	// RVA: 0x22C9100 Offset: 0x22C8500 VA: 0x1822C9100 Slot: 20
	public virtual int GetPingAverage(ulong guid) { }

	// RVA: 0x22C91A0 Offset: 0x22C85A0 VA: 0x1822C91A0 Slot: 21
	public virtual int GetPingLast(ulong guid) { }

	// RVA: 0x22C9240 Offset: 0x22C8640 VA: 0x1822C9240 Slot: 22
	public virtual int GetPingLowest(ulong guid) { }

	// RVA: 0x22C97D0 Offset: 0x22C8BD0 VA: 0x1822C97D0 Slot: 23
	public virtual Native.RaknetStats GetStatistics(ulong guid) { }

	// RVA: 0x22C92E0 Offset: 0x22C86E0 VA: 0x1822C92E0 Slot: 24
	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	// RVA: 0x2FB0E0 Offset: 0x2FA4E0 VA: 0x1802FB0E0
	public void .ctor() { }

	// RVA: 0x22CA590 Offset: 0x22C9990 VA: 0x1822CA590
	private static void .cctor() { }

}

public enum Peer.PacketPriority // TypeDefIndex: 7335
{	// Fields
	public int value__; // 0x0
	public const Peer.PacketPriority IMMEDIATE_PRIORITY = 0;
	public const Peer.PacketPriority HIGH_PRIORITY = 1;
	public const Peer.PacketPriority MEDIUM_PRIORITY = 2;
	public const Peer.PacketPriority LOW_PRIORITY = 3;

}

public enum Peer.PacketReliability // TypeDefIndex: 7336
{	// Fields
	public int value__; // 0x0
	public const Peer.PacketReliability UNRELIABLE = 0;
	public const Peer.PacketReliability UNRELIABLE_SEQUENCED = 1;
	public const Peer.PacketReliability RELIABLE = 2;
	public const Peer.PacketReliability RELIABLE_ORDERED = 3;
	public const Peer.PacketReliability RELIABLE_SEQUENCED = 4;

}

