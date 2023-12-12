﻿#region License
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
#endregion

namespace Arcemi.Models
{
    public static class ItemTypeExtensions
    {
        public static string AsDisplayable(this ItemType type)
        {
            return type.ToString();
        }

        public static bool IsEnchantable(this ItemType? type)
        {
            switch (type) {
                case ItemType.Weapon:
                case ItemType.Armor:
                case ItemType.Shield:
                    return true;
            }
            return false;
        }
    }
}
