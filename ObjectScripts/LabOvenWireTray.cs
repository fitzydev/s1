using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB3 RID: 3251
	[Token(Token = "0x2000CB3")]
	public class LabOvenWireTray : MonoBehaviour
	{
		// Token: 0x17000CA2 RID: 3234
		// (get) Token: 0x06005A9D RID: 23197 RVA: 0x00016218 File Offset: 0x00014418
		// (set) Token: 0x06005A9E RID: 23198 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA2")]
		public bool Interactable
		{
			[Token(Token = "0x6005A9D")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A9E")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CA3 RID: 3235
		// (get) Token: 0x06005A9F RID: 23199 RVA: 0x00016230 File Offset: 0x00014430
		// (set) Token: 0x06005AA0 RID: 23200 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA3")]
		public float TargetPosition
		{
			[Token(Token = "0x6005A9F")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005AA0")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CA4 RID: 3236
		// (get) Token: 0x06005AA1 RID: 23201 RVA: 0x00016248 File Offset: 0x00014448
		// (set) Token: 0x06005AA2 RID: 23202 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA4")]
		public float ActualPosition
		{
			[Token(Token = "0x6005AA1")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005AA2")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005AA3 RID: 23203 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA3")]
		[Address(RVA = "0xA29A60", Offset = "0xA28460", VA = "0x180A29A60")]
		private void Start()
		{
		}

		// Token: 0x06005AA4 RID: 23204 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA4")]
		[Address(RVA = "0xA296D0", Offset = "0xA280D0", VA = "0x180A296D0")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005AA5 RID: 23205 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA5")]
		[Address(RVA = "0xA29860", Offset = "0xA28260", VA = "0x180A29860")]
		private void Move()
		{
		}

		// Token: 0x06005AA6 RID: 23206 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA6")]
		[Address(RVA = "0xA292C0", Offset = "0xA27CC0", VA = "0x180A292C0")]
		private void ClampAngle()
		{
		}

		// Token: 0x06005AA7 RID: 23207 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA7")]
		[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x06005AA8 RID: 23208 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA8")]
		[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
		public void SetPosition(float position)
		{
		}

		// Token: 0x06005AA9 RID: 23209 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AA9")]
		[Address(RVA = "0xA29410", Offset = "0xA27E10", VA = "0x180A29410")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06005AAA RID: 23210 RVA: 0x00016260 File Offset: 0x00014460
		[Token(Token = "0x6005AAA")]
		[Address(RVA = "0xA29420", Offset = "0xA27E20", VA = "0x180A29420")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x06005AAB RID: 23211 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAB")]
		[Address(RVA = "0xA29400", Offset = "0xA27E00", VA = "0x180A29400")]
		public void ClickEnd()
		{
		}

		// Token: 0x06005AAC RID: 23212 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005AAC")]
		[Address(RVA = "0xA29A70", Offset = "0xA28470", VA = "0x180A29A70")]
		public LabOvenWireTray()
		{
		}

		// Token: 0x0400425A RID: 16986
		[Token(Token = "0x400425A")]
		public const float HIT_OFFSET_MAX = 0.24f;

		// Token: 0x0400425B RID: 16987
		[Token(Token = "0x400425B")]
		public const float HIT_OFFSET_MIN = -0.25f;

		// Token: 0x0400425F RID: 16991
		[Token(Token = "0x400425F")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Transform Tray;

		// Token: 0x04004260 RID: 16992
		[Token(Token = "0x4004260")]
		[FieldOffset(Offset = "0x38")]
		public Transform PlaneNormal;

		// Token: 0x04004261 RID: 16993
		[Token(Token = "0x4004261")]
		[FieldOffset(Offset = "0x40")]
		public Transform ClosedPosition;

		// Token: 0x04004262 RID: 16994
		[Token(Token = "0x4004262")]
		[FieldOffset(Offset = "0x48")]
		public Transform OpenPosition;

		// Token: 0x04004263 RID: 16995
		[Token(Token = "0x4004263")]
		[FieldOffset(Offset = "0x50")]
		public LabOvenDoor OvenDoor;

		// Token: 0x04004264 RID: 16996
		[Token(Token = "0x4004264")]
		[FieldOffset(Offset = "0x58")]
		[Header("Settings")]
		public float MoveSpeed;

		// Token: 0x04004265 RID: 16997
		[Token(Token = "0x4004265")]
		[FieldOffset(Offset = "0x60")]
		public AnimationCurve DoorClampCurve;

		// Token: 0x04004266 RID: 16998
		[Token(Token = "0x4004266")]
		[FieldOffset(Offset = "0x68")]
		private Vector3 clickOffset;

		// Token: 0x04004267 RID: 16999
		[Token(Token = "0x4004267")]
		[FieldOffset(Offset = "0x74")]
		private bool isMoving;
	}
}
