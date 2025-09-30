using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Delivery;
using ScheduleOne.Employees;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.Management;
using ScheduleOne.Map;
using ScheduleOne.Misc;
using ScheduleOne.Money;
using ScheduleOne.ObjectScripts;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;
using UnityEngine.Events;

namespace ScheduleOne.Property
{
	// Token: 0x020008B4 RID: 2228
	[Token(Token = "0x20008B4")]
	public class Property : NetworkBehaviour, ISaveable
	{
		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x06003D20 RID: 15648 RVA: 0x00010770 File Offset: 0x0000E970
		// (set) Token: 0x06003D21 RID: 15649 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A3")]
		public bool IsOwned
		{
			[Token(Token = "0x6003D20")]
			[Address(RVA = "0x538700", Offset = "0x537100", VA = "0x180538700")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D21")]
			[Address(RVA = "0x633830", Offset = "0x632230", VA = "0x180633830")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008A4 RID: 2212
		// (get) Token: 0x06003D22 RID: 15650 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D23 RID: 15651 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A4")]
		public List<Employee> Employees
		{
			[Token(Token = "0x6003D22")]
			[Address(RVA = "0x548950", Offset = "0x547350", VA = "0x180548950")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D23")]
			[Address(RVA = "0x5ADF40", Offset = "0x5AC940", VA = "0x1805ADF40")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008A5 RID: 2213
		// (get) Token: 0x06003D24 RID: 15652 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D25 RID: 15653 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A5")]
		public RectTransform WorldspaceUIContainer
		{
			[Token(Token = "0x6003D24")]
			[Address(RVA = "0x672D40", Offset = "0x671740", VA = "0x180672D40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D25")]
			[Address(RVA = "0x672DD0", Offset = "0x6717D0", VA = "0x180672DD0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x170008A6 RID: 2214
		// (get) Token: 0x06003D26 RID: 15654 RVA: 0x00010788 File Offset: 0x0000E988
		// (set) Token: 0x06003D27 RID: 15655 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008A6")]
		public bool IsContentCulled
		{
			[Token(Token = "0x6003D26")]
			[Address(RVA = "0x538220", Offset = "0x536C20", VA = "0x180538220")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D27")]
			[Address(RVA = "0x6CAFD0", Offset = "0x6C99D0", VA = "0x1806CAFD0")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008A7 RID: 2215
		// (get) Token: 0x06003D28 RID: 15656 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A7")]
		public string PropertyName
		{
			[Token(Token = "0x6003D28")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A8 RID: 2216
		// (get) Token: 0x06003D29 RID: 15657 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008A8")]
		public string PropertyCode
		{
			[Token(Token = "0x6003D29")]
			[Address(RVA = "0x63D950", Offset = "0x63C350", VA = "0x18063D950")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008A9 RID: 2217
		// (get) Token: 0x06003D2A RID: 15658 RVA: 0x000107A0 File Offset: 0x0000E9A0
		[Token(Token = "0x170008A9")]
		public int LoadingDockCount
		{
			[Token(Token = "0x6003D2A")]
			[Address(RVA = "0x84A230", Offset = "0x848C30", VA = "0x18084A230")]
			get
			{
				return 0;
			}
		}

		// Token: 0x170008AA RID: 2218
		// (get) Token: 0x06003D2B RID: 15659 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AA")]
		public string SaveFolderName
		{
			[Token(Token = "0x6003D2B")]
			[Address(RVA = "0x66EEE0", Offset = "0x66D8E0", VA = "0x18066EEE0", Slot = "19")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AB RID: 2219
		// (get) Token: 0x06003D2C RID: 15660 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AB")]
		public string SaveFileName
		{
			[Token(Token = "0x6003D2C")]
			[Address(RVA = "0x84A250", Offset = "0x848C50", VA = "0x18084A250", Slot = "20")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AC RID: 2220
		// (get) Token: 0x06003D2D RID: 15661 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x170008AC")]
		public Loader Loader
		{
			[Token(Token = "0x6003D2D")]
			[Address(RVA = "0x62FFB0", Offset = "0x62E9B0", VA = "0x18062FFB0", Slot = "21")]
			get
			{
				return null;
			}
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003D2E RID: 15662 RVA: 0x000107B8 File Offset: 0x0000E9B8
		[Token(Token = "0x170008AD")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x6003D2E")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "22")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003D2F RID: 15663 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D30 RID: 15664 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AE")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x6003D2F")]
			[Address(RVA = "0x62FCC0", Offset = "0x62E6C0", VA = "0x18062FCC0", Slot = "23")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D30")]
			[Address(RVA = "0x76B8B0", Offset = "0x76A2B0", VA = "0x18076B8B0", Slot = "24")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008AF RID: 2223
		// (get) Token: 0x06003D31 RID: 15665 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06003D32 RID: 15666 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008AF")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x6003D31")]
			[Address(RVA = "0x62FCB0", Offset = "0x62E6B0", VA = "0x18062FCB0", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6003D32")]
			[Address(RVA = "0x6302A0", Offset = "0x62ECA0", VA = "0x1806302A0", Slot = "26")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x170008B0 RID: 2224
		// (get) Token: 0x06003D33 RID: 15667 RVA: 0x000107D0 File Offset: 0x0000E9D0
		// (set) Token: 0x06003D34 RID: 15668 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x170008B0")]
		public bool HasChanged
		{
			[Token(Token = "0x6003D33")]
			[Address(RVA = "0x84A220", Offset = "0x848C20", VA = "0x18084A220", Slot = "27")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6003D34")]
			[Address(RVA = "0x84A260", Offset = "0x848C60", VA = "0x18084A260", Slot = "28")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06003D35 RID: 15669 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D35")]
		[Address(RVA = "0x846D40", Offset = "0x845740", VA = "0x180846D40", Slot = "42")]
		public virtual void Awake()
		{
		}

		// Token: 0x06003D36 RID: 15670 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D36")]
		[Address(RVA = "0x8476E0", Offset = "0x8460E0", VA = "0x1808476E0", Slot = "43")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x06003D37 RID: 15671 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D37")]
		[Address(RVA = "0x849700", Offset = "0x848100", VA = "0x180849700", Slot = "44")]
		protected virtual void Start()
		{
		}

		// Token: 0x06003D38 RID: 15672 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D38")]
		[Address(RVA = "0x846EE0", Offset = "0x8458E0", VA = "0x180846EE0", Slot = "45")]
		protected virtual void FixedUpdate()
		{
		}

		// Token: 0x06003D39 RID: 15673 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D39")]
		[Address(RVA = "0x845F30", Offset = "0x844930", VA = "0x180845F30")]
		public void AddConfigurable(IConfigurable configurable)
		{
		}

		// Token: 0x06003D3A RID: 15674 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3A")]
		[Address(RVA = "0x848690", Offset = "0x847090", VA = "0x180848690")]
		public void RemoveConfigurable(IConfigurable configurable)
		{
		}

		// Token: 0x06003D3B RID: 15675 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3B")]
		[Address(RVA = "0x849AA0", Offset = "0x8484A0", VA = "0x180849AA0")]
		private void UpdateCulling()
		{
		}

		// Token: 0x06003D3C RID: 15676 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3C")]
		[Address(RVA = "0x847EC0", Offset = "0x8468C0", VA = "0x180847EC0", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06003D3D RID: 15677 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3D")]
		[Address(RVA = "0x847CA0", Offset = "0x8466A0", VA = "0x180847CA0", Slot = "46")]
		protected virtual void OnDestroy()
		{
		}

		// Token: 0x06003D3E RID: 15678 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3E")]
		[Address(RVA = "0x847070", Offset = "0x845A70", VA = "0x180847070", Slot = "47")]
		protected virtual void GetNetworth(MoneyManager.FloatContainer container)
		{
		}

		// Token: 0x06003D3F RID: 15679 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D3F")]
		[Address(RVA = "0x847FC0", Offset = "0x8469C0", VA = "0x180847FC0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x06003D40 RID: 15680 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D40")]
		[Address(RVA = "0x849340", Offset = "0x847D40", VA = "0x180849340")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		protected void SetOwned_Server()
		{
		}

		// Token: 0x06003D41 RID: 15681 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D41")]
		[Address(RVA = "0x848080", Offset = "0x846A80", VA = "0x180848080")]
		[ObserversRpc(RunLocally = true, BufferLast = true)]
		private void ReceiveOwned_Networked()
		{
		}

		// Token: 0x06003D42 RID: 15682 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D42")]
		[Address(RVA = "0x8481B0", Offset = "0x846BB0", VA = "0x1808481B0", Slot = "48")]
		protected virtual void RecieveOwned()
		{
		}

		// Token: 0x06003D43 RID: 15683 RVA: 0x000107E8 File Offset: 0x0000E9E8
		[Token(Token = "0x6003D43")]
		[Address(RVA = "0x8496B0", Offset = "0x8480B0", VA = "0x1808496B0", Slot = "49")]
		public virtual bool ShouldSave()
		{
			return default(bool);
		}

		// Token: 0x06003D44 RID: 15684 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D44")]
		[Address(RVA = "0x849450", Offset = "0x847E50", VA = "0x180849450")]
		public void SetOwned()
		{
		}

		// Token: 0x06003D45 RID: 15685 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D45")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80")]
		public void SetBoundsVisible(bool vis)
		{
		}

		// Token: 0x06003D46 RID: 15686 RVA: 0x00010800 File Offset: 0x0000EA00
		[Token(Token = "0x6003D46")]
		[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "50")]
		public virtual bool CanBePurchased()
		{
			return default(bool);
		}

		// Token: 0x06003D47 RID: 15687 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D47")]
		[Address(RVA = "0x849120", Offset = "0x847B20", VA = "0x180849120", Slot = "51")]
		public virtual void SetContentCulled(bool culled)
		{
		}

		// Token: 0x06003D48 RID: 15688 RVA: 0x00010818 File Offset: 0x0000EA18
		[Token(Token = "0x6003D48")]
		[Address(RVA = "0x8485C0", Offset = "0x846FC0", VA = "0x1808485C0")]
		public int RegisterEmployee(Employee emp)
		{
			return 0;
		}

		// Token: 0x06003D49 RID: 15689 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D49")]
		[Address(RVA = "0x846D90", Offset = "0x845790", VA = "0x180846D90")]
		public void DeregisterEmployee(Employee emp)
		{
		}

		// Token: 0x06003D4A RID: 15690 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4A")]
		[Address(RVA = "0x849860", Offset = "0x848260", VA = "0x180849860")]
		private void ToggleableActioned(InteractableToggleable toggleable)
		{
		}

		// Token: 0x06003D4B RID: 15691 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4B")]
		[Address(RVA = "0x848D30", Offset = "0x847730", VA = "0x180848D30")]
		[ServerRpc(RequireOwnership = false)]
		public void SendToggleableState(int index, bool state)
		{
		}

		// Token: 0x06003D4C RID: 15692 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D4C")]
		[Address(RVA = "0x849460", Offset = "0x847E60", VA = "0x180849460")]
		[ObserversRpc]
		[TargetRpc]
		public void SetToggleableState(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x06003D4D RID: 15693 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4D")]
		[Address(RVA = "0x847230", Offset = "0x845C30", VA = "0x180847230", Slot = "52")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x06003D4E RID: 15694 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4E")]
		[Address(RVA = "0x846EF0", Offset = "0x8458F0", VA = "0x180846EF0")]
		protected List<DynamicSaveData> GetEmployeeSaveDatas()
		{
			return null;
		}

		// Token: 0x06003D4F RID: 15695 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D4F")]
		[Address(RVA = "0x8470B0", Offset = "0x845AB0", VA = "0x1808470B0")]
		protected List<DynamicSaveData> GetObjectSaveDatas()
		{
			return null;
		}

		// Token: 0x06003D50 RID: 15696 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D50")]
		[Address(RVA = "0x849D30", Offset = "0x848730", VA = "0x180849D30", Slot = "53")]
		public virtual List<string> WriteData(string parentFolderPath)
		{
			return null;
		}

		// Token: 0x06003D51 RID: 15697 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D51")]
		[Address(RVA = "0x42DA80", Offset = "0x42C480", VA = "0x18042DA80", Slot = "54")]
		public virtual void DeleteUnapprovedFiles(string parentFolderPath)
		{
		}

		// Token: 0x06003D52 RID: 15698 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D52")]
		[Address(RVA = "0x847940", Offset = "0x846340", VA = "0x180847940", Slot = "55")]
		public virtual void Load(PropertyData propertyData, string dataString)
		{
		}

		// Token: 0x06003D53 RID: 15699 RVA: 0x00010830 File Offset: 0x0000EA30
		[Token(Token = "0x6003D53")]
		[Address(RVA = "0x846DF0", Offset = "0x8457F0", VA = "0x180846DF0")]
		public bool DoBoundsContainPoint(Vector3 point)
		{
			return default(bool);
		}

		// Token: 0x06003D54 RID: 15700 RVA: 0x00010848 File Offset: 0x0000EA48
		[Token(Token = "0x6003D54")]
		[Address(RVA = "0x847770", Offset = "0x846170", VA = "0x180847770")]
		private bool IsPointInsideBox(Vector3 worldPoint, BoxCollider box)
		{
			return default(bool);
		}

		// Token: 0x06003D55 RID: 15701 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D55")]
		[Address(RVA = "0x847580", Offset = "0x845F80", VA = "0x180847580")]
		public List<Bed> GetUnassignedBeds()
		{
			return null;
		}

		// Token: 0x06003D56 RID: 15702 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D56")]
		public List<T> GetBuildablesOfType<T>() where T : BuildableItem
		{
			return null;
		}

		// Token: 0x06003D57 RID: 15703 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D57")]
		[Address(RVA = "0x849F20", Offset = "0x848920", VA = "0x180849F20")]
		public Property()
		{
		}

		// Token: 0x06003D5A RID: 15706 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6003D5A")]
		[Address(RVA = "0x849A30", Offset = "0x848430", VA = "0x180849A30")]
		[CompilerGenerated]
		private IEnumerator <RecieveOwned>g__Wait|92_0()
		{
			return null;
		}

		// Token: 0x06003D5C RID: 15708 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5C")]
		[Address(RVA = "0x847AF0", Offset = "0x8464F0", VA = "0x180847AF0", Slot = "56")]
		public virtual void NetworkInitialize___Early()
		{
		}

		// Token: 0x06003D5D RID: 15709 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5D")]
		[Address(RVA = "0x847AD0", Offset = "0x8464D0", VA = "0x180847AD0", Slot = "57")]
		public virtual void NetworkInitialize__Late()
		{
		}

		// Token: 0x06003D5E RID: 15710 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5E")]
		[Address(RVA = "0x825A80", Offset = "0x824480", VA = "0x180825A80", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06003D5F RID: 15711 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D5F")]
		[Address(RVA = "0x848EA0", Offset = "0x8478A0", VA = "0x180848EA0")]
		private void RpcWriter___Server_SetOwned_Server_2166136261()
		{
		}

		// Token: 0x06003D60 RID: 15712 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D60")]
		[Address(RVA = "0x848080", Offset = "0x846A80", VA = "0x180848080")]
		protected void RpcLogic___SetOwned_Server_2166136261()
		{
		}

		// Token: 0x06003D61 RID: 15713 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D61")]
		[Address(RVA = "0x848990", Offset = "0x847390", VA = "0x180848990")]
		private void RpcReader___Server_SetOwned_Server_2166136261(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D62 RID: 15714 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D62")]
		[Address(RVA = "0x848A90", Offset = "0x847490", VA = "0x180848A90")]
		private void RpcWriter___Observers_ReceiveOwned_Networked_2166136261()
		{
		}

		// Token: 0x06003D63 RID: 15715 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D63")]
		[Address(RVA = "0x848720", Offset = "0x847120", VA = "0x180848720")]
		private void RpcLogic___ReceiveOwned_Networked_2166136261()
		{
		}

		// Token: 0x06003D64 RID: 15716 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D64")]
		[Address(RVA = "0x8487E0", Offset = "0x8471E0", VA = "0x1808487E0")]
		private void RpcReader___Observers_ReceiveOwned_Networked_2166136261(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D65 RID: 15717 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D65")]
		[Address(RVA = "0x848D30", Offset = "0x847730", VA = "0x180848D30")]
		private void RpcWriter___Server_SendToggleableState_3658436649(int index, bool state)
		{
		}

		// Token: 0x06003D66 RID: 15718 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D66")]
		[Address(RVA = "0x848740", Offset = "0x847140", VA = "0x180848740")]
		public void RpcLogic___SendToggleableState_3658436649(int index, bool state)
		{
		}

		// Token: 0x06003D67 RID: 15719 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D67")]
		[Address(RVA = "0x8488E0", Offset = "0x8472E0", VA = "0x1808488E0")]
		private void RpcReader___Server_SendToggleableState_3658436649(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06003D68 RID: 15720 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D68")]
		[Address(RVA = "0x848BB0", Offset = "0x8475B0", VA = "0x180848BB0")]
		private void RpcWriter___Observers_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x06003D69 RID: 15721 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D69")]
		[Address(RVA = "0x848760", Offset = "0x847160", VA = "0x180848760")]
		public void RpcLogic___SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x06003D6A RID: 15722 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6A")]
		[Address(RVA = "0x848830", Offset = "0x847230", VA = "0x180848830")]
		private void RpcReader___Observers_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D6B RID: 15723 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6B")]
		[Address(RVA = "0x848FB0", Offset = "0x8479B0", VA = "0x180848FB0")]
		private void RpcWriter___Target_SetToggleableState_338960014(NetworkConnection conn, int index, bool state)
		{
		}

		// Token: 0x06003D6C RID: 15724 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6C")]
		[Address(RVA = "0x8489E0", Offset = "0x8473E0", VA = "0x1808489E0")]
		private void RpcReader___Target_SetToggleableState_338960014(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06003D6D RID: 15725 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6003D6D")]
		[Address(RVA = "0x846010", Offset = "0x844A10", VA = "0x180846010", Slot = "58")]
		protected virtual void Awake_UserLogic_ScheduleOne.Property.Property_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04002B31 RID: 11057
		[Token(Token = "0x4002B31")]
		[FieldOffset(Offset = "0x0")]
		public static List<Property> Properties;

		// Token: 0x04002B32 RID: 11058
		[Token(Token = "0x4002B32")]
		[FieldOffset(Offset = "0x8")]
		public static List<Property> UnownedProperties;

		// Token: 0x04002B33 RID: 11059
		[Token(Token = "0x4002B33")]
		[FieldOffset(Offset = "0x10")]
		public static List<Property> OwnedProperties;

		// Token: 0x04002B34 RID: 11060
		[Token(Token = "0x4002B34")]
		[FieldOffset(Offset = "0x18")]
		public static Property.PropertyChange onPropertyAcquired;

		// Token: 0x04002B35 RID: 11061
		[Token(Token = "0x4002B35")]
		[FieldOffset(Offset = "0x118")]
		public UnityEvent onThisPropertyAcquired;

		// Token: 0x04002B3A RID: 11066
		[Token(Token = "0x4002B3A")]
		[FieldOffset(Offset = "0x140")]
		[SerializeField]
		[Header("Settings")]
		protected string propertyName;

		// Token: 0x04002B3B RID: 11067
		[Token(Token = "0x4002B3B")]
		[FieldOffset(Offset = "0x148")]
		public bool AvailableInDemo;

		// Token: 0x04002B3C RID: 11068
		[Token(Token = "0x4002B3C")]
		[FieldOffset(Offset = "0x150")]
		[SerializeField]
		protected string propertyCode;

		// Token: 0x04002B3D RID: 11069
		[Token(Token = "0x4002B3D")]
		[FieldOffset(Offset = "0x158")]
		public float Price;

		// Token: 0x04002B3E RID: 11070
		[Token(Token = "0x4002B3E")]
		[FieldOffset(Offset = "0x15C")]
		public float DefaultRotation;

		// Token: 0x04002B3F RID: 11071
		[Token(Token = "0x4002B3F")]
		[FieldOffset(Offset = "0x160")]
		public int EmployeeCapacity;

		// Token: 0x04002B40 RID: 11072
		[Token(Token = "0x4002B40")]
		[FieldOffset(Offset = "0x164")]
		public bool OwnedByDefault;

		// Token: 0x04002B41 RID: 11073
		[Token(Token = "0x4002B41")]
		[FieldOffset(Offset = "0x168")]
		public string IsOwnedVariable;

		// Token: 0x04002B42 RID: 11074
		[Token(Token = "0x4002B42")]
		[FieldOffset(Offset = "0x170")]
		[Header("Culling Settings")]
		public bool ContentCullingEnabled;

		// Token: 0x04002B43 RID: 11075
		[Token(Token = "0x4002B43")]
		[FieldOffset(Offset = "0x174")]
		public float MinimumCullingDistance;

		// Token: 0x04002B44 RID: 11076
		[Token(Token = "0x4002B44")]
		[FieldOffset(Offset = "0x178")]
		public GameObject[] ObjectsToCull;

		// Token: 0x04002B45 RID: 11077
		[Token(Token = "0x4002B45")]
		[FieldOffset(Offset = "0x180")]
		[Header("References")]
		public PropertyContentsContainer Container;

		// Token: 0x04002B46 RID: 11078
		[Token(Token = "0x4002B46")]
		[FieldOffset(Offset = "0x188")]
		public Transform EmployeeContainer;

		// Token: 0x04002B47 RID: 11079
		[Token(Token = "0x4002B47")]
		[FieldOffset(Offset = "0x190")]
		public Transform SpawnPoint;

		// Token: 0x04002B48 RID: 11080
		[Token(Token = "0x4002B48")]
		[FieldOffset(Offset = "0x198")]
		public Transform InteriorSpawnPoint;

		// Token: 0x04002B49 RID: 11081
		[Token(Token = "0x4002B49")]
		[FieldOffset(Offset = "0x1A0")]
		public GameObject ForSaleSign;

		// Token: 0x04002B4A RID: 11082
		[Token(Token = "0x4002B4A")]
		[FieldOffset(Offset = "0x1A8")]
		public GameObject BoundingBox;

		// Token: 0x04002B4B RID: 11083
		[Token(Token = "0x4002B4B")]
		[FieldOffset(Offset = "0x1B0")]
		public POI PoI;

		// Token: 0x04002B4C RID: 11084
		[Token(Token = "0x4002B4C")]
		[FieldOffset(Offset = "0x1B8")]
		public Transform ListingPoster;

		// Token: 0x04002B4D RID: 11085
		[Token(Token = "0x4002B4D")]
		[FieldOffset(Offset = "0x1C0")]
		public Transform NPCSpawnPoint;

		// Token: 0x04002B4E RID: 11086
		[Token(Token = "0x4002B4E")]
		[FieldOffset(Offset = "0x1C8")]
		public Transform[] EmployeeIdlePoints;

		// Token: 0x04002B4F RID: 11087
		[Token(Token = "0x4002B4F")]
		[FieldOffset(Offset = "0x1D0")]
		public List<ModularSwitch> Switches;

		// Token: 0x04002B50 RID: 11088
		[Token(Token = "0x4002B50")]
		[FieldOffset(Offset = "0x1D8")]
		public List<InteractableToggleable> Toggleables;

		// Token: 0x04002B51 RID: 11089
		[Token(Token = "0x4002B51")]
		[FieldOffset(Offset = "0x1E0")]
		public PropertyDisposalArea DisposalArea;

		// Token: 0x04002B52 RID: 11090
		[Token(Token = "0x4002B52")]
		[FieldOffset(Offset = "0x1E8")]
		public LoadingDock[] LoadingDocks;

		// Token: 0x04002B53 RID: 11091
		[Token(Token = "0x4002B53")]
		[FieldOffset(Offset = "0x1F0")]
		[HideInInspector]
		public List<BuildableItem> BuildableItems;

		// Token: 0x04002B54 RID: 11092
		[Token(Token = "0x4002B54")]
		[FieldOffset(Offset = "0x1F8")]
		public List<IConfigurable> Configurables;

		// Token: 0x04002B55 RID: 11093
		[Token(Token = "0x4002B55")]
		[FieldOffset(Offset = "0x200")]
		private BoxCollider[] propertyBoundsColliders;

		// Token: 0x04002B56 RID: 11094
		[Token(Token = "0x4002B56")]
		[FieldOffset(Offset = "0x208")]
		private PropertyLoader loader;

		// Token: 0x04002B5A RID: 11098
		[Token(Token = "0x4002B5A")]
		[FieldOffset(Offset = "0x228")]
		private List<string> savedObjectPaths;

		// Token: 0x04002B5B RID: 11099
		[Token(Token = "0x4002B5B")]
		[FieldOffset(Offset = "0x230")]
		private List<string> savedEmployeePaths;

		// Token: 0x04002B5C RID: 11100
		[Token(Token = "0x4002B5C")]
		[FieldOffset(Offset = "0x238")]
		private bool NetworkInitialize___EarlyScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted;

		// Token: 0x04002B5D RID: 11101
		[Token(Token = "0x4002B5D")]
		[FieldOffset(Offset = "0x239")]
		private bool NetworkInitialize__LateScheduleOne.Property.PropertyAssembly-CSharp.dll_Excuted;

		// Token: 0x020008B5 RID: 2229
		// (Invoke) Token: 0x06003D6F RID: 15727
		[Token(Token = "0x20008B5")]
		public delegate void PropertyChange(Property property);
	}
}
