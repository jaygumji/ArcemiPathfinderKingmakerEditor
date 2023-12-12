﻿namespace Arcemi.Models.Warhammer40KRogueTrader
{
    public class W40KRTGameUnitPortraitModel : IGameUnitPortraitModel
    {
        private readonly IGameResourcesProvider Res = GameDefinition.Warhammer40K_RogueTrader.Resources;
        private readonly string unitBlueprint;

        public W40KRTGameUnitPortraitModel(UnitUISettingsPartItemModel uiSettings, string unitBlueprint)
        {
            UiSettings = uiSettings;
            this.unitBlueprint = unitBlueprint;
        }

        public UnitUISettingsPartItemModel UiSettings { get; }

        public string Blueprint => UiSettings.m_Portrait;

        public string Path
        {
            get {
                if (!string.IsNullOrEmpty(UiSettings.m_CustomPortrait?.CustomPortraitId)) {
                    return Res.GetPortraitsUri(UiSettings.m_CustomPortrait.CustomPortraitId);
                }
                if (!string.IsNullOrEmpty(Blueprint)) {
                    return Res.GetPortraitsUri(Blueprint);
                }
                if (Res.TryGetPortraitsUri(unitBlueprint, out var uri)) {
                    return uri;
                }
                var portraitId = Res.GetCharacterPotraitIdentifier(unitBlueprint);
                return Res.GetPortraitsUri(portraitId);
            }
        }

        public bool IsSupported => UiSettings is object;

        public void Set(Portrait portrait)
        {
            var accessor = UiSettings.GetAccessor();
            if (portrait.IsCompanion) {
                accessor.Value(null, "m_Portrait");
                accessor.SetObjectToNull("m_CustomPortrait");
            }
            else if (portrait.IsCustom) {
                accessor.Value(null, "m_Portrait");
                var c = accessor.Object("m_CustomPortrait", a => new CustomPortraitModel(a), createIfNull: true);
                c.CustomPortraitId = portrait.Key;
            }
            else {
                accessor.Value(portrait.Key, "m_Portrait");
                accessor.SetObjectToNull("m_CustomPortrait");
            }
        }
    }
}