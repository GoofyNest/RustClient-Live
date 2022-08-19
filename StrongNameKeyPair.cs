public class StrongNameKeyPair : ISerializable, IDeserializationCallback // TypeDefIndex: 598
{	// Fields
	private byte[] _publicKey; // 0x10
	private string _keyPairContainer; // 0x18
	private bool _keyPairExported; // 0x20
	private byte[] _keyPairArray; // 0x28

	// Methods

	// RVA: 0x18D2150 Offset: 0x18D1550 VA: 0x1818D2150
	protected void .ctor(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x18D2040 Offset: 0x18D1440 VA: 0x1818D2040 Slot: 4
	private void System.Runtime.Serialization.ISerializable.GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x3628C0 Offset: 0x361CC0 VA: 0x1803628C0 Slot: 5
	private void System.Runtime.Serialization.IDeserializationCallback.OnDeserialization(object sender) { }

}

