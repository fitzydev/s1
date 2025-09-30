using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.NPCs
{
	// Token: 0x02000671 RID: 1649
	[Token(Token = "0x2000671")]
	public class NPCSpeedController : MonoBehaviour
	{
		// Token: 0x060029C4 RID: 10692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C4")]
		[Address(RVA = "0x72A4F0", Offset = "0x728EF0", VA = "0x18072A4F0")]
		private void Awake()
		{
		}

		// Token: 0x060029C5 RID: 10693 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C5")]
		[Address(RVA = "0x72A680", Offset = "0x729080", VA = "0x18072A680")]
		private void FixedUpdate()
		{
		}

		// Token: 0x060029C6 RID: 10694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C6")]
		[Address(RVA = "0x72A7C0", Offset = "0x7291C0", VA = "0x18072A7C0")]
		private NPCSpeedController.SpeedControl GetHighestPriorityControl()
		{
			return null;
		}

		// Token: 0x060029C7 RID: 10695 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029C7")]
		[Address(RVA = "0x72A2B0", Offset = "0x728CB0", VA = "0x18072A2B0")]
		public void AddSpeedControl(NPCSpeedController.SpeedControl control)
		{
		}

		// Token: 0x060029C8 RID: 10696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60029C8")]
		[Address(RVA = "0x72A810", Offset = "0x729210", VA = "0x18072A810")]
		public NPCSpeedController.SpeedControl GetSpeedControl(string id)
		{
			return null;
		}

		// Token: 0x060029C9 RID: 10697 RVA: 0x0000CA20 File Offset: 0x0000AC20
		[Token(Token = "0x60029C9")]
		[Address(RVA = "0x72A5A0", Offset = "0x728FA0", VA = "0x18072A5A0")]
		public bool DoesSpeedControlExist(string id)
		{
			return default(bool);
		}

		// Token: 0x060029CA RID: 10698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CA")]
		[Address(RVA = "0x72A8F0", Offset = "0x7292F0", VA = "0x18072A8F0")]
		public void RemoveSpeedControl(string id)
		{
		}

		// Token: 0x060029CB RID: 10699 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60029CB")]
		[Address(RVA = "0x72AA00", Offset = "0x729400", VA = "0x18072AA00")]
		public NPCSpeedController()
		{
		}

		// Token: 0x04001F52 RID: 8018
		[Token(Token = "0x4001F52")]
		[FieldOffset(Offset = "0x20")]
		[Header("Settings")]
		[Range(0f, 1f)]
		public float DefaultWalkSpeed;

		// Token: 0x04001F53 RID: 8019
		[Token(Token = "0x4001F53")]
		[FieldOffset(Offset = "0x24")]
		public float SpeedMultiplier;

		// Token: 0x04001F54 RID: 8020
		[Token(Token = "0x4001F54")]
		[FieldOffset(Offset = "0x28")]
		[Header("References")]
		public NPCMovement Movement;

		// Token: 0x04001F55 RID: 8021
		[Token(Token = "0x4001F55")]
		[FieldOffset(Offset = "0x30")]
		protected List<NPCSpeedController.SpeedControl> speedControlStack;

		// Token: 0x04001F56 RID: 8022
		[Token(Token = "0x4001F56")]
		[FieldOffset(Offset = "0x38")]
		[Header("Debug")]
		public NPCSpeedController.SpeedControl ActiveSpeedControl;

		// Token: 0x02000672 RID: 1650
		[Token(Token = "0x2000672")]
		[Serializable]
		public class SpeedControl
		{
			// Token: 0x060029CC RID: 10700 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60029CC")]
			[Address(RVA = "0x72C750", Offset = "0x72B150", VA = "0x18072C750")]
			public SpeedControl(string id, int priority, float speed)
			{
			}

			// Token: 0x04001F57 RID: 8023
			[Token(Token = "0x4001F57")]
			[FieldOffset(Offset = "0x10")]
			public string id;

			// Token: 0x04001F58 RID: 8024
			[Token(Token = "0x4001F58")]
			[FieldOffset(Offset = "0x18")]
			public int priority;

			// Token: 0x04001F59 RID: 8025
			[Token(Token = "0x4001F59")]
			[FieldOffset(Offset = "0x1C")]
			public float speed;
		}
	}
}
