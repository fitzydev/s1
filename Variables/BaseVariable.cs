using System;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using Il2CppDummyDll;
using ScheduleOne.PlayerScripts;

namespace ScheduleOne.Variables
{
	// Token: 0x0200029A RID: 666
	[Token(Token = "0x200029A")]
	public abstract class BaseVariable
	{
		// Token: 0x17000303 RID: 771
		// (get) Token: 0x06000DDF RID: 3551 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06000DE0 RID: 3552 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000303")]
		public Player Owner
		{
			[Token(Token = "0x6000DDF")]
			[Address(RVA = "0x4423C0", Offset = "0x440DC0", VA = "0x1804423C0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6000DE0")]
			[Address(RVA = "0x4423F0", Offset = "0x440DF0", VA = "0x1804423F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06000DE1 RID: 3553 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000DE1")]
		[Address(RVA = "0xA9BBD0", Offset = "0xA9A5D0", VA = "0x180A9BBD0")]
		public BaseVariable(string name, EVariableReplicationMode replicationMode, bool persistent, EVariableMode mode, Player owner)
		{
		}

		// Token: 0x06000DE2 RID: 3554
		[Token(Token = "0x6000DE2")]
		public abstract object GetValue();

		// Token: 0x06000DE3 RID: 3555
		[Token(Token = "0x6000DE3")]
		public abstract void SetValue(object value, bool replicate = true);

		// Token: 0x06000DE4 RID: 3556
		[Token(Token = "0x6000DE4")]
		public abstract void ReplicateValue(NetworkConnection conn);

		// Token: 0x06000DE5 RID: 3557 RVA: 0x00006FF0 File Offset: 0x000051F0
		[Token(Token = "0x6000DE5")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "7")]
		public virtual bool EvaluateCondition(Condition.EConditionType operation, string value)
		{
			return default(bool);
		}

		// Token: 0x04000E1E RID: 3614
		[Token(Token = "0x4000E1E")]
		[FieldOffset(Offset = "0x10")]
		public EVariableReplicationMode ReplicationMode;

		// Token: 0x04000E1F RID: 3615
		[Token(Token = "0x4000E1F")]
		[FieldOffset(Offset = "0x18")]
		public string Name;

		// Token: 0x04000E20 RID: 3616
		[Token(Token = "0x4000E20")]
		[FieldOffset(Offset = "0x20")]
		public bool Persistent;

		// Token: 0x04000E21 RID: 3617
		[Token(Token = "0x4000E21")]
		[FieldOffset(Offset = "0x24")]
		public EVariableMode VariableMode;
	}
}
