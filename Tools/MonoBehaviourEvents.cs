using System;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Tools
{
	// Token: 0x0200090B RID: 2315
	[Token(Token = "0x200090B")]
	public class MonoBehaviourEvents : MonoBehaviour
	{
		// Token: 0x06003FBE RID: 16318 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBE")]
		[Address(RVA = "0x8679E0", Offset = "0x8663E0", VA = "0x1808679E0")]
		private void Awake()
		{
		}

		// Token: 0x06003FBF RID: 16319 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FBF")]
		[Address(RVA = "0x867A00", Offset = "0x866400", VA = "0x180867A00")]
		private void Start()
		{
		}

		// Token: 0x06003FC0 RID: 16320 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC0")]
		[Address(RVA = "0x867A20", Offset = "0x866420", VA = "0x180867A20")]
		private void Update()
		{
		}

		// Token: 0x06003FC1 RID: 16321 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003FC1")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public MonoBehaviourEvents()
		{
		}

		// Token: 0x04002CA8 RID: 11432
		[Token(Token = "0x4002CA8")]
		[FieldOffset(Offset = "0x20")]
		public UnityEvent onAwake;

		// Token: 0x04002CA9 RID: 11433
		[Token(Token = "0x4002CA9")]
		[FieldOffset(Offset = "0x28")]
		public UnityEvent onStart;

		// Token: 0x04002CAA RID: 11434
		[Token(Token = "0x4002CAA")]
		[FieldOffset(Offset = "0x30")]
		public UnityEvent onUpdate;
	}
}
