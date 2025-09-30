using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.Growing
{
	// Token: 0x02000927 RID: 2343
	[Token(Token = "0x2000927")]
	public class VialCap : Clickable
	{
		// Token: 0x170008FC RID: 2300
		// (get) Token: 0x0600402A RID: 16426 RVA: 0x00011058 File Offset: 0x0000F258
		// (set) Token: 0x0600402B RID: 16427 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008FC")]
		public bool Removed
		{
			[Token(Token = "0x600402A")]
			[Address(RVA = "0x4A4A60", Offset = "0x4A3460", VA = "0x1804A4A60")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600402B")]
			[Address(RVA = "0x4A4A90", Offset = "0x4A3490", VA = "0x1804A4A90")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x0600402C RID: 16428 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402C")]
		[Address(RVA = "0x8787C0", Offset = "0x8771C0", VA = "0x1808787C0", Slot = "6")]
		public override void StartClick(RaycastHit hit)
		{
		}

		// Token: 0x0600402D RID: 16429 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402D")]
		[Address(RVA = "0x878500", Offset = "0x876F00", VA = "0x180878500")]
		private void Pop()
		{
		}

		// Token: 0x0600402E RID: 16430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600402E")]
		[Address(RVA = "0x878810", Offset = "0x877210", VA = "0x180878810")]
		public VialCap()
		{
		}

		// Token: 0x04002D0E RID: 11534
		[Token(Token = "0x4002D0E")]
		[FieldOffset(Offset = "0x58")]
		public Collider Collider;

		// Token: 0x04002D0F RID: 11535
		[Token(Token = "0x4002D0F")]
		[FieldOffset(Offset = "0x60")]
		private Rigidbody RigidBody;
	}
}
