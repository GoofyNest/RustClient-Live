internal class Peer // TypeDefIndex: 7335
{
	private IntPtr ptr; 
	private static byte[] ByteBuffer; 

	public virtual ulong incomingGUID { get; }
	public virtual uint incomingAddressInt { get; }
	public virtual uint incomingPort { get; }
	public string incomingAddress { get; }
	public virtual int incomingBits { get; }
	public virtual int incomingBitsUnread { get; }
	public virtual int incomingBytes { get; }
	public virtual int incomingBytesUnread { get; }


	public static Peer CreateServer(string ip, int port, int maxConnections) { }

	public static Peer CreateConnection(string hostname, int port, int retries, int retryDelay, int timeout) { }

	public void Close() { }

	public uint PendingReceiveCount() { }

	public bool Receive() { }

	public virtual ulong get_incomingGUID() { }

	public virtual uint get_incomingAddressInt() { }

	public virtual uint get_incomingPort() { }

	public string get_incomingAddress() { }

	public virtual int get_incomingBits() { }

	public virtual int get_incomingBitsUnread() { }

	public virtual int get_incomingBytes() { }

	public virtual int get_incomingBytesUnread() { }

	public virtual void SetReadPos(int bitsOffset) { }

	protected virtual bool Read(byte* data, int length) { }

	public int ReadBytes(byte[] buffer, int offset, int length) { }

	public byte ReadByte() { }

	public virtual IntPtr RawData() { }

	public int ReadBytes(MemoryStream memoryStream, int length) { }

	public virtual void SendStart() { }

	public void WriteByte(byte val) { }

	public void WriteBytes(byte[] val, int offset, int length) { }

	public void WriteBytes(byte[] val) { }

	public void WriteBytes(MemoryStream stream) { }

	protected virtual void Write(byte* data, int size) { }

	public virtual uint SendBroadcast(Priority priority, SendMethod reliability, sbyte channel) { }

	public virtual uint SendTo(ulong guid, Priority priority, SendMethod reliability, sbyte channel) { }

	public void SendUnconnectedMessage(byte* data, int length, uint adr, ushort port) { }

	public string GetAddress(ulong guid) { }

	private static string StringFromPointer(IntPtr p) { }

	public int ToRaknetPriority(Priority priority) { }

	public int ToRaknetPacketReliability(SendMethod reliability) { }

	public void Kick(Connection connection) { }

	protected virtual void Check() { }

	public virtual string GetStatisticsString(ulong guid) { }

	public virtual int GetPingAverage(ulong guid) { }

	public virtual int GetPingLast(ulong guid) { }

	public virtual int GetPingLowest(ulong guid) { }

	public virtual Native.RaknetStats GetStatistics(ulong guid) { }

	public virtual ulong GetStat(Connection connection, BaseNetwork.StatTypeLong type) { }

	public void .ctor() { }

	private static void .cctor() { }

}

public enum Peer.PacketPriority // TypeDefIndex: 7336
{
	public int value__; 
	public const Peer.PacketPriority IMMEDIATE_PRIORITY = 0;
	public const Peer.PacketPriority HIGH_PRIORITY = 1;
	public const Peer.PacketPriority MEDIUM_PRIORITY = 2;
	public const Peer.PacketPriority LOW_PRIORITY = 3;

}

public enum Peer.PacketReliability // TypeDefIndex: 7337
{
	public int value__; 
	public const Peer.PacketReliability UNRELIABLE = 0;
	public const Peer.PacketReliability UNRELIABLE_SEQUENCED = 1;
	public const Peer.PacketReliability RELIABLE = 2;
	public const Peer.PacketReliability RELIABLE_ORDERED = 3;
	public const Peer.PacketReliability RELIABLE_SEQUENCED = 4;

}

