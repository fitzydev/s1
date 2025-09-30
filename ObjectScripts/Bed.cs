using System;
using FishNet.Object;
using Il2CppDummyDll;
using ScheduleOne.Employees;
using ScheduleOne.Interaction;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000C76 RID: 3190
	[Token(Token = "0x2000C76")]
	public class Bed : NetworkBehaviour
	{
		// Token: 0x17000BDC RID: 3036
		// (get) Token: 0x06005652 RID: 22098 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BDC")]
		public Employee AssignedEmployee
		{
			[Token(Token = "0x6005652")]
			[Address(RVA = "0x9C44D0", Offset = "0x9C2ED0", VA = "0x1809C44D0")]
			get
			{
				return null;
			}
		}

		// Token: 0x06005653 RID: 22099 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005653")]
		[Address(RVA = "0x9C3B80", Offset = "0x9C2580", VA = "0x1809C3B80", Slot = "19")]
		public virtual void Awake()
		{
		}

		// Token: 0x06005654 RID: 22100 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005654")]
		[Address(RVA = "0x9C41E0", Offset = "0x9C2BE0", VA = "0x1809C41E0")]
		public void Hovered()
		{
		}

		// Token: 0x06005655 RID: 22101 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005655")]
		[Address(RVA = "0x9C43C0", Offset = "0x9C2DC0", VA = "0x1809C43C0")]
		public void Interacted()
		{
		}

		// Token: 0x06005656 RID: 22102 RVA: 0x00015630 File Offset: 0x00013830
		[Token(Token = "0x6005656")]
		[Address(RVA = "0x9C3CC0", Offset = "0x9C26C0", VA = "0x1809C3CC0")]
		private bool CanSleep(out string noSleepReason)
		{
			return default(bool);
		}

		// Token: 0x06005657 RID: 22103 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005657")]
		[Address(RVA = "0x9C3A70", Offset = "0x9C2470", VA = "0x1809C3A70")]
		public void UpdateMaterial()
		{
		}

		// Token: 0x06005658 RID: 22104 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005658")]
		[Address(RVA = "0x606820", Offset = "0x605220", VA = "0x180606820")]
		public Bed()
		{
		}

		// Token: 0x06005659 RID: 22105 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005659")]
		[Address(RVA = "0x9C44B0", Offset = "0x9C2EB0", VA = "0x1809C44B0", Slot = "20")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600565A RID: 22106 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565A")]
		[Address(RVA = "0x9C4490", Offset = "0x9C2E90", VA = "0x1809C4490", Slot = "21")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600565B RID: 22107 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565B")]
		[Address(RVA = "0x6783D0", Offset = "0x676DD0", VA = "0x1806783D0", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600565C RID: 22108 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600565C")]
		[Address(RVA = "0x9C3A70", Offset = "0x9C2470", VA = "0x1809C3A70")]
		private void Awake_UserLogic_ScheduleOne.ObjectScripts.Bed_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003FF8 RID: 16376
		[Token(Token = "0x4003FF8")]
		public const int MIN_SLEEP_TIME = 1800;

		// Token: 0x04003FF9 RID: 16377
		[Token(Token = "0x4003FF9")]
		public const float SLEEP_TIME_SCALE = 1f;

		// Token: 0x04003FFA RID: 16378
		[Token(Token = "0x4003FFA")]
		[FieldOffset(Offset = "0x118")]
		[Header("References")]
		[SerializeField]
		protected InteractableObject intObj;

		// Token: 0x04003FFB RID: 16379
		[Token(Token = "0x4003FFB")]
		[FieldOffset(Offset = "0x120")]
		public EmployeeHome EmployeeStationThing;

		// Token: 0x04003FFC RID: 16380
		[Token(Token = "0x4003FFC")]
		[FieldOffset(Offset = "0x128")]
		public MeshRenderer BlanketMesh;

		// Token: 0x04003FFD RID: 16381
		[Token(Token = "0x4003FFD")]
		[FieldOffset(Offset = "0x130")]
		[Header("Materials")]
		public Material DefaultBlanket;

		// Token: 0x04003FFE RID: 16382
		[Token(Token = "0x4003FFE")]
		[FieldOffset(Offset = "0x138")]
		public Material BotanistBlanket;

		// Token: 0x04003FFF RID: 16383
		[Token(Token = "0x4003FFF")]
		[FieldOffset(Offset = "0x140")]
		public Material ChemistBlanket;

		// Token: 0x04004000 RID: 16384
		[Token(Token = "0x4004000")]
		[FieldOffset(Offset = "0x148")]
		public Material PackagerBlanket;

		// Token: 0x04004001 RID: 16385
		[Token(Token = "0x4004001")]
		[FieldOffset(Offset = "0x150")]
		public Material CleanerBlanket;

		// Token: 0x04004002 RID: 16386
		[Token(Token = "0x4004002")]
		[FieldOffset(Offset = "0x158")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted;

		// Token: 0x04004003 RID: 16387
		[Token(Token = "0x4004003")]
		[FieldOffset(Offset = "0x159")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.BedAssembly-CSharp.dll_Excuted;
	}
}
