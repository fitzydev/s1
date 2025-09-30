using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.UI.Construction.Features;
using UnityEngine;

namespace ScheduleOne.Construction.Features
{
	// Token: 0x02000799 RID: 1945
	[Token(Token = "0x2000799")]
	public abstract class Feature : NetworkBehaviour
	{
		// Token: 0x06003476 RID: 13430 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003476")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003477 RID: 13431 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003477")]
		[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x06003478 RID: 13432 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003478")]
		[Address(RVA = "0x7A2BF0", Offset = "0x7A15F0", VA = "0x1807A2BF0", Slot = "20")]
		public virtual FI_Base CreateInterface(Transform parent)
		{
			return null;
		}

		// Token: 0x06003479 RID: 13433
		[Token(Token = "0x6003479")]
		public abstract void Default();

		// Token: 0x0600347A RID: 13434 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347A")]
		[Address(RVA = "0x7A2CE0", Offset = "0x7A16E0", VA = "0x1807A2CE0")]
		protected Feature()
		{
		}

		// Token: 0x0600347B RID: 13435 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347B")]
		[Address(RVA = "0x651F60", Offset = "0x650960", VA = "0x180651F60", Slot = "22")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600347C RID: 13436 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347C")]
		[Address(RVA = "0x7A2CC0", Offset = "0x7A16C0", VA = "0x1807A2CC0", Slot = "23")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600347D RID: 13437 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347D")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600347E RID: 13438 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600347E")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "24")]
		protected virtual void Awake_UserLogic_ScheduleOne.Construction.Features.Feature_Assembly-CSharp.dll()
		{
		}

		// Token: 0x0400247C RID: 9340
		[Token(Token = "0x400247C")]
		[FieldOffset(Offset = "0x118")]
		public string featureName;

		// Token: 0x0400247D RID: 9341
		[Token(Token = "0x400247D")]
		[FieldOffset(Offset = "0x120")]
		public Sprite featureIcon;

		// Token: 0x0400247E RID: 9342
		[Token(Token = "0x400247E")]
		[FieldOffset(Offset = "0x128")]
		public Transform featureIconLocation;

		// Token: 0x0400247F RID: 9343
		[Token(Token = "0x400247F")]
		[FieldOffset(Offset = "0x130")]
		public GameObject featureInterfacePrefab;

		// Token: 0x04002480 RID: 9344
		[Token(Token = "0x4002480")]
		[FieldOffset(Offset = "0x138")]
		public bool disableRoofDisibility;

		// Token: 0x04002481 RID: 9345
		[Token(Token = "0x4002481")]
		[FieldOffset(Offset = "0x139")]
		private bool NetworkInitialize___EarlyScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted;

		// Token: 0x04002482 RID: 9346
		[Token(Token = "0x4002482")]
		[FieldOffset(Offset = "0x13A")]
		private bool NetworkInitialize__LateScheduleOne.Construction.Features.FeatureAssembly-CSharp.dll_Excuted;
	}
}
