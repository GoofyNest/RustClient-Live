public class Message // TypeDefIndex: 6867
{
	public Message.Type type; 
	public BaseNetwork peer; 
	public Connection connection; 

	public NetRead read { get; }
	public NetWrite write { get; }


	public NetRead get_read() { }

	public NetWrite get_write() { }

	public virtual void Clear() { }

	public void .ctor() { }

}

public enum Message.Type // TypeDefIndex: 6868
{
	public byte value__; 
	public const Message.Type Welcome = 1;
	public const Message.Type Auth = 2;
	public const Message.Type Approved = 3;
	public const Message.Type Ready = 4;
	public const Message.Type Entities = 5;
	public const Message.Type EntityDestroy = 6;
	public const Message.Type GroupChange = 7;
	public const Message.Type GroupDestroy = 8;
	public const Message.Type RPCMessage = 9;
	public const Message.Type EntityPosition = 10;
	public const Message.Type ConsoleMessage = 11;
	public const Message.Type ConsoleCommand = 12;
	public const Message.Type Effect = 13;
	public const Message.Type DisconnectReason = 14;
	public const Message.Type Tick = 15;
	public const Message.Type Message = 16;
	public const Message.Type RequestUserInformation = 17;
	public const Message.Type GiveUserInformation = 18;
	public const Message.Type GroupEnter = 19;
	public const Message.Type GroupLeave = 20;
	public const Message.Type VoiceData = 21;
	public const Message.Type EAC = 22;
	public const Message.Type EntityFlags = 23;
	public const Message.Type World = 24;
	public const Message.Type ConsoleReplicatedVars = 25;
	public const Message.Type Last = 25;

}

