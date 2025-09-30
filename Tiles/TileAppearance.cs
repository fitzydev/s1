using System;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.Tiles
{
	// Token: 0x020002D3 RID: 723
	[Token(Token = "0x20002D3")]
	public class TileAppearance : MonoBehaviour
	{
		// Token: 0x06000F80 RID: 3968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F80")]
		[Address(RVA = "0xAC8750", Offset = "0xAC7150", VA = "0x180AC8750")]
		public void Awake()
		{
		}

		// Token: 0x06000F81 RID: 3969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F81")]
		[Address(RVA = "0x7AE920", Offset = "0x7AD320", VA = "0x1807AE920")]
		public void SetVisible(bool visible)
		{
		}

		// Token: 0x06000F82 RID: 3970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F82")]
		[Address(RVA = "0xAC8780", Offset = "0xAC7180", VA = "0x180AC8780")]
		public void SetColor(ETileColor col)
		{
		}

		// Token: 0x06000F83 RID: 3971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6000F83")]
		[Address(RVA = "0x42DCF0", Offset = "0x42C6F0", VA = "0x18042DCF0")]
		public TileAppearance()
		{
		}

		// Token: 0x04000F7E RID: 3966
		[Token(Token = "0x4000F7E")]
		[FieldOffset(Offset = "0x20")]
		[SerializeField]
		[Header("References")]
		protected MeshRenderer tileMesh;

		// Token: 0x04000F7F RID: 3967
		[Token(Token = "0x4000F7F")]
		[FieldOffset(Offset = "0x28")]
		[SerializeField]
		[Header("Settings")]
		protected Material mat_White;

		// Token: 0x04000F80 RID: 3968
		[Token(Token = "0x4000F80")]
		[FieldOffset(Offset = "0x30")]
		[SerializeField]
		protected Material mat_Blue;

		// Token: 0x04000F81 RID: 3969
		[Token(Token = "0x4000F81")]
		[FieldOffset(Offset = "0x38")]
		[SerializeField]
		protected Material mat_Red;
	}
}
