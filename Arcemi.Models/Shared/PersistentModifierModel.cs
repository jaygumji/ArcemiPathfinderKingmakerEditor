﻿#region License
/* This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/. */
 #endregion
namespace Arcemi.Models
{
    public class PersistentModifierModel : RefModel
    {
        public PersistentModifierModel(ModelDataAccessor accessor) : base(accessor)
        {
        }

        public int ModValue { get => A.Value<int>(); set => A.Value(value); }
        public string ModDescriptor { get => A.Value<string>(); set => A.Value(value); }
    }
}