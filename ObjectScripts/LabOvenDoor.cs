using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB1 RID: 3249
	[Token(Token = "0x2000CB1")]
	public class LabOvenDoor : MonoBehaviour
	{
		// Token: 0x17000C9F RID: 3231
		// (get) Token: 0x06005A8A RID: 23178 RVA: 0x000161B8 File Offset: 0x000143B8
		// (set) Token: 0x06005A8B RID: 23179 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C9F")]
		public bool Interactable
		{
			[Token(Token = "0x6005A8A")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005A8B")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CA0 RID: 3232
		// (get) Token: 0x06005A8C RID: 23180 RVA: 0x000161D0 File Offset: 0x000143D0
		// (set) Token: 0x06005A8D RID: 23181 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA0")]
		public float TargetPosition
		{
			[Token(Token = "0x6005A8C")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005A8D")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000CA1 RID: 3233
		// (get) Token: 0x06005A8E RID: 23182 RVA: 0x000161E8 File Offset: 0x000143E8
		// (set) Token: 0x06005A8F RID: 23183 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000CA1")]
		public float ActualPosition
		{
			[Token(Token = "0x6005A8E")]
			[Address(RVA = "0x485C70", Offset = "0x484670", VA = "0x180485C70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005A8F")]
			[Address(RVA = "0x485CB0", Offset = "0x4846B0", VA = "0x180485CB0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005A90 RID: 23184 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A90")]
		[Address(RVA = "0xA28F00", Offset = "0xA27900", VA = "0x180A28F00")]
		private void Start()
		{
		}

		// Token: 0x06005A91 RID: 23185 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A91")]
		[Address(RVA = "0xA28A90", Offset = "0xA27490", VA = "0x180A28A90")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005A92 RID: 23186 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A92")]
		[Address(RVA = "0xA28CE0", Offset = "0xA276E0", VA = "0x180A28CE0")]
		private void Move()
		{
		}

		// Token: 0x06005A93 RID: 23187 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A93")]
		[Address(RVA = "0xA28E50", Offset = "0xA27850", VA = "0x180A28E50")]
		public void SetInteractable(bool interactable)
		{
		}

		// Token: 0x06005A94 RID: 23188 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A94")]
		[Address(RVA = "0xA28E70", Offset = "0xA27870", VA = "0x180A28E70")]
		public void SetPosition(float newPosition)
		{
		}

		// Token: 0x06005A95 RID: 23189 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A95")]
		[Address(RVA = "0xA28740", Offset = "0xA27140", VA = "0x180A28740")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06005A96 RID: 23190 RVA: 0x00016200 File Offset: 0x00014400
		[Token(Token = "0x6005A96")]
		[Address(RVA = "0xA287E0", Offset = "0xA271E0", VA = "0x180A287E0")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x06005A97 RID: 23191 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A97")]
		[Address(RVA = "0xA28730", Offset = "0xA27130", VA = "0x180A28730")]
		public void ClickEnd()
		{
		}

		// Token: 0x06005A98 RID: 23192 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A98")]
		[Address(RVA = "0xA29030", Offset = "0xA27A30", VA = "0x180A29030")]
		public LabOvenDoor()
		{
		}

		// Token: 0x0400423E RID: 16958
		[Token(Token = "0x400423E")]
		public const float HIT_OFFSET_MAX = 0.24f;

		// Token: 0x0400423F RID: 16959
		[Token(Token = "0x400423F")]
		public const float HIT_OFFSET_MIN = -0.25f;

		// Token: 0x04004240 RID: 16960
		[Token(Token = "0x4004240")]
		public const float DOOR_ANGLE_CLOSED = 90f;

		// Token: 0x04004241 RID: 16961
		[Token(Token = "0x4004241")]
		public const float DOOR_ANGLE_OPEN = 10f;

		// Token: 0x04004245 RID: 16965
		[Token(Token = "0x4004245")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Clickable HandleClickable;

		// Token: 0x04004246 RID: 16966
		[Token(Token = "0x4004246")]
		[FieldOffset(Offset = "0x38")]
		public Transform Door;

		// Token: 0x04004247 RID: 16967
		[Token(Token = "0x4004247")]
		[FieldOffset(Offset = "0x40")]
		public Transform PlaneNormal;

		// Token: 0x04004248 RID: 16968
		[Token(Token = "0x4004248")]
		[FieldOffset(Offset = "0x48")]
		public AnimationCurve HitMapCurve;

		// Token: 0x04004249 RID: 16969
		[Token(Token = "0x4004249")]
		[FieldOffset(Offset = "0x50")]
		[Header("Sounds")]
		public AudioSourceController OpenSound;

		// Token: 0x0400424A RID: 16970
		[Token(Token = "0x400424A")]
		[FieldOffset(Offset = "0x58")]
		public AudioSourceController CloseSound;

		// Token: 0x0400424B RID: 16971
		[Token(Token = "0x400424B")]
		[FieldOffset(Offset = "0x60")]
		public AudioSourceController ShutSound;

		// Token: 0x0400424C RID: 16972
		[Token(Token = "0x400424C")]
		[FieldOffset(Offset = "0x68")]
		[Header("Settings")]
		public float DoorMoveSpeed;

		// Token: 0x0400424D RID: 16973
		[Token(Token = "0x400424D")]
		[FieldOffset(Offset = "0x6C")]
		private Vector3 clickOffset;

		// Token: 0x0400424E RID: 16974
		[Token(Token = "0x400424E")]
		[FieldOffset(Offset = "0x78")]
		private bool isMoving;
	}
}
