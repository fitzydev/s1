using System;
using System.Runtime.CompilerServices;
using Il2CppDummyDll;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Cutscenes
{
	// Token: 0x0200078F RID: 1935
	[Token(Token = "0x200078F")]
	[RequireComponent(typeof(Animation))]
	public class Cutscene : MonoBehaviour
	{
		// Token: 0x170007A1 RID: 1953
		// (get) Token: 0x06003439 RID: 13369 RVA: 0x0000E580 File Offset: 0x0000C780
		// (set) Token: 0x0600343A RID: 13370 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170007A1")]
		public bool IsPlaying
		{
			[Token(Token = "0x6003439")]
			[Address(RVA = "0x4B9020", Offset = "0x4B7A20", VA = "0x1804B9020")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600343A")]
			[Address(RVA = "0x4B9030", Offset = "0x4B7A30", VA = "0x1804B9030")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x0600343B RID: 13371 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343B")]
		[Address(RVA = "0x79EB30", Offset = "0x79D530", VA = "0x18079EB30", Slot = "4")]
		protected virtual void Awake()
		{
		}

		// Token: 0x0600343C RID: 13372 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343C")]
		[Address(RVA = "0x79EEF0", Offset = "0x79D8F0", VA = "0x18079EEF0")]
		private void LateUpdate()
		{
		}

		// Token: 0x0600343D RID: 13373 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343D")]
		[Address(RVA = "0x79F060", Offset = "0x79DA60", VA = "0x18079F060", Slot = "5")]
		public virtual void Play()
		{
		}

		// Token: 0x0600343E RID: 13374 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343E")]
		[Address(RVA = "0x79EB80", Offset = "0x79D580", VA = "0x18079EB80")]
		public void InvokeEnd()
		{
		}

		// Token: 0x0600343F RID: 13375 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600343F")]
		[Address(RVA = "0x79F400", Offset = "0x79DE00", VA = "0x18079F400")]
		public Cutscene()
		{
		}

		// Token: 0x04002452 RID: 9298
		[Token(Token = "0x4002452")]
		[FieldOffset(Offset = "0x28")]
		[Header("Settings")]
		public string Name;

		// Token: 0x04002453 RID: 9299
		[Token(Token = "0x4002453")]
		[FieldOffset(Offset = "0x30")]
		public bool DisablePlayerControl;

		// Token: 0x04002454 RID: 9300
		[Token(Token = "0x4002454")]
		[FieldOffset(Offset = "0x31")]
		public bool OverrideFOV;

		// Token: 0x04002455 RID: 9301
		[Token(Token = "0x4002455")]
		[FieldOffset(Offset = "0x34")]
		public float CameraFOV;

		// Token: 0x04002456 RID: 9302
		[Token(Token = "0x4002456")]
		[FieldOffset(Offset = "0x38")]
		[Header("References")]
		public Transform CameraControl;

		// Token: 0x04002457 RID: 9303
		[Token(Token = "0x4002457")]
		[FieldOffset(Offset = "0x40")]
		[Header("Events")]
		public UnityEvent onPlay;

		// Token: 0x04002458 RID: 9304
		[Token(Token = "0x4002458")]
		[FieldOffset(Offset = "0x48")]
		public UnityEvent onEnd;

		// Token: 0x04002459 RID: 9305
		[Token(Token = "0x4002459")]
		[FieldOffset(Offset = "0x50")]
		private Animation animation;
	}
}
