﻿using System.Collections.Generic;
using System.Linq;

namespace Arcemi.Models.Warhammer40KRogueTrader
{
    public class W40KRTGameSharedInventoryModel : IGameInventoryModel
    {
        private readonly IGameResourcesProvider Res = GameDefinition.Warhammer40K_RogueTrader.Resources;

        public W40KRTGameSharedInventoryModel(RefModel inventory)
        {
            Ref = inventory?.GetAccessor().Object<RefModel>("CollectionConverter");
            if (IsSupported) {
                A = Ref?.GetAccessor();
                Items = new GameModelCollection<IGameItemEntry, RefModel>(A.List<RefModel>("m_Items"), x => new W40RTGameItemEntry(x), IsValidItem, new W40KRTGameInventoryItemWriter(Ref));
            }
        }
        public RefModel Ref { get; }
        private ModelDataAccessor A { get; }

        private bool IsValidItem(RefModel i)
        {
            if (i.GetAccessor().Value<string>("m_WielderRef").HasValue()) return false;
            return true;
        }

        public bool IsSupported => Ref is object;
        public IGameModelCollection<IGameItemEntry> Items { get; }
        public IReadOnlyList<BlueprintType> AddableTypes { get; } = new[] {
           W40KRTBlueprintTypeProvider.ItemEquipmentFeet,
           W40KRTBlueprintTypeProvider.ItemEquipmentGloves,
           W40KRTBlueprintTypeProvider.ItemEquipmentHead,
           W40KRTBlueprintTypeProvider.ItemEquipmentNeck,
           W40KRTBlueprintTypeProvider.ItemEquipmentRing,
           W40KRTBlueprintTypeProvider.ItemEquipmentShoulders,
           W40KRTBlueprintTypeProvider.ItemEquipmentUsable,
           W40KRTBlueprintTypeProvider.ItemKey,
           W40KRTBlueprintTypeProvider.ItemNote,
           W40KRTBlueprintTypeProvider.Item,
           W40KRTBlueprintTypeProvider.ItemArmor,
           W40KRTBlueprintTypeProvider.ItemWeapon,
           //W40KRTBlueprintTypeProvider.ItemArmorPlating,
           //W40KRTBlueprintTypeProvider.ItemAugerArray,
           //W40KRTBlueprintTypeProvider.ItemLifeSustainer,
           //W40KRTBlueprintTypeProvider.ItemMechadendrite,
           //W40KRTBlueprintTypeProvider.ItemPlasmaDrives,
           //W40KRTBlueprintTypeProvider.ItemResourceMiner,
           //W40KRTBlueprintTypeProvider.ItemVoidShieldGenerator,
        };

        public IEnumerable<IBlueprintMetadataEntry> GetAddableItems(string typeFullName = null)
        {
            return typeFullName.HasValue()
                ? Res.Blueprints.GetEntries(typeFullName)
                : AddableTypes.SelectMany(t => Res.Blueprints.GetEntries(t));
        }
    }
}