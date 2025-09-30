using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.ScriptableObjects;

namespace ScheduleOne.Calling
{
	// Token: 0x02000817 RID: 2071
	[Token(Token = "0x2000817")]
	public class CallManager : Singleton<CallManager>
	{
		// Token: 0x17000817 RID: 2071
		// (get) Token: 0x0600391A RID: 14618 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600391B RID: 14619 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000817")]
		public PhoneCallData QueuedCallData
		{
			[Token(Token = "0x600391A")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600391B")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600391C RID: 14620 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391C")]
		[Address(RVA = "0x803430", Offset = "0x801E30", VA = "0x180803430", Slot = "4")]
		protected override void Start()
		{
		}

		// Token: 0x0600391D RID: 14621 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391D")]
		[Address(RVA = "0x803240", Offset = "0x801C40", VA = "0x180803240", Slot = "6")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x0600391E RID: 14622 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391E")]
		[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
		public void QueueCall(PhoneCallData data)
		{
		}

		// Token: 0x0600391F RID: 14623 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600391F")]
		[Address(RVA = "0x803220", Offset = "0x801C20", VA = "0x180803220")]
		public void ClearQueuedCall()
		{
		}

		// Token: 0x06003920 RID: 14624 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003920")]
		[Address(RVA = "0x8031A0", Offset = "0x801BA0", VA = "0x1808031A0")]
		private void CallCompleted(PhoneCallData call)
		{
		}

		// Token: 0x06003921 RID: 14625 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003921")]
		[Address(RVA = "0x803660", Offset = "0x802060", VA = "0x180803660")]
		public CallManager()
		{
		}
	}
}
