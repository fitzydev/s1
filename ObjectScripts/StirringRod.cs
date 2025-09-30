using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.PlayerTasks;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CA4 RID: 3236
	[Token(Token = "0x2000CA4")]
	public class StirringRod : MonoBehaviour
	{
		// Token: 0x17000C64 RID: 3172
		// (get) Token: 0x0600593E RID: 22846 RVA: 0x00015E88 File Offset: 0x00014088
		// (set) Token: 0x0600593F RID: 22847 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C64")]
		public bool Interactable
		{
			[Token(Token = "0x600593E")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600593F")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C65 RID: 3173
		// (get) Token: 0x06005940 RID: 22848 RVA: 0x00015EA0 File Offset: 0x000140A0
		// (set) Token: 0x06005941 RID: 22849 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C65")]
		public float CurrentStirringSpeed
		{
			[Token(Token = "0x6005940")]
			[Address(RVA = "0x485C90", Offset = "0x484690", VA = "0x180485C90")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005941")]
			[Address(RVA = "0x485CD0", Offset = "0x4846D0", VA = "0x180485CD0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x06005942 RID: 22850 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005942")]
		[Address(RVA = "0xA3D3A0", Offset = "0xA3BDA0", VA = "0x180A3D3A0")]
		private void Start()
		{
		}

		// Token: 0x06005943 RID: 22851 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005943")]
		[Address(RVA = "0xA3D4C0", Offset = "0xA3BEC0", VA = "0x180A3D4C0")]
		private void Update()
		{
		}

		// Token: 0x06005944 RID: 22852 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005944")]
		[Address(RVA = "0xA3CD60", Offset = "0xA3B760", VA = "0x180A3CD60")]
		private void LateUpdate()
		{
		}

		// Token: 0x06005945 RID: 22853 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005945")]
		[Address(RVA = "0xA28E50", Offset = "0xA27850", VA = "0x180A28E50")]
		public void SetInteractable(bool e)
		{
		}

		// Token: 0x06005946 RID: 22854 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005946")]
		[Address(RVA = "0xA3C9B0", Offset = "0xA3B3B0", VA = "0x180A3C9B0")]
		public void ClickStart(RaycastHit hit)
		{
		}

		// Token: 0x06005947 RID: 22855 RVA: 0x00015EB8 File Offset: 0x000140B8
		[Token(Token = "0x6005947")]
		[Address(RVA = "0xA3CAB0", Offset = "0xA3B4B0", VA = "0x180A3CAB0")]
		private Vector3 GetPlaneHit()
		{
			return default(Vector3);
		}

		// Token: 0x06005948 RID: 22856 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005948")]
		[Address(RVA = "0xA3C9A0", Offset = "0xA3B3A0", VA = "0x180A3C9A0")]
		public void ClickEnd()
		{
		}

		// Token: 0x06005949 RID: 22857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005949")]
		[Address(RVA = "0xA3CA50", Offset = "0xA3B450", VA = "0x180A3CA50")]
		public void Destroy()
		{
		}

		// Token: 0x0600594A RID: 22858 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600594A")]
		[Address(RVA = "0xA3D5F0", Offset = "0xA3BFF0", VA = "0x180A3D5F0")]
		public StirringRod()
		{
		}

		// Token: 0x040041A0 RID: 16800
		[Token(Token = "0x40041A0")]
		public const float MAX_STIR_RATE = 20f;

		// Token: 0x040041A1 RID: 16801
		[Token(Token = "0x40041A1")]
		public const float MAX_PIVOT_ANGLE = 7f;

		// Token: 0x040041A4 RID: 16804
		[Token(Token = "0x40041A4")]
		[FieldOffset(Offset = "0x28")]
		public float LerpSpeed;

		// Token: 0x040041A5 RID: 16805
		[Token(Token = "0x40041A5")]
		[FieldOffset(Offset = "0x30")]
		[Header("References")]
		public Clickable Clickable;

		// Token: 0x040041A6 RID: 16806
		[Token(Token = "0x40041A6")]
		[FieldOffset(Offset = "0x38")]
		public Transform PlaneNormal;

		// Token: 0x040041A7 RID: 16807
		[Token(Token = "0x40041A7")]
		[FieldOffset(Offset = "0x40")]
		public Transform Container;

		// Token: 0x040041A8 RID: 16808
		[Token(Token = "0x40041A8")]
		[FieldOffset(Offset = "0x48")]
		public Transform RodPivot;

		// Token: 0x040041A9 RID: 16809
		[Token(Token = "0x40041A9")]
		[FieldOffset(Offset = "0x50")]
		public AudioSourceController StirSound;

		// Token: 0x040041AA RID: 16810
		[Token(Token = "0x40041AA")]
		[FieldOffset(Offset = "0x58")]
		private Vector3 clickOffset;

		// Token: 0x040041AB RID: 16811
		[Token(Token = "0x40041AB")]
		[FieldOffset(Offset = "0x64")]
		private bool isMoving;
	}
}
