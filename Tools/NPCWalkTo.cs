using System;
using Il2CppDummyDll;
using ScheduleOne.NPCs;
using UnityEngine;

namespace ScheduleOne.Tools
{
	// Token: 0x0200090C RID: 2316
	[Token(Token = "0x200090C")]
	[RequireComponent(typeof(NPCMovement))]
	public class NPCWalkTo : MonoBehaviour
	{
		// Token: 0x06003FC2 RID: 16322 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC2")]
		[Address(RVA = "0x867A40", Offset = "0x866440", VA = "0x180867A40")]
		private void Update()
		{
		}

		// Token: 0x06003FC3 RID: 16323 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC3")]
		[Address(RVA = "0x588560", Offset = "0x586F60", VA = "0x180588560")]
		public NPCWalkTo()
		{
		}

		// Token: 0x04002CAB RID: 11435
		[Token(Token = "0x4002CAB")]
		[FieldOffset(Offset = "0x20")]
		public Transform Target;

		// Token: 0x04002CAC RID: 11436
		[Token(Token = "0x4002CAC")]
		[FieldOffset(Offset = "0x28")]
		public float RepathRate;

		// Token: 0x04002CAD RID: 11437
		[Token(Token = "0x4002CAD")]
		[FieldOffset(Offset = "0x2C")]
		private float timeSinceLastPath;
	}
}
