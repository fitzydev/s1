using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using FishNet.Connection;
using FishNet.Object;
using FishNet.Object.Synchronizing;
using FishNet.Serializing;
using FishNet.Transporting;
using Il2CppDummyDll;
using ScheduleOne.DevUtilities;
using ScheduleOne.EntityFramework;
using ScheduleOne.Interaction;
using ScheduleOne.ItemFramework;
using ScheduleOne.Management;
using ScheduleOne.Persistence.Datas;
using ScheduleOne.Storage;
using ScheduleOne.Tiles;
using ScheduleOne.UI.Management;
using UnityEngine;

namespace ScheduleOne.ObjectScripts
{
	// Token: 0x02000CA6 RID: 3238
	[Token(Token = "0x2000CA6")]
	public class DryingRack : GridItem, IUsable, IItemSlotOwner, ITransitEntity, IConfigurable
	{
		// Token: 0x17000C66 RID: 3174
		// (get) Token: 0x06005950 RID: 22864 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005951 RID: 22865 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C66")]
		public NetworkObject NPCUserObject
		{
			[Token(Token = "0x6005950")]
			[Address(RVA = "0x62FC90", Offset = "0x62E690", VA = "0x18062FC90", Slot = "72")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005951")]
			[Address(RVA = "0xA22EE0", Offset = "0xA218E0", VA = "0x180A22EE0", Slot = "73")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C67 RID: 3175
		// (get) Token: 0x06005952 RID: 22866 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005953 RID: 22867 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C67")]
		public NetworkObject PlayerUserObject
		{
			[Token(Token = "0x6005952")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00", Slot = "74")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005953")]
			[Address(RVA = "0xA230A0", Offset = "0xA21AA0", VA = "0x180A230A0", Slot = "75")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C68 RID: 3176
		// (get) Token: 0x06005954 RID: 22868 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005955 RID: 22869 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C68")]
		public List<ItemSlot> ItemSlots
		{
			[Token(Token = "0x6005954")]
			[Address(RVA = "0x62FC80", Offset = "0x62E680", VA = "0x18062FC80", Slot = "78")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005955")]
			[Address(RVA = "0x630250", Offset = "0x62EC50", VA = "0x180630250", Slot = "79")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C69 RID: 3177
		// (get) Token: 0x06005956 RID: 22870 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C69")]
		public string Name
		{
			[Token(Token = "0x6005956")]
			[Address(RVA = "0x9D7380", Offset = "0x9D5D80", VA = "0x1809D7380", Slot = "87")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6A RID: 3178
		// (get) Token: 0x06005957 RID: 22871 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005958 RID: 22872 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C6A")]
		public List<ItemSlot> InputSlots
		{
			[Token(Token = "0x6005957")]
			[Address(RVA = "0x8C8800", Offset = "0x8C7200", VA = "0x1808C8800", Slot = "88")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005958")]
			[Address(RVA = "0x8C8810", Offset = "0x8C7210", VA = "0x1808C8810", Slot = "89")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C6B RID: 3179
		// (get) Token: 0x06005959 RID: 22873 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600595A RID: 22874 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C6B")]
		public List<ItemSlot> OutputSlots
		{
			[Token(Token = "0x6005959")]
			[Address(RVA = "0xA280E0", Offset = "0xA26AE0", VA = "0x180A280E0", Slot = "90")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600595A")]
			[Address(RVA = "0xA28130", Offset = "0xA26B30", VA = "0x180A28130", Slot = "91")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C6C RID: 3180
		// (get) Token: 0x0600595B RID: 22875 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6C")]
		public Transform LinkOrigin
		{
			[Token(Token = "0x600595B")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0", Slot = "92")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6D RID: 3181
		// (get) Token: 0x0600595C RID: 22876 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C6D")]
		public Transform[] AccessPoints
		{
			[Token(Token = "0x600595C")]
			[Address(RVA = "0x9DC5E0", Offset = "0x9DAFE0", VA = "0x1809DC5E0", Slot = "93")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C6E RID: 3182
		// (get) Token: 0x0600595D RID: 22877 RVA: 0x00015EE8 File Offset: 0x000140E8
		[Token(Token = "0x17000C6E")]
		public bool Selectable
		{
			[Token(Token = "0x600595D")]
			[Address(RVA = "0xA280F0", Offset = "0xA26AF0", VA = "0x180A280F0", Slot = "94")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C6F RID: 3183
		// (get) Token: 0x0600595E RID: 22878 RVA: 0x00015F00 File Offset: 0x00014100
		// (set) Token: 0x0600595F RID: 22879 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C6F")]
		public bool IsAcceptingItems
		{
			[Token(Token = "0x600595E")]
			[Address(RVA = "0xA280C0", Offset = "0xA26AC0", VA = "0x180A280C0", Slot = "95")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x600595F")]
			[Address(RVA = "0xA28110", Offset = "0xA26B10", VA = "0x180A28110")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C70 RID: 3184
		// (get) Token: 0x06005960 RID: 22880 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C70")]
		public EntityConfiguration Configuration
		{
			[Token(Token = "0x6005960")]
			[Address(RVA = "0xA280B0", Offset = "0xA26AB0", VA = "0x180A280B0", Slot = "109")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C71 RID: 3185
		// (get) Token: 0x06005961 RID: 22881 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005962 RID: 22882 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C71")]
		protected DryingRackConfiguration stationConfiguration
		{
			[Token(Token = "0x6005961")]
			[Address(RVA = "0xA280B0", Offset = "0xA26AB0", VA = "0x180A280B0")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005962")]
			[Address(RVA = "0xA28170", Offset = "0xA26B70", VA = "0x180A28170")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C72 RID: 3186
		// (get) Token: 0x06005963 RID: 22883 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C72")]
		public ConfigurationReplicator ConfigReplicator
		{
			[Token(Token = "0x6005963")]
			[Address(RVA = "0x716CC0", Offset = "0x7156C0", VA = "0x180716CC0", Slot = "110")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C73 RID: 3187
		// (get) Token: 0x06005964 RID: 22884 RVA: 0x00015F18 File Offset: 0x00014118
		[Token(Token = "0x17000C73")]
		public EConfigurableType ConfigurableType
		{
			[Token(Token = "0x6005964")]
			[Address(RVA = "0xA280A0", Offset = "0xA26AA0", VA = "0x180A280A0", Slot = "111")]
			get
			{
				return EConfigurableType.Pot;
			}
		}

		// Token: 0x17000C74 RID: 3188
		// (get) Token: 0x06005965 RID: 22885 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005966 RID: 22886 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C74")]
		public WorldspaceUIElement WorldspaceUI
		{
			[Token(Token = "0x6005965")]
			[Address(RVA = "0xA28100", Offset = "0xA26B00", VA = "0x180A28100", Slot = "112")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005966")]
			[Address(RVA = "0xA28150", Offset = "0xA26B50", VA = "0x180A28150", Slot = "113")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x17000C75 RID: 3189
		// (get) Token: 0x06005967 RID: 22887 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005968 RID: 22888 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C75")]
		public NetworkObject CurrentPlayerConfigurer
		{
			[Token(Token = "0x6005967")]
			[Address(RVA = "0xA1CD80", Offset = "0xA1B780", VA = "0x180A1CD80", Slot = "114")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005968")]
			[Address(RVA = "0xA22DB0", Offset = "0xA217B0", VA = "0x180A22DB0", Slot = "115")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005969 RID: 22889 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005969")]
		[Address(RVA = "0xA26660", Offset = "0xA25060", VA = "0x180A26660", Slot = "129")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetConfigurer(NetworkObject player)
		{
		}

		// Token: 0x17000C76 RID: 3190
		// (get) Token: 0x0600596A RID: 22890 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C76")]
		public Sprite TypeIcon
		{
			[Token(Token = "0x600596A")]
			[Address(RVA = "0x716B70", Offset = "0x715570", VA = "0x180716B70", Slot = "117")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C77 RID: 3191
		// (get) Token: 0x0600596B RID: 22891 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C77")]
		public Transform Transform
		{
			[Token(Token = "0x600596B")]
			[Address(RVA = "0x506E30", Offset = "0x505830", VA = "0x180506E30", Slot = "118")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C78 RID: 3192
		// (get) Token: 0x0600596C RID: 22892 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x17000C78")]
		public Transform UIPoint
		{
			[Token(Token = "0x600596C")]
			[Address(RVA = "0x62FDF0", Offset = "0x62E7F0", VA = "0x18062FDF0", Slot = "119")]
			get
			{
				return null;
			}
		}

		// Token: 0x17000C79 RID: 3193
		// (get) Token: 0x0600596D RID: 22893 RVA: 0x00015F30 File Offset: 0x00014130
		[Token(Token = "0x17000C79")]
		public bool CanBeSelected
		{
			[Token(Token = "0x600596D")]
			[Address(RVA = "0x48DCC0", Offset = "0x48C6C0", VA = "0x18048DCC0", Slot = "121")]
			get
			{
				return default(bool);
			}
		}

		// Token: 0x17000C7A RID: 3194
		// (get) Token: 0x0600596E RID: 22894 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x0600596F RID: 22895 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7A")]
		public ItemSlot InputSlot
		{
			[Token(Token = "0x600596E")]
			[Address(RVA = "0x62FC60", Offset = "0x62E660", VA = "0x18062FC60")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x600596F")]
			[Address(RVA = "0x630230", Offset = "0x62EC30", VA = "0x180630230")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7B RID: 3195
		// (get) Token: 0x06005970 RID: 22896 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005971 RID: 22897 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7B")]
		public ItemSlot OutputSlot
		{
			[Token(Token = "0x6005970")]
			[Address(RVA = "0x62FC40", Offset = "0x62E640", VA = "0x18062FC40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005971")]
			[Address(RVA = "0x630210", Offset = "0x62EC10", VA = "0x180630210")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7C RID: 3196
		// (get) Token: 0x06005972 RID: 22898 RVA: 0x00015F48 File Offset: 0x00014148
		// (set) Token: 0x06005973 RID: 22899 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7C")]
		public bool IsOpen
		{
			[Token(Token = "0x6005972")]
			[Address(RVA = "0xA280D0", Offset = "0xA26AD0", VA = "0x180A280D0")]
			[CompilerGenerated]
			get
			{
				return default(bool);
			}
			[Token(Token = "0x6005973")]
			[Address(RVA = "0xA28120", Offset = "0xA26B20", VA = "0x180A28120")]
			[CompilerGenerated]
			private set
			{
			}
		}

		// Token: 0x17000C7D RID: 3197
		// (get) Token: 0x06005974 RID: 22900 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x06005975 RID: 22901 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7D")]
		public List<DryingOperation> DryingOperations
		{
			[Token(Token = "0x6005974")]
			[Address(RVA = "0x81BB40", Offset = "0x81A540", VA = "0x18081BB40")]
			[CompilerGenerated]
			get
			{
				return null;
			}
			[Token(Token = "0x6005975")]
			[Address(RVA = "0x81C440", Offset = "0x81AE40", VA = "0x18081C440")]
			[CompilerGenerated]
			set
			{
			}
		}

		// Token: 0x06005976 RID: 22902 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005976")]
		[Address(RVA = "0xA1F3E0", Offset = "0xA1DDE0", VA = "0x180A1F3E0", Slot = "47")]
		public override void Awake()
		{
		}

		// Token: 0x06005977 RID: 22903 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005977")]
		[Address(RVA = "0xA20660", Offset = "0xA1F060", VA = "0x180A20660", Slot = "66")]
		public override void InitializeGridItem(ItemInstance instance, Grid grid, Vector2 originCoordinate, int rotation, string GUID)
		{
		}

		// Token: 0x06005978 RID: 22904 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005978")]
		[Address(RVA = "0xA21320", Offset = "0xA1FD20", VA = "0x180A21320", Slot = "9")]
		public override void OnSpawnServer(NetworkConnection connection)
		{
		}

		// Token: 0x06005979 RID: 22905 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005979")]
		[Address(RVA = "0xA26500", Offset = "0xA24F00", VA = "0x180A26500", Slot = "130")]
		public void SendConfigurationToClient(NetworkConnection conn)
		{
		}

		// Token: 0x0600597A RID: 22906 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597A")]
		[Address(RVA = "0xA1FDD0", Offset = "0xA1E7D0", VA = "0x180A1FDD0")]
		private void Exit(ExitAction action)
		{
		}

		// Token: 0x0600597B RID: 22907 RVA: 0x00015F60 File Offset: 0x00014160
		[Token(Token = "0x600597B")]
		[Address(RVA = "0xA1F430", Offset = "0xA1DE30", VA = "0x180A1F430", Slot = "53")]
		public override bool CanBeDestroyed(out string reason)
		{
			return default(bool);
		}

		// Token: 0x0600597C RID: 22908 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597C")]
		[Address(RVA = "0xA1FB10", Offset = "0xA1E510", VA = "0x180A1FB10", Slot = "55")]
		public override void DestroyItem(bool callOnServer = true)
		{
		}

		// Token: 0x0600597D RID: 22909 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597D")]
		[Address(RVA = "0xA20930", Offset = "0xA1F330", VA = "0x180A20930")]
		private void MinPass()
		{
		}

		// Token: 0x0600597E RID: 22910 RVA: 0x00015F78 File Offset: 0x00014178
		[Token(Token = "0x600597E")]
		[Address(RVA = "0xA1F530", Offset = "0xA1DF30", VA = "0x180A1F530")]
		public bool CanStartOperation()
		{
			return default(bool);
		}

		// Token: 0x0600597F RID: 22911 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600597F")]
		[Address(RVA = "0xA27AF0", Offset = "0xA264F0", VA = "0x180A27AF0")]
		public void StartOperation()
		{
		}

		// Token: 0x06005980 RID: 22912 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005980")]
		[Address(RVA = "0xA27D60", Offset = "0xA26760", VA = "0x180A27D60")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void TryEndOperation(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
		}

		// Token: 0x06005981 RID: 22913 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005981")]
		[Address(RVA = "0xA200F0", Offset = "0xA1EAF0", VA = "0x180A200F0")]
		public List<DryingOperation> GetOperationsAtTargetQuality()
		{
			return null;
		}

		// Token: 0x06005982 RID: 22914 RVA: 0x00015F90 File Offset: 0x00014190
		[Token(Token = "0x6005982")]
		[Address(RVA = "0xA20260", Offset = "0xA1EC60", VA = "0x180A20260")]
		public int GetOutputCapacityForOperation(DryingOperation operation, EQuality quality)
		{
			return 0;
		}

		// Token: 0x06005983 RID: 22915 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005983")]
		[Address(RVA = "0xA252F0", Offset = "0xA23CF0", VA = "0x180A252F0")]
		[ServerRpc(RequireOwnership = false)]
		private void SendOperation(DryingOperation op)
		{
		}

		// Token: 0x06005984 RID: 22916 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005984")]
		[Address(RVA = "0xA21D00", Offset = "0xA20700", VA = "0x180A21D00")]
		[TargetRpc]
		[ObserversRpc]
		private void PleaseReceiveOp(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x06005985 RID: 22917 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005985")]
		[Address(RVA = "0xA22990", Offset = "0xA21390", VA = "0x180A22990")]
		[ObserversRpc(RunLocally = true, ExcludeServer = true)]
		private void RemoveOperation(int opIndex)
		{
		}

		// Token: 0x06005986 RID: 22918 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005986")]
		[Address(RVA = "0xA24CD0", Offset = "0xA236D0", VA = "0x180A24CD0")]
		[ObserversRpc]
		private void SetOperationQuantity(int opIndex, int quantity)
		{
		}

		// Token: 0x06005987 RID: 22919 RVA: 0x00015FA8 File Offset: 0x000141A8
		[Token(Token = "0x6005987")]
		[Address(RVA = "0xA20400", Offset = "0xA1EE00", VA = "0x180A20400")]
		public int GetTotalDryingItems()
		{
			return 0;
		}

		// Token: 0x06005988 RID: 22920 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005988")]
		[Address(RVA = "0xA220A0", Offset = "0xA20AA0", VA = "0x180A220A0")]
		public void RefreshHangingVisuals()
		{
		}

		// Token: 0x06005989 RID: 22921 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005989")]
		[Address(RVA = "0xA1F8E0", Offset = "0xA1E2E0", VA = "0x180A1F8E0", Slot = "123")]
		public WorldspaceUIElement CreateWorldspaceUI()
		{
			return null;
		}

		// Token: 0x0600598A RID: 22922 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598A")]
		[Address(RVA = "0xA1FD40", Offset = "0xA1E740", VA = "0x180A1FD40", Slot = "124")]
		public void DestroyWorldspaceUI()
		{
		}

		// Token: 0x0600598B RID: 22923 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598B")]
		[Address(RVA = "0xA26BE0", Offset = "0xA255E0", VA = "0x180A26BE0", Slot = "76")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetPlayerUser(NetworkObject playerObject)
		{
		}

		// Token: 0x0600598C RID: 22924 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598C")]
		[Address(RVA = "0xA26AB0", Offset = "0xA254B0", VA = "0x180A26AB0", Slot = "77")]
		[ServerRpc(RequireOwnership = false, RunLocally = true)]
		public void SetNPCUser(NetworkObject npcObject)
		{
		}

		// Token: 0x0600598D RID: 22925 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598D")]
		[Address(RVA = "0xA20520", Offset = "0xA1EF20", VA = "0x180A20520")]
		public void Hovered()
		{
		}

		// Token: 0x0600598E RID: 22926 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598E")]
		[Address(RVA = "0xA20880", Offset = "0xA1F280", VA = "0x180A20880")]
		public void Interacted()
		{
		}

		// Token: 0x0600598F RID: 22927 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600598F")]
		[Address(RVA = "0xA215E0", Offset = "0xA1FFE0", VA = "0x180A215E0")]
		public void Open()
		{
		}

		// Token: 0x06005990 RID: 22928 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005990")]
		[Address(RVA = "0xA1F5A0", Offset = "0xA1DFA0", VA = "0x180A1F5A0")]
		public void Close()
		{
		}

		// Token: 0x06005991 RID: 22929 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005991")]
		[Address(RVA = "0xA27950", Offset = "0xA26350", VA = "0x180A27950", Slot = "80")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetStoredInstance(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005992 RID: 22930 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005992")]
		[Address(RVA = "0xA27690", Offset = "0xA26090", VA = "0x180A27690")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetStoredInstance_Internal(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x06005993 RID: 22931 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005993")]
		[Address(RVA = "0xA26940", Offset = "0xA25340", VA = "0x180A26940", Slot = "81")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetItemSlotQuantity(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005994 RID: 22932 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005994")]
		[Address(RVA = "0xA26790", Offset = "0xA25190", VA = "0x180A26790")]
		[ObserversRpc(RunLocally = true)]
		private void SetItemSlotQuantity_Internal(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x06005995 RID: 22933 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005995")]
		[Address(RVA = "0xA274A0", Offset = "0xA25EA0", VA = "0x180A274A0", Slot = "82")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotLocked(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005996 RID: 22934 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005996")]
		[Address(RVA = "0xA27170", Offset = "0xA25B70", VA = "0x180A27170")]
		[TargetRpc(RunLocally = true)]
		[ObserversRpc(RunLocally = true)]
		private void SetSlotLocked_Internal(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x06005997 RID: 22935 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005997")]
		[Address(RVA = "0xA26FD0", Offset = "0xA259D0", VA = "0x180A26FD0", Slot = "83")]
		[ServerRpc(RunLocally = true, RequireOwnership = false)]
		public void SetSlotFilter(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005998 RID: 22936 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x6005998")]
		[Address(RVA = "0xA26D10", Offset = "0xA25710", VA = "0x180A26D10")]
		[ObserversRpc(RunLocally = true)]
		[TargetRpc(RunLocally = true)]
		private void SetSlotFilter_Internal(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x06005999 RID: 22937 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x6005999")]
		[Address(RVA = "0xA1FE20", Offset = "0xA1E820", VA = "0x180A1FE20", Slot = "60")]
		public override BuildableItemData GetBaseData()
		{
			return null;
		}

		// Token: 0x0600599A RID: 22938 RVA: 0x00002050 File Offset: 0x00000250
		[Token(Token = "0x600599A")]
		[Address(RVA = "0xA20350", Offset = "0xA1ED50", VA = "0x180A20350", Slot = "59")]
		public override DynamicSaveData GetSaveData()
		{
			return null;
		}

		// Token: 0x0600599B RID: 22939 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599B")]
		[Address(RVA = "0xA27F10", Offset = "0xA26910", VA = "0x180A27F10")]
		public DryingRack()
		{
		}

		// Token: 0x0600599C RID: 22940 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599C")]
		[Address(RVA = "0xA20B30", Offset = "0xA1F530", VA = "0x180A20B30", Slot = "62")]
		public override void NetworkInitialize___Early()
		{
		}

		// Token: 0x0600599D RID: 22941 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599D")]
		[Address(RVA = "0xA20AA0", Offset = "0xA1F4A0", VA = "0x180A20AA0", Slot = "63")]
		public override void NetworkInitialize__Late()
		{
		}

		// Token: 0x0600599E RID: 22942 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599E")]
		[Address(RVA = "0x669880", Offset = "0x668280", VA = "0x180669880", Slot = "14")]
		public override void NetworkInitializeIfDisabled()
		{
		}

		// Token: 0x0600599F RID: 22943 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x600599F")]
		[Address(RVA = "0xA25420", Offset = "0xA23E20", VA = "0x180A25420")]
		private void RpcWriter___Server_SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060059A0 RID: 22944 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A0")]
		[Address(RVA = "0xA22DB0", Offset = "0xA217B0", VA = "0x180A22DB0", Slot = "131")]
		public void RpcLogic___SetConfigurer_3323014238(NetworkObject player)
		{
		}

		// Token: 0x060059A1 RID: 22945 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A1")]
		[Address(RVA = "0xA23FC0", Offset = "0xA229C0", VA = "0x180A23FC0")]
		private void RpcReader___Server_SetConfigurer_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059A2 RID: 22946 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A2")]
		[Address(RVA = "0xA25DA0", Offset = "0xA247A0", VA = "0x180A25DA0")]
		private void RpcWriter___Server_TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
		}

		// Token: 0x060059A3 RID: 22947 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A3")]
		[Address(RVA = "0xA234B0", Offset = "0xA21EB0", VA = "0x180A234B0")]
		public void RpcLogic___TryEndOperation_4146970406(int operationIndex, bool allowSplitting, EQuality quality, int requestID)
		{
		}

		// Token: 0x060059A4 RID: 22948 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A4")]
		[Address(RVA = "0xA24520", Offset = "0xA22F20", VA = "0x180A24520")]
		private void RpcReader___Server_TryEndOperation_4146970406(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059A5 RID: 22949 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A5")]
		[Address(RVA = "0xA252F0", Offset = "0xA23CF0", VA = "0x180A252F0")]
		private void RpcWriter___Server_SendOperation_1307702229(DryingOperation op)
		{
		}

		// Token: 0x060059A6 RID: 22950 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A6")]
		[Address(RVA = "0xA22DA0", Offset = "0xA217A0", VA = "0x180A22DA0")]
		private void RpcLogic___SendOperation_1307702229(DryingOperation op)
		{
		}

		// Token: 0x060059A7 RID: 22951 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A7")]
		[Address(RVA = "0xA23F70", Offset = "0xA22970", VA = "0x180A23F70")]
		private void RpcReader___Server_SendOperation_1307702229(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059A8 RID: 22952 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A8")]
		[Address(RVA = "0xA25F30", Offset = "0xA24930", VA = "0x180A25F30")]
		private void RpcWriter___Target_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x060059A9 RID: 22953 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059A9")]
		[Address(RVA = "0xA22AE0", Offset = "0xA214E0", VA = "0x180A22AE0")]
		private void RpcLogic___PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x060059AA RID: 22954 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AA")]
		[Address(RVA = "0xA24620", Offset = "0xA23020", VA = "0x180A24620")]
		private void RpcReader___Target_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059AB RID: 22955 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AB")]
		[Address(RVA = "0xA248C0", Offset = "0xA232C0", VA = "0x180A248C0")]
		private void RpcWriter___Observers_PleaseReceiveOp_1575047616(NetworkConnection conn, DryingOperation op)
		{
		}

		// Token: 0x060059AC RID: 22956 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AC")]
		[Address(RVA = "0xA23A80", Offset = "0xA22480", VA = "0x180A23A80")]
		private void RpcReader___Observers_PleaseReceiveOp_1575047616(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059AD RID: 22957 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AD")]
		[Address(RVA = "0xA24A00", Offset = "0xA23400", VA = "0x180A24A00")]
		private void RpcWriter___Observers_RemoveOperation_3316948804(int opIndex)
		{
		}

		// Token: 0x060059AE RID: 22958 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AE")]
		[Address(RVA = "0xA22C40", Offset = "0xA21640", VA = "0x180A22C40")]
		private void RpcLogic___RemoveOperation_3316948804(int opIndex)
		{
		}

		// Token: 0x060059AF RID: 22959 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059AF")]
		[Address(RVA = "0xA23AD0", Offset = "0xA224D0", VA = "0x180A23AD0")]
		private void RpcReader___Observers_RemoveOperation_3316948804(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059B0 RID: 22960 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B0")]
		[Address(RVA = "0xA24CD0", Offset = "0xA236D0", VA = "0x180A24CD0")]
		private void RpcWriter___Observers_SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
		}

		// Token: 0x060059B1 RID: 22961 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B1")]
		[Address(RVA = "0xA22F80", Offset = "0xA21980", VA = "0x180A22F80")]
		private void RpcLogic___SetOperationQuantity_1692629761(int opIndex, int quantity)
		{
		}

		// Token: 0x060059B2 RID: 22962 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B2")]
		[Address(RVA = "0xA23BE0", Offset = "0xA225E0", VA = "0x180A23BE0")]
		private void RpcReader___Observers_SetOperationQuantity_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059B3 RID: 22963 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B3")]
		[Address(RVA = "0xA25800", Offset = "0xA24200", VA = "0x180A25800")]
		private void RpcWriter___Server_SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060059B4 RID: 22964 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B4")]
		[Address(RVA = "0xA230A0", Offset = "0xA21AA0", VA = "0x180A230A0", Slot = "132")]
		public void RpcLogic___SetPlayerUser_3323014238(NetworkObject playerObject)
		{
		}

		// Token: 0x060059B5 RID: 22965 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B5")]
		[Address(RVA = "0xA24170", Offset = "0xA22B70", VA = "0x180A24170")]
		private void RpcReader___Server_SetPlayerUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059B6 RID: 22966 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B6")]
		[Address(RVA = "0xA256D0", Offset = "0xA240D0", VA = "0x180A256D0")]
		private void RpcWriter___Server_SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060059B7 RID: 22967 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B7")]
		[Address(RVA = "0xA22EE0", Offset = "0xA218E0", VA = "0x180A22EE0", Slot = "133")]
		public void RpcLogic___SetNPCUser_3323014238(NetworkObject npcObject)
		{
		}

		// Token: 0x060059B8 RID: 22968 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B8")]
		[Address(RVA = "0xA240F0", Offset = "0xA22AF0", VA = "0x180A240F0")]
		private void RpcReader___Server_SetNPCUser_3323014238(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059B9 RID: 22969 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059B9")]
		[Address(RVA = "0xA25C30", Offset = "0xA24630", VA = "0x180A25C30")]
		private void RpcWriter___Server_SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060059BA RID: 22970 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BA")]
		[Address(RVA = "0xA23370", Offset = "0xA21D70", VA = "0x180A23370", Slot = "134")]
		public void RpcLogic___SetStoredInstance_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060059BB RID: 22971 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BB")]
		[Address(RVA = "0xA24430", Offset = "0xA22E30", VA = "0x180A24430")]
		private void RpcReader___Server_SetStoredInstance_2652194801(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059BC RID: 22972 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BC")]
		[Address(RVA = "0xA25170", Offset = "0xA23B70", VA = "0x180A25170")]
		private void RpcWriter___Observers_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060059BD RID: 22973 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BD")]
		[Address(RVA = "0xA233F0", Offset = "0xA21DF0", VA = "0x180A233F0")]
		private void RpcLogic___SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060059BE RID: 22974 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BE")]
		[Address(RVA = "0xA23EE0", Offset = "0xA228E0", VA = "0x180A23EE0")]
		private void RpcReader___Observers_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059BF RID: 22975 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059BF")]
		[Address(RVA = "0xA26390", Offset = "0xA24D90", VA = "0x180A26390")]
		private void RpcWriter___Target_SetStoredInstance_Internal_2652194801(NetworkConnection conn, int itemSlotIndex, ItemInstance instance)
		{
		}

		// Token: 0x060059C0 RID: 22976 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C0")]
		[Address(RVA = "0xA24820", Offset = "0xA23220", VA = "0x180A24820")]
		private void RpcReader___Target_SetStoredInstance_Internal_2652194801(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059C1 RID: 22977 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C1")]
		[Address(RVA = "0xA25550", Offset = "0xA23F50", VA = "0x180A25550")]
		private void RpcWriter___Server_SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060059C2 RID: 22978 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C2")]
		[Address(RVA = "0xA22E50", Offset = "0xA21850", VA = "0x180A22E50", Slot = "135")]
		public void RpcLogic___SetItemSlotQuantity_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060059C3 RID: 22979 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C3")]
		[Address(RVA = "0xA24040", Offset = "0xA22A40", VA = "0x180A24040")]
		private void RpcReader___Server_SetItemSlotQuantity_1692629761(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059C4 RID: 22980 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C4")]
		[Address(RVA = "0xA24B50", Offset = "0xA23550", VA = "0x180A24B50")]
		private void RpcWriter___Observers_SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060059C5 RID: 22981 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C5")]
		[Address(RVA = "0xA22E60", Offset = "0xA21860", VA = "0x180A22E60")]
		private void RpcLogic___SetItemSlotQuantity_Internal_1692629761(int itemSlotIndex, int quantity)
		{
		}

		// Token: 0x060059C6 RID: 22982 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C6")]
		[Address(RVA = "0xA23B40", Offset = "0xA22540", VA = "0x180A23B40")]
		private void RpcReader___Observers_SetItemSlotQuantity_Internal_1692629761(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059C7 RID: 22983 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C7")]
		[Address(RVA = "0xA25AA0", Offset = "0xA244A0", VA = "0x180A25AA0")]
		private void RpcWriter___Server_SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060059C8 RID: 22984 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C8")]
		[Address(RVA = "0xA23240", Offset = "0xA21C40", VA = "0x180A23240", Slot = "136")]
		public void RpcLogic___SetSlotLocked_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060059C9 RID: 22985 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059C9")]
		[Address(RVA = "0xA242E0", Offset = "0xA22CE0", VA = "0x180A242E0")]
		private void RpcReader___Server_SetSlotLocked_3170825843(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059CA RID: 22986 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CA")]
		[Address(RVA = "0xA26200", Offset = "0xA24C00", VA = "0x180A26200")]
		private void RpcWriter___Target_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060059CB RID: 22987 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CB")]
		[Address(RVA = "0xA232C0", Offset = "0xA21CC0", VA = "0x180A232C0")]
		private void RpcLogic___SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060059CC RID: 22988 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CC")]
		[Address(RVA = "0xA24720", Offset = "0xA23120", VA = "0x180A24720")]
		private void RpcReader___Target_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059CD RID: 22989 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CD")]
		[Address(RVA = "0xA24FD0", Offset = "0xA239D0", VA = "0x180A24FD0")]
		private void RpcWriter___Observers_SetSlotLocked_Internal_3170825843(NetworkConnection conn, int itemSlotIndex, bool locked, NetworkObject lockOwner, string lockReason)
		{
		}

		// Token: 0x060059CE RID: 22990 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CE")]
		[Address(RVA = "0xA23DF0", Offset = "0xA227F0", VA = "0x180A23DF0")]
		private void RpcReader___Observers_SetSlotLocked_Internal_3170825843(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059CF RID: 22991 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059CF")]
		[Address(RVA = "0xA25930", Offset = "0xA24330", VA = "0x180A25930")]
		private void RpcWriter___Server_SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060059D0 RID: 22992 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D0")]
		[Address(RVA = "0xA23140", Offset = "0xA21B40", VA = "0x180A23140", Slot = "137")]
		public void RpcLogic___SetSlotFilter_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060059D1 RID: 22993 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D1")]
		[Address(RVA = "0xA241F0", Offset = "0xA22BF0", VA = "0x180A241F0")]
		private void RpcReader___Server_SetSlotFilter_527532783(PooledReader PooledReader0, Channel channel, NetworkConnection conn)
		{
		}

		// Token: 0x060059D2 RID: 22994 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D2")]
		[Address(RVA = "0xA24E50", Offset = "0xA23850", VA = "0x180A24E50")]
		private void RpcWriter___Observers_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060059D3 RID: 22995 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D3")]
		[Address(RVA = "0xA231C0", Offset = "0xA21BC0", VA = "0x180A231C0")]
		private void RpcLogic___SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060059D4 RID: 22996 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D4")]
		[Address(RVA = "0xA23D60", Offset = "0xA22760", VA = "0x180A23D60")]
		private void RpcReader___Observers_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x060059D5 RID: 22997 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D5")]
		[Address(RVA = "0xA26090", Offset = "0xA24A90", VA = "0x180A26090")]
		private void RpcWriter___Target_SetSlotFilter_Internal_527532783(NetworkConnection conn, int itemSlotIndex, SlotFilter filter)
		{
		}

		// Token: 0x060059D6 RID: 22998 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059D6")]
		[Address(RVA = "0xA24680", Offset = "0xA23080", VA = "0x180A24680")]
		private void RpcReader___Target_SetSlotFilter_Internal_527532783(PooledReader PooledReader0, Channel channel)
		{
		}

		// Token: 0x17000C7E RID: 3198
		// (get) Token: 0x060059D7 RID: 22999 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059D8 RID: 23000 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7E")]
		public NetworkObject SyncAccessor_<NPCUserObject>k__BackingField
		{
			[Token(Token = "0x60059D7")]
			[Address(RVA = "0x62FC90", Offset = "0x62E690", VA = "0x18062FC90")]
			get
			{
				return null;
			}
			[Token(Token = "0x60059D8")]
			[Address(RVA = "0xA28250", Offset = "0xA26C50", VA = "0x180A28250")]
			set
			{
			}
		}

		// Token: 0x060059D9 RID: 23001 RVA: 0x00015FC0 File Offset: 0x000141C0
		[Token(Token = "0x60059D9")]
		[Address(RVA = "0xA21F00", Offset = "0xA20900", VA = "0x180A21F00", Slot = "138")]
		public virtual bool ReadSyncVar___ScheduleOne.ObjectScripts.DryingRack(PooledReader PooledReader0, uint UInt321, bool Boolean2)
		{
			return default(bool);
		}

		// Token: 0x17000C7F RID: 3199
		// (get) Token: 0x060059DA RID: 23002 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059DB RID: 23003 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C7F")]
		public NetworkObject SyncAccessor_<PlayerUserObject>k__BackingField
		{
			[Token(Token = "0x60059DA")]
			[Address(RVA = "0x62FE00", Offset = "0x62E800", VA = "0x18062FE00")]
			get
			{
				return null;
			}
			[Token(Token = "0x60059DB")]
			[Address(RVA = "0xA28310", Offset = "0xA26D10", VA = "0x180A28310")]
			set
			{
			}
		}

		// Token: 0x17000C80 RID: 3200
		// (get) Token: 0x060059DC RID: 23004 RVA: 0x00002050 File Offset: 0x00000250
		// (set) Token: 0x060059DD RID: 23005 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x17000C80")]
		public NetworkObject SyncAccessor_<CurrentPlayerConfigurer>k__BackingField
		{
			[Token(Token = "0x60059DC")]
			[Address(RVA = "0xA1CD80", Offset = "0xA1B780", VA = "0x180A1CD80")]
			get
			{
				return null;
			}
			[Token(Token = "0x60059DD")]
			[Address(RVA = "0xA28190", Offset = "0xA26B90", VA = "0x180A28190")]
			set
			{
			}
		}

		// Token: 0x060059DE RID: 23006 RVA: 0x00002053 File Offset: 0x00000253
		[Token(Token = "0x60059DE")]
		[Address(RVA = "0xA1F080", Offset = "0xA1DA80", VA = "0x180A1F080", Slot = "139")]
		protected virtual void Awake_UserLogic_ScheduleOne.ObjectScripts.DryingRack_Assembly-CSharp.dll()
		{
		}

		// Token: 0x040041B0 RID: 16816
		[Token(Token = "0x40041B0")]
		public const int DRY_MINS_PER_TIER = 720;

		// Token: 0x040041B1 RID: 16817
		[Token(Token = "0x40041B1")]
		[FieldOffset(Offset = "0x218")]
		[Header("Settings")]
		public int ItemCapacity;

		// Token: 0x040041B2 RID: 16818
		[Token(Token = "0x40041B2")]
		[FieldOffset(Offset = "0x220")]
		[Header("References")]
		public Transform[] CameraPositions;

		// Token: 0x040041B3 RID: 16819
		[Token(Token = "0x40041B3")]
		[FieldOffset(Offset = "0x228")]
		public InteractableObject IntObj;

		// Token: 0x040041B4 RID: 16820
		[Token(Token = "0x40041B4")]
		[FieldOffset(Offset = "0x230")]
		public Transform uiPoint;

		// Token: 0x040041B5 RID: 16821
		[Token(Token = "0x40041B5")]
		[FieldOffset(Offset = "0x238")]
		public Transform[] accessPoints;

		// Token: 0x040041B6 RID: 16822
		[Token(Token = "0x40041B6")]
		[FieldOffset(Offset = "0x240")]
		public StorageVisualizer InputVisuals;

		// Token: 0x040041B7 RID: 16823
		[Token(Token = "0x40041B7")]
		[FieldOffset(Offset = "0x248")]
		public StorageVisualizer OutputVisuals;

		// Token: 0x040041B8 RID: 16824
		[Token(Token = "0x40041B8")]
		[FieldOffset(Offset = "0x250")]
		public StorageVisualizer HangingVisuals;

		// Token: 0x040041B9 RID: 16825
		[Token(Token = "0x40041B9")]
		[FieldOffset(Offset = "0x258")]
		public Transform[] HangAlignments;

		// Token: 0x040041BA RID: 16826
		[Token(Token = "0x40041BA")]
		[FieldOffset(Offset = "0x260")]
		public ConfigurationReplicator configReplicator;

		// Token: 0x040041BB RID: 16827
		[Token(Token = "0x40041BB")]
		[FieldOffset(Offset = "0x268")]
		[Header("UI")]
		public DryingRackUIElement WorldspaceUIPrefab;

		// Token: 0x040041BC RID: 16828
		[Token(Token = "0x40041BC")]
		[FieldOffset(Offset = "0x270")]
		public Sprite typeIcon;

		// Token: 0x040041CB RID: 16843
		[Token(Token = "0x40041CB")]
		[FieldOffset(Offset = "0x2E0")]
		public Action<DryingOperation> onOperationStart;

		// Token: 0x040041CC RID: 16844
		[Token(Token = "0x40041CC")]
		[FieldOffset(Offset = "0x2E8")]
		public Action<DryingOperation> onOperationComplete;

		// Token: 0x040041CD RID: 16845
		[Token(Token = "0x40041CD")]
		[FieldOffset(Offset = "0x2F0")]
		public Action onOperationsChanged;

		// Token: 0x040041CE RID: 16846
		[Token(Token = "0x40041CE")]
		[FieldOffset(Offset = "0x2F8")]
		private ItemSlot[] hangSlots;

		// Token: 0x040041CF RID: 16847
		[Token(Token = "0x40041CF")]
		[FieldOffset(Offset = "0x300")]
		private List<int> requestIDs;

		// Token: 0x040041D0 RID: 16848
		[Token(Token = "0x40041D0")]
		[FieldOffset(Offset = "0x308")]
		public SyncVar<NetworkObject> syncVar___<NPCUserObject>k__BackingField;

		// Token: 0x040041D1 RID: 16849
		[Token(Token = "0x40041D1")]
		[FieldOffset(Offset = "0x310")]
		public SyncVar<NetworkObject> syncVar___<PlayerUserObject>k__BackingField;

		// Token: 0x040041D2 RID: 16850
		[Token(Token = "0x40041D2")]
		[FieldOffset(Offset = "0x318")]
		public SyncVar<NetworkObject> syncVar___<CurrentPlayerConfigurer>k__BackingField;

		// Token: 0x040041D3 RID: 16851
		[Token(Token = "0x40041D3")]
		[FieldOffset(Offset = "0x320")]
		private bool NetworkInitialize___EarlyScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted;

		// Token: 0x040041D4 RID: 16852
		[Token(Token = "0x40041D4")]
		[FieldOffset(Offset = "0x321")]
		private bool NetworkInitialize__LateScheduleOne.ObjectScripts.DryingRackAssembly-CSharp.dll_Excuted;
	}
}
