using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.Audio;
using ScheduleOne.DevUtilities;
using ScheduleOne.ItemFramework;
using ScheduleOne.Persistence;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Persistence.Loaders;
using UnityEngine;

namespace ScheduleOne.Money
{
	// Token: 0x02000C5D RID: 3165
	[Token(Token = "0x2000C5D")]
	public class MoneyManager : NetworkSingleton<MoneyManager>, IBaseSaveable, ISaveable
	{
		// Token: 0x060054E6 RID: 21734 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E6")]
		[Address(RVA = "0x9CA2B0", Offset = "0x9C8CB0", VA = "0x1809CA2B0")]
		public static string ApplyMoneyTextColor(string text)
		{
			return null;
		}

		// Token: 0x060054E7 RID: 21735 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E7")]
		[Address(RVA = "0x9CA260", Offset = "0x9C8C60", VA = "0x1809CA260")]
		public static string ApplyMoneyTextColorDarker(string text)
		{
			return null;
		}

		// Token: 0x060054E8 RID: 21736 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x60054E8")]
		[Address(RVA = "0x9CA300", Offset = "0x9C8D00", VA = "0x1809CA300")]
		public static string ApplyOnlineBalanceColor(string text)
		{
			return null;
		}

		// Token: 0x17000BA2 RID: 2978
		// (get) Token: 0x060054E9 RID: 21737 RVA: 0x00015210 File Offset: 0x00013410
		[Token(Token = "0x17000BA2")]
		public float LifetimeEarnings
		{
			[Token(Token = "0x60054E9")]
			[Address(RVA = "0x538610", Offset = "0x537010", VA = "0x180538610")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BA3 RID: 2979
		// (get) Token: 0x060054EA RID: 21738 RVA: 0x00015228 File Offset: 0x00013428
		// (set) Token: 0x060054EB RID: 21739 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BA3")]
		public float LastCalculatedNetworth
		{
			[Token(Token = "0x60054EA")]
			[Address(RVA = "0x716D70", Offset = "0x715770", VA = "0x180716D70")]
			[CompilerGenerated]
			get
			{
				return 0f;
			}
			[Token(Token = "0x60054EB")]
			[Address(RVA = "0x716EE0", Offset = "0x7158E0", VA = "0x180716EE0")]
			[CompilerGenerated]
			protected set
			{
			}
		}

		// Token: 0x17000BA4 RID: 2980
		// (get) Token: 0x060054EC RID: 21740 RVA: 0x00015240 File Offset: 0x00013440
		[Token(Token = "0x17000BA4")]
		public float cashBalance
		{
			[Token(Token = "0x60054EC")]
			[Address(RVA = "0x9CD600", Offset = "0x9CC000", VA = "0x1809CD600")]
			get
			{
				return 0f;
			}
		}

		// Token: 0x17000BA5 RID: 2981
		// (get) Token: 0x060054ED RID: 21741 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA5")]
		protected CashInstance cashInstance
		{
			[Token(Token = "0x60054ED")]
			[Address(RVA = "0x9CD620", Offset = "0x9CC020", VA = "0x1809CD620")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA6 RID: 2982
		// (get) Token: 0x060054EE RID: 21742 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA6")]
		public string SaveFolderName
		{
			[Token(Token = "0x60054EE")]
			[Address(RVA = "0x9CD5D0", Offset = "0x9CBFD0", VA = "0x1809CD5D0", Slot = "26")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA7 RID: 2983
		// (get) Token: 0x060054EF RID: 21743 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA7")]
		public string SaveFileName
		{
			[Token(Token = "0x60054EF")]
			[Address(RVA = "0x9CD5A0", Offset = "0x9CBFA0", VA = "0x1809CD5A0", Slot = "27")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA8 RID: 2984
		// (get) Token: 0x060054F0 RID: 21744 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000BA8")]
		public Loader Loader
		{
			[Token(Token = "0x60054F0")]
			[Address(RVA = "0x630180", Offset = "0x62EB80", VA = "0x180630180", Slot = "28")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000BA9 RID: 2985
		// (get) Token: 0x060054F1 RID: 21745 RVA: 0x00015258 File Offset: 0x00013458
		[Token(Token = "0x17000BA9")]
		public bool ShouldSaveUnderFolder
		{
			[Token(Token = "0x60054F1")]
			[Address(RVA = "0x4B7AD0", Offset = "0x4B64D0", VA = "0x1804B7AD0", Slot = "29")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000BAA RID: 2986
		// (get) Token: 0x060054F2 RID: 21746 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060054F3 RID: 21747 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BAA")]
		public List<string> LocalExtraFiles
		{
			[Token(Token = "0x60054F2")]
			[Address(RVA = "0x708B20", Offset = "0x707520", VA = "0x180708B20", Slot = "30")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054F3")]
			[Address(RVA = "0x708B30", Offset = "0x707530", VA = "0x180708B30", Slot = "31")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BAB RID: 2987
		// (get) Token: 0x060054F4 RID: 21748 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060054F5 RID: 21749 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BAB")]
		public List<string> LocalExtraFolders
		{
			[Token(Token = "0x60054F4")]
			[Address(RVA = "0x73CAF0", Offset = "0x73B4F0", VA = "0x18073CAF0", Slot = "32")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x60054F5")]
			[Address(RVA = "0x73CB00", Offset = "0x73B500", VA = "0x18073CB00", Slot = "33")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BAC RID: 2988
		// (get) Token: 0x060054F6 RID: 21750 RVA: 0x00015270 File Offset: 0x00013470
		// (set) Token: 0x060054F7 RID: 21751 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BAC")]
		public bool HasChanged
		{
			[Token(Token = "0x60054F6")]
			[Address(RVA = "0x778080", Offset = "0x776A80", VA = "0x180778080", Slot = "34")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x60054F7")]
			[Address(RVA = "0x7782E0", Offset = "0x776CE0", VA = "0x1807782E0", Slot = "35")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000BAD RID: 2989
		// (get) Token: 0x060054F8 RID: 21752 RVA: 0x00015288 File Offset: 0x00013488
		[Token(Token = "0x17000BAD")]
		public int LoadOrder
		{
			[Token(Token = "0x60054F8")]
			[Address(RVA = "0x778170", Offset = "0x776B70", VA = "0x180778170", Slot = "25")]
			[CompilerGenerated]
			get
			{
				return 0;
			}
		}

		// Token: 0x060054F9 RID: 21753 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054F9")]
		[Address(RVA = "0x9CA3A0", Offset = "0x9C8DA0", VA = "0x1809CA3A0", Slot = "20")]
		public override void Awake()
		{
		}

		// Token: 0x060054FA RID: 21754 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FA")]
		[Address(RVA = "0x9CB220", Offset = "0x9C9C20", VA = "0x1809CB220", Slot = "49")]
		public virtual void InitializeSaveable()
		{
		}

		// Token: 0x060054FB RID: 21755 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FB")]
		[Address(RVA = "0x9CD100", Offset = "0x9CBB00", VA = "0x1809CD100", Slot = "19")]
		protected override void Start()
		{
		}

		// Token: 0x060054FC RID: 21756 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FC")]
		[Address(RVA = "0x9CBEB0", Offset = "0x9CA8B0", VA = "0x1809CBEB0", Slot = "6")]
		public override void OnStartServer()
		{
		}

		// Token: 0x060054FD RID: 21757 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FD")]
		[Address(RVA = "0x9CBE10", Offset = "0x9CA810", VA = "0x1809CBE10", Slot = "11")]
		public override void OnStartClient()
		{
		}

		// Token: 0x060054FE RID: 21758 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FE")]
		[Address(RVA = "0x9CBB00", Offset = "0x9CA500", VA = "0x1809CBB00", Slot = "21")]
		protected override void OnDestroy()
		{
		}

		// Token: 0x060054FF RID: 21759 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60054FF")]
		[Address(RVA = "0x9CB4E0", Offset = "0x9C9EE0", VA = "0x1809CB4E0")]
		private void Loaded()
		{
		}

		// Token: 0x06005500 RID: 21760 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005500")]
		[Address(RVA = "0x9CD440", Offset = "0x9CBE40", VA = "0x1809CD440")]
		private void Update()
		{
		}

		// Token: 0x06005501 RID: 21761 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005501")]
		[Address(RVA = "0x9CB580", Offset = "0x9C9F80", VA = "0x1809CB580")]
		private void MinPass()
		{
		}

		// Token: 0x06005502 RID: 21762 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005502")]
		[Address(RVA = "0x9CAF00", Offset = "0x9C9900", VA = "0x1809CAF00")]
		public CashInstance GetCashInstance(float amount)
		{
			return null;
		}

		// Token: 0x06005503 RID: 21763 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005503")]
		[Address(RVA = "0x9CAAF0", Offset = "0x9C94F0", VA = "0x1809CAAF0")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void CreateOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06005504 RID: 21764 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005504")]
		[Address(RVA = "0x9CC1F0", Offset = "0x9CABF0", VA = "0x1809CC1F0")]
		[ObserversRpc]
		private void ReceiveOnlineTransaction(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06005505 RID: 21765 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005505")]
		[Address(RVA = "0x9CD090", Offset = "0x9CBA90", VA = "0x1809CD090")]
		protected IEnumerator ShowOnlineBalanceChange(RectTransform changeDisplay)
		{
			return null;
		}

		// Token: 0x06005506 RID: 21766 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005506")]
		[Address(RVA = "0x9CA840", Offset = "0x9C9240", VA = "0x1809CA840")]
		[ServerRpc(RequireOwnership = false)]
		public void ChangeLifetimeEarnings(float change)
		{
		}

		// Token: 0x06005507 RID: 21767 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005507")]
		[Address(RVA = "0x9CBF80", Offset = "0x9CA980", VA = "0x1809CBF80")]
		public void PlayCashSound()
		{
		}

		// Token: 0x06005508 RID: 21768 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005508")]
		[Address(RVA = "0x9CA420", Offset = "0x9C8E20", VA = "0x1809CA420")]
		public void ChangeCashBalance(float change, bool visualizeChange = true, bool playCashSound = false)
		{
		}

		// Token: 0x06005509 RID: 21769 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005509")]
		[Address(RVA = "0x9CD020", Offset = "0x9CBA20", VA = "0x1809CD020")]
		protected IEnumerator ShowCashChange(RectTransform changeDisplay)
		{
			return null;
		}

		// Token: 0x0600550A RID: 21770 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550A")]
		[Address(RVA = "0x9CACA0", Offset = "0x9C96A0", VA = "0x1809CACA0")]
		public static string FormatAmount(float amount, bool showDecimals = false, bool includeColor = false)
		{
			return null;
		}

		// Token: 0x0600550B RID: 21771 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600550B")]
		[Address(RVA = "0x9CB090", Offset = "0x9C9A90", VA = "0x1809CB090", Slot = "50")]
		public virtual string GetSaveString()
		{
			return null;
		}

		// Token: 0x0600550C RID: 21772 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550C")]
		[Address(RVA = "0x9CB2B0", Offset = "0x9C9CB0", VA = "0x1809CB2B0")]
		public void Load(MoneyData data)
		{
		}

		// Token: 0x0600550D RID: 21773 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550D")]
		[Address(RVA = "0x9CA980", Offset = "0x9C9380", VA = "0x1809CA980")]
		public void CheckNetworthAchievements()
		{
		}

		// Token: 0x0600550E RID: 21774 RVA: 0x000152A0 File Offset: 0x000134A0
		[Token(Token = "0x600550E")]
		[Address(RVA = "0x9CAFE0", Offset = "0x9C99E0", VA = "0x1809CAFE0")]
		public float GetNetWorth()
		{
			return 0f;
		}

		// Token: 0x0600550F RID: 21775 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600550F")]
		[Address(RVA = "0x9CD450", Offset = "0x9CBE50", VA = "0x1809CD450")]
		public MoneyManager()
		{
		}

		// Token: 0x06005510 RID: 21776 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005510")]
		[Address(RVA = "0x9CB800", Offset = "0x9CA200", VA = "0x1809CB800", Slot = "22")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x06005511 RID: 21777 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005511")]
		[Address(RVA = "0x9CB760", Offset = "0x9CA160", VA = "0x1809CB760", Slot = "23")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x06005512 RID: 21778 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005512")]
		[Address(RVA = "0x5B3020", Offset = "0x5B1A20", VA = "0x1805B3020", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x06005513 RID: 21779 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005513")]
		[Address(RVA = "0x9CCEB0", Offset = "0x9CB8B0", VA = "0x1809CCEB0")]
		private void RpcWriter___Server_CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06005514 RID: 21780 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005514")]
		[Address(RVA = "0x9CC1F0", Offset = "0x9CABF0", VA = "0x1809CC1F0")]
		public void RpcLogic___CreateOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06005515 RID: 21781 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005515")]
		[Address(RVA = "0x9CCDE0", Offset = "0x9CB7E0", VA = "0x1809CCDE0")]
		private void RpcReader___Server_CreateOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x06005516 RID: 21782 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005516")]
		[Address(RVA = "0x9CC1F0", Offset = "0x9CABF0", VA = "0x1809CC1F0")]
		private void RpcWriter___Observers_ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06005517 RID: 21783 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005517")]
		[Address(RVA = "0x9CC4E0", Offset = "0x9CAEE0", VA = "0x1809CC4E0")]
		private void RpcLogic___ReceiveOnlineTransaction_1419830531(string _transaction_Name, float _unit_Amount, float _quantity, string _transaction_Note)
		{
		}

		// Token: 0x06005518 RID: 21784 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005518")]
		[Address(RVA = "0x9CCB90", Offset = "0x9CB590", VA = "0x1809CCB90")]
		private void RpcReader___Observers_ReceiveOnlineTransaction_1419830531(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x06005519 RID: 21785 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005519")]
		[Address(RVA = "0x9CA840", Offset = "0x9C9240", VA = "0x1809CA840")]
		private void RpcWriter___Server_ChangeLifetimeEarnings_431000436(float change)
		{
		}

		// Token: 0x0600551A RID: 21786 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551A")]
		[Address(RVA = "0x9CC380", Offset = "0x9CAD80", VA = "0x1809CC380")]
		public void RpcLogic___ChangeLifetimeEarnings_431000436(float change)
		{
		}

		// Token: 0x0600551B RID: 21787 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600551B")]
		[Address(RVA = "0x9CCC50", Offset = "0x9CB650", VA = "0x1809CCC50")]
		private void RpcReader___Server_ChangeLifetimeEarnings_431000436(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x17000BAE RID: 2990
		// (get) Token: 0x0600551C RID: 21788 RVA: 0x000152B8 File Offset: 0x000134B8
		// (set) Token: 0x0600551D RID: 21789 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BAE")]
		public float SyncAccessor_onlineBalance
		{
			[Token(Token = "0x600551C")]
			[Address(RVA = "0x5381A0", Offset = "0x536BA0", VA = "0x1805381A0")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x600551D")]
			[Address(RVA = "0x9CD760", Offset = "0x9CC160", VA = "0x1809CD760")]
			set
			{
			}
		}

		// Token: 0x0600551E RID: 21790 RVA: 0x000152D0 File Offset: 0x000134D0
		[Token(Token = "0x600551E")]
		[Address(RVA = "0x9CC070", Offset = "0x9CAA70", VA = "0x1809CC070", Slot = "51")]
		public virtual bool ReadSyncVar___ScheduleOne.Money.MoneyManager(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000BAF RID: 2991
		// (get) Token: 0x0600551F RID: 21791 RVA: 0x000152E8 File Offset: 0x000134E8
		// (set) Token: 0x06005520 RID: 21792 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000BAF")]
		public float SyncAccessor_lifetimeEarnings
		{
			[Token(Token = "0x600551F")]
			[Address(RVA = "0x538610", Offset = "0x537010", VA = "0x180538610")]
			get
			{
				return 0f;
			}
			[Token(Token = "0x6005520")]
			[Address(RVA = "0x9CD6A0", Offset = "0x9CC0A0", VA = "0x1809CD6A0")]
			set
			{
			}
		}

		// Token: 0x06005521 RID: 21793 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005521")]
		[Address(RVA = "0x9CA350", Offset = "0x9C8D50", VA = "0x1809CA350", Slot = "52")]
		protected virtual void Awake_UserLogic_ScheduleOne.Money.MoneyManager_Assembly-CSharp.dll()
		{
		}

		// Token: 0x04003F06 RID: 16134
		[Token(Token = "0x4003F06")]
		public const string MONEY_TEXT_COLOR = "#54E717";

		// Token: 0x04003F07 RID: 16135
		[Token(Token = "0x4003F07")]
		public const string MONEY_TEXT_COLOR_DARKER = "#46CB4F";

		// Token: 0x04003F08 RID: 16136
		[Token(Token = "0x4003F08")]
		public const string ONLINE_BALANCE_COLOR = "#4CBFFF";

		// Token: 0x04003F09 RID: 16137
		[Token(Token = "0x4003F09")]
		[FieldOffset(Offset = "0x120")]
		public List<Transaction> ledger;

		// Token: 0x04003F0A RID: 16138
		[Token(Token = "0x4003F0A")]
		[FieldOffset(Offset = "0x128")]
		[SyncVar(/*Failed to decode CustomAttribute blob!*/)]
		public float onlineBalance;

		// Token: 0x04003F0B RID: 16139
		[Token(Token = "0x4003F0B")]
		[FieldOffset(Offset = "0x12C")]
		[SyncVar(/*Failed to decode CustomAttribute blob!*/)]
		public float lifetimeEarnings;

		// Token: 0x04003F0D RID: 16141
		[Token(Token = "0x4003F0D")]
		[FieldOffset(Offset = "0x138")]
		[SerializeField]
		protected AudioSourceController CashSound;

		// Token: 0x04003F0E RID: 16142
		[Token(Token = "0x4003F0E")]
		[FieldOffset(Offset = "0x140")]
		[Header("Prefabs")]
		[SerializeField]
		protected GameObject moneyChangePrefab;

		// Token: 0x04003F0F RID: 16143
		[Token(Token = "0x4003F0F")]
		[FieldOffset(Offset = "0x148")]
		[SerializeField]
		protected GameObject cashChangePrefab;

		// Token: 0x04003F10 RID: 16144
		[Token(Token = "0x4003F10")]
		[FieldOffset(Offset = "0x150")]
		public Sprite LaunderingNotificationIcon;

		// Token: 0x04003F11 RID: 16145
		[Token(Token = "0x4003F11")]
		[FieldOffset(Offset = "0x158")]
		public Action<MoneyManager.FloatContainer> onNetworthCalculation;

		// Token: 0x04003F12 RID: 16146
		[Token(Token = "0x4003F12")]
		[FieldOffset(Offset = "0x160")]
		private MoneyLoader loader;

		// Token: 0x04003F17 RID: 16151
		[Token(Token = "0x4003F17")]
		[FieldOffset(Offset = "0x180")]
		public SyncVar<float> syncVar___onlineBalance;

		// Token: 0x04003F18 RID: 16152
		[Token(Token = "0x4003F18")]
		[FieldOffset(Offset = "0x188")]
		public SyncVar<float> syncVar___lifetimeEarnings;

		// Token: 0x04003F19 RID: 16153
		[Token(Token = "0x4003F19")]
		[FieldOffset(Offset = "0x190")]
		private bool NetworkInitialize___EarlyScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x04003F1A RID: 16154
		[Token(Token = "0x4003F1A")]
		[FieldOffset(Offset = "0x191")]
		private bool NetworkInitialize__LateScheduleOne.Money.MoneyManagerAssembly-CSharp.dll_Excuted;

		// Token: 0x02000C5E RID: 3166
		[Token(Token = "0x2000C5E")]
		public class FloatContainer
		{
			// Token: 0x17000BB0 RID: 2992
			// (get) Token: 0x06005522 RID: 21794 RVA: 0x00015300 File Offset: 0x00013500
			// (set) Token: 0x06005523 RID: 21795 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x17000BB0")]
			public float value
			{
				[Token(Token = "0x6005522")]
				[Address(RVA = "0x4657B0", Offset = "0x4641B0", VA = "0x1804657B0")]
				[CompilerGenerated]
				get
				{
					return 0f;
				}
				[Token(Token = "0x6005523")]
				[Address(RVA = "0x493FC0", Offset = "0x4929C0", VA = "0x180493FC0")]
				[CompilerGenerated]
				private set
				{
				}
			}

			// Token: 0x06005524 RID: 21796 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005524")]
			[Address(RVA = "0x7E4910", Offset = "0x7E3310", VA = "0x1807E4910")]
			public void ChangeValue(float value)
			{
			}

			// Token: 0x06005525 RID: 21797 RVA: 0x00002053 File Offset: 0x00000253
			[Token(Token = "0x6005525")]
			[Address(RVA = "0x42D6A0", Offset = "0x42C0A0", VA = "0x18042D6A0")]
			public FloatContainer()
			{
			}
		}
	}
}
