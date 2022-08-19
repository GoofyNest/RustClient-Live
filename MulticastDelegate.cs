public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
{
// Namespace: System
[ComVisibleAttribute] // RVA: 0x75EC0 Offset: 0x752C0 VA: 0x180075EC0
[Serializable]
public abstract class MulticastDelegate : Delegate // TypeDefIndex: 377
	// Fields
	private Delegate[] delegates; // 0x68

	// Methods

	// RVA: 0x1674100 Offset: 0x1673500 VA: 0x181674100 Slot: 8
	public override void GetObjectData(SerializationInfo info, StreamingContext context) { }

	// RVA: 0x1673E30 Offset: 0x1673230 VA: 0x181673E30 Slot: 0
	public sealed override bool Equals(object obj) { }

	// RVA: 0x1673FB0 Offset: 0x16733B0 VA: 0x181673FB0 Slot: 2
	public sealed override int GetHashCode() { }

	// RVA: 0x16740B0 Offset: 0x16734B0 VA: 0x1816740B0 Slot: 7
	protected override MethodInfo GetMethodImpl() { }

	// RVA: 0x1673FC0 Offset: 0x16733C0 VA: 0x181673FC0 Slot: 9
	public sealed override Delegate[] GetInvocationList() { }

	// RVA: 0x1673A70 Offset: 0x1672E70 VA: 0x181673A70 Slot: 10
	protected sealed override Delegate CombineImpl(Delegate follow) { }

	// RVA: 0x1674120 Offset: 0x1673520 VA: 0x181674120
	private int LastIndexOf(Delegate[] haystack, Delegate[] needle) { }

	// RVA: 0x1674290 Offset: 0x1673690 VA: 0x181674290 Slot: 11
	protected sealed override Delegate RemoveImpl(Delegate value) { }

}

