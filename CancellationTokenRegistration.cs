public struct CancellationTokenRegistration : IEquatable<CancellationTokenRegistration>, IDisposable // TypeDefIndex: 750
{
	private readonly CancellationCallbackInfo m_callbackInfo;
	private readonly SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> m_registrationInfo;


	internal void .ctor(CancellationCallbackInfo callbackInfo, SparselyPopulatedArrayAddInfo<CancellationCallbackInfo> registrationInfo) { }

	[FriendAccessAllowedAttribute]
	internal bool TryDeregister() { }

	public void Dispose() { }

	public override bool Equals(object obj) { }

	public bool Equals(CancellationTokenRegistration other) { }

	public override int GetHashCode() { }

}

