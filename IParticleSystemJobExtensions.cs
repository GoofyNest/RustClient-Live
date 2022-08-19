public static class IParticleSystemJobExtensions // TypeDefIndex: 4547
{	// Methods

	[ExtensionAttribute] // RVA: 0x6F300 Offset: 0x6E700 VA: 0x18006F300
	// RVA: -1 Offset: -1
	public static JobHandle Schedule<T>(T jobData, ParticleSystem ps, JobHandle dependsOn) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0790 Offset: 0x1A9FB90 VA: 0x181AA0790
	|-IParticleSystemJobExtensions.Schedule<ParticleSystemIK.ParticleSystemIKJob>
	*/

	// RVA: -1 Offset: -1
	private static JobsUtility.JobScheduleParameters CreateScheduleParams<T>(ref T jobData, ParticleSystem ps, JobHandle dependsOn, IntPtr jobReflectionData) { }
	/* GenericInstMethod :
	|
	|-RVA: 0x1AA0680 Offset: 0x1A9FA80 VA: 0x181AA0680
	|-IParticleSystemJobExtensions.CreateScheduleParams<ParticleSystemIK.ParticleSystemIKJob>
	*/

}

