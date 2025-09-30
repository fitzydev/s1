using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Dialogue;
using ScheduleOne.Management;
using ScheduleOne.NPCs;
using ScheduleOne.NPCs.Behaviour;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Property;
using UnityEngine;

namespace ScheduleOne.Employees
{
	// Token: 0x020005BE RID: 1470
	[Token(Token = "0x20005BE")]
	public class Employee : NPC
	{
		// Token: 0x170005E5 RID: 1509
		// (get) Token: 0x06002296 RID: 8854 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06002297 RID: 8855 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E5")]
		public Property AssignedProperty
		{
			[Token(Token = "0x6002296")]
			[Address(RVA = "0x689EF0", Offset = "0x6888F0", VA = "0x180689EF0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6002297")]
			[Address(RVA = "0x6941C0", Offset = "0x692BC0", VA = "0x1806941C0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005E6 RID: 1510
		// (get) Token: 0x06002298 RID: 8856 RVA: 0x0000AF08 File Offset: 0x00009108
		// (set) Token: 0x06002299 RID: 8857 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E6")]
		public int EmployeeIndex
		{
			[Token(Token = "0x6002298")]
			[Address(RVA = "0x694120", Offset = "0x692B20", VA = "0x180694120")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x6002299")]
			[Address(RVA = "0x6941E0", Offset = "0x692BE0", VA = "0x1806941E0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170005E7 RID: 1511
		// (get) Token: 0x0600229A RID: 8858 RVA: 0x0000AF20 File Offset: 0x00009120
		// (set) Token: 0x0600229B RID: 8859 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E7")]
		public bool PaidForToday
		{
			[Token(Token = "0x600229A")]
			[Address(RVA = "0x694190", Offset = "0x692B90", VA = "0x180694190")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600229B")]
			[Address(RVA = "0x694210", Offset = "0x692C10", VA = "0x180694210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005E8 RID: 1512
		// (get) Token: 0x0600229C RID: 8860 RVA: 0x0000AF38 File Offset: 0x00009138
		// (set) Token: 0x0600229D RID: 8861 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005E8")]
		public bool Fired
		{
			[Token(Token = "0x600229C")]
			[Address(RVA = "0x694140", Offset = "0x692B40", VA = "0x180694140")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600229D")]
			[Address(RVA = "0x6941F0", Offset = "0x692BF0", VA = "0x1806941F0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005E9 RID: 1513
		// (get) Token: 0x0600229E RID: 8862 RVA: 0x0000AF50 File Offset: 0x00009150
		[Token(Token = "0x170005E9")]
		public bool IsWaitingOutside
		{
			[Token(Token = "0x600229E")]
			[Address(RVA = "0x694160", Offset = "0x692B60", VA = "0x180694160")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170005EA RID: 1514
		// (get) Token: 0x0600229F RID: 8863 RVA: 0x0000AF68 File Offset: 0x00009168
		// (set) Token: 0x060022A0 RID: 8864 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EA")]
		public bool IsMale
		{
			[Token(Token = "0x600229F")]
			[Address(RVA = "0x694150", Offset = "0x692B50", VA = "0x180694150")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022A0")]
			[Address(RVA = "0x694200", Offset = "0x692C00", VA = "0x180694200")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EB RID: 1515
		// (get) Token: 0x060022A1 RID: 8865 RVA: 0x0000AF80 File Offset: 0x00009180
		// (set) Token: 0x060022A2 RID: 8866 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EB")]
		private protected int AppearanceIndex
		{
			[Token(Token = "0x60022A1")]
			[Address(RVA = "0x694110", Offset = "0x692B10", VA = "0x180694110")]
			[CompilerGenerated]
			protected get
			{
				return 0;
			}
			[Token(Token = "0x60022A2")]
			[Address(RVA = "0x6941B0", Offset = "0x692BB0", VA = "0x1806941B0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x170005EC RID: 1516
		// (get) Token: 0x060022A3 RID: 8867 RVA: 0x0000AF98 File Offset: 0x00009198
		[Token(Token = "0x170005EC")]
		public EEmployeeType EmployeeType
		{
			[Token(Token = "0x60022A3")]
			[Address(RVA = "0x694130", Offset = "0x692B30", VA = "0x180694130")]
			get
			{
				return EEmployeeType.Botanist;
			}
		}

		// Token: 0x170005ED RID: 1517
		// (get) Token: 0x060022A4 RID: 8868 RVA: 0x0000AFB0 File Offset: 0x000091B0
		// (set) Token: 0x060022A5 RID: 8869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005ED")]
		public int TimeSinceLastWorked
		{
			[Token(Token = "0x60022A4")]
			[Address(RVA = "0x6941A0", Offset = "0x692BA0", VA = "0x1806941A0")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
			[Token(Token = "0x60022A5")]
			[Address(RVA = "0x6942A0", Offset = "0x692CA0", VA = "0x1806942A0")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x060022A6 RID: 8870 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A6")]
		[Address(RVA = "0x6931D0", Offset = "0x691BD0", VA = "0x1806931D0", Slot = "70")]
		protected override void Start()
		{
		}

		// Token: 0x060022A7 RID: 8871 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A7")]
		[Address(RVA = "0x691300", Offset = "0x68FD00", VA = "0x180691300", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060022A8 RID: 8872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A8")]
		[Address(RVA = "0x691200", Offset = "0x68FC00", VA = "0x180691200", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x060022A9 RID: 8873 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022A9")]
		[Address(RVA = "0x6905E0", Offset = "0x68EFE0", VA = "0x1806905E0", Slot = "108")]
		[TargetRpc]
		[ObserversRpc(RunLocally = true)]
		public virtual void Initialize(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x060022AA RID: 8874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AA")]
		[Address(RVA = "0x68F790", Offset = "0x68E190", VA = "0x18068F790", Slot = "109")]
		protected virtual void AssignProperty(Property prop, bool warp)
		{
		}

		// Token: 0x060022AB RID: 8875 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AB")]
		[Address(RVA = "0x693C90", Offset = "0x692690", VA = "0x180693C90", Slot = "110")]
		protected virtual void UnassignProperty()
		{
		}

		// Token: 0x060022AC RID: 8876 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AC")]
		[Address(RVA = "0x692B20", Offset = "0x691520", VA = "0x180692B20")]
		[ServerRpc(RequireOwnership = false)]
		public void SendTransfer(string propertyCode)
		{
		}

		// Token: 0x060022AD RID: 8877 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AD")]
		[Address(RVA = "0x691B10", Offset = "0x690510", VA = "0x180691B10")]
		[ObserversRpc]
		private void TransferToProperty(string code)
		{
		}

		// Token: 0x060022AE RID: 8878 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AE")]
		[Address(RVA = "0x693A90", Offset = "0x692490", VA = "0x180693A90", Slot = "111")]
		protected virtual void TransferToProperty(Property prop)
		{
		}

		// Token: 0x060022AF RID: 8879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022AF")]
		[Address(RVA = "0x6904D0", Offset = "0x68EED0", VA = "0x1806904D0", Slot = "112")]
		protected virtual void InitializeInfo(string firstName, string lastName, string id)
		{
		}

		// Token: 0x060022B0 RID: 8880 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B0")]
		[Address(RVA = "0x690160", Offset = "0x68EB60", VA = "0x180690160", Slot = "113")]
		protected virtual void InitializeAppearance(bool male, int index)
		{
		}

		// Token: 0x060022B1 RID: 8881 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B1")]
		[Address(RVA = "0x68F9D0", Offset = "0x68E3D0", VA = "0x18068F9D0", Slot = "114")]
		protected virtual void CheckDialogueChoice(string choiceLabel)
		{
		}

		// Token: 0x060022B2 RID: 8882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B2")]
		[Address(RVA = "0x692A10", Offset = "0x691410", VA = "0x180692A10")]
		[ServerRpc(RequireOwnership = false)]
		public void SendFire()
		{
		}

		// Token: 0x060022B3 RID: 8883 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B3")]
		[Address(RVA = "0x6914F0", Offset = "0x68FEF0", VA = "0x1806914F0")]
		[ObserversRpc]
		private void ReceiveFire()
		{
		}

		// Token: 0x060022B4 RID: 8884 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B4")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "115")]
		protected virtual void ResetConfiguration()
		{
		}

		// Token: 0x060022B5 RID: 8885 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B5")]
		[Address(RVA = "0x68FB20", Offset = "0x68E520", VA = "0x18068FB20", Slot = "116")]
		protected virtual void Fire()
		{
		}

		// Token: 0x060022B6 RID: 8886 RVA: 0x0000AFC8 File Offset: 0x000091C8
		[Token(Token = "0x60022B6")]
		[Address(RVA = "0x68F910", Offset = "0x68E310", VA = "0x18068F910")]
		protected bool CanWork()
		{
			return default(bool);
		}

		// Token: 0x060022B7 RID: 8887 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B7")]
		[Address(RVA = "0x690F80", Offset = "0x68F980", VA = "0x180690F80", Slot = "71")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060022B8 RID: 8888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B8")]
		[Address(RVA = "0x693D40", Offset = "0x692740", VA = "0x180693D40", Slot = "117")]
		protected virtual void UpdateBehaviour()
		{
		}

		// Token: 0x060022B9 RID: 8889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022B9")]
		[Address(RVA = "0x690B30", Offset = "0x68F530", VA = "0x180690B30")]
		protected void MarkIsWorking()
		{
		}

		// Token: 0x060022BA RID: 8890 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BA")]
		[Address(RVA = "0x6930E0", Offset = "0x691AE0", VA = "0x1806930E0")]
		private void SetWaitOutside(bool wait)
		{
		}

		// Token: 0x060022BB RID: 8891 RVA: 0x0000AFE0 File Offset: 0x000091E0
		[Token(Token = "0x60022BB")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "118")]
		protected virtual bool ShouldIdle()
		{
			return default(bool);
		}

		// Token: 0x060022BC RID: 8892 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BC")]
		[Address(RVA = "0x690B40", Offset = "0x68F540", VA = "0x180690B40", Slot = "72")]
		protected override void MinPass()
		{
		}

		// Token: 0x060022BD RID: 8893 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BD")]
		[Address(RVA = "0x6911F0", Offset = "0x68FBF0", VA = "0x1806911F0")]
		private void OnSleepEnd()
		{
		}

		// Token: 0x060022BE RID: 8894 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022BE")]
		[Address(RVA = "0x6930D0", Offset = "0x691AD0", VA = "0x1806930D0")]
		public void SetIsPaid()
		{
		}

		// Token: 0x060022BF RID: 8895 RVA: 0x0000AFF8 File Offset: 0x000091F8
		[Token(Token = "0x60022BF")]
		[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "90")]
		public override bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x060022C0 RID: 8896 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C0")]
		[Address(RVA = "0x68FCD0", Offset = "0x68E6D0", VA = "0x18068FCD0", Slot = "94")]
		public override NPCData GetNPCData()
		{
			return null;
		}

		// Token: 0x060022C1 RID: 8897 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60022C1")]
		[Address(RVA = "0x68FC70", Offset = "0x68E670", VA = "0x18068FC70", Slot = "119")]
		public virtual EmployeeHome GetHome()
		{
			return null;
		}

		// Token: 0x060022C2 RID: 8898 RVA: 0x0000B010 File Offset: 0x00009210
		[Token(Token = "0x60022C2")]
		[Address(RVA = "0x690990", Offset = "0x68F390", VA = "0x180690990")]
		public bool IsPayAvailable()
		{
			return default(bool);
		}

		// Token: 0x060022C3 RID: 8899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C3")]
		[Address(RVA = "0x691610", Offset = "0x690010", VA = "0x180691610")]
		public void RemoveDailyWage()
		{
		}

		// Token: 0x060022C4 RID: 8900 RVA: 0x0000B028 File Offset: 0x00009228
		[Token(Token = "0x60022C4")]
		[Address(RVA = "0x68FEC0", Offset = "0x68E8C0", VA = "0x18068FEC0", Slot = "120")]
		public virtual bool GetWorkIssue(out DialogueContainer notWorkingReason)
		{
			return default(bool);
		}

		// Token: 0x060022C5 RID: 8901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C5")]
		[Address(RVA = "0x6930C0", Offset = "0x691AC0", VA = "0x1806930C0", Slot = "121")]
		public virtual void SetIdle(bool idle)
		{
		}

		// Token: 0x060022C6 RID: 8902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C6")]
		[Address(RVA = "0x690A30", Offset = "0x68F430", VA = "0x180690A30")]
		protected void LeavePropertyAndDespawn()
		{
		}

		// Token: 0x060022C7 RID: 8903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C7")]
		[Address(RVA = "0x693640", Offset = "0x692040", VA = "0x180693640")]
		[ObserversRpc(RunLocally = true)]
		public void SubmitNoWorkReason(string reason, string fix, int priority = 0)
		{
		}

		// Token: 0x060022C8 RID: 8904 RVA: 0x0000B040 File Offset: 0x00009240
		[Token(Token = "0x60022C8")]
		[Address(RVA = "0x693170", Offset = "0x691B70", VA = "0x180693170")]
		private bool ShouldShowNoWorkDialogue(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x060022C9 RID: 8905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022C9")]
		[Address(RVA = "0x691190", Offset = "0x68FB90", VA = "0x180691190")]
		private void OnNotWorkingDialogue()
		{
		}

		// Token: 0x060022CA RID: 8906 RVA: 0x0000B058 File Offset: 0x00009258
		[Token(Token = "0x60022CA")]
		[Address(RVA = "0x693160", Offset = "0x691B60", VA = "0x180693160")]
		private bool ShouldShowFireDialogue(bool enabled)
		{
			return default(bool);
		}

		// Token: 0x060022CB RID: 8907 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CB")]
		[Address(RVA = "0x6938E0", Offset = "0x6922E0", VA = "0x1806938E0")]
		private void TradeItems()
		{
		}

		// Token: 0x060022CC RID: 8908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CC")]
		[Address(RVA = "0x6937E0", Offset = "0x6921E0", VA = "0x1806937E0")]
		private void TradeItemsDone()
		{
		}

		// Token: 0x060022CD RID: 8909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CD")]
		[Address(RVA = "0x692E20", Offset = "0x691820", VA = "0x180692E20")]
		protected void SetDestination(ITransitEntity transitEntity, bool teleportIfFail = true)
		{
		}

		// Token: 0x060022CE RID: 8910 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CE")]
		[Address(RVA = "0x692ED0", Offset = "0x6918D0", VA = "0x180692ED0")]
		protected void SetDestination(Vector3 position, bool teleportIfFail = true)
		{
		}

		// Token: 0x060022CF RID: 8911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022CF")]
		[Address(RVA = "0x694020", Offset = "0x692A20", VA = "0x180694020", Slot = "122")]
		protected virtual void WalkCallback(NPCMovement.WalkResult result)
		{
		}

		// Token: 0x060022D0 RID: 8912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D0")]
		[Address(RVA = "0x694070", Offset = "0x692A70", VA = "0x180694070")]
		public Employee()
		{
		}

		// Token: 0x060022D1 RID: 8913 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D1")]
		[Address(RVA = "0x690C30", Offset = "0x68F630", VA = "0x180690C30", Slot = "99")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x060022D2 RID: 8914 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D2")]
		[Address(RVA = "0x690BD0", Offset = "0x68F5D0", VA = "0x180690BD0", Slot = "100")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x060022D3 RID: 8915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D3")]
		[Address(RVA = "0x687D80", Offset = "0x686780", VA = "0x180687D80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x060022D4 RID: 8916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D4")]
		[Address(RVA = "0x6926C0", Offset = "0x6910C0", VA = "0x1806926C0")]
		private void RpcWriter___Observers_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x060022D5 RID: 8917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D5")]
		[Address(RVA = "0x6916C0", Offset = "0x6900C0", VA = "0x1806916C0", Slot = "123")]
		public virtual void RpcLogic___Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x060022D6 RID: 8918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D6")]
		[Address(RVA = "0x691F50", Offset = "0x690950", VA = "0x180691F50")]
		private void RpcReader___Observers_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060022D7 RID: 8919 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D7")]
		[Address(RVA = "0x692C50", Offset = "0x691650", VA = "0x180692C50")]
		private void RpcWriter___Target_Initialize_2260823878(NetworkConnection conn, string firstName, string lastName, string id, string guid, string propertyID, bool male, int appearanceIndex)
		{
		}

		// Token: 0x060022D8 RID: 8920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D8")]
		[Address(RVA = "0x692590", Offset = "0x690F90", VA = "0x180692590")]
		private void RpcReader___Target_Initialize_2260823878(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060022D9 RID: 8921 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022D9")]
		[Address(RVA = "0x692B20", Offset = "0x691520", VA = "0x180692B20")]
		private void RpcWriter___Server_SendTransfer_3615296227(string propertyCode)
		{
		}

		// Token: 0x060022DA RID: 8922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DA")]
		[Address(RVA = "0x691B10", Offset = "0x690510", VA = "0x180691B10")]
		public void RpcLogic___SendTransfer_3615296227(string propertyCode)
		{
		}

		// Token: 0x060022DB RID: 8923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DB")]
		[Address(RVA = "0x692420", Offset = "0x690E20", VA = "0x180692420")]
		private void RpcReader___Server_SendTransfer_3615296227(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060022DC RID: 8924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DC")]
		[Address(RVA = "0x691B10", Offset = "0x690510", VA = "0x180691B10")]
		private void RpcWriter___Observers_TransferToProperty_3615296227(string code)
		{
		}

		// Token: 0x060022DD RID: 8925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DD")]
		[Address(RVA = "0x691E00", Offset = "0x690800", VA = "0x180691E00")]
		private void RpcLogic___TransferToProperty_3615296227(string code)
		{
		}

		// Token: 0x060022DE RID: 8926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DE")]
		[Address(RVA = "0x692170", Offset = "0x690B70", VA = "0x180692170")]
		private void RpcReader___Observers_TransferToProperty_3615296227(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060022DF RID: 8927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022DF")]
		[Address(RVA = "0x692A10", Offset = "0x691410", VA = "0x180692A10")]
		private void RpcWriter___Server_SendFire_2166136261()
		{
		}

		// Token: 0x060022E0 RID: 8928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E0")]
		[Address(RVA = "0x6914F0", Offset = "0x68FEF0", VA = "0x1806914F0")]
		public void RpcLogic___SendFire_2166136261()
		{
		}

		// Token: 0x060022E1 RID: 8929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E1")]
		[Address(RVA = "0x6922F0", Offset = "0x690CF0", VA = "0x1806922F0")]
		private void RpcReader___Server_SendFire_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060022E2 RID: 8930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E2")]
		[Address(RVA = "0x6914F0", Offset = "0x68FEF0", VA = "0x1806914F0")]
		private void RpcWriter___Observers_ReceiveFire_2166136261()
		{
		}

		// Token: 0x060022E3 RID: 8931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E3")]
		[Address(RVA = "0x691AF0", Offset = "0x6904F0", VA = "0x180691AF0")]
		private void RpcLogic___ReceiveFire_2166136261()
		{
		}

		// Token: 0x060022E4 RID: 8932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E4")]
		[Address(RVA = "0x692080", Offset = "0x690A80", VA = "0x180692080")]
		private void RpcReader___Observers_ReceiveFire_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060022E5 RID: 8933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E5")]
		[Address(RVA = "0x692890", Offset = "0x691290", VA = "0x180692890")]
		private void RpcWriter___Observers_SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		// Token: 0x060022E6 RID: 8934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E6")]
		[Address(RVA = "0x691C50", Offset = "0x690650", VA = "0x180691C50")]
		public void RpcLogic___SubmitNoWorkReason_15643032(string reason, string fix, int priority = 0)
		{
		}

		// Token: 0x060022E7 RID: 8935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022E7")]
		[Address(RVA = "0x6920C0", Offset = "0x690AC0", VA = "0x1806920C0")]
		private void RpcReader___Observers_SubmitNoWorkReason_15643032(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x170005EE RID: 1518
		// (get) Token: 0x060022E8 RID: 8936 RVA: 0x0000B070 File Offset: 0x00009270
		// (set) Token: 0x060022E9 RID: 8937 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170005EE")]
		public bool SyncAccessor_<PaidForToday>k__BackingField
		{
			[Token(Token = "0x60022E8")]
			[Address(RVA = "0x694190", Offset = "0x692B90", VA = "0x180694190")]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60022E9")]
			[Address(RVA = "0x6942B0", Offset = "0x692CB0", VA = "0x1806942B0")]
			set
			{
			}
		}

		// Token: 0x060022EA RID: 8938 RVA: 0x0000B088 File Offset: 0x00009288
		[Token(Token = "0x60022EA")]
		[Address(RVA = "0x6913B0", Offset = "0x68FDB0", VA = "0x1806913B0", Slot = "124")]
		public virtual bool ReadSyncVar___ScheduleOne.Employees.Employee(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60022EB")]
		[Address(RVA = "0x68F8C0", Offset = "0x68E2C0", VA = "0x18068F8C0", Slot = "64")]
		public override void Awake()
		{
		}

		// Token: 0x04001B7F RID: 7039
		[Token(Token = "0x4001B7F")]
		public const int MAX_CONSECUTIVE_PATHING_FAILURES = 5;

		// Token: 0x04001B80 RID: 7040
		[Token(Token = "0x4001B80")]
		[FieldOffset(Offset = "0x2F0")]
		public bool DEBUG;

		// Token: 0x04001B87 RID: 7047
		[Token(Token = "0x4001B87")]
		[FieldOffset(Offset = "0x30C")]
		[SerializeField]
		protected EEmployeeType Type;

		// Token: 0x04001B88 RID: 7048
		[Token(Token = "0x4001B88")]
		[FieldOffset(Offset = "0x310")]
		[Header("Payment")]
		public float SigningFee;

		// Token: 0x04001B89 RID: 7049
		[Token(Token = "0x4001B89")]
		[FieldOffset(Offset = "0x314")]
		public float DailyWage;

		// Token: 0x04001B8A RID: 7050
		[Token(Token = "0x4001B8A")]
		[FieldOffset(Offset = "0x318")]
		[Header("References")]
		public IdleBehaviour WaitOutside;

		// Token: 0x04001B8B RID: 7051
		[Token(Token = "0x4001B8B")]
		[FieldOffset(Offset = "0x320")]
		public MoveItemBehaviour MoveItemBehaviour;

		// Token: 0x04001B8C RID: 7052
		[Token(Token = "0x4001B8C")]
		[FieldOffset(Offset = "0x328")]
		public DialogueContainer BedNotAssignedDialogue;

		// Token: 0x04001B8D RID: 7053
		[Token(Token = "0x4001B8D")]
		[FieldOffset(Offset = "0x330")]
		public DialogueContainer NotPaidDialogue;

		// Token: 0x04001B8E RID: 7054
		[Token(Token = "0x4001B8E")]
		[FieldOffset(Offset = "0x338")]
		public DialogueContainer WorkIssueDialogueTemplate;

		// Token: 0x04001B8F RID: 7055
		[Token(Token = "0x4001B8F")]
		[FieldOffset(Offset = "0x340")]
		public DialogueContainer FireDialogue;

		// Token: 0x04001B90 RID: 7056
		[Token(Token = "0x4001B90")]
		[FieldOffset(Offset = "0x348")]
		public DialogueContainer TransferDialogue;

		// Token: 0x04001B91 RID: 7057
		[Token(Token = "0x4001B91")]
		[FieldOffset(Offset = "0x350")]
		private List<Employee.NoWorkReason> WorkIssues;

		// Token: 0x04001B93 RID: 7059
		[Token(Token = "0x4001B93")]
		[FieldOffset(Offset = "0x35C")]
		protected bool initialized;

		// Token: 0x04001B94 RID: 7060
		[Token(Token = "0x4001B94")]
		[FieldOffset(Offset = "0x360")]
		protected int consecutivePathingFailures;

		// Token: 0x04001B95 RID: 7061
		[Token(Token = "0x4001B95")]
		[FieldOffset(Offset = "0x364")]
		private float timeOnLastPathingFailure;

		// Token: 0x04001B96 RID: 7062
		[Token(Token = "0x4001B96")]
		[FieldOffset(Offset = "0x368")]
		private Transform cachedNPCSpawnPoint;

		// Token: 0x04001B97 RID: 7063
		[Token(Token = "0x4001B97")]
		[FieldOffset(Offset = "0x370")]
		public SyncVar<bool> syncVar___<PaidForToday>k__BackingField;

		// Token: 0x04001B98 RID: 7064
		[Token(Token = "0x4001B98")]
		[FieldOffset(Offset = "0x378")]
		private bool NetworkInitialize___EarlyScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted;

		// Token: 0x04001B99 RID: 7065
		[Token(Token = "0x4001B99")]
		[FieldOffset(Offset = "0x379")]
		private bool NetworkInitialize__LateScheduleOne.Employees.EmployeeAssembly-CSharp.dll_Excuted;

		// Token: 0x020005BF RID: 1471
		[Token(Token = "0x20005BF")]
		public class NoWorkReason
		{
			// Token: 0x060022EC RID: 8940 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x60022EC")]
			[Address(RVA = "0x6CDDF0", Offset = "0x6CC7F0", VA = "0x1806CDDF0")]
			public NoWorkReason(string reason, string fix, int priority)
			{
			}

			// Token: 0x04001B9A RID: 7066
			[Token(Token = "0x4001B9A")]
			[FieldOffset(Offset = "0x10")]
			public string Reason;

			// Token: 0x04001B9B RID: 7067
			[Token(Token = "0x4001B9B")]
			[FieldOffset(Offset = "0x18")]
			public string Fix;

			// Token: 0x04001B9C RID: 7068
			[Token(Token = "0x4001B9C")]
			[FieldOffset(Offset = "0x20")]
			public int Priority;
		}
	}
}
