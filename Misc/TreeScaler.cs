using System;
using System.Collections.Generic;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Misc
{
	// Token: 0x02000CE4 RID: 3300
	[Token(Token = "0x2000CE4")]
	public class TreeScaler : MonoBehaviour
	{
		// Token: 0x06005D88 RID: 23944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D88")]
		[Address(RVA = "0xA69FB0", Offset = "0xA689B0", VA = "0x180A69FB0", Slot = "4")]
		protected virtual void Start()
		{
		}

		// Token: 0x06005D89 RID: 23945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D89")]
		[Address(RVA = "0xA6A0B0", Offset = "0xA68AB0", VA = "0x180A6A0B0")]
		private void UpdateScale()
		{
		}

		// Token: 0x06005D8A RID: 23946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005D8A")]
		[Address(RVA = "0xA6A3A0", Offset = "0xA68DA0", VA = "0x180A6A3A0")]
		public TreeScaler()
		{
		}

		// Token: 0x040043E8 RID: 17384
		[Token(Token = "0x40043E8")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected List<Transform> branchMeshes;

		// Token: 0x040043E9 RID: 17385
		[Token(Token = "0x40043E9")]
		[FieldOffset(Offset = "0x28")]
		public float minScale;

		// Token: 0x040043EA RID: 17386
		[Token(Token = "0x40043EA")]
		[FieldOffset(Offset = "0x2C")]
		public float maxScale;

		// Token: 0x040043EB RID: 17387
		[Token(Token = "0x40043EB")]
		[FieldOffset(Offset = "0x30")]
		public float minScaleDistance;

		// Token: 0x040043EC RID: 17388
		[Token(Token = "0x40043EC")]
		[FieldOffset(Offset = "0x34")]
		public float maxScaleDistance;
	}
}
