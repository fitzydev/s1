using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.StationFramework
{
	// Token: 0x02000976 RID: 2422
	[Token(Token = "0x2000976")]
	public class PourableAngleLimit : MonoBehaviour
	{
		// Token: 0x06004266 RID: 16998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004266")]
		[Address(RVA = "0x880D00", Offset = "0x87F700", VA = "0x180880D00")]
		private void Awake()
		{
		}

		// Token: 0x06004267 RID: 16999 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004267")]
		[Address(RVA = "0x880D20", Offset = "0x87F720", VA = "0x180880D20")]
		public void FixedUpdate()
		{
		}

		// Token: 0x06004268 RID: 17000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6004268")]
		[Address(RVA = "0x880DD0", Offset = "0x87F7D0", VA = "0x180880DD0")]
		public PourableAngleLimit()
		{
		}

		// Token: 0x04002E84 RID: 11908
		[Token(Token = "0x4002E84")]
		[FieldOffset(Offset = "0x20")]
		public PourableModule Pourable;

		// Token: 0x04002E85 RID: 11909
		[Token(Token = "0x4002E85")]
		[FieldOffset(Offset = "0x28")]
		public DraggableConstraint Constraint;

		// Token: 0x04002E86 RID: 11910
		[Token(Token = "0x4002E86")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float AngleAtMaxFill;

		// Token: 0x04002E87 RID: 11911
		[Token(Token = "0x4002E87")]
		[FieldOffset(Offset = "0x34")]
		public float AngleAtMinFill;

		// Token: 0x04002E88 RID: 11912
		[Token(Token = "0x4002E88")]
		[FieldOffset(Offset = "0x38")]
		public float PourAngleMaxFill;

		// Token: 0x04002E89 RID: 11913
		[Token(Token = "0x4002E89")]
		[FieldOffset(Offset = "0x3C")]
		public float PourAngleMinFill;
	}
}
