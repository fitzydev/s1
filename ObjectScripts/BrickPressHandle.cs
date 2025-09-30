using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C93 RID: 3219
	[Token(Token = "0x2000C93")]
	public class BrickPressHandle : MonoBehaviour
	{
		// Token: 0x17000C24 RID: 3108
		// (get) Token: 0x060057E1 RID: 22497 RVA: 0x00015AE0 File Offset: 0x00013CE0
		// (set) Token: 0x060057E2 RID: 22498 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C24")]
		public bool Interactable
		{
			[Token(Token = "0x60057E1")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60057E2")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C25 RID: 3109
		// (get) Token: 0x060057E3 RID: 22499 RVA: 0x00015AF8 File Offset: 0x00013CF8
		// (set) Token: 0x060057E4 RID: 22500 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C25")]
		public float CurrentPosition
		{
			[Token(Token = "0x60057E3")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60057E4")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C26 RID: 3110
		// (get) Token: 0x060057E5 RID: 22501 RVA: 0x00015B10 File Offset: 0x00013D10
		// (set) Token: 0x060057E6 RID: 22502 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C26")]
		public float TargetPosition
		{
			[Token(Token = "0x60057E5")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60057E6")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060057E7 RID: 22503 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E7")]
		[Address(RVA = "0xA03A00", Offset = "0xA02400", VA = "0x180A03A00")]
		private void Start()
		{
		}

		// Token: 0x060057E8 RID: 22504 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E8")]
		[Address(RVA = "0xA03680", Offset = "0xA02080", VA = "0x180A03680")]
		private void LateUpdate()
		{
		}

		// Token: 0x060057E9 RID: 22505 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057E9")]
		[Address(RVA = "0xA03820", Offset = "0xA02220", VA = "0x180A03820")]
		private void Move()
		{
		}

		// Token: 0x060057EA RID: 22506 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EA")]
		[Address(RVA = "0xA03B20", Offset = "0xA02520", VA = "0x180A03B20")]
		private void UpdateSound(float difference)
		{
		}

		// Token: 0x060057EB RID: 22507 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EB")]
		[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
		public void SetPosition(float position)
		{
		}

		// Token: 0x060057EC RID: 22508 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EC")]
		[Address(RVA = "0xA039E0", Offset = "0xA023E0", VA = "0x180A039E0")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x060057ED RID: 22509 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057ED")]
		[Address(RVA = "0xA03240", Offset = "0xA01C40", VA = "0x180A03240")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x060057EE RID: 22510 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057EE")]
		[Address(RVA = "0xA03230", Offset = "0xA01C30", VA = "0x180A03230")]
		public void ClickEnd()
		{
		}

		// Token: 0x060057EF RID: 22511 RVA: 0x00015B28 File Offset: 0x00013D28
		[Token(Token = "0x60057EF")]
		[Address(RVA = "0xA032E0", Offset = "0xA01CE0", VA = "0x180A032E0")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x060057F0 RID: 22512 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60057F0")]
		[Address(RVA = "0xA03B30", Offset = "0xA02530", VA = "0x180A03B30")]
		public BrickPressHandle()
		{
		}

		// Token: 0x040040D5 RID: 16597
		[Token(Token = "0x40040D5")]
		[FieldOffset(Offset = "0x2C")]
		private float lastClickPosition;

		// Token: 0x040040D6 RID: 16598
		[Token(Token = "0x40040D6")]
		[FieldOffset(Offset = "0x30")]
		[Header("Settings")]
		public float MoveSpeed;

		// Token: 0x040040D7 RID: 16599
		[Token(Token = "0x40040D7")]
		[FieldOffset(Offset = "0x34")]
		public bool Locked;

		// Token: 0x040040D8 RID: 16600
		[Token(Token = "0x40040D8")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform PlaneNormal;

		// Token: 0x040040D9 RID: 16601
		[Token(Token = "0x40040D9")]
		[FieldOffset(Offset = "0x40")]
		public Transform RaisedTransform;

		// Token: 0x040040DA RID: 16602
		[Token(Token = "0x40040DA")]
		[FieldOffset(Offset = "0x48")]
		public Transform LoweredTransform;

		// Token: 0x040040DB RID: 16603
		[Token(Token = "0x40040DB")]
		[FieldOffset(Offset = "0x50")]
		public Clickable HandleClickable;

		// Token: 0x040040DC RID: 16604
		[Token(Token = "0x40040DC")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController ClickSound;

		// Token: 0x040040DD RID: 16605
		[Token(Token = "0x40040DD")]
		[FieldOffset(Offset = "0x60")]
		private Vector3 clickOffset;

		// Token: 0x040040DE RID: 16606
		[Token(Token = "0x40040DE")]
		[FieldOffset(Offset = "0x6C")]
		private bool isMoving;
	}
}
