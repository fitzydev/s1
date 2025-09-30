using System;
using Il2CppDummyDll;
using ScheduleOne.PlayerTasks;
using ScheduleOne.Tools;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CB2 RID: 3250
	[Token(Token = "0x2000CB2")]
	public class LabOvenHammer : MonoBehaviour
	{
		// Token: 0x06005A99 RID: 23193 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A99")]
		[Address(RVA = "0xA290F0", Offset = "0xA27AF0", VA = "0x180A290F0")]
		private void Start()
		{
		}

		// Token: 0x06005A9A RID: 23194 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9A")]
		[Address(RVA = "0xA29150", Offset = "0xA27B50", VA = "0x180A29150")]
		private void Update()
		{
		}

		// Token: 0x06005A9B RID: 23195 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9B")]
		[Address(RVA = "0xA29090", Offset = "0xA27A90", VA = "0x180A29090")]
		private void OnCollisionEnter(Collision collision)
		{
		}

		// Token: 0x06005A9C RID: 23196 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005A9C")]
		[Address(RVA = "0xA292A0", Offset = "0xA27CA0", VA = "0x180A292A0")]
		public LabOvenHammer()
		{
		}

		// Token: 0x0400424F RID: 16975
		[Token(Token = "0x400424F")]
		[FieldOffset(Offset = "0x20")]
		public Draggable Draggable;

		// Token: 0x04004250 RID: 16976
		[Token(Token = "0x4004250")]
		[FieldOffset(Offset = "0x28")]
		public DraggableConstraint Constraint;

		// Token: 0x04004251 RID: 16977
		[Token(Token = "0x4004251")]
		[FieldOffset(Offset = "0x30")]
		public RotateRigidbodyToTarget Rotator;

		// Token: 0x04004252 RID: 16978
		[Token(Token = "0x4004252")]
		[FieldOffset(Offset = "0x38")]
		public Transform CoM;

		// Token: 0x04004253 RID: 16979
		[Token(Token = "0x4004253")]
		[FieldOffset(Offset = "0x40")]
		public Transform ImpactPoint;

		// Token: 0x04004254 RID: 16980
		[Token(Token = "0x4004254")]
		[FieldOffset(Offset = "0x48")]
		public SmoothedVelocityCalculator VelocityCalculator;

		// Token: 0x04004255 RID: 16981
		[Token(Token = "0x4004255")]
		[FieldOffset(Offset = "0x50")]
		[Header("Settings")]
		public float MinHeight;

		// Token: 0x04004256 RID: 16982
		[Token(Token = "0x4004256")]
		[FieldOffset(Offset = "0x54")]
		public float MaxHeight;

		// Token: 0x04004257 RID: 16983
		[Token(Token = "0x4004257")]
		[FieldOffset(Offset = "0x58")]
		public float MinAngle;

		// Token: 0x04004258 RID: 16984
		[Token(Token = "0x4004258")]
		[FieldOffset(Offset = "0x5C")]
		public float MaxAngle;

		// Token: 0x04004259 RID: 16985
		[Token(Token = "0x4004259")]
		[FieldOffset(Offset = "0x60")]
		public UnityEvent<Collision> onCollision;
	}
}
